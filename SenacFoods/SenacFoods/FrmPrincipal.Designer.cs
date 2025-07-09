namespace SenacFoods
{
    partial class FrmPrincipal
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
            btnUsuário = new Button();
            btnPedido = new Button();
            btnComanda = new Button();
            btnCardápio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            lblMensagem = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnUsuário);
            groupBox1.Controls.Add(btnPedido);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardápio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(44, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuário
            // 
            btnUsuário.BackColor = Color.LightCoral;
            btnUsuário.FlatStyle = FlatStyle.Flat;
            btnUsuário.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuário.ForeColor = Color.Black;
            btnUsuário.Location = new Point(665, 61);
            btnUsuário.Name = "btnUsuário";
            btnUsuário.Size = new Size(169, 163);
            btnUsuário.TabIndex = 0;
            btnUsuário.Text = "Usuário";
            btnUsuário.UseVisualStyleBackColor = false;
            btnUsuário.Click += btnUsuário_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.Coral;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(459, 61);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(169, 163);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.LimeGreen;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(236, 61);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(182, 163);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardápio
            // 
            btnCardápio.BackColor = Color.Orange;
            btnCardápio.FlatStyle = FlatStyle.Flat;
            btnCardápio.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardápio.ForeColor = Color.Black;
            btnCardápio.Location = new Point(23, 61);
            btnCardápio.Name = "btnCardápio";
            btnCardápio.Size = new Size(169, 163);
            btnCardápio.TabIndex = 0;
            btnCardápio.Text = "Cardápio";
            btnCardápio.UseVisualStyleBackColor = false;
            btnCardápio.Click += btnCardápio_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F);
            btnFechar.ForeColor = SystemColors.ButtonFace;
            btnFechar.Location = new Point(877, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(64, 46);
            btnFechar.TabIndex = 1;
            btnFechar.Tag = "x";
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 11F);
            btnMinimizar.ForeColor = SystemColors.ButtonFace;
            btnMinimizar.Location = new Point(800, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(64, 46);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Tag = "x";
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 16F);
            lblMensagem.ForeColor = SystemColors.ButtonFace;
            lblMensagem.Location = new Point(180, 17);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(213, 45);
            lblMensagem.TabIndex = 3;
            lblMensagem.Text = "lblMensagem";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Century Gothic", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(334, 252);
            button1.Name = "button1";
            button1.Size = new Size(217, 88);
            button1.TabIndex = 1;
            button1.Text = "Mesas";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(953, 470);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardápio;
        private Button btnPedido;
        private Button btnComanda;
        private Button btnUsuário;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblMensagem;
        private Button button1;
    }
}