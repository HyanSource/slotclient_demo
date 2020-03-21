// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: msg.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from msg.proto</summary>
  public static partial class MsgReflection {

    #region Descriptor
    /// <summary>File descriptor for msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgltc2cucHJvdG8SAnBiIkcKClBsYXllckRhdGESEAoIUGxheWVySUQYASAB",
            "KAUSEgoKUGxheWVyTmFtZRgCIAEoCRITCgtQbGF5ZXJNb25leRgDIAEoBSIk",
            "CgNCZXQSEAoIUGxheWVySUQYASABKAUSCwoDQmV0GAIgASgFIjwKCExpbmVP",
            "ZGRzEg0KBUdldElEGAEgASgFEhAKCEdldENvdW50GAIgASgFEg8KB0dldE9k",
            "ZHMYAyABKAUiZAoKR2FtZVJlc3VsdBIOCgZSZXN1bHQYASABKAkSHwoJTGlu",
            "ZXNPZGRzGAIgAygLMgwucGIuTGluZU9kZHMSFAoMU2NhdHRlckNvdW50GAMg",
            "ASgFEg8KB0FsbE9kZHMYBCABKAUigAEKEFJldHVybkdhbWVSZXN1bHQSEAoI",
            "QWxsTW9uZXkYASABKAUSEAoIR2V0TW9uZXkYAiABKAUSEQoJRnJlZUNvdW50",
            "GAMgASgFEhEKCUZyZWVSb3VuZBgEIAEoBRIiCgpHYW1lUmVzdWx0GAUgASgL",
            "Mg4ucGIuR2FtZVJlc3VsdCIaCgdUYWxrTXNnEg8KB2NvbnRlbnQYASABKAki",
            "OwoJQnJvYWRDYXN0EhAKCFBsYXllcklEGAEgASgFEhwKB1RhbGtNc2cYAiAB",
            "KAsyCy5wYi5UYWxrTXNnQgWqAgJQYmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.PlayerData), global::Pb.PlayerData.Parser, new[]{ "PlayerID", "PlayerName", "PlayerMoney" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Bet), global::Pb.Bet.Parser, new[]{ "PlayerID", "Bet_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.LineOdds), global::Pb.LineOdds.Parser, new[]{ "GetID", "GetCount", "GetOdds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.GameResult), global::Pb.GameResult.Parser, new[]{ "Result", "LinesOdds", "ScatterCount", "AllOdds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.ReturnGameResult), global::Pb.ReturnGameResult.Parser, new[]{ "AllMoney", "GetMoney", "FreeCount", "FreeRound", "GameResult" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.TalkMsg), global::Pb.TalkMsg.Parser, new[]{ "Content" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.BroadCast), global::Pb.BroadCast.Parser, new[]{ "PlayerID", "TalkMsg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///給玩家的資訊
  /// </summary>
  public sealed partial class PlayerData : pb::IMessage<PlayerData> {
    private static readonly pb::MessageParser<PlayerData> _parser = new pb::MessageParser<PlayerData>(() => new PlayerData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData(PlayerData other) : this() {
      playerID_ = other.playerID_;
      playerName_ = other.playerName_;
      playerMoney_ = other.playerMoney_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData Clone() {
      return new PlayerData(this);
    }

    /// <summary>Field number for the "PlayerID" field.</summary>
    public const int PlayerIDFieldNumber = 1;
    private int playerID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerID {
      get { return playerID_; }
      set {
        playerID_ = value;
      }
    }

    /// <summary>Field number for the "PlayerName" field.</summary>
    public const int PlayerNameFieldNumber = 2;
    private string playerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerName {
      get { return playerName_; }
      set {
        playerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PlayerMoney" field.</summary>
    public const int PlayerMoneyFieldNumber = 3;
    private int playerMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerMoney {
      get { return playerMoney_; }
      set {
        playerMoney_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerID != other.PlayerID) return false;
      if (PlayerName != other.PlayerName) return false;
      if (PlayerMoney != other.PlayerMoney) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerID != 0) hash ^= PlayerID.GetHashCode();
      if (PlayerName.Length != 0) hash ^= PlayerName.GetHashCode();
      if (PlayerMoney != 0) hash ^= PlayerMoney.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerID);
      }
      if (PlayerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PlayerName);
      }
      if (PlayerMoney != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PlayerMoney);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerID);
      }
      if (PlayerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerName);
      }
      if (PlayerMoney != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerMoney);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerData other) {
      if (other == null) {
        return;
      }
      if (other.PlayerID != 0) {
        PlayerID = other.PlayerID;
      }
      if (other.PlayerName.Length != 0) {
        PlayerName = other.PlayerName;
      }
      if (other.PlayerMoney != 0) {
        PlayerMoney = other.PlayerMoney;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerID = input.ReadInt32();
            break;
          }
          case 18: {
            PlayerName = input.ReadString();
            break;
          }
          case 24: {
            PlayerMoney = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///給伺服器下注資訊
  /// </summary>
  public sealed partial class Bet : pb::IMessage<Bet> {
    private static readonly pb::MessageParser<Bet> _parser = new pb::MessageParser<Bet>(() => new Bet());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Bet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bet(Bet other) : this() {
      playerID_ = other.playerID_;
      bet_ = other.bet_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bet Clone() {
      return new Bet(this);
    }

    /// <summary>Field number for the "PlayerID" field.</summary>
    public const int PlayerIDFieldNumber = 1;
    private int playerID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerID {
      get { return playerID_; }
      set {
        playerID_ = value;
      }
    }

    /// <summary>Field number for the "Bet" field.</summary>
    public const int Bet_FieldNumber = 2;
    private int bet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Bet_ {
      get { return bet_; }
      set {
        bet_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Bet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Bet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerID != other.PlayerID) return false;
      if (Bet_ != other.Bet_) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerID != 0) hash ^= PlayerID.GetHashCode();
      if (Bet_ != 0) hash ^= Bet_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerID);
      }
      if (Bet_ != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Bet_);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerID);
      }
      if (Bet_ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Bet_);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Bet other) {
      if (other == null) {
        return;
      }
      if (other.PlayerID != 0) {
        PlayerID = other.PlayerID;
      }
      if (other.Bet_ != 0) {
        Bet_ = other.Bet_;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerID = input.ReadInt32();
            break;
          }
          case 16: {
            Bet_ = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///單線的賠率
  /// </summary>
  public sealed partial class LineOdds : pb::IMessage<LineOdds> {
    private static readonly pb::MessageParser<LineOdds> _parser = new pb::MessageParser<LineOdds>(() => new LineOdds());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LineOdds> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LineOdds() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LineOdds(LineOdds other) : this() {
      getID_ = other.getID_;
      getCount_ = other.getCount_;
      getOdds_ = other.getOdds_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LineOdds Clone() {
      return new LineOdds(this);
    }

    /// <summary>Field number for the "GetID" field.</summary>
    public const int GetIDFieldNumber = 1;
    private int getID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GetID {
      get { return getID_; }
      set {
        getID_ = value;
      }
    }

    /// <summary>Field number for the "GetCount" field.</summary>
    public const int GetCountFieldNumber = 2;
    private int getCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GetCount {
      get { return getCount_; }
      set {
        getCount_ = value;
      }
    }

    /// <summary>Field number for the "GetOdds" field.</summary>
    public const int GetOddsFieldNumber = 3;
    private int getOdds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GetOdds {
      get { return getOdds_; }
      set {
        getOdds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LineOdds);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LineOdds other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GetID != other.GetID) return false;
      if (GetCount != other.GetCount) return false;
      if (GetOdds != other.GetOdds) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GetID != 0) hash ^= GetID.GetHashCode();
      if (GetCount != 0) hash ^= GetCount.GetHashCode();
      if (GetOdds != 0) hash ^= GetOdds.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (GetID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(GetID);
      }
      if (GetCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(GetCount);
      }
      if (GetOdds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(GetOdds);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GetID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GetID);
      }
      if (GetCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GetCount);
      }
      if (GetOdds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GetOdds);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LineOdds other) {
      if (other == null) {
        return;
      }
      if (other.GetID != 0) {
        GetID = other.GetID;
      }
      if (other.GetCount != 0) {
        GetCount = other.GetCount;
      }
      if (other.GetOdds != 0) {
        GetOdds = other.GetOdds;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            GetID = input.ReadInt32();
            break;
          }
          case 16: {
            GetCount = input.ReadInt32();
            break;
          }
          case 24: {
            GetOdds = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///遊戲結果
  /// </summary>
  public sealed partial class GameResult : pb::IMessage<GameResult> {
    private static readonly pb::MessageParser<GameResult> _parser = new pb::MessageParser<GameResult>(() => new GameResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameResult(GameResult other) : this() {
      result_ = other.result_;
      linesOdds_ = other.linesOdds_.Clone();
      scatterCount_ = other.scatterCount_;
      allOdds_ = other.allOdds_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameResult Clone() {
      return new GameResult(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LinesOdds" field.</summary>
    public const int LinesOddsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Pb.LineOdds> _repeated_linesOdds_codec
        = pb::FieldCodec.ForMessage(18, global::Pb.LineOdds.Parser);
    private readonly pbc::RepeatedField<global::Pb.LineOdds> linesOdds_ = new pbc::RepeatedField<global::Pb.LineOdds>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Pb.LineOdds> LinesOdds {
      get { return linesOdds_; }
    }

    /// <summary>Field number for the "ScatterCount" field.</summary>
    public const int ScatterCountFieldNumber = 3;
    private int scatterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ScatterCount {
      get { return scatterCount_; }
      set {
        scatterCount_ = value;
      }
    }

    /// <summary>Field number for the "AllOdds" field.</summary>
    public const int AllOddsFieldNumber = 4;
    private int allOdds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AllOdds {
      get { return allOdds_; }
      set {
        allOdds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!linesOdds_.Equals(other.linesOdds_)) return false;
      if (ScatterCount != other.ScatterCount) return false;
      if (AllOdds != other.AllOdds) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      hash ^= linesOdds_.GetHashCode();
      if (ScatterCount != 0) hash ^= ScatterCount.GetHashCode();
      if (AllOdds != 0) hash ^= AllOdds.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Result);
      }
      linesOdds_.WriteTo(output, _repeated_linesOdds_codec);
      if (ScatterCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ScatterCount);
      }
      if (AllOdds != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(AllOdds);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      size += linesOdds_.CalculateSize(_repeated_linesOdds_codec);
      if (ScatterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ScatterCount);
      }
      if (AllOdds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllOdds);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameResult other) {
      if (other == null) {
        return;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      linesOdds_.Add(other.linesOdds_);
      if (other.ScatterCount != 0) {
        ScatterCount = other.ScatterCount;
      }
      if (other.AllOdds != 0) {
        AllOdds = other.AllOdds;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Result = input.ReadString();
            break;
          }
          case 18: {
            linesOdds_.AddEntriesFrom(input, _repeated_linesOdds_codec);
            break;
          }
          case 24: {
            ScatterCount = input.ReadInt32();
            break;
          }
          case 32: {
            AllOdds = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///金額和遊戲結果
  /// </summary>
  public sealed partial class ReturnGameResult : pb::IMessage<ReturnGameResult> {
    private static readonly pb::MessageParser<ReturnGameResult> _parser = new pb::MessageParser<ReturnGameResult>(() => new ReturnGameResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReturnGameResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnGameResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnGameResult(ReturnGameResult other) : this() {
      allMoney_ = other.allMoney_;
      getMoney_ = other.getMoney_;
      freeCount_ = other.freeCount_;
      freeRound_ = other.freeRound_;
      GameResult = other.gameResult_ != null ? other.GameResult.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnGameResult Clone() {
      return new ReturnGameResult(this);
    }

    /// <summary>Field number for the "AllMoney" field.</summary>
    public const int AllMoneyFieldNumber = 1;
    private int allMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AllMoney {
      get { return allMoney_; }
      set {
        allMoney_ = value;
      }
    }

    /// <summary>Field number for the "GetMoney" field.</summary>
    public const int GetMoneyFieldNumber = 2;
    private int getMoney_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GetMoney {
      get { return getMoney_; }
      set {
        getMoney_ = value;
      }
    }

    /// <summary>Field number for the "FreeCount" field.</summary>
    public const int FreeCountFieldNumber = 3;
    private int freeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FreeCount {
      get { return freeCount_; }
      set {
        freeCount_ = value;
      }
    }

    /// <summary>Field number for the "FreeRound" field.</summary>
    public const int FreeRoundFieldNumber = 4;
    private int freeRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FreeRound {
      get { return freeRound_; }
      set {
        freeRound_ = value;
      }
    }

    /// <summary>Field number for the "GameResult" field.</summary>
    public const int GameResultFieldNumber = 5;
    private global::Pb.GameResult gameResult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Pb.GameResult GameResult {
      get { return gameResult_; }
      set {
        gameResult_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReturnGameResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReturnGameResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AllMoney != other.AllMoney) return false;
      if (GetMoney != other.GetMoney) return false;
      if (FreeCount != other.FreeCount) return false;
      if (FreeRound != other.FreeRound) return false;
      if (!object.Equals(GameResult, other.GameResult)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AllMoney != 0) hash ^= AllMoney.GetHashCode();
      if (GetMoney != 0) hash ^= GetMoney.GetHashCode();
      if (FreeCount != 0) hash ^= FreeCount.GetHashCode();
      if (FreeRound != 0) hash ^= FreeRound.GetHashCode();
      if (gameResult_ != null) hash ^= GameResult.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AllMoney != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AllMoney);
      }
      if (GetMoney != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(GetMoney);
      }
      if (FreeCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FreeCount);
      }
      if (FreeRound != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FreeRound);
      }
      if (gameResult_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GameResult);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AllMoney != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllMoney);
      }
      if (GetMoney != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GetMoney);
      }
      if (FreeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FreeCount);
      }
      if (FreeRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FreeRound);
      }
      if (gameResult_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameResult);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReturnGameResult other) {
      if (other == null) {
        return;
      }
      if (other.AllMoney != 0) {
        AllMoney = other.AllMoney;
      }
      if (other.GetMoney != 0) {
        GetMoney = other.GetMoney;
      }
      if (other.FreeCount != 0) {
        FreeCount = other.FreeCount;
      }
      if (other.FreeRound != 0) {
        FreeRound = other.FreeRound;
      }
      if (other.gameResult_ != null) {
        if (gameResult_ == null) {
          gameResult_ = new global::Pb.GameResult();
        }
        GameResult.MergeFrom(other.GameResult);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            AllMoney = input.ReadInt32();
            break;
          }
          case 16: {
            GetMoney = input.ReadInt32();
            break;
          }
          case 24: {
            FreeCount = input.ReadInt32();
            break;
          }
          case 32: {
            FreeRound = input.ReadInt32();
            break;
          }
          case 42: {
            if (gameResult_ == null) {
              gameResult_ = new global::Pb.GameResult();
            }
            input.ReadMessage(gameResult_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///聊天訊息
  /// </summary>
  public sealed partial class TalkMsg : pb::IMessage<TalkMsg> {
    private static readonly pb::MessageParser<TalkMsg> _parser = new pb::MessageParser<TalkMsg>(() => new TalkMsg());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TalkMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TalkMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TalkMsg(TalkMsg other) : this() {
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TalkMsg Clone() {
      return new TalkMsg(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TalkMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TalkMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TalkMsg other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///廣播
  /// </summary>
  public sealed partial class BroadCast : pb::IMessage<BroadCast> {
    private static readonly pb::MessageParser<BroadCast> _parser = new pb::MessageParser<BroadCast>(() => new BroadCast());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BroadCast> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.MsgReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BroadCast() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BroadCast(BroadCast other) : this() {
      playerID_ = other.playerID_;
      TalkMsg = other.talkMsg_ != null ? other.TalkMsg.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BroadCast Clone() {
      return new BroadCast(this);
    }

    /// <summary>Field number for the "PlayerID" field.</summary>
    public const int PlayerIDFieldNumber = 1;
    private int playerID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerID {
      get { return playerID_; }
      set {
        playerID_ = value;
      }
    }

    /// <summary>Field number for the "TalkMsg" field.</summary>
    public const int TalkMsgFieldNumber = 2;
    private global::Pb.TalkMsg talkMsg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Pb.TalkMsg TalkMsg {
      get { return talkMsg_; }
      set {
        talkMsg_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BroadCast);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BroadCast other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerID != other.PlayerID) return false;
      if (!object.Equals(TalkMsg, other.TalkMsg)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerID != 0) hash ^= PlayerID.GetHashCode();
      if (talkMsg_ != null) hash ^= TalkMsg.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerID);
      }
      if (talkMsg_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TalkMsg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerID);
      }
      if (talkMsg_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TalkMsg);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BroadCast other) {
      if (other == null) {
        return;
      }
      if (other.PlayerID != 0) {
        PlayerID = other.PlayerID;
      }
      if (other.talkMsg_ != null) {
        if (talkMsg_ == null) {
          talkMsg_ = new global::Pb.TalkMsg();
        }
        TalkMsg.MergeFrom(other.TalkMsg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerID = input.ReadInt32();
            break;
          }
          case 18: {
            if (talkMsg_ == null) {
              talkMsg_ = new global::Pb.TalkMsg();
            }
            input.ReadMessage(talkMsg_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
