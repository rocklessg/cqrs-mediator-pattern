using CqrsMediatRPattern.API.Commands;
using CqrsMediatRPattern.API.Models;
using CqrsMediatRPattern.API.Repositories.Interfaces;
using MediatR;

namespace CqrsMediatRPattern.API.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Name = command.Name,
                Email = command.Email,
                Address = command.Address,
                Age = command.Age
            };
            return await _studentRepository.AddStudentAsync(student);
        }
    }
}
