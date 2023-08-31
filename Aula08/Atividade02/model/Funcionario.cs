using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.model
{
    public class Funcionario
    {
        private string name = string.Empty;
        private string role = string.Empty;
        private string cpf = string.Empty;
        private int workload;
        private float hoursBank;
        private decimal salary;

        public Funcionario(string name, string role, string cpf, int workload, float hoursBank, decimal salary)
        {
            this.name = name;
            this.role = role;
            this.cpf = cpf;
            this.workload = workload;
            this.hoursBank = hoursBank;
            this.salary = salary;
        }

        public string GetName() 
        {
            return this.name;
        }

        public void SetName (string name) 
        {
            this.name = name;
        }

        public string GetRole()
        {
            return this.role;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }

        public string GetCpr()
        {
            return this.cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public int GetWorkload()
        {
            return this.workload;
        }

        public void SetWorkloadf(int workload)
        {
            this.workload = workload;
        }

        public float GetHoursBank()
        {
            return this.hoursBank;
        }

        public void SetHoursBank(float hoursBank)
        {
            this.hoursBank = hoursBank;
        }

        public decimal GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(decimal salary)
        {
            this.salary = salary;
        }

        public void View()
        {
            Console.WriteLine("\n****************************************************");
            Console.WriteLine("                 Dados do Funcionário:");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Nome: {this.name}");
            Console.WriteLine($"Cargo: {this.role}");
            Console.WriteLine($"Salario: {(this.salary).ToString("C")}");
            Console.WriteLine($"Banco de Horas: {this.hoursBank:F2}");
            Console.WriteLine($"Carga Horaria: {this.workload} horas");
            Console.WriteLine("***************************************************\n");
        }
    }
}
