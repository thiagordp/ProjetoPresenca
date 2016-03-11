using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class BancoAcessoDados
    {
        public void Teste()
        {
            using (Modelos.Contexto contexto = new Modelos.Contexto())
            {
                try
                {
                    Modelos.Aluno aluno = new Modelos.Aluno();
                    Random random = new Random();


                    aluno.CODIGO_ALUNO = random.Next(13100000, 13109999);
                    aluno.NOME_ALUNO = "FULANO";

                    contexto.Aluno.Add(aluno);

                    contexto.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
    }
}
