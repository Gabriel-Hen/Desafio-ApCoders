using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_ApCoders.views
{
    public partial class FmrRegistrar_Inquilino : Form
    {
        MySqlConnection connection;
        public FmrRegistrar_Inquilino()
        {
            InitializeComponent();
        }

        private void FmrRegistrar_Inquilino_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistrar_Inquilinos_Click(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string registrar_unidade = "INSERT INTO inquilinos (unidade_id,nome, idade, sexo, telefone, email ) " +
                    "VALUES " +
                    "('" + TxtUnidade_id_inquilino.Text + "','" +TxtNome.Text + "', '" + TxtIdade.Text + "', '" + CmbSexo.Text + "', '" + TxtTelefone.Text + "', '" + TxtEmail.Text + "')";

                MySqlCommand cmdRegistrar_Unidade = new MySqlCommand(registrar_unidade, connection);

                connection.Open();
                cmdRegistrar_Unidade.ExecuteReader();

                MessageBox.Show("Registrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
