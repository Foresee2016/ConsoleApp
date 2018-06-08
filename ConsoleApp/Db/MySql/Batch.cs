using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp.Db.MySql {
	class Batch {
		static void Main(string[] args) {
			MySqlConnection conn = new MySqlConnection(
				"Data Source=localhost;Port=3306;Initial Catalog = learn;Persist Security Info=True;User=root;Password=123456;SslMode=None;");
			MySqlCommand cmd = new MySqlCommand();
			try {
				conn.Open();
				cmd.Connection = conn;
				cmd.CommandText = "INSERT INTO music(title, price) VALUES (@title, @price)";
				cmd.Prepare();
				//cmd.Parameters.Add("@ExamCode", MySqlDbType.String, 16); //这种方式能限制数值类型和列长度
				cmd.Parameters.AddWithValue("@title", "标题1");
				cmd.Parameters.AddWithValue("@price", 1);
				DateTime start = DateTime.Now;
				for (int i = 1; i <= 1000; i++) {
					cmd.Parameters["@title"].Value = "标题" + i;
					cmd.Parameters["@price"].Value = i;
					cmd.ExecuteNonQuery();
				}
				Console.WriteLine("用时："+(DateTime.Now - start).TotalMilliseconds);
			} catch (MySqlException ex) {
				Console.WriteLine(ex);
				throw;
			}
			Console.ReadKey();
		}
	}
}
