using Cf.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCommon
{
    /// <summary>
    /// Class ExportHelper.
    /// </summary>
    public class ExportHelper
    {
        /// <summary>
        /// Exports the PDF.
        /// </summary>
        /// <param name="headers">The headers.</param>
        /// <param name="dataTable">The data table.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="CurrentLanguage">The current language.</param>
        /// <param name="fontPath">The font path.</param>
        /// <returns>System.Byte[].</returns>
        public static byte [] exportPDF(List<string>  headers, List<List<string>> dataTable, 
            string pathImage , string CurrentLanguage ,string fontPath)
        {
            //start the pdf 
            MemoryStream workStream = new MemoryStream();
            StringBuilder status = new StringBuilder("");
            
            //file name to be created 
           
            Document doc = new Document();
            doc.SetMargins(0f, 0f, 0f, 0f);

            //file will created in this path
            //string strAttachment = path;// Server.MapPath("~/Downloadss/" + strPDFFileName);

            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
            doc.Open();

            //Add Image to PDF                 
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(pathImage);
            PdfExport.Add_Image_To_PDF(image, doc);
            PdfExport.Add_Line_Message(
                string.Format(
                ResourceServices.GetString(CurrentLanguage, "Export", "ExportDate"),
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")), doc);

            // Add Content to PDF
            //Create PDF Table with the count of header columns

            PdfPTable table = new PdfPTable(headers.Count);
            table = new PdfPTable(headers.Count);
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            //table.SetWidths(new float[] { 0.3f, 1f });
            table.SpacingBefore = 20f;
            table.TotalWidth = 400f;
            
            float[] headersWidth = new float[headers.Count];// { 20, 20, 20, 20, 20, 20, 20 };  //Header Widths
            for (int i = 0; i < headers.Count; i++)
            {
                headersWidth[i] = 20;
            }
            table.SetWidths(headersWidth);        //Set the pdf headers

            table.WidthPercentage = 100;       //Set the PDF File witdh percentage
            table.HeaderRows = 1;

            if (CurrentLanguage.Equals("ar"))
            {
                // for arabic language:
                table.DefaultCell.NoWrap = false;
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            }
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            ////Add header
            for (int i = 0; i < headers.Count; i++)
            {
                PdfExport.AddCellToHeader(table, headers[i].ToString(), bf);// );
            }
            
            //Add body
            for (int i=0; i<dataTable.Count;i++)
            {
                for (int j = 0; j < dataTable[i].Count; j++)
                {
                    PdfExport.AddCellToBody(table, dataTable[i][j], bf);  
                }
            }

            doc.Add(table);
            
            // Closing the document
            doc.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;

            return workStream.ToArray();
            //return File(workStream.ToArray(), "application/pdf", strPDFFileName);

        }
        
        /// <summary>
        /// Exports the excel.
        /// </summary>
        /// <param name="headers">The headers.</param>
        /// <param name="dataTable">The data table.</param>
        /// <returns>MemoryStream.</returns>
        /// <exception cref="System.Exception"></exception>
        public static MemoryStream exportExcel(List<string> headers, List<List<string>> dataTable)
        {
            //System.IO.StreamWriter excelDoc;
            using (var stream = new MemoryStream())
            {
                using (var excelDoc = new StreamWriter(stream, Encoding.UTF8))
                {
                    #region startExcelXml
                    const string startExcelXML = "<xml version>\r\n<Workbook " +
                          "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                          " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                          "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                          "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                          "office:spreadsheet\">\r\n <Styles>\r\n " +
                          "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                          "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                          "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                          "\r\n <Protection/>\r\n </Style>\r\n " +
                          "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                          "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                          "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                          " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                          "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                          "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                          "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                          "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                          "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                          "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                          "</Styles>\r\n ";
                    #endregion
                    const string endExcelXML = "</Workbook>";
                    int rowCount = 0;
                    int sheetCount = 1;
                    excelDoc.Write(startExcelXML);
                    excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                    excelDoc.Write("<Table>");
                    #region First Row
                    //print date
                    excelDoc.Write("<Row>");
                    excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                    excelDoc.Write(string.Format(
                        ResourceServices.GetString(System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName, "Export", "ExportDate"),
                        DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
                    excelDoc.Write("</Data></Cell>");
                    excelDoc.Write("</Row>");

                    excelDoc.Write("<Row>");
                    DateTime d = DateTime.Now;
                    //elapsedTime = (DateTime.Now - d).TotalSeconds;
                    System.Data.DataTable table = new System.Data.DataTable("Table");

                    for (int i = 0; i < headers.Count; i++)
                    {
                        table.Columns.Add(headers[i]);
                    }

                    //Add body
                    for (int i = 0; i < dataTable.Count; i++)
                    {
                        object[] columns = new object[dataTable[i].Count];

                        for (int j = 0; j < dataTable[i].Count; j++)
                        {
                            columns[j]=dataTable[i][j];
                        }
                        table.Rows.Add(columns);
                    }

                    //foreach (EventLogBalanceExtendedVw item in eventlog)
                    //{
                    //    table.Rows.Add(
                    //        item.EventLogId.ToString(),
                    //        item.EventLogEventStatusName,
                    //        item.EventLogDate,
                    //        item.AccountUnverifiedAccountNumber,
                    //        ChechEventLogError(item.EventLogEventLogErrorMessage),
                    //        item.EventLogUserInstanceUserUserName,
                    //        item.EventLogUserInstanceInstanceChannelName
                    //        );
                    //}
                    DataSet set = new DataSet();
                    set.Tables.Add(table);
                    for (int x = 0; x < set.Tables[0].Columns.Count; x++)
                    {
                        excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                        excelDoc.Write(set.Tables[0].Columns[x].ColumnName);
                        excelDoc.Write("</Data></Cell>");
                    }
                    excelDoc.Write("</Row>");
                    #endregion

                    for (int x = 0; x < set.Tables[0].DefaultView.Count; x++)
                    {
                        rowCount++;
                        #region 64000
                        if (rowCount == 64000)
                        {
                            rowCount = 0;
                            sheetCount++;
                            excelDoc.Write("</Table>");
                            excelDoc.Write(" </Worksheet>");
                            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                            excelDoc.Write("<Table>");
                        }
                        #endregion
                        excelDoc.Write("<Row>"); //ID=" + rowCount + "

                        for (int y = 0; y < set.Tables[0].Columns.Count; y++)
                        {
                            System.Type rowType = null;
                            rowType = set.Tables[0].DefaultView[x][y].GetType();
                            switch (rowType.ToString())
                            {
                                case "System.String":
                                    string XMLstring = "";
                                    XMLstring = set.Tables[0].DefaultView[x][y].ToString();
                                    XMLstring = XMLstring.Trim();
                                    XMLstring = XMLstring.Replace("&", "&");
                                    XMLstring = XMLstring.Replace(">", ">");
                                    XMLstring = XMLstring.Replace("<", "<");
                                    excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                   "<Data ss:Type=\"String\">");
                                    excelDoc.Write(XMLstring);
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.DateTime":
                                    DateTime XMLDate = DateTime.Now;
                                    XMLDate = (DateTime)set.Tables[0].DefaultView[x][y];
                                    string XMLDatetoString = "";
                                    XMLDatetoString = XMLDate.Year.ToString() +
                                         "-" +
                                         (XMLDate.Month < 10 ? "0" +
                                         XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                         "-" +
                                         (XMLDate.Day < 10 ? "0" +
                                         XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                         "T" +
                                         (XMLDate.Hour < 10 ? "0" +
                                         XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                         ":" +
                                         (XMLDate.Minute < 10 ? "0" +
                                         XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                         ":" +
                                         (XMLDate.Second < 10 ? "0" +
                                         XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                         ".000";
                                    excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                                 "<Data ss:Type=\"DateTime\">");
                                    excelDoc.Write(XMLDatetoString);
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.Boolean":
                                    excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                "<Data ss:Type=\"String\">");
                                    //excelDoc.Write(x[y].ToString());
                                    excelDoc.Write(set.Tables[0].DefaultView[x][y].ToString());
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.Int16":
                                case "System.Int32":
                                    excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                            "<Data ss:Type=\"Number\">");
                                    //  excelDoc.Write(x[y].ToString());
                                    excelDoc.Write(set.Tables[0].DefaultView[x][y].ToString());
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.Int64":
                                case "System.Byte":
                                    excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                            "<Data ss:Type=\"Number\">");
                                    //  excelDoc.Write(x[y].ToString());
                                    excelDoc.Write(set.Tables[0].DefaultView[x][y].ToString());
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.Decimal":
                                    excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                          "<Data ss:Type=\"Number\">");
                                    //  excelDoc.Write(x[y].ToString());
                                    excelDoc.Write(set.Tables[0].DefaultView[x][y].ToString());
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.Double":
                                    excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                          "<Data ss:Type=\"Number\">");
                                    //  excelDoc.Write(x[y].ToString());
                                    excelDoc.Write(set.Tables[0].DefaultView[x][y].ToString());
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                case "System.DBNull":
                                    excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                          "<Data ss:Type=\"String\">");
                                    excelDoc.Write("");
                                    excelDoc.Write("</Data></Cell>");
                                    break;
                                default:
                                    throw (new Exception(rowType.ToString() + " not handled."));
                            }
                        }
                        excelDoc.Write("</Row>");
                    }
                    excelDoc.Write("</Table>");
                    excelDoc.Write(" </Worksheet>");
                    excelDoc.Write(endExcelXML);
                    excelDoc.Close();
                }
                return new MemoryStream(stream.ToArray());
            }
        }

        //public static void exportPDF(string [] headers, string CurrentLanguage)
        //{
        //    string ImagePath = "~/Content/images/enlogo.png";
        //    string FontPath = "~/fonts/fonts/ARIALUNI.TTF";

            

        //    //start the pdf 
        //    MemoryStream workStream = new MemoryStream();
        //    StringBuilder status = new StringBuilder("");

        //    //file name to be created 

        //    Document doc = new Document();
        //    doc.SetMargins(0f, 0f, 0f, 0f);

        //    //file will created in this path
        //    //string strAttachment = path;// Server.MapPath("~/Downloadss/" + strPDFFileName);

        //    PdfWriter.GetInstance(doc, workStream).CloseStream = false;
        //    doc.Open();

        //    //Add Image to PDF                 
        //    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ImagePath);
        //    PdfExport.Add_Image_To_PDF(image, doc);

        //    // Add Content to PDF

        //    //Create PDF Table with n columns

        //    int n = headers.Length;

        //    PdfPTable table = new PdfPTable(n);
        //    table = new PdfPTable(n);
        //    table.HorizontalAlignment = Element.ALIGN_LEFT;
        //    //table.SetWidths(new float[] { 0.3f, 1f });
        //    table.SpacingBefore = 20f;
        //    table.TotalWidth = 400f;

        //    float[] headersWidth = new float[n];// { 20, 20, 20, 20, 20, 20, 20 };  //Header Widths
        //    for (int i = 0; i <n; i++)
        //    {
        //        headersWidth[i] = headers[i].Length-1;
        //    }
        //    table.SetWidths(headersWidth);        //Set the pdf headers

        //    table.WidthPercentage = 100;       //Set the PDF File witdh percentage
        //    table.HeaderRows = 1;


        //    if (CurrentLanguage.Equals("ar"))
        //    {
        //        // for arabic language:
        //        table.DefaultCell.NoWrap = false;
        //        table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

        //    }

        //    BaseFont bf = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        //    ////Add header
        //    for (int i = 0; i < n; i++)
        //    {
        //        PdfExport.AddCellToHeader(table, headers[i].ToString(), bf);// );
        //    }

        //    //Add body
        //    for (int i = 0; i < dataTable.Count; i++)
        //    {
        //        for (int j = 0; j < dataTable[i].Count; j++)
        //        {
        //            PdfExport.AddCellToBody(table, dataTable[i][j], bf);

        //        }
        //    }

        //    doc.Add(table);

        //    // Closing the document
        //    doc.Close();

        //    byte[] byteInfo = workStream.ToArray();
        //    workStream.Write(byteInfo, 0, byteInfo.Length);
        //    workStream.Position = 0;

        //    return workStream.ToArray();
        //}

    }
}
