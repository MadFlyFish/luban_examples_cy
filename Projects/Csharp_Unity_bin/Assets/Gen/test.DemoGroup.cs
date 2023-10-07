
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class DemoGroup : Luban.BeanBase
{
    public DemoGroup(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadInt();
        X1_Ref = null;
        X2 = _buf.ReadInt();
        X2_Ref = null;
        X3 = _buf.ReadInt();
        X3_Ref = null;
        X4 = _buf.ReadInt();
        X5 = test.InnerGroup.DeserializeInnerGroup(_buf);
    }

    public static DemoGroup DeserializeDemoGroup(ByteBuf _buf)
    {
        return new test.DemoGroup(_buf);
    }

    public readonly int Id;
    public readonly int X1;
    public test.DemoGroup X1_Ref;
    public readonly int X2;
    public test.DemoGroup X2_Ref;
    public readonly int X3;
    public test.DemoGroup X3_Ref;
    public readonly int X4;
    public readonly test.InnerGroup X5;
   
    public const int __ID__ = -379263008;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        X1_Ref = tables.TbDemoGroupC.GetOrDefault(X1);
        X2_Ref = tables.TbDemoGroupS.GetOrDefault(X2);
        X3_Ref = tables.TbDemoGroupE.GetOrDefault(X3);
        
        X5?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x4:" + X4 + ","
        + "x5:" + X5 + ","
        + "}";
    }
}

}
