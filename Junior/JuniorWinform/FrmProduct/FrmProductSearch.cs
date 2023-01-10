using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorWinform.FrmProduct
{
    public partial class FrmProductSearch : Form
    {
        public string Value { get; set; }
        public FrmProductSearch()
        {
            InitializeComponent();
        }

        private void FrmProductSearch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Value = textBox1.Text;
        }
    }
}
