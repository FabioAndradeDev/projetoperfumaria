create table RelatoriosFinanceiros
(
    RelatorioID   int auto_increment
        primary key,
    DataRelatorio datetime       not null,
    Descricao     text           null,
    Valor         decimal(10, 2) not null
);

