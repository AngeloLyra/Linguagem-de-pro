using Modelos;

class Aula5 {
public static void Main (string[] args) {
  Aluno aluno1 = new Aluno(0);
  aluno1.Cpf = "422.657.877-99";
  Impressora.Imprimir(aluno1);
  Aluno aluno2 = new Aluno(1);
  aluno2.Cpf = "660.036.460-20";
  Impressora.Imprimir(aluno2);
  //Pessoa pessoa1 = new Pessoa();
  Pessoa pessoa1 = new Professor();
  pessoa1.Cpf = "422.657.877-99";
  Impressora.Imprimir(pessoa1);
  Pessoa pessoa2 = (Pessoa) aluno2;
  Impressora.Imprimir(pessoa2);
  Aluno aluno3 = (Aluno) pessoa2;
  Impressora.Imprimir(aluno3);
  Professor professor1 = new Professor();
  professor1.Cpf = "423.613.317-09";
  Impressora.Imprimir(professor1);
  Familiar familiar1 = new Familiar();
  familiar1.Cpf = "069.705.698-28";
  Impressora.Imprimir(familiar1);
  }
}