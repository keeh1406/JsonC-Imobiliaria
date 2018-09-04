using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBD.Model
{
    class Json
    {
        public string id { get; set; }
        public string categoria { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string bairro { get; set; }
        public string status { get; set; }
        public string area_total { get; set; }
        public string area_privativa { get; set; }
        public string iptu { get; set; }
        public string condominio { get; set; }
        public string planta { get; set; }
        public string dependencia { get; set; }
        public string sacada { get; set; }
        public string portaria { get; set; }
        public string elevador { get; set; }
        public string churrasqueira { get; set; }
        public string dormitorios { get; set; }
        public string suites { get; set; }
        public string vagas { get; set; }
        public string banheiros { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string descricao { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string valor_venda { get; set; }
        public string mostrar_mapa { get; set; }
        public string imagem_principal { get; set; }
        public List<string> imagens { get; set; }
        public string valor_aluguel { get; set; }
    }
}
