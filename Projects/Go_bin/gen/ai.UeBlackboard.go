
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

type AiUeBlackboard struct {
    Id int32
    NodeName string
    FlowAbortMode int32
    NotifyObserver int32
    BlackboardKey string
    KeyQuery interface{}
}

const TypeId_AiUeBlackboard = -315297507

func (*AiUeBlackboard) GetTypeId() int32 {
    return -315297507
}

func NewAiUeBlackboard(_buf *luban.ByteBuf) (_v *AiUeBlackboard, err error) {
    _v = &AiUeBlackboard{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.FlowAbortMode, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NotifyObserver, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.BlackboardKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.KeyQuery, err = NewAiKeyQueryOperator(_buf); err != nil { err = errors.New("error"); return } }
    return
}
