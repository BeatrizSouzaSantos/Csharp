using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.NewFolder1 {
    public partial class FrmCheckIn : Form {
        public FrmCheckIn() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            RbCliente.Enabled = true;
            RbGrupo.Enabled = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            RbGrupo.Enabled = true;
            RbCliente.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;
        }

        private void FrmCheckIn_Load(object sender, EventArgs e) {

        }
    }
}
