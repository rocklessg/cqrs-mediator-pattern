using CqrsMediatRPattern.API.Commands;
using CqrsMediatRPattern.API.Repositories.Interfaces;
using MediatR;

namespace CqrsMediatRPattern.API.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByIdAsync(command.Id);

            if (student is null) 
            { 
                return default;
            }

            return await _studentRepository.DeleteStudentAsync(student.Id);
        }
    }
}
