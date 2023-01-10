using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Junior.BO;

namespace JuniorWinform.FrmProduct
{
    public partial class FrmProductEdit : Form
    {
        public Product Product { get; set; }
        public FrmProductEdit()
        {
            InitializeComponent();
        }
        public FrmProductEdit(Product product) : this()
        {
            Product = product;
            txt_ref.Text = product.Reference;
            txt_px.Text = product.Prix_unitaire.ToString();
            dtpdp.Value = product.DateP;
            dtp_de.Value = product.DateEx;
            if (product.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(product.Photo));
        }

        private void FrmProductEdit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images(*.jpg,*.jpeg,*.png,*.gif,*.tiff)|*.jpg;*.jpeg;*.png;*.gif;*.tiff";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            long prix;
            long.TryParse(txt_px.Text, out prix);
            byte[] photo = null;
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                photo = File.ReadAllBytes(pictureBox1.ImageLocation);
            }
            else if (pictureBox1.Image != null)
            {
                photo = Product.Photo;
            }
            Product = new Product(Product?.Id ?? 0, txt_ref.Text, txt_des.Text,prix, dtpdp.Value,dtp_de.Value, photo);

        }
    }
}
