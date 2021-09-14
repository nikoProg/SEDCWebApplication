using SEDCWebApplication.DAL.Data.Entities;
using SEDCWebApplication.DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SEDCWebApplication.DAL.Data.Implementations
{
    public class ProductDAL : BaseDAL, IProductDAL
    {

        protected override string COLUMN_PREFIX
        {
            get { return ColumnPrefixConstants.PROD; }
        }


        public void Save(Product item)
        {
            switch (item.EntityState)
            {
                case EntityStateEnum.New:
                    this.Add(item);
                    break;
                case EntityStateEnum.Updated:
                    this.Update(item);
                    break;
                case EntityStateEnum.Loaded:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(String.Format("EntityState is invalid: Value: {0}", item.EntityState));
            }
            item.EntityState = EntityStateEnum.Loaded;
        }

        public Product GetById(int id)
        {
            SqlConnection cn = ConnectionGet();

            Product result = null;

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Product_GetById";

            this.ParamValueTypeNonNullableValueSet(cmd, id, "@ProductId", SqlDbType.Int);

            try
            {
                cn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = Create(reader);
                }
            }
            catch (Exception ex)
            {
                //DMLogger.Singleton.LogError(LogCategories.SECURITY, ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;
        }


        private void Add(Product item)
        {
            SqlConnection cn = ConnectionGet();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Product_Ins";

            CommonParametersAdd(item, cmd);

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = "@ID";
            prm.SqlDbType = SqlDbType.Int;
            prm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prm);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                item.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);

            }
            catch (Exception ex)
            {
                //DMLogger.Singleton.LogError(ex, item);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void Update(Product item) //promenio sam iz private u public!
        {
            SqlConnection cn = ConnectionGet();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Product_Upd";

            CommonParametersAdd(item, cmd);

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = "@ID";
            prm.SqlDbType = SqlDbType.Int;
            prm.Value = item.Id.Value;
            cmd.Parameters.Add(prm);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //DMLogger.Singleton.LogError(ex, item);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Product> SearchProducts(string searchParam)
        {
            SqlConnection cn = ConnectionGet();

            Product result = null;
            List<Product> results = new List<Product>();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Product_Search";

            this.ParamStringNullableValueSet(cmd, searchParam, "@SearchParam", SqlDbType.NVarChar, 50);

            try
            {
                cn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = Create(reader);
                    results.Add(result);
                }
            }
            catch (Exception ex)
            {
                //DMLogger.Singleton.LogError(LogCategories.SECURITY, ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return results;
        }

        public List<Product> GetAll(int skip, int take)
        {
            SqlConnection cn = ConnectionGet();

            Product result = null;
            List<Product> results = new List<Product>();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Product_GetAll_Skip_Take";//drugacije se zove u bazi, mada su sve getAll sa skip i take.

            this.ParamValueTypeNonNullableValueSet(cmd, skip, "@RowsToSkip", SqlDbType.Int);
            this.ParamValueTypeNonNullableValueSet(cmd, take, "@RowsToTake", SqlDbType.Int);

            try
            {
                cn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = Create(reader);
                    results.Add(result);
                }
            }
            catch (Exception ex)
            {
                //DMLogger.Singleton.LogError(LogCategories.SECURITY, ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return results;
        }


        private void CommonParametersAdd(Product item, SqlCommand cmd)
        {
            this.ParamStringNonNullableValueSet(cmd, item.Name, "@ProductName", SqlDbType.NVarChar, 50);
            this.ParamNullableValueTypeNullableValueSet<float>(cmd, item.UnitPrice, "@UnitPrice", SqlDbType.Decimal);//kako da napisem broj decimala?!mozda
            //mozda treba da se promeni tip iz float u decimal sa C# strane
            this.ParamNullableValueTypeNullableValueSet<bool>(cmd, item.IsDiscounted, "@IsDiscounted", SqlDbType.Bit);
            this.ParamNullableValueTypeNullableValueSet<bool>(cmd, item.IsActive, "@IsActive", SqlDbType.Bit);
            this.ParamNullableValueTypeNullableValueSet<bool>(cmd, item.IsDeleted, "@IsDeleted", SqlDbType.Bit);
            this.ParamStringNullableValueSet(cmd, item.Size, "@Size", SqlDbType.NVarChar, 50);

            this.ParamStringNullableValueSet(cmd, item.ImagePath, "@ImagePath", SqlDbType.NVarChar, 255);
        }

        private Product Create(IDataReader reader)
        {
            Product item = new Product(ReaderColumnReadNullableValueType<Int32>(reader, "ID", COLUMN_PREFIX));

            item.Name = ReaderColumnReadObject<string>(reader, "ProductName", COLUMN_PREFIX);
            item.UnitPrice = ReaderColumnReadNullableValueType<float>(reader, "UnitPrice", COLUMN_PREFIX);
            //decimal i float, isto kao u gornjoj metodi
            item.IsDiscounted = ReaderColumnReadNullableValueType<bool>(reader, "IsDiscounted", COLUMN_PREFIX);
            item.IsActive = ReaderColumnReadNullableValueType<bool>(reader, "IsActive", COLUMN_PREFIX);
            item.IsDeleted = ReaderColumnReadNullableValueType<Boolean>(reader, "IsDeleted", COLUMN_PREFIX);
            item.Size = ReaderColumnReadObject<string>(reader, "Size", COLUMN_PREFIX);

            return item;
        }

        public bool Delete(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
