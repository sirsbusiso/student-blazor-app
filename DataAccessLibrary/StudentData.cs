using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class StudentData : IStudentData
    {
        private readonly ISqlDataAccess _db;

        public StudentData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<StudentModel>> GetStudents()
        {
            string sql = "select * from dbo.tb_Students";

            return _db.LoadData<StudentModel, dynamic>(sql, new { });

        }

        public Task InsertStudent(StudentModel model)
        {
            string sql = @"insert into dbo.tb_Students (Name, Surname, Age)
                          values (@Name, @Surname, @Age);";

            return _db.SaveData(sql, model);

        }
    }
}
