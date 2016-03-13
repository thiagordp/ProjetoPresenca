using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class BancoAcessoDados
    {


        /// <summary>
        /// String de conexão
        /// </summary>
        private const string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ListaPresenca;Integrated Security=SSPI";

        #region CRIACAO_BANCO

        /// <summary>
        /// String de conexão com o banco
        /// </summary>
        public static string StringConexao
        {
            get { return conexao; }
        }

        /// <summary>
        /// Criação do Banco de dados
        /// </summary>
        public void CriaBanco(string ScriptBanco, string ScriptTabelas)
        {
            StringBuilder sql = new StringBuilder();        // Armazena a consulta SQL
            SqlCommand comandoSql = new SqlCommand();       // A partir da script SQL e de uma conexão com o banco, executa a script sobre o banco.

            try
            {
                string stringConexao = @"Server= localhost\SQLEXPRESS; Integrated Security = SSPI";  // String de conexão diferente do pradrão!!!

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();
                    sql.Append(ScriptBanco);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria o Banco de dados.

                    sql.Clear();

                    sql.Append(ScriptTabelas); // Adiciona o script para criação das tabelas

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria as tabelas.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Verifica a existência do banco de dados no sistema de banco de dados.
        /// </summary>
        /// <returns>Tabela contendo os bancos que tem o nome 'ListaPresenca'</returns>
        public DataTable VerificaBanco()
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dadosTabela = new DataTable();

            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; database=master; Integrated Security=SSPI"))  // String de conexão diferente do pradrão!!!
                {
                    conexao.Open();
                    sql.Append("SELECT * FROM sys.databases where name = 'ListaPresenca'");      // Consulta para verificar se existe algum banco nomeado 'GradeHorario'

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region METODO_BANCO




        #endregion
    }
}
