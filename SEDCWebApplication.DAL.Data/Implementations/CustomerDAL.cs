using SEDCWebApplication.DAL.Data.Entities;
using SEDCWebApplication.DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SEDCWebApplication.DAL.Data.Implementations
{
    public class CustomerDAL : BaseDAL, ICustomerDAL
    {

        protected override string COLUMN_PREFIX
        {
            get { return ColumnPrefixConstants.CUST; }
        }


        public void Save(Customer item)
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

        public Customer GetById(int id)
        {
            SqlConnection cn = ConnectionGet();

            Customer result = null;

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Customer_GetById";

            this.ParamValueTypeNonNullableValueSet(cmd, id, "@CustomerId", SqlDbType.Int);

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


        private void Add(Customer item)
        {
            SqlConnection cn = ConnectionGet();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Customer_Ins";

            CommonParametersAdd(item, cmd);

            SqlParameter prm = new SqlParameter();
            prm.ParameterName = "@ID";
            prm.SqlDbType = SqlDbType.Int;
            prm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prm);

            //contact ID treba preko baze da se izracuna za svaki customer
            /*prm.ParameterName = "@CONTACTID";
            prm.SqlDbType = SqlDbType.Int;
            prm.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prm);*/

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

        private void Update(Customer item) //promenio sam iz private u public!
        {
            SqlConnection cn = ConnectionGet();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Customer_Upd";

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

        public List<Customer> SearchCustomers(string searchParam)
        {
            SqlConnection cn = ConnectionGet();

            Customer result = null;
            List<Customer> results = new List<Customer>();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Customer_Search";

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

        public List<Customer> GetAll(int skip, int take)
        {
            SqlConnection cn = ConnectionGet();

            Customer result = null;
            List<Customer> results = new List<Customer>();

            SqlCommand cmd = CommandGet(cn);
            cmd.CommandText = "Customer_GetAll";

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


        private void CommonParametersAdd(Customer item, SqlCommand cmd)
        {
            this.ParamStringNullableValueSet(cmd, item.UserName, "@UserName", SqlDbType.NVarChar, 50);
            this.ParamStringNullableValueSet(cmd, item.Password, "@Password", SqlDbType.NVarChar, 50);
            this.ParamStringNonNullableValueSet(cmd, item.Name, "@CustomerName", SqlDbType.NVarChar, 50);

            this.ParamStringNullableValueSet(cmd, item.ImagePath, "@ImagePath", SqlDbType.NVarChar, 255);
            this.ParamStringNullableValueSet(cmd, item.Address, "@Address", SqlDbType.NVarChar, 50);
        }

        private Customer Create(IDataReader reader)
        {
            Customer item = new Customer(ReaderColumnReadNullableValueType<Int32>(reader, "ID", COLUMN_PREFIX));

            item.Name = ReaderColumnReadObject<string>(reader, "CustomerName", COLUMN_PREFIX);
            
            item.ImagePath = ReaderColumnReadObject<string>(reader, "ImagePath", COLUMN_PREFIX);
            item.UserName = ReaderColumnReadObject<string>(reader, "UserName", COLUMN_PREFIX);
            //item.Password = ReaderColumnReadObject<string>(reader, "Password", COLUMN_PREFIX);

            return item;
        }
    }
}
