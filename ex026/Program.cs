using System;

namespace ex026
{
  class Program 
  {
    static void Main()
    {
      String resposta = "N";
      // IMenu menu = new MenuPrincipal();
      do {
        Console.Clear();
        Loja loja =
        new Loja(
          new MenuPrincipal(),
          new MenuEnergia(),
          new MenuGotv(),
          new MenuCambio(),
          new Energia(),
          new Gotv(),
          new Cambio()
        );
        loja.IniciarLoja();
        Console.Write("Digite N para parar S/Enter para continuar: ");
        String res = Console.ReadLine().ToUpper();
        resposta = Convert.ToString(res[0]); 

      } while (resposta != "N");
      
    }
  }
}