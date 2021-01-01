using JsonDiffPatchDotNet;
using Newtonsoft.Json.Linq;
using System;

namespace OutSystems.NssTrackChanges.Component
{
    class JsonTransform
    {
        private readonly string objectOriginalJSON;
        private readonly string objectModifiedJSON;
        public JsonTransform(string ObjectOriginalJSON, string ObjectModifiedJSON)
        {
            objectOriginalJSON = ObjectOriginalJSON;
            objectModifiedJSON = ObjectModifiedJSON;
        }
        public string JsonObjectDiff()
        {
            JToken jTokenOriginal = JToken.Parse(objectOriginalJSON);
            JToken jTokenModified = JToken.Parse(objectModifiedJSON);
            JToken jTokensDiff = new JsonDiffPatch().Diff(jTokenOriginal, jTokenModified);
            try
            {
                return jTokensDiff.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
