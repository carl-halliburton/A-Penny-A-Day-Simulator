using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubledPennyCalculator
{
    class Calculate
    {
        private string input;
        private string output;
        private int count;
        private long numDays;
        private long pennyTotal;
        private double dollarValue;

        public Calculate(long days) {
            count = 0;
            numDays = days;
            pennyTotal = 0;
        }

        public void DoublePenny()
        {
            SetPennyTotal(GetPennyTotal() * GetPennyTotal());
        }

        public void SetPennyTotal(long newTotal)
        {
            pennyTotal = newTotal;
        }

        public long GetPennyTotal()
        {
            return pennyTotal;
        }

        public void SetOutPut()
        {
            
        }

        public String GetOutPut()
        {
            return output;
        }

        public void SetCount()
        {

        }

        public int GetCount()
        {
            return count;
        }

        public void FormeatDollar()
        {
            output = Convert.ToDecimal(dollarValue).ToString("#,##0.00");
        }
    }
}
