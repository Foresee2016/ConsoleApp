using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Db.MySql {
	class Student {
		public uint Id { get; set; }
		public string UserId { get; set; }
		[Required]
		public string SchoolId { get; set; }
		public string GradeId { get; set; }
		public string ClassId { get; set; } //#5
		public string RealName { get; set; }
		[Required]
		public string StudentId { get; set; }
		public string ExamCode { get; set; }
		public string RegCode { get; set; } //'学籍号'
		public string IdNumber { get; set; }//#10
		public string Sex { get; set; }
		public string Birthday { get; set; }
		public string ParentTel { get; set; }
		public string Address { get; set; } //#15
		public string Dorm { get; set; }
		public int Subject { get; set; }
		public string Remark { get; set; }
		// 创建时间和修改时间就不用放在类里了，创建和更新的时候做个时间戳
	}
}
