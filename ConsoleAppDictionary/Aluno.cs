using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDictionary
{
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
}
