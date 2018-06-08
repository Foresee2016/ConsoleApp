using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp.Db.MySql {
	class Batch2 {
		public static readonly string INSERT_FIELD = "RI_UserId, RI_SchoolId, RI_GradeId, RI_ClassId, RI_RealName, RI_StudentId, RI_ExamCode, " + //#7
			"RI_RegCode, RI_IdNumber, RI_Sex, RI_Birthday, RI_ParentTel, RI_Address, RI_Dorm, RI_Subject, RI_Remark, RI_CreateTime, RI_UpdateTime"; //#11
		static void Main(string[] args) {
			Student[] students = new Student[3];
			for (int i = 0; i < students.Length; i++) {
				students[i] = new Student {
					UserId = Guid.NewGuid().ToString(),
					SchoolId = "123456",
					StudentId = "987654321",
					GradeId = "987654",
					ClassId = "123456789",
					ExamCode = "4566789321",
					RegCode = "852741963"
				};
			}
			MySqlConnection conn = new MySqlConnection(
				"Data Source=127.0.0.1;Port=3306;Initial Catalog=RI_ScheduleCourse;MinimumPoolSize=3;Persist Security Info=True;User=mysql;Password=123456;SslMode=None;");
			MySqlCommand cmd = new MySqlCommand();
			try {
				conn.Open();
				cmd.Connection = conn;
				cmd.CommandText = "insert into RI_Student (" + INSERT_FIELD + ")"
									+ "values(@UserId, @SchoolId, @GradeId, @ClassId, @RealName, @StudentId, @ExamCode, @RegCode, @IdNumber, @Sex, " //#10
									+ "@Birthday, @ParentTel, @Address, @Dorm, @Subject, @Remark, NOW(), NOW());" //#8
									+ "select last_insert_id();";
				cmd.Prepare();
				cmd.Parameters.Add("@UserId", MySqlDbType.String, 36);
				cmd.Parameters.Add("@SchoolId", MySqlDbType.String, 36);
				cmd.Parameters.Add("@GradeId", MySqlDbType.String, 36);
				cmd.Parameters.Add("@ClassId", MySqlDbType.String, 36);
				cmd.Parameters.Add("@RealName", MySqlDbType.String, 16);//#5
				cmd.Parameters.Add("@StudentId", MySqlDbType.String, 32);
				cmd.Parameters.Add("@ExamCode", MySqlDbType.String, 16);
				cmd.Parameters.Add("@RegCode", MySqlDbType.String, 36);
				cmd.Parameters.Add("@IdNumber", MySqlDbType.String, 20);
				cmd.Parameters.Add("@Sex", MySqlDbType.String, 2); //#5
				cmd.Parameters.Add("@Birthday", MySqlDbType.String, 20);
				cmd.Parameters.Add("@ParentTel", MySqlDbType.String, 32);
				cmd.Parameters.Add("@Address", MySqlDbType.String, 30);
				cmd.Parameters.Add("@Dorm", MySqlDbType.String, 32);
				cmd.Parameters.Add("@Subject", MySqlDbType.Int16); //#5
				cmd.Parameters.Add("@Remark", MySqlDbType.Text);
				uint[] res = new uint[students.Length];
				for (int i = 0; i < students.Length; i++) {
					students[i].UserId = Guid.NewGuid().ToString();
					cmd.Parameters["@UserId"].Value = students[i].UserId;
					cmd.Parameters["@SchoolId"].Value = students[i].SchoolId;
					cmd.Parameters["@GradeId"].Value = students[i].GradeId;
					cmd.Parameters["@ClassId"].Value = students[i].ClassId;
					cmd.Parameters["@RealName"].Value = students[i].RealName;
					cmd.Parameters["@StudentId"].Value = students[i].StudentId;
					cmd.Parameters["@ExamCode"].Value = students[i].ExamCode;
					cmd.Parameters["@RegCode"].Value = students[i].RegCode;
					cmd.Parameters["@IdNumber"].Value = students[i].IdNumber;
					cmd.Parameters["@Sex"].Value = students[i].Sex;
					cmd.Parameters["@Birthday"].Value = students[i].Birthday;
					cmd.Parameters["@ParentTel"].Value = students[i].ParentTel;
					cmd.Parameters["@Address"].Value = students[i].Address;
					cmd.Parameters["@Dorm"].Value = students[i].Dorm;
					cmd.Parameters["@Subject"].Value = students[i].Subject;
					cmd.Parameters["@Remark"].Value = students[i].Remark;
					object newId = cmd.ExecuteScalar();
					res[i] = Convert.ToUInt32(newId.ToString());
				}
				Console.WriteLine(String.Join(",", res));
			} catch (MySqlException ex) {
				Console.WriteLine(ex);
				throw;
			}
			Console.ReadKey();
		}
	}
}
