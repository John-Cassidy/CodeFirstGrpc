using ProtoBuf.Grpc;
using SharedContracts;

namespace CodeFirstGrpc.Services
{
    public class CodeFirstService : ICodeFirstContract
    {
        public Task<Response> Unary(Request request, CallContext context = default)
        {
            return Task.FromResult(
                 new Response
                 {
                     Message = $"Hello {request.Content}"
                 });
        }
    }
}
