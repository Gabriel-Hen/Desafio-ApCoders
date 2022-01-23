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
    public partial class FmrInquilinos : Form
    {
        MySqlConnection connection;
        public FmrInquilinos()
        {
            InitializeComponent();
            LstInquilinos.View = View.Details;
            LstInquilinos.LabelEdit = true;
            LstInquilinos.AllowColumnReorder = true;
            LstInquilinos.FullRowSelect = true;
            LstInquilinos.GridLines = true;

            LstInquilinos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Id_Unidade", 70, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Idade", 50, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Sexo", 70, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            LstInquilinos.Columns.Add("Email", 250, HorizontalAlignment.Left);
        }

        private void BtnRegistro_Inquilino_Click(object sender, EventArgs e)
        {
            FmrRegistrar_Inquilino registrar_Inquilino = new FmrRegistrar_Inquilino();
            registrar_Inquilino.Show();
        }

        private void FmrInquilinos_Load(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string view_inquilinos = "SELECT * FROM  inquilinos";

                connection.Open();

                MySqlCommand cmdView_Inquilinos = new MySqlCommand(view_inquilinos, connection);
                MySqlDataReader Leitor_Inquilinos = cmdView_Inquilinos.ExecuteReader();

                while (Leitor_Inquilinos.Read())
                {
                    string[] row =
                    {
                        Leitor_Inquilinos.GetString(0),
                        Leitor_Inquilinos.GetString(1),
                        Leitor_Inquilinos.GetString(2),
                        Leitor_Inquilinos.GetString(3),
                        Leitor_Inquilinos.GetString(4),
                        Leitor_Inquilinos.GetString(5),
                        Leitor_Inquilinos.GetString(6)
                    };
                    var LstViewItem = new ListViewItem(row);

                    LstInquilinos.Items.Add(LstViewItem);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAtualizar_Inquilinos_Click(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string view_inquilinos = "SELECT * FROM  inquilinos";

                connection.Open();

                MySqlCommand cmdView_Inquilinos = new MySqlCommand(view_inquilinos, connection);
                MySqlDataReader Leitor_Inquilinos = cmdView_Inquilinos.ExecuteReader();

                LstInquilinos.Items.Clear();

                while (Leitor_Inquilinos.Read())
                {
                    string[] row =
                    {
                        Leitor_Inquilinos.GetString(0),
                        Leitor_Inquilinos.GetString(1),
                        Leitor_Inquilinos.GetString(2),
                        Leitor_Inquilinos.GetString(3),
                        Leitor_Inquilinos.GetString(4),
                        Leitor_Inquilinos.GetString(5),
                        Leitor_Inquilinos.GetString(6)
                    };
                    var LstViewItem = new ListViewItem(row);

                    LstInquilinos.Items.Add(LstViewItem);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
