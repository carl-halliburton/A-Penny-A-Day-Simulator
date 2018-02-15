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

        public Calculate() {
            numDays = 0;
            pennyTotal = 1;
        }

        public void DoublePenny()
        {
            int count = 0;
            while (count != numDays)
            {
                pennyTotal = pennyTotal + pennyTotal;
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

        public void SetNumDays(long days)
        {
            numDays = days;
        }

        public long GetNumDays()
        {
            return numDays;
        }

        public void FormeatDollar()
        { 
            dollarValue = Convert.ToDecimal(pennyTotal / 100.0).ToString("#,##0.00");
        }
    }
}
