using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPNetDemoExample1.App_Code
{
    public class UserDetails
    {
        private string m_UserName, m_Password, m_Country, m_Email;

        public string UserName
        {
            get
            {
                return m_UserName;
            }

            set
            {
                m_UserName = value;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }

            set
            {
                m_Password = value;
            }
        }

        public string Country
        {
            get
            {
                return m_Country;
            }

            set
            {
                m_Country = value;
            }
        }

        public string Email
        {
            get
            {
                return m_Email;
            }

            set
            {
                m_Email = value;
            }
        }

        public UserDetails()
        {
            // Constructor logic here
        }

        private string GetConnectionString()
        {
            // This approach is error prone
            string str = "dataSource=.;initial catalog=asptraining;integrated security=true";
            return str;
        }

        private string GetCS()
        {
            // save because, DataSource, InitialCatalog and IntegratedSecurity are popping up as properties.
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";
            scsb.InitialCatalog = "asptraining";
            scsb.IntegratedSecurity = true;
            return scsb.ToString();
        }

        private string GetCSFromWebConfig()
        {
            string str = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
            return str;
        }

        public DataSet GetListOfAllCountries()
        {
            DataSet dset = null;
            SqlDataAdapter sda = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = this.GetCSFromWebConfig();

                cmd = new SqlCommand();
                cmd.Connection = (con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GetListOfCountries";

                // The new table which is getting returened is aliased as Users
                dset = new DataSet("Users");

                // Adapter is a bridge between Program and DB
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dset, "Users");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;

                    cmd.Dispose();
                    cmd = null;

                    dset.Dispose();
                    dset = null;

                    sda.Dispose();
                    sda = null;
                }
            }
            return dset;
        }


        public DataSet GetCountryWiseUsers()
        {
            DataSet dset = null;
            SqlDataAdapter sda = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = this.GetCSFromWebConfig();

                cmd = new SqlCommand();
                cmd.Connection = (con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GetCountryWiseUsers";

                // The new table which is getting returened is aliased as Users
                dset = new DataSet("Users");

                // Adapter is a bridge between Program and DB
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dset, "Users");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;

                    cmd.Dispose();
                    cmd = null;

                    dset.Dispose();
                    dset = null;

                    sda.Dispose();
                    sda = null;
                }
            }
            return dset;
        }
        // connection oriented architecture - live connection required.
        // Read only
        // forward only
        public SqlDataReader GetListOfAllUsersDataReader()
        {

            SqlDataReader sdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = this.GetCSFromWebConfig();

                cmd = new SqlCommand();
                cmd.Connection = (con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GetListOfAllUsers";

                con.Open();
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // Connection is closed when sdr is closed, sdr is closed when it is returned to the function call. If we don't mention this, then it is a great problem

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                /* Don't close the connection because, if you close we don't have connection oriented architecture.
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;

                    cmd.Dispose();
                    cmd = null;

                    sdr.Close();
                    sdr = null;
                }*/ 
            }
            return sdr;
        }
        public DataSet GetListOfAllUsers()
        {
            DataSet dset = null;
            SqlDataAdapter sda = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = this.GetCSFromWebConfig();

                cmd = new SqlCommand();
                cmd.Connection = (con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_GetListOfAllUsers";

                // The new table which is getting returened is aliased as Users
                dset = new DataSet("Users");

                // Adapter is a bridge between Program and DB
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dset,"Users");

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;

                    cmd.Dispose();
                    cmd = null;

                    dset.Dispose();
                    dset = null;

                    sda.Dispose();
                    sda = null;
                }
            }
            return dset;
        }

        public int UpdateUser()
        {
            // calling the stored procedure
            SqlConnection con = null;
            SqlCommand cmd = null;

            int Counter = 0;
            try
            {
                con = new SqlConnection();
                // con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                // con.ConnectionString = this.GetConnectionString();
                // con.ConnectionString = this.GetCS();
                con.ConnectionString = this.GetCSFromWebConfig();
                cmd.Connection = con;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_ChangeProfile]";

                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this.Password);
                cmd.Parameters.AddWithValue("@Country", this.Country);
                cmd.Parameters.AddWithValue("@Email", this.Email);

                con.Open();
                Counter = cmd.ExecuteNonQuery(); // Counter is number of rows affected.

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }
            return (Counter);
        }

        public DataSet GetUserInfo()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            DataSet dSet = null;

           
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                cmd.Connection = con;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_GetUserDetails]";
                cmd.Parameters.AddWithValue("@UserName", UserName);

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet("Users");
                sda.Fill(dSet, "User");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }

            return dSet;
        }


        public int UnSub()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            int Counter = 0;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                cmd.Connection = con;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_Unsubscribe]";

                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this.Password);

                con.Open();
                Counter = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }

            return Counter;
        }

        public int ChangePass()
        {

            SqlConnection con = null;
            SqlCommand cmd = null;

            int Counter = 0;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                cmd.Connection = con;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_ChangePassword]";

                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this.Password);

                con.Open();
                Counter = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }

            return Counter;
        }

        public DataSet CheckCred()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            DataSet dset = null;
            SqlDataAdapter sda = null;


             // int Counter = 0;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                cmd.Connection = con;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_Check_Credentials]";

                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this.Password);

                /* con.Open();
                Counter = Convert.ToInt32(cmd.ExecuteScalar().ToString()); */

                sda = new SqlDataAdapter(cmd);
                dset = new DataSet();
                sda.Fill(dset);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }

            return dset;

        }


        public int CreateUser()
        {
            // calling the stored procedure
            SqlConnection con = null;
            SqlCommand cmd = null;

            int Counter = 0;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true"; // if sql server auth userid = .. password = ...
                cmd.Connection = con;

                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[USP_UserDetails_Insert]";

                cmd.Parameters.AddWithValue("@UserName", this.UserName);
                cmd.Parameters.AddWithValue("@Password", this.Password);
                cmd.Parameters.AddWithValue("@Country", this.Country);
                cmd.Parameters.AddWithValue("@Email", this.Email);

                con.Open();
                Counter = cmd.ExecuteNonQuery(); // Counter is number of rows affected.
               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }
            return (Counter);
        }
    }
}