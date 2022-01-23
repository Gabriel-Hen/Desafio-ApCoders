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
    public partial class FmrDespesas : Form
    {
 
     
        MySqlConnection connection;
        public FmrDespesas()
        {
            InitializeComponent();
            LstDespesas.View = View.Details;
            LstDespesas.LabelEdit = true;
            LstDespesas.AllowColumnReorder = true;
            LstDespesas.FullRowSelect = true;
            LstDespesas.GridLines = true;

            LstDespesas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Id_Unidade", 70, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Descrição", 250, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Tipo Despesa", 250, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Valor", 50, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Vencimento Fatura", 150, HorizontalAlignment.Left);
            LstDespesas.Columns.Add("Status Pagamento", 100, HorizontalAlignment.Left);
        }

        private void BtnRegistro_Despesa_Click(object sender, EventArgs e)
        {
            FmrRegistrar_Depesas registrar_Depesas = new FmrRegistrar_Depesas();
            registrar_Depesas.Show();
        }

        private void FmrDespesas_Load(object sender, EventArgs e)
        {
            try
            {


                connection = new MySqlConnection("datasource=localhost;username=root;password=r8o5o4t8;database=apcoders");

                string view_despesas = "SELECT * FROM  despesas";

                connection.Open();

                MySqlCommand cmdView_Despesas = new MySqlCommand(view_despesas, connection);
                MySqlDataReader Leitor_despesas = cmdView_Despesas.ExecuteReader();

                while (Leitor_despesas.Read())
                {
                    string[] row =
                    {
                        Leitor_despesas.GetString(0),
                        Leitor_despesas.GetString(1),
                        Leitor_despesas.GetString(2),
                        Leitor_despesas.GetString(3),
                        Leitor_despesas.GetString(4),
                        Leitor_despesas.GetString(5),
                        Leitor_despesas.GetString(6)
                    };
                    var LstViewItem = new ListViewItem(row);

                    LstDespesas.Items.Add(LstViewItem);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LstDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
