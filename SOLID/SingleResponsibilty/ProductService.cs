using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    public class ProductService
    {
        public void CreateProduct(string name, decimal price)
        {
            MessageBox.Show("Ürün eklendi");           

        }
    }
}
