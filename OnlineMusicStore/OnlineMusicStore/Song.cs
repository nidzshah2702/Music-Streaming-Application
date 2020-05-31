using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicStore
{
    class Song
    {


        public string Title { get; set; }
        public string Language { get; set; }
        public string Artists { get; set; }
        public DateTime released_date { get; set; }
        public string FilePath { get; set; }
        public Album Album { get; set; }
     


        public void DownloadSong(int i)
        {

        }
       public static  SqlDataReader ViewSongs()
       {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nidhi Shah\Documents\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            string s = "Select * from Song";
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void setAlbum(int id) { 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nidhi Shah\Documents\MusicDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        string s = "Select * from Album where Id="+id;
        con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
        SqlDataReader dr = cmd.ExecuteReader();
            Album = new Album();
            while (dr.Read())
            {
                Album.AlbumImage = dr["AlbumImage"].ToString();
                Album.AlbumName = dr["AlbumName"].ToString();


            }
        

        }

    //    public IEnumerable<Song> BrowseSongs(string query)
     //   {

      //  }
    }



}
