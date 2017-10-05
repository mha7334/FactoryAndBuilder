using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryAndBuilderPatternApp.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 2;
        }

        public decimal GetHouseAllowance()
        {
            return 0;
        }

        public decimal GetMedicalAllowance()
        {
            return 0;
        }

        public decimal GetPay()
        {
            return 5;
        }
    }
}