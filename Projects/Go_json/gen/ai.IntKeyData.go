
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type AiIntKeyData struct {
    Value int32
}

const TypeId_AiIntKeyData = -342751904

func (*AiIntKeyData) GetTypeId() int32 {
    return -342751904
}

func NewAiIntKeyData(_buf map[string]interface{}) (_v *AiIntKeyData, err error) {
    _v = &AiIntKeyData{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["value"].(float64); !_ok_ { err = errors.New("value error"); return }; _v.Value = int32(_tempNum_) }
    return
}
