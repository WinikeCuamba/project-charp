using System;

namespace ex026
{
  public class MenuCambio: IMenu
  {
    public Byte Opcao { get; }

    public void ExibirMenu()
    {
      Console.WriteLine(
        "---OPOÇÕES DE CAMBIO--- \n"+
        "[ 1 ] DE METICAL PARA DOLAR \n"+
        "[ 2 ] DE DOLAR PARA METICAL \n"+ 
        "[ 3 ] DE RANDES PARA METICAL \n"+
        "[ 4 ] DE METICAL PARA RANDES \n"
      );
    } 
  }
}