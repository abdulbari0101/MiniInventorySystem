/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System;
using System.Windows.Forms;

namespace MiniInventorySystem.Forms
{
    public partial class AddPoduct_form : Form
    {
        string productID;
        string productBrand;
        string productModel;
        string productName;
        string category;
        double quantity;
        double productPrice;
        Inventory inventory;
        public AddPoduct_form(Inventory inventory,string productID)
        {
            InitializeComponent();

            this.inventory = inventory;
            this.productID = productID;

           
            menu_category.Items.AddRange(new object []{  "Electronics", "Electrical", "Mobiles", "Computers"});
            txtBox_ID.Text = productID;
        }
           

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                productID = txtBox_ID.Text;
                productName = txtBox_name.Text;
                productBrand = txtBox_brand.Text;
                productModel = txtBox_model.Text;
                category = menu_category.Text;
                quantity = double.Parse(txtBox_Quantity.Text);
                productPrice = double.Parse(txtBox_price.Text);
                Product product = new Product(productID, productBrand, productModel, productName, category, quantity, productPrice);

                inventory.addProduct(product);
                MessageBox.Show("Product added successfully.");

                resetTextBox();
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
        private void resetTextBox()
        {
            txtBox_ID.Clear();
            txtBox_name.Clear();
            txtBox_brand.Clear();
            txtBox_model.Clear();
            txtBox_Quantity.Clear();
            txtBox_price.Clear();
        }
    }
}
