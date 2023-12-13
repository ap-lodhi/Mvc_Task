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
    public class StudentClass: StudentInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];
        public ResponseModel addStudent(StudentModel M)
        {

            ResponseModel result = new ResponseModel();
            StudentModel User = new StudentModel    ();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {

                    con.Open();



                    using (SqlCommand cmd = new SqlCommand("SP_InsertStudent", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Student_fisrt_Name", M.Student_fisrt_Name);
                        cmd.Parameters.AddWithValue("@Student_Last_Name", M.Student_Last_Name);
                        cmd.Parameters.AddWithValue("@Student_Email", M.Student_Email);
                        cmd.Parameters.AddWithValue("@Student_Phone", M.Student_Phone);
                        cmd.Parameters.AddWithValue("@Student_Session", M.Student_Session);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@Is_active", M.Is_active);
                        cmd.Parameters.AddWithValue("@Is_Deleted", M.Is_Deleted);

                        var id = cmd.ExecuteNonQuery();





                        if (id > 0)
                        {
                            result.status = true;


                            result.message = "Data Saved Successfully";



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

        public List<StudentModel> getStuDetails()

        {

            List<StudentModel> res = new List<StudentModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("sp_getAllStudentDetails", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;



                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                StudentModel u = new StudentModel();
                                u.Student_id = (int)reader["Student_id"];

                                u.Student_fisrt_Name = (string)reader["Student_fisrt_Name"];
                                u.Student_Last_Name = (string)reader["Student_Last_Name"];
                                u.Student_Email = (string)reader["Student_Email"];
                                u.Student_Phone = (string)reader["Student_Phone"];
                                u.Student_Session = (string)reader["Student_Session"];
                                u.created_date = (DateTime)reader["created_date"];

                                u.Is_active = (Boolean)reader["Is_active"];
                                u.Is_Deleted = (Boolean)reader["Is_Deleted"];



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

        public ResponseModel deleteStuListItem(int id)
        {
            ResponseModel result = new ResponseModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_deleteStudentMasterItem", con))
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
        public StudentModel editStudentMater(int Id)

        {

            ResponseModel res = new ResponseModel();

            StudentModel User = new StudentModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("sp_GetStudentListById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.Student_id = string.IsNullOrEmpty(reader["Student_id"].ToString()) ? 0 : Convert.ToInt32(reader["Student_id"]);
                                User.Student_fisrt_Name = string.IsNullOrWhiteSpace(reader["Student_fisrt_Name"].ToString()) ? "" : reader["Student_fisrt_Name"].ToString();
                                User.Student_Last_Name= string.IsNullOrWhiteSpace(reader["Student_Last_Name"].ToString()) ? "" : reader["Student_Last_Name"].ToString();
                                User.Student_Email = string.IsNullOrWhiteSpace(reader["Student_Email"].ToString()) ? "" : reader["Student_Email"].ToString();
                                User.Student_Session = string.IsNullOrWhiteSpace(reader["Student_Session"].ToString()) ? "" : reader["Student_Session"].ToString();
                                User.Student_Phone = string.IsNullOrWhiteSpace(reader["Student_Phone"].ToString()) ? "" : reader["Student_Phone"].ToString();
                                User.Is_active = !string.IsNullOrWhiteSpace(reader["Is_active"].ToString()) && reader["Is_active"].ToString().ToLower() == "active";
                                User.Is_Deleted = !string.IsNullOrWhiteSpace(reader["Is_Deleted"].ToString()) && reader["Is_Deleted"].ToString().ToLower() == "active";


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


        public ResponseModel updateStudent(StudentModel M)
        {

            ResponseModel result = new ResponseModel();
            StudentModel User = new StudentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Sp_update_Student_List", con))

                    {
                        cmd.Parameters.AddWithValue("@Student_id", M.Student_id);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Student_fisrt_Name", M.Student_fisrt_Name);
                        cmd.Parameters.AddWithValue("@Student_Last_Name", M.Student_Last_Name);
                        cmd.Parameters.AddWithValue("@Student_Email", M.Student_Email);
                        cmd.Parameters.AddWithValue("@Student_Phone", M.Student_Phone);
                        cmd.Parameters.AddWithValue("@Student_Session", M.Student_Session);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@Is_active", M.Is_active);
                        cmd.Parameters.AddWithValue("@Is_Deleted", M.Is_Deleted);

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
    }
}
