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
        public byte x = 0;
        public byte y = 0;
        public bool IsCliked = false;
        public void AtualizarPosicaoDoTeclado()
        {
            var key = Console.ReadKey().Key;
            switch (key)
            {
                //Movimentaco com teclas (WSAD)
                case (W):
                    if (this.y > 0)
                    {
                        this.y--;
                    }
                    break;

                case (S):
                    if (this.y < 2)
                    {
                        this.y++;
                    }
                    break;

                case (A):
                    if (this.x > 0)
                    {
                        this.x--;
                    }
                    break;

                case (D):
                    if (this.x < 2)
                    {
                        this.x++;
                    }
                    break;

                //Movimentacao com setas
                case (CIMA):
                    if (this.y > 0)
                    {
                        this.y--;
                    }
                    break;

                case (BAIXO):
                    if (this.y < 2)
                    {
                        this.y++;
                    }
                    break;

                case (ESQUERDA):
                    if (this.x > 0)
                    {
                        this.x--;
                    }
                    break;

                case (DIREITA):
                    if (this.x < 2)
                    {
                        this.x++;
                    }
                    break;

                case (ESPACO):
                    Click();
                    break;

                case (ENTER):
                    Click();
                    break;
                default:
                    break;
            }

        }
        private void Click()
        {
            this.IsCliked = true;
        }
    }
}
