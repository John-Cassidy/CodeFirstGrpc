using System.Runtime.Serialization;
using System.ServiceModel;
using ProtoBuf.Grpc;

namespace SharedContracts
{   

    [DataContract]
    public class Request
    {
        [DataMember(Order = 1)]
        public string Content { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }

    [ServiceContract]
    public interface ICodeFirstContract
    {
        Task<Response> Unary(Request request, CallContext context = default);
    }
}
