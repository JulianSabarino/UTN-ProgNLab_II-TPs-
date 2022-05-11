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
    public partial class frm_calc : Form
    {
        /// <summary>
        /// Inicializo todo como " " en lugar de "", evita algunos problemas al operar
        /// Obligo al formulario a no cambiar de tamaño
        /// Llamo al Metodo LabelResize, explicado en su Summary
        /// </summary>
        public frm_calc()
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
        /// <param name="operationMemory">StringBuilder que tiene el formato OPERANDO1 OPERACION OPERANDO2 = RESULTADO Envrioment.NewLine</param>
        private void AppendList(StringBuilder operationMemory)
        {
            lst_memory.Items.Add(operationMemory);
            lst_memory.Refresh();
        }

        /// <summary>
        /// Modifico la distancia a la izquierda del label teniendo en cuenta el tamaño
        /// de mi form y actual de mi Label de resultados
        /// </summary>
        private void LabelResize()
        {
            const int y = 27;
            int x = 575 - lbl_result.Width;

            lbl_result.Location = new Point(x, y);
        }

        /// <summary>
        /// Funcion llamada para cambiar los valores de los txt_operandos o cmb_operacion en caso de que alguno sea invalido
        /// Si el valor del txt es" " o invalido ("asd") coloco en el txt "0" y 0 como valor en el la clase Operando
        /// Si el valor del cmb es" " o invalido ("asd") coloco en el cmb "+" y + como valor en el la clase Calculadora
        /// </summary>
        /// <param name="num1">Operando 1</param>
        /// <param name="num2">Operando 2</param>
        /// <param name="operation">Combo_box de operacion</param>
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
        /// Sobrecarga del metodo anterior en caso de querer usar el txt_firstnumber para calcular binarios
        /// </summary>
        /// <param name="num1"></param>
        private void TextBoxReprint(Operando num1)
        {
            if (num1.Numero == "0")
                txt_firstNumber.Text = "0";
        }

        /// <summary>
        /// Creo operandos y la calculadora
        /// Arreglo los txt y cmb en caso de ser necesario
        /// si la operacion es / 0, cambio mi texto por Math Error
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

            operationMemory.Clear();

            if (operation == '/' && number2.Numero == "0")
            {
                operationMemory.AppendFormat("{0} / 0 = Math Error", number1.Numero);
                lbl_result.Text = "Math Error";
            }
            else
            {
                operationMemory.AppendFormat("{0} {1} {2} = {3}", number1.Numero, operation, number2.Numero, result);
            }

            LabelResize();
            AppendList(operationMemory);
            
        }

        /// <summary>
        /// Limpia de la siguiente manera:
        /// txt a " "
        /// lbl a " "
        /// cmb a " "
        /// Ubico el label en una posicion necesaria
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

        /// <summary>
        /// Llamo al form.Close()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Creo un unico operando y tomo valor desde el label.
        /// En caso de de ser invalido su valor es 0
        /// 
        /// Y lo convierto a binario
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
        /// Creo un unico operando y tomo valor desde el label.
        /// En caso de de ser invalido su valor es 0
        /// 
        /// Y lo convierto a decimal
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

        /// <summary>
        /// Al estar cerrando (sea por el boton cerrar o por la cruz) abro un message box
        /// Cierro dependiendo de la respuesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_tp1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
            DialogResult opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
