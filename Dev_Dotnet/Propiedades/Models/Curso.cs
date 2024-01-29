namespace Propiedades.Models
{
    internal class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void ListarAluno()
        {
           foreach(Pessoa aluno in  Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }

        }
        public int ObterQuantidadeDeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
    }
}
