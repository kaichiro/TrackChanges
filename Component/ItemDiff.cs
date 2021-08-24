using System.Collections.Generic;

namespace OutSystems.NssTrackChanges.Component
{
    public class ItemDiff
    {
        public string AttributeName { get; set; }
        public List<string> Values = new List<string>();
    }
}
