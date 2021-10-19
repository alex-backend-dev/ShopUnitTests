using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Product : IEquatable<Product>
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString() => $"Product ID: {ProductID}, Name: {Name}, Price: {Price}";

        public bool Equals(Product product)
        {
            if (ReferenceEquals(product, null)) return false;
            if (ReferenceEquals(this, product)) return true;
            return ((ProductID == product.ProductID) && (Name == product.Name) && (Price == product.Price));
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return product != null && ProductID.Equals(product.ProductID);
        }

        public override int GetHashCode()
        {
            var hashCode = 227186641;
            hashCode = hashCode * -1521134295 + ProductID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Product leftProduct, Product rightProduct) => leftProduct != null && (leftProduct.Equals(rightProduct));

        public static bool operator !=(Product leftProduct, Product rightProduct) => !(leftProduct == rightProduct);
    }
}
