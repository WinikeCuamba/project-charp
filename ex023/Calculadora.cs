using System;

namespace ex023 
{
  public class Calculadora
  {
    public double  Adicao(double num1, double num2)
    {
      return num1 + num2;
    }

    public double Subtracao(double num1, double num2)
    {
      return num1 - num2;
    }

    public decimal Divicao(decimal num1, decimal num2)
    {
      return num1 / num2;
    }
    
    public double Multiplicacao(double num1, double num2)
    {
      return num1 * num2;
    }

    //  Em teste 
    // public decimal Radiacao(int num1)
    // {
    //   decimal meia = 0.5M;
    //   return num1 ^ meia;
    // }

    // public double Esponeciacao(double num1, double num2)
    // {
    //   return num1 ^ num2;
    // }
  }
}