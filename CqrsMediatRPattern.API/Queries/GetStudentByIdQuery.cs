using CqrsMediatRPattern.API.Models;
using MediatR;

namespace CqrsMediatRPattern.API.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }
    }
}
