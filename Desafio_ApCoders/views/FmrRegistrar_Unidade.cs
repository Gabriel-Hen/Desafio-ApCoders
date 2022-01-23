using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desafio_ApCoders.views
{
    public partial class FmrRegistrar_Unidade : Form
    {
        MySqlConnection connection;
        public FmrRegistrar_Unidade()
        {
            InitializeComponent();
        }

        private void FmrRegistrar_Unidade_Load(object sender, EventArgs e)
        {

        }

        private void LblIdentificacao_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Unidade_Click(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string registrar_unidade = "INSERT INTO unidade (identificacao, proprietario, condominio, endereco ) " +
                    "VALUES " +
                    "('" + TxtIdentificacao.Text + "', '" + TxtProprietario.Text + "', '" + TxtCondominio.Text + "', '" + TxtEndereco.Text + "')";

                MySqlCommand cmdRegistrar_Unidade = new MySqlCommand(registrar_unidade, connection);

                connection.Open();
                cmdRegistrar_Unidade.ExecuteReader();

                MessageBox.Show("Registrado com sucesso");
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
