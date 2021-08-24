using System.Collections.Generic;
using TrackChangesV2;

namespace OutSystems.NssTrackChanges.ComponentV2
{
    public class HelperTrackChangesV2
    {
        private readonly string fOriginalObjectJSON;
        private readonly string fModifieldObjectJSON;
        private readonly List<string> fIgnoreFields;

        public HelperTrackChangesV2(string OriginalObjectJSON, string ModifieldObjectJSON, List<string> IgnoreFields)
        {
            fOriginalObjectJSON = OriginalObjectJSON;
            fModifieldObjectJSON = ModifieldObjectJSON;
            fIgnoreFields = IgnoreFields ?? new List<string>();
        }

        public List<ItemMerge> Process() =>
            new TrackChangesV2.TrackChanges(
                originalOjbectJSON: fOriginalObjectJSON, 
                modifieldObjectJSON: fModifieldObjectJSON, 
                ignoreFields: fIgnoreFields
            ).ProcessTrackChanges();
    }
}
