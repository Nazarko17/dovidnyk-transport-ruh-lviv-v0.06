using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ElectroTransport.Classes {
    class electroClass {
        //Getters та Setters
        public int TransportID { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Interval { get; set; }
        public string Stops { get; set; }
        public string Type { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Пошук даних в БД
        public DataTable Select() {
            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try {
                //2. Запит SQL
                string sql = "SELECT * FROM table_marshrut";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення SQL DataAdapter за допомогою cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return dt;
        }

        //Запис даних в БД
        public bool Insert(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //2. Запит SQL для запису даних в БД
                string sql = "INSERT INTO table_marshrut (TransportID, Start, Finish, Interval, Stops, Type) VALUES (@TransportID, @Start, @Finish, @Interval, @Stops, @Type)";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення параметрів для додавання даних
                cmd.Parameters.AddWithValue("@TransportID", m.TransportID);
                cmd.Parameters.AddWithValue("@Start", m.Start);
                cmd.Parameters.AddWithValue("@Finish", m.Finish);
                cmd.Parameters.AddWithValue("@Interval", m.Interval);
                cmd.Parameters.AddWithValue("@Stops", m.Stops);
                cmd.Parameters.AddWithValue("@Type", m.Type);

                //Підключення відкрито
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                } else {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return isSuccess;
        }

        //Оновлення даних в БД
        public bool Update(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //Запит SQL для оновлення даних в БД
                string sql = "UPDATE table_marshrut SET Start=@Start, Finish=@Finish, Interval=@Interval, Stops=@Stops, Type=@Type WHERE TransportID=@TransportID";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення параметрві для додавання даних
                cmd.Parameters.AddWithValue("@Start", m.Start);
                cmd.Parameters.AddWithValue("@Finish", m.Finish);
                cmd.Parameters.AddWithValue("@Interval", m.Interval);
                cmd.Parameters.AddWithValue("@Stops", m.Stops);
                cmd.Parameters.AddWithValue("@Type", m.Type);
                cmd.Parameters.AddWithValue("TransportID", m.TransportID);
                //Підключення відкрито
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                }
                else {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return isSuccess;
        }
        
        //Видалення даних з БД
        public bool Delete(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //Запит SQL для видалення даних в БД
                string sql = "DELETE FROM table_marshrut WHERE TransportID=@TransportID";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TransportID", m.TransportID);
                //Підключення відкрито
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally{
                //Підключення закрито
                conn.Close();
            }
            return isSuccess;
        }

    }
}