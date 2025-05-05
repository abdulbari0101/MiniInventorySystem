/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System;
using System.Data;
using System.Windows.Forms;
namespace  MiniInventorySystem.Forms
{
    public partial class Home_form : Form
    {
        Inventory inventory = new Inventory();
        public Home_form()
        {
            InitializeComponent();
            display();
          
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            SearchProduct_Form search = new SearchProduct_Form(inventory);
            search.ShowDialog();
            Product product = search.product;
            if (product != null)
            {
                AddSameProduct_form addSame = new AddSameProduct_form(product);
                addSame.ShowDialog();
            }
            else
            {
                AddPoduct_form add = new AddPoduct_form(inventory, search.productId);
                add.ShowDialog();
            }
        }
        private void btn_remove_product_Click(object sender, EventArgs e)
        {
            SearchProduct_Form search = new SearchProduct_Form(inventory);
            search.ShowDialog();
            Product product = search.product;
            if (product != null)
            {
                AddSameProduct_form remove = new AddSameProduct_form(product, true);
                remove.ShowDialog();
            }
            else
            {
                MessageBox.Show("This product is not found in Inventory");
            }
            
        }

        private void btn_update_product_Click(object sender, EventArgs e)
        {
            SearchProduct_Form search = new SearchProduct_Form(inventory);
            search.ShowDialog();
            Product product = search.product;
            if (product != null)
            {
                UpdateProduct_form update = new UpdateProduct_form(product);
                update.Show();
            }
            else
            {
                MessageBox.Show("This product is not found in Inventory");
            }
           
        }

        private void btn_display_all_Click(object sender, EventArgs e)
        {
            display();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string productId = txtbox_search.Text.Trim();
            Product product = inventory.searchProduct(productId);
            if (product != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Category");
                dt.Columns.Add("Brand");
                dt.Columns.Add("Model");
                dt.Columns.Add("Name");
                dt.Columns.Add("Price");
                dt.Columns.Add("Quantity");
                dt.Rows.Add(new object[] { product.productID, product.category,
                                           product.productBrand, product.productModel,
                                           product.productName, product.productPrice,
                                           product.quantity});
                myGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("This product is not found in Inventory");
            }

        }
        private void display()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Category");
            dt.Columns.Add("Brand");
            dt.Columns.Add("Model");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");


            foreach (Product product in inventory.productList)
            {
                dt.Rows.Add(new object[] { product.productID, product.category,
                                           product.productBrand, product.productModel,
                                           product.productName, product.productPrice,
                                           product.quantity});
            }

            myGridView.DataSource = dt;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
