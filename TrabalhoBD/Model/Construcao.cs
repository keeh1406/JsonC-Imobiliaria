using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBD.Model
{
    class Construcao
    {
        public int id_Contrucao { get; set; }
        public int Ano { get; set; }
        public List<Imovel> Imovel;
    }
}
