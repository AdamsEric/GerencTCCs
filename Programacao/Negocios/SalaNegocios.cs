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
                acessoDadosSqlServer.AdicionarParametros("@SalaTipoID", Convert.ToInt32(sala.SalaSalaTipoID));
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", Convert.ToInt32(sala.SalaUnidadeID));
                string SalaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblSala (SalaNome,SalaDescricao,SalaSalaTipoID,SalaUnidadeID) VALUES (@SalaNome,@SalaDescricao,@SalaTipoID,@SalaUnidadeID) SELECT @@IDENTITY AS RETORNO").ToString();

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
                acessoDadosSqlServer.AdicionarParametros("@SalaTipoID", Convert.ToInt32(sala.SalaSalaTipoID));
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", Convert.ToInt32(sala.SalaUnidadeID));
                string SalaID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblSala SET SalaNome = @SalaNome, SalaDescricao = @SalaDescricao, SalaSalaTipoID = @SalaTipoID, SalaUnidadeID = @SalaUnidadeID WHERE SalaID = @SalaID SELECT @SalaID AS RETORNO").ToString();

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
            SalaColecao salaColecao = new SalaColecao();

            acessoDadosSqlServer.LimparParametros();
            DataTable dataTableSala;

            if (unidade == "")
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", nome);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaSalaTipoID AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID WHERE SalaNome LIKE '%' + @SalaNome + '%'");
            }
            else
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", RetornaUnidadeID(unidade));
                acessoDadosSqlServer.AdicionarParametros("@SalaNome", nome);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, SalaSalaTipoID AS Tipo, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID WHERE (SalaNome LIKE '%' + @SalaNome + '%') and (SalaUnidadeID = @SalaUnidadeID)");
            }

            foreach (DataRow linha in dataTableSala.Rows)
            {
                Sala sala = new Sala();
                sala.SalaID = Convert.ToInt32(linha["ID"]);
                sala.SalaNome = Convert.ToString(linha["Sala"]);
                sala.SalaDescricao = Convert.ToString(linha["Descricao"]);
                sala.SalaUnidadeNome = Convert.ToString(linha["Unidade"]);
                salaColecao.Add(sala);
            }
            return salaColecao;
        }

        public SalaColecao ConsultarPorDescricao(string descricao, string unidade)
        {
            SalaColecao salaColecao = new SalaColecao();

            acessoDadosSqlServer.LimparParametros();
            DataTable dataTableSala;

            if (unidade == "")
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", descricao);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID WHERE SalaDescricao LIKE '%' + @SalaDescricao + '%'");
            }
            else
            {
                acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeID", RetornaUnidadeID(unidade));
                acessoDadosSqlServer.AdicionarParametros("@SalaDescricao", descricao);
                dataTableSala = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT SalaID AS ID, SalaNome AS Sala, SalaDescricao AS Descricao, UnidadeNome AS Unidade FROM tblSala INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID WHERE (SalaDescricao LIKE '%' + @SalaDescricao + '%') and (SalaUnidadeID = @SalaUnidadeID)");
            }

            foreach (DataRow linha in dataTableSala.Rows)
            {
                Sala sala = new Sala();
                sala.SalaID = Convert.ToInt32(linha["ID"]);
                sala.SalaNome = Convert.ToString(linha["Sala"]);
                sala.SalaDescricao = Convert.ToString(linha["Descricao"]);
                sala.SalaUnidadeNome = Convert.ToString(linha["Unidade"]);
                salaColecao.Add(sala);
            }
            return salaColecao;
        }

        public int RetornaUnidadeID(string sala)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@SalaUnidadeNome", sala);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT UnidadeID FROM tblUnidade where UnidadeNome LIKE '%' + @SalaUnidadeNome + '%'"));

            return ID;
        }

        public int RetornaSalaTipoID(string salaTipo)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@SalaTipoTipo", salaTipo);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT SalaTipoID FROM tblSalaTipo WHERE SalaTipoTipo LIKE '%' + @SalaTipoTipo + '%'"));

            return ID;
        }
    }
}
