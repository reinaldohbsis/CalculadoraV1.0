using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    public class Resultado
    {
        

        public double Resposta(double numa, double numb, char operador)
        {
            switch (operador) {
                case '+':
                    return numa + numb;
                case '-':
                    return numa - numb;
                case '*':
                    return numa * numb;
                case '/':
                    if (numb == 0)
                    {
                        return 0;
                    }
                    return numa / numb;
                case ' ':
                    return numa;          
            }
            return 0;

        }

        public string ErroRe()
        {
                 return "Não seja um animal";        
        }


    }
}
