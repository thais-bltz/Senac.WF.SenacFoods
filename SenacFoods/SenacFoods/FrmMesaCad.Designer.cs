namespace SenacFoods
{
    partial class FrmMesaCad
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
            groupBox1 = new GroupBox();
            txtNumeroPessoas = new TextBox();
            label3 = new Label();
            txtNumeroMesa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumeroPessoas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumeroMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 339);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesas";
            // 
            // txtNumeroPessoas
            // 
            txtNumeroPessoas.Location = new Point(57, 212);
            txtNumeroPessoas.Name = "txtNumeroPessoas";
            txtNumeroPessoas.Size = new Size(251, 31);
            txtNumeroPessoas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(57, 179);
            label3.Name = "label3";
            label3.Size = new Size(173, 30);
            label3.TabIndex = 2;
            label3.Text = "Numero Pessoas";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(57, 82);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(251, 31);
            txtNumeroMesa.TabIndex = 1;
            txtNumeroMesa.TextChanged += txtNumeroMesa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(57, 49);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 0;
            label2.Text = "Numero Mesa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Mesas";
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 451);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNumeroMesa;
        private Label label2;
        private TextBox txtNumeroPessoas;
        private Label label3;
    }
}