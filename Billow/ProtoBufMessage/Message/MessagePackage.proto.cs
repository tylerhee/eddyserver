//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MessagePackage/MessagePackage.proto
namespace Eddy.ProtoBufMessage
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessagePackage")]
  public partial class MessagePackage : global::ProtoBuf.IExtensible
  {
    public MessagePackage() {}
    
    private uint _category_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"category_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint category_id
    {
      get { return _category_id; }
      set { _category_id = value; }
    }
    private uint _type_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }
    private byte[] _message;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] message
    {
      get { return _message; }
      set { _message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}