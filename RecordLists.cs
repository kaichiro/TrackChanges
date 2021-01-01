using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssTrackChanges {

	/// <summary>
	/// RecordList type <code>RLIgnoreItemRecordList</code> that represents a record list of
	///  <code>IgnoreItem</code>
	/// </summary>
	[Serializable()]
	public partial class RLIgnoreItemRecordList: GenericRecordList<RCIgnoreItemRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIgnoreItemRecord GetElementDefaultValue() {
			return new RCIgnoreItemRecord("");
		}

		public T[] ToArray<T>(Func<RCIgnoreItemRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIgnoreItemRecordList recordlist, Func<RCIgnoreItemRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIgnoreItemRecordList(RCIgnoreItemRecord[] array) {
			RLIgnoreItemRecordList result = new RLIgnoreItemRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIgnoreItemRecordList ToList<T>(T[] array, Func <T, RCIgnoreItemRecord> converter) {
			RLIgnoreItemRecordList result = new RLIgnoreItemRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIgnoreItemRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIgnoreItemRecord> converter) {
			RLIgnoreItemRecordList result = new RLIgnoreItemRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIgnoreItemRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIgnoreItemRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIgnoreItemRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIgnoreItemRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIgnoreItemRecord> NewList() {
			return new RLIgnoreItemRecordList();
		}


	} // RLIgnoreItemRecordList

	/// <summary>
	/// RecordList type <code>RLItemChangedRecordList</code> that represents a record list of
	///  <code>ItemChanged</code>
	/// </summary>
	[Serializable()]
	public partial class RLItemChangedRecordList: GenericRecordList<RCItemChangedRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCItemChangedRecord GetElementDefaultValue() {
			return new RCItemChangedRecord("");
		}

		public T[] ToArray<T>(Func<RCItemChangedRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLItemChangedRecordList recordlist, Func<RCItemChangedRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLItemChangedRecordList(RCItemChangedRecord[] array) {
			RLItemChangedRecordList result = new RLItemChangedRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLItemChangedRecordList ToList<T>(T[] array, Func <T, RCItemChangedRecord> converter) {
			RLItemChangedRecordList result = new RLItemChangedRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLItemChangedRecordList FromRestList<T>(RestList<T> restList, Func <T, RCItemChangedRecord> converter) {
			RLItemChangedRecordList result = new RLItemChangedRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLItemChangedRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLItemChangedRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLItemChangedRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLItemChangedRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCItemChangedRecord> NewList() {
			return new RLItemChangedRecordList();
		}


	} // RLItemChangedRecordList

	/// <summary>
	/// RecordList type <code>RLObjectChangedRecordList</code> that represents a record list of
	///  <code>ObjectChanged</code>
	/// </summary>
	[Serializable()]
	public partial class RLObjectChangedRecordList: GenericRecordList<RCObjectChangedRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCObjectChangedRecord GetElementDefaultValue() {
			return new RCObjectChangedRecord("");
		}

		public T[] ToArray<T>(Func<RCObjectChangedRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLObjectChangedRecordList recordlist, Func<RCObjectChangedRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLObjectChangedRecordList(RCObjectChangedRecord[] array) {
			RLObjectChangedRecordList result = new RLObjectChangedRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLObjectChangedRecordList ToList<T>(T[] array, Func <T, RCObjectChangedRecord> converter) {
			RLObjectChangedRecordList result = new RLObjectChangedRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLObjectChangedRecordList FromRestList<T>(RestList<T> restList, Func <T, RCObjectChangedRecord> converter) {
			RLObjectChangedRecordList result = new RLObjectChangedRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLObjectChangedRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLObjectChangedRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLObjectChangedRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLObjectChangedRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCObjectChangedRecord> NewList() {
			return new RLObjectChangedRecordList();
		}


	} // RLObjectChangedRecordList

	/// <summary>
	/// RecordList type <code>RLErrorRecordList</code> that represents a record list of <code>Error</code>
	/// </summary>
	[Serializable()]
	public partial class RLErrorRecordList: GenericRecordList<RCErrorRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCErrorRecord GetElementDefaultValue() {
			return new RCErrorRecord("");
		}

		public T[] ToArray<T>(Func<RCErrorRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLErrorRecordList recordlist, Func<RCErrorRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLErrorRecordList(RCErrorRecord[] array) {
			RLErrorRecordList result = new RLErrorRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLErrorRecordList ToList<T>(T[] array, Func <T, RCErrorRecord> converter) {
			RLErrorRecordList result = new RLErrorRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLErrorRecordList FromRestList<T>(RestList<T> restList, Func <T, RCErrorRecord> converter) {
			RLErrorRecordList result = new RLErrorRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLErrorRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLErrorRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLErrorRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLErrorRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCErrorRecord> NewList() {
			return new RLErrorRecordList();
		}


	} // RLErrorRecordList

	/// <summary>
	/// RecordList type <code>RLObjectChangedErrorRecordList</code> that represents a record list of
	///  <code>ObjectChanged, Error</code>
	/// </summary>
	[Serializable()]
	public partial class RLObjectChangedErrorRecordList: GenericRecordList<RCObjectChangedErrorRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCObjectChangedErrorRecord GetElementDefaultValue() {
			return new RCObjectChangedErrorRecord("");
		}

		public T[] ToArray<T>(Func<RCObjectChangedErrorRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLObjectChangedErrorRecordList recordlist, Func<RCObjectChangedErrorRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLObjectChangedErrorRecordList(RCObjectChangedErrorRecord[] array) {
			RLObjectChangedErrorRecordList result = new RLObjectChangedErrorRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLObjectChangedErrorRecordList ToList<T>(T[] array, Func <T, RCObjectChangedErrorRecord> converter) {
			RLObjectChangedErrorRecordList result = new RLObjectChangedErrorRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLObjectChangedErrorRecordList FromRestList<T>(RestList<T> restList, Func <T, RCObjectChangedErrorRecord> converter) {
			RLObjectChangedErrorRecordList result = new RLObjectChangedErrorRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLObjectChangedErrorRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLObjectChangedErrorRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLObjectChangedErrorRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLObjectChangedErrorRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[2];
			def[0] = null;
			def[1] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCObjectChangedErrorRecord> NewList() {
			return new RLObjectChangedErrorRecordList();
		}


	} // RLObjectChangedErrorRecordList
}
