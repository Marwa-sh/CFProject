using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilder;

namespace Cf.Data
{
    public class ParametersCustomCriterion : CriterionBase
    {
        private List<Tuple<string, string, bool>> Pairs;
        public ParametersCustomCriterion(List<Tuple<string, string, bool>> pairs)
        {
            Pairs = pairs;
        }
        public override string ToString()
        {
            string s = string.Empty;
            foreach(Tuple<string, string, bool> p in Pairs)
            {
                if (s != string.Empty)
                    s += " AND ";
                if (p.Item3)
                    s += "Parameters.exist('(/Params/" + p.Item1 + "[.=\"" + p.Item2 + "\"])') = 1";
                else
                    s += "Parameters.exist('(/Params/" + p.Item1 + "[contains(.,\"" + p.Item2 + "\")])') = 1";
            }
            return s;
        }
    }
}
