using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BE;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Servicios
{
    public class PDF
    {
        
        public void pdf()
        {


        }
        public void GenerarPrimerTabla(List<BEInformeEmpleado> listadoinformes)
        {

            Document pdoc = new Document(iTextSharp.text.PageSize.A4, 20f, 20f, 30f, 30f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("D:\\Informe.pdf", FileMode.Create));
            pdoc.Open();
            PdfPTable pdftable = new PdfPTable(3);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            Font texto = new Font(bf, 10, Font.NORMAL);
            PdfPCell cell = new PdfPCell(new Phrase("Empleado"));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            PdfPCell cell1 = new PdfPCell(new Phrase("WO Asignadas"));
            cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            PdfPCell cell2 = new PdfPCell(new Phrase("WO Cerradas"));
            cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            pdftable.AddCell(cell);
            pdftable.AddCell(cell1);
            pdftable.AddCell(cell2);

            foreach (BEInformeEmpleado informe in listadoinformes)
            {
                pdftable.AddCell(new Phrase(informe.Usuario.ToString()));
                pdftable.AddCell(new Phrase(informe.CasosAbiertos.ToString()));
                pdftable.AddCell(new Phrase(informe.CasosCerrados.ToString()));
            }
            
            pdoc.Add(pdftable);
            pdoc.Close();
        }
    }


}
