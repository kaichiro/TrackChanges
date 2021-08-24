using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;
using System.Collections.Generic;
using OutSystems.NssTrackChanges.Component;
using OutSystems.NssTrackChanges.ComponentV2;

namespace OutSystems.NssTrackChanges
{

    public class CssTrackChanges : IssTrackChanges
    {

        /// <summary>
        /// . Obtains the difference between two JSON objects, either an Entity or a Structure. .
        /// </summary>
        /// <param name="ssOriginalObject">. Object in its original state (no change). .</param>
        /// <param name="ssModifiedObject">. Object in its modified state (with change). .</param>
        /// <param name="ssIgnoreItems">. List of items / attributes to be ignored by the comparison...</param>
        /// <param name="ssResultProcessing">. Object containing attributes that have different values between the Original and Modified states or when there is an error, it returns true and the error message.</param>
        public void MssGetDiff(string ssOriginalObject, string ssModifiedObject, RLIgnoreItemRecordList ssIgnoreItems, out RCObjectChangedErrorRecord ssResultProcessing)
        {

            int TrackChanges_Version = 2;

            RCObjectChangedErrorRecord rCObjectChangedErrorRecord = new RCObjectChangedErrorRecord(null);

            try
            {
                List<string> ignoreAttrib = new List<string>();
                foreach (RCIgnoreItemRecord rCIgnoreItemRecord in ssIgnoreItems.Data)
                {
                    ignoreAttrib.Add(rCIgnoreItemRecord.ssSTIgnoreItem.ssItem);
                }

                switch (TrackChanges_Version)
                {
                    case 1:
                        TrackChangesInvok trackChangesInvok = new TrackChangesInvok(ssOriginalObject, ssModifiedObject, ignoreAttrib);

                        ObjectDiff objectDiff = trackChangesInvok.DiffJSON();

                        rCObjectChangedErrorRecord.ssSTObjectChanged.ssName = objectDiff.ObjectName;
                        objectDiff.Items.ForEach(delegate (ItemDiff itemDiff)
                        {
                            RCItemChangedRecord rCItemChangedRecord = new RCItemChangedRecord();
                            rCItemChangedRecord.ssSTItemChanged.ssAttribute = itemDiff.AttributeName;
                            rCItemChangedRecord.ssSTItemChanged.ssOriginalValue = itemDiff.Values[0];
                            rCItemChangedRecord.ssSTItemChanged.ssModifieldValue = itemDiff.Values[1];
                            rCObjectChangedErrorRecord.ssSTObjectChanged.ssAttributies.Append(record: rCItemChangedRecord);
                        });

                        break;

                    case 2:

                        TrackChangesV2.TrackChanges trackChangesV2 = 
                            new TrackChangesV2.TrackChanges(originalOjbectJSON: ssOriginalObject, modifieldObjectJSON: ssModifiedObject, ignoreFields: ignoreAttrib);

                        trackChangesV2.ProcessTrackChanges().ForEach(delegate (TrackChangesV2.ItemMerge itemMerge) 
                        {
                            RCItemChangedRecord rCItemChangedRecord = new RCItemChangedRecord();
                            rCItemChangedRecord.ssSTItemChanged.ssAttribute = itemMerge.Name;
                            rCItemChangedRecord.ssSTItemChanged.ssOriginalValue = itemMerge.ActualValue;
                            rCItemChangedRecord.ssSTItemChanged.ssModifieldValue = itemMerge.NewValue;
                            rCObjectChangedErrorRecord.ssSTObjectChanged.ssAttributies.Append(record: rCItemChangedRecord);
                        });

                        break;
                }


                ssResultProcessing = rCObjectChangedErrorRecord;
            }
            catch (Exception e)
            {
                rCObjectChangedErrorRecord.ssSTError.ssIsError = true;
                rCObjectChangedErrorRecord.ssSTError.ssErrorMessage = string.Concat(e.Message);
                ssResultProcessing = rCObjectChangedErrorRecord;
            }
            // TODO: Write implementation for action
        } // MssGetDiff
    } // CssTrackChanges
} // OutSystems.NssTrackChanges
