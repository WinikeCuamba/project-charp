using System;

namespace ex026
{
  class MenuPrincipal: IMenu
  {
    public Byte Opcao { get; } 
    public void ExibirMenu()
    {
      Console.WriteLine(
        "-----LOJA WINIKE---- \n" +
        "[ 1 ] Energia \n" +
        "[ 2 ] GOTV \n" +
        "[ 3 ] Cambio \n" +
        "[ 4 ] Sair \n" 
      );
    }
  }
}