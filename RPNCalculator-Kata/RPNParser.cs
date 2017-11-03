using System.Collections.Generic;
using System.Linq;

namespace RPNCalculator_Kata
{
    public class RPNParser
    {
        public List<string> Terms { get; private set; } = new List<string>();

        public void Parse(string formula)
        {
            Terms = formula.Split(' ').ToList();
        }
    }
}