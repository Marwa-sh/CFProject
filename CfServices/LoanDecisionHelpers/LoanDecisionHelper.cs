using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cf.Services;
using Cf.Data;


namespace CfServices.LoanDecisionHelpers
{
    ///<summary>
	/// Loan Decision Helper Class
	///</summary>
    public class LoanDecisionHelper
    {
        #region MoveLoanToSubscriber

        ///<summary>
        /// Move Loan To Employee Method
        ///</summary>
        public void MoveLoanToEmployee(int userId, int LoanId, int EmployeeId, LoanDecision loanDecision)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);

                // 0- Create Loan Decision
                LoanDecision decision = LoanDecisionServices.Insert(userId,loanDecision,db);

                // 1- Change the Status Of Old Loan to be Move To Employee
                Loan loan = LoanServices.Get(LoanId,db);
                loan.LoanStatus = (int)LoanStatusEnum.MoveToEmployee;
                LoanServices.Update(userId,loan,db);
                // 2- Process the Installments



                // 3- Create New Product + Refundable Product

                LoanRequest req = new LoanRequest()
                {
                    //Request=
                };
                Loan NewLoan = new Loan()
                {
                    LoanDecision = decision.Id,
                    Product = loan.Product,
                    LoanGenerationStatus = (int)LoanGenerationStatusEnum.IncommingFromOtherSubscriber,
                    LoanStatus = (int)LoanStatusEnum.Unfinished,
                    LoanType = loan.LoanType
                };

                LoanServices.Insert(userId, NewLoan);


                // 2- Add Loan and Generate Installment


                //db.LoanGenerate(model.Requests[i].RequestId, decision.Id, (int)LoanGenerationStatusEnum.LoanRequest);


                // 4- Generate Installment for the new Loan

                //  
            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region MoveLoanToOtherDepartment
        ///<summary>
        /// Move Loan To Other Department Method
        ///</summary>
        public void MoveLoanToOtherDepartment()
        {

        }
        #endregion

        #region MoveLoanFromOtherDepartment
        ///<summary>
        /// Move Loan From Other Department Method
        ///</summary>
        public void MoveLoanFromOtherDepartment()
        {

        }
        #endregion

        #region MoveLoanToGuarantors
        ///<summary>
        /// Move Loan To Guarantors Method
        ///</summary>
        public void MoveLoanToGuarantors()
        {

        }
        #endregion

    }
}
