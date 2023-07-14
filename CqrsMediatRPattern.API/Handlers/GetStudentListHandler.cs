using CqrsMediatRPattern.API.Models;
using CqrsMediatRPattern.API.Queries;
using CqrsMediatRPattern.API.Repositories.Interfaces;
using MediatR;

namespace CqrsMediatRPattern.API.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetStudentListQuery query, CancellationToken cancellationToken) 
            => await _studentRepository.GetStudentListAsync();
    }
}
