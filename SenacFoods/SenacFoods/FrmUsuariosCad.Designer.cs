namespace SenacFoods
{
    partial class FrmUsuariosCad
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmacaoDeSenha = new TextBox();
            comboBoxPerfil = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            textBox5 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLightLight;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(12, 113);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(626, 37);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(12, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(626, 37);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLightLight;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(12, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(626, 37);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "Senha";
            // 
            // txtConfirmacaoDeSenha
            // 
            txtConfirmacaoDeSenha.BackColor = SystemColors.ControlLightLight;
            txtConfirmacaoDeSenha.Font = new Font("Segoe UI", 11F);
            txtConfirmacaoDeSenha.Location = new Point(12, 311);
            txtConfirmacaoDeSenha.Name = "txtConfirmacaoDeSenha";
            txtConfirmacaoDeSenha.Size = new Size(626, 37);
            txtConfirmacaoDeSenha.TabIndex = 3;
            txtConfirmacaoDeSenha.Text = "Confirmação de senha";
            // 
            // comboBoxPerfil
            // 
            comboBoxPerfil.BackColor = SystemColors.ControlLightLight;
            comboBoxPerfil.Font = new Font("Segoe UI", 11F);
            comboBoxPerfil.FormattingEnabled = true;
            comboBoxPerfil.Items.AddRange(new object[] { "Administrador", "Operador", "Engenheiro", "Eletricista", "Atendente", "Cozinheiro", "Barbeiro", "Assistente Administrativo", "Professor", "Publicitário", "Desenvolvedor Web", "Programador", "Enfermeiro", "Psicólogo", "Outro" });
            comboBoxPerfil.Location = new Point(12, 381);
            comboBoxPerfil.Name = "comboBoxPerfil";
            comboBoxPerfil.Size = new Size(352, 38);
            comboBoxPerfil.TabIndex = 4;
            comboBoxPerfil.Text = "Perfil";
            comboBoxPerfil.SelectedIndexChanged += comboBoxPerfil_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.YellowGreen;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.Location = new Point(598, 452);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(121, 52);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(725, 451);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 53);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 89);
            panel1.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Tan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 15F);
            textBox5.Location = new Point(13, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 40);
            textBox5.TabIndex = 0;
            textBox5.Text = "Cad Usuarios";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Location = new Point(814, 3);
            button1.Name = "button1";
            button1.Size = new Size(51, 42);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 516);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(comboBoxPerfil);
            Controls.Add(txtConfirmacaoDeSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCad";
            Text = "FrmUsuariosCad";
            Load += FrmUsuariosCad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmacaoDeSenha;
        private ComboBox comboBoxPerfil;
        private Button btnSalvar;
        private Button btnCancelar;
        private Panel panel1;
        private TextBox textBox5;
        private Button button1;
    }
}