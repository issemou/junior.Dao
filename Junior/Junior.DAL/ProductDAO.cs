using Junior.BO;
using Junior.Common;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.DAL
{
   public class ProductDAO 
    {
        private readonly Sql sql;

        public ProductDAO(string connectionStringName)
        {
            sql = new Sql(connectionStringName);
        }

        public void Add(Product product)
        {
            sql.Execute
            (
                "Sp_Product_Insert",
                GetParamater(product),
                true
            );
        }

        public void Set(Product product)
        {
            sql.Execute
            (
                "Sp_Product_Update",
                GetParamater(product),
                true
            );
        }


        public void Delete(int id)
        {
            sql.Execute
            (
                "Sp_Product_Delete",
                GetParamater(new Product { Id = id }),
                true
            );
        }

        public Product Get(int id)
        {
            return sql.Read<Product>
            (
                "Sp_Product_Select",
                GetParamater(new Product { Id = id }),
                GetProduct,
                true
            )?.FirstOrDefault();
        }

        public IEnumerable<Product> GetAll()
        {
            return sql.Read<Product>("Sp_Product_Select", null, GetProduct, true);
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return sql.Read<Product>("Sp_Product_Search", GetParamater(new Product { Reference = name }), GetProduct, true);
        }

        private Product GetProduct(DbDataReader reader)
        {
            return new Product
            (
                int.Parse(reader["id"].ToString()),
                reader["reference"].ToString(),
                reader["designation"].ToString(),
                long.Parse(reader["pu"].ToString()),
                DateTime.Parse(reader["dp"].ToString()),
                DateTime.Parse(reader["de"].ToString()),
                reader["photo"] != DBNull.Value ? (byte[])reader["photo"] : null
            );
        }

        private Sql.Parameter[] GetParamater(Product product)
        {
            return new Sql.Parameter[]
            {
                new Sql.Parameter("@id", System.Data.DbType.Int32, product.Id == 0 ? DBNull.Value : (object)product.Id),
                new Sql.Parameter("@reference", System.Data.DbType.String, (object)product.Reference ?? DBNull.Value),
                new Sql.Parameter("@designation", System.Data.DbType.String, (object)product.Designation ?? DBNull.Value),
                new Sql.Parameter("@pu", System.Data.DbType.Int64, product.Prix_unitaire == 0 ? DBNull.Value : (object)product.Prix_unitaire),
                new Sql.Parameter("@dp", System.Data.DbType.Date, product.DateP == DateTime.MinValue ? DBNull.Value : (object)product.DateP),
                new Sql.Parameter("@de", System.Data.DbType.Date, product.DateEx == DateTime.MinValue ? DBNull.Value : (object)product.DateEx),
                new Sql.Parameter("@photo", System.Data.DbType.Binary, (object)product.Photo ?? DBNull.Value)
            };
        }
    }

}
    

