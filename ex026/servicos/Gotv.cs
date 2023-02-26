namespace ex026 
{
  public class Gotv: IServico
  {
    protected const Byte PACOTE_ESSENCIAL = 1;
    protected const Byte PACOTE_PLUS = 2;
    protected const Byte PACOTE_MAX = 3; 
    private Byte opcao; 
    public void EfetuarServico(Byte opcao)
    {
      this.opcao = opcao;

      switch (this.opcao)
      {
        case (PACOTE_ESSENCIAL):
          Console.WriteLine("O preço do pacote essencial custa 200MT");
          break;

        case (PACOTE_PLUS):
          Console.WriteLine("O preço do pacote plus custa 500MT");
          break;

        case (PACOTE_MAX):
          Console.WriteLine("O preço do pacote max custa 900MT");
          break;

        default:
          Console.WriteLine("Opção invalida\nTente novamente");
          break;
      }

    }
  }
}