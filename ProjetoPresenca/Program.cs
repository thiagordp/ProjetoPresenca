using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPresenca
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                #region VERIFICA_EXISTE_BANCO

                RegraNegocio.BancoRegraNegocio bancoRN = new RegraNegocio.BancoRegraNegocio();
                DataTable dadosTabela = new DataTable();
                dadosTabela = bancoRN.VerificaBanco();

                if (dadosTabela.Rows.Count <= 0)
                {
                    bancoRN.CriaBanco();
                }
                #endregion

                Application.Run(new frmPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o sistema.\n\nDetalhe: \"" + ex.Message + "\"");
            }

        }
    }
}
