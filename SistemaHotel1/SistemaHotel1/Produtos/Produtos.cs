using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1.Produtos {
    public partial class FrmProdutos : Form {
        public FrmProdutos() {
            InitializeComponent();
        }

        private void HabilitarCampos() 
        {
            TxtNome.Enabled = true;
            TxtDescricao.Enabled = true;
            TxtValor.Enabled = true;
            CbFornecedor.Enabled = true;
            TxtEstoque.Enabled = true;
            BtnImg.Enabled = true;
            TxtNome.Focus();
        }

        private void DesabilitarCampos() 
        {
            TxtNome.Enabled = false;
            TxtDescricao.Enabled = false;
            TxtValor.Enabled = false;
            CbFornecedor.Enabled = false;
            TxtEstoque.Enabled = false;
            BtnImg.Enabled = false;
        }
        // Text -> recebe o texto em vazio ""
        private void LimparCampos() {
            TxtNome.Text = "";
            TxtDescricao.Text = "";
            TxtValor.Text = "";
            TxtEstoque.Text = "";
            LimparFoto();
        }
        private void LimparFoto() 
        {
            Img.Image = SistemaHotel.Properties.Resources.sem_foto;
        }
        private void FrmProdutos_Load(object sender, EventArgs e) 
        {
            LimparFoto();
        }

        private void BtnNovo_Click(object sender, EventArgs e) 
        {
            HabilitarCampos();
            BtnSalvar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e) 
        {
            if (TxtNome.Text.ToString().Trim() == "") {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (TxtValor.Text == "") {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtValor.Focus();
                return;
            }


            //Código do botão para salvar

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            if (TxtNome.Text.ToString().Trim() == "") {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (TxtValor.Text == "") {
                MessageBox.Show("Preencha o Valor!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtValor.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO EDITAR

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNovo.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e) 
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
            {

                //CÓDIGO DO BOTÃO DE EXCLUIR


                MessageBox.Show("Registro Excluído com Sucesso!", "Dados Apagados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNovo.Enabled = true;
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                TxtNome.Text = "";
                TxtNome.Enabled = false;
            }
        }

        //fILTRANDO iMAGEM 
        //VERIFICAÇÃO 
        //ABRIR IMAGEM
        //DIALOG EXTRAI O CAMINHO DO ARQUIVO
        private void BtnImg_Click(object sender, EventArgs e) 
        {
#pragma warning disable IDE0017 // Simplificar a inicialização de objeto
            OpenFileDialog dialog = new OpenFileDialog();
#pragma warning restore IDE0017 // Simplificar a inicialização de objeto
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*png|Arquivos PNG(*.png)|*.png|Todos os arquivos(*.*)|*-*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                MessageBox.Show(foto);
                Img.ImageLocation = foto;
            }
        }
    }
}
