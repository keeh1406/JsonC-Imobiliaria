using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrabalhoBD.Model;
using TrabalhoBD.Repositorio;

namespace TrabalhoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Imovel.json");

            var modelo = JsonConvert.DeserializeObject<List<Json>>(json);

            foreach (var obj in modelo.ToList())
            {



                //Verificando a faixa de preço do IPTU do imovel
                #region Faixa IPTU
                var iptu = Convert.ToDecimal(obj.iptu);
                var fiptu = string.Empty;

                if (!String.IsNullOrEmpty(obj.iptu))
                    if (iptu > 0 && iptu <= 600)
                    {
                        fiptu = "Entre 0 - 600 valores";
                    }
                    else if (iptu > 600 && iptu <= 1200)
                    {
                        fiptu = "Entre 601 - 1200 valores";
                    }
                    else if (iptu > 1200 && iptu <= 1800)
                    {
                        fiptu = "Entre 1201 - 1800 valores";
                    }
                    else
                        fiptu = "Acima de 1801 valores";

                #endregion

                //Verificando a faixa de condominio do imovel
                #region Faixa Condominio
                var condominio = Convert.ToDecimal(obj.condominio);
                var fcondominio = string.Empty;

                if (!String.IsNullOrEmpty(obj.condominio))
                {
                    if (condominio > 0 && condominio <= 100)
                    {
                        fcondominio = "Entre 0 - 100 metros";
                    }
                    else if (condominio > 100 && condominio <= 150)
                    {
                        fcondominio = "Entre 101 - 150 metros";
                    }
                    else if (condominio > 151 && condominio <= 200)
                    {
                        fcondominio = "Entre 151 - 200 metros";
                    }
                    else
                    {
                        fcondominio = "Acima de 201 metros";
                    }
                }
                #endregion

                //Verificando a faixa de dormitorios do imovel
                #region Faixa Dormitorios
                var dormitorio = Convert.ToInt32(obj.dormitorios);
                var fdormitorio = string.Empty;

                if (!String.IsNullOrEmpty(obj.dormitorios))
                {
                    if (dormitorio > 0 && dormitorio <= 2)
                    {
                        fdormitorio = "Entre 0 - 2 dormitorios";
                    }
                    else if (dormitorio > 2 && dormitorio <= 4)
                    {
                        fdormitorio = "Entre 3 - 4" +
                            " dormitorios";
                    }
                    else
                    {
                        fdormitorio = "Acima de 5 dormitorios";
                    }
                }
                #endregion

                //Verificando a faixa de suites do imovel
                #region Faixa Suites
                var suites = Convert.ToInt32(obj.suites);
                var fsuites = string.Empty;

                if (!String.IsNullOrEmpty(obj.suites))
                {
                    if (suites > 0 && suites <= 2)
                    {
                        fsuites = "Entre 0 - 2 suites";
                    }
                    else if (suites > 2 && suites <= 4)
                    {
                        fsuites = "Entre 3 - 4 suites";
                    }
                    else
                    {
                        fsuites = "Acima de 5 suites";
                    }
                }
                #endregion

                //Verificando a faixa de vagas do imovel
                #region Faixa Vagas
                var vagas = Convert.ToInt32(obj.vagas);
                var fvagas = string.Empty;

                if (!String.IsNullOrEmpty(obj.vagas))
                {
                    if (vagas > 0 && vagas <= 2)
                    {
                        fvagas = "Entre 0 - 2 vagas";
                    }
                    else if (vagas > 2 && vagas <= 4)
                    {
                        fvagas = "Entre 3 - 4 vagas";
                    }
                    else
                    {
                        fvagas = "Acima de 5 vagas";
                    }
                }
                #endregion

                //Verificando a faixa de banheiros do imovel
                #region Faixa Banheiros
                var banheiros = Convert.ToInt32(obj.banheiros);
                var fbanheiros = string.Empty;

                if (!String.IsNullOrEmpty(obj.banheiros))
                {
                    if (banheiros > 0 && banheiros <= 2)
                    {
                        fbanheiros = "Entre 0 - 2 banheiros";
                    }
                    else if (banheiros > 2 && banheiros <= 4)
                    {
                        fbanheiros = "Entre 3 - 4 banheiros";
                    }
                    else
                    {
                        fbanheiros = "Acima de 5 banheiros";
                    }
                }
                #endregion

                //Verificando a faixa do valor de venda do imovel
                #region Faixa Venda
                var venda = Convert.ToDecimal(obj.valor_venda);
                var fvenda = string.Empty;

                if (!String.IsNullOrEmpty(obj.valor_venda))
                    if (venda > 0 && venda <= 50000)
                    {
                        fvenda = "Entre 0 - 50.000 valores";
                    }
                    else if (venda > 50000 && venda <= 125000)
                    {
                        fvenda = "Entre 50.001" +
                            " - 125.000 valores";
                    }
                    else if (venda > 125000 && venda <= 200000)
                    {
                        fvenda = "Entre 125.001 - 200.000 valores";
                    }
                    else
                        fvenda = "Acima de 200.001 valores";
                #endregion

                //Verificando a faixa da area privada do imovel
                #region Faixa Aluguel
                var aluguel = Convert.ToDecimal(obj.valor_aluguel);
                var faluguel = string.Empty;

                if (!String.IsNullOrEmpty(obj.valor_aluguel))
                {
                    if (aluguel > 0 && aluguel <= 1000)
                    {
                        faluguel = "Entre 0 - 1.000 valores";
                    }
                    else if (aluguel > 1000 && aluguel <= 1500)
                    {
                        faluguel = "Entre 1001" + " - 1.500 valores";
                    }
                    else if (aluguel > 1500 && aluguel <= 2750)
                    {
                        faluguel = "Entre 1.501 - 2.750 valores";
                    }
                    else
                        faluguel = "Acima de 2.751 valores";
                }
                #endregion


                // Verificação
                #region
                var uf = banco.BuscarEstado(obj.uf);
                var fuf = obj.uf;

                if (uf == 0)
                {
                    banco.AdicionaEstado(fuf);
                }

                //Verificando se Cidade ja existe

                var cidade = banco.BuscaCidade(obj.cidade);
                var fcidade = obj.cidade;

                if (cidade == 0)
                {
                    banco.AdicionaCidade(obj.cidade, obj.uf);
                }

                //Verificando se Bairro ja existe

                var bairro = banco.BuscarBairro(obj.bairro);
                var fbairro = obj.bairro;
                var cep = Convert.ToInt32(obj.cep.Substring(0, 5));

                if (bairro == 0)
                {
                    banco.AdicionaBairro(obj.cidade, fbairro, cep);
                }

                #endregion


                //Metodo para inserir Imovel no Banco
                #region Adicionando Imovel
               var id_imovel = banco.AdicionarImovel(obj.categoria != null ? obj.categoria : null,
                                       obj.status != null ? obj.status : null,
                                       fiptu == "" ? null : fiptu,
                                       fcondominio == "" ? null : fcondominio,
                                       obj.planta.Contains("SIM") ? true : false,
                                       obj.dependencia.Contains("SIM") ? true : false,
                                       obj.sacada.Contains("SIM") ? true : false,
                                       obj.portaria.Contains("SIM") ? true : false,
                                       obj.elevador.Contains("SIM") ? true : false,
                                       obj.churrasqueira != null ? obj.churrasqueira : null,
                                       fdormitorio == "" ? null : fdormitorio,
                                       fsuites == "" ? null : fsuites,
                                       fvagas == "" ? null : fvagas,
                                       fbanheiros == "" ? null : fbanheiros,
                                       fvenda == "" ? null : fvenda,
                                       faluguel == "" ? null : faluguel,
                                       obj.bairro == "" ? null : obj.bairro
                                       );
                #endregion

                // Método para inserir a Construcao no Banco
                #region Adicionando Construcao
                banco.AdicionarConstrucao(id_imovel);
                #endregion

            }
        }
    }
}
