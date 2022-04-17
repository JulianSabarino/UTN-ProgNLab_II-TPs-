namespace Tp1_Sabarino
{
    partial class frm_tp1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_butGroup = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_operation = new System.Windows.Forms.Button();
            this.gbox_converter = new System.Windows.Forms.GroupBox();
            this.btn_bin2dec = new System.Windows.Forms.Button();
            this.btn_dec2bin = new System.Windows.Forms.Button();
            this.lst_memory = new System.Windows.Forms.ListBox();
            this.gbox_data = new System.Windows.Forms.GroupBox();
            this.cmb_operation = new System.Windows.Forms.ComboBox();
            this.txt_firstNumber = new System.Windows.Forms.TextBox();
            this.txt_secNumber = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gbox_butGroup.SuspendLayout();
            this.gbox_converter.SuspendLayout();
            this.gbox_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_butGroup
            // 
            this.gbox_butGroup.Controls.Add(this.btn_close);
            this.gbox_butGroup.Controls.Add(this.btn_clean);
            this.gbox_butGroup.Controls.Add(this.btn_operation);
            this.gbox_butGroup.Location = new System.Drawing.Point(73, 188);
            this.gbox_butGroup.Name = "gbox_butGroup";
            this.gbox_butGroup.Size = new System.Drawing.Size(500, 100);
            this.gbox_butGroup.TabIndex = 0;
            this.gbox_butGroup.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(353, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(140, 59);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(184, 22);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(140, 59);
            this.btn_clean.TabIndex = 1;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_operation
            // 
            this.btn_operation.Location = new System.Drawing.Point(15, 22);
            this.btn_operation.Name = "btn_operation";
            this.btn_operation.Size = new System.Drawing.Size(140, 59);
            this.btn_operation.TabIndex = 0;
            this.btn_operation.Text = "Operar";
            this.btn_operation.UseVisualStyleBackColor = true;
            this.btn_operation.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // gbox_converter
            // 
            this.gbox_converter.Controls.Add(this.btn_bin2dec);
            this.gbox_converter.Controls.Add(this.btn_dec2bin);
            this.gbox_converter.Location = new System.Drawing.Point(73, 311);
            this.gbox_converter.Name = "gbox_converter";
            this.gbox_converter.Size = new System.Drawing.Size(500, 100);
            this.gbox_converter.TabIndex = 1;
            this.gbox_converter.TabStop = false;
            // 
            // btn_bin2dec
            // 
            this.btn_bin2dec.Location = new System.Drawing.Point(258, 22);
            this.btn_bin2dec.Name = "btn_bin2dec";
            this.btn_bin2dec.Size = new System.Drawing.Size(235, 59);
            this.btn_bin2dec.TabIndex = 1;
            this.btn_bin2dec.Text = "Convertir a Decimal";
            this.btn_bin2dec.UseVisualStyleBackColor = true;
            this.btn_bin2dec.Click += new System.EventHandler(this.btn_bin2dec_Click);
            // 
            // btn_dec2bin
            // 
            this.btn_dec2bin.Location = new System.Drawing.Point(15, 22);
            this.btn_dec2bin.Name = "btn_dec2bin";
            this.btn_dec2bin.Size = new System.Drawing.Size(235, 59);
            this.btn_dec2bin.TabIndex = 0;
            this.btn_dec2bin.Text = "Convertir a Binario";
            this.btn_dec2bin.UseVisualStyleBackColor = true;
            this.btn_dec2bin.Click += new System.EventHandler(this.btn_dec2bin_Click);
            // 
            // lst_memory
            // 
            this.lst_memory.FormattingEnabled = true;
            this.lst_memory.ItemHeight = 15;
            this.lst_memory.Location = new System.Drawing.Point(586, 32);
            this.lst_memory.Name = "lst_memory";
            this.lst_memory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_memory.Size = new System.Drawing.Size(190, 379);
            this.lst_memory.TabIndex = 2;
            // 
            // gbox_data
            // 
            this.gbox_data.Controls.Add(this.cmb_operation);
            this.gbox_data.Controls.Add(this.txt_firstNumber);
            this.gbox_data.Controls.Add(this.txt_secNumber);
            this.gbox_data.Location = new System.Drawing.Point(73, 62);
            this.gbox_data.Name = "gbox_data";
            this.gbox_data.Size = new System.Drawing.Size(500, 100);
            this.gbox_data.TabIndex = 3;
            this.gbox_data.TabStop = false;
            // 
            // cmb_operation
            // 
            this.cmb_operation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_operation.FormattingEnabled = true;
            this.cmb_operation.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmb_operation.Location = new System.Drawing.Point(216, 36);
            this.cmb_operation.Name = "cmb_operation";
            this.cmb_operation.Size = new System.Drawing.Size(76, 33);
            this.cmb_operation.TabIndex = 2;
            // 
            // txt_firstNumber
            // 
            this.txt_firstNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_firstNumber.Location = new System.Drawing.Point(15, 36);
            this.txt_firstNumber.MinimumSize = new System.Drawing.Size(4, 59);
            this.txt_firstNumber.Name = "txt_firstNumber";
            this.txt_firstNumber.Size = new System.Drawing.Size(140, 32);
            this.txt_firstNumber.TabIndex = 1;
            // 
            // txt_secNumber
            // 
            this.txt_secNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_secNumber.Location = new System.Drawing.Point(353, 36);
            this.txt_secNumber.MinimumSize = new System.Drawing.Size(4, 59);
            this.txt_secNumber.Name = "txt_secNumber";
            this.txt_secNumber.Size = new System.Drawing.Size(140, 32);
            this.txt_secNumber.TabIndex = 0;
            // 
            // lbl_result
            // 
            this.lbl_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_result.Location = new System.Drawing.Point(545, 27);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_result.Size = new System.Drawing.Size(26, 32);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = " .";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_tp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.gbox_data);
            this.Controls.Add(this.lst_memory);
            this.Controls.Add(this.gbox_converter);
            this.Controls.Add(this.gbox_butGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_tp1";
            this.Text = "Tp1 Sabarino";
            this.gbox_butGroup.ResumeLayout(false);
            this.gbox_converter.ResumeLayout(false);
            this.gbox_data.ResumeLayout(false);
            this.gbox_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_butGroup;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_operation;
        private System.Windows.Forms.GroupBox gbox_converter;
        private System.Windows.Forms.Button btn_bin2dec;
        private System.Windows.Forms.Button btn_dec2bin;
        private System.Windows.Forms.ListBox lst_memory;
        private System.Windows.Forms.GroupBox gbox_data;
        private System.Windows.Forms.ComboBox cmb_operation;
        private System.Windows.Forms.TextBox txt_firstNumber;
        private System.Windows.Forms.TextBox txt_secNumber;
        private System.Windows.Forms.Label lbl_result;
    }
}
