using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1.Cadastros {
    public partial class FrmFuncionarios : Form {
        public FrmFuncionarios() {
            InitializeComponent();
        }


        private void HabilitarCampos() {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtEndereco.Enabled = true;
            CbCargo.Enabled = true;
            TxtTelefone.Enabled = true;
            TxtNome.Focus();
        }

        private void DesabilitarCampos() {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            CbCargo.Enabled = false;
            TxtTelefone.Enabled = false;
        }
        // Text -> recebe o texto em vazio ""
        private void LimparCampos() {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
        }

        //validar Radio Bottom
        private void FrmFuncionarios_Load(object sender, EventArgs e) {
            RbNome.Checked = true;
        }

        //Desabilitar CPF
        private void RbNome_CheckedChanged(object sender, EventArgs e) {
            TxtBuscarNome.Visible = true;
            TxtBuscarCPF.Visible = false;

            TxtBuscarNome.Text = "";
            TxtBuscarNome.Text = "";
        }

        //DesabilitarNome
        private void RbCPF_CheckedChanged(object sender, EventArgs e) {
            TxtBuscarNome.Visible = false;
            TxtBuscarCPF.Visible = true;

            TxtBuscarNome.Text = "";
            TxtBuscarNome.Text = "";
        }

        //Habilitando botão Salvar

        private void BtnNovo_Click(object sender, EventArgs e) {
            HabilitarCampos();
            BtnSalvar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        // Verificar se um campo está vazio
        //desabilitar espaços como informações
        private void BtnSalvar_Click(object sender, EventArgs e) {
            if (TxtNome.Text.ToString().Trim() == "") {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (TxtCPF.Text == "   .   .   -") {
                MessageBox.Show("Preencha o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCPF.Focus();
                return;
            }


            //Código do botão para salvar

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();

        }

        private void Grid_Click(object sender, EventArgs e) {
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnSalvar.Enabled = false;

        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            if (TxtNome.Text.ToString().Trim() == "") {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (TxtCPF.Text == "   .   .   -") {
                MessageBox.Show("Preencha o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO DE EDITAR

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNovo.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e) {
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
    }
}

