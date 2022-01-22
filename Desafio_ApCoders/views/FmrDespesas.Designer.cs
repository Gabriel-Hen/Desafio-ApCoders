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
            this.LstInquilinos = new System.Windows.Forms.ListView();
            this.Id_Despesas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo_Despesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vencimento_Fatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status_Pagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unidade_Despesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRegistro_Despesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstInquilinos
            // 
            this.LstInquilinos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Unidade_Despesa,
            this.Id_Despesas,
            this.Descricao,
            this.Tipo_Despesa,
            this.Valor,
            this.Vencimento_Fatura,
            this.Status_Pagamento});
            this.LstInquilinos.FullRowSelect = true;
            this.LstInquilinos.GridLines = true;
            this.LstInquilinos.HideSelection = false;
            this.LstInquilinos.Location = new System.Drawing.Point(12, 12);
            this.LstInquilinos.MultiSelect = false;
            this.LstInquilinos.Name = "LstInquilinos";
            this.LstInquilinos.Size = new System.Drawing.Size(776, 271);
            this.LstInquilinos.TabIndex = 2;
            this.LstInquilinos.UseCompatibleStateImageBehavior = false;
            this.LstInquilinos.View = System.Windows.Forms.View.Details;
            // 
            // Id_Despesas
            // 
            this.Id_Despesas.DisplayIndex = 0;
            this.Id_Despesas.Text = "ID";
            // 
            // Descricao
            // 
            this.Descricao.DisplayIndex = 1;
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 159;
            // 
            // Tipo_Despesa
            // 
            this.Tipo_Despesa.DisplayIndex = 2;
            this.Tipo_Despesa.Text = "Tipo Despesa";
            this.Tipo_Despesa.Width = 176;
            // 
            // Valor
            // 
            this.Valor.DisplayIndex = 3;
            this.Valor.Text = "Valor";
            this.Valor.Width = 98;
            // 
            // Vencimento_Fatura
            // 
            this.Vencimento_Fatura.DisplayIndex = 4;
            this.Vencimento_Fatura.Text = "Vencimento Fatura";
            this.Vencimento_Fatura.Width = 104;
            // 
            // Status_Pagamento
            // 
            this.Status_Pagamento.DisplayIndex = 5;
            this.Status_Pagamento.Text = "Status Pagamento";
            this.Status_Pagamento.Width = 103;
            // 
            // Unidade_Despesa
            // 
            this.Unidade_Despesa.DisplayIndex = 6;
            this.Unidade_Despesa.Text = "ID Unidade";
            this.Unidade_Despesa.Width = 69;
            // 
            // BtnRegistro_Despesa
            // 
            this.BtnRegistro_Despesa.Location = new System.Drawing.Point(626, 324);
            this.BtnRegistro_Despesa.Name = "BtnRegistro_Despesa";
            this.BtnRegistro_Despesa.Size = new System.Drawing.Size(138, 50);
            this.BtnRegistro_Despesa.TabIndex = 3;
            this.BtnRegistro_Despesa.Text = "Registrar";
            this.BtnRegistro_Despesa.UseVisualStyleBackColor = true;
            // 
            // FmrDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistro_Despesa);
            this.Controls.Add(this.LstInquilinos);
            this.Name = "FmrDespesas";
            this.Text = "FmrDespesas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstInquilinos;
        private System.Windows.Forms.ColumnHeader Id_Despesas;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Tipo_Despesa;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Vencimento_Fatura;
        private System.Windows.Forms.ColumnHeader Status_Pagamento;
        private System.Windows.Forms.ColumnHeader Unidade_Despesa;
        private System.Windows.Forms.Button BtnRegistro_Despesa;
    }
}