namespace SenacFoods
{
    partial class FrmMesa
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
            label1 = new Label();
            txtPesquisa = new TextBox();
            btnFechar = new Button();
            buttonExcluir = new Button();
            btnAdicionar = new Button();
            buttonSalvar = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar";

            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(121, 20);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(664, 31);
            txtPesquisa.TabIndex = 5;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = SystemColors.ButtonFace;
            btnFechar.Location = new Point(878, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(58, 48);
            btnFechar.TabIndex = 6;
            btnFechar.Tag = "x";
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Salmon;
            buttonExcluir.Location = new Point(606, 489);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(150, 57);
            buttonExcluir.TabIndex = 8;
            buttonExcluir.Text = "X Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.BurlyWood;
            btnAdicionar.Location = new Point(12, 59);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(133, 42);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.YellowGreen;
            buttonSalvar.Font = new Font("Segoe UI", 10F);
            buttonSalvar.Location = new Point(762, 489);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(160, 57);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "# Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(29, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(893, 374);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(847, 305);
            dataGridView1.TabIndex = 0;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 559);
            Controls.Add(groupBox1);
            Controls.Add(buttonSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(buttonExcluir);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            Text = "FrmMesa";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesquisa;
        private Button btnFechar;
        private Button buttonExcluir;
        private Button btnAdicionar;
        private Button buttonSalvar;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}