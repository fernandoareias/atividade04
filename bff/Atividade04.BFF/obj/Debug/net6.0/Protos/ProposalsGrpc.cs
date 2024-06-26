// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Proposals.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Atividade04.BFF.Protos.Services {
  public static partial class ProposalsService
  {
    static readonly string __ServiceName = "ProposalsService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery> __Marshaller_ProposalsConsultaQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse> __Marshaller_ProposalsQueryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery, global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse> __Method_ConsultarProposals = new grpc::Method<global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery, global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ConsultarProposals",
        __Marshaller_ProposalsConsultaQuery,
        __Marshaller_ProposalsQueryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Atividade04.BFF.Protos.Services.ProposalsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ProposalsService</summary>
    public partial class ProposalsServiceClient : grpc::ClientBase<ProposalsServiceClient>
    {
      /// <summary>Creates a new client for ProposalsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProposalsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProposalsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProposalsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProposalsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProposalsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse ConsultarProposals(global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarProposals(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse ConsultarProposals(global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ConsultarProposals, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse> ConsultarProposalsAsync(global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConsultarProposalsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse> ConsultarProposalsAsync(global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ConsultarProposals, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProposalsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProposalsServiceClient(configuration);
      }
    }

  }
}
#endregion
