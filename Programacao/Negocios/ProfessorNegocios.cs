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
    public class ProfessorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ProfessorNome", professor.ProfessorNome);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", professor.ProfessorMatricula);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorTelefone", professor.ProfessorTelefone);
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblProfessor (ProfessorNome,ProfessorMatricula,ProfessorTelefone) VALUES (@ProfessorNome,@ProfessorMatricula,@ProfessorTelefone) SELECT @@IDENTITY AS RETORNO").ToString();

                return ProfessorID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ProfessorID", professor.ProfessorID);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorNome", professor.ProfessorNome);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", professor.ProfessorMatricula);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorTelefone", professor.ProfessorTelefone);
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblProfessor SET ProfessorNome = @ProfessorNome, ProfessorMatricula = @ProfessorMatricula, ProfessorTelefone = @ProfessorTelefone WHERE ProfessorID = @ProfessorID SELECT @ProfessorID AS RETORNO").ToString();

                return ProfessorID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@ProfessorID", professor.ProfessorID);
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblProfessor WHERE ProfessorID = @ProfessorID SELECT @ProfessorID AS RETORNO").ToString();

                return ProfessorID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ProfessorColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            ProfessorColecao professorColecao = new ProfessorColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@ProfessorNome", nome);
            DataTable dataTableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT ProfessorID AS ID, ProfessorNome AS Professor, ProfessorMatricula AS Matricula, ProfessorTelefone AS Telefone FROM tblProfessor WHERE ProfessorNome LIKE '%' + @ProfessorNome + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableProfessor.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Professor professor = new Professor();
                professor.ProfessorID = Convert.ToInt32(linha["ID"]);
                professor.ProfessorNome = Convert.ToString(linha["Professor"]);
                professor.ProfessorMatricula = Convert.ToString(linha["Matricula"]);
                professor.ProfessorTelefone = Convert.ToString(linha["Telefone"]);
                professorColecao.Add(professor);
            }
            return professorColecao;
        }

        public ProfessorColecao ConsultarPorMatricula(string matricula)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            ProfessorColecao professorColecao = new ProfessorColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", matricula);
            DataTable dataTableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SELECT ProfessorID AS ID, ProfessorNome AS Professor, ProfessorMatricula AS Matricula, ProfessorTelefone AS Telefone FROM tblProfessor WHERE ProfessorMatricula LIKE '%' + @ProfessorMatricula + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableProfessor.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Professor professor = new Professor();
                professor.ProfessorID = Convert.ToInt32(linha["ID"]);
                professor.ProfessorNome = Convert.ToString(linha["Professor"]);
                professor.ProfessorMatricula = Convert.ToString(linha["Matricula"]);
                professor.ProfessorTelefone = Convert.ToString(linha["Telefone"]);
                professorColecao.Add(professor);
            }
            return professorColecao;
        }

        public int VerificarProfessorExistente(string matricula, int professorid)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", matricula);
            acessoDadosSqlServer.AdicionarParametros("@ProfessorID", professorid);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT ProfessorID FROM tblProfessor WHERE ProfessorMatricula = @ProfessorMatricula AND ProfessorID <> @ProfessorID"));

            return verificacao;
        }
    }
}
