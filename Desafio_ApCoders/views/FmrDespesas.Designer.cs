namespace Desafio_ApCoders.views
{
    partial class FmrDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDespesas));
            this.LstDespesas = new System.Windows.Forms.ListView();
            this.BtnRegistro_Despesa = new System.Windows.Forms.Button();
            this.BtnAtualizar_Despesas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstDespesas
            // 
            this.LstDespesas.HideSelection = false;
            this.LstDespesas.Location = new System.Drawing.Point(12, 70);
            this.LstDespesas.Name = "LstDespesas";
            this.LstDespesas.Size = new System.Drawing.Size(1299, 314);
            this.LstDespesas.TabIndex = 2;
            this.LstDespesas.UseCompatibleStateImageBehavior = false;
            this.LstDespesas.SelectedIndexChanged += new System.EventHandler(this.LstDespesas_SelectedIndexChanged);
            // 
            // BtnRegistro_Despesa
            // 
            this.BtnRegistro_Despesa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro_Despesa.Location = new System.Drawing.Point(1166, 9);
            this.BtnRegistro_Despesa.Name = "BtnRegistro_Despesa";
            this.BtnRegistro_Despesa.Size = new System.Drawing.Size(145, 55);
            this.BtnRegistro_Despesa.TabIndex = 3;
            this.BtnRegistro_Despesa.Text = "Registrar";
            this.BtnRegistro_Despesa.UseVisualStyleBackColor = true;
            this.BtnRegistro_Despesa.Click += new System.EventHandler(this.BtnRegistro_Despesa_Click);
            // 
            // BtnAtualizar_Despesas
            // 
            this.BtnAtualizar_Despesas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar_Despesas.Image = global::Desafio_ApCoders.Properties.Resources.refresh_curve_arrows_icon_icons_com_68503__1_;
            this.BtnAtualizar_Despesas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtualizar_Despesas.Location = new System.Drawing.Point(12, 9);
            this.BtnAtualizar_Despesas.Name = "BtnAtualizar_Despesas";
            this.BtnAtualizar_Despesas.Size = new System.Drawing.Size(187, 55);
            this.BtnAtualizar_Despesas.TabIndex = 4;
            this.BtnAtualizar_Despesas.Text = "Atualizar";
            this.BtnAtualizar_Despesas.UseVisualStyleBackColor = true;
            this.BtnAtualizar_Despesas.Click += new System.EventHandler(this.BtnAtualizar_Despesas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Despesas";
            // 
            // FmrDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAtualizar_Despesas);
            this.Controls.Add(this.BtnRegistro_Despesa);
            this.Controls.Add(this.LstDespesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrDespesas";
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FmrDespesas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegistro_Despesa;
        private System.Windows.Forms.Button BtnAtualizar_Despesas;
        public System.Windows.Forms.ListView LstDespesas;
        private System.Windows.Forms.Label label1;
    }
}