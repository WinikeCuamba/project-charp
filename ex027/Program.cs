using  System;

namespace ex027
{
  class Program
  {
    static void Main()
    {
      string[,] matriz = new string[3,3] {{" "," "," "},{" "," "," "},{" "," "," "}};
      Cenario cenario = new Cenario(matriz, 3, 3);
      Teclado teclado = new Teclado( new Posicao2D(0,0) );
      Posicao2D posicao = new Posicao2D(0, 0);

      Jogo jogo = new Jogo( cenario, teclado, posicao);
      jogo.IniciarJogo();
      
    } 
  }
}