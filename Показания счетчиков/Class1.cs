using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Path = System.IO.Path;
namespace Показания_счетчиков
{
    internal class DataBase
    { 
        
        //private SQLiteConnection SQLiteConn3;
        //private DataTable Meters;
        

        public static SQLiteConnection connection;
        static SQLiteCommand command;
        

        private bool conn = false;
        private const string V = "\\DB.db";

        public  DataBase()
        {
            if(conn == false)
            {
                try
                {
                    var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    var path = Path.GetDirectoryName(location);
                    connection = new SQLiteConnection("Data Source=" + path + V + ";Version=3; FailIfMissing =False");
                    connection.Open();                                        
                    //command = new SQLiteCommand(connection);
                    conn = true;
                    Console.WriteLine("OK");
                    

                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");

                }
            }
            
        }
        
        
        //Добавление счетчика
        public void AddMeter(string service, string variableComment)
        {

            command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO Meters ('Service', 'Name') VALUES ('"+service+"','"+variableComment+"');";
            command.ExecuteNonQuery();

        }

        //Добавление цен за услуги
        public void AddPrice(string service, double price, string measurement)
        {

            command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO Prices ('Service', 'Price', 'Measurement') VALUES ('" + service + "','" + price + "','" + measurement + "');";
            command.ExecuteNonQuery();
        }

        //Названия счетчика
        public string[] MetersNames()
        {
            
            string sqc = "SELECT * FROM Meters";
            SQLiteCommand command = new SQLiteCommand(sqc,connection);
            SQLiteDataReader reader = command.ExecuteReader();
            var lst = new List<string>();
            while (reader.Read())
            {   
                lst.Add((string)reader[2]);    
            }
            string[] name = new string[lst.Count];
            for(int i = 0; i < name.Length; i++)
            {
                name[i] =Convert.ToString(lst[i]);
                Console.WriteLine(name[i]);
            }
            return name;
        }

        //Вывод данных из Prices в dataGridView 2
        public List<string[]> Prices()
        {
            string sqc = "SELECT* FROM Prices";
            SQLiteCommand command = new SQLiteCommand(sqc, connection);
           
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                
            }
            reader.Close();
            
            return data;
        }

        //вывод показаний
        public List<string[]> Values(string meter)
        {
           
            
            command = new SQLiteCommand(connection);
            
            string table = "";
            command.CommandText = "SELECT Service FROM Meters WHERE Name = '" + meter + "';"; ;
            string service = command.ExecuteScalar().ToString();

            switch (service)
            {
                case "Холодное водоснабжение":
                    table = "coldWater";
                    break;

                case "Горячее водоснабжение":
                    table = "hotWater";
                    break;

                case "Электроснабжение":
                    table = "Electricity";
                    break;

                case "Газоснабжение":
                    table = "Gas";
                    break;
                default:
                    table = "";
                    break;
            }
            command.CommandText = "SELECT* FROM '" + table + "'";
            command.ExecuteNonQuery();

            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                //data[data.Count - 1][2] = reader[3].ToString();

            }
            reader.Close();

            return data;

        }


        //Изменить цену
        public void ChangePriceValue(string service,string price)
        {
            command = new SQLiteCommand(connection);
            Console.WriteLine(service);
            command.CommandText = "UPDATE Prices SET 'Price' = '" + price + "' WHERE Service = '" + service  + "';";
            
            command.ExecuteNonQuery();
            

        }

        //удаление цены
        public void DeletePriceValue(string service)
        {
            
            command = new SQLiteCommand(connection);
            command.CommandText = "DELETE FROM Prices WHERE Service = '" + service + "';";
            
            Console.WriteLine(command.ExecuteNonQuery());

           

        }
        //Добавление показаний
        public void AddMetersData(string meter, string date, int value)
        {
            command = new SQLiteCommand(connection);
           
            command.CommandText = "SELECT Service FROM Meters WHERE Name = '" + meter + "';"; 
            string service = command.ExecuteScalar().ToString();
            //Console.WriteLine(service);
            

            switch (service)
            {
                case "Холодное водоснабжение":
                    command.CommandText = "INSERT INTO coldWater('Date', 'Value','Name') VALUES('" + date + "', '" + value + "','" + meter + "'); ";
                    command.ExecuteNonQuery();
                    break;

                case "Горячее водоснабжение":
                    command.CommandText = "INSERT INTO hotWater('Date', 'Value','Name') VALUES('" + date + "', '" + value + "','" + meter + "'); ";
                    command.ExecuteNonQuery();
                    break;

                case "Электроснабжение":
                    command.CommandText = "INSERT INTO Electricity('Date', 'Value','Name') VALUES('" + date + "', '" + value + "','" + meter + "'); ";
                    command.ExecuteNonQuery();
                    break;

                case "Газоснабжение":
                    command.CommandText = "INSERT INTO Gas('Date', 'Value','Name') VALUES('" + date + "', '" + value + "','" + meter + "'); ";
                    command.ExecuteNonQuery();
                    break;


            }

            


        }
        //Вывод данных из Prices в dataGridView1
        public double Prices2(string meter)
        {
            double price;
            command = new SQLiteCommand(connection);

            command.CommandText = "SELECT Service FROM Meters WHERE Name = '" + meter + "';"; 
            string service = command.ExecuteScalar().ToString();

            try
            {
                command.CommandText = "SELECT Price FROM Prices WHERE Service = '" + service + "'; ";
                price = Convert.ToDouble(command.ExecuteScalar().ToString());
                
            }
            catch (NullReferenceException)
            {
                price = 0;
            }
            return price;


        }
        public String[] Service()
        {
            

           
            

            string sqc = "SELECT * FROM Prices";
            SQLiteCommand command = new SQLiteCommand(sqc, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            var lst = new List<string>();
            while (reader.Read())
            {
                lst.Add((string)reader[1]);
            }
            string[] name = new string[lst.Count];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Convert.ToString(lst[i]);
                //Console.WriteLine(name[i]);
            }
            return name;

            
        }

        
    }
}
