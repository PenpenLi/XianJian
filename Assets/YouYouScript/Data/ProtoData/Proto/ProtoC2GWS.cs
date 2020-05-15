// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_C2GWS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace YouYou.Proto {

  /// <summary>Holder for reflection information generated from Proto_C2GWS.proto</summary>
  public static partial class ProtoC2GWSReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_C2GWS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoC2GWSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b19DMkdXUy5wcm90bxIMWW91WW91LlByb3RvIiQKD0MyR1dTX1Jl",
            "Z0NsaWVudBIRCglBY2NvdW50SWQYASABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::YouYou.Proto.C2GWS_RegClient), global::YouYou.Proto.C2GWS_RegClient.Parser, new[]{ "AccountId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///玩家向网关服务器注册客户端
  /// </summary>
  public sealed partial class C2GWS_RegClient : YouYou.IProto, pb::IMessage<C2GWS_RegClient> {
    private static readonly pb::MessageParser<C2GWS_RegClient> _parser = new pb::MessageParser<C2GWS_RegClient>(() => new C2GWS_RegClient());
    public ushort ProtoId => ProtoIdDefine.Proto_C2GWS_RegClient;
    public string ProtoEnName => "C2GWS_RegClient";
    public ProtoCategory Category => ProtoCategory.Client2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2GWS_RegClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::YouYou.Proto.ProtoC2GWSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient(C2GWS_RegClient other) : this() {
      accountId_ = other.accountId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient Clone() {
      return new C2GWS_RegClient(this);
    }

    /// <summary>Field number for the "AccountId" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private long accountId_;
    /// <summary>
    ///玩家账号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2GWS_RegClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2GWS_RegClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountId != 0L) hash ^= AccountId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(AccountId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccountId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AccountId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2GWS_RegClient other) {
      if (other == null) {
        return;
      }
      if (other.AccountId != 0L) {
        AccountId = other.AccountId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AccountId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
