// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/PlainInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FreeStripService {

  /// <summary>Holder for reflection information generated from Protos/PlainInfo.proto</summary>
  public static partial class PlainInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/PlainInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlainInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvUGxhaW5JbmZvLnByb3RvEglQbGFpbkluZm8iiQEKF1BsYWlu",
            "UHJlcGFyYXRpb25SZXF1ZXN0EhIKCnBsYWluTW9kZWwYASABKBESEAoIYWx0",
            "aXR1ZGUYAiABKAESFAoMYWx0aXR1ZGVUZW1wGAMgASgBEhYKDmNhbGN1bGF0",
            "ZWRUZW1wGAQgASgBEhoKEmNhbGN1bGF0ZWRQcmVzc3VyZRgFIAEoASJeChVQ",
            "bGFpblByZXBhcmF0aW9uUmVwbHkSFgoOcHJlcGFyZU1pbnV0ZXMYASABKAES",
            "GAoQYnVzeVN0cmlwTWludXRlcxgCIAEoARITCgtzdHJpcExlbmd0aBgDIAEo",
            "ATK7AQoJUGxhaW5JbmZvElYKDkdldExhbmRpbmdJbmZvEiIuUGxhaW5JbmZv",
            "LlBsYWluUHJlcGFyYXRpb25SZXF1ZXN0GiAuUGxhaW5JbmZvLlBsYWluUHJl",
            "cGFyYXRpb25SZXBseRJWCg5HZXRUYWtlT2ZmSW5mbxIiLlBsYWluSW5mby5Q",
            "bGFpblByZXBhcmF0aW9uUmVxdWVzdBogLlBsYWluSW5mby5QbGFpblByZXBh",
            "cmF0aW9uUmVwbHlCE6oCEEZyZWVTdHJpcFNlcnZpY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FreeStripService.PlainPreparationRequest), global::FreeStripService.PlainPreparationRequest.Parser, new[]{ "PlainModel", "Altitude", "AltitudeTemp", "CalculatedTemp", "CalculatedPressure" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::FreeStripService.PlainPreparationReply), global::FreeStripService.PlainPreparationReply.Parser, new[]{ "PrepareMinutes", "BusyStripMinutes", "StripLength" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlainPreparationRequest : pb::IMessage<PlainPreparationRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlainPreparationRequest> _parser = new pb::MessageParser<PlainPreparationRequest>(() => new PlainPreparationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlainPreparationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FreeStripService.PlainInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationRequest(PlainPreparationRequest other) : this() {
      plainModel_ = other.plainModel_;
      altitude_ = other.altitude_;
      altitudeTemp_ = other.altitudeTemp_;
      calculatedTemp_ = other.calculatedTemp_;
      calculatedPressure_ = other.calculatedPressure_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationRequest Clone() {
      return new PlainPreparationRequest(this);
    }

    /// <summary>Field number for the "plainModel" field.</summary>
    public const int PlainModelFieldNumber = 1;
    private int plainModel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlainModel {
      get { return plainModel_; }
      set {
        plainModel_ = value;
      }
    }

    /// <summary>Field number for the "altitude" field.</summary>
    public const int AltitudeFieldNumber = 2;
    private double altitude_;
    /// <summary>
    ///������ ��� ������� ����
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Altitude {
      get { return altitude_; }
      set {
        altitude_ = value;
      }
    }

    /// <summary>Field number for the "altitudeTemp" field.</summary>
    public const int AltitudeTempFieldNumber = 3;
    private double altitudeTemp_;
    /// <summary>
    ///����������� �� ���� ������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AltitudeTemp {
      get { return altitudeTemp_; }
      set {
        altitudeTemp_ = value;
      }
    }

    /// <summary>Field number for the "calculatedTemp" field.</summary>
    public const int CalculatedTempFieldNumber = 4;
    private double calculatedTemp_;
    /// <summary>
    ///���������� �������� ����������� ��� ������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CalculatedTemp {
      get { return calculatedTemp_; }
      set {
        calculatedTemp_ = value;
      }
    }

    /// <summary>Field number for the "calculatedPressure" field.</summary>
    public const int CalculatedPressureFieldNumber = 5;
    private double calculatedPressure_;
    /// <summary>
    ///���������� �������� �������� ��� ������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CalculatedPressure {
      get { return calculatedPressure_; }
      set {
        calculatedPressure_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlainPreparationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlainPreparationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlainModel != other.PlainModel) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Altitude, other.Altitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AltitudeTemp, other.AltitudeTemp)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CalculatedTemp, other.CalculatedTemp)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CalculatedPressure, other.CalculatedPressure)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlainModel != 0) hash ^= PlainModel.GetHashCode();
      if (Altitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Altitude);
      if (AltitudeTemp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AltitudeTemp);
      if (CalculatedTemp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CalculatedTemp);
      if (CalculatedPressure != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CalculatedPressure);
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
      if (PlainModel != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(PlainModel);
      }
      if (Altitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Altitude);
      }
      if (AltitudeTemp != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(AltitudeTemp);
      }
      if (CalculatedTemp != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(CalculatedTemp);
      }
      if (CalculatedPressure != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(CalculatedPressure);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PlainModel != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(PlainModel);
      }
      if (Altitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Altitude);
      }
      if (AltitudeTemp != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(AltitudeTemp);
      }
      if (CalculatedTemp != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(CalculatedTemp);
      }
      if (CalculatedPressure != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(CalculatedPressure);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlainModel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(PlainModel);
      }
      if (Altitude != 0D) {
        size += 1 + 8;
      }
      if (AltitudeTemp != 0D) {
        size += 1 + 8;
      }
      if (CalculatedTemp != 0D) {
        size += 1 + 8;
      }
      if (CalculatedPressure != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlainPreparationRequest other) {
      if (other == null) {
        return;
      }
      if (other.PlainModel != 0) {
        PlainModel = other.PlainModel;
      }
      if (other.Altitude != 0D) {
        Altitude = other.Altitude;
      }
      if (other.AltitudeTemp != 0D) {
        AltitudeTemp = other.AltitudeTemp;
      }
      if (other.CalculatedTemp != 0D) {
        CalculatedTemp = other.CalculatedTemp;
      }
      if (other.CalculatedPressure != 0D) {
        CalculatedPressure = other.CalculatedPressure;
      }
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
          case 8: {
            PlainModel = input.ReadSInt32();
            break;
          }
          case 17: {
            Altitude = input.ReadDouble();
            break;
          }
          case 25: {
            AltitudeTemp = input.ReadDouble();
            break;
          }
          case 33: {
            CalculatedTemp = input.ReadDouble();
            break;
          }
          case 41: {
            CalculatedPressure = input.ReadDouble();
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
          case 8: {
            PlainModel = input.ReadSInt32();
            break;
          }
          case 17: {
            Altitude = input.ReadDouble();
            break;
          }
          case 25: {
            AltitudeTemp = input.ReadDouble();
            break;
          }
          case 33: {
            CalculatedTemp = input.ReadDouble();
            break;
          }
          case 41: {
            CalculatedPressure = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class PlainPreparationReply : pb::IMessage<PlainPreparationReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlainPreparationReply> _parser = new pb::MessageParser<PlainPreparationReply>(() => new PlainPreparationReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlainPreparationReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FreeStripService.PlainInfoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationReply(PlainPreparationReply other) : this() {
      prepareMinutes_ = other.prepareMinutes_;
      busyStripMinutes_ = other.busyStripMinutes_;
      stripLength_ = other.stripLength_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlainPreparationReply Clone() {
      return new PlainPreparationReply(this);
    }

    /// <summary>Field number for the "prepareMinutes" field.</summary>
    public const int PrepareMinutesFieldNumber = 1;
    private double prepareMinutes_;
    /// <summary>
    ///����� �� ���������� ��������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PrepareMinutes {
      get { return prepareMinutes_; }
      set {
        prepareMinutes_ = value;
      }
    }

    /// <summary>Field number for the "busyStripMinutes" field.</summary>
    public const int BusyStripMinutesFieldNumber = 2;
    private double busyStripMinutes_;
    /// <summary>
    ///����� ���������, ����� ������ ��� �������� ���������� ������� ����� ������/�������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BusyStripMinutes {
      get { return busyStripMinutes_; }
      set {
        busyStripMinutes_ = value;
      }
    }

    /// <summary>Field number for the "stripLength" field.</summary>
    public const int StripLengthFieldNumber = 3;
    private double stripLength_;
    /// <summary>
    ///����������� ����� ������ ��� ������
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double StripLength {
      get { return stripLength_; }
      set {
        stripLength_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlainPreparationReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlainPreparationReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PrepareMinutes, other.PrepareMinutes)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BusyStripMinutes, other.BusyStripMinutes)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StripLength, other.StripLength)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PrepareMinutes != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PrepareMinutes);
      if (BusyStripMinutes != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BusyStripMinutes);
      if (StripLength != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StripLength);
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
      if (PrepareMinutes != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PrepareMinutes);
      }
      if (BusyStripMinutes != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BusyStripMinutes);
      }
      if (StripLength != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(StripLength);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PrepareMinutes != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PrepareMinutes);
      }
      if (BusyStripMinutes != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BusyStripMinutes);
      }
      if (StripLength != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(StripLength);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PrepareMinutes != 0D) {
        size += 1 + 8;
      }
      if (BusyStripMinutes != 0D) {
        size += 1 + 8;
      }
      if (StripLength != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlainPreparationReply other) {
      if (other == null) {
        return;
      }
      if (other.PrepareMinutes != 0D) {
        PrepareMinutes = other.PrepareMinutes;
      }
      if (other.BusyStripMinutes != 0D) {
        BusyStripMinutes = other.BusyStripMinutes;
      }
      if (other.StripLength != 0D) {
        StripLength = other.StripLength;
      }
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
          case 9: {
            PrepareMinutes = input.ReadDouble();
            break;
          }
          case 17: {
            BusyStripMinutes = input.ReadDouble();
            break;
          }
          case 25: {
            StripLength = input.ReadDouble();
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
          case 9: {
            PrepareMinutes = input.ReadDouble();
            break;
          }
          case 17: {
            BusyStripMinutes = input.ReadDouble();
            break;
          }
          case 25: {
            StripLength = input.ReadDouble();
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
