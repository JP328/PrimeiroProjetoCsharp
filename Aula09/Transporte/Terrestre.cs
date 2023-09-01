using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Terrestre : Transporte
    {
        private int rodas;
        private int velocidade;

        public Terrestre(int rodas, int velocidade, int capacidade) : base(capacidade)
        {
            this.rodas = rodas;
            this.velocidade = velocidade;
        }

        public int GetNumeroRodas()
        {
            return rodas;
        }

        public void SetNumeroRodas(int rodas)
        {
            this.rodas = rodas;
        }

        public int GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("Número de rodas: " + this.rodas);
            Console.WriteLine("Velocidade: " + this.velocidade);

        }

    }
}
