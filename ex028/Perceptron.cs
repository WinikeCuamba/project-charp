using System;

namespace ex028
{
   class Perceptron 
   {
      Perceptron(float Ipeso)
      {
         this.peso = Ipeso;
      }
      private float peso = Random;
      private int[,] entrada;
      public int[,] Entrada
      { 
         get 
         {
            return this.entrada;
         }
         set 
         {
            this.entrada = value;
         }
      }
      public int[] Saida
      { 
         get 
         {
            return this.entrada;
         }
         set 
         {
            this.entrada = value;
         }
      }
      public void IniciarTenamento(int NumeroDeRepeticaoDeTreino, float num1DaEntrada, float num2DaEntrada)
      {
         this.Saida;
         float yEsperado;
         this.Entrada[0, 0] = num1DaEntrada;
         this.Entrada[0, 1] = num2DaEntrada;

         for (int i = 0; i < NumeroDeRepeticaoDeTreino; i++)
         {
            
         }
      }
      private float FuncaoDeAtivacao(float[] Entrada, float peso)
      {
         float func = Entrada[0, 0] * peso + Entrada[0, 1] * peso;
         float y;
         if (func > 1)
         {
            y = 1;
         } else if ( func < 0 )
         {
            y = 0; 
         }
         return y;
      }

      private float CalcularFalha(float[,] entradas, float saida)
      {
         float saidaDesejada;
         if (entrada[0,0] < 0 || entrada[0,1] < 0)
         {
            float saidaDesejada = 0;

         } else if (entrada[0,0] < 1 || entrada[0,1] < 0)
         {
            float saidaDesejada = 0;

         } else if (entrada[0,1] < 1 || entrada[0,0] < 0)
         {
            float saidaDesejada = 0;

         } else if (entrada[0,1] < 1 || entrada[0,1] < 0)
         {
            float saidaDesejada = 1;
         }

         if (saida < saidaDesejada)
         {
            return 0.1;

         } else if (saida > saidaDesejada)
         {
            return -0.1;
         }
      }
  }
}