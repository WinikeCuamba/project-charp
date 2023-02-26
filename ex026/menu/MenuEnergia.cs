using System;

namespace ex026
{
  public class MenuEnergia: IMenu
  {
    public Byte Opcao { get; }
    public void ExibirMenu()
    {
      Console.WriteLine(
        "---Opções de energia--- \n" +
        "[ 1 ] Quanto custa a energia \n" +
        "[ 2 ] Quantos MT são necessários para comprar energia x"
      );
    }
  }

}