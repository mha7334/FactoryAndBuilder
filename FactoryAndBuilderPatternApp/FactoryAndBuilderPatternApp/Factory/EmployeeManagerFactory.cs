using FactoryAndBuilderPatternApp.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryAndBuilderPatternApp.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empId)
        {

            if (empId == 1)
                return new PermanenetEmployeeManager();
            else if (empId == 2)
                return new ContractEmployeeManager();
            else
                return null;
        }
    }
}