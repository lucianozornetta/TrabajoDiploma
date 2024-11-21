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
        public void GenerarPrimerTabla(List<BEInformeEmpleado> listadoinformes , BEInformeAbiertoCerrado informearea)
        {
           
            Document pdoc = new Document(iTextSharp.text.PageSize.A4, 20f, 20f, 30f, 30f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("Informe.pdf", FileMode.Create));
            pdoc.Open();

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            Font tituloFont = new Font(bf, 14, Font.BOLD);
            Font texto = new Font(bf, 10, Font.NORMAL);

            // Título de la primera tabla
            pdoc.Add(new Paragraph("Informe de Casos Asignados y Resueltos", tituloFont));
            pdoc.Add(new Paragraph("\n"));

            // Primera tabla
            PdfPTable pdftable = new PdfPTable(3);
            pdftable.WidthPercentage = 100;
            pdftable.SetWidths(new float[] { 2f, 1f, 1f });

            PdfPCell cell = new PdfPCell(new Phrase("Empleado", texto));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cell1 = new PdfPCell(new Phrase("WO Asignadas", texto));
            cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cell2 = new PdfPCell(new Phrase("WO Cerradas", texto));
            cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;

            pdftable.AddCell(cell);
            pdftable.AddCell(cell1);
            pdftable.AddCell(cell2);

            bool esPar = true;
            foreach (BEInformeEmpleado informe in listadoinformes)
            {
                BaseColor backgroundColor = esPar ? BaseColor.LIGHT_GRAY : BaseColor.WHITE;
                pdftable.AddCell(new PdfPCell(new Phrase(informe.Usuario.ToString())) { BackgroundColor = backgroundColor });
                pdftable.AddCell(new PdfPCell(new Phrase(informe.CasosAbiertos.ToString())) { BackgroundColor = backgroundColor });
                pdftable.AddCell(new PdfPCell(new Phrase(informe.CasosCerrados.ToString())) { BackgroundColor = backgroundColor });

                esPar = !esPar;
            }

            pdoc.Add(pdftable);
            pdoc.Add(new Paragraph("\n"));

            // Título de la segunda tabla
            pdoc.Add(new Paragraph("Informe de Casos Cerrados", tituloFont));
            pdoc.Add(new Paragraph("\n"));

            // Segunda tabla
            PdfPTable pdftable2 = new PdfPTable(3);
            pdftable2.WidthPercentage = 100;
            pdftable2.SetWidths(new float[] { 2f, 1f, 1f });

            cell = new PdfPCell(new Phrase("Empleado", texto));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            cell1 = new PdfPCell(new Phrase("Dentro de SLA", texto));
            cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;

            cell2 = new PdfPCell(new Phrase("Fuera de SLA", texto));
            cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;

            pdftable2.AddCell(cell);
            pdftable2.AddCell(cell1);
            pdftable2.AddCell(cell2);

            esPar = true;
            foreach (BEInformeEmpleado informe in listadoinformes)
            {
                BaseColor backgroundColor = esPar ? BaseColor.LIGHT_GRAY: BaseColor.WHITE;
                pdftable2.AddCell(new PdfPCell(new Phrase(informe.Usuario.ToString())) { BackgroundColor = backgroundColor });
                pdftable2.AddCell(new PdfPCell(new Phrase(informe.DentroDeSLA.ToString())) { BackgroundColor = backgroundColor });
                pdftable2.AddCell(new PdfPCell(new Phrase(informe.FueraDeSLA.ToString())) { BackgroundColor = backgroundColor });

                esPar = !esPar;
            }

            pdoc.Add(pdftable2);


            pdoc.Add(new Paragraph("\n"));

            
            pdoc.Add(new Paragraph("Informe de Area", tituloFont));
            pdoc.Add(new Paragraph("\n"));

            PdfPTable pdftable3 = new PdfPTable(3);
            pdftable3.WidthPercentage = 100;
            pdftable3.SetWidths(new float[] { 2f, 1f, 1f });

            cell = new PdfPCell(new Phrase("Area", texto));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            cell1 = new PdfPCell(new Phrase("WO Abiertas", texto));
            cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;

            cell2 = new PdfPCell(new Phrase("WO Cerradas", texto));
            cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;

            pdftable3.AddCell(cell);
            pdftable3.AddCell(cell1);
            pdftable3.AddCell(cell2);

            pdftable3.AddCell(new PdfPCell(new Phrase(informearea.Area.ToString())) { BackgroundColor = BaseColor.WHITE });
            pdftable3.AddCell(new PdfPCell(new Phrase(informearea.Abiertos.ToString())) { BackgroundColor = BaseColor.WHITE });
            pdftable3.AddCell(new PdfPCell(new Phrase(informearea.Cerrados.ToString())) { BackgroundColor = BaseColor.WHITE });

           
            pdoc.Add(pdftable3);





            pdoc.Add(new Paragraph("\n"));


            pdoc.Add(new Paragraph("Informe de SLA de Area", tituloFont));
            pdoc.Add(new Paragraph("\n"));

            PdfPTable pdftable4 = new PdfPTable(3);
            pdftable4.WidthPercentage = 100;
            pdftable4.SetWidths(new float[] { 2f, 1f, 1f });

            cell = new PdfPCell(new Phrase("Area", texto));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            cell1 = new PdfPCell(new Phrase("Dentro de SLA", texto));
            cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;

            cell2 = new PdfPCell(new Phrase("Fuera de SLA", texto));
            cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;

            pdftable4.AddCell(cell);
            pdftable4.AddCell(cell1);
            pdftable4.AddCell(cell2);

            pdftable4.AddCell(new PdfPCell(new Phrase(informearea.Area.ToString())) { BackgroundColor = BaseColor.WHITE });
            pdftable4.AddCell(new PdfPCell(new Phrase(informearea.DentroSLA.ToString())) { BackgroundColor = BaseColor.WHITE });
            pdftable4.AddCell(new PdfPCell(new Phrase(informearea.FueraSLA.ToString())) { BackgroundColor = BaseColor.WHITE });


            pdoc.Add(pdftable4);



            pdoc.Close();
        }

    }


}
