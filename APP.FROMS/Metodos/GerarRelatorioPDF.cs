using System;
using System.Collections.Generic;
using System.IO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using APP.FROMS.Class;
using System.Threading.Tasks;

namespace APP.FROMS.Metodos
{
    public class GeradorRelatorioPDF
    {
        public async Task GerarPDFAsync(string caminhoArquivo, IEnumerable<RelatorioDetalhado> dadosRelatorio)
        {
            await Task.Run(() =>
            {

                using (var document = new PdfDocument())
                {
                    var page = document.AddPage();
                    var graphics = XGraphics.FromPdfPage(page);
                    var font = new XFont("Verdana", 10, XFontStyle.Regular);
            



                    int linha = 1;

                    
                    graphics.DrawString("Mês", font, XBrushes.Black, new XRect(50, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);
                    graphics.DrawString("Total Vendas", font, XBrushes.Black, new XRect(150, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);
                    graphics.DrawString("Total Compras", font, XBrushes.Black, new XRect(250, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);

                    linha++;

                  
                    foreach (var item in dadosRelatorio)
                    {
                        DateTime mes = (DateTime)item.Mes; 
                        var mesFormatado = mes.FormatarMesAno();

                        graphics.DrawString(mesFormatado, font, XBrushes.Black, new XRect(50, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);
                        graphics.DrawString(item.TotalVenda.ToString("C"), font, XBrushes.Black, new XRect(150, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);
                        graphics.DrawString(item.TotalCompra.ToString("C"), font, XBrushes.Black, new XRect(250, linha * 30, page.Width - 100, page.Height - 50), XStringFormats.TopLeft);

                        linha++;
                    }

                    document.Save(caminhoArquivo);
                }
            });
        }
    }
}
