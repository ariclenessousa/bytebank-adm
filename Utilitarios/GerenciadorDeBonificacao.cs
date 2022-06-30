using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        //public void Registrar(Diretor Diretor)
        //{
        //    this.totalBonificacao += Diretor.getBonificacao();
        //}

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
