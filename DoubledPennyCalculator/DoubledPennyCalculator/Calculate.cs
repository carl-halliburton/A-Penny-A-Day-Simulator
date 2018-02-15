using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubledPennyCalculator
{
    class Calculate
    {
        private string dollarValue;
        private long numDays;
        private long pennyTotal;

        public Calculate(long days) {
            numDays = days;
            pennyTotal = 0;
            DoublePenny(numDays);
        }

        public void DoublePenny(long numbDays)
        {
            int count = 0;
            while (count != numDays)
            {
                SetPennyTotal(GetPennyTotal() * GetPennyTotal());
                count++;
            }
            FormeatDollar();
        }

        public void SetPennyTotal(long newTotal)
        {
            pennyTotal = newTotal;
        }

        public long GetPennyTotal()
        {
            return pennyTotal;
        }

        public String GetDollarValue()
        {
            return dollarValue;
        }

        public void FormeatDollar()
        { 
            dollarValue = Convert.ToDecimal(pennyTotal / 100.0).ToString("#,##0.00");
        }
    }
}
