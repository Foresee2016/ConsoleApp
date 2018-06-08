using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp.Db.MySql {
	class Simple {
		static void Main(string[] args) {
			PrintAll();
			Console.WriteLine("--------------------");
			PrintAll2();
			Console.ReadKey();
		}
		static void PrintAll() {
			// 两种连接字符串都可以
			MySqlConnection conn = new MySqlConnection(
				//"server=127.0.0.1;user id=root;Password=123456;database=learn;persist security info=False");
				"Data Source=localhost;Port=3306;Initial Catalog = learn;Persist Security Info=True;User=root;Password=123456;SslMode=None;");
			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select * from music";
			try {
				conn.Open();
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					string title = reader.GetString("title");
					DateTime releaseDate = reader.GetDateTime("release_date");
					double price = reader.GetDouble("price");
					Console.WriteLine("title: {0}, release: {1}, price: {2}", title, releaseDate, price);
				}
			} catch (Exception e) {
				Console.WriteLine(e);
			} finally {
				conn.Close();
			}
		}
		static void PrintAll2() {
			MySqlConnection conn = new MySqlConnection(
				"Data Source=localhost;Port=3306;Initial Catalog = learn;Persist Security Info=True;User=root;Password=123456;SslMode=None;");

			MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select * from music";
			try {
				// 用MySqlDataAdapter也行
				MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(cmd.CommandText, conn);
				DataTable dataTable = new DataTable();
				dbDataAdapter.Fill(dataTable);
				for (int i = 0; i < dataTable.Rows.Count; i++) {
					string title = dataTable.Rows[i]["title"].ToString();
					DateTime releaseDate = DateTime.Parse(dataTable.Rows[i]["release_date"].ToString());
					double price = Double.Parse(dataTable.Rows[i]["price"].ToString());
					Console.WriteLine("title: {0}, release: {1}, price: {2}", title, releaseDate, price);
				}
			} catch (Exception e) {
				Console.WriteLine(e);
			} finally {
				conn.Close();
			}
		}
	}
	class Music {
		public long Id { get; set; }
		public string Title { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public double Price { get; set; }

		public Music() {

		}

		public Music(long id, string title, DateTime releaseDate, string genre, double price) {
			Id = id;
			Title = title;
			ReleaseDate = releaseDate;
			Genre = genre;
			Price = price;
		}
	}
}
