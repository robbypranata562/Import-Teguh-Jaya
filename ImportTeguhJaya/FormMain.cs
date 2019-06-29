using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
namespace ImportTeguhJaya
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void importDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportBarang importBarang = new ImportBarang();
            importBarang.ShowDialog();

        }
    }
}
