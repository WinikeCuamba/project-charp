using System;

namespace ex024
{
  class Program 
  {
    static void Main()
    {
      Aluno aluno1 = new Aluno("winike", 2013);
      Console.Clear();
      var res = aluno1.FazerProva();
      Console.WriteLine($" O aluno {aluno1.Nome} teve {aluno1.Notas[0]} na prova {aluno1.Prova}");
      res = aluno1.FazerProva();
      Console.WriteLine($" O aluno {aluno1.Nome} teve {aluno1.Notas[1]} na prova {aluno1.Prova}");
      res = aluno1.FazerProva();
      Console.WriteLine($" O aluno {aluno1.Nome} teve {aluno1.Notas[2]} na prova {aluno1.Prova}");
      Console.WriteLine(res);         
    }
  }
}