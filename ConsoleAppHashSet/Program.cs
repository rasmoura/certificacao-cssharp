using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();

            Console.WriteLine(string.Join(", ", alunosEmLista));
            Console.WriteLine();

        }
    }
}
