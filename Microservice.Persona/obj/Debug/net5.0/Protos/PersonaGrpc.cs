// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/persona.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Microservice.Persona.Protos {
  public static partial class PersonaProtoService
  {
    static readonly string __ServiceName = "PersonaProtoService";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Microservice.Persona.Protos.personaRequest> __Marshaller_personaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservice.Persona.Protos.personaRequest.Parser));
    static readonly grpc::Marshaller<global::Microservice.Persona.Protos.personaResponse> __Marshaller_personaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservice.Persona.Protos.personaResponse.Parser));

    static readonly grpc::Method<global::Microservice.Persona.Protos.personaRequest, global::Microservice.Persona.Protos.personaResponse> __Method_GetPersona = new grpc::Method<global::Microservice.Persona.Protos.personaRequest, global::Microservice.Persona.Protos.personaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPersona",
        __Marshaller_personaRequest,
        __Marshaller_personaResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Microservice.Persona.Protos.PersonaReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonaProtoService</summary>
    [grpc::BindServiceMethod(typeof(PersonaProtoService), "BindService")]
    public abstract partial class PersonaProtoServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Microservice.Persona.Protos.personaResponse> GetPersona(global::Microservice.Persona.Protos.personaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PersonaProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPersona, serviceImpl.GetPersona).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PersonaProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPersona, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservice.Persona.Protos.personaRequest, global::Microservice.Persona.Protos.personaResponse>(serviceImpl.GetPersona));
    }

  }
}
#endregion
