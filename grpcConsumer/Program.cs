// See https://aka.ms/new-console-template for more information
using CodeFirstGrpc.Contracts;
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhost:7184");

var reply = await client.Unary( new Request { Name = "GreeterClient" });

Console.WriteLine($"Greeting: {reply.Message}");
Console.WriteLine("Press any key to exit...");