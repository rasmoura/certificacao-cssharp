using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDictionary
{
    class Curso
    {
        private IDictionary<int, Aluno> matriculaParaAluno = new Dictionary<int, Aluno>();

        private string curso;

        private string aluno;

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        private ISet<Aula> aulas = new HashSet<Aula>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public IList<Aula> Aulas
        {
            get
            {
                return new ReadOnlyCollection<Aula>(aulas.ToList());
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
            matriculaParaAluno.Add(aluno.NumeroMatricula, aluno);
        }

        internal bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //foreach (var aluno in this.alunos)
            //{
            //    if (aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }
            //}

            //throw new KeyNotFoundException("Matricula não encontrada: " + numeroMatricula);
            
            //Aluno result;
            matriculaParaAluno.TryGetValue(numeroMatricula, out Aluno result);
            return result;
        }

        internal void substituirMatricula(Aluno aluno)
        {
            alunos.Add(aluno);
            matriculaParaAluno[aluno.NumeroMatricula] = aluno;
        }

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }
    }
}
