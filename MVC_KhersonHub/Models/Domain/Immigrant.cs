using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

namespace MVC_KhersonHub

{

    public class Immigrant

    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string RegisteredResidence { get; set; }
        [Required]
        public string ActualResidence { get; set; }
        [Required]
        public string IDP_number { get; set; }
        public int? Number_of_children { get; set; }
        public byte[] Img { get; set; }

        public List<Immigrant> GetImmigrant()
        {
            string connectionString = "Data Source=SQL8005.site4now.net;Initial Catalog=db_a9784f_khersonhub;User Id=db_a9784f_khersonhub_admin;Password=masyanya2003";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = "SELECT * FROM Immigrant";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Immigrant> immigrantList = new List<Immigrant>();


            while (dr.Read())
            {
                Immigrant immigrant = new Immigrant();
                immigrant.ID = Convert.ToInt32(dr["ID"]);
                immigrant.FirstName = dr["FirstName"].ToString();
                immigrant.SurName = dr["SurName"].ToString();
                immigrant.Patronymic = dr["Patronymic"].ToString();
                immigrant.Number = dr["Number"].ToString();
                immigrant.Date = Convert.ToDateTime(dr["Date"]);
                immigrant.RegisteredResidence = dr["RegisteredResidence"].ToString();
                immigrant.ActualResidence = dr["ActualResidence"].ToString();
                immigrant.IDP_number = dr["IDP_number"].ToString();
                immigrant.Number_of_children = Convert.ToInt32(dr["Number_of_children"]);
                immigrant.Img = (byte[])(dr["Img"]);

                immigrantList.Add(immigrant);
            }
            return immigrantList;

        }
    }
}
