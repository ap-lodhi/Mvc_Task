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
  
    public class DepartmentClass : DepartmentInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];
   
        
        //Add Department 
        public ResponseModel Depuser(DeparmentModel M)
        {

            ResponseModel result = new ResponseModel();
            DeparmentModel User = new DeparmentModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {

                    con.Open();

                     

                        using (SqlCommand cmd = new SqlCommand("InsertDeparmentUser", con))

                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Branch_name", M.Branch_name);
                            cmd.Parameters.AddWithValue("@Hod_name", M.Hod_name);
                            cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                            cmd.Parameters.AddWithValue("@Is_active", M.Is_active);


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

        //get deparment lIst 
        public List<DeparmentModel> getDepDetails()

        {

            List<DeparmentModel> res = new List<DeparmentModel>();

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

                                DeparmentModel u = new DeparmentModel();
                                u.Branch_id = (int)reader["Branch_id"];

                                u.Branch_name = (string)reader["Branch_name"];

                                u.Hod_name = (string)reader["Hod_name"];
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

        //Delete Department item by id 
        public ResponseModel deleteDepListItem(int id)
        {
            ResponseModel result = new ResponseModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_deleteDepMasterItem", con))
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



        public DeparmentModel editDepMaster(int Id)

        {

            ResponseModel res = new ResponseModel();

            DeparmentModel User = new DeparmentModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("sp_GetDepartmentListById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.Branch_id= string.IsNullOrEmpty(reader["Branch_id"].ToString()) ? 0 : Convert.ToInt32(reader["Branch_id"]);


                                User.Branch_name = string.IsNullOrWhiteSpace(reader["Branch_name"].ToString()) ? "" : reader["Branch_name"].ToString();

                                User.Hod_name = string.IsNullOrWhiteSpace(reader["Hod_name"].ToString()) ? "" : reader["Hod_name"].ToString();
                                User.Is_active = !string.IsNullOrWhiteSpace(reader["Is_active"].ToString()) && reader["Is_active"].ToString().ToLower() == "active";



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

        public ResponseModel updateDepart(DeparmentModel dep)
        {

            ResponseModel result = new ResponseModel();
            DeparmentModel User = new DeparmentModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Sp_update_Department_List", con))

                    {
                        cmd.Parameters.AddWithValue("@Branch_id", dep.Branch_id);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Branch_name", dep.Branch_name);
                        cmd.Parameters.AddWithValue("@Hod_name", dep.Hod_name);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@Is_active", dep.Is_active);

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


    }
}
