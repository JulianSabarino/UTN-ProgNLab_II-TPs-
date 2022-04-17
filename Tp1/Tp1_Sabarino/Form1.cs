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
        public frm_tp1()
        {
            InitializeComponent();
            lbl_result.Text = " ";
        }

        private void AppendList(StringBuilder operationMemory)
        {
            lst_memory.Items.Add(operationMemory);
            lst_memory.Refresh();
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando(txt_firstNumber.Text);
            Operando number2 = new Operando(txt_secNumber.Text);
            Calculadora calculadora = new Calculadora();

            char operation = cmb_operation.Text[0];

            double result = calculadora.Operar(number1,number2,operation);
            StringBuilder operationMemory = new StringBuilder();

            lbl_result.Text = result.ToString();

            operationMemory.AppendFormat("{0} {1} {2} = {3}", number1.Numero, operation, number2.Numero, result);
            AppendList(operationMemory);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_firstNumber.Clear();
            txt_secNumber.Clear();
            lbl_result.Text = " ";
            cmb_operation.Text = " ";
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

        private void btn_dec2bin_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando(txt_firstNumber.Text);
            StringBuilder operation = new StringBuilder();

            string binary = number1.DecimalABinario(number1.Numero);

            operation.AppendFormat("{0}(10) = {1}(2)",number1.Numero, binary);
            AppendList(operation);

            lbl_result.Text = binary;
            
        }

        private void btn_bin2dec_Click(object sender, EventArgs e)
        {
            Operando number1 = new Operando(txt_firstNumber.Text);
            StringBuilder operation = new StringBuilder();

            string numberDec = number1.BinarioADecimal(number1.Numero);

            operation.AppendFormat("{0}(2) = {1}(10)", number1.Numero, numberDec);
            AppendList(operation);

            lbl_result.Text = numberDec;
        }
    }
}
