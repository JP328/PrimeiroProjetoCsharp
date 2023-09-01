using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.model
{
    public class Gerente : Funcionario
    {
        private string responsibleArea = string.Empty;

        public Gerente(
            string name, string role, string cpf, int workload, float hoursBank, decimal salary, string responsibleArea) : 
            base(name, role, cpf, workload, hoursBank, salary)
        {
            this.responsibleArea = responsibleArea;
        }


        public string GetSalesTarget() { return this.responsibleArea; }

        public void SetSalesTarget(string responsibleArea) { this.responsibleArea = responsibleArea; }


        public override void View() 
        {
            base.View();
            Console.WriteLine($"Setor que gerência: {this.responsibleArea}");
            Console.WriteLine("***************************************************\n");
        }
    }
}
