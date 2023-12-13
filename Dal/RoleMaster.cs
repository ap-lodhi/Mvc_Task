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
    public class RoleMaster : RoleInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];
        public ResponseModel roleuser(RoleModel M)
        {

            ResponseModel result = new ResponseModel();
            RoleModel User = new RoleModel();
            
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {

                    con.Open();

                    using (SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_signup WHERE emailId = @emailId", con))
                    {
                       // checkUsernameCmd.Parameters.AddWithValue("@emailId", objmodel.Role_name);
                       // int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                       // if (existingUserCount > 0)
                      //  {
                         //   result.status = false;
                           // result.message = "User EmailId already exists. Please choose a different email id.";
                      //  }
                       // else
                       // {

                            using (SqlCommand cmd = new SqlCommand("InsertRoleUser", con))

                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Role_name", M.Role_name);
                                cmd.Parameters.AddWithValue("@Role_designation", M.Role_designation);
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
                   // }
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



        public List<RoleModel> getRoleDetails()

        {

            List<RoleModel> res = new List<RoleModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetRoleUser", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;



                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                RoleModel u = new RoleModel();
                                u.Role_id= (int)reader["Role_id"];

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

        public ResponseModel deleteRoleListItem(int id)
        {
            ResponseModel result = new ResponseModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_deleteRoleMasterItem", con))
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


        public RoleModel editRoleMater(int Id)

        {

            ResponseModel res = new ResponseModel();

            RoleModel User = new RoleModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("sp_GetRoleListById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.Role_id = string.IsNullOrEmpty(reader["Role_id"].ToString()) ? 0 : Convert.ToInt32(reader["Role_id"]);


                                User.Role_name = string.IsNullOrWhiteSpace(reader["Role_name"].ToString()) ? "" : reader["Role_name"].ToString();

                                User.Role_designation = string.IsNullOrWhiteSpace(reader["Role_designation"].ToString()) ? "" : reader["Role_designation"].ToString();
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



        public ResponseModel updateRole(RoleModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            RoleModel User = new RoleModel();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Sp_update_Role_List", con))

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
    }
}
