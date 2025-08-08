namespace SenacFoods
{
    partial class FrmComanda
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
            txtPesquisarUsuarios = new TextBox();
            txtPesquisa = new TextBox();
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisarUsuarios
            // 
            txtPesquisarUsuarios.BackColor = SystemColors.Control;
            txtPesquisarUsuarios.Font = new Font("Segoe UI", 11F);
            txtPesquisarUsuarios.Location = new Point(12, 12);
            txtPesquisarUsuarios.Name = "txtPesquisarUsuarios";
            txtPesquisarUsuarios.Size = new Size(113, 37);
            txtPesquisarUsuarios.TabIndex = 7;
            txtPesquisarUsuarios.Text = "Pesquisar ";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(147, 18);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(530, 31);
            txtPesquisa.TabIndex = 8;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ButtonShadow;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(818, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(64, 46);
            btnFechar.TabIndex = 9;
            btnFechar.Tag = "x";
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 451);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comandas";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Location = new Point(617, 414);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(119, 46);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(807, 296);
            dataGridView1.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Khaki;
            btnAdicionar.Location = new Point(19, 43);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(167, 43);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Nova Comanda";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.Location = new Point(754, 486);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 46);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 544);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(txtPesquisarUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            Text = "frmComanda";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisarUsuarios;
        private TextBox txtPesquisa;
        private Button btnFechar;
        private GroupBox groupBox1;
        private Button btnAdicionar;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnExcluir;
    }
}