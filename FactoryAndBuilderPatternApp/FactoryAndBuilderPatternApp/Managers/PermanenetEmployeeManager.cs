using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryAndBuilderPatternApp.Managers
{
    public class PermanenetEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHouseAllowance()
        {
            return 10;
        }

        public decimal GetMedicalAllowance()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}