
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Linq;


namespace cfg.test
{
    public partial class TbMultiIndexList
    {
        private readonly System.Func<string, int, int, ByteBuf> _byteBufLoader;
        private readonly string _fileName;
        private Tables _tables;



        private System.Collections.Generic.Dictionary<int, test.MultiIndexList> _dataMap_id1;
        private System.Collections.Generic.Dictionary<int, int> _offsetMap_id1;
        private System.Collections.Generic.Dictionary<int, int> _lengthMap_id1;
        private System.Collections.Generic.Dictionary<long, test.MultiIndexList> _dataMap_id2;
        private System.Collections.Generic.Dictionary<long, int> _offsetMap_id2;
        private System.Collections.Generic.Dictionary<long, int> _lengthMap_id2;
        private System.Collections.Generic.Dictionary<string, test.MultiIndexList> _dataMap_id3;
        private System.Collections.Generic.Dictionary<string, int> _offsetMap_id3;
        private System.Collections.Generic.Dictionary<string, int> _lengthMap_id3;

        public TbMultiIndexList(ByteBuf _buf, string fileName, System.Func<string, int, int, ByteBuf> byteBufLoader)
        {
            _dataMap_id1 = new System.Collections.Generic.Dictionary<int, test.MultiIndexList>();
            _offsetMap_id1 = new System.Collections.Generic.Dictionary<int, int>();
            _lengthMap_id1 = new System.Collections.Generic.Dictionary<int, int>();
            _dataMap_id2 = new System.Collections.Generic.Dictionary<long, test.MultiIndexList>();
            _offsetMap_id2 = new System.Collections.Generic.Dictionary<long, int>();
            _lengthMap_id2 = new System.Collections.Generic.Dictionary<long, int>();
            _dataMap_id3 = new System.Collections.Generic.Dictionary<string, test.MultiIndexList>();
            _offsetMap_id3 = new System.Collections.Generic.Dictionary<string, int>();
            _lengthMap_id3 = new System.Collections.Generic.Dictionary<string, int>();
            _fileName = fileName;
            _byteBufLoader = byteBufLoader;
            
            for (int n = _buf.ReadSize(); n > 0; --n)
            {   
                int key_id1;
                key_id1 = _buf.ReadInt();
                long key_id2;
                key_id2 = _buf.ReadLong();
                string key_id3;
                key_id3 = _buf.ReadString();

                int offset = _buf.ReadInt();
                int length = _buf.ReadInt();

                _offsetMap_id1.Add(key_id1, offset);
                _lengthMap_id1.Add(key_id1, length);
                _offsetMap_id2.Add(key_id2, offset);
                _lengthMap_id2.Add(key_id2, length);
                _offsetMap_id3.Add(key_id3, offset);
                _lengthMap_id3.Add(key_id3, length);
            }
        }
        public test.MultiIndexList GetById1OrDefault(int key) => this.GetById1(key) ?? default;
        public test.MultiIndexList GetById1(int key)
        {
            if (_dataMap_id1.TryGetValue(key, out var v))
            {
                return v;
            }
            int offset = _offsetMap_id1[key];
            int length = _lengthMap_id1[key];
            ByteBuf buf = this._byteBufLoader(this._fileName, offset, length);
            v = test.MultiIndexList.DeserializeMultiIndexList(buf);;
            _dataMap_id1[v.Id1] = v;
            _dataMap_id2[v.Id2] = v;
            _dataMap_id3[v.Id3] = v;
            v.ResolveRef(_tables);
            return v;
        }
        public test.MultiIndexList GetById2OrDefault(long key) => this.GetById2(key) ?? default;
        public test.MultiIndexList GetById2(long key)
        {
            if (_dataMap_id2.TryGetValue(key, out var v))
            {
                return v;
            }
            int offset = _offsetMap_id2[key];
            int length = _lengthMap_id2[key];
            ByteBuf buf = this._byteBufLoader(this._fileName, offset, length);
            v = test.MultiIndexList.DeserializeMultiIndexList(buf);;
            _dataMap_id1[v.Id1] = v;
            _dataMap_id2[v.Id2] = v;
            _dataMap_id3[v.Id3] = v;
            v.ResolveRef(_tables);
            return v;
        }
        public test.MultiIndexList GetById3OrDefault(string key) => this.GetById3(key) ?? default;
        public test.MultiIndexList GetById3(string key)
        {
            if (_dataMap_id3.TryGetValue(key, out var v))
            {
                return v;
            }
            int offset = _offsetMap_id3[key];
            int length = _lengthMap_id3[key];
            ByteBuf buf = this._byteBufLoader(this._fileName, offset, length);
            v = test.MultiIndexList.DeserializeMultiIndexList(buf);;
            _dataMap_id1[v.Id1] = v;
            _dataMap_id2[v.Id2] = v;
            _dataMap_id3[v.Id3] = v;
            v.ResolveRef(_tables);
            return v;
        }
                
        public void LoadAll(System.Action<int, long, string,test.MultiIndexList> onLoad = null)
        {
            //用第一个Index来索引即可
            foreach(var (key,offset) in _offsetMap_id1)
            {
                var value = this.GetById1(key);
                if (value != null)
                {
                    //把所有的索引值都传进去
                    onLoad?.Invoke(value.Id1, value.Id2, value.Id3, value);
                }
            }
        }
        public void ResolveRef(Tables tables)
        {
            this._tables = tables;
        }
    }

}
