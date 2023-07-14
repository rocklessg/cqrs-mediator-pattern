using CqrsMediatRPattern.API.Data;
using CqrsMediatRPattern.API.Models;
using CqrsMediatRPattern.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediatRPattern.API.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student> AddStudentAsync(Student studentDetails)
        {
            var result = await _dbContext.Students.AddAsync(studentDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _dbContext.Students.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Students.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int Id) => await _dbContext.Students.Where(x => x.Id == Id).FirstOrDefaultAsync();

        public async Task<List<Student>> GetStudentListAsync() => await _dbContext.Students.ToListAsync();

        public async Task<int> UpdateStudentAsync(Student studentDetails)
        {
            _dbContext.Students.Update(studentDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
