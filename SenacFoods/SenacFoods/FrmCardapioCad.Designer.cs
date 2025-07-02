namespace SenacFoods
{
    partial class FrmCardapioCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFechar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            txtPreco = new TextBox();
            txtDescrição = new RichTextBox();
            txtTitulo = new TextBox();
            chkPossuiPreparo = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = SystemColors.ButtonFace;
            btnFechar.Location = new Point(946, 6);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(58, 48);
            btnFechar.TabIndex = 6;
            btnFechar.Tag = "x";
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(679, 564);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 57);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.YellowGreen;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.Location = new Point(823, 500);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 57);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtDescrição);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(992, 565);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(32, 354);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(636, 37);
            txtPreco.TabIndex = 6;
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(32, 168);
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(636, 135);
            txtDescrição.TabIndex = 5;
            txtDescrição.Text = "";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(32, 79);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(636, 37);
            txtTitulo.TabIndex = 4;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Font = new Font("Segoe UI", 10F);
            chkPossuiPreparo.Location = new Point(32, 426);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(176, 32);
            chkPossuiPreparo.TabIndex = 3;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(23, 306);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 2;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(23, 125);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 1;
            label3.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(23, 43);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 0;
            label2.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Cardápio";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 631);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private TextBox txtTitulo;
        private CheckBox chkPossuiPreparo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPreco;
        private RichTextBox txtDescrição;
    }
}