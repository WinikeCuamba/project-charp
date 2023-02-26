using System;
namespace ex027
{
    public class Cenario : ICenario
    {

        public Cenario(string[,] matrix, int tamanhoX, int tamanhoY)
        {
            this.CenarioTextura = matrix;
            TamanhoCenarioX = tamanhoX;
            TamanhoCenarioY = tamanhoY;
        }


        public int TamanhoCenarioX { get; private set; }
        public int TamanhoCenarioY { get; private set; }


        private string[,] cenarioTextura;
        public string[,] CenarioTextura 
        {
            get 
            {
                return this.cenarioTextura;
            }
            private set 
            {
                this.cenarioTextura = value;
            }
            
        }

        public void  AlterarVisualizacaoDoCenario(Byte posicaoX, Byte posicaoY, Char caracter)
        {
            this.CenarioTextura[posicaoY, posicaoX] = Convert.ToString(caracter);

        } 
        public void VisualizarCenario()
        {
            for ( int l = 0; l < TamanhoCenarioX; l++ )
            {
                for (int c = 0; c < TamanhoCenarioY; c++)
                {
                    Console.Write($"[{this.CenarioTextura[l, c]}]");
                }
                Console.WriteLine("");
            } 
        }

        public void AtualizarJogoVisualizacao() 
        {
            Console.Clear();
            VisualizarCenario();
        }

    }
}