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
    public class BancaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string InserirBanca(int tcc)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@BancaTCCID", tcc);
                string bancaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblBanca (BancaTCCID) VALUES (@BancaTCCID) SELECT @@IDENTITY AS RETORNO").ToString();
                
                return bancaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void ExcluirBanca(int tcc)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@BancaTCCID", tcc);
            acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblBanca WHERE BancaTCCID = @BancaTCCID");
        }

        public string InserirProfessor(Banca banca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@BancaProfessorProfessorID", banca.BancaProfessorID);
                acessoDadosSqlServer.AdicionarParametros("@BancaProfessorBancaID", banca.BancaID);
                string bancaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblBancaProfessor (BancaProfessorProfessorID, BancaProfessorBancaID) VALUES (@BancaProfessorProfessorID, @BancaProfessorBancaID) SELECT @@IDENTITY AS RETORNO").ToString();
                return bancaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirProfessor(Banca banca)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@BancaBancaProfessorID", banca.BancaBancaProfessorID);
                string bancaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblBancaProfessor WHERE BancaProfessorID = @BancaBancaProfessorID SELECT @@IDENTITY AS RETORNO").ToString();
                return bancaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public BancaColecao ListarProfessores(int bancaID)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            BancaColecao bancaColecao = new BancaColecao();
            
            DataTable dataTableBanca;
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@BancaProfessorBancaID", bancaID);
            dataTableBanca = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT BancaProfessorID AS ID, BancaProfessorBancaID AS Banca, BancaProfessorProfessorID AS 'ID do Professor', ProfessorNome AS Professor, BancaTCCID AS 'ID do TCC' FROM tblBancaProfessor INNER JOIN tblProfessor ON BancaProfessorProfessorID = ProfessorID INNER JOIN tblBanca ON BancaProfessorBancaID = BancaID WHERE BancaProfessorBancaID = @BancaProfessorBancaID");

            foreach (DataRow linha in dataTableBanca.Rows)
            {
                Banca banca = new Banca();
                banca.BancaBancaProfessorID = Convert.ToInt32(linha["ID"]);
                banca.BancaID = Convert.ToInt32(linha["Banca"]);
                banca.BancaProfessorID = Convert.ToInt32(linha["ID do Professor"]);
                banca.BancaProfessorNome = (linha["Professor"].ToString());
                banca.BancaTCCID = Convert.ToInt32(linha["ID do TCC"]);

                bancaColecao.Add(banca);
            }
            return bancaColecao;
        }

        public int RetornaBancaID(int tccID)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@BancaTCCID", tccID);
            int bancaID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT BancaID FROM tblBanca where BancaTCCID = @BancaTCCID"));
            return bancaID;
        }

        public int VerificarProfessorExistente(Banca banca)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@BancaProfessorBancaID", banca.BancaID);
            acessoDadosSqlServer.AdicionarParametros("@BancaProfessorProfessorID", banca.BancaProfessorID);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT BancaProfessorBancaID FROM tblBancaProfessor WHERE BancaProfessorProfessorID = @BancaProfessorProfessorID AND BancaProfessorBancaID = @BancaProfessorBancaID"));
            
            return verificacao;
        }

        public int VerificarBancaVazia(int bancaid)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@BancaProfessorBancaID", bancaid);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT TOP 1 BancaProfessorID FROM tblBancaProfessor WHERE BancaProfessorBancaID = @BancaProfessorBancaID"));
            return verificacao;
        }
    }
}
