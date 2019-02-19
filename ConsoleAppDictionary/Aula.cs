using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDictionary
{
    class Aula
    {
        private string aula;
        private int codigoAula;

        public Aula(string aula, int codigoAula)
        {
            this.aula = aula;
            this.codigoAula = codigoAula;
        }

        public override string ToString()
        {
            return $"{codigoAula} - {aula}";
        }
    }
}
