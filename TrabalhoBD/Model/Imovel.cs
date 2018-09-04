using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBD.Model
{
    class Imovel
    {
        public int id_Imovel { get; set; }
        public string Categoria { get; set; }
        public string Status { get; set; }
        public string Faixa_IPTU { get; set; }
        public string Faixa_Condominio { get; set; }
        public bool Flg_Planta { get; set; }
        public bool Flg_Dependencia { get; set; }
        public bool Flg_Sacada { get; set; }
        public bool Flg_Portaria { get; set; }
        public bool Flg_Elevador { get; set; }
        public string Churrasqueira { get; set; }
        public string Faixa_Dormintorios { get; set; }
        public string Faixa_Suites { get; set; }
        public string Faixa_Vagas { get; set; }
        public string Faixa_Banheiros { get; set; }
        public string Faixa_Valor_Venda { get; set; }
        public string Faixa_Valor_Aluguel { get; set; }
        public List<Bairro> Bairro;
    }
}
