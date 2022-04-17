using System;

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

        public string DecimalABinario(double number)
        {
            long numberToBinary = Convert.ToInt64(number);
            return Convert.ToString(numberToBinary, 2);
        }

        public string DecimalABinario(string number)
        {
            double numberToBinary = ValidarOperando(number);
            
            return DecimalABinario(numberToBinary);
        }

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
            //numero = ValidarOperando(strNumero);
        }

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

    public class Calculadora
    {
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
