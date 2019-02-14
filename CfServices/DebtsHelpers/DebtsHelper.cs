//using Cf.Data;
//using Cf.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CfServices.DebtsHelpers
//{
//    public class DebtsHelper
//    {
//        public JsonResult Calculate(int employeeId, int productTypeId, float amount, int period, float netAmount, float deductions)
//        {
//            try
//            {
//                Db db = new Db(DbServices.ConnectionString);
//                EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter()
//                {
//                    EmployeeId = employeeId,
//                    ProductTypeId = (short)productTypeId,
//                    Amount = (decimal)amount,
//                    Period = (short)period
//                };

//                EmployeeProductCalculatorResult result = db.EmployeeProductCalculatorFirstOrDefault(f);
//                if (result == null)
//                {
//                    return Json("Error", JsonRequestBehavior.AllowGet);
//                }
//                else
//                {
//                    GetEmployeeSolvencyFilter filter = new GetEmployeeSolvencyFilter()
//                    {
//                        EmployeeId = employeeId,
//                        Amount = (decimal)amount,
//                        Date = System.DateTime.Now,
//                        Installment = result.Installment,
//                        GrossSalary = (decimal)netAmount,
//                        NetSalary = (decimal)netAmount

//                    };
//                    GetEmployeeSolvencyResult solvencyResult = db.GetEmployeeSolvencyFirstOrDefault(filter);

//                    return Json(new { Calculator = result, Solevency = solvencyResult }, JsonRequestBehavior.AllowGet);
//                }
//            }
//            catch (CfException cfex)
//            {
//                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
//            }
//            catch (Exception ex)
//            {
//                TempData["Failure"] = ex.Message;
//            }

//            return Json("Error", JsonRequestBehavior.AllowGet);
//        }

//    }
//}
