using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using DTO;

namespace Negocios
{
    public class UnidadeNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Unidade unidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UnidadeNome", unidade.UnidadeNome);
                acessoDadosSqlServer.AdicionarParametros("@UnidadeCidade", unidade.UnidadeCidade);
                acessoDadosSqlServer.AdicionarParametros("@UnidadeEstado", unidade.UnidadeEstado);
                acessoDadosSqlServer.AdicionarParametros("@UnidadePais", unidade.UnidadePais);
                string UnidadeID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUnidadeInserir").ToString();

                return UnidadeID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Unidade unidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UnidadeID", unidade.UnidadeID);
                acessoDadosSqlServer.AdicionarParametros("@UnidadeNome", unidade.UnidadeNome);
                acessoDadosSqlServer.AdicionarParametros("@UnidadeCidade", unidade.UnidadeCidade);
                acessoDadosSqlServer.AdicionarParametros("@UnidadeEstado", unidade.UnidadeEstado);
                acessoDadosSqlServer.AdicionarParametros("@UnidadePais", unidade.UnidadePais);
                string UnidadeID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUnidadeAlterar").ToString();

                return UnidadeID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Unidade unidade)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UnidadeID", unidade.UnidadeID);
                string UnidadeID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUnidadeExcluir").ToString();

                return UnidadeID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public UnidadeColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            UnidadeColecao unidadeColecao = new UnidadeColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@UnidadeNome", nome);
            DataTable dataTableUnidade = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUnidadeConsultarPorNome");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableUnidade.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Unidade unidade = new Unidade();
                unidade.UnidadeID = Convert.ToInt32(linha["Código"]);
                unidade.UnidadeNome = Convert.ToString(linha["Unidade"]);
                unidade.UnidadeCidade = Convert.ToString(linha["Cidade"]);
                unidade.UnidadeEstado = Convert.ToString(linha["Estado"]);
                unidade.UnidadePais = Convert.ToString(linha["País"]);
                unidadeColecao.Add(unidade);
            }
            return unidadeColecao;
        }
    }
}
