namespace GerenciadorDeFestaBrabo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbNomeConsulta = new System.Windows.Forms.TextBox();
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.libConvidados = new System.Windows.Forms.ListBox();
            this.grbConsulta.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(225, 54);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(553, 58);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciador de Festas";
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.lblResultado);
            this.grbConsulta.Controls.Add(this.pibResultado);
            this.grbConsulta.Controls.Add(this.btnConsultar);
            this.grbConsulta.Controls.Add(this.txbNomeConsulta);
            this.grbConsulta.Controls.Add(this.lblNomeConsulta);
            this.grbConsulta.Location = new System.Drawing.Point(14, 190);
            this.grbConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbConsulta.Size = new System.Drawing.Size(455, 337);
            this.grbConsulta.TabIndex = 2;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(49, 89);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(335, 59);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbNomeConsulta
            // 
            this.txbNomeConsulta.Location = new System.Drawing.Point(115, 44);
            this.txbNomeConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNomeConsulta.Name = "txbNomeConsulta";
            this.txbNomeConsulta.Size = new System.Drawing.Size(229, 21);
            this.txbNomeConsulta.TabIndex = 1;
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Location = new System.Drawing.Point(71, 48);
            this.lblNomeConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(45, 16);
            this.lblNomeConsulta.TabIndex = 0;
            this.lblNomeConsulta.Text = "Nome: ";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.libConvidados);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtNomeCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(476, 190);
            this.grbCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastro.Size = new System.Drawing.Size(443, 337);
            this.grbCadastro.TabIndex = 3;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(49, 174);
            this.pibResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(67, 61);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 3;
            this.pibResultado.TabStop = false;
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::GerenciadorDeFestaBrabo.Properties.Resources._14134696;
            this.pibLogo.Location = new System.Drawing.Point(75, 26);
            this.pibLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(144, 127);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(124, 174);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 4;
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(112, 45);
            this.txtNomeCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(229, 21);
            this.txtNomeCadastro.TabIndex = 3;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(68, 49);
            this.lblNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(45, 16);
            this.lblNomeCadastro.TabIndex = 2;
            this.lblNomeCadastro.Text = "Nome: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(52, 89);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(335, 59);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // libConvidados
            // 
            this.libConvidados.FormattingEnabled = true;
            this.libConvidados.ItemHeight = 16;
            this.libConvidados.Location = new System.Drawing.Point(40, 174);
            this.libConvidados.Name = "libConvidados";
            this.libConvidados.Size = new System.Drawing.Size(369, 116);
            this.libConvidados.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gerenciador de Festas";
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbNomeConsulta;
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.ListBox libConvidados;
    }
}

