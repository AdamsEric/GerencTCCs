﻿using System;
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
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblAluno (AlunoNome,AlunoMatricula,AlunoTelefone,AlunoCurso) VALUES (@AlunoNome,@AlunoMatricula,@AlunoTelefone,@AlunoCurso) SELECT @AlunoID AS RETORNO").ToString();

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
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblAluno SET AlunoNome = @AlunoNome, AlunoMatricula = @AlunoMatricula, AlunoTelefone = @AlunoTelefone, AlunoCurso = @AlunoCurso WHERE AlunoID = @AlunoID SELECT @AlunoID AS RETORNO").ToString();

                return AlunoID;
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
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblAluno WHERE AlunoID = @AlunoID SELECT @AlunoID AS RETORNO").ToString();

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
            DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT AlunoID AS ID, AlunoNome AS Aluno, AlunoMatricula AS Matricula, AlunoTelefone AS Telefone, CursoNome AS Curso FROM tblAluno INNER JOIN tblCurso ON AlunoCursoID = CursoID WHERE AlunoNome LIKE '%' + @AlunoNome + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableAluno.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Aluno aluno = new Aluno();
                aluno.AlunoID = Convert.ToInt32(linha["ID"]);
                aluno.AlunoNome = Convert.ToString(linha["Aluno"]);
                aluno.AlunoMatricula = Convert.ToString(linha["Matricula"]);
                aluno.AlunoTelefone = Convert.ToString(linha["Telefone"]);
				aluno.AlunoCursoNome = (linha["Curso"]).ToString();
                alunoColecao.Add(aluno);
            }
            return alunoColecao;
        }

        public int RetornaIDUnidade(string unidade)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoUnidadeNome", unidade);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT UnidadeID FROM tblUnidade where UnidadeNome LIKE '%' + @AlunoUnidadeNome + '%'"));

            return ID;
        }

        public int RetornaIDCurso(string curso, int unidade)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoCursoNome", curso);
            acessoDadosSqlServer.AdicionarParametros("@AlunoUnidadeID", unidade);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT * FROM tblCurso WHERE (CursoNome LIKE '%' + @AlunoCursoNome + '%') AND (CursoUnidadeID = @AlunoUnidadeID)"));

            return ID;
        }

    }
}
