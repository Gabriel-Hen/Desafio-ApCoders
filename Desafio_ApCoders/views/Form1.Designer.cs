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
            this.BtnUnidade = new System.Windows.Forms.Button();
            this.BtnInquilinos = new System.Windows.Forms.Button();
            this.BtnDespesas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUnidade
            // 
            this.BtnUnidade.Location = new System.Drawing.Point(12, 12);
            this.BtnUnidade.Name = "BtnUnidade";
            this.BtnUnidade.Size = new System.Drawing.Size(85, 37);
            this.BtnUnidade.TabIndex = 0;
            this.BtnUnidade.Text = "Unidades";
            this.BtnUnidade.UseVisualStyleBackColor = true;
            // 
            // BtnInquilinos
            // 
            this.BtnInquilinos.Location = new System.Drawing.Point(12, 55);
            this.BtnInquilinos.Name = "BtnInquilinos";
            this.BtnInquilinos.Size = new System.Drawing.Size(85, 37);
            this.BtnInquilinos.TabIndex = 1;
            this.BtnInquilinos.Text = "Inquilinos";
            this.BtnInquilinos.UseVisualStyleBackColor = true;
            // 
            // BtnDespesas
            // 
            this.BtnDespesas.Location = new System.Drawing.Point(12, 98);
            this.BtnDespesas.Name = "BtnDespesas";
            this.BtnDespesas.Size = new System.Drawing.Size(85, 37);
            this.BtnDespesas.TabIndex = 2;
            this.BtnDespesas.Text = "Despesas";
            this.BtnDespesas.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDespesas);
            this.Controls.Add(this.BtnInquilinos);
            this.Controls.Add(this.BtnUnidade);
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

