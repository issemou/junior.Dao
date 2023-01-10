using Junior.BO;
using Junior.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorWinform.FrmProduct
{
    public partial class FrmProductList : Form
    {
        private List<Product> myproduct;
        private readonly string connectionString;
        private readonly ProductDAO productDAO;
        public FrmProductList()
        {
            InitializeComponent();
            myproduct = new List<Product>();
            connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
            productDAO = new ProductDAO("SqlServer");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            myproduct = productDAO.GetAll().ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = myproduct;
            dataGridView1.ClearSelection();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProductEdit form = new FrmProductEdit();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var product = form.Product;
                    productDAO.Add(product);
                    myproduct.Add(product);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = myproduct;
                    MessageBox.Show
                    (
                        "Save done !",
                        "Confirmation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
               (
                   ex.Message +" " + ex.StackTrace,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductList_Load(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        var oldProduct = dataGridView1.SelectedRows[i].DataBoundItem as Product;
                        FrmProductEdit form = new FrmProductEdit(oldProduct);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var product = form.Product;
                            productDAO.Set(product);
                            var index = myproduct.IndexOf(oldProduct);
                            myproduct[index] = product;
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = myproduct;
                            MessageBox.Show
                            (
                                "Save done !",
                                "Confirmation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                  (
                      ex.Message,
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var oldProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                    FrmProductSearch form = new FrmProductSearch();
                    productDAO.Delete(oldProduct.Id);
                    myproduct.Remove(oldProduct);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = myproduct;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                  (
                      ex.Message,
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            var hti = dataGridView1.HitTest(e.X, e.Y);
            dataGridView1.ClearSelection();

            int rowIndex = hti.RowIndex;
            if (e.Button == MouseButtons.Right && rowIndex >= 0)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                var row = dataGrid.Rows[rowIndex];
                row.Selected = true;
                dataGrid.Focus();
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductSearch form = new FrmProductSearch();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var people = productDAO.GetByName(form.Value);
      
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;
            }
        }
    }
}
