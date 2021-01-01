using System.Collections.Generic;

namespace OutSystems.NssTrackChanges.Component
{
    public class ObjectDiff
    {
        public string ObjectName { get; set; }
        public List<ItemDiff> Items = new List<ItemDiff>();
        public override string ToString()
        {
            const string SKIP_LINE = "\r\n";
            const string ATTRIBUTE_SPACE = "  ", VALUE_SPACE = "    ";
            string _return = null;
            _return += string.Concat("Name: ", ObjectName, SKIP_LINE);
            foreach (ItemDiff item in Items)
            {
                _return += string.Concat(str0: ATTRIBUTE_SPACE, str1: "Attribute: ", str2: item.AttributeName, str3: SKIP_LINE);
                foreach (string value in item.Values)
                {
                    _return += string.Concat(str0: VALUE_SPACE, str1: "Value: ", str2: value, str3: SKIP_LINE);
                }
            }
            return _return;
        }
    }
}
