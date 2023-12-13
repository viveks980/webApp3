using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Interface;
using WebApplication3.Models;

namespace WebApplication3.Dal
{
    public class AdmissionClass : AdmissionInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];

        public ResponseModel updateCollege(College objmodel)
        {

            ResponseModel result = new ResponseModel();
            College User = new College();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("updateCollege", con))

                    {
                        cmd.Parameters.AddWithValue("@clg_id", objmodel.clg_id);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CollegeName", objmodel.CollegeName);
                        cmd.Parameters.AddWithValue("@StudenName", objmodel.StudentName);
                        cmd.Parameters.AddWithValue("@branchName", objmodel.branchName);
                        cmd.Parameters.AddWithValue("@RoleDesignation", objmodel.RoleDesignation);
                        cmd.Parameters.AddWithValue("@fees", objmodel.fees);
                        cmd.Parameters.AddWithValue("@AdmissionDate", objmodel.AddmissionDate);
                        cmd.Parameters.AddWithValue("@IsPayment", objmodel.Is_Payment);
                        cmd.Parameters.AddWithValue("@IsActive", objmodel.Is_active);

                        var Id = cmd.ExecuteNonQuery();





                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "Admission Updated Successfully";



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
        public getCollege editCollege(int clg_id)

        {

            ResponseModel res = new ResponseModel();

            getCollege User = new getCollege();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("get_CollegeById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@clg_id", clg_id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {
                                User.clg_id = string.IsNullOrEmpty(reader["clg_id"].ToString()) ? 0 : Convert.ToInt32(reader["clg_id"]);
                                User.CollegeName = string.IsNullOrWhiteSpace(reader["CollegeName"].ToString()) ? "" : reader["CollegeName"].ToString();
                                User.fees = reader["fees"]?.ToString()?.Trim() != "" ? decimal.Parse(reader["fees"].ToString()) : 0m;
                                User.AddmissionDate = reader["AddmissionDate"] != DBNull.Value ? Convert.ToDateTime(reader["AddmissionDate"]) : DateTime.MinValue;
                                User.Is_Payment = string.IsNullOrWhiteSpace(reader["Is_Payment"].ToString()) ? false : Convert.ToBoolean(reader["Is_Payment"].ToString());
                                User.Is_active = string.IsNullOrWhiteSpace(reader["Is_active"].ToString()) ? false : Convert.ToBoolean(reader["Is_active"].ToString());

                               // form.IsActive = string.IsNullOrWhiteSpace(reader["IsActive"].ToString()) ? false : Convert.ToBoolean(reader["IsActive"].ToString());

                                User.firstName = string.IsNullOrWhiteSpace(reader["firstName"].ToString()) ? "" : reader["firstName"].ToString();
                                User.branchName = string.IsNullOrWhiteSpace(reader["branchName"].ToString()) ? "" : reader["branchName"].ToString();
                                User.Role_designation = string.IsNullOrWhiteSpace(reader["Role_designation"].ToString()) ? "" : reader["Role_designation"].ToString();
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
        public List<getCollege> getAdmissionDetails()

        {

            List<getCollege> res = new List<getCollege>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("getTableData", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                getCollege u = new getCollege();

                                u.clg_id = (int)reader["clg_id"];
                                u.CollegeName = (string)reader["CollegeName"];
                                u.fees = (decimal)reader["fees"];
                                u.AddmissionDate = (DateTime)reader["AddmissionDate"];
                                u.Is_active = (Boolean)reader["Is_active"];
                                u.Is_Payment = (Boolean)reader["Is_Payment"];
                                u.firstName = (string)reader["firstName"];
                                u.branchName = (string)reader["branchName"];
                                u.Role_designation = (string)reader["Role_designation"];
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
        public List<RoleModel> getRoleDesignation()

            {

                List<RoleModel> res = new List<RoleModel>();

                using (SqlConnection con = new SqlConnection(connection))

                {

                    con.Open();

                    try

                    {

                        using (SqlCommand cmd = new SqlCommand("select Role_id , Role_designation from Role_master", con))

                        {

                            cmd.CommandType = CommandType.Text;


                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)

                            {

                                while (reader.Read())

                                {

                                    RoleModel u = new RoleModel();

                                    u.Role_id = string.IsNullOrEmpty(reader["Role_id"].ToString()) ? 0 : Convert.ToInt32(reader["Role_id"]);

                                    u.Role_designation = string.IsNullOrWhiteSpace(reader["Role_designation"].ToString()) ? "" : reader["Role_designation"].ToString();

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
        public List<DepartmentModel> getDepBranchName()

            {

                List<DepartmentModel> res = new List<DepartmentModel>();

                using (SqlConnection con = new SqlConnection(connection))

                {

                    con.Open();

                    try

                    {

                        using (SqlCommand cmd = new SqlCommand("select branchId , branchName from Department", con))

                        {

                            cmd.CommandType = CommandType.Text;


                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)

                            {

                                while (reader.Read())

                                {

                                DepartmentModel u = new DepartmentModel();

                                    u.branchId = string.IsNullOrEmpty(reader["branchId"].ToString()) ? 0 : Convert.ToInt32(reader["branchId"]);

                                    u.branchName = string.IsNullOrWhiteSpace(reader["branchName"].ToString()) ? "" : reader["branchName"].ToString();

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
        public List<StudentModel> getStudentName()

            {

                List<StudentModel> res = new List<StudentModel>();

                using (SqlConnection con = new SqlConnection(connection))

                {

                    con.Open();

                    try

                    {

                        using (SqlCommand cmd = new SqlCommand("select studentId,firstName  from student", con))

                        {

                            cmd.CommandType = CommandType.Text;


                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)

                            {

                                while (reader.Read())

                                {

                                    StudentModel u = new StudentModel();

                                    u.studentId = string.IsNullOrEmpty(reader["studentId"].ToString()) ? 0 : Convert.ToInt32(reader["studentId"]);

                                    u.firstName = string.IsNullOrWhiteSpace(reader["firstName"].ToString()) ? "" : reader["firstName"].ToString();

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
        public ResponseModel addadmission(College objmodel)

        {
            ResponseModel result = new ResponseModel();
            College User = new College();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("save_College", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CollegeName", objmodel.CollegeName);
                        cmd.Parameters.AddWithValue("@StudenName", objmodel.StudentName);
                        cmd.Parameters.AddWithValue("@branchName", objmodel.branchName);
                        cmd.Parameters.AddWithValue("@RoleDesignation", objmodel.RoleDesignation);
                        cmd.Parameters.AddWithValue("@Fees", objmodel.fees);
                        cmd.Parameters.AddWithValue("@AdmissionDate", objmodel.AddmissionDate);
                        cmd.Parameters.AddWithValue("@IsPayment", objmodel.Is_Payment);
                        cmd.Parameters.AddWithValue("@IsActive", objmodel.Is_active);
                        var id = cmd.ExecuteNonQuery();
                        if (id > 0)
                        {
                            result.status = true;
                            result.message = "Admission Saved Successfully";
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
        public ResponseModel deleteCollege(int clg_id)

        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("deleteCollege", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@clg_id", clg_id);

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
    }
}

