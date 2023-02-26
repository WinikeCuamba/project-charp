using System;

namespace ex026
{
  public class Energia: IServico 
  {
    // Constantes das opções 
    const float PRECO_ENERGIA = 8.44F;
    const int OPCAO_PRECO_ENERGIA = 1;
    const int OPCAO_COMPRAR_ENERGIA = 2;
    private Byte opcao;
    public Byte Opcao 
    {
       get { return this.opcao; }
    }
    
    public void EfetuarServico(Byte opcao) 
    {
      if (opcao == OPCAO_PRECO_ENERGIA)
      {
        Console.WriteLine("A energia custa 8.44MT");
      }
      else if (opcao == OPCAO_COMPRAR_ENERGIA)
      {
        Console.Write("A energia custa 8.44MT por kwh.\nQuantos kwh vai comprar? ");
        int kwh = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{kwh}kwh são {kwh * PRECO_ENERGIA}MT\n[S]/Enter para comfirmar e [N] para rejeitar ");
        String res = Console.ReadLine();

        if (res.ToUpper() != "N")
        {
          Console.WriteLine("Pagamento efetuado com sucesso\nObrigado volte sempre");
        }
        else
        {
          Console.WriteLine("Pagamento canselado");
        }
      }
      else
      {
        Console.WriteLine("Opcao invalida tente novamente");
      }
    }
  }
}