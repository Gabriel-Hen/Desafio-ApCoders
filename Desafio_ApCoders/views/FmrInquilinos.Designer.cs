namespace Desafio_ApCoders.views
{
    partial class FmrInquilinos
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
            this.LstInquilinos = new System.Windows.Forms.ListView();
            this.Id_inquilinos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRegistro_Inquilino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstInquilinos
            // 
            this.LstInquilinos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_inquilinos,
            this.Nome,
            this.Idade,
            this.Sexo,
            this.Telefone,
            this.Email});
            this.LstInquilinos.FullRowSelect = true;
            this.LstInquilinos.GridLines = true;
            this.LstInquilinos.HideSelection = false;
            this.LstInquilinos.Location = new System.Drawing.Point(12, 12);
            this.LstInquilinos.MultiSelect = false;
            this.LstInquilinos.Name = "LstInquilinos";
            this.LstInquilinos.Size = new System.Drawing.Size(776, 271);
            this.LstInquilinos.TabIndex = 1;
            this.LstInquilinos.UseCompatibleStateImageBehavior = false;
            this.LstInquilinos.View = System.Windows.Forms.View.Details;
            // 
            // Id_inquilinos
            // 
            this.Id_inquilinos.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 123;
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            this.Idade.Width = 55;
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 69;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 164;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 193;
            // 
            // BtnRegistro_Inquilino
            // 
            this.BtnRegistro_Inquilino.Location = new System.Drawing.Point(651, 341);
            this.BtnRegistro_Inquilino.Name = "BtnRegistro_Inquilino";
            this.BtnRegistro_Inquilino.Size = new System.Drawing.Size(118, 43);
            this.BtnRegistro_Inquilino.TabIndex = 2;
            this.BtnRegistro_Inquilino.Text = "Registrar";
            this.BtnRegistro_Inquilino.UseVisualStyleBackColor = true;
            // 
            // FmrInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistro_Inquilino);
            this.Controls.Add(this.LstInquilinos);
            this.Name = "FmrInquilinos";
            this.Text = "FmrInquilinos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstInquilinos;
        private System.Windows.Forms.ColumnHeader Id_inquilinos;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Idade;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button BtnRegistro_Inquilino;
    }
}