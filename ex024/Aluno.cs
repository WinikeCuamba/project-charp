using System;

namespace ex024
{
  public class Aluno
  {
    private string nome;
    private int anoDeNacimento;
    private int[] notas = new int[3];
    private byte prova;

    public Aluno(string nome, int anoDeNacimento)
    {
      this.AnoDeNacimento = anoDeNacimento;
      this.Nome = nome;
      this.notas[0] = 0;
      this.notas[1] = 0;
      this.notas[2] = 0;


    }
    public byte Prova 
    {
      get 
      {
        return this.prova;        
      }
    }
    public int[] Notas 
    {
      get 
      {
        return this.notas;
      }
    }
    public string Nome 
    {
      get 
      {
        return this.nome;
      }
      set 
      {
        this.nome = value.ToLower();
      }
    }

    public int AnoDeNacimento
    {
      get 
      {
        return this.anoDeNacimento;
      }
      set 
      {
        this.anoDeNacimento = value; 
      }
    }

    public string FazerProva()
    {
      string retorno = "null";
      if (this.prova <= 3)
      {
        Console.Write($"Digite a nota da prova {this.prova + 1}º ");
        try 
        {
          notas[this.prova] = int.Parse(Console.ReadLine());
        }
        catch (Exception e) 
        {
          Console.WriteLine("Excedeu o numero de suas provas ");
        }
        this.prova++;
      }
      else 
      {
        retorno =  "Não podes mais fazer prova porque já fizeste a terceira prova";
      }
      return retorno;
    }
  }
}