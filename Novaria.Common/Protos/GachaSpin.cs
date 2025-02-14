// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gacha_spin.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from gacha_spin.proto</summary>
  public static partial class GachaSpinReflection {

    #region Descriptor
    /// <summary>File descriptor for gacha_spin.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaSpinReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBnYWNoYV9zcGluLnByb3RvEgVwcm90bxoMcHVibGljLnByb3RvIj4KDEdh",
            "Y2hhU3BpblJlcRIKCgJJZBgBIAEoDRIMCgRNb2RlGAIgASgNEhQKC05leHRQ",
            "YWNrYWdlGP8PIAEoDCKKAQoNR2FjaGFTcGluUmVzcBIfCgVDYXJkcxgBIAMo",
            "CzIQLnByb3RvLkdhY2hhQ2FyZBIhCgZDaGFuZ2UYAiABKAsyES5wcm90by5D",
            "aGFuZ2VJbmZvEgwKBFRpbWUYAyABKAMSEQoJRGF5c0NvdW50GA8gASgNEhQK",
            "C05leHRQYWNrYWdlGP8PIAEoDCJgCglHYWNoYUNhcmQSHAoEQ2FyZBgBIAEo",
            "CzIOLnByb3RvLkl0ZW1UcGwSHwoHUmV3YXJkcxgCIAMoCzIOLnByb3RvLkl0",
            "ZW1UcGwSFAoLTmV4dFBhY2thZ2UY/w8gASgMUABiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.PublicReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.GachaSpinReq), global::Proto.GachaSpinReq.Parser, new[]{ "Id", "Mode", "NextPackage" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.GachaSpinResp), global::Proto.GachaSpinResp.Parser, new[]{ "Cards", "Change", "Time", "DaysCount", "NextPackage" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.GachaCard), global::Proto.GachaCard.Parser, new[]{ "Card", "Rewards", "NextPackage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GachaSpinReq : pb::IMessage<GachaSpinReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaSpinReq> _parser = new pb::MessageParser<GachaSpinReq>(() => new GachaSpinReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaSpinReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.GachaSpinReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinReq(GachaSpinReq other) : this() {
      id_ = other.id_;
      mode_ = other.mode_;
      nextPackage_ = other.nextPackage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinReq Clone() {
      return new GachaSpinReq(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "Mode" field.</summary>
    public const int ModeFieldNumber = 2;
    private uint mode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Mode {
      get { return mode_; }
      set {
        mode_ = value;
      }
    }

    /// <summary>Field number for the "NextPackage" field.</summary>
    public const int NextPackageFieldNumber = 2047;
    private pb::ByteString nextPackage_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString NextPackage {
      get { return nextPackage_; }
      set {
        nextPackage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaSpinReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaSpinReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Mode != other.Mode) return false;
      if (NextPackage != other.NextPackage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Mode != 0) hash ^= Mode.GetHashCode();
      if (NextPackage.Length != 0) hash ^= NextPackage.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Mode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Mode);
      }
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Mode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Mode);
      }
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Mode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mode);
      }
      if (NextPackage.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(NextPackage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaSpinReq other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Mode != 0) {
        Mode = other.Mode;
      }
      if (other.NextPackage.Length != 0) {
        NextPackage = other.NextPackage;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Mode = input.ReadUInt32();
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Mode = input.ReadUInt32();
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GachaSpinResp : pb::IMessage<GachaSpinResp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaSpinResp> _parser = new pb::MessageParser<GachaSpinResp>(() => new GachaSpinResp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaSpinResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.GachaSpinReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinResp(GachaSpinResp other) : this() {
      cards_ = other.cards_.Clone();
      change_ = other.change_ != null ? other.change_.Clone() : null;
      time_ = other.time_;
      daysCount_ = other.daysCount_;
      nextPackage_ = other.nextPackage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaSpinResp Clone() {
      return new GachaSpinResp(this);
    }

    /// <summary>Field number for the "Cards" field.</summary>
    public const int CardsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Proto.GachaCard> _repeated_cards_codec
        = pb::FieldCodec.ForMessage(10, global::Proto.GachaCard.Parser);
    private readonly pbc::RepeatedField<global::Proto.GachaCard> cards_ = new pbc::RepeatedField<global::Proto.GachaCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Proto.GachaCard> Cards {
      get { return cards_; }
    }

    /// <summary>Field number for the "Change" field.</summary>
    public const int ChangeFieldNumber = 2;
    private global::Proto.ChangeInfo change_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Proto.ChangeInfo Change {
      get { return change_; }
      set {
        change_ = value;
      }
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 3;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "DaysCount" field.</summary>
    public const int DaysCountFieldNumber = 15;
    private uint daysCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DaysCount {
      get { return daysCount_; }
      set {
        daysCount_ = value;
      }
    }

    /// <summary>Field number for the "NextPackage" field.</summary>
    public const int NextPackageFieldNumber = 2047;
    private pb::ByteString nextPackage_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString NextPackage {
      get { return nextPackage_; }
      set {
        nextPackage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaSpinResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaSpinResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cards_.Equals(other.cards_)) return false;
      if (!object.Equals(Change, other.Change)) return false;
      if (Time != other.Time) return false;
      if (DaysCount != other.DaysCount) return false;
      if (NextPackage != other.NextPackage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cards_.GetHashCode();
      if (change_ != null) hash ^= Change.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (DaysCount != 0) hash ^= DaysCount.GetHashCode();
      if (NextPackage.Length != 0) hash ^= NextPackage.GetHashCode();
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
      cards_.WriteTo(output, _repeated_cards_codec);
      if (change_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Change);
      }
      if (Time != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Time);
      }
      if (DaysCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DaysCount);
      }
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      cards_.WriteTo(ref output, _repeated_cards_codec);
      if (change_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Change);
      }
      if (Time != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Time);
      }
      if (DaysCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DaysCount);
      }
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      size += cards_.CalculateSize(_repeated_cards_codec);
      if (change_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Change);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (DaysCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DaysCount);
      }
      if (NextPackage.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(NextPackage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaSpinResp other) {
      if (other == null) {
        return;
      }
      cards_.Add(other.cards_);
      if (other.change_ != null) {
        if (change_ == null) {
          Change = new global::Proto.ChangeInfo();
        }
        Change.MergeFrom(other.Change);
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.DaysCount != 0) {
        DaysCount = other.DaysCount;
      }
      if (other.NextPackage.Length != 0) {
        NextPackage = other.NextPackage;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            cards_.AddEntriesFrom(input, _repeated_cards_codec);
            break;
          }
          case 18: {
            if (change_ == null) {
              Change = new global::Proto.ChangeInfo();
            }
            input.ReadMessage(Change);
            break;
          }
          case 24: {
            Time = input.ReadInt64();
            break;
          }
          case 120: {
            DaysCount = input.ReadUInt32();
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            cards_.AddEntriesFrom(ref input, _repeated_cards_codec);
            break;
          }
          case 18: {
            if (change_ == null) {
              Change = new global::Proto.ChangeInfo();
            }
            input.ReadMessage(Change);
            break;
          }
          case 24: {
            Time = input.ReadInt64();
            break;
          }
          case 120: {
            DaysCount = input.ReadUInt32();
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GachaCard : pb::IMessage<GachaCard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaCard> _parser = new pb::MessageParser<GachaCard>(() => new GachaCard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.GachaSpinReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaCard(GachaCard other) : this() {
      card_ = other.card_ != null ? other.card_.Clone() : null;
      rewards_ = other.rewards_.Clone();
      nextPackage_ = other.nextPackage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaCard Clone() {
      return new GachaCard(this);
    }

    /// <summary>Field number for the "Card" field.</summary>
    public const int CardFieldNumber = 1;
    private global::Proto.ItemTpl card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Proto.ItemTpl Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    /// <summary>Field number for the "Rewards" field.</summary>
    public const int RewardsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Proto.ItemTpl> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(18, global::Proto.ItemTpl.Parser);
    private readonly pbc::RepeatedField<global::Proto.ItemTpl> rewards_ = new pbc::RepeatedField<global::Proto.ItemTpl>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Proto.ItemTpl> Rewards {
      get { return rewards_; }
    }

    /// <summary>Field number for the "NextPackage" field.</summary>
    public const int NextPackageFieldNumber = 2047;
    private pb::ByteString nextPackage_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString NextPackage {
      get { return nextPackage_; }
      set {
        nextPackage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Card, other.Card)) return false;
      if(!rewards_.Equals(other.rewards_)) return false;
      if (NextPackage != other.NextPackage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (card_ != null) hash ^= Card.GetHashCode();
      hash ^= rewards_.GetHashCode();
      if (NextPackage.Length != 0) hash ^= NextPackage.GetHashCode();
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
      if (card_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Card);
      }
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      if (card_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Card);
      }
      rewards_.WriteTo(ref output, _repeated_rewards_codec);
      if (NextPackage.Length != 0) {
        output.WriteRawTag(250, 127);
        output.WriteBytes(NextPackage);
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
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      size += rewards_.CalculateSize(_repeated_rewards_codec);
      if (NextPackage.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(NextPackage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaCard other) {
      if (other == null) {
        return;
      }
      if (other.card_ != null) {
        if (card_ == null) {
          Card = new global::Proto.ItemTpl();
        }
        Card.MergeFrom(other.Card);
      }
      rewards_.Add(other.rewards_);
      if (other.NextPackage.Length != 0) {
        NextPackage = other.NextPackage;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (card_ == null) {
              Card = new global::Proto.ItemTpl();
            }
            input.ReadMessage(Card);
            break;
          }
          case 18: {
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (card_ == null) {
              Card = new global::Proto.ItemTpl();
            }
            input.ReadMessage(Card);
            break;
          }
          case 18: {
            rewards_.AddEntriesFrom(ref input, _repeated_rewards_codec);
            break;
          }
          case 16378: {
            NextPackage = input.ReadBytes();
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
