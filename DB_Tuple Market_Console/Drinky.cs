using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DB_Tuple_Market_Console
{
    internal class Drinky : Foodie
    {


        public Drinky()
        {

        }

        //public Drinky(string n, string desc, int quanti, int price, int id_e) : base(n,desc,quanti,price,id_e)
        //{
            
        //}

        public new void InsertData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
        }

        public new void DeleteData(SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE t_drink WHERE id_food=@id_food", con);
            cmd.Parameters.AddWithValue("@id_food", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("your data already deleted.");
        }

        public new void UpdateData(SqlConnection con)
        { 
        
        
        }    
        
        public new void ShowData(SqlConnection con)
        {

        }
    }
}
