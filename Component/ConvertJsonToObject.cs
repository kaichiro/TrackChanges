using System;
using System.Collections.Generic;
using System.IO;

namespace OutSystems.NssTrackChanges.Component
{
    class ConvertJsonToObject
    {
        private readonly char CHAR_DOUBLE_QUOTE = Convert.ToChar("\"");
        private readonly string STRING_DOUBLE_QUOTE = "\"";
        private readonly string originalObjectJSON;
        private readonly string modifiedObjectJSON;
        private readonly List<string> ignoreAttributies;
        private bool IsEntityType;
        private bool IsStructureType;
        public ConvertJsonToObject(string OriginalObjectJSON, string ModifiedObjectJSON, List<string> IgnoreAttributies)
        {
            originalObjectJSON = OriginalObjectJSON;
            modifiedObjectJSON = ModifiedObjectJSON;
            ignoreAttributies = IgnoreAttributies ?? new List<string>();
        }
        private string ReturnJsonTransformed() => new JsonTransform(originalObjectJSON, modifiedObjectJSON).JsonObjectDiff();
        private void WhatInstanceOf(string jsonObj)
        {
            using (StringReader reader = new StringReader(jsonObj))
            {
                string line;
                int numberLine = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    numberLine++;
                    if (numberLine == 2)
                    {
                        IsEntityType = line.Substring(line.Length - 1, 1).Equals("{");
                        IsStructureType = line.Substring(line.Length - 1, 1).Equals("[");
                        break;
                    }
                }
            }
        }
        public ObjectDiff DiffObj()
        {
            ObjectDiff objectDiff = new ObjectDiff();
            string varAttrib = null;
            using (StringReader reader = new StringReader(ReturnJsonTransformed()))
            {
                WhatInstanceOf(ReturnJsonTransformed());
                string line;
                if (IsEntityType)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line != string.Empty)
                        {
                            if ((line.Length > 1) && !line.Equals("    ],") && !line.Equals("    ]") && !line.Equals("  }"))
                            {
                                if (line.Substring(0, 3).Equals("  \""))
                                {
                                    objectDiff.ObjectName = line.Split(CHAR_DOUBLE_QUOTE)[1];
                                }
                                else
                                {
                                    if (line.Substring(0, 5).Equals("    \""))
                                    {
                                        varAttrib = line.Split(CHAR_DOUBLE_QUOTE)[1];
                                    }
                                    else
                                    {
                                        if (!IsIgnoreAttribute(varAttrib))
                                        {
                                            if (line.Substring(0, 6).Equals("      "))
                                            {
                                                string sValue = line.EndsWith(",") ? line.Substring(0, line.Length - 1).Trim() : line.Trim();
                                                sValue = (sValue.StartsWith(STRING_DOUBLE_QUOTE) && sValue.EndsWith(STRING_DOUBLE_QUOTE)) ? sValue = sValue.Substring(1, sValue.Length - 2).Trim() : sValue;
                                                ItemDiff dJsonDiffItemFIND = objectDiff.Items.Find(item => item.AttributeName == varAttrib);
                                                if (dJsonDiffItemFIND == null)
                                                {
                                                    ItemDiff itemDiff = new ItemDiff
                                                    {
                                                        AttributeName = varAttrib
                                                    };
                                                    itemDiff.Values.Add(sValue);
                                                    objectDiff.Items.Add(itemDiff);
                                                }
                                                else
                                                {
                                                    dJsonDiffItemFIND.Values.Add(sValue);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (IsStructureType)
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if ((line != null) && (line.Length > 1) && !line.Equals("  ],") && !line.Equals("  ]"))
                            {
                                if (line.Substring(0, 3).Equals("  \""))
                                {
                                    varAttrib = line.Split(CHAR_DOUBLE_QUOTE)[1];
                                }
                                else
                                {
                                    if (!IsIgnoreAttribute(varAttrib))
                                    {
                                        if (line.Substring(0, 4).Equals("    "))
                                        {
                                            string sValue = line.EndsWith(",") ? line.Substring(0, line.Length - 1).Trim() : line.Trim();
                                            sValue = (sValue.StartsWith(STRING_DOUBLE_QUOTE) && sValue.EndsWith(STRING_DOUBLE_QUOTE)) ? sValue = sValue.Substring(1, sValue.Length - 2).Trim() : sValue;
                                            ItemDiff dJsonDiffItemFIND = objectDiff.Items.Find(item => item.AttributeName == varAttrib);
                                            if (dJsonDiffItemFIND == null)
                                            {
                                                ItemDiff itemDiff = new ItemDiff
                                                {
                                                    AttributeName = varAttrib
                                                };
                                                itemDiff.Values.Add(sValue);
                                                objectDiff.Items.Add(itemDiff);
                                            }
                                            else
                                            {
                                                dJsonDiffItemFIND.Values.Add(sValue);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        objectDiff.ObjectName = "Structure";
                    }
                }
                objectDiff = NormalizeValues(objectDiff);
                if (objectDiff.Items.Count < 1)
                {
                    objectDiff = new ObjectDiff();
                }
            }
            return objectDiff;
        }
        private ObjectDiff NormalizeValues(ObjectDiff objDiff)
        {
            objDiff.Items.ForEach(delegate (ItemDiff item)
            {
                string modifValue = item.Values[0];
                switch (item.Values.Count)
                {
                    case 1:
                        item.Values.RemoveAt(0);
                        item.Values.Add(string.Empty);
                        item.Values.Add(modifValue);
                        break;
                    case 3:
                        item.Values.RemoveAt(0);
                        item.Values.RemoveAt(0);
                        item.Values.RemoveAt(0);
                        item.Values.Add(modifValue);
                        item.Values.Add(string.Empty);
                        break;
                    default:
                        break;
                }
            });
            return objDiff;
        }
        private bool IsIgnoreAttribute(string currentAttribute)
        {
            bool result = false;
            ignoreAttributies.ForEach(delegate (string attribToIgnore)
            {
                if (currentAttribute == attribToIgnore)
                    result = true;
            });
            return result;
        }
    }
}
