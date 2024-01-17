using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico1
{
    public class SoldProduct
    {
        private int _id;    
        private int _productId;
        private int _stock;
        private int _saleId;


        public SoldProduct(int id, int productId, int stock, int saleId)
        {
            _id = id;
            _productId = productId;
            _stock = stock;
            _saleId = saleId;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public int SaleId { get {  return _saleId; } set { _saleId = value; } }
    }
}
