
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


public final class ChooseSkill extends cfg.ai.Task {
    public ChooseSkill(JsonObject _buf) { 
        super(_buf);
        targetActorKey = _buf.get("target_actor_key").getAsString();
        resultSkillIdKey = _buf.get("result_skill_id_key").getAsString();
    }

    public static ChooseSkill deserialize(JsonObject _buf) {
            return new cfg.ai.ChooseSkill(_buf);
    }

    public final String targetActorKey;
    public final String resultSkillIdKey;

    public static final int __ID__ = -918812268;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + nodeName + ","
        + "(format_field_name __code_style field.name):" + decorators + ","
        + "(format_field_name __code_style field.name):" + services + ","
        + "(format_field_name __code_style field.name):" + ignoreRestartSelf + ","
        + "(format_field_name __code_style field.name):" + targetActorKey + ","
        + "(format_field_name __code_style field.name):" + resultSkillIdKey + ","
        + "}";
    }
}
