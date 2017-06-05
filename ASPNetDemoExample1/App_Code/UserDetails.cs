using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


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


        public int UpdateUser()
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

            int Counter = 0;
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

        public int CheckCred()
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
                cmd.CommandText = "[USP_Check_Credentials]";

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