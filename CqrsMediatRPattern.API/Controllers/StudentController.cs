using CqrsMediatRPattern.API.Commands;
using CqrsMediatRPattern.API.Models;
using CqrsMediatRPattern.API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatRPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException();
        }

        [HttpGet("get-all-students")]
        public async Task<List<Student>> GetStudentListAsync()
        {
            var students = await _mediator.Send(new GetStudentListQuery());
            return students;
        }

        [HttpGet("get-student/id")]
       // [Route("id")]
        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery() { Id = studentId });
            return student;
        }

        [HttpPost("reqister-student")]
        public async Task<Student> AddStudentAsync(Student student)
        {
            var studentDetail = await _mediator.Send(new CreateStudentCommand(
                student.Name,
                student.Email,
                student.Address,
                student.Age));
            return studentDetail;
        }

        [HttpPut("updade-student")]
        public async Task<int> UpdateStudentAsync(Student student)
        {
            var isStudentDetailUpdated = await _mediator.Send(new UpdateStudentCommand(
               student.Id,
               student.Name,
               student.Email,
               student.Address,
               student.Age));
            return isStudentDetailUpdated;
        }

        [HttpDelete("delete-student/id")]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteStudentCommand() { Id = Id });
        }
    }
}
