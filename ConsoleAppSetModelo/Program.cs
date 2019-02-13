using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSetModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
        }

        class Curso
        {
            private string curso;
            private string aluno;

            public Curso(string curso, string aluno)
            {
                this.curso = curso;
                this.aluno = aluno;
            }

        }
    }
}
