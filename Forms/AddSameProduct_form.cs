/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System;
using System.Windows.Forms;

namespace MiniInventorySystem.Forms
{
    public partial class AddSameProduct_form : Form
    {
        Product product;
        bool isRemoveProduct = false;
        public AddSameProduct_form(Product product)
        {
            InitializeComponent();
            this.product = product;

            lbl_id.Text = product.productID;
            lbl_model.Text = product.productModel;
            lbl_name.Text = product.productName;
        }
        public AddSameProduct_form(Product product,bool isRemoveProduct)
        {
            InitializeComponent();
            this.product = product;

            lbl_id.Text = product.productID;
            lbl_model.Text = product.productModel;
            lbl_name.Text = product.productName;
            this.isRemoveProduct = isRemoveProduct;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                double input_quantity = double.Parse(txtBox_Quantity.Text);

                double av_quantity = product.quantity;
                double total;

                if (isRemoveProduct == true)
                {

                    if (input_quantity > av_quantity)
                        lbl_over_error.Visible = true;
                    else
                    {
                        input_quantity = input_quantity * -1;

                        total = input_quantity + av_quantity;

                        product.quantity = total;
                        
                        MessageBox.Show("Removing " + Math.Abs(input_quantity) + " items successfully");
                        this.Hide();
                    }

                }
                else
                {
                    total = input_quantity + av_quantity;
                    product.quantity = total;
                    MessageBox.Show("Adding " + input_quantity + " items successfully");
                    this.Hide();
                }
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

        private void AddSameProduct_form_Load(object sender, EventArgs e)
        {
            lbl_aviQuantity.Text = product.quantity.ToString();
        }
    }
}
