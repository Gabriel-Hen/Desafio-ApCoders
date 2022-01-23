namespace Desafio_ApCoders
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnUnidade = new System.Windows.Forms.Button();
            this.BtnInquilinos = new System.Windows.Forms.Button();
            this.BtnDespesas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUnidade
            // 
            this.BtnUnidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnidade.Location = new System.Drawing.Point(12, 12);
            this.BtnUnidade.Name = "BtnUnidade";
            this.BtnUnidade.Size = new System.Drawing.Size(140, 37);
            this.BtnUnidade.TabIndex = 0;
            this.BtnUnidade.Text = "Unidades";
            this.BtnUnidade.UseVisualStyleBackColor = true;
            this.BtnUnidade.Click += new System.EventHandler(this.BtnUnidade_Click);
            // 
            // BtnInquilinos
            // 
            this.BtnInquilinos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInquilinos.Location = new System.Drawing.Point(12, 55);
            this.BtnInquilinos.Name = "BtnInquilinos";
            this.BtnInquilinos.Size = new System.Drawing.Size(140, 37);
            this.BtnInquilinos.TabIndex = 1;
            this.BtnInquilinos.Text = "Inquilinos";
            this.BtnInquilinos.UseVisualStyleBackColor = true;
            this.BtnInquilinos.Click += new System.EventHandler(this.BtnInquilinos_Click);
            // 
            // BtnDespesas
            // 
            this.BtnDespesas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDespesas.Location = new System.Drawing.Point(12, 98);
            this.BtnDespesas.Name = "BtnDespesas";
            this.BtnDespesas.Size = new System.Drawing.Size(140, 46);
            this.BtnDespesas.TabIndex = 2;
            this.BtnDespesas.Text = "Despesas";
            this.BtnDespesas.UseVisualStyleBackColor = true;
            this.BtnDespesas.Click += new System.EventHandler(this.BtnDespesas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 156);
            this.Controls.Add(this.BtnDespesas);
            this.Controls.Add(this.BtnInquilinos);
            this.Controls.Add(this.BtnUnidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUnidade;
        private System.Windows.Forms.Button BtnInquilinos;
        private System.Windows.Forms.Button BtnDespesas;
    }
}

