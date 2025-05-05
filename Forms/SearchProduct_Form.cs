/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System;
using System.Windows.Forms;

namespace MiniInventorySystem.Forms
{
    public partial class SearchProduct_Form : Form
    {
        public Product product = null;
        public string productId;
        public Inventory inventory;
        public SearchProduct_Form(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            

                productId = txtBox_ID.Text;
                product = inventory.searchProduct(productId);
                this.Hide();
               
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
