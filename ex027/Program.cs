using  System;

namespace ex027
{
  class Program
  {
    static void Main()
    {
      string[,] matriz = new string[3,3] {{" "," "," "},{" "," "," "},{" "," "," "}};
      Jogo jogo = 
        new Jogo(
          new Cenario(matriz, 3, 3),
          new Teclado()
        );
      jogo.IniciarJogo();
      
    } 
  }
}