using HotelManagement.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Net.Http.Headers;
using System.Runtime.Versioning;

namespace HotelManagement.Properties
{
    public class Connection
    {
       public void Page_Loader (object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-R6FGGGQ\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open ();

            SqlCommand cmd = new SqlCommand("insert into ut values(@fName,@lName,@rEmail,@rPhone,@rPassword)", conn);

            
            cmd.Parameters.AddWithValue("@fName", ());


        }
    }
}
