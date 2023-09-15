
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Linq;


namespace cfg.l10n
{
    public partial class TbPatchDemo
    {
        private readonly System.Func<string, int, int, ByteBuf> _byteBufLoader;
        private readonly string _fileName;
        private Tables _tables;

        private readonly System.Collections.Generic.Dictionary<int, l10n.PatchDemo> _dataMap;
        private readonly System.Collections.Generic.Dictionary<int, int> _offsetMap;
        private readonly System.Collections.Generic.Dictionary<int, int> _lengthMap;

        private readonly System.Collections.Generic.List<l10n.PatchDemo> _dataList;
    
        public TbPatchDemo(ByteBuf _buf,string fileName, System.Func<string, int, int, ByteBuf> byteBufLoader)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, l10n.PatchDemo>();
            _offsetMap = new System.Collections.Generic.Dictionary<int, int>();
            _lengthMap = new System.Collections.Generic.Dictionary<int, int>();
            _fileName = fileName;
            _byteBufLoader = byteBufLoader;
        
            for (int n = _buf.ReadSize(); n > 0; --n)
            {
                int key;
                key = _buf.ReadInt();
                int offset = _buf.ReadInt();
                int length = _buf.ReadInt();
                _offsetMap.Add(key, offset);
                _lengthMap.Add(key, length);
            }
        }

        public void LoadAll(System.Action<int,l10n.PatchDemo> onLoad = null)
        {
            foreach(var (key,offset) in _offsetMap)
		    {
                var value = this.Get(key);
                if (value != null)
			    {
				    onLoad?.Invoke(key, value);
			    }
		    }
        }

        public l10n.PatchDemo GetOrDefault(int key) => this.Get(key) ?? default;
        public l10n.PatchDemo Get(int key)
        {
            if (_dataMap.TryGetValue(key, out var v))
            {
                return v;
            }
            int offset = _offsetMap[key];
            int length = _lengthMap[key];
            ByteBuf buf = this._byteBufLoader(this._fileName, offset, length);
            v = l10n.PatchDemo.DeserializePatchDemo(buf);;
            _dataMap[key] = v;
            v.ResolveRef(_tables);
            return v;
        }
        public l10n.PatchDemo this[int key] => this.Get(key);

        public void ResolveRef(Tables tables)
        {
            this._tables = tables;
        }

    }

}
