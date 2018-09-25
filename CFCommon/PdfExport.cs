using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CFCommon
{
    /// <summary>
    /// Class PdfExport.
    /// </summary>
    public class PdfExport
    {
        static Font fontErrorMessage = FontFactory.GetFont("Arial", 16, Font.NORMAL, BaseColor.BLACK);
        static Font fontMessage = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

        public static void Add_Image_To_PDF( Image image, Document doc)
        {
            // Define The table that contains the image 
            //Header Table
            PdfPTable table = new PdfPTable(1);
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            table.SetWidths(new float[] { 1f });

            //Company Logo
            PdfPCell cell = ImageCell(image, 100f, PdfPCell.ALIGN_CENTER);
            table.AddCell(cell);
            doc.Add(table);          
        }

        /// <summary>
        /// Creates the PDF with error message.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="message">The message.</param>
        /// <returns>System.Byte[].</returns>
        public static byte [] CreatePDFWithErrorMessage(Image image,string message)
        {
            MemoryStream workStream = new MemoryStream();
            Document doc = new Document();
            doc.SetMargins(0f, 0f, 0f, 0f);

            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
            doc.Open();
            //Add Image to PDF                 
            //iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(HttpContext.Server.MapPath("~/Content/images/enlogo.png"));
            Add_Image_To_PDF(image, doc);
            Add_Error_Message(message, doc);

            doc.Close();
            return workStream.ToArray();
        }

        /// <summary>
        /// Adds the error message to the document.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="doc">The document.</param>
        public static void Add_Error_Message(string message, Document doc)
        {
            PdfPTable table = new PdfPTable(1);
            table = new PdfPTable(1);
            table.TotalWidth = 500f;
            table.SetWidths(new float[] { 1f });
            table.SpacingBefore = 20f;

            Phrase phrase = new Phrase();
            phrase.Add(new Chunk(message, fontErrorMessage));
            PdfPCell cell = PdfExport.PhraseCell(phrase, PdfPCell.ALIGN_LEFT);
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            table.AddCell(cell);

            doc.Add(table);

        }

        /// <summary>
        /// Adds the line message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="doc">The document.</param>
        public static void Add_Line_Message(string message, Document doc)
        {
            PdfPTable table = new PdfPTable(1);
            table = new PdfPTable(1);
            table.TotalWidth = 500f;
            table.SetWidths(new float[] { 1f });
            table.SpacingBefore = 20f;

            Phrase phrase = new Phrase();
            phrase.Add(new Chunk(message, fontMessage ));
            PdfPCell cell = PdfExport.PhraseCell(phrase, PdfPCell.ALIGN_LEFT);
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            table.AddCell(cell);
            doc.Add(table);
        }

        /// <summary>
        /// Draws the line.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="color">The color.</param>
        public static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, BaseColor color)
        {
            PdfContentByte contentByte = writer.DirectContent;
            contentByte.SetColorStroke(color);
            contentByte.MoveTo(x1, y1);
            contentByte.LineTo(x2, y2);
            contentByte.Stroke();
        }

        /// <summary>
        /// Phrases the cell.
        /// </summary>
        /// <param name="phrase">The phrase.</param>
        /// <param name="align">The align.</param>
        /// <returns>PdfPCell.</returns>
        public static PdfPCell PhraseCell(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
        }

        /// <summary>
        /// Images the cell.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="scale">The scale.</param>
        /// <param name="align">The align.</param>
        /// <returns>PdfPCell.</returns>
        public static PdfPCell ImageCell(Image image, float scale, int align)
        {
            //HttpContext.Server.MapPath("~/Content/images/" + CurrentLanguage + "logo.png")
            image.ScalePercent(scale);
            PdfPCell cell = new PdfPCell(image);
            //cell.BorderColor = Color.WHITE;
            // cell.VerticalAlignment = PdfCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 0f;
            cell.PaddingTop = 0f;
            return cell;
        }

        /// <summary>
        /// Method to add single cell to the Header
        /// </summary>
        /// <param name="tableLayout">The table layout.</param>
        /// <param name="cellText">The cell text.</param>
        /// <param name="bf">The bf.</param>
        public static void AddCellToHeader(PdfPTable tableLayout, string cellText , BaseFont bf)
        {
            Font f = new Font(bf, 8, 1, iTextSharp.text.BaseColor.BLACK);
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText,f ))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5,
                BackgroundColor = new iTextSharp.text.BaseColor(235, 246, 249)
            });
            //tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.YELLOW))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(128, 0, 0) });
        }


        /// <summary>
        ///  Method to add single cell to the body
        /// </summary>
        /// <param name="tableLayout">The table layout.</param>
        /// <param name="cellText">The cell text.</param>
        /// <param name="bf">The bf.</param>
        public static void AddCellToBody(PdfPTable tableLayout, string cellText , BaseFont bf)
        {
            Font f=new Font(bf, 8, 1, iTextSharp.text.BaseColor.BLACK);
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, f))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5,
                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
            });
        }

        /// <summary>
        /// Adds the color of the cell to body with specific.
        /// </summary>
        /// <param name="tableLayout">The table layout.</param>
        /// <param name="cellText">The cell text.</param>
        /// <param name="bf">The bf.</param>
        /// <param name="color">The color.</param>
        public static void AddCellToBodyWithSpecificColor(PdfPTable tableLayout, string cellText, BaseFont bf, BaseColor color)
        {
            Font f = new Font(bf, 8, 1, iTextSharp.text.BaseColor.BLACK);
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, f))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5,
                BackgroundColor = color
            });
        }


    }
}
