using System;
using Modelos;

class AulaObjeto {

  public static void Imprimir(Aluno aluno,
                             Disciplina disciplina){
    if (aluno.Matricular(disciplina)){
      Console.WriteLine(aluno.Matricula);
    }
  }
  
  public static void Main (string[] args){  
    Aluno aluno1 = new Aluno {
      Matricula = "012022",
    };
    
    Aluno aluno2 = new Aluno{
      Matricula = "022023",

    };
    
    Disciplina disciplina = new Disciplina{
      nome = "Linguagem de Programação",
  
    };

     Imprimir(aluno1, disciplina);
     Imprimir(aluno2, disciplina);
  }
}