using CqrsMediatRPattern.API.Models;
using CqrsMediatRPattern.API.Queries;
using CqrsMediatRPattern.API.Repositories.Interfaces;
using MediatR;

namespace CqrsMediatRPattern.API.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentByIdAsync(query.Id);
        }
    }
}
