using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTeste
{
    public class TesteLib: ITestando
    {
        public int ID { get; set; }
        public string Sobrenome { get; set; }

        public string TesteRetorno(string valor)
        {
            return $"Valor retornado é {valor}";
        }
    }
}
