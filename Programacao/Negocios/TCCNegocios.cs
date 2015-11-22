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
    public class TCCNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(TCC tcc)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TCCTitulo", tcc.TCCTitulo);
                acessoDadosSqlServer.AdicionarParametros("@TCCGrandeArea", tcc.TCCGrandeArea);
                acessoDadosSqlServer.AdicionarParametros("@TCCArea", tcc.TCCArea);
                acessoDadosSqlServer.AdicionarParametros("@TCCSubarea", tcc.TCCSubarea);
                acessoDadosSqlServer.AdicionarParametros("@TCCEspecialidade", tcc.TCCEspecialidade);
                acessoDadosSqlServer.AdicionarParametros("@TCCResumo", tcc.TCCResumo);
                acessoDadosSqlServer.AdicionarParametros("@TCCPaginas", tcc.TCCPaginas);
                acessoDadosSqlServer.AdicionarParametros("@TCCData", tcc.TCCData);
                acessoDadosSqlServer.AdicionarParametros("@TCCSalaID", tcc.TCCSalaID);
                acessoDadosSqlServer.AdicionarParametros("@TCCAlunoID", tcc.TCCAlunoID);
                acessoDadosSqlServer.AdicionarParametros("@TCCOrientadorID", tcc.TCCOrientadorID);
                string tccID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblTCC (TCCTitulo,TCCGrandeArea,TCCArea,TCCSubarea,TCCEspecialidade,TCCResumo,TCCPaginas,TCCData,TCCSalaID,TCCAlunoID,TCCOrientadorID) VALUES (@TCCTitulo,@TCCGrandeArea,@TCCArea,@TCCSubarea,@TCCEspecialidade,@TCCResumo,@TCCPaginas,@TCCData,@TCCSalaID,@TCCAlunoID,@TCCOrientadorID) SELECT @@IDENTITY AS RETORNO").ToString();

                return tccID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(TCC tcc)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TCCID", tcc.TCCID);
                acessoDadosSqlServer.AdicionarParametros("@TCCTitulo", tcc.TCCTitulo);
                acessoDadosSqlServer.AdicionarParametros("@TCCGrandeArea", tcc.TCCGrandeArea);
                acessoDadosSqlServer.AdicionarParametros("@TCCArea", tcc.TCCArea);
                acessoDadosSqlServer.AdicionarParametros("@TCCSubarea", tcc.TCCSubarea);
                acessoDadosSqlServer.AdicionarParametros("@TCCEspecialidade", tcc.TCCEspecialidade);
                acessoDadosSqlServer.AdicionarParametros("@TCCResumo", tcc.TCCResumo);
                acessoDadosSqlServer.AdicionarParametros("@TCCPaginas", tcc.TCCPaginas);
                acessoDadosSqlServer.AdicionarParametros("@TCCData", tcc.TCCData);
                acessoDadosSqlServer.AdicionarParametros("@TCCSalaID", tcc.TCCSalaID);
                acessoDadosSqlServer.AdicionarParametros("@TCCAlunoID", tcc.TCCAlunoID);
                acessoDadosSqlServer.AdicionarParametros("@TCCOrientadorID", tcc.TCCOrientadorID);
                string TCCID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblTCC SET TCCTitulo = @TCCTitulo,TCCGrandeArea = @TCCGrandeArea,TCCArea = @TCCArea,TCCSubarea = @TCCSubarea,TCCEspecialidade = @TCCEspecialidade,TCCResumo = @TCCResumo,TCCPaginas = @TCCPaginas,TCCData = @TCCData,TCCSalaID = @TCCSalaID, TCCAlunoID = @TCCAlunoID, TCCOrientadorID = @TCCOrientadorID WHERE TCCID = @TCCID SELECT @TCCID AS RETORNO").ToString();

                return TCCID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(TCC tcc)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TCCID", tcc.TCCID);
                string TCCID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblTCC WHERE TCCID = @TCCID SELECT @TCCID AS RETORNO").ToString();

                return TCCID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TCCColecao ConsultarPorTitulo(string titulo)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            TCCColecao tccColecao = new TCCColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@TCCTitulo", titulo);
            DataTable dataTableTCC = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT TCCID AS ID, AlunoID AS AlunoID, AlunoNome AS Aluno, TCCTitulo AS Titulo, ProfessorID AS OrientadorID, ProfessorNome AS Orientador, TCCGrandeArea AS 'Grande Area', TCCArea AS Area, TCCSubarea AS Subarea, TCCEspecialidade AS Especialidade, TCCPaginas AS 'N de Paginas', TCCData AS Data, SalaID AS SalaID, SalaNome AS Sala, UnidadeNome AS Unidade, TCCResumo AS Resumo FROM tblTCC INNER JOIN tblAluno ON TCCAlunoID = AlunoID INNER JOIN tblSala ON TCCSalaID = SalaID INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblProfessor ON TCCOrientadorID = ProfessorID WHERE TCCTitulo LIKE '%' + @TCCTitulo + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableTCC.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                TCC tcc = new TCC();

                tcc.TCCID = Convert.ToInt32(linha["ID"]);
                tcc.TCCAlunoID = Convert.ToInt32(linha["AlunoID"]);
                tcc.TCCAlunoNome = Convert.ToString(linha["Aluno"]);
                tcc.TCCTitulo = Convert.ToString(linha["Titulo"]);
                tcc.TCCOrientadorID = Convert.ToInt32(linha["OrientadorID"]);
                tcc.TCCOrientadorNome = Convert.ToString(linha["Orientador"]);
                tcc.TCCGrandeArea = Convert.ToString(linha["Grande Area"]);
                tcc.TCCArea = Convert.ToString(linha["Area"]);
                tcc.TCCSubarea = Convert.ToString(linha["Subarea"]);
                tcc.TCCEspecialidade = Convert.ToString(linha["Especialidade"]);
                tcc.TCCPaginas = Convert.ToInt32(linha["N de Paginas"]);
                tcc.TCCSalaID = Convert.ToInt32(linha["SalaID"]);
                tcc.TCCSalaNome = Convert.ToString(linha["Sala"]);
                tcc.TCCUnidade = Convert.ToString(linha["Unidade"]);
                tcc.TCCData = Convert.ToDateTime(linha["Data"]);
                tcc.TCCResumo = Convert.ToString(linha["Resumo"]);

                tccColecao.Add(tcc);
            }
            return tccColecao;
        }

        public TCCColecao ConsultarPorAluno(string aluno)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            TCCColecao tccColecao = new TCCColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@TCCAlunoNome", aluno);
            DataTable dataTableTCC = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT TCCID AS ID, AlunoID AS AlunoID, AlunoNome AS Aluno, TCCTitulo AS Titulo, ProfessorID AS OrientadorID, ProfessorNome AS Orientador, TCCGrandeArea AS 'Grande Area', TCCArea AS Area, TCCSubarea AS Subarea, TCCEspecialidade AS Especialidade, TCCPaginas AS 'N de Paginas', TCCData AS Data, SalaID AS SalaID, SalaNome AS Sala, UnidadeNome AS Unidade, TCCResumo AS Resumo FROM tblTCC INNER JOIN tblAluno ON TCCAlunoID = AlunoID INNER JOIN tblSala ON TCCSalaID = SalaID INNER JOIN tblUnidade ON SalaUnidadeID = UnidadeID INNER JOIN tblProfessor ON TCCOrientadorID = ProfessorID WHERE AlunoNome LIKE '%' + @TCCAlunoNome + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableTCC.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                TCC tcc = new TCC();

                tcc.TCCID = Convert.ToInt32(linha["ID"]);
                tcc.TCCAlunoID = Convert.ToInt32(linha["AlunoID"]);
                tcc.TCCAlunoNome = Convert.ToString(linha["Aluno"]);
                tcc.TCCTitulo = Convert.ToString(linha["Titulo"]);
                tcc.TCCOrientadorID = Convert.ToInt32(linha["OrientadorID"]);
                tcc.TCCOrientadorNome = Convert.ToString(linha["Orientador"]);
                tcc.TCCGrandeArea = Convert.ToString(linha["Grande Area"]);
                tcc.TCCArea = Convert.ToString(linha["Area"]);
                tcc.TCCSubarea = Convert.ToString(linha["Subarea"]);
                tcc.TCCEspecialidade = Convert.ToString(linha["Especialidade"]);
                tcc.TCCPaginas = Convert.ToInt32(linha["N de Paginas"]);
                tcc.TCCSalaID = Convert.ToInt32(linha["SalaID"]);
                tcc.TCCSalaNome = Convert.ToString(linha["Sala"]);
                tcc.TCCUnidade = Convert.ToString(linha["Unidade"]);
                tcc.TCCData = Convert.ToDateTime(linha["Data"]);
                tcc.TCCResumo = Convert.ToString(linha["Resumo"]);

                tccColecao.Add(tcc);
            }
            return tccColecao;
        }
    }
}
