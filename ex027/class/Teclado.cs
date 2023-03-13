using System.Globalization;
using System;

namespace ex027
{
    public class Teclado
    {

        public const ConsoleKey W = ConsoleKey.W;
        public const ConsoleKey S = ConsoleKey.S;
        public const ConsoleKey A = ConsoleKey.A;
        public const ConsoleKey D = ConsoleKey.D;
        public const ConsoleKey CIMA = ConsoleKey.UpArrow;
        public const ConsoleKey BAIXO = ConsoleKey.DownArrow;
        public const ConsoleKey ESQUERDA = ConsoleKey.LeftArrow;
        public const ConsoleKey DIREITA = ConsoleKey.RightArrow;
        public const ConsoleKey SAIR = ConsoleKey.Escape;
        public const ConsoleKey ESPACO = ConsoleKey.Spacebar;
        public const ConsoleKey ENTER = ConsoleKey.Enter;  
        public Posicao2D Posicao { get; }
        public bool EstaClicado = false;

        public Teclado(Posicao2D posicao)
        {
            this.Posicao = posicao;
        }
        public void AtualizarPosicaoDoTeclado()
        {
            var key = Console.ReadKey().Key;
            switch (key)
            {
                //Movimentaco com teclas (WSAD)
                case (W):
                    if (this.Posicao.Y > 0)
                    {
                        this.Posicao.Y--;
                    }
                    break;

                case (S):
                    if (this.Posicao.Y < 2)
                    {
                        this.Posicao.Y++;
                    }
                    break;

                case (A):
                    if (this.Posicao.X > 0)
                    {
                        this.Posicao.X--;
                    }
                    break;

                case (D):
                    if (this.Posicao.X < 2)
                    {
                        this.Posicao.X++;
                    }
                    break;

                //Movimentacao com setas
                case (CIMA):
                    if (this.Posicao.Y > 0)
                    {
                        this.Posicao.Y--;
                    }
                    break;

                case (BAIXO):
                    if (this.Posicao.Y < 2)
                    {
                        this.Posicao.Y++;
                    }
                    break;

                case (ESQUERDA):
                    if (this.Posicao.X > 0)
                    {
                        this.Posicao.X--;
                    }
                    break;

                case (DIREITA):
                    if (this.Posicao.X < 2)
                    {
                        this.Posicao.X++;
                    }
                    break;

                case (ESPACO):
                    this.EstaClicado = true;
                    break;

                case (ENTER):
                    this.EstaClicado = true;
                    break;
                default:
                    break;
            }

        }
        public bool Click()
        {
            bool clicado = this.EstaClicado;
            this.EstaClicado = false;
            return clicado;
        }
    }
}
