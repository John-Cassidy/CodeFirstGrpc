// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using SharedContracts;

Console.WriteLine("Hello, World!");
using var channel = GrpcChannel.ForAddress("https://localhost:7251");
var client = channel.CreateGrpcService<ICodeFirstContract>();

var reply = await client.Unary(
    new Request { Content = "CodeFirst project" });

Console.WriteLine($"Greeting: {reply.Message}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();