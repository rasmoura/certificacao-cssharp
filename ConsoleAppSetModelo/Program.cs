using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSetModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            Curso csharpColecoes = new Curso();
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();

            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Console.WriteLine();

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

            Console.ReadKey();
            //csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            //csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            //csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
        }

    }

    class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }
        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }
        public override int GetHashCode()
        {
            //var hashCode = -1774929330;
            //hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            //hashCode = hashCode * -1521134295 + numeroMatricula.GetHashCode();
            //hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            //hashCode = hashCode * -1521134295 + NumeroMatricula.GetHashCode();
            //return hashCode;

            return this.nome.GetHashCode();
        }
    }

    class Curso
    {
        private string curso;
        private string aluno;
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public Curso()
        {
        }

        public Curso(string curso, string aluno)
        {
            this.curso = curso;
            this.aluno = aluno;
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        internal bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }

}
