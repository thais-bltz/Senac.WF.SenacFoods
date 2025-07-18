namespace SenacFoods
{
    partial class FrmUsuarios
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
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            textBox1 = new TextBox();
            btnAdicionar = new Button();
            btnFechar = new Button();
            txtPesquisarUsuarios = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(807, 296);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.Location = new Point(584, 447);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 46);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Location = new Point(712, 447);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(119, 46);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(530, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(44, 82);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 43);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ButtonShadow;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(816, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(64, 46);
            btnFechar.TabIndex = 5;
            btnFechar.Tag = "x";
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisarUsuarios
            // 
            txtPesquisarUsuarios.BackColor = SystemColors.Control;
            txtPesquisarUsuarios.Font = new Font("Segoe UI", 11F);
            txtPesquisarUsuarios.Location = new Point(44, 27);
            txtPesquisarUsuarios.Name = "txtPesquisarUsuarios";
            txtPesquisarUsuarios.Size = new Size(196, 37);
            txtPesquisarUsuarios.TabIndex = 6;
            txtPesquisarUsuarios.Text = "Pesquisar Usuarios";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 505);
            Controls.Add(txtPesquisarUsuarios);
            Controls.Add(btnFechar);
            Controls.Add(btnAdicionar);
            Controls.Add(textBox1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox textBox1;
        private Button btnAdicionar;
        private Button btnFechar;
        private TextBox txtPesquisarUsuarios;
    }
}