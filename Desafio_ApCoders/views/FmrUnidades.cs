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
    public partial class FmrUnidades : Form
    {
        MySqlConnection connection;
        public FmrUnidades()
        {
            InitializeComponent();

            LstUnidades.View = View.Details;
            LstUnidades.LabelEdit = true;
            LstUnidades.AllowColumnReorder = true;
            LstUnidades.FullRowSelect = true;
            LstUnidades.GridLines = true;

            LstUnidades.Columns.Add("ID", 30, HorizontalAlignment.Left);
            LstUnidades.Columns.Add("Identificação", 250, HorizontalAlignment.Left);
            LstUnidades.Columns.Add("Proprietario", 250, HorizontalAlignment.Left);
            LstUnidades.Columns.Add("Condominio", 250, HorizontalAlignment.Left);
            LstUnidades.Columns.Add("Endereço", 250, HorizontalAlignment.Left);
        }

        private void BtnRegistro_Unidade_Click(object sender, EventArgs e)
        {
            FmrRegistrar_Unidade registrar_Unidade = new FmrRegistrar_Unidade(); 
            registrar_Unidade.Show();
        }

        private void LstUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string view_unidade = "SELECT * FROM  unidade";

                connection.Open();

                MySqlCommand cmdView_Unidade = new MySqlCommand(view_unidade, connection);
                MySqlDataReader Leitor_Unidade = cmdView_Unidade.ExecuteReader();

                LstUnidades.Items.Clear();


                while (Leitor_Unidade.Read())
                {
                    string[] row =
                    {
                        Leitor_Unidade.GetString(0),
                        Leitor_Unidade.GetString(1),
                        Leitor_Unidade.GetString(2),
                        Leitor_Unidade.GetString(3),
                        Leitor_Unidade.GetString(4)
                    };
                    var LstViewItem = new ListViewItem(row);

                    LstUnidades.Items.Add(LstViewItem);
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FmrUnidades_Load(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string view_unidade = "SELECT * FROM  unidade";

                connection.Open();

                MySqlCommand cmdView_Unidade = new MySqlCommand(view_unidade, connection);
                MySqlDataReader Leitor_Unidade = cmdView_Unidade.ExecuteReader();

                LstUnidades.Items.Clear();


                while (Leitor_Unidade.Read())
                {
                    string[] row =
                    {
                        Leitor_Unidade.GetString(0),
                        Leitor_Unidade.GetString(1),
                        Leitor_Unidade.GetString(2),
                        Leitor_Unidade.GetString(3),
                        Leitor_Unidade.GetString(4)
                    };
                    var LstViewItem = new ListViewItem(row);

                    LstUnidades.Items.Add(LstViewItem);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
