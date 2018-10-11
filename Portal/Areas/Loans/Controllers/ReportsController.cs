using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Cf.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using System.Data;

namespace Portal.Areas.Loans.Controllers
{
    public class ReportsController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string reportEmployeeLoansBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportEmployeeLoansBetweenTwoDates");
        private string reportLoansBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportLoansBetweenTwoDates");
        private string reportPaymentsBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportPaymentsBetweenTwoDates");
        private string reportSubscriptionsBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportSubscriptionsBetweenTwoDates");
        private string reportBalance = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportBalance");
        private string print = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "Print");

        private string newAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "NewAmounts");
        private string finishedAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "FinishedAmounts");
        private string equalAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "EqualAmounts");
        private string diffAmountsMore = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "DiffAmountsMore");
        private string diffAmountsLess = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "DiffAmountsLess");
        private string reportLoansVw = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ReportLoansVw");
        public ReportsController()
        {
            #region ViewBags
            ViewBag.ReportEmployeeLoansBetweenTwoDates = reportEmployeeLoansBetweenTwoDates;
            ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
            ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
            ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
            ViewBag.NewAmounts = newAmounts;
            ViewBag.FinishedAmounts = finishedAmounts;
            ViewBag.EqualAmounts = equalAmounts;
            ViewBag.DiffAmountsMore = diffAmountsMore;
            ViewBag.DiffAmountsLess = diffAmountsLess;
            ViewBag.ReportBalance = reportBalance;
            ViewBag.ReportLoansVw = reportLoansVw;
            ViewBag.Print = print;
            #endregion
        }

        #region Index
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region ReportEmployeeLoansBetweenTwoDates  

        public ActionResult ReportEmployeeLoansBetweenTwoDates()
        {
            ViewBag.ReportEmployeeLoansBetweenTwoDates = reportEmployeeLoansBetweenTwoDates;
            return View("_FilterReportEmployeeLoansBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportEmployeeLoansBetweenTwoDates(string operationType, ReportEmployeeLoansBetweenTwoDatesFilter model)
        {
            try
            {
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportEmployeeLoansBetweenTwoDates", model);
                }
                else if(operationType != null && operationType == "csv")
                {
                    return RedirectToAction("GetCSVEmployeeLoansBetweenTwoDates", model);
                }
                List<ReportEmployeeLoansBetweenTwoDatesResult> result = DbServices.ReportEmployeeLoansBetweenTwoDates(model, db);

                return PartialView("ReportEmployeeLoansBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportEmployeeLoansBetweenTwoDates = reportEmployeeLoansBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region ReportLoansBetweenTwoDates  

        public ActionResult ReportLoansBetweenTwoDates()
        {
            ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
            return View("_FilterReportLoansBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportLoansBetweenTwoDates(string operationType, ReportLoansBetweenTwoDatesFilter model)
        {
            try
            {
                if(operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportLoansBetweenTwoDates", model);
                }
                List<ReportLoansBetweenTwoDatesResult> result = DbServices.ReportLoansBetweenTwoDates(model, db);

                return PartialView("ReportLoansBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region ReportPaymentsBetweenTwoDates  

        public ActionResult ReportPaymentsBetweenTwoDates()
        {
            ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
            return View("_FilterReportPaymentsBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportPaymentsBetweenTwoDates(string operationType, ReportPaymentsBetweenTwoDatesFilter model)
        {
            try
            {
                if(model.PaymentDiff == null)
                {
                    model.PaymentDiff = 0;
                }
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportPaymentsBetweenTwoDates", model);
                }
                List<ReportPaymentsBetweenTwoDatesResult> result = DbServices.ReportPaymentsBetweenTwoDates(model, db);

                return PartialView("ReportPaymentsBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region ReportSubscriptionsBetweenTwoDates  

        public ActionResult ReportSubscriptionsBetweenTwoDates()
        {
            ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
            return View("_FilterReportSubscriptionsBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportSubscriptionsBetweenTwoDates(string operationType, ReportSubscriptionsBetweenTwoDatesFilter model)
        {
            try
            {
                if (model.SubscriptionDiff == null)
                {
                    model.SubscriptionDiff = 0;
                }
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportSubscriptionsBetweenTwoDates", model);
                }
                List<ReportSubscriptionsBetweenTwoDatesResult> result = DbServices.ReportSubscriptionsBetweenTwoDates(model, db);

                return PartialView("ReportSubscriptionsBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
                return View();
            }
        }

        #endregion


        #region Reports Printing
        [HttpGet]
        public ActionResult PrintReportLoansBetweenTwoDates(ReportLoansBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportLoansBetweenTwoDatesResult> result = DbServices.ReportLoansBetweenTwoDates(model, db);
                 
                return PartialView(result);
            }
            catch (CfException exc)
            {                
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportPaymentsBetweenTwoDates(ReportPaymentsBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportPaymentsBetweenTwoDatesResult> result = DbServices.ReportPaymentsBetweenTwoDates(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportSubscriptionsBetweenTwoDates(ReportSubscriptionsBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportSubscriptionsBetweenTwoDatesResult> result = DbServices.ReportSubscriptionsBetweenTwoDates(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportLoansVw(LoanExtendedVwFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<LoanExtendedVw> result = db.Get(model);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportBalance(ReportMonthlyBalanceSumFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportMonthlyBalanceSumResult> result = DbServices.ReportMonthlyBalanceSum(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportEmployeeLoansBetweenTwoDates(ReportEmployeeLoansBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportEmployeeLoansBetweenTwoDatesResult> result = DbServices.ReportEmployeeLoansBetweenTwoDates(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        #endregion

        #region ReportLoansVw
        public ActionResult ReportLoansVw()
        {
            ViewBag.ReportLoansVw = reportLoansVw;
            return View("_FilterReportLoansVw");
        }

        [HttpPost]
        public ActionResult ReportLoansVw(string operationType, LoanExtendedVwFilter model)
        {
            try
            {                 
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportLoansVw", model);
                }
                List<LoanExtendedVw> result = db.Get(model);

                return PartialView("ReportLoansVwResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansVw = reportLoansVw;
                return View();
            }
        }

        #endregion

        #region ReportBalance  

        public ActionResult ReportBalance()
        {
            ViewBag.ReportBalance = reportBalance;
            return View("_FilterReportBalance");
        }

        [HttpPost]
        public ActionResult ReportBalance(string operationType, ReportMonthlyBalanceSumFilter model)
        {
            try
            {
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportBalance", model);
                }
                List<ReportMonthlyBalanceSumResult> result = DbServices.ReportMonthlyBalanceSum(model, db);

                return PartialView("ReportBalanceResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region Excel Actions
        [HttpPost]
        public FileContentResult GetCSVEmployeeLoansBetweenTwoDates()
        {
            ReportEmployeeLoansBetweenTwoDatesFilter filters = new ReportEmployeeLoansBetweenTwoDatesFilter();
                try
                {
                List<ReportEmployeeLoansBetweenTwoDatesResult> result = DbServices.ReportEmployeeLoansBetweenTwoDates(filters);                    
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
                            excelDoc.Write("<Row>");
                            DateTime d = DateTime.Now;
                            //elapsedTime = (DateTime.Now - d).TotalSeconds;
                            System.Data.DataTable table = new System.Data.DataTable("Table");

                            table.Columns.Add("1");
                            table.Columns.Add("2");
                            table.Columns.Add("3");
                            table.Columns.Add("4");
                            table.Columns.Add("5");
                            table.Columns.Add("6");
                            table.Columns.Add("7");
                            
                        foreach (ReportEmployeeLoansBetweenTwoDatesResult item in result)
                            {
                                table.Rows.Add(
                                    item.ProductEmployeeId.ToString(),
                                    item.ProductEmployeeFullName,
                                    item.ProductProductTypeName,
                                    item.ProductAmount,
                                    item.LoanDecisionDate.ToString(),                                   
                                    item.Installment,
                                    item.LoanDecisionNumber
                                    );
                            }
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
                        return File(new MemoryStream(stream.ToArray()).ToArray(), "application/vnd.ms-excel", "EmployeeLoansBetweenTwoDates.xls");
                    }

                    // MessageBox.Show("Data exported to excel file successfuly");
                }
                catch (Exception ex)
                {
                    return File(new System.Text.UTF8Encoding().GetBytes(ex.Message), "application/vnd.ms-excel", "Error.xls");
                }
        }

        #endregion
    }
}

