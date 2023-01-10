using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.BO
{
    public class Product
    {

        public int Id { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public double Prix_unitaire { get; set; }
        public DateTime DateP { get; set; }
        public DateTime DateEx { get; set; }
        public byte[] Photo { get; set; }


        public Product()
        {

        }

        public Product(int id, string reference, string designation, double prix_unitaire,DateTime dp,DateTime de, byte[] photo)
        {
            Id = id;
            Reference = reference;
            Designation = designation;
            Prix_unitaire = prix_unitaire;
            DateP = dp;
            DateEx = de;
            Photo = photo;
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Id == product.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(Product left, Product right)
        {
            return EqualityComparer<Product>.Default.Equals(left, right);
        }

        public static bool operator !=(Product left, Product right)
        {
            return !(left == right);
        }
    }
}
