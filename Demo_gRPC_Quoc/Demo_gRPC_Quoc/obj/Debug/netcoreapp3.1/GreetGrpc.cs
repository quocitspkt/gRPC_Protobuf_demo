// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Demo_gRPC_Quoc {
  /// <summary>
  /// The calculate service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.SumRequest> __Marshaller_greet_SumRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.SumRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.SumReply> __Marshaller_greet_SumReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.SumReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.SubRequest> __Marshaller_greet_SubRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.SubRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.SubReply> __Marshaller_greet_SubReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.SubReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.MulRequest> __Marshaller_greet_MulRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.MulRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.MulReply> __Marshaller_greet_MulReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.MulReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.DivRequest> __Marshaller_greet_DivRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.DivRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Demo_gRPC_Quoc.DivReply> __Marshaller_greet_DivReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Demo_gRPC_Quoc.DivReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Demo_gRPC_Quoc.SumRequest, global::Demo_gRPC_Quoc.SumReply> __Method_Sum = new grpc::Method<global::Demo_gRPC_Quoc.SumRequest, global::Demo_gRPC_Quoc.SumReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sum",
        __Marshaller_greet_SumRequest,
        __Marshaller_greet_SumReply);

    static readonly grpc::Method<global::Demo_gRPC_Quoc.SubRequest, global::Demo_gRPC_Quoc.SubReply> __Method_Sub = new grpc::Method<global::Demo_gRPC_Quoc.SubRequest, global::Demo_gRPC_Quoc.SubReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sub",
        __Marshaller_greet_SubRequest,
        __Marshaller_greet_SubReply);

    static readonly grpc::Method<global::Demo_gRPC_Quoc.MulRequest, global::Demo_gRPC_Quoc.MulReply> __Method_Mul = new grpc::Method<global::Demo_gRPC_Quoc.MulRequest, global::Demo_gRPC_Quoc.MulReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Mul",
        __Marshaller_greet_MulRequest,
        __Marshaller_greet_MulReply);

    static readonly grpc::Method<global::Demo_gRPC_Quoc.DivRequest, global::Demo_gRPC_Quoc.DivReply> __Method_Div = new grpc::Method<global::Demo_gRPC_Quoc.DivRequest, global::Demo_gRPC_Quoc.DivReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Div",
        __Marshaller_greet_DivRequest,
        __Marshaller_greet_DivReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Demo_gRPC_Quoc.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Demo_gRPC_Quoc.SumReply> Sum(global::Demo_gRPC_Quoc.SumRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo_gRPC_Quoc.SubReply> Sub(global::Demo_gRPC_Quoc.SubRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo_gRPC_Quoc.MulReply> Mul(global::Demo_gRPC_Quoc.MulRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo_gRPC_Quoc.DivReply> Div(global::Demo_gRPC_Quoc.DivRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Sum, serviceImpl.Sum)
          .AddMethod(__Method_Sub, serviceImpl.Sub)
          .AddMethod(__Method_Mul, serviceImpl.Mul)
          .AddMethod(__Method_Div, serviceImpl.Div).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Sum, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo_gRPC_Quoc.SumRequest, global::Demo_gRPC_Quoc.SumReply>(serviceImpl.Sum));
      serviceBinder.AddMethod(__Method_Sub, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo_gRPC_Quoc.SubRequest, global::Demo_gRPC_Quoc.SubReply>(serviceImpl.Sub));
      serviceBinder.AddMethod(__Method_Mul, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo_gRPC_Quoc.MulRequest, global::Demo_gRPC_Quoc.MulReply>(serviceImpl.Mul));
      serviceBinder.AddMethod(__Method_Div, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo_gRPC_Quoc.DivRequest, global::Demo_gRPC_Quoc.DivReply>(serviceImpl.Div));
    }

  }
}
#endregion
