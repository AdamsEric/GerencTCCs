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
    public class AlunoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
		
		public string Inserir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoNome", aluno.AlunoNome);
                acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", aluno.AlunoMatricula);
                acessoDadosSqlServer.AdicionarParametros("@AlunoTelefone", aluno.AlunoTelefone);
				acessoDadosSqlServer.AdicionarParametros("@AlunoCurso", aluno.AlunoCursoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoInserir").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoID", aluno.AlunoID);
                acessoDadosSqlServer.AdicionarParametros("@AlunoNome", aluno.AlunoNome);
                acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", aluno.AlunoMatricula);
                acessoDadosSqlServer.AdicionarParametros("@AlunoTelefone", aluno.AlunoTelefone);
				acessoDadosSqlServer.AdicionarParametros("@AlunoCurso", aluno.AlunoCursoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoAlterar").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoID", aluno.AlunoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoExcluir").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public AlunoColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            AlunoColecao alunoColecao = new AlunoColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoNome", nome);
            DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultarPorNome");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableAluno.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Aluno aluno = new Aluno();
                aluno.AlunoID = Convert.ToInt32(linha["AlunoID"]);
                aluno.AlunoNome = Convert.ToString(linha["AlunoNome"]);
                aluno.AlunoMatricula = Convert.ToString(linha["AlunoMatricula"]);
                aluno.AlunoTelefone = Convert.ToString(linha["AlunoTelefone"]);
				aluno.AlunoCursoID = Convert.ToInt32(linha["AlunoCurso"]);
                alunoColecao.Add(aluno);
            }
            return alunoColecao;
        }
    }
}
