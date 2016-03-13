using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class BancoRegraNegocio
    {
        /// <summary>
        /// Referência à classe da camada de dados.
        /// </summary>
        private AcessoDados.BancoAcessoDados bancoAD;

        /// <summary>
        /// Criação do banco de dados no sistema, caso ainda não exista.
        /// </summary>
        public void CriaBanco()
        {
            try
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                path = path.Replace(@"\bin\Debug", ""); // Isso é feito pois a linha anterior retorna o caminho para o Debug e não para a raiz do projeto.

                string caminhoScriptBanco = path + @"\Resources\ScriptBanco.sql";
                FileInfo arquivoBanco = new FileInfo(caminhoScriptBanco);
                string scriptBanco = arquivoBanco.OpenText().ReadToEnd();

                string caminhoScriptTabelas = path + @"\Resources\ScriptTabela.sql";
                FileInfo arquivoTabelas = new FileInfo(caminhoScriptTabelas);
                string scriptTabela = arquivoTabelas.OpenText().ReadToEnd();

                bancoAD = new AcessoDados.BancoAcessoDados();
                bancoAD.CriaBanco(scriptBanco, scriptTabela); // Função que verificará a existência do BD e, caso não exista, criará um novo banco. 
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Verifica a existência do banco que será usado.
        /// </summary>
        /// <returns></returns>
        public DataTable VerificaBanco()
        {
            try
            {
                bancoAD = new AcessoDados.BancoAcessoDados();
                return bancoAD.VerificaBanco();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }
    }
}
