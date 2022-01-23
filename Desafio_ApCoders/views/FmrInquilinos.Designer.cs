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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrInquilinos));
            this.LstInquilinos = new System.Windows.Forms.ListView();
            this.BtnRegistro_Inquilino = new System.Windows.Forms.Button();
            this.BtnAtualizar_Inquilinos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstInquilinos
            // 
            this.LstInquilinos.HideSelection = false;
            this.LstInquilinos.Location = new System.Drawing.Point(12, 70);
            this.LstInquilinos.Name = "LstInquilinos";
            this.LstInquilinos.Size = new System.Drawing.Size(1322, 275);
            this.LstInquilinos.TabIndex = 1;
            this.LstInquilinos.UseCompatibleStateImageBehavior = false;
            this.LstInquilinos.View = System.Windows.Forms.View.Details;
            // 
            // BtnRegistro_Inquilino
            // 
            this.BtnRegistro_Inquilino.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro_Inquilino.Location = new System.Drawing.Point(1207, 3);
            this.BtnRegistro_Inquilino.Name = "BtnRegistro_Inquilino";
            this.BtnRegistro_Inquilino.Size = new System.Drawing.Size(127, 51);
            this.BtnRegistro_Inquilino.TabIndex = 2;
            this.BtnRegistro_Inquilino.Text = "Registrar";
            this.BtnRegistro_Inquilino.UseVisualStyleBackColor = true;
            this.BtnRegistro_Inquilino.Click += new System.EventHandler(this.BtnRegistro_Inquilino_Click);
            // 
            // BtnAtualizar_Inquilinos
            // 
            this.BtnAtualizar_Inquilinos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar_Inquilinos.Image = global::Desafio_ApCoders.Properties.Resources.refresh_curve_arrows_icon_icons_com_68503__1_;
            this.BtnAtualizar_Inquilinos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtualizar_Inquilinos.Location = new System.Drawing.Point(12, 3);
            this.BtnAtualizar_Inquilinos.Name = "BtnAtualizar_Inquilinos";
            this.BtnAtualizar_Inquilinos.Size = new System.Drawing.Size(185, 61);
            this.BtnAtualizar_Inquilinos.TabIndex = 3;
            this.BtnAtualizar_Inquilinos.Text = "Atualizar";
            this.BtnAtualizar_Inquilinos.UseVisualStyleBackColor = true;
            this.BtnAtualizar_Inquilinos.Click += new System.EventHandler(this.BtnAtualizar_Inquilinos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inquilinos";
            // 
            // FmrInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAtualizar_Inquilinos);
            this.Controls.Add(this.BtnRegistro_Inquilino);
            this.Controls.Add(this.LstInquilinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrInquilinos";
            this.Text = "Inquilinos";
            this.Load += new System.EventHandler(this.FmrInquilinos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstInquilinos;
        private System.Windows.Forms.Button BtnRegistro_Inquilino;
        private System.Windows.Forms.Button BtnAtualizar_Inquilinos;
        private System.Windows.Forms.Label label1;
    }
}