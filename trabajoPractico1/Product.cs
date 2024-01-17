using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico1
{
    public class Product
    {
        private int _id;
        private int _idUser;
        private string _description;
        private double _costPrice;
        private double _salePrice;
        private int _stock;

        public Product(int id, int idUser, string description, double costPrice, double salePrice, int stock) 
        { 
            this._id= id;
            this._idUser= idUser;
            this._description= description;
            this._costPrice= costPrice;
            this._salePrice=salePrice;
            this._stock= stock;
        }

        public int Id { get { return _id; } }
        public int IdUser { get { return _idUser; } set { _idUser = value; } }
    
        public string Description { get { return _description; } set { _description = value; } }
        public double CostPrice { get { return _costPrice; } set { _costPrice = value; } }
        public double SalePrice {  get { return _salePrice; } set { _salePrice = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
       
    }



}
    