using System;

namespace ex026
{
  public class MenuGotv: IMenu
  {
    public Byte Opcao { get; }

    public void ExibirMenu() 
    {
      Console.WriteLine(
        "---OPOÇÕES DA GOTV--- \n"+
        "[ 1 ] Quanto custa o pacote essencial? \n"+ 
        "[ 2 ] Quanto custa o pacote plus \n" +
        "[ 3 ] Quanto custa o pacote Max"
      );
    }
  }
  
}