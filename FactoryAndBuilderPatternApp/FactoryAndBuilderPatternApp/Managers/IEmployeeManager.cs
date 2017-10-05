using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndBuilderPatternApp.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
        decimal GetHouseAllowance();
        decimal GetMedicalAllowance();
    }
}
