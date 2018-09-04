using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBD.Model
{
    class Bairro
    {
        public int id_Bairro { get; set; }
        public string nome_Bairro { get; set; }
        public long cep_Bairro { get; set; }
        public List<Cidade> Cidade { get; set; }
    }
}
