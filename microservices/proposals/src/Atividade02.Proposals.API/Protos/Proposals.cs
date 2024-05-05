// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Proposals.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Atividade04.BFF.Protos.Services {

  /// <summary>Holder for reflection information generated from Protos/Proposals.proto</summary>
  public static partial class ProposalsReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Proposals.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProposalsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvUHJvcG9zYWxzLnByb3RvIkQKFlByb3Bvc2Fsc0NvbnN1bHRh",
            "UXVlcnkSEQoJY25wal9sb2phGAEgASgJEhcKD3VzdWFyaW9fbG9qaXN0YRgC",
            "IAEoCSK4AQoRUHJvcG9zYWxzUmVzcG9uc2USFAoMYWdncmVnYXRlX2lkGAEg",
            "ASgJEhIKCmNyZWF0ZWRfYXQYAiABKAkSEgoKdXBkYXRlZF9hdBgDIAEoCRIM",
            "CgRjb2RlGAQgASgJEhAKCGZ1bGxuYW1lGAUgASgJEgsKA2NwZhgGIAEoCRIR",
            "CgljZWxscGhvbmUYByABKAkSDgoGc3RhdHVzGAggASgJEhUKDWNyZWFkaXRf",
            "bGltaXQYCSABKAkiPwoWUHJvcG9zYWxzUXVlcnlSZXNwb25zZRIlCglwcm9w",
            "b3NhbHMYASADKAsyEi5Qcm9wb3NhbHNSZXNwb25zZTJaChBQcm9wb3NhbHNT",
            "ZXJ2aWNlEkYKEkNvbnN1bHRhclByb3Bvc2FscxIXLlByb3Bvc2Fsc0NvbnN1",
            "bHRhUXVlcnkaFy5Qcm9wb3NhbHNRdWVyeVJlc3BvbnNlQiKqAh9BdGl2aWRh",
            "ZGUwNC5CRkYuUHJvdG9zLlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery), global::Atividade04.BFF.Protos.Services.ProposalsConsultaQuery.Parser, new[]{ "CnpjLoja", "UsuarioLojista" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Atividade04.BFF.Protos.Services.ProposalsResponse), global::Atividade04.BFF.Protos.Services.ProposalsResponse.Parser, new[]{ "AggregateId", "CreatedAt", "UpdatedAt", "Code", "Fullname", "Cpf", "Cellphone", "Status", "CreaditLimit" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse), global::Atividade04.BFF.Protos.Services.ProposalsQueryResponse.Parser, new[]{ "Proposals" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProposalsConsultaQuery : pb::IMessage<ProposalsConsultaQuery>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProposalsConsultaQuery> _parser = new pb::MessageParser<ProposalsConsultaQuery>(() => new ProposalsConsultaQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProposalsConsultaQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Atividade04.BFF.Protos.Services.ProposalsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsConsultaQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsConsultaQuery(ProposalsConsultaQuery other) : this() {
      cnpjLoja_ = other.cnpjLoja_;
      usuarioLojista_ = other.usuarioLojista_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsConsultaQuery Clone() {
      return new ProposalsConsultaQuery(this);
    }

    /// <summary>Field number for the "cnpj_loja" field.</summary>
    public const int CnpjLojaFieldNumber = 1;
    private string cnpjLoja_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CnpjLoja {
      get { return cnpjLoja_; }
      set {
        cnpjLoja_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "usuario_lojista" field.</summary>
    public const int UsuarioLojistaFieldNumber = 2;
    private string usuarioLojista_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UsuarioLojista {
      get { return usuarioLojista_; }
      set {
        usuarioLojista_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProposalsConsultaQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProposalsConsultaQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CnpjLoja != other.CnpjLoja) return false;
      if (UsuarioLojista != other.UsuarioLojista) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CnpjLoja.Length != 0) hash ^= CnpjLoja.GetHashCode();
      if (UsuarioLojista.Length != 0) hash ^= UsuarioLojista.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CnpjLoja.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CnpjLoja);
      }
      if (UsuarioLojista.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UsuarioLojista);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CnpjLoja.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CnpjLoja);
      }
      if (UsuarioLojista.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UsuarioLojista);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CnpjLoja.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CnpjLoja);
      }
      if (UsuarioLojista.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UsuarioLojista);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProposalsConsultaQuery other) {
      if (other == null) {
        return;
      }
      if (other.CnpjLoja.Length != 0) {
        CnpjLoja = other.CnpjLoja;
      }
      if (other.UsuarioLojista.Length != 0) {
        UsuarioLojista = other.UsuarioLojista;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CnpjLoja = input.ReadString();
            break;
          }
          case 18: {
            UsuarioLojista = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            CnpjLoja = input.ReadString();
            break;
          }
          case 18: {
            UsuarioLojista = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProposalsResponse : pb::IMessage<ProposalsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProposalsResponse> _parser = new pb::MessageParser<ProposalsResponse>(() => new ProposalsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProposalsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Atividade04.BFF.Protos.Services.ProposalsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsResponse(ProposalsResponse other) : this() {
      aggregateId_ = other.aggregateId_;
      createdAt_ = other.createdAt_;
      updatedAt_ = other.updatedAt_;
      code_ = other.code_;
      fullname_ = other.fullname_;
      cpf_ = other.cpf_;
      cellphone_ = other.cellphone_;
      status_ = other.status_;
      creaditLimit_ = other.creaditLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsResponse Clone() {
      return new ProposalsResponse(this);
    }

    /// <summary>Field number for the "aggregate_id" field.</summary>
    public const int AggregateIdFieldNumber = 1;
    private string aggregateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AggregateId {
      get { return aggregateId_; }
      set {
        aggregateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 2;
    private string createdAt_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "updated_at" field.</summary>
    public const int UpdatedAtFieldNumber = 3;
    private string updatedAt_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UpdatedAt {
      get { return updatedAt_; }
      set {
        updatedAt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 4;
    private string code_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Code {
      get { return code_; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fullname" field.</summary>
    public const int FullnameFieldNumber = 5;
    private string fullname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Fullname {
      get { return fullname_; }
      set {
        fullname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cpf" field.</summary>
    public const int CpfFieldNumber = 6;
    private string cpf_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Cpf {
      get { return cpf_; }
      set {
        cpf_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cellphone" field.</summary>
    public const int CellphoneFieldNumber = 7;
    private string cellphone_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Cellphone {
      get { return cellphone_; }
      set {
        cellphone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 8;
    private string status_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Status {
      get { return status_; }
      set {
        status_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "creadit_limit" field.</summary>
    public const int CreaditLimitFieldNumber = 9;
    private string creaditLimit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CreaditLimit {
      get { return creaditLimit_; }
      set {
        creaditLimit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProposalsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProposalsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AggregateId != other.AggregateId) return false;
      if (CreatedAt != other.CreatedAt) return false;
      if (UpdatedAt != other.UpdatedAt) return false;
      if (Code != other.Code) return false;
      if (Fullname != other.Fullname) return false;
      if (Cpf != other.Cpf) return false;
      if (Cellphone != other.Cellphone) return false;
      if (Status != other.Status) return false;
      if (CreaditLimit != other.CreaditLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AggregateId.Length != 0) hash ^= AggregateId.GetHashCode();
      if (CreatedAt.Length != 0) hash ^= CreatedAt.GetHashCode();
      if (UpdatedAt.Length != 0) hash ^= UpdatedAt.GetHashCode();
      if (Code.Length != 0) hash ^= Code.GetHashCode();
      if (Fullname.Length != 0) hash ^= Fullname.GetHashCode();
      if (Cpf.Length != 0) hash ^= Cpf.GetHashCode();
      if (Cellphone.Length != 0) hash ^= Cellphone.GetHashCode();
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (CreaditLimit.Length != 0) hash ^= CreaditLimit.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (AggregateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AggregateId);
      }
      if (CreatedAt.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CreatedAt);
      }
      if (UpdatedAt.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UpdatedAt);
      }
      if (Code.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Code);
      }
      if (Fullname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Fullname);
      }
      if (Cpf.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Cpf);
      }
      if (Cellphone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Cellphone);
      }
      if (Status.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Status);
      }
      if (CreaditLimit.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CreaditLimit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AggregateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AggregateId);
      }
      if (CreatedAt.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CreatedAt);
      }
      if (UpdatedAt.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UpdatedAt);
      }
      if (Code.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Code);
      }
      if (Fullname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Fullname);
      }
      if (Cpf.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Cpf);
      }
      if (Cellphone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Cellphone);
      }
      if (Status.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Status);
      }
      if (CreaditLimit.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CreaditLimit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AggregateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AggregateId);
      }
      if (CreatedAt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatedAt);
      }
      if (UpdatedAt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UpdatedAt);
      }
      if (Code.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (Fullname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fullname);
      }
      if (Cpf.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cpf);
      }
      if (Cellphone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cellphone);
      }
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (CreaditLimit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreaditLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProposalsResponse other) {
      if (other == null) {
        return;
      }
      if (other.AggregateId.Length != 0) {
        AggregateId = other.AggregateId;
      }
      if (other.CreatedAt.Length != 0) {
        CreatedAt = other.CreatedAt;
      }
      if (other.UpdatedAt.Length != 0) {
        UpdatedAt = other.UpdatedAt;
      }
      if (other.Code.Length != 0) {
        Code = other.Code;
      }
      if (other.Fullname.Length != 0) {
        Fullname = other.Fullname;
      }
      if (other.Cpf.Length != 0) {
        Cpf = other.Cpf;
      }
      if (other.Cellphone.Length != 0) {
        Cellphone = other.Cellphone;
      }
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.CreaditLimit.Length != 0) {
        CreaditLimit = other.CreaditLimit;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AggregateId = input.ReadString();
            break;
          }
          case 18: {
            CreatedAt = input.ReadString();
            break;
          }
          case 26: {
            UpdatedAt = input.ReadString();
            break;
          }
          case 34: {
            Code = input.ReadString();
            break;
          }
          case 42: {
            Fullname = input.ReadString();
            break;
          }
          case 50: {
            Cpf = input.ReadString();
            break;
          }
          case 58: {
            Cellphone = input.ReadString();
            break;
          }
          case 66: {
            Status = input.ReadString();
            break;
          }
          case 74: {
            CreaditLimit = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            AggregateId = input.ReadString();
            break;
          }
          case 18: {
            CreatedAt = input.ReadString();
            break;
          }
          case 26: {
            UpdatedAt = input.ReadString();
            break;
          }
          case 34: {
            Code = input.ReadString();
            break;
          }
          case 42: {
            Fullname = input.ReadString();
            break;
          }
          case 50: {
            Cpf = input.ReadString();
            break;
          }
          case 58: {
            Cellphone = input.ReadString();
            break;
          }
          case 66: {
            Status = input.ReadString();
            break;
          }
          case 74: {
            CreaditLimit = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProposalsQueryResponse : pb::IMessage<ProposalsQueryResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProposalsQueryResponse> _parser = new pb::MessageParser<ProposalsQueryResponse>(() => new ProposalsQueryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProposalsQueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Atividade04.BFF.Protos.Services.ProposalsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsQueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsQueryResponse(ProposalsQueryResponse other) : this() {
      proposals_ = other.proposals_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProposalsQueryResponse Clone() {
      return new ProposalsQueryResponse(this);
    }

    /// <summary>Field number for the "proposals" field.</summary>
    public const int ProposalsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Atividade04.BFF.Protos.Services.ProposalsResponse> _repeated_proposals_codec
        = pb::FieldCodec.ForMessage(10, global::Atividade04.BFF.Protos.Services.ProposalsResponse.Parser);
    private readonly pbc::RepeatedField<global::Atividade04.BFF.Protos.Services.ProposalsResponse> proposals_ = new pbc::RepeatedField<global::Atividade04.BFF.Protos.Services.ProposalsResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Atividade04.BFF.Protos.Services.ProposalsResponse> Proposals {
      get { return proposals_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProposalsQueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProposalsQueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!proposals_.Equals(other.proposals_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= proposals_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      proposals_.WriteTo(output, _repeated_proposals_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      proposals_.WriteTo(ref output, _repeated_proposals_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += proposals_.CalculateSize(_repeated_proposals_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProposalsQueryResponse other) {
      if (other == null) {
        return;
      }
      proposals_.Add(other.proposals_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            proposals_.AddEntriesFrom(input, _repeated_proposals_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            proposals_.AddEntriesFrom(ref input, _repeated_proposals_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
