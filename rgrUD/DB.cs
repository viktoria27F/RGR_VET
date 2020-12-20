using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Drawing;

namespace rgrUD
{
    class DB
    {
        public List<string> AllTables { get; set; }
        MySqlConnection connection;

        public DB(string log, string pas)
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=" + log + "; password=" + pas + ";database=veterinary_clinic;");
           
        }
        //ОТКРЫТИЕ СОЕДИНЕНИЯ
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
           
        }
        //ЗАКРЫТИЕ СОЕДИНЕНИЯ
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        //ВОЗВРАТ СОЕДИНЕНИЯ
        public MySqlConnection getConnection()
        {
            return connection;
        }

        private static void QueryPet(MySqlConnection conn,string sql)
        {
            

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Индекс (index) столбца Emp_ID в команде SQL.
                        int empIdIndex = reader.GetOrdinal("Emp_Id"); // 0


                        long empId = Convert.ToInt64(reader.GetValue(0));

                        // Столбец Emp_No имеет index = 1.
                        string empNo = reader.GetString(1);
                        int empNameIndex = reader.GetOrdinal("Emp_Name");// 2
                        string empName = reader.GetString(empNameIndex);

                        // Индекс (index) столбца Mng_Id в команде SQL.
                        int mngIdIndex = reader.GetOrdinal("Mng_Id");

                        long? mngId = null;

                        // Проверить значение данного столбца может являться null или нет.
                        if (!reader.IsDBNull(mngIdIndex))
                        {
                            mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("empIdIndex:" + empIdIndex);
                        Console.WriteLine("EmpId:" + empId);
                        Console.WriteLine("EmpNo:" + empNo);
                        Console.WriteLine("EmpName:" + empName);
                        Console.WriteLine("MngId:" + mngId);
                    }
                }
            }

        }


        
        public void  SelectAllTables()
        {

            string sql = "SHOW Tables";
            AllTables = new List<string>();
            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = connection;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AllTables.Add(reader.GetString(0));
                    }
                }
            }
        }
    }

}
