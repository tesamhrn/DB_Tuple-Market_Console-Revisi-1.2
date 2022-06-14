using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace DB_Tuple_Market_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datsource = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DB_TupleMarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(datsource);

            Console.WriteLine("\t\t\tWelcome The Tuple Market");
            //SqlCommand cmd = new SqlCommand()

            //menu. 

            MainMenu:
            Console.WriteLine("Login as :\n");
            Console.WriteLine("1. Admin");
            Console.WriteLine("9. Just want to Shooping\n");

            Console.Write("Input : ");
            int SelectLogin = int.Parse(Console.ReadLine());

            if (SelectLogin == 1 )
            {
                Console.WriteLine();
                Console.WriteLine("Input your identity.");
                loginpage:
                Console.Write("Username : ");
                string username = Console.ReadLine();
                

                Console.Write("Password : ");
                int password = int.Parse(Console.ReadLine());

                
                    String querry = "SELECT * FROM T_admin WHERE username= '"+username+"'AND password = '"+password+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry,con);
                    
                    DataTable  dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0 )
                    {
                        Console.WriteLine($"Welcome {username}, what's gonna you do in here ? ");
                        
                        ProductMenu: 

                        Console.WriteLine("All stuff we had here : \n");
                        Console.WriteLine("1. Food");
                        Console.WriteLine("2. Drinks");
                        Console.WriteLine("9. Back\n");

                        Console.Write("Input : ");
                        int select = int.Parse(Console.ReadLine());
                        var Features = 0; 
                        switch (select)
                        {
                            case 1:

                                Foodie fd = new Foodie();

                                DatabaseMenu();

                                Console.Write("Input your option features : ");
                                Features = int.Parse(Console.ReadLine());

                                if (Features == 1)
                                {
                                    Console.WriteLine("Insert the data : \n");

                                    Console.Write("name food : ");
                                    fd.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    fd.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    fd.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    fd.price = int.Parse(Console.ReadLine());

                                    Console.Write("id food : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    fd.InsertData(con);


                                }

                                else if (Features == 2)
                                {
                                    Console.WriteLine("delete the data by input the \'id\' : \n");

                                    Console.Write("id : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    fd.DeleteData(con);
                                }

                                else if (Features == 3)
                                {
                                    Console.WriteLine("update the data by input the \'id\' as an primary key : \n");
                                   
                                    Console.Write("id food : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    Console.Write("name food : ");
                                    fd.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    fd.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    fd.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    fd.price = int.Parse(Console.ReadLine());

                                }

                                else if (Features == 4)
                                {
                                    fd.ShowData(con);
                                }

                                goto ProductMenu;
                            case 2:
                                DatabaseMenu();

                                Drinky drink1 = new Drinky();

                                Console.Write("Input your option features : ");
                                Features = int.Parse(Console.ReadLine());

                                if (Features == 1)
                                {
                                    Console.WriteLine("Insert the data : \n");

                                    Console.Write("name food : ");
                                    drink1.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    drink1.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    drink1.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    drink1.price = int.Parse(Console.ReadLine());

                                    Console.Write("id food : ");
                                    drink1.id = int.Parse(Console.ReadLine());

                                    //drink1.InsertData(con);
                                }

                                else if (Features == 2)
                                {
                                    Console.WriteLine("delete the data by input the \'id\' : \n");

                                    Console.Write("id : ");
                                    drink1.id = int.Parse(Console.ReadLine());

                                    fd.DeleteData(con);

                            }

                                else if (Features == 3)
                                {

                                }

                                else if (Features == 4)
                                {

                                }
                                break;
                            case 3:

                                break;
                            case 9:

                                goto MainMenu;

                           

                            default:
                                break;
                        }



                    }

                    else
                    {
                        MessageBox.Show("Fill the correct Data !", ":)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("\n\n");
                        goto loginpage; 
                    }
              
                
                
            }

            else if (SelectLogin == 9)
            {

            }
        }

        private static void DatabaseMenu()
        {
            Console.WriteLine("1. INSERT data");
            Console.WriteLine("2. DELETE data");
            Console.WriteLine("3. UPDATE data");
            Console.WriteLine("4. SHOW   data\n");
            
            
        }

        public void Inserting(SqlConnection con )
        {
            string querry = @"INSERT INTO t_food VALUES()";

        }

        public void ShowData()
        {
            string querry = @"SELECT * FROM t_food ";
        }

        public static void Delete()
        {
            string querry = @"";
        }

    }
}
