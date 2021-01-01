using System;
using System.Collections.Generic;

namespace OutSystems.NssTrackChanges.Component
{
    class TrackChangesInvok
    {
        private readonly string stringOriginalJSON;
        private readonly string stringModifiedJSON;
        private readonly List<string> ignoreAttributies;
        public TrackChangesInvok(string StringOriginalJSON, string StringModifiedJSON, List<string> IgnoreAttributies)
        {
            stringOriginalJSON = StringOriginalJSON;
            stringModifiedJSON = StringModifiedJSON;
            ignoreAttributies = IgnoreAttributies;
        }
        public ObjectDiff DiffJSON()
        {
            try
            {
                return new ConvertJsonToObject(stringOriginalJSON, stringModifiedJSON, ignoreAttributies).DiffObj();
            }
            catch (Exception e)
            {
                ObjectDiff objectDiff_Excetion = new ObjectDiff
                {
                    ObjectName = e.Message
                };
                return objectDiff_Excetion;
            }
        }
        public ObjectDiff TrackChanges(string StrOriginalJSON, string StrModifiedJSON, List<string> IgnoreAttribs)
        {
            try
            {
                return new ConvertJsonToObject(StrOriginalJSON, StrModifiedJSON, IgnoreAttribs).DiffObj();
            }
            catch (Exception e)
            {
                ObjectDiff objectDiff_Excetion = new ObjectDiff
                {
                    ObjectName = e.Message
                };
                return objectDiff_Excetion;
            }
        }
    }
}
