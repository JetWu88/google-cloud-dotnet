// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/notification_message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/notification_message.proto</summary>
  public static partial class NotificationMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/notification_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvbm90aWZpY2F0aW9u",
            "X21lc3NhZ2UucHJvdG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52",
            "MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxosZ29vZ2xlL2Nsb3Vk",
            "L3NlY3VyaXR5Y2VudGVyL3YxL2ZpbmRpbmcucHJvdG8ifAoTTm90aWZpY2F0",
            "aW9uTWVzc2FnZRIgChhub3RpZmljYXRpb25fY29uZmlnX25hbWUYASABKAkS",
            "OgoHZmluZGluZxgCIAEoCzInLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRl",
            "ci52MS5GaW5kaW5nSABCBwoFZXZlbnRC9AEKImNvbS5nb29nbGUuY2xvdWQu",
            "c2VjdXJpdHljZW50ZXIudjFCGE5vdGlmaWNhdGlvbk1lc3NhZ2VQcm90b1AB",
            "Wkxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3Vk",
            "L3NlY3VyaXR5Y2VudGVyL3YxO3NlY3VyaXR5Y2VudGVyqgIeR29vZ2xlLkNs",
            "b3VkLlNlY3VyaXR5Q2VudGVyLlYxygIeR29vZ2xlXENsb3VkXFNlY3VyaXR5",
            "Q2VudGVyXFYx6gIhR29vZ2xlOjpDbG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYx",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.SecurityCenter.V1.FindingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.NotificationMessage), global::Google.Cloud.SecurityCenter.V1.NotificationMessage.Parser, new[]{ "NotificationConfigName", "Finding" }, new[]{ "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Cloud SCC's Notification
  /// </summary>
  public sealed partial class NotificationMessage : pb::IMessage<NotificationMessage> {
    private static readonly pb::MessageParser<NotificationMessage> _parser = new pb::MessageParser<NotificationMessage>(() => new NotificationMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NotificationMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.NotificationMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotificationMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotificationMessage(NotificationMessage other) : this() {
      notificationConfigName_ = other.notificationConfigName_;
      switch (other.EventCase) {
        case EventOneofCase.Finding:
          Finding = other.Finding.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotificationMessage Clone() {
      return new NotificationMessage(this);
    }

    /// <summary>Field number for the "notification_config_name" field.</summary>
    public const int NotificationConfigNameFieldNumber = 1;
    private string notificationConfigName_ = "";
    /// <summary>
    /// Name of the notification config that generated current notification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NotificationConfigName {
      get { return notificationConfigName_; }
      set {
        notificationConfigName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "finding" field.</summary>
    public const int FindingFieldNumber = 2;
    /// <summary>
    /// If it's a Finding based notification config, this field will be
    /// populated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1.Finding Finding {
      get { return eventCase_ == EventOneofCase.Finding ? (global::Google.Cloud.SecurityCenter.V1.Finding) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.Finding;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      Finding = 2,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NotificationMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NotificationMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NotificationConfigName != other.NotificationConfigName) return false;
      if (!object.Equals(Finding, other.Finding)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NotificationConfigName.Length != 0) hash ^= NotificationConfigName.GetHashCode();
      if (eventCase_ == EventOneofCase.Finding) hash ^= Finding.GetHashCode();
      hash ^= (int) eventCase_;
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
      if (NotificationConfigName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NotificationConfigName);
      }
      if (eventCase_ == EventOneofCase.Finding) {
        output.WriteRawTag(18);
        output.WriteMessage(Finding);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NotificationConfigName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NotificationConfigName);
      }
      if (eventCase_ == EventOneofCase.Finding) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Finding);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NotificationMessage other) {
      if (other == null) {
        return;
      }
      if (other.NotificationConfigName.Length != 0) {
        NotificationConfigName = other.NotificationConfigName;
      }
      switch (other.EventCase) {
        case EventOneofCase.Finding:
          if (Finding == null) {
            Finding = new global::Google.Cloud.SecurityCenter.V1.Finding();
          }
          Finding.MergeFrom(other.Finding);
          break;
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
          case 10: {
            NotificationConfigName = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Cloud.SecurityCenter.V1.Finding subBuilder = new global::Google.Cloud.SecurityCenter.V1.Finding();
            if (eventCase_ == EventOneofCase.Finding) {
              subBuilder.MergeFrom(Finding);
            }
            input.ReadMessage(subBuilder);
            Finding = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code