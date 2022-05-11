using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operando
    {
        private double numero;

        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }

            get
            {
                return numero.ToString();
            }
        }

        /// <summary>
        /// Tomo un string y lo convierto a decimal, si es invalida vale 0
        /// </summary>
        /// <param name="binary">String proveniente de un Label o TxtBox</param>
        /// <returns></returns>
        public string BinarioADecimal(string binary)
        {
            bool isBinary = EsBinario(binary);
            long numberToDecimal;
            if (isBinary)
                numberToDecimal = Convert.ToInt32(binary, 2);
            else
            {
                numberToDecimal = 0;
                Numero = "0";
            }


            return numberToDecimal.ToString();
        }

        /// <summary>
        /// Tomo el numero y lo convierto a binario, si es invalido vale 0
        /// </summary>
        /// <param name="number">Numero proveniente de Label o TxtBox</param>
        /// <returns></returns>
        public string DecimalABinario(double number)
        {
            long numberToBinary = Convert.ToInt64(number);
            return Convert.ToString(numberToBinary, 2);
        }

        /// <summary>
        /// Sobrecarga del metodo anterior, toma un string en lugar de un double
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string DecimalABinario(string number)
        {
            double numberToBinary = ValidarOperando(number);

            return DecimalABinario(numberToBinary);
        }

        /// <summary>
        /// Se fija que los caracteres de un string sean 0 o 1
        /// Si es binario devuelve true
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool isBinary = true;
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    isBinary = false;
                    break;
                }

            }
            return isBinary;
        }

        #region Constructores

        public Operando()
        {
            Numero = "0";
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        #endregion

        #region Sobrecargas
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        #endregion

        /// <summary>
        /// Valido que el operando tenga un valor valido, caso contrario vale 0
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>

        private double ValidarOperando(string numero)
        {
            double retValue;

            if (double.TryParse(numero, out retValue) == false)
            {
                retValue = 0;
            }

            return retValue;
        }

    }
}
