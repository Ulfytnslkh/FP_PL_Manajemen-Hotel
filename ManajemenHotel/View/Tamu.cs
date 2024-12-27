using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ManajemenHotel.Model.Entity;
using ManajemenHotel.Model;

namespace ManajemenHotel.View
{
    public partial class Tamu : Form
    {
        public Tamu()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form form6 = new FrmTambahTamu();
            form6.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form form7 = new FrmEditTamu();
            form7.Show();
            this.Hide();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Form formK = new Dashboard();
            formK.Show();
            this.Hide();
        }
    }
}
