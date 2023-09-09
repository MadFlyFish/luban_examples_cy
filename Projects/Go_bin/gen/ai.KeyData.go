
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type AiKeyData struct {
}

const TypeId_AiKeyData = 1022478019

func (*AiKeyData) GetTypeId() int32 {
    return 1022478019
}

func NewAiKeyData(_buf *luban.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case -719747885: _v, err := NewAiFloatKeyData(_buf); if err != nil { return nil, errors.New("ai.floatkeydata") } else { return _v, nil }
        case -342751904: _v, err := NewAiIntKeyData(_buf); if err != nil { return nil, errors.New("ai.intkeydata") } else { return _v, nil }
        case -307888654: _v, err := NewAiStringKeyData(_buf); if err != nil { return nil, errors.New("ai.stringkeydata") } else { return _v, nil }
        case 1517269500: _v, err := NewAiBlackboardKeyData(_buf); if err != nil { return nil, errors.New("ai.blackboardkeydata") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

