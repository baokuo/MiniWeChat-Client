//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DeleteFriendMsg.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeleteFriendReq")]
  public partial class DeleteFriendReq : global::ProtoBuf.IExtensible
  {
    public DeleteFriendReq() {}
    
    private string _friendUserId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"friendUserId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string friendUserId
    {
      get { return _friendUserId; }
      set { _friendUserId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeleteFriendRsp")]
  public partial class DeleteFriendRsp : global::ProtoBuf.IExtensible
  {
    public DeleteFriendRsp() {}
    
    private protocol.DeleteFriendRsp.ResultCode _resultCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"resultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public protocol.DeleteFriendRsp.ResultCode resultCode
    {
      get { return _resultCode; }
      set { _resultCode = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ResultCode")]
    public enum ResultCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUCCESS", Value=0)]
      SUCCESS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FAIL", Value=1)]
      FAIL = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}