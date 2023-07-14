using CqrsMediatRPattern.API.Models;
using MediatR;

namespace CqrsMediatRPattern.API.Queries
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {

    }
}
