/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniInventorySystem
{
    public class Inventory
    {
        public List<Product> productList;
        public Inventory()
        {
            productList = new List<Product>();
        }
        public void addProduct(Product product)
        {
            productList.Add(product);
           
        }
        public void RemoveProduct(Product product)
        {

            productList.Remove(product);
            MessageBox.Show("Product removed successfully.");

        }
        public Product searchProduct(string productID) {
          
            foreach (Product product1 in productList)
            {
                if(product1.productID == productID)
                    return product1;
            }

           return null;
        }
   
    }
}
