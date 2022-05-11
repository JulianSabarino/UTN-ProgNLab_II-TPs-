using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculadora
    {
        /// <summary>
        /// Devuelvo el valor de la cuenta. En caso de que la division es invalida devuelvo 0
        /// </summary>
        /// <param name="num1">Operando 1</param>
        /// <param name="num2">Operando 2</param>
        /// <param name="operador">Operacion</param>
        /// <returns></returns>
        public double Operar(Operando num1, Operando num2, char operador)
        {
            char myOperator = ValidarOperador(operador);
            double retValue = 0;

            switch (myOperator)
            {
                case '+':
                    retValue = num1 + num2;
                    break;
                case '-':
                    retValue = num1 - num2;
                    break;
                case '*':
                    retValue = num1 * num2;
                    break;
                case '/':
                    if (num2.Numero == "0")
                        retValue = 0;
                    else
                        retValue = num1 / num2;
                    break;
            }

            return retValue;
        }

        /// <summary>
        /// Me fijo que mi operacion sea valida, en caso contrario es "+"
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private char ValidarOperador(char operador)
        {
            char myOperator;
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                myOperator = operador;
            else
                myOperator = '+';
            return myOperator;
        }
    }
}
