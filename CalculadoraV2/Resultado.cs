using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    public class Resultado
    {
        

        public static double Resposta(double numa, double numb, char operador)
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

        public static string ErroRe()
        {
                 return "Não seja um animal ";        
        }

        public static void Numb(string temp, double num, char operador, out double numa, out double numb)
        {
            try
            {
                numb =  double.Parse(temp.Substring(temp.LastIndexOf(' ')));
                numa = num;
                
            }
            catch
            {
                try
                {
                    numa = double.Parse(temp);
                    numb = 0;
                }
                catch
                {
                    numb = double.Parse(temp.Substring(temp.LastIndexOf(' ')).Replace("%",""))/100;                  
                    numa = num;

                    if (operador != ' ')
                    {
                        switch (operador)
                        {
                            case '/':
                                numb += 0;
                                break;
                            case '*':
                                numb += 0;
                                break;
                            default:
                                numb *= num;
                                break;
                        }
                    }
                }
                
            }
            
        }


    }
}
