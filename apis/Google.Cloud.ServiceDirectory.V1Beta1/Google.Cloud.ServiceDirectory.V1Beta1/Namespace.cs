// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1beta1/namespace.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1beta1/namespace.proto</summary>
  public static partial class NamespaceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1beta1/namespace.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NamespaceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJldGExL25hbWVz",
            "cGFjZS5wcm90bxIlZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3RvcnkudjFi",
            "ZXRhMRofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90byKQAgoJTmFtZXNwYWNlEhEKBG5hbWUYASABKAlCA+BBBRJRCgZsYWJl",
            "bHMYAiADKAsyPC5nb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MWJl",
            "dGExLk5hbWVzcGFjZS5MYWJlbHNFbnRyeUID4EEBGi0KC0xhYmVsc0VudHJ5",
            "EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAE6bupBawopc2Vydmlj",
            "ZWRpcmVjdG9yeS5nb29nbGVhcGlzLmNvbS9OYW1lc3BhY2USPnByb2plY3Rz",
            "L3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9uYW1lc3BhY2VzL3tu",
            "YW1lc3BhY2V9QpICCiljb20uZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3Rv",
            "cnkudjFiZXRhMUIOTmFtZXNwYWNlUHJvdG9QAVpVZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9zZXJ2aWNlZGlyZWN0b3J5",
            "L3YxYmV0YTE7c2VydmljZWRpcmVjdG9yefgBAaoCJUdvb2dsZS5DbG91ZC5T",
            "ZXJ2aWNlRGlyZWN0b3J5LlYxQmV0YTHKAiVHb29nbGVcQ2xvdWRcU2Vydmlj",
            "ZURpcmVjdG9yeVxWMWJldGEx6gIoR29vZ2xlOjpDbG91ZDo6U2VydmljZURp",
            "cmVjdG9yeTo6VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.Namespace), global::Google.Cloud.ServiceDirectory.V1Beta1.Namespace.Parser, new[]{ "Name", "Labels" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A container for [services][google.cloud.servicedirectory.v1beta1.Service].
  /// Namespaces allow administrators to group services together and define
  /// permissions for a collection of services.
  /// </summary>
  public sealed partial class Namespace : pb::IMessage<Namespace>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Namespace> _parser = new pb::MessageParser<Namespace>(() => new Namespace());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Namespace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.NamespaceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Namespace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Namespace(Namespace other) : this() {
      name_ = other.name_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Namespace Clone() {
      return new Namespace(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The resource name for the namespace in the format
    /// 'projects/*/locations/*/namespaces/*'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. Resource labels associated with this Namespace.
    /// No more than 64 user labels can be associated with a given resource.  Label
    /// keys and values can be no longer than 63 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Namespace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Namespace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Labels.Equals(other.Labels)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Labels.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Namespace other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      labels_.Add(other.labels_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
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
