using System.Globalization;
using System;
using System.Collections.Generic;
namespace ex027 
{
    public class Jogo 
    {
        public Jogo(Cenario tabuleiro, Teclado teclado, Posicao2D primeiraPos)
        {    
            this.cenario = tabuleiro;
            this.teclado = teclado;
            this.PrimeiraPosicao = primeiraPos;
            this.Caracter = this.Bola;
        }
        
        public int Jogada { get; set;}

        public char Bola = Convert.ToChar("O"); 
        public char Xixi = Convert.ToChar("X");

        public Posicao2D PrimeiraPosicao { get; set; }
        public bool Iscliked { get; set; }

        public char Caracter { get; set; }

        public List<Posicao2D> PosicoesMarcadas { get; set; }
        public List<Posicao2D> PosicoesMarcadasXixi { get; set; }
        public List<Posicao2D> PosicoesMarcadasBola { get; set; }
        private ICenario cenario;

        private Teclado teclado;

        public void IniciarJogo() 
        {
            this.PosicoesMarcadas = new List<Posicao2D>();
            this.PosicoesMarcadasXixi = new List<Posicao2D>();
            this.PosicoesMarcadasBola = new List<Posicao2D>();
            this.cenario.VisualizarCenario();
            atualizarJogo();
        }
        public void atualizarJogo()
        {
            this.cenario.AtualizarJogoVisualizacao();
            this.teclado.AtualizarPosicaoDoTeclado();
            this.Iscliked = FoiClicado();
            this.PosicionarCorectamente(this.Iscliked);
            MovendoOAlgarismo(this.teclado.Posicao);
        }
        private void MovendoOAlgarismo(Posicao2D posicao)
        {
            bool foiMarcada = this.PosicaoFoiMarcada();
            if (!foiMarcada)
            {
                this.cenario.AlterarVisualizacaoDoCenario(this.PrimeiraPosicao.X, this.PrimeiraPosicao.Y, Convert.ToChar(" "));
            }
            this.PrimeiraPosicao.X = posicao.X;
            this.PrimeiraPosicao.Y = posicao.Y;
            this.cenario.AlterarVisualizacaoDoCenario(posicao.X, posicao.Y, this.Caracter);
            atualizarJogo();
        }
        private void AdicionandoElementoNoCenario(Posicao2D posicao)
        {
            this.cenario.AlterarVisualizacaoDoCenario(posicao.X, posicao.Y, this.Caracter);
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
            bool click = this.teclado.Click();
            return click;
        }
        private bool PosicaoFoiMarcada()
        {
            bool esta = false;
            if (this.Caracter == this.Bola)
            {
                esta = this.PosicaoEstaNoVector(this.PrimeiraPosicao, this.PosicoesMarcadas);
            }
            if (this.Caracter == this.Xixi)
            {
                esta = this.PosicaoEstaNoVector(this.PrimeiraPosicao, this.PosicoesMarcadas);
            }
            return esta;
        }
        public bool PosicaoEstaNoVector(Posicao2D pos, List<Posicao2D> posicoesNoVector)
        {
            bool esta = false;
            for (int p = 0; p < posicoesNoVector.Count; p++)
            {
                if ( pos.X == posicoesNoVector[p].X || pos.Y == posicoesNoVector[p].Y )
                {
                    esta = true;
                }
            }
            return esta;
        }

        public void PosicionarCorectamente(bool clique)
        {
            if (clique)
            {
                AdicionandoElementoNoCenario(this.teclado.Posicao);
                if (this.Caracter == this.Bola)
                {
                    Posicao2D pos = new Posicao2D(this.teclado.Posicao.X, this.teclado.Posicao.Y);
                    this.PosicoesMarcadasBola.Add(pos);
                    this.PosicoesMarcadas.Add(pos);
                }
                else if (this.Caracter == this.Xixi)
                {
                    Posicao2D pos = new Posicao2D(this.teclado.Posicao.X, this.teclado.Posicao.Y);
                    this.PosicoesMarcadasXixi.Add(pos);
                    this.PosicoesMarcadas.Add(pos);
                }
            }
        }
    }
}