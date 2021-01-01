using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssTrackChanges {

	public interface IssTrackChanges {

		/// <summary>
		/// . Obtains the difference between two JSON objects, either an Entity or a Structure. .
		/// </summary>
		/// <param name="ssOriginalObject">. Object in its original state (no change). .</param>
		/// <param name="ssModifiedObject">. Object in its modified state (with change). .</param>
		/// <param name="ssIgnoreItems">. List of items / attributes to be ignored by the comparison. .</param>
		/// <param name="ssResultProcessing">. Object containing attributes that have different values between the Original and Modified states or when there is an error, it returns true and the error message.
		/// </param>
		void MssGetDiff(string ssOriginalObject, string ssModifiedObject, RLIgnoreItemRecordList ssIgnoreItems, out RCObjectChangedErrorRecord ssResultProcessing);

	} // IssTrackChanges

} // OutSystems.NssTrackChanges
