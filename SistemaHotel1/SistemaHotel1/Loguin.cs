using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1 {
    public partial class FrmLoguin : Form
       //arrumando cursor na inicialização para iniciar de modo falso
    {
        public FrmLoguin() {
            InitializeComponent();
            pnlLoguin.Visible = false;
        }
        // arrumando localização e adicionando cor Argb
        private void FrmLoguin_Load(object sender, EventArgs e) 
        {
            pnlLoguin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            pnlLoguin.Visible = true;
            btnLoguin.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 121, 212);
            btnLoguin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        //ao inicializar os componentes
        private void PnlLoguin_Paint(object sender, PaintEventArgs e) 
        {
            pnlLoguin.Visible = true;
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e) 
        {

        }

        //Volta Loguin quando a tecla enter é opressionada
        private void BtnLoguin_Click(object sender, EventArgs e) 
        {
            ChamarLogin();
        }

        //Evento KeyDown = quando a tecla ENTER é pressionado
        private void FrmLoguin_KeyDown(object sender, KeyEventArgs e) 
        {
             
            if (e.KeyCode == Keys.Enter) 
            {
                MessageBox.Show("Tecla Enter Pressionada");
                ChamarLogin();
            }
        }

        //Avisar ao usuário para preencher dados
        private void ChamarLogin()
        {
            //ignorar espaço com Trim
            if (TxtUsuario.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Preencha o Usuário!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUsuario.Text = "";
                TxtUsuario.Focus(); 
                return;
            }
            if (txtSenha.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Preencha a Senha!" , "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            // chamar a tela de menu
            //this.hide para fechar a tela de loguin e abrir a tela de Menu

            FrmMenu form = new FrmMenu();
            // this.Hide();
            Limpar();
            form.Show();
        }


        //limpar os dados após fechar menu
        //após limpar o txtUsuario recebe o foco do botão
        private void Limpar() 
        {
            TxtUsuario.Text = "";
            txtSenha.Text = "";
            TxtUsuario.Focus();

        }
        // redimensionar a tela no modo true
        private void FrmLoguin_Resize(object sender, EventArgs e) 
        {
            pnlLoguin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
