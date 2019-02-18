using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.AntiOpenClosed
{
    class TaxCalculator
    {
        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxAmount = 0;
            decimal taxableIncome = income - deduction;

            switch (country)
            {
                case "Turkey":
                    // TODO: Calculate
                    break;
                case "Australia":
                    // TODO: Calculate
                    break;
                case "UK":
                    // TODO: Calculate
                    break;
            }

            return taxAmount;
        }
    }
}
