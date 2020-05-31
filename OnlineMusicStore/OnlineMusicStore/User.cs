using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicStore
{
    class User
    {
        public string Name { get; set; }
       public  string ContactNo { get; set; }
       public string Email { get; set; }
      public  string Password { get; set; }
        public string Subscription { get; set; } = "Standard";


        public static bool Login(string email,string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nidhi Shah\Documents\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "Select * from Users where Email='" + email + "'" + "and Password='"+password+ "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginInfo.Email = dr["Email"].ToString();
                LoginInfo.Name = dr["Name"].ToString();
                LoginInfo.Id = Convert.ToInt32(dr["Id"]);
                return true;
            }
            return false;

        }


        public static bool Register(User u)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nidhi Shah\Documents\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "Insert into Users values('" + u.Name + "','" + u.ContactNo + "','" + u.Email + "','" + u.Subscription + "','" + u.Password + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i != 0)
            {
                Login(u.Email, u.Password);

                return true;


            }else
            {
                return false;
            }
        }

    }

  


}
