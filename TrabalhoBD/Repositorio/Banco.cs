using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoBD.Model;

namespace TrabalhoBD.Repositorio
{
    class Banco
    {
            //Adiciona Imovel
            public int AdicionarImovel(string categoria,
                                         string status,
                                         string faixa_iptu,
                                         string faixa_condominio,
                                         bool flg_planta,
                                         bool flg_dependencia,
                                         bool flg_sacada,
                                         bool flg_portaria,
                                         bool flg_elevador,
                                         string churrasqueira,
                                         string faixa_dormitorios,
                                         string faixa_suites,
                                         string faixa_vagas,
                                         string faixa_banheiros,
                                         string faixa_venda,
                                         string faixa_aluguel,
                                         string bairro
                                         )
            {
                Tabela_Imovel  imovel = new Tabela_Imovel();
                imovel.categoria = categoria;
                imovel.status = status;
                imovel.faixa_condominio = faixa_condominio;
                imovel.flg_planta = flg_planta;
                imovel.flg_dependencia = flg_dependencia;
                imovel.flg_sacada = flg_sacada;
                imovel.flg_protaria = flg_portaria;
                imovel.flg_elevador = flg_elevador;
                imovel.churrasqueira = churrasqueira;
                imovel.faixa_dormitorios = faixa_dormitorios;
                imovel.faixa_suites = faixa_suites;
                imovel.faixa_vagas = faixa_vagas;
                imovel.faixa_banheiros = faixa_banheiros;
                imovel.faixa_venda = faixa_venda;
                imovel.faixa_aluguel = faixa_aluguel;
                imovel.faixa_iptu = faixa_iptu;

            ImobiliariaBDEntities ef = new ImobiliariaBDEntities();
            var id = Convert.ToInt32((from p in ef.Tabela_Bairro where p.nome_bairro == bairro select p.id_bairro).Max());
            imovel.id_bairro = id;
            ef.Tabela_Imovel.Add(imovel);

           

          
            ef.SaveChanges();

                int qtd = Convert.ToInt32((from p in ef.Tabela_Imovel select p.id_imovel).Max());

                return qtd;
            }

 

        //Adiciona Construcão
        #region
        public int RandomNumber()
        {
            Random random = new Random();
            var Ano = random.Next(1900, 2018);

            return Ano;

        }

            public void AdicionarConstrucao(int imovel)
            {

            ImobiliariaBDEntities ef = new ImobiliariaBDEntities();

            Tabela_Construcao construcao = new Tabela_Construcao();
            var id = Convert.ToInt32((from p in ef.Tabela_Imovel select p.id_imovel).Max());

            construcao.ano = RandomNumber();
            construcao.id_imovel = id;

            ef.Tabela_Construcao.Add(construcao);

                ef.SaveChanges();

            }
        #endregion

        //Buscando por Estado
        #region BuscarEstado
        public int BuscarEstado(string nome_Estado)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                int add = (from p in context.Tabela_Estado where p.nome_estado == nome_Estado select p).Count();

                return add;
            }
        }
        #endregion

        #region BucarEstadoporId

        public int BucarEstadoporId(string nome_Estado)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                decimal add = (from p in context.Tabela_Estado where p.nome_estado == nome_Estado select p.id_estado).First();
                int ef = Convert.ToInt32(add);
                return ef;
            }
        }

        #endregion

        #region AdicionaEstado
        public void AdicionaEstado(string nome_Estado)
        {
            ImobiliariaBDEntities ef = new ImobiliariaBDEntities();
            Tabela_Estado estado = new Tabela_Estado();
            estado.nome_estado = nome_Estado;
            ef.Tabela_Estado.Add(estado);

            ef.SaveChanges();
        }
        #endregion

        //Buscando por Cidade
        #region BuscaCidade
        public int BuscaCidade(string nome_Cidade)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                int add = (from p in context.Tabela_Cidade where p.nome_cidade == nome_Cidade select p).Count();

                return add;
            }
        }
        #endregion

        #region AdicionaCidade

        public void AdicionaCidade(string nome_Cidade, string nome_Estado)
        {
            ImobiliariaBDEntities ef = new ImobiliariaBDEntities();
            Tabela_Cidade cidade = new Tabela_Cidade();
            cidade.nome_cidade = nome_Cidade;
            cidade.id_estado = BucarEstadoporId(nome_Estado);
            ef.Tabela_Cidade.Add(cidade);

            ef.SaveChanges();
        }

        #endregion

        #region BuscarCidadeporId
        public int BuscarCidadeporId(string nome_Cidade)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                decimal add = (from p in context.Tabela_Cidade where p.nome_cidade == nome_Cidade select p.id_cidade).First();
                int ef = Convert.ToInt32(add);

                return ef;
            }
        }
        #endregion

        //Buscando por Bairro
        #region AdicionaBairro
        public void AdicionaBairro(string nome_Cidade, string nome_Bairro, long cep)
        {
            ImobiliariaBDEntities ef = new ImobiliariaBDEntities();
            Tabela_Bairro bairro = new Tabela_Bairro();
            bairro.nome_bairro = nome_Bairro;
            bairro.cep = Convert.ToInt32(cep);
            bairro.id_cidade = BuscarCidadeporId(nome_Cidade);
            ef.Tabela_Bairro.Add(bairro);

            ef.SaveChanges();
        }
        #endregion

        #region BuscarBairro
        public int BuscarBairro(string nome_Bairro)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                int add = (from p in context.Tabela_Bairro where p.nome_bairro == nome_Bairro select p).Count();

                return add;
            }
        }
        #endregion

        #region BuscarBairroporId
        public int BuscarBairroporId(string nome_Cidade)
        {
            using (ImobiliariaBDEntities context = new ImobiliariaBDEntities())
            {

                int add = Convert.ToInt32((from p in context.Tabela_Bairro where p.nome_bairro == nome_Cidade select p.id_bairro).First());

                return add;
            }
        }
        #endregion
    }
}