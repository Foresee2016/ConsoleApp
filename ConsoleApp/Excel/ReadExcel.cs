using System;
using System.Data;
using System.Data.OleDb;

namespace ConsoleApp.Excel {
	class ReadExcel {
		public static DataSet ExcelToDataSet(string path) {
			// .NET Core里没有OleDbConnection这种连接方式，白试了就。辣鸡.NET，吃枣药丸
			string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
			OleDbConnection conn = new OleDbConnection(strConn);
			conn.Open();
			DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
			DisplayDataTable2(schemaTable);
			string tableName = schemaTable.Rows[0][2].ToString().Trim();
			//System.Console.WriteLine("tableName: " + tableName);
			string strExcel = "select * from [教研组信息$]";
			OleDbDataAdapter myCmd = new OleDbDataAdapter(strExcel,conn);
			DataSet ds = new DataSet();
			myCmd.Fill(ds, "table1");
			return ds;
		}
		public static void DisplayDataTable(DataTable table) {
			foreach (DataRow row in table.Rows) {
				foreach (DataColumn col in table.Columns) {
					Console.WriteLine("{0} = {1}, ", col.ColumnName, row[col]);
				}
				Console.WriteLine("---------------");
			}
		}
		public static void DisplayDataTable2(DataTable table) {
			for(int i=0; i<table.Rows.Count; i++) {
				DataRow row = table.Rows[i];
				for (int j = 0; j < table.Columns.Count; j++) {
					Console.WriteLine("{0} : {1}", j, row[j]);
				}
				Console.WriteLine();
				Console.WriteLine("----------");
			}
		}
		static void Main(string[] args) {
			DataSet ds = ExcelToDataSet("D:/VsSpace/模板/教研组-信息导入模板.xlsx");
			for(int i=0; i < ds.Tables.Count; i++) {
				Console.WriteLine("---------------");
				DataTable table = ds.Tables[i];
				Console.WriteLine(table.TableName);
				DisplayDataTable2(table);
			}
			Console.ReadKey();
		}
	}
}