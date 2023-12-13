using System;
using System.Data;
using System.Data.SqlClient;
using WebApplication3.Interface;
using WebApplication3.Models;

namespace WebApplication3.Dal
{
    public class UserClass : UserInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];
        public ResponseModel adduser(RoleModel objmodel)
        {
            ResponseModel result = new ResponseModel();
            RoleModel User = new RoleModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertRole", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Role_name", objmodel.Role_name);
                        cmd.Parameters.AddWithValue("@Role_designation", objmodel.Role_designation);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@Is_active", objmodel.Is_active);
                        var Id = cmd.ExecuteNonQuery();
                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Role Saved Successfully";
                        }
                        else
                        {
                            result.status = false;
                            result.message = "Please Check...Something Went wrong...!!!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.status = false;
                    Helper.WriteLog("The error is:" + ex);
                    Console.WriteLine("Error is:" + ex);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            return result;



        }

        

       
    }
}
