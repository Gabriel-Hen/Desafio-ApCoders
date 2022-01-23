using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desafio_ApCoders.views
{
    public partial class FmrRegistrar_Depesas : Form
    {
        MySqlConnection connection;
        public FmrRegistrar_Depesas()
        {
            InitializeComponent();
        }
        public FmrRegistrar_Depesas(string despesa)
        {
            InitializeComponent();
            Despesa = despesa;
        }

        public string Despesa { get; }

        private void BtnRegistrar_Inquilinos_Click(object sender, EventArgs e)
        {
          
         
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string registrar_despesa = "INSERT INTO despesas (unidade_id, descricao, tipo_despesa, valor, vencimento_fatura, status_pagamento ) " +
                    "VALUES " +
                    "('" + TxtUnidade_Id_despesa.Text + "','" + TxtDescricao.Text + "', '" + TxtTipo_despesa.Text + "', '" + TxtValor.Text + "','" + TxtVencimento_Fatura.Text + "', '" + CmbStatus_Pagamento.Text + "')";

                MySqlCommand cmdRegistrar_Despesa = new MySqlCommand(registrar_despesa, connection);

                connection.Open();
                cmdRegistrar_Despesa.ExecuteReader();

                MessageBox.Show("Registrado com sucesso");
                TxtDescricao.Clear();
                TxtTipo_despesa.Clear();
                TxtUnidade_Id_despesa.Clear();
                TxtValor.Clear();
                TxtVencimento_Fatura.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FmrRegistrar_Depesas_Load(object sender, EventArgs e)
        {

        }

        private void TxtVencimento_Fatura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
