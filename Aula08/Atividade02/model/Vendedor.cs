using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.model
{
    public class Vendedor : Funcionario
    {
        private decimal salesTarget;

        public Vendedor(
            string name, string role, string cpf, int workload, float hoursBank, decimal salary, decimal salesTarget) : 
            base(name, role, cpf, workload, hoursBank, salary)
        {
            this.salesTarget = salesTarget;
        }

        public decimal GetSalesTarget() { return this.salesTarget; }

        public void SetSalesTarget(decimal salesTarget) { this.salesTarget = salesTarget; }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Meta de Vendas: {this.salesTarget}");
            Console.WriteLine("***************************************************\n");
        }
    }
}
