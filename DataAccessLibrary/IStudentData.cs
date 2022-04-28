using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IStudentData
    {
        Task<List<StudentModel>> GetStudents();
        Task InsertStudent(StudentModel model);
    }
}