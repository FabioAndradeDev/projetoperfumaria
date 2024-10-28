using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.FROMS.Class
{
    internal class RelatorioFinanceiroDadoscs
    {
        private string _connectionString;

        public RelatorioFinanceiroDadoscs(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método que retorna um relatório detalhado
        public async Task<IEnumerable<RelatorioDetalhado>> ObterDadosRelatorioDetalhadoAsync()
        {
            var relatorios = new List<RelatorioDetalhado>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = @"
                SELECT
                    COALESCE(v.DataVenda, c.DataCompra) AS Data,
                    COALESCE(v.TotalVenda, 0) AS TotalVenda,
                    COALESCE(c.TotalCompra, 0) AS TotalCompra,
                    (COALESCE(v.TotalVenda, 0) - COALESCE(c.TotalCompra, 0)) AS Lucro
                FROM
                    (SELECT DataVenda, SUM(TotalVenda) AS TotalVenda FROM Vendas GROUP BY DataVenda) AS v
                LEFT JOIN
                    (SELECT DataCompra, SUM(TotalCompra) AS TotalCompra FROM Compras GROUP BY DataCompra) AS c
                ON MONTH(v.DataVenda) = MONTH(c.DataCompra)
                UNION
                SELECT
                    COALESCE(v.DataVenda, c.DataCompra) AS Data,
                    COALESCE(v.TotalVenda, 0) AS TotalVenda,
                    COALESCE(c.TotalCompra, 0) AS TotalCompra,
                    (COALESCE(v.TotalVenda, 0) - COALESCE(c.TotalCompra, 0)) AS Lucro
                FROM
                    (SELECT DataVenda, SUM(TotalVenda) AS TotalVenda FROM Vendas GROUP BY DataVenda) AS v
                RIGHT JOIN
                    (SELECT DataCompra, SUM(TotalCompra) AS TotalCompra FROM Compras GROUP BY DataCompra) AS c
                ON MONTH(v.DataVenda) = MONTH(c.DataCompra)
                WHERE v.DataVenda IS NULL;
                ";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var relatorio = new RelatorioDetalhado
                            {
                                DataVenda = reader.IsDBNull(reader.GetOrdinal("Data")) ? default(DateTime) : reader.GetDateTime("Data"),
                                TotalVenda = reader.GetDecimal("TotalVenda"),
                                TotalCompra = reader.GetDecimal("TotalCompra"),
                                Lucro = reader.GetDecimal("Lucro")
                            };
                            relatorios.Add(relatorio);
                        }
                    }
                }
            }

            return relatorios;
        }
    }
}
