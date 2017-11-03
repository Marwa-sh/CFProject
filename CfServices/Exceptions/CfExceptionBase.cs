using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cf.Data;

namespace Cf.Services.Exceptions
{
	/// <summary>
	/// A base class for all Cf exceptions
	/// </summary>
	public class CfException : Exception
	{
		/// <summary>
		/// Name of the Module which throws the exception
		/// </summary>
		public string Module { get; set; }

		/// <summary>
		/// Number of the exception
		/// </summary>
		public int Number { get; set; }
		public ErrorDefinition ErrorDefinition { get; set; }
        /// <summary>
        /// Public constructor for the CfExceptionBase class
        /// </summary>
        /// <param name="module">Module name</param>
        /// <param name="number">Exception number</param>
        /// <param name="message">Error message</param>
        /// <param name="innerException"></param>
        public CfException(string module, int number, string message, Exception innerException = null)
            : base(message, innerException)
        {
            this.Module = module;
            this.Number = number;
        }

        /// <summary>
        /// Public constructor for the CfExceptionBase class
        /// </summary>
        /// <param name="module">Module name</param>
        public CfException(string module) : base()
        {
            this.Module = module;
        }

        /// <summary>
        /// Overrides the ToString() method to represent the exception
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = Module + " (" + Number + "): " + Message;
            s = s.Replace('\'', ' ');
            return s;
        }
    }
}
