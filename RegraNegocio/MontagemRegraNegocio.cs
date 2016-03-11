using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class MontagemRegraNegocio
    {
        AcessoDados.BancoAcessoDados banco = new AcessoDados.BancoAcessoDados();

        public void Teste()
        {
            try
            {
                banco.Teste();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
