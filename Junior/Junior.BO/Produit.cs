using System.Collections.Generic;

namespace Junior.BO
{
    public class Produit
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public int Prix_Unitaire { get; set; }
        public float TVA { get; set; }
        public byte[] Photo { get; set; }

        public Produit()
        {

        }

        public Produit(int id, string reference, string designation, int prix_Unitaire, float tVA, byte[] photo)
        {
            Id = id;
            Reference = reference;
            Designation = designation;
            Prix_Unitaire = prix_Unitaire;
            TVA = tVA;
            Photo = photo;
        }

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   Id == produit.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(Produit left, Produit right)
        {
            return EqualityComparer<Produit>.Default.Equals(left, right);
        }

        public static bool operator !=(Produit left, Produit right)
        {
            return !(left == right);
        }
    }
}
