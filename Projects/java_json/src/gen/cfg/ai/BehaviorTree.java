
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class BehaviorTree extends AbstractBean {
    public BehaviorTree(JsonObject _buf) { 
        id = _buf.get("id").getAsInt();
        name = _buf.get("name").getAsString();
        desc = _buf.get("desc").getAsString();
        blackboardId = _buf.get("blackboard_id").getAsString();
        root = cfg.ai.ComposeNode.deserialize(_buf.get("root").getAsJsonObject());
    }

    public static BehaviorTree deserialize(JsonObject _buf) {
            return new cfg.ai.BehaviorTree(_buf);
    }

    public final int id;
    public final String name;
    public final String desc;
    public final String blackboardId;
    public final cfg.ai.ComposeNode root;

    public static final int __ID__ = 159552822;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + name + ","
        + "(format_field_name __code_style field.name):" + desc + ","
        + "(format_field_name __code_style field.name):" + blackboardId + ","
        + "(format_field_name __code_style field.name):" + root + ","
        + "}";
    }
}
