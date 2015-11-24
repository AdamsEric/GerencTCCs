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
    public class SalaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Sala sala)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", sala.SalaNome);
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", sala.SalaDescricao);
                acessoDadosSqlServer.AdicionarParametros("@SalaSalaTipoID", Convert.ToInt32(sala.SalaSalaTipoID));
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", Convert.ToInt32(sala.SalaUnidadeID));
                string SalaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblSala (SalaNome,SalaDescricao,SalaUnidadeID,SalaSalaTipoID) VALUES (@SalaNome,@SalaDescricao,@SalaUnidadeID,@SalaSalaTipoID) SELECT @@IDENTITY AS RETORNO").ToString();

                return SalaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Sala sala)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@SalaID", sala.SalaID);
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", sala.SalaNome);
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", sala.SalaDescricao);
                acessoDadosSqlServer.AdicionarParametros("@SalaSalaTipoID", Convert.ToInt32(sala.SalaSalaTipoID));
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", Convert.ToInt32(sala.SalaUnidadeID));
                string SalaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblSala SET SalaNome = @SalaNome, SalaDescricao = @SalaDescricao, SalaSalaTipoID = @SalaSalaTipoID, SalaUnidadeID = @SalaUnidadeID WHERE SalaID = @SalaID SELECT @SalaID AS RETORNO").ToString();

                return SalaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Sala sala)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@SalaID", sala.SalaID);
                string SalaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblSala WHERE SalaID = @SalaID SELECT @SalaID AS RETORNO").ToString();

                return SalaID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SalaColecao ConsultarPorNome(string nome, string unidade)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            SalaColecao salaColecao = new SalaColecao();

            acessoDadosSqlServer.LimparParametros();
            DataTable dataTableSala;

            if (unidade == "")
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", nome);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaTipoTipo AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblSalaTipo ON SalaSalaTipoID = SalaTipoID WHERE SalaNome LIKE '%' + @SalaNome + '%'");
            }
            else
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", RetornaUnidadeID(unidade));
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", nome);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaTipoTipo AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblSalaTipo ON SalaSalaTipoID = SalaTipoID WHERE (SalaNome LIKE '%' + @SalaNome + '%') and (SalaUnidadeID = @SalaUnidadeID)");
            }

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableSala.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Sala sala = new Sala();
                sala.SalaID = Convert.ToInt32(linha["ID"]);
                sala.SalaNome = Convert.ToString(linha["Sala"]);
                sala.SalaDescricao = Convert.ToString(linha["Descricao"]);
                sala.SalaSalaTipoNome = Convert.ToString(linha["Tipo"]);
                sala.SalaUnidadeNome = Convert.ToString(linha["Unidade"]);
                salaColecao.Add(sala);
            }
            return salaColecao;
        }

        public SalaColecao ConsultarPorDescricao(string descricao, string unidade)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            SalaColecao salaColecao = new SalaColecao();

            acessoDadosSqlServer.LimparParametros();
            DataTable dataTableSala;

            if (unidade == "")
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", descricao);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaTipoTipo AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblSalaTipo ON SalaSalaTipoID = SalaTipoID WHERE (SalaDescricao LIKE '%' + @SalaDescricao + '%')");
            }
            else
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", RetornaUnidadeID(unidade));
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", descricao);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaTipoTipo AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblSalaTipo ON SalaSalaTipoID = SalaTipoID WHERE (SalaDescricao LIKE '%' + @SalaDescricao + '%') and (SalaUnidadeID = @SalaUnidadeID)");
            }

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableSala.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Sala sala = new Sala();
                sala.SalaID = Convert.ToInt32(linha["ID"]);
                sala.SalaNome = Convert.ToString(linha["Sala"]);
                sala.SalaDescricao = Convert.ToString(linha["Descricao"]);
                sala.SalaSalaTipoNome = Convert.ToString(linha["Tipo"]);
                sala.SalaUnidadeNome = Convert.ToString(linha["Unidade"]);
                salaColecao.Add(sala);
            }
            return salaColecao;
        }

        public int RetornaUnidadeID(string nome)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeNome", nome);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT UnidadeID FROM tblUnidade where UnidadeNome LIKE '%' + @SalaUnidadeNome + '%'"));

            return ID;
        }

        public int RetornaSalaTipoID(string nome)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@SalaSalaTipoNome", nome);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT SalaTipoID FROM tblSalaTipo where SalaTipoTipo LIKE '%' + @SalaSalaTipoNome + '%'"));
            
            return ID;
        }

        public int VerificarUso(int salaid)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@SalaID", salaid);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT TOP 1 SalaID FROM tblSala INNER JOIN tblTCC ON SalaID = TCCSalaID WHERE SalaID = @SalaID"));
            return verificacao;
        }
    }
}
