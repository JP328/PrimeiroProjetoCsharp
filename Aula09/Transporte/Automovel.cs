using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Automovel : Terrestre
    {
        private string cor;
        private string placa;
        private int portas;
        private int marcha;

        public Automovel(
            string cor, string placa, int portas, int marcha, int rodas, int velocidade, int capacidade) : 
            base(rodas, velocidade, capacidade)
        {
            this.cor = cor; 
            this.placa = placa;
            this.portas = portas;
            this.marcha = marcha;
        }

        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string cor)
        {
            this.cor = cor;
        }

        public int GetNumeroPortas()
        {
            return portas;
        }

        public void SetNumeroPortas(int portas)
        {
            this.portas = portas;
        }

        public string GetPlaca()
        {
            return placa;
        }

        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public void SetMarcha(int marcha)
        {
            this.marcha = marcha;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("cor: " + this.cor);
            Console.WriteLine("Número de portas: " + this.portas);
            Console.WriteLine("Placa: " + this.placa);
            Console.WriteLine("Marcha: " + this.marcha);

        }

    }
}
