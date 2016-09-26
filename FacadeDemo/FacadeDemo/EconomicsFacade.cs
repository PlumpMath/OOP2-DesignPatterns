using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeDemo.Economics;

namespace FacadeDemo
{
    static class EconomicsFacade
    {
        public static bool PaySalary(int empId) {
            dynamic manager = new ComplexEconomicsManager();
            var emp = manager.GetEmplyee(empId);
            var salary = emp.GetMonthlySalary();
            var receipt = manager.ProcessTransaction(emp, salary);
            return receipt.IsValid();
        }
    }
}
