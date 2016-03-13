using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace AcessoDados
{
    public class ExcelAcessoDados
    {
        /// <summary>
        /// Aplicação excel
        /// </summary>
        private Application xlsApp;
        /// <summary>
        /// Arquivo excel
        /// </summary>
        private Workbook xlsWorkbook;
        /// <summary>
        /// Planilha do arquivo excel
        /// </summary>
        private Worksheet xlsWorksheet;
        /// <summary>
        /// Nome do arquivo excel padrão
        /// </summary>
        private string defaultFile = @"" + Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "planilha.xlsx";
        
        public void CriaArquivo(string fileName)
        {

        }

        public void EscreveArquivo(string fileName)
        {

        }

        public void LeArquivo(string fileName)
        {

        }

        public void ApagaArquivo(string fileName)
        {

        }

        void LiberaObjeto(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
