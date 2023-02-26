namespace ex027 
{
  interface ICenario 
  {
    public void VisualizarCenario() {}
    public void  AlterarVisualizacaoDoCenario(byte posicaoX, byte posicaoY, char caracter) {}
    public void AtualizarJogoVisualizacao() {}
  }
}