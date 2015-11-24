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
    public class UsuarioNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.UsuarioSenha);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioGrupoID", usuario.UsuarioGrupoID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSituacao", usuario.UsuarioSituacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", usuario.UsuarioNome);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioMatricula", usuario.UsuarioMatricula);
                string UsuarioID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblUsuario (UsuarioLogin, UsuarioSenha, UsuarioSituacao, UsuarioNome, UsuarioMatricula, UsuarioGrupoID) VALUES (@UsuarioLogin, @UsuarioSenha, @UsuarioSituacao, @UsuarioNome, @UsuarioMatricula, @UsuarioGrupoID) SELECT @@IDENTITY AS RETORNO").ToString();

                return UsuarioID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", usuario.UsuarioID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.UsuarioSenha);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioGrupoID", usuario.UsuarioGrupoID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSituacao", usuario.UsuarioSituacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", usuario.UsuarioNome);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioMatricula", usuario.UsuarioMatricula);
                string UsuarioID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblUsuario SET UsuarioLogin = @UsuarioLogin, UsuarioSenha = @UsuarioSenha, UsuarioSituacao = @UsuarioSituacao, UsuarioNome = @UsuarioNome, UsuarioMatricula = @UsuarioMatricula, UsuarioGrupoID = @UsuarioGrupoID WHERE UsuarioID = @UsuarioID SELECT @UsuarioID AS RETORNO").ToString();

                return UsuarioID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", usuario.UsuarioID);
                string UsuarioID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblUsuario WHERE	UsuarioID = @UsuarioID SELECT @UsuarioID AS RETORNO").ToString();

                return UsuarioID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public UsuarioColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            UsuarioColecao usuarioColecao = new UsuarioColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", nome);
            DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT UsuarioID AS ID, UsuarioLogin AS Login, UsuarioSenha AS Senha, UsuarioSituacao AS Situacao, UsuarioNome AS Nome, UsuarioMatricula AS Matricula, UsuarioGrupoID AS 'ID do Grupo', GrupoNome AS Grupo FROM tblUsuario INNER JOIN tblGrupo ON UsuarioGrupoID = GrupoID WHERE UsuarioNome LIKE ('%' + @UsuarioNome + '%')");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableUsuario.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Usuario usuario = new Usuario();
                usuario.UsuarioID = Convert.ToInt32(linha["ID"]);
                usuario.UsuarioLogin = Convert.ToString(linha["Login"]);
                usuario.UsuarioSenha = Convert.ToString(linha["Senha"]);
                usuario.UsuarioNome = Convert.ToString(linha["Nome"]);
                usuario.UsuarioMatricula = Convert.ToString(linha["Matricula"]);
                usuario.UsuarioGrupoID = Convert.ToInt32(linha["ID do Grupo"]);
                usuario.UsuarioGrupoNome = Convert.ToString(linha["Grupo"]);
                usuario.UsuarioSituacao = Convert.ToString(linha["Situacao"]);
                usuarioColecao.Add(usuario);
            }
            return usuarioColecao;
        }

        public UsuarioColecao ConsultarPorLogin(string login)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            UsuarioColecao usuarioColecao = new UsuarioColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", login);
            DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT UsuarioID AS ID, UsuarioLogin AS Login, UsuarioSenha AS Senha, UsuarioSituacao AS Situacao, UsuarioNome AS Nome, UsuarioMatricula AS Matricula, UsuarioGrupoID AS 'ID do Grupo', GrupoNome AS Grupo FROM tblUsuario INNER JOIN tblGrupo ON UsuarioGrupoID = GrupoID WHERE UsuarioLogin LIKE ('%' + @UsuarioLogin + '%')");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableUsuario.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Usuario usuario = new Usuario();
                usuario.UsuarioID = Convert.ToInt32(linha["ID"]);
                usuario.UsuarioLogin = Convert.ToString(linha["Login"]);
                usuario.UsuarioSenha = Convert.ToString(linha["Senha"]);
                usuario.UsuarioNome = Convert.ToString(linha["Nome"]);
                usuario.UsuarioMatricula = Convert.ToString(linha["Matricula"]);
                usuario.UsuarioGrupoID = Convert.ToInt32(linha["ID do Grupo"]);
                usuario.UsuarioGrupoNome = Convert.ToString(linha["Grupo"]);
                usuario.UsuarioSituacao = Convert.ToString(linha["Situacao"]);
                usuarioColecao.Add(usuario);
            }
            return usuarioColecao;
        }

        public int RetornaIDGrupo(string grupo)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@GrupoNome", grupo);
            int ID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT GrupoID FROM tblGrupo where GrupoNome LIKE '%' + @GrupoNome + '%'"));

            return ID;
        }

        public int RealizarLogin(string login, string senha)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", login);
            acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", senha);
            int UsuarioID = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT UsuarioID AS ID FROM tblUsuario INNER JOIN tblGrupo ON UsuarioGrupoID = GrupoID WHERE UsuarioLogin LIKE @UsuarioLogin AND UsuarioSenha = @UsuarioSenha"));

            return UsuarioID;
        
        }

        public string VerificarGrupo(int ID)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@UsuarioID", ID);
            string Grupo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT GrupoNome AS Grupo FROM tblUsuario INNER JOIN tblGrupo ON UsuarioGrupoID = GrupoID WHERE UsuarioID LIKE @UsuarioID").ToString();
            
            return Grupo;
        }
    }
}
