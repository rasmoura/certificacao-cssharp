using System;
using System.Collections.Generic;

namespace _02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //DICIONÁRIO

            //declarando dicionário de filmes
            Dictionary<int, Filme> filmes = new Dictionary<int, Filme>();
            filmes.Add(34672, esperanca);
            filmes.Add(5617, imperio);
            filmes.Add(17645, retorno);

            Console.WriteLine("imprimindo filmes cadastrados:");
            foreach (var item in filmes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Imprimindo keys dos filmes:");
            foreach (var item in filmes)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();
            Console.WriteLine("Imprimindo values dos filmes:");
            foreach (var item in filmes)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();

            //um dicionario permite associar uma chave (ID do filme) a um valor (o filme)

            //qual é o filme com ID 34672?
            Console.WriteLine("Qual é o filme com ID 34672? " + filmes[34672]);

            //e se tentarmos adicionar outro filme com a mesma chave?
            //filmes.Add(34672, ameaca);
            //não é possivel adicionar um filme com uma chave existente, nao permite duplicadade;

            //e se quisermos trocar o filme que tem a mesma chave?
            filmes[34672] = ameaca;

            //qual é o filme de chave 34672?
            Console.WriteLine();
            Console.WriteLine("Qual é o filme de chave 34672 agora?" + filmes[34672]);

            //buscando uma chave que não existe: 34673
            //Console.WriteLine();
            //Console.WriteLine("Verificando se a chave 34673 existe " + filmes[34673]);
            //Quando se busca uma chave que não existe no dicionario, 
            //retorna exceção:
            //System.Collections.Generic.KeyNotFoundException: 'The given key '34673' was not present in the dictionary.'

            //verificando se uma chave existe: 34763
            Console.WriteLine();
            Console.WriteLine("Verificando se uma chave existe: 34763 -  " + filmes.ContainsKey(34763));

            //buscando uma chave de forma segura
            Console.WriteLine();

            filmes.TryGetValue(34763, out Filme filme34763);

            if (filme34763 == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Filme com chave 34673 não existe.");
            }


        }

        public class Filme : IComparable
        {
            public Filme(string titulo, int ano)
            {
                Titulo = titulo;
                Ano = ano;
            }

            public string Titulo { get; set; }
            public int Ano { get; set; }

            public int CompareTo(object obj)
            {
                Filme esta = this;
                Filme outra = obj as Filme;

                if (outra == null)
                {
                    return 1;
                }

                return esta.Titulo.CompareTo(outra.Titulo);
            }

            public override string ToString()
            {
                return $"{Titulo} - {Ano}";
            }

            public override bool Equals(object obj)
            {
                Filme outra = obj as Filme;
                if (outra == null)
                {
                    return false;
                }

                return outra.Titulo.Equals(this.Titulo)
                    && outra.Ano.Equals(this.Ano);
            }

            public override int GetHashCode()
            {
                var hashCode = -131496797;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
                hashCode = hashCode * -1521134295 + Ano.GetHashCode();
                return hashCode;
            }
        }
    }
}