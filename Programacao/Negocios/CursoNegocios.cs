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
    public class CursoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
		
		public string Inserir(Curso curso)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CursoNome", curso.CursoNome);
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidade", curso.CursoUnidadeID);
                acessoDadosSqlServer.AdicionarParametros("@CursoCoordenador", curso.CursoCoordenador);
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoInserir").ToString();

                return CursoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Curso curso)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CursoID", curso.CursoID);
                acessoDadosSqlServer.AdicionarParametros("@CursoNome", curso.CursoNome);
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidade", curso.CursoUnidadeID);
                acessoDadosSqlServer.AdicionarParametros("@CursoCoordenador", curso.CursoCoordenador);
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoAlterar").ToString();

                return CursoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Curso curso)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CursoID", curso.CursoID);
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoExcluir").ToString();

                return CursoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public CursoColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            CursoColecao cursoColecao = new CursoColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@CursoNome", nome);
            DataTable dataTableCurso = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCursoConsultarPorNome");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableCurso.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Curso curso = new Curso();
                curso.CursoID = Convert.ToInt32(linha["CursoID"]);
                curso.CursoNome = Convert.ToString(linha["CursoNome"]);
                curso.CursoUnidadeID = Convert.ToInt32(linha["CursoUnidadeID"]);
                curso.CursoCoordenador = Convert.ToInt32(linha["CursoCoordenador"]);
                cursoColecao.Add(curso);
            }
            return cursoColecao;
        }
    }
}