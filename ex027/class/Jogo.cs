using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace ex027 
{
    public class Jogo 
    {
        public Jogo(Cenario tabuleiro, Teclado teclado)
        {    
            this.cenario = tabuleiro;
            this.teclado = teclado;
            this.PrimeiraPosicaoX = 0;
            this.PrimeiraPosicaoY = 0; 
            this.Caracter = this.Bola;
        }
        
        public int Jogada { get; set;}
        public char Bola = Convert.ToChar("O"); 
        public char Xixi = Convert.ToChar("X");
        public byte PrimeiraPosicaoX { get; set; }
        public byte PrimeiraPosicaoY { get; set; }
        public bool Iscliked { get; set; }
        public char Caracter { get; set; }
        public byte[] PosicoesMarcadasX { get; set; }
        public byte[] PosicoesMarcadasY { get; set; }
        private ICenario cenario; 
        private Teclado teclado;

        public void IniciarJogo() 
        {
            this.PosicoesMarcadasX = new byte[5];
            this.PosicoesMarcadasY = new byte[5];
            this.cenario.VisualizarCenario();
            atualizarJogo();
        }
        public void atualizarJogo()
        {
            this.cenario.AtualizarJogoVisualizacao();
            this.teclado.AtualizarPosicaoDoTeclado();
            this.Iscliked = FoiClicado();
            if (this.Iscliked)
            {
                AdicionandoElementoNoCenario(this.teclado.x, this.teclado.y);
            }
            MovendoOAlgarismo(this.teclado.x, this.teclado.y);
        }
        private void MovendoOAlgarismo(byte x, byte y)
        {
      
            this.cenario.AlterarVisualizacaoDoCenario(this.PrimeiraPosicaoX, this.PrimeiraPosicaoY, Convert.ToChar(" "));
            this.PrimeiraPosicaoX = x;
            this.PrimeiraPosicaoY = y;
            this.cenario.AlterarVisualizacaoDoCenario(x, y, this.Caracter);
            atualizarJogo();
        }
        private void AdicionandoElementoNoCenario(byte x, byte y)
        {
            this.cenario.AlterarVisualizacaoDoCenario(x, y, this.Caracter);
            if (this.Caracter == this.Bola)
            {
                this.Caracter = this.Xixi;
            }
            else 
            {
                this.Caracter = this.Bola;
            }
        }
        private bool FoiClicado()
        {
            bool click = this.teclado.IsCliked;
            this.teclado.IsCliked = false;
            return click;
        }
    }
}