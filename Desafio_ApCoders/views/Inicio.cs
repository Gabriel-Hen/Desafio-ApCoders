using Desafio_ApCoders.views;
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

namespace Desafio_ApCoders
{
    public partial class Inicio : Form
    {
        MySqlConnection connection;
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnUnidade_Click(object sender, EventArgs e)
        {
            FmrUnidades unidades = new FmrUnidades();
            unidades.Show();

        }

        private void BtnInquilinos_Click(object sender, EventArgs e)
        {
            FmrInquilinos inquilinos = new FmrInquilinos();
            inquilinos.Show();
        }

        private void BtnDespesas_Click(object sender, EventArgs e)
        {
            FmrDespesas despesas = new FmrDespesas();
            despesas.Show();
        }
    }
}
