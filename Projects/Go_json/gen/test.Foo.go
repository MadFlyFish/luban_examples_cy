
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestFoo struct {
    Y1 int32
    Y2 int32
    Y3 int32
}

const TypeId_TestFoo = -1147950774

func (*TestFoo) GetTypeId() int32 {
    return -1147950774
}

func NewTestFoo(_buf map[string]interface{}) (_v *TestFoo, err error) {
    _v = &TestFoo{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["y1"].(float64); !_ok_ { err = errors.New("y1 error"); return }; _v.Y1 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["y2"].(float64); !_ok_ { err = errors.New("y2 error"); return }; _v.Y2 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["y3"].(float64); !_ok_ { err = errors.New("y3 error"); return }; _v.Y3 = int32(_tempNum_) }
    return
}
