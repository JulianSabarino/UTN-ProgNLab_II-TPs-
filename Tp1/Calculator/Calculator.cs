﻿using System;

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
            long numberToDecimal = Convert.ToInt32(binary, 2);
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
            return true;
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

            if (!(double.TryParse(numero, out retValue)))
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