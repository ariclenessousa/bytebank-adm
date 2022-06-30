using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // N - ...

        private int _tipo;

        public string Nome { get; set; }    // propriedade da classe 

        public string Cpf { get; set; }     // propriedade da classe

        public double Salario { get; set; } // propriedade da classe

        public double getBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
