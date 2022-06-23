using MySql.Data.MySqlClient;
using System;
namespace connectDatabase
{
    class Program
    {
        static string connStr = "server=localhost;user=root;password=;database=mbm;port=3306;";
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter{Environment.NewLine}1. To insert data into database.{Environment.NewLine}2. To display data from database. {Environment.NewLine}");
            var switch_on = Convert.ToInt32(Console.ReadLine());
            switch (switch_on)
            {
                case 1:
                    //var sql2 = "INSERT INTO address_book (Id, Full_Name, Email, Phone) VALUES (null, 'Hishan Shrestha', 'hishanshrestha29@gmail.com','9823715263')";

                    var sql2 = "INSERT INTO address_book (Id, Full_Name, Email, Phone) VALUES (null, @Full_Name, @Email, @Phone)";


                    WriteToDatabase(sql2);
                    break;
                case 2:
                    var sql = "SELECT * FROM address_book";
                    ReadFromDatabase(sql);
                    break;


                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public static void ReadFromDatabase(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "--" + reader[1] + "-- " + reader[2] + "-- " + reader[3]);
                }
                reader.Close();
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
            conn.Close();
            Console.WriteLine("Connection closed. Press any key to exit");
            Console.ReadKey();
        }

        public static void WriteToDatabase(string sql)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (cmd)
                {
                    Console.WriteLine("Enter full name");
                    var txtFullName = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    var txtEmail = Console.ReadLine();
                    Console.WriteLine("Enter phone");
                    var txtPhone = Console.ReadLine();
                    cmd.Parameters.AddWithValue("@Full_Name", txtFullName);
                    cmd.Parameters.AddWithValue("@Email", txtEmail);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data inserted successfully");
                }
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
            conn.Close();
            Console.WriteLine("Connection closed. Press any key to exit");
            Console.ReadKey();
        }
    }
}

