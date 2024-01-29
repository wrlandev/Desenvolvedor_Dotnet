namespace Propiedades.Models
{
    internal class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto =  $"N{count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
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
