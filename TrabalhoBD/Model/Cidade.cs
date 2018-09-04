using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBD.Model
{
    class Cidade
    {
        public int id_Cidade { get; set; }
        public string nome_Cidade { get; set; }
        public List<Estado> Estado { get; set; }
    }
}
