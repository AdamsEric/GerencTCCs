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
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidadeID", Convert.ToInt32(curso.CursoUnidadeID));
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblCurso (CursoNome,CursoUnidadeID) VALUES (@CursoNome,@CursoUnidadeID) SELECT @@IDENTITY AS RETORNO").ToString();

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
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidadeID", Convert.ToInt32(curso.CursoUnidadeID));
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblCurso SET CursoNome = @CursoNome, CursoUnidadeID = @CursoUnidadeID WHERE CursoID = @CursoID SELECT @CursoID AS RETORNO").ToString();

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
                string CursoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblCurso WHERE CursoID = @CursoID SELECT @CursoID AS RETORNO").ToString();

                return CursoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public CursoColecao ConsultarPorNome(string nome, string unidade)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            CursoColecao cursoColecao = new CursoColecao();

            acessoDadosSqlServer.LimparParametros();
            DataTable dataTableCurso;

            if (unidade == "")
            {
                acessoDadosSqlServer.AdicionarParametros("@CursoNome", nome);
                dataTableCurso = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT CursoID AS ID, CursoNome AS Curso, UnidadeNome AS Unidade FROM tblCurso INNER JOIN tblUnidade ON CursoUnidadeID = UnidadeID WHERE CursoNome LIKE '%' + @CursoNome + '%'");
            }
            else
            {
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidadeID", RetornaCursoID(unidade));
                acessoDadosSqlServer.AdicionarParametros("@CursoNome", nome);
                dataTableCurso = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT CursoID AS ID, CursoNome AS Curso, UnidadeNome AS Unidade FROM tblCurso INNER JOIN tblUnidade ON CursoUnidadeID = UnidadeID WHERE (CursoNome LIKE '%' + @CursoNome + '%') and (CursoUnidadeID = @CursoUnidadeID)");
            }


            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableCurso.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Curso curso = new Curso();
                curso.CursoID = Convert.ToInt32(linha["ID"]);
                curso.CursoNome = Convert.ToString(linha["Curso"]);
                curso.CursoUnidadeNome = Convert.ToString(linha["Unidade"]);
                cursoColecao.Add(curso);
            }
            return cursoColecao;
        }

        public int RetornaCursoID (string nome)
        {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CursoUnidadeNome", nome);
                int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT UnidadeID FROM tblUnidade where UnidadeNome LIKE '%' + @CursoUnidadeNome + '%'"));

                return ID;
        }
    }
}