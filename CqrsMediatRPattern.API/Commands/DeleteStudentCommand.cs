using MediatR;

namespace CqrsMediatRPattern.API.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
