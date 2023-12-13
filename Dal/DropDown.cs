using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Task_1.interfaces;
using Task_1.Models;

namespace Task_1.Dal
{
    public class DropDown : DropDownInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];

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

        public List<DeparmentModel> getDepBranchName()

        {

            List<DeparmentModel> res = new List<DeparmentModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("select Branch_id , Branch_name from department_master", con))

                    {
                        cmd.CommandType = CommandType.Text;



                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                DeparmentModel u = new DeparmentModel();
                                u.Branch_id = string.IsNullOrEmpty(reader["Branch_id"].ToString()) ? 0 : Convert.ToInt32(reader["Branch_id"]);

                                u.Branch_name = string.IsNullOrWhiteSpace(reader["Branch_name"].ToString()) ? "" : reader["Branch_name"].ToString();

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

                    using (SqlCommand cmd = new SqlCommand("select Student_id,Student_fisrt_Name   from student_master", con))

                    {
                        cmd.CommandType = CommandType.Text;



                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                StudentModel u = new StudentModel();
                                u.Student_id = string.IsNullOrEmpty(reader["Student_id"].ToString()) ? 0 : Convert.ToInt32(reader["Student_id"]);

                                u.Student_fisrt_Name = string.IsNullOrWhiteSpace(reader["Student_fisrt_Name"].ToString()) ? "" : reader["Student_fisrt_Name"].ToString();

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


        public ResponseModel addadmission(CollegeModel objmodel)

        {

            ResponseModel result = new ResponseModel();

            CollegeModel User = new CollegeModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                try

                {

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_insert_college_Details", con))

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



        public List<getCollegeModel> getCollege()

        {
            //if(fromDate==DateTime('01/01/1999') && toDate= "01/01/1999")
            //{
            //    fromDate
            //}
            List<getCollegeModel> res = new List<getCollegeModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetCollegeMasterDetails", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                      //  cmd.Parameters.Add(new SqlParameter("@fromDate", SqlDbType.DateTime)).Value = fromDate;
                      //  cmd.Parameters.Add(new SqlParameter("@toDate", SqlDbType.DateTime)).Value = toDate;


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                getCollegeModel u = new getCollegeModel();
                                u.clg_id = (int)reader["clg_id"];

                                u.collegeName = (string)reader["collegeName"];
                                u.Student_fisrt_Name = (string)reader["Student_fisrt_Name"];
                                u.Branch_name= (string)reader["Branch_name"];
                                u.Role_designation = (string)reader["Role_designation"];
                                u.fees = (decimal)reader["fees"];

                                u.AddmissionDate = string.IsNullOrWhiteSpace(reader["AddmissionDate"].ToString()) ? Convert.ToDateTime(DateTime.Now.ToString("1900-01-01")) : Convert.ToDateTime(reader["AddmissionDate"]);;
                                u.Is_active = (Boolean)reader["Is_active"];
                                u.Is_Payment = (Boolean)reader["Is_Payment"];



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



        public ResponseModel deleteClgListItem(int id)
        {
            ResponseModel result = new ResponseModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_delete_college_Details", con))
                    {
                        // cmd.CommandType = CommandType.Text;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        var s = cmd.ExecuteNonQuery();


                        if (s > 0)
                        {
                            result.status = true;
                            result.message = "Data delete suscessfully";
                            result.Id = id;
                        }
                        else
                        {
                            result.status = false;
                            result.message = "Please check something went wrong";
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.status = false;
                    result.message = "Exception occours";
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }

            }
            return result;
        }


        public getCollegeModel editCollegeMater(int Id)

        {

            ResponseModel res = new ResponseModel();

            getCollegeModel User = new getCollegeModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("sp_GetCollegeDetailsById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@clg_id", Id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.clg_id = string.IsNullOrEmpty(reader["clg_id"].ToString()) ? 0 : Convert.ToInt32(reader["clg_id"]);
                                User.collegeName = string.IsNullOrWhiteSpace(reader["CollegeName"].ToString()) ? "" : reader["CollegeName"].ToString();
                                User.Student_fisrt_Name= string.IsNullOrWhiteSpace(reader["Student_fisrt_Name"].ToString()) ? "" : reader["Student_fisrt_Name"].ToString();
                                User.Branch_name = string.IsNullOrWhiteSpace(reader["Branch_name"].ToString()) ? "" : reader["Branch_name"].ToString();
                                User.Role_designation = string.IsNullOrWhiteSpace(reader["Role_designation"].ToString()) ? "" : reader["Role_designation"].ToString();
                                User.AddmissionDate = string.IsNullOrWhiteSpace(reader["AddmissionDate"].ToString()) ? Convert.ToDateTime(DateTime.Now.ToString("1900-01-01")) : Convert.ToDateTime(reader["AddmissionDate"]); ;
                                User.fees = reader["fees"]?.ToString()?.Trim() != "" ? decimal.Parse(reader["fees"].ToString()) : 0m;
                                User.Is_Payment = string.IsNullOrWhiteSpace(reader["Is_Payment"].ToString()) ? false : Convert.ToBoolean(reader["Is_Payment"].ToString());
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


        public ResponseModel updateCollege(CollegeModel M) 

        {

            ResponseModel result = new ResponseModel();
            CollegeModel User = new CollegeModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCollegeDetails_by_Id", con))
                         
                    {
                        cmd.Parameters.AddWithValue("@clg_id", M.clg_id);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@collegeName", M.CollegeName);
                        cmd.Parameters.AddWithValue("@StudenName", M.StudentName);
                        cmd.Parameters.AddWithValue("@branchName", M.branchName);
                        cmd.Parameters.AddWithValue("@RoleDesignation", M.RoleDesignation);
                        cmd.Parameters.AddWithValue("@fees", M.fees);
                        cmd.Parameters.AddWithValue("@AddmissionDate", M.AddmissionDate);
                        cmd.Parameters.AddWithValue("@Is_Payment", M.Is_active);
                        cmd.Parameters.AddWithValue("@Is_active", M.Is_Payment);

                        var Id = cmd.ExecuteNonQuery();



                        if (Id > 0)
                        {
                            result.status = true;
                            result.message = "college Updated Successfully";


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


        public List<getCollegeModel> getCollegeList(DateTime? fromDate, DateTime? toDate)
        {
            List<getCollegeModel> res = new List<getCollegeModel>();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("GeSearchDateCollegeDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for from date and to date
                        cmd.Parameters.Add(new SqlParameter("@fromDate", SqlDbType.DateTime)).Value = fromDate;
                        cmd.Parameters.Add(new SqlParameter("@toDate", SqlDbType.DateTime)).Value = toDate;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                getCollegeModel u = new getCollegeModel();
                                u.clg_id = (int)reader["clg_id"];
                                u.collegeName = (string)reader["collegeName"];
                                u.Student_fisrt_Name = (string)reader["Student_fisrt_Name"];
                                u.Branch_name = (string)reader["Branch_name"];
                                u.Role_designation = (string)reader["Role_designation"];
                                u.fees = (decimal)reader["fees"];
                                u.AddmissionDate = string.IsNullOrWhiteSpace(reader["AddmissionDate"].ToString()) ? Convert.ToDateTime(DateTime.Now.ToString("1900-01-01")) : Convert.ToDateTime(reader["AddmissionDate"]);
                                u.Is_active = (Boolean)reader["Is_active"];
                                u.Is_Payment = (Boolean)reader["Is_Payment"];

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


    }
}
