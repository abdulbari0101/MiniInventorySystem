/* 
 ريمان العثماني | 2306507
 هاجر الشرابي | 2306798
 جنى الصبحي     | 2305715
 */
namespace MiniInventorySystem
{
    public class Product
    {
        public string productID { set; get; }
        public string productBrand { set; get; }
        public string productModel { set; get; }
        public string productName { set; get; }
        public string category { set; get; }
        public double quantity { set; get; }
        public double productPrice { set; get; }

        public Product(string productID, string productBrand, string productModel, string productName, string category, double quantity, double productPrice)
        {
            this.productID = productID;
            this.productBrand = productBrand;
            this.productModel = productModel;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }
        public Product()
        {

        }
    }
}
