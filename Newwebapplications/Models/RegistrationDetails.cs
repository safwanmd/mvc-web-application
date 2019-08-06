using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Newwebapplications.Models
{
    public class RegistrationDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        SqlConnection cn = new SqlConnection("Data Source=SAFWAN-PC;Initial Catalog=Mvcproject;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public string InsertRegDetails(RegistrationDetails obj)
        {
            cmd.CommandText= "Insert into Table values('" + obj.Name + "')";
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return "Success";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}