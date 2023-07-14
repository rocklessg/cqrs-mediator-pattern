using CqrsMediatRPattern.API.Models;

namespace CqrsMediatRPattern.API.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentListAsync();
        Task<Student> GetStudentByIdAsync(int Id);
        Task<Student> AddStudentAsync(Student studentDetails);
        Task<int> UpdateStudentAsync(Student studentDetails);
        Task<int> DeleteStudentAsync(int Id);
    }
}
