
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.ai
{
public sealed partial class BlackboardKeyData : ai.KeyData
{
    public BlackboardKeyData(ByteBuf _buf)  : base(_buf) 
    {
        Value = _buf.ReadString();
    }

    public static BlackboardKeyData DeserializeBlackboardKeyData(ByteBuf _buf)
    {
        return new ai.BlackboardKeyData(_buf);
    }

    public readonly string Value;
   
    public const int __ID__ = 1517269500;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "value:" + Value + ","
        + "}";
    }
}

}