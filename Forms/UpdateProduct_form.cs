/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System;
using System.Windows.Forms;

namespace MiniInventorySystem.Forms
{
    public partial class UpdateProduct_form : Form
    {
        Product product;
        
        string productBrand;
        string productModel;
        string productName;
        string category;
        double quantity;
        double productPrice;
        
        public UpdateProduct_form(Product product)
        {
            InitializeComponent();
            this.product = product;

            menu_category.Items.AddRange(new object[] { "Electronics", "Electrical", "Mobiles", "Computers" });

            // set data on text box
            txtBox_ID.Text = product.productID;
            txtBox_name.Text = product.productName;
            txtBox_brand.Text = product.productBrand;
            txtBox_model.Text = product.productModel;
            //make category item as selected
            menu_category.Text = product.category;

            txtBox_Quantity.Text = product.quantity.ToString();
            txtBox_price.Text = product.productPrice.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                productName = txtBox_name.Text;
                productBrand = txtBox_brand.Text;
                productModel = txtBox_model.Text;
                category = menu_category.Text;
                quantity = double.Parse(txtBox_Quantity.Text);
                productPrice = double.Parse(txtBox_price.Text);

                //update values
                product.productName = productName;
                product.productBrand = productBrand;
                product.productModel = productModel;
                product.category = category;
                product.quantity = quantity;
                product.productPrice = productPrice;

                MessageBox.Show("The product [" + product.productName + "] updated successfully");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
