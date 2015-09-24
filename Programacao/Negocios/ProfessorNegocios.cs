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
                acessoDadosSqlServer.AdicionarParametros("@ProfessorCPF", professor.ProfessorCPF);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", professor.ProfessorMatricula);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorTelefone", professor.ProfessorTelefone);
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProfessorInserir").ToString();

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
                acessoDadosSqlServer.AdicionarParametros("@ProfessorCPF", professor.ProfessorCPF);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorMatricula", professor.ProfessorMatricula);
                acessoDadosSqlServer.AdicionarParametros("@ProfessorTelefone", professor.ProfessorTelefone);
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProfessorAlterar").ToString();

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
                string ProfessorID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProfessorExcluir").ToString();

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
            DataTable dataTableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarPorNome");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableProfessor.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Professor professor = new Professor();
                professor.ProfessorID = Convert.ToInt32(linha["ProfessorID"]);
                professor.ProfessorNome = Convert.ToString(linha["ProfessorNome"]);
                professor.ProfessorCPF = Convert.ToString(linha["ProfessorCPF"]);
                professor.ProfessorMatricula = Convert.ToString(linha["ProfessorMatricula"]);
                professor.ProfessorTelefone = Convert.ToString(linha["ProfessorTelefone"]);
                professorColecao.Add(professor);
            }
            return professorColecao;
        }

        public ProfessorColecao ConsultarPorCPF (string cpf)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            ProfessorColecao professorColecao = new ProfessorColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@ProfessorCPF", cpf);
            DataTable dataTableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarPorCPF");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableProfessor.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Professor professor = new Professor();
                professor.ProfessorID = Convert.ToInt32(linha["ProfessorID"]);
                professor.ProfessorNome = Convert.ToString(linha["ProfessorNome"]);
                professor.ProfessorCPF = Convert.ToString(linha["ProfessorCPF"]);
                professor.ProfessorMatricula = Convert.ToString(linha["ProfessorMatricula"]);
                professor.ProfessorTelefone = Convert.ToString(linha["ProfessorTelefone"]);
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
            DataTable dataTableProfessor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultarPorMatricula");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableProfessor.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Professor professor = new Professor();
                professor.ProfessorID = Convert.ToInt32(linha["ProfessorID"]);
                professor.ProfessorNome = Convert.ToString(linha["ProfessorNome"]);
                professor.ProfessorCPF = Convert.ToString(linha["ProfessorCPF"]);
                professor.ProfessorMatricula = Convert.ToString(linha["ProfessorMatricula"]);
                professor.ProfessorTelefone = Convert.ToString(linha["ProfessorTelefone"]);
                professorColecao.Add(professor);
            }
            return professorColecao;
        }
    }
}
