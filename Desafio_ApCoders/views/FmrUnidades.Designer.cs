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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUnidades));
            this.LstUnidades = new System.Windows.Forms.ListView();
            this.BtnRegistro_Unidade = new System.Windows.Forms.Button();
            this.BtnView_Unidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstUnidades
            // 
            this.LstUnidades.HideSelection = false;
            this.LstUnidades.Location = new System.Drawing.Point(12, 87);
            this.LstUnidades.Name = "LstUnidades";
            this.LstUnidades.Size = new System.Drawing.Size(1138, 337);
            this.LstUnidades.TabIndex = 0;
            this.LstUnidades.UseCompatibleStateImageBehavior = false;
            this.LstUnidades.SelectedIndexChanged += new System.EventHandler(this.LstUnidades_SelectedIndexChanged);
            // 
            // BtnRegistro_Unidade
            // 
            this.BtnRegistro_Unidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro_Unidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegistro_Unidade.Location = new System.Drawing.Point(960, 17);
            this.BtnRegistro_Unidade.Name = "BtnRegistro_Unidade";
            this.BtnRegistro_Unidade.Size = new System.Drawing.Size(190, 64);
            this.BtnRegistro_Unidade.TabIndex = 1;
            this.BtnRegistro_Unidade.Text = "Registrar";
            this.BtnRegistro_Unidade.UseVisualStyleBackColor = true;
            this.BtnRegistro_Unidade.Click += new System.EventHandler(this.BtnRegistro_Unidade_Click);
            // 
            // BtnView_Unidade
            // 
            this.BtnView_Unidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView_Unidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnView_Unidade.Image = global::Desafio_ApCoders.Properties.Resources.refresh_curve_arrows_icon_icons_com_68503__1_;
            this.BtnView_Unidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnView_Unidade.Location = new System.Drawing.Point(12, 17);
            this.BtnView_Unidade.Name = "BtnView_Unidade";
            this.BtnView_Unidade.Size = new System.Drawing.Size(190, 64);
            this.BtnView_Unidade.TabIndex = 2;
            this.BtnView_Unidade.Text = "Atualizar";
            this.BtnView_Unidade.UseVisualStyleBackColor = true;
            this.BtnView_Unidade.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidades";
            // 
            // FmrUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnView_Unidade);
            this.Controls.Add(this.BtnRegistro_Unidade);
            this.Controls.Add(this.LstUnidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrUnidades";
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.FmrUnidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstUnidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistro_Unidade;
        private System.Windows.Forms.Button BtnView_Unidade;
    }
}