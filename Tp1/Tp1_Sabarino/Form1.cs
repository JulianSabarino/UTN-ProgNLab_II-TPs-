using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator;

namespace Tp1_Sabarino
{
    public partial class frm_tp1 : Form
    {
        /// <summary>
        /// Inicializo todo como " " en lugar de "", evita algunos problemas al operar
        /// Obligo al formulario a no cambiar de tama;o
        /// Cambio el puntero del label de resultado para que siempre quede en la misma posicion
        /// </summary>
        public frm_tp1()
        {
            InitializeComponent();
            lbl_result.Text = " ";
            txt_firstNumber.Text = " ";
            txt_secNumber.Text = " ";
            cmb_operation.Text = " ";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LabelResize();
        }

        /// <summary>
        /// Agrego el texto recibido a mi listbox y lo recargo para que aparezcan los cambios
        /// </summary>
        /// <param name="operationMemory"></param>
        private void AppendList(StringBuilder operationMemory)
        {
            lst_memory.Items.Add(operationMemory);
            lst_memory.Refresh();
        }

        /// <summary>
        /// Cambio el puntero X de mi label para ubicarlo en una posicion relativa
        /// </summary>
        private void LabelResize()
        {
            const int y = 27;
            int x = 575 - lbl_result.Width;

            lbl_result.Location = new Point(x, y);
        }

        /// <summary>
        /// Si el valor de operando es 0, puede darse por ser " " o invalido ("asd") lo coloco en el textbox
        /// si el valor del operando de '+', puede darse por ser ' ' lo coloca en el combobox
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operation"></param>
        private void TextBoxReprint(Operando num1, Operando num2, char operation)
        {
            if (num1.Numero == "0")
                txt_firstNumber.Text = "0";
            if(num2.Numero == "0")
                txt_secNumber.Text = "0";
            if (operation == '+')
                cmb_operation.Text = "+";
        }

        /// <summary>
        /// Lo mismo que lo anterior pero para el primer textbox, en caso de querer usarlo para hacer las cuentas a binario en lugar del label
        /// </summary>
        /// <param name="num1"></param>
        private void TextBoxReprint(Operando num1)
        {
            if (num1.Numero == "0")
                txt_firstNumber.Text = "0";
        }

        /// <summary>
        /// Creo operandos y tomo la operacion, en caso de ser invalidos los valores por defecto son 0 + 0
        /// si la operacion es / 0, cambio mi texto por Syntax Error
        /// 
        /// Orden de operacion es:
        /// Operandos>>operator>>Reprintear textbox>>Operar()>>corroborar resultados>>print sobre label y sobre listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_operation_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando();
            number1.Numero = txt_firstNumber.Text;
            Operando number2 = new Operando();
            number2.Numero = txt_secNumber.Text;
            Calculadora calculadora = new Calculadora();

            char operation = cmb_operation.Text[0];
            
            if (operation == ' ')
                operation = '+';
            TextBoxReprint(number1 ,number2,operation);


            double result = calculadora.Operar(number1, number2, operation);
            StringBuilder operationMemory = new StringBuilder();

            lbl_result.Text = result.ToString();

            operationMemory.AppendFormat("{0} {1} {2} = {3}", number1.Numero, operation, number2.Numero, result);

            if (operation == '/' && number2.Numero == "0")
            {
                operationMemory.Clear();
                operationMemory.AppendFormat("{0} / 0 = Syntax Error",number1.Numero);
                lbl_result.Text = "Syntax Error";
            }

            LabelResize();
            AppendList(operationMemory);
            
        }

        /// <summary>
        /// pongo en " " todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_firstNumber.Clear();
            txt_secNumber.Clear();
            lbl_result.Text = " ";
            cmb_operation.Text = " ";
            LabelResize();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (opcion == DialogResult.Yes)
                this.Close();
        }
        private void frm_tp1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Creo un operando con valor igual a mi label de resultado y opero, el valor por defecto es 0(10) = 0(2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dec2bin_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando();
            number1.Numero = lbl_result.Text;

            StringBuilder operation = new StringBuilder();

            string binary = number1.DecimalABinario(number1.Numero);

            operation.AppendFormat("{0}(10) = {1}(2)",number1.Numero, binary);
            AppendList(operation);

            lbl_result.Text = binary;
            LabelResize();
            TextBoxReprint(number1);
        }

        /// <summary>
        /// Creo un operando con valor igual a mi label de resultado y opero, el valor por defecto es 0(2) = 0(10)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bin2dec_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando();
            number1.Numero = lbl_result.Text;
            StringBuilder operation = new StringBuilder();
            string numberDec = "0";

            //if (System.Text.RegularExpressions.Regex.IsMatch(number1.Numero, "[^0-1]"))
            numberDec = number1.BinarioADecimal(number1.Numero);

            operation.AppendFormat("{0}(2) = {1}(10)", number1.Numero, numberDec);
            AppendList(operation);

            lbl_result.Text = numberDec;
            LabelResize();
            TextBoxReprint(number1);
        }
    }
}
