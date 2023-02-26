using System;

namespace ex023 
{
  class Program
  {
    static void Main()
    {
      IO shell = new IO();
      Calculadora calc = new Calculadora();
      string Calculo;
      string res;

      while (true)
      {
        shell.Clear();
        shell.Print(
          "=======Calculadora Winike======= \n " +
          "=> Adição       (A) \n " +
          "=> Subtração    (S) \n " +
          "=> Multipicação (M) \n " +
          "=> Divição      (D) "
        );
        Calculo = shell.Input(
          "Qual Opção vai escolher? "
        ).ToUpper();

        if (Calculo =="A")
        {
          double num1 = double.Parse(shell.Input(
            "Digite o primeiro numero: "
          ));
          double num2 = double.Parse(shell.Input(
            "Digite o segundo numero: "
          ));
          double resul = calc.Adicao(num1, num2);

          shell.Print($"A resposta da adição é {resul}");     
        }
        else if (Calculo == "S")
        {
          double num1 = double.Parse(shell.Input(
            "Digite o primeiro numero: "
          ));
          double num2 = double.Parse(shell.Input(
            "Digite o segundo numero: "
          ));
          double resul = calc.Subtracao(num1, num2);

          shell.Print($"A resposta da subtração é {resul}");     

        }
        else if (Calculo == "M")
        {
          double num1 = double.Parse(shell.Input(
            "Digite o primeiro numero: "
          ));
          double num2 = double.Parse(shell.Input(
            "Digite o segundo numero: "
          ));
          double resul = calc.Multiplicacao(num1, num2);

          shell.Print($"A resposta da multiplicação é {resul}");     

        }
        else if (Calculo == "D")
        {
          decimal num1 = decimal.Parse(shell.Input(
            "Digite o primeiro numero: "
          ));
          decimal num2 = decimal.Parse(shell.Input(
            "Digite o segundo numero: "
          ));
          decimal resul = calc.Divicao(num1, num2);

          shell.Print($"A resposta da divição é {resul}");     

        }
        else 
        {
          shell.Print(
            "OPÇÃO INVALIDA TENTE NOVAMENTE"
          );
        }

        res = shell.Input(
          "Quer continuar [N]ão/Enter para continuar: "
        ).ToUpper();
        
        if (res == "N")
        {
          break;
        }
      }
    }
  }  
}