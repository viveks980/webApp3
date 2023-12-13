using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Interface;
using WebApplication3.Models;

namespace WebApplication3.Dal
{
    
public class signUpClass : signUpInterface

    {

        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];

        //RoleModel editRole(int Role_id);
        public ResponseModel updateStudent(StudentModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            StudentModel User = new StudentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("update_Student", con))

                    {
                        cmd.Parameters.AddWithValue("@studentId", objmodel.studentId);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@firstName", objmodel.firstName);
                        cmd.Parameters.AddWithValue("@session", objmodel.session);
                        cmd.Parameters.AddWithValue("@email", objmodel.email);
                        cmd.Parameters.AddWithValue("@phoneNo", objmodel.phoneNo);
                        cmd.Parameters.AddWithValue("@isDeleted", objmodel.isDeleted);
                        cmd.Parameters.AddWithValue("@isActive", objmodel.isActive);

                        var Id = cmd.ExecuteNonQuery();





                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Student Updated Successfully";



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
        public ResponseModel updateRole(RoleModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            RoleModel User = new RoleModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("updateRole", con))

                    {
                        cmd.Parameters.AddWithValue("@Role_id", objmodel.Role_id);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Role_name", objmodel.Role_name);
                        cmd.Parameters.AddWithValue("@Role_designation", objmodel.Role_designation);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@Is_active", objmodel.Is_active);

                        var Id = cmd.ExecuteNonQuery();





                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Role Updated Successfully";



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
        public ResponseModel updateDepartment(DepartmentModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            DepartmentModel User = new DepartmentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("updateDepartment", con))

                    {
                        cmd.Parameters.AddWithValue("@branchId", objmodel.branchId);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@branchName", objmodel.branchName);
                        cmd.Parameters.AddWithValue("@hodName", objmodel.hodName);
                        cmd.Parameters.AddWithValue("@isActive", objmodel.isActive);
                      
                        var Id = cmd.ExecuteNonQuery();





                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Department Updated Successfully";



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
        public RoleModel editRole(int Role_id)

        {

            ResponseModel res = new ResponseModel();

            RoleModel User = new RoleModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("get_RoleById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Role_id", Role_id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.Role_id = string.IsNullOrEmpty(reader["Role_id"].ToString()) ? 0 : Convert.ToInt32(reader["Role_id"]);


                                User.Role_name = string.IsNullOrWhiteSpace(reader["Role_name"].ToString()) ? "" : reader["Role_name"].ToString();

                                User.Role_designation = string.IsNullOrWhiteSpace(reader["Role_designation"].ToString()) ? "" : reader["Role_designation"].ToString();
                               
                                User.created_date = reader["created_date"] != DBNull.Value? Convert.ToDateTime(reader["created_date"]): DateTime.MinValue;
                                User.Is_active = string.IsNullOrWhiteSpace(reader["Is_active"].ToString()) ? false : Convert.ToBoolean(reader["Is_active"].ToString());
                               




                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    res.status = false;

                    res.message = "Errorr!!!";

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }


            }

            return User;

        }

        public DepartmentModel editDepartment(int branchId)

        {

            ResponseModel res = new ResponseModel();

            DepartmentModel User = new DepartmentModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("get_DepartmentById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@branchId", branchId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.branchId = string.IsNullOrEmpty(reader["branchId"].ToString()) ? 0 : Convert.ToInt32(reader["branchId"]);


                                User.branchName = string.IsNullOrWhiteSpace(reader["branchName"].ToString()) ? "" : reader["branchName"].ToString();

                                User.hodName = string.IsNullOrWhiteSpace(reader["hodName"].ToString()) ? "" : reader["hodName"].ToString();
                               
                                User.isActive = string.IsNullOrWhiteSpace(reader["isActive"].ToString()) ? false : Convert.ToBoolean(reader["isActive"].ToString());
                              




                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    res.status = false;

                    res.message = "Errorr!!!";

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }


            }

            return User;

        }
        public StudentModel editStudent(int studentId)

        {

            ResponseModel res = new ResponseModel();

            StudentModel User = new StudentModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("get_StudentById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.studentId = string.IsNullOrEmpty(reader["studentId"].ToString()) ? 0 : Convert.ToInt32(reader["studentId"]);
                                User.firstName = string.IsNullOrWhiteSpace(reader["firstName"].ToString()) ? "" : reader["firstName"].ToString();
                                User.session = string.IsNullOrWhiteSpace(reader["session"].ToString()) ? "" : reader["session"].ToString();
                                User.email = string.IsNullOrWhiteSpace(reader["email"].ToString()) ? "" : reader["email"].ToString();
                                User.phoneNo = string.IsNullOrEmpty(reader["phoneNo"].ToString()) ? 0 : Convert.ToInt32(reader["phoneNo"]);
                                User.isDeleted = string.IsNullOrWhiteSpace(reader["isDeleted"].ToString()) ? false : Convert.ToBoolean(reader["isDeleted"].ToString());
                                User.isActive = string.IsNullOrWhiteSpace(reader["isActive"].ToString()) ? false : Convert.ToBoolean(reader["isActive"].ToString());
                                // User.Is_Payment = string.IsNullOrWhiteSpace(reader["Is_Payment"].ToString()) ? false : Convert.ToBoolean(reader["Is_Payment"].ToString());


                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    res.status = false;

                    res.message = "Errorr!!!";

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }


            }

            return User;

        }
        public ResponseModel deleteDepartment(int branchId)

        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("deleteDepartment", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@branchId", branchId);

                        var Id = cmd.ExecuteNonQuery();

                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Data Deleted Successfully..!!";
                            result.id = Id;


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
                    result.message = "Exception Occure..!!";

                }
                finally
                {
                    con.Close();
                    con.Dispose();

                }
            }
            return result;

        }

        public ResponseModel deleteRole(int Role_id)

        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("deleteRole", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Role_id", Role_id);

                        var Id = cmd.ExecuteNonQuery();

                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Data Deleted Successfully..!!";
                            result.id = Id;


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
                    result.message = "Exception Occure..!!";

                }
                finally
                {
                    con.Close();
                    con.Dispose();

                }
            }
            return result;

        }
        public ResponseModel deleteStudent(int studentId)

        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("delete_Student", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        var Id = cmd.ExecuteNonQuery();

                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Data Deleted Successfully..!!";
                            result.id = Id;


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
                    result.message = "Exception Occure..!!";

                }
                finally
                {
                    con.Close();
                    con.Dispose();

                }
            }
            return result;

        }
        public List<StudentModel> getStudentDetails()
       

        {

            List<StudentModel> res = new List<StudentModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetStudentList", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                StudentModel u = new StudentModel();
                                u.studentId = (int)reader["studentId"];
                                u.firstName = (string)reader["firstName"];
                                u.session = (string)reader["session"];
                                u.email = (string)reader["email"];
                                u.phoneNo= (int)reader["phoneNo"];
                                u.isDeleted= (Boolean)reader["isDeleted"];
                                u.isActive = (Boolean)reader["isActive"];
                                res.Add(u);


                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }


        }

        public List<RoleModel> getRoleDetails()

        {

            List<RoleModel> res = new List<RoleModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetRoleList", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                RoleModel u = new RoleModel();

                                u.Role_id = (int)reader["Role_id"];

                                u.Role_name = (string)reader["Role_name"];

                                u.Role_designation = (string)reader["Role_designation"];
                                u.created_date = (DateTime)reader["created_date"];



                                u.Is_active = (Boolean)reader["Is_active"];


                                res.Add(u);


                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }


        }


        public List<DepartmentModel> getDepDetails()

        {

            List<DepartmentModel> res = new List<DepartmentModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetDepartmentList", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                DepartmentModel u = new DepartmentModel();

                                u.branchId = (int)reader["branchId"];

                                u.branchName = (string)reader["branchName"];

                                u.hodName = (string)reader["hodName"];

                                

                                u.isActive = (Boolean)reader["isActive"];


                                res.Add(u);


                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }


        }

        public ResponseModel adduser(RegisterModel objmodel)

        {

            ResponseModel result = new ResponseModel();

            RegisterModel User = new RegisterModel();
            MailMessage msg = new MailMessage();

            SmtpClient smtp = new SmtpClient();

            using (SqlConnection con = new SqlConnection(connection))

            {

                try

                {

                    con.Open();




                    using (SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_signup WHERE userid = @userid", con))

                    {

                        checkUsernameCmd.Parameters.AddWithValue("@userid", objmodel.userId);

                        int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (existingUserCount > 0)

                        {

                            result.status = false;

                            result.message = "Userid already exists. Please choose a different userid.";

                        }

                        else

                        {


                            using (SqlCommand cmd = new SqlCommand("signUp", con))

                            {

                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@name", objmodel.name);

                                cmd.Parameters.AddWithValue("@userId", objmodel.userId);

                                string encryptedPassword = EncryptPassword(objmodel.decryptedPassword);

                                cmd.Parameters.AddWithValue("@encryptedPassword", encryptedPassword);


                                cmd.Parameters.AddWithValue("@decryptedPassword", objmodel.decryptedPassword);



                                var id = cmd.ExecuteNonQuery();



                                if (id > 0)

                                {

                                    result.status = true;


                                    msg.From = new MailAddress("vivek.swami@cylsys.com");

                                    
                                    msg.To.Add(objmodel.userId);

                                    msg.Subject = "Testing Mail For Registration";

                                    msg.Body = "Dear "+ objmodel.name + " Your Registration is successful..!!";

                                    msg.IsBodyHtml = true;

                                    smtp.Host = "smtp-mail.outlook.com";

                                    smtp.Port = 587;

                                    smtp.EnableSsl = true;

                                    smtp.UseDefaultCredentials = false;

                                    smtp.Credentials = new NetworkCredential("vivek.swami@cylsys.com", "Cylsys@2");

                                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                                    smtp.Send(msg);

                                    result.message = "Data Saved Successfully";


                                }

                                else

                                {

                                    result.status = false;

                                    result.message = "Please Check...Something Went wrong...!!!";

                                }

                            }

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


        private string EncryptPassword(string password)

        {

            string encryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            byte[] clearBytes = Encoding.Unicode.GetBytes(password);

            using (Aes encryptor = Aes.Create())

            {

                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] {

            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76

        });

                encryptor.Key = pdb.GetBytes(32);

                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())

                {

                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))

                    {

                        cs.Write(clearBytes, 0, clearBytes.Length);

                        cs.Close();

                    }

                    return Convert.ToBase64String(ms.ToArray());

                }

            }

        }

       
        public ResponseModel loginUser(RegisterModel objmodel)

        {

            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                try

                {

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ValidateLogin", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@userId", objmodel.userId);

                        cmd.Parameters.AddWithValue("@decryptedPassword", objmodel.decryptedPassword);

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            result.status = true;

                            result.message = "Login successful.";

                        }

                        else

                        {

                            result.status = false;

                            result.message = "Invalid email or password.";

                        }

                    }

                }

                catch (Exception ex)

                {

                    result.status = false;

                    result.message = "An error occurred. Please try again later.";

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
        public ResponseModel adddepartment(DepartmentModel objmodel)

        {
            ResponseModel result = new ResponseModel();
            DepartmentModel User = new DepartmentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                   
                        using (SqlCommand cmd = new SqlCommand("saveDepartment", con))

                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@branchName", objmodel.branchName);
                            cmd.Parameters.AddWithValue("@hodName", objmodel.hodName);
                            cmd.Parameters.AddWithValue("@isActive",objmodel.isActive);
                            var id = cmd.ExecuteNonQuery();
                            if (id > 0)
                            {
                                result.status = true;
                                result.message = "Department Saved Successfully";
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
        public ResponseModel addstudent(StudentModel objmodel)

        {
            ResponseModel result = new ResponseModel();
            StudentModel User = new StudentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("saveStudent", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@firstName", objmodel.firstName);
                        cmd.Parameters.AddWithValue("@session", objmodel.session);
                        cmd.Parameters.AddWithValue("@email", objmodel.email);
                        cmd.Parameters.AddWithValue("@phoneNo", objmodel.phoneNo);
                        cmd.Parameters.AddWithValue("@isDeleted", objmodel.isActive);
                        cmd.Parameters.AddWithValue("@isActive", objmodel.isActive);
                        var id = cmd.ExecuteNonQuery();
                        if (id > 0)
                        {
                            result.status = true;
                            result.message = "Student Saved Successfully";
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
