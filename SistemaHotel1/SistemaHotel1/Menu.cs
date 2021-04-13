using SistemaHotel.NewFolder1;
using SistemaHotel.Reservas;
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

namespace SistemaHotel1 {
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e) {
            pnlTopo.BackColor = Color.FromArgb(12, 187, 188);
        }
        // adicionat a tela de funcinários
        // Cadastros = não está no mesmo diretório.
        // = para instanciar

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show();
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void label1_Click(object sender, EventArgs e) {
#pragma warning restore IDE1006 // Estilos de Nomenclatura

        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void timer1_Tick(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            label1.Text = (DateTime.Now.ToString("HH:mm:ss"));

        }

        private void LblData_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void label3_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e) 
        {
           
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FrmCheckIn form = new FrmCheckIn();
            form.Show();
        }

        private void MenuReservas_Click(object sender, EventArgs e) 
        {
            SistemaHotel.Reservas.FrmQuartos form = new SistemaHotel.Reservas.FrmQuartos();
                form.Show();
        }
    }
}
