using System;

namespace ex026
{
  public class Cambio: IServico
  {
    // Constantes das opções 
    protected const Byte OPCAO_METICAL_DOLAR = 1;
    protected const Byte OPCAO_DOLAR_METICAL = 2;
    protected const Byte OPCAO_RANDE_METICAL = 3;
    protected const Byte OPCAO_METICAL_RANDE = 4;

    // Constantes das moedas 
    protected const float DOLAR_POR_METICAL = 0.016F;
    protected const float METICAL_POR_DOLAR =  63.83F;
    protected const float RANDE_POR_METICAL = 0.26F;
    protected const float METICAL_POR_RANDE = 3.79F; 

    private float metical, dolar, rande;
    //Variavel da opcao 
    private Byte opcao;

    // Metodo que efectua o servico
    public void EfetuarServico(Byte opcao)  
    {
      this.opcao = opcao;
      switch (this.opcao) 
      {
        case (OPCAO_METICAL_DOLAR):
          Console.WriteLine($"{DOLAR_POR_METICAL}US$ custa 1MT");
          Console.Write("Quantos meticaís queres cambiar? ");
          this.metical = Convert.ToInt32(Console.ReadLine());
          this.dolar = this.CambiarMeticalDolar(this.metical);
          Console.WriteLine($"O cambio foi de {this.metical}MT para {this.dolar}US$");
          break;
        
        case (OPCAO_DOLAR_METICAL):
          Console.WriteLine($"{METICAL_POR_DOLAR}MT custa 1US$");
          Console.Write("Quantos dolates queres cambiar? ");
          this.dolar = Convert.ToInt32(Console.ReadLine());
          this.metical = this.CambiarDolarMetical(this.dolar);
          Console.WriteLine($"O cambio foi de {this.dolar}US$ para {this.metical}MT");
          break;
        
        case (OPCAO_RANDE_METICAL):
          Console.WriteLine($"{METICAL_POR_RANDE}MT custa 1RAR");
          Console.Write("Quantos randes qures cambiar? ");
          this.rande = Convert.ToInt32(Console.ReadLine());
          this.metical = this.CambiarRandeMetical(this.rande);
          Console.WriteLine($"O cambio foi de {this.rande}RAR para {this.metical}MT");
          break;
        
        case (OPCAO_METICAL_RANDE):
          Console.WriteLine($"{RANDE_POR_METICAL}RAR custa MT");
          Console.Write($"Quantos meticaís queeres cambiar? ");
          this.metical = Convert.ToInt32(Console.ReadLine());
          this.rande = this.CambiarMeticalRande(this.metical);
          Console.WriteLine($"O cambio foi de {this.metical}MT para {this.rande}RAR");
          break;

        default:
          Console.WriteLine("Opção invalida\n volte sempre");
          break;
      }
    }

    private float CambiarMeticalDolar(float metical)
    {
      return metical * DOLAR_POR_METICAL;    
    }

    private float CambiarDolarMetical(float dolar)
    {
      return dolar * METICAL_POR_DOLAR;    
    }

    private float CambiarRandeMetical(float rande)
    {
      return rande * METICAL_POR_RANDE;    
    }

    private float CambiarMeticalRande(float metical)
    {
      return metical * RANDE_POR_METICAL;    
    }

  } 
}