using System.Threading;
using System.Threading.Tasks;

namespace MakeItEasyCQRS.Handlers.Contracts
{
    public interface IGenericHandler<TRequest, TResult>
    {
        Task<TResult> Handle(TRequest request, CancellationToken cancellationToken);
    }
}