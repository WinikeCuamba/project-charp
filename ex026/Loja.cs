namespace ex026
{
  public class Loja
  {
    public Loja(
      IMenu menuPrincipal,
      IMenu menuEnergia,
      IMenu menuGotv,
      IMenu menuCambio,
      IServico servicoEnergia,
      IServico servicoGotv,
      IServico servioCambio
      )
    {
      this.MenuPrincipal = menuPrincipal;
      this.MenuEnergia = menuEnergia;
      this.MenuGotv = menuGotv;
      this.MenuCambio = menuCambio;

      this.ServicoEnergia = servicoEnergia;
      this.ServicoGotv = servicoGotv;
      this.ServicoCambio = servioCambio;
    }

    // Constantes da opções
    const Byte OPCAO_ENERGIA = 1;
    const Byte OPCAO_GOTV = 2;
    const Byte OPCAO_CAMBIO = 3;
    const  Byte OPCAO_SAIR = 4;

    // Inicialização dos menus 
    public IMenu MenuPrincipal { get; }
    public IMenu MenuEnergia { get; }
    public IMenu MenuGotv { get; }
    public IMenu MenuCambio { get; }

    // Incialização dos servicos 
    private IServico ServicoEnergia;
    private IServico ServicoGotv;
    private IServico ServicoCambio;

    // Inicialização da variaveis da Opcao 
    private Byte Opcao;
    private Byte SubOpcao;
    public void IniciarLoja()
    {
      this.MenuPrincipal.ExibirMenu();
      Console.Write("Qual opção vai escolher? ");
      this.Opcao = Convert.ToByte(Console.ReadLine());

      switch (this.Opcao)
      {
        case (OPCAO_ENERGIA):
          this.MenuEnergia.ExibirMenu();
          Console.Write("Qual opção vais escolher? ");
          this.SubOpcao = Convert.ToByte(Console.ReadLine());
          this.ServicoEnergia.EfetuarServico(this.SubOpcao);
          break;

        case (OPCAO_GOTV):
          this.MenuGotv.ExibirMenu();
          Console.Write("Qual opção vais escolher? ");
          this.SubOpcao = Convert.ToByte(Console.ReadLine());
          this.ServicoGotv.EfetuarServico(this.SubOpcao);
          break;
          
        case (OPCAO_CAMBIO):
          this.MenuCambio.ExibirMenu();
          Console.Write("Qual opção vais escolher? ");
          this.SubOpcao = Convert.ToByte(Console.ReadLine());
          this.ServicoCambio.EfetuarServico(this.SubOpcao);
          break;

        case (OPCAO_SAIR):
          Console.WriteLine("OBRIGADO VOLTE SEMPRE");
          break;
        
        default:
          Console.WriteLine(
            "Opcao invalida tente novamente\n Tente novamente"
          );
          break;
      }
    }    
  }
}

