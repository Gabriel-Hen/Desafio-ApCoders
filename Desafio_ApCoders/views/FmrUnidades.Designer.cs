namespace Desafio_ApCoders.views
{
    partial class FmrUnidades
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
            this.LstUnidades = new System.Windows.Forms.ListView();
            this.BtnRegistro_Unidade = new System.Windows.Forms.Button();
            this.Id_unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Identificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proprietario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condominio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LstUnidades
            // 
            this.LstUnidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_unidade,
            this.Identificacao,
            this.Proprietario,
            this.Condominio,
            this.Endereco});
            this.LstUnidades.FullRowSelect = true;
            this.LstUnidades.GridLines = true;
            this.LstUnidades.HideSelection = false;
            this.LstUnidades.Location = new System.Drawing.Point(13, 9);
            this.LstUnidades.MultiSelect = false;
            this.LstUnidades.Name = "LstUnidades";
            this.LstUnidades.Size = new System.Drawing.Size(767, 271);
            this.LstUnidades.TabIndex = 0;
            this.LstUnidades.UseCompatibleStateImageBehavior = false;
            this.LstUnidades.View = System.Windows.Forms.View.Details;
            // 
            // BtnRegistro_Unidade
            // 
            this.BtnRegistro_Unidade.Location = new System.Drawing.Point(651, 344);
            this.BtnRegistro_Unidade.Name = "BtnRegistro_Unidade";
            this.BtnRegistro_Unidade.Size = new System.Drawing.Size(104, 37);
            this.BtnRegistro_Unidade.TabIndex = 1;
            this.BtnRegistro_Unidade.Text = "Registrar";
            this.BtnRegistro_Unidade.UseVisualStyleBackColor = true;
            // 
            // Id_unidade
            // 
            this.Id_unidade.Text = "ID";
            // 
            // Identificacao
            // 
            this.Identificacao.Text = "Identificacao";
            this.Identificacao.Width = 175;
            // 
            // Proprietario
            // 
            this.Proprietario.Text = "Proprietario";
            this.Proprietario.Width = 176;
            // 
            // Condominio
            // 
            this.Condominio.Text = "Condominio";
            this.Condominio.Width = 180;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            this.Endereco.Width = 164;
            // 
            // FmrUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistro_Unidade);
            this.Controls.Add(this.LstUnidades);
            this.Name = "FmrUnidades";
            this.Text = "FmrUnidades";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstUnidades;
        private System.Windows.Forms.Button BtnRegistro_Unidade;
        private System.Windows.Forms.ColumnHeader Id_unidade;
        private System.Windows.Forms.ColumnHeader Identificacao;
        private System.Windows.Forms.ColumnHeader Proprietario;
        private System.Windows.Forms.ColumnHeader Condominio;
        private System.Windows.Forms.ColumnHeader Endereco;
    }
}