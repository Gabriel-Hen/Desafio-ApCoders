namespace Desafio_ApCoders.views
{
    partial class FmrRegistrar_Unidade
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
            this.LblIdentificacao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblProprietario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblCondominio = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.BtnRegistrar_Unidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIdentificacao
            // 
            this.LblIdentificacao.AutoSize = true;
            this.LblIdentificacao.Location = new System.Drawing.Point(12, 9);
            this.LblIdentificacao.Name = "LblIdentificacao";
            this.LblIdentificacao.Size = new System.Drawing.Size(68, 13);
            this.LblIdentificacao.TabIndex = 0;
            this.LblIdentificacao.Text = "Identificação";
            this.LblIdentificacao.Click += new System.EventHandler(this.LblIdentificacao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 3;
            // 
            // LblProprietario
            // 
            this.LblProprietario.AutoSize = true;
            this.LblProprietario.Location = new System.Drawing.Point(12, 65);
            this.LblProprietario.Name = "LblProprietario";
            this.LblProprietario.Size = new System.Drawing.Size(60, 13);
            this.LblProprietario.TabIndex = 2;
            this.LblProprietario.Text = "Proprietario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LblCondominio
            // 
            this.LblCondominio.AutoSize = true;
            this.LblCondominio.Location = new System.Drawing.Point(13, 123);
            this.LblCondominio.Name = "LblCondominio";
            this.LblCondominio.Size = new System.Drawing.Size(62, 13);
            this.LblCondominio.TabIndex = 4;
            this.LblCondominio.Text = "Condominio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 7;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(14, 178);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(53, 13);
            this.LblEndereco.TabIndex = 6;
            this.LblEndereco.Text = "Endereço";
            // 
            // BtnRegistrar_Unidade
            // 
            this.BtnRegistrar_Unidade.Location = new System.Drawing.Point(105, 241);
            this.BtnRegistrar_Unidade.Name = "BtnRegistrar_Unidade";
            this.BtnRegistrar_Unidade.Size = new System.Drawing.Size(77, 38);
            this.BtnRegistrar_Unidade.TabIndex = 8;
            this.BtnRegistrar_Unidade.Text = "Registrar";
            this.BtnRegistrar_Unidade.UseVisualStyleBackColor = true;
            // 
            // FmrRegistrar_Unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistrar_Unidade);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblCondominio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblProprietario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblIdentificacao);
            this.Name = "FmrRegistrar_Unidade";
            this.Text = "FmrRegistrar_Unidade";
            this.Load += new System.EventHandler(this.FmrRegistrar_Unidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIdentificacao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblProprietario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblCondominio;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Button BtnRegistrar_Unidade;
    }
}