using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssTrackChanges {

	/// <summary>
	/// Structure <code>RCIgnoreItemRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIgnoreItemRecord: ISerializable, ITypedRecord<RCIgnoreItemRecord> {
		internal static readonly GlobalObjectKey IdIgnoreItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*audNMxvFjdlC3sGQZTx6tQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IgnoreItem")]
		public STIgnoreItemStructure ssSTIgnoreItem;


		public static implicit operator STIgnoreItemStructure(RCIgnoreItemRecord r) {
			return r.ssSTIgnoreItem;
		}

		public static implicit operator RCIgnoreItemRecord(STIgnoreItemStructure r) {
			RCIgnoreItemRecord res = new RCIgnoreItemRecord(null);
			res.ssSTIgnoreItem = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIgnoreItemRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTIgnoreItem = new STIgnoreItemStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTIgnoreItem.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTIgnoreItem.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIgnoreItemRecord r) {
			this = r;
		}


		public static bool operator == (RCIgnoreItemRecord a, RCIgnoreItemRecord b) {
			if (a.ssSTIgnoreItem != b.ssSTIgnoreItem) return false;
			return true;
		}

		public static bool operator != (RCIgnoreItemRecord a, RCIgnoreItemRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIgnoreItemRecord)) return false;
			return (this == (RCIgnoreItemRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTIgnoreItem.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIgnoreItemRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTIgnoreItem = new STIgnoreItemStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTIgnoreItem", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTIgnoreItem' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTIgnoreItem = (STIgnoreItemStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTIgnoreItem.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTIgnoreItem.InternalRecursiveSave();
		}


		public RCIgnoreItemRecord Duplicate() {
			RCIgnoreItemRecord t;
			t.ssSTIgnoreItem = (STIgnoreItemStructure) this.ssSTIgnoreItem.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTIgnoreItem.ToXml(this, recordElem, "IgnoreItem", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "ignoreitem") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IgnoreItem")) variable.Value = ssSTIgnoreItem; else variable.Optimized = true;
				variable.SetFieldName("ignoreitem");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIgnoreItem) {
				return ssSTIgnoreItem;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTIgnoreItem.FillFromOther((IRecord) other.AttributeGet(IdIgnoreItem));
		}
		public bool IsDefault() {
			RCIgnoreItemRecord defaultStruct = new RCIgnoreItemRecord(null);
			if (this.ssSTIgnoreItem != defaultStruct.ssSTIgnoreItem) return false;
			return true;
		}
	} // RCIgnoreItemRecord

	/// <summary>
	/// Structure <code>RCItemChangedRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCItemChangedRecord: ISerializable, ITypedRecord<RCItemChangedRecord> {
		internal static readonly GlobalObjectKey IdItemChanged = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0M4DWxqP6ZD41hrFUTLJEA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ItemChanged")]
		public STItemChangedStructure ssSTItemChanged;


		public static implicit operator STItemChangedStructure(RCItemChangedRecord r) {
			return r.ssSTItemChanged;
		}

		public static implicit operator RCItemChangedRecord(STItemChangedStructure r) {
			RCItemChangedRecord res = new RCItemChangedRecord(null);
			res.ssSTItemChanged = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCItemChangedRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTItemChanged = new STItemChangedStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTItemChanged.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTItemChanged.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCItemChangedRecord r) {
			this = r;
		}


		public static bool operator == (RCItemChangedRecord a, RCItemChangedRecord b) {
			if (a.ssSTItemChanged != b.ssSTItemChanged) return false;
			return true;
		}

		public static bool operator != (RCItemChangedRecord a, RCItemChangedRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCItemChangedRecord)) return false;
			return (this == (RCItemChangedRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTItemChanged.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCItemChangedRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTItemChanged = new STItemChangedStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTItemChanged", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTItemChanged' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTItemChanged = (STItemChangedStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTItemChanged.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTItemChanged.InternalRecursiveSave();
		}


		public RCItemChangedRecord Duplicate() {
			RCItemChangedRecord t;
			t.ssSTItemChanged = (STItemChangedStructure) this.ssSTItemChanged.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTItemChanged.ToXml(this, recordElem, "ItemChanged", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "itemchanged") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemChanged")) variable.Value = ssSTItemChanged; else variable.Optimized = true;
				variable.SetFieldName("itemchanged");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdItemChanged) {
				return ssSTItemChanged;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTItemChanged.FillFromOther((IRecord) other.AttributeGet(IdItemChanged));
		}
		public bool IsDefault() {
			RCItemChangedRecord defaultStruct = new RCItemChangedRecord(null);
			if (this.ssSTItemChanged != defaultStruct.ssSTItemChanged) return false;
			return true;
		}
	} // RCItemChangedRecord

	/// <summary>
	/// Structure <code>RCObjectChangedRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCObjectChangedRecord: ISerializable, ITypedRecord<RCObjectChangedRecord> {
		internal static readonly GlobalObjectKey IdObjectChanged = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fiqyA_Z3f2qop8rM3+lvmQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ObjectChanged")]
		public STObjectChangedStructure ssSTObjectChanged;


		public static implicit operator STObjectChangedStructure(RCObjectChangedRecord r) {
			return r.ssSTObjectChanged;
		}

		public static implicit operator RCObjectChangedRecord(STObjectChangedStructure r) {
			RCObjectChangedRecord res = new RCObjectChangedRecord(null);
			res.ssSTObjectChanged = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCObjectChangedRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTObjectChanged = new STObjectChangedStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTObjectChanged.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTObjectChanged.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCObjectChangedRecord r) {
			this = r;
		}


		public static bool operator == (RCObjectChangedRecord a, RCObjectChangedRecord b) {
			if (a.ssSTObjectChanged != b.ssSTObjectChanged) return false;
			return true;
		}

		public static bool operator != (RCObjectChangedRecord a, RCObjectChangedRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCObjectChangedRecord)) return false;
			return (this == (RCObjectChangedRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTObjectChanged.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCObjectChangedRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTObjectChanged = new STObjectChangedStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTObjectChanged", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTObjectChanged' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTObjectChanged = (STObjectChangedStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTObjectChanged.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTObjectChanged.InternalRecursiveSave();
		}


		public RCObjectChangedRecord Duplicate() {
			RCObjectChangedRecord t;
			t.ssSTObjectChanged = (STObjectChangedStructure) this.ssSTObjectChanged.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTObjectChanged.ToXml(this, recordElem, "ObjectChanged", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "objectchanged") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ObjectChanged")) variable.Value = ssSTObjectChanged; else variable.Optimized = true;
				variable.SetFieldName("objectchanged");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdObjectChanged) {
				return ssSTObjectChanged;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTObjectChanged.FillFromOther((IRecord) other.AttributeGet(IdObjectChanged));
		}
		public bool IsDefault() {
			RCObjectChangedRecord defaultStruct = new RCObjectChangedRecord(null);
			if (this.ssSTObjectChanged != defaultStruct.ssSTObjectChanged) return false;
			return true;
		}
	} // RCObjectChangedRecord

	/// <summary>
	/// Structure <code>RCErrorRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCErrorRecord: ISerializable, ITypedRecord<RCErrorRecord> {
		internal static readonly GlobalObjectKey IdError = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ImBN4o0eIHrnt+JdvDDaJg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Error")]
		public STErrorStructure ssSTError;


		public static implicit operator STErrorStructure(RCErrorRecord r) {
			return r.ssSTError;
		}

		public static implicit operator RCErrorRecord(STErrorStructure r) {
			RCErrorRecord res = new RCErrorRecord(null);
			res.ssSTError = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCErrorRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTError = new STErrorStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTError.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTError.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCErrorRecord r) {
			this = r;
		}


		public static bool operator == (RCErrorRecord a, RCErrorRecord b) {
			if (a.ssSTError != b.ssSTError) return false;
			return true;
		}

		public static bool operator != (RCErrorRecord a, RCErrorRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCErrorRecord)) return false;
			return (this == (RCErrorRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTError.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCErrorRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTError = new STErrorStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTError", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTError' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTError = (STErrorStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTError.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTError.InternalRecursiveSave();
		}


		public RCErrorRecord Duplicate() {
			RCErrorRecord t;
			t.ssSTError = (STErrorStructure) this.ssSTError.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTError.ToXml(this, recordElem, "Error", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "error") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Error")) variable.Value = ssSTError; else variable.Optimized = true;
				variable.SetFieldName("error");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdError) {
				return ssSTError;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTError.FillFromOther((IRecord) other.AttributeGet(IdError));
		}
		public bool IsDefault() {
			RCErrorRecord defaultStruct = new RCErrorRecord(null);
			if (this.ssSTError != defaultStruct.ssSTError) return false;
			return true;
		}
	} // RCErrorRecord

	/// <summary>
	/// Structure <code>RCObjectChangedErrorRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCObjectChangedErrorRecord: ISerializable, ITypedRecord<RCObjectChangedErrorRecord> {
		internal static readonly GlobalObjectKey IdObjectChanged = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fiqyA_Z3f2qop8rM3+lvmQ");
		internal static readonly GlobalObjectKey IdError = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ImBN4o0eIHrnt+JdvDDaJg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ObjectChanged")]
		public STObjectChangedStructure ssSTObjectChanged;

		[System.Xml.Serialization.XmlElement("Error")]
		public STErrorStructure ssSTError;


		public BitArray OptimizedAttributes;

		public RCObjectChangedErrorRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTObjectChanged = new STObjectChangedStructure(null);
			ssSTError = new STErrorStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[2];
			all[0] = null;
			all[1] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTObjectChanged.OptimizedAttributes = value[0];
					ssSTError.OptimizedAttributes = value[1];
				}
			}
			get {
				BitArray[] all = new BitArray[2];
				all[0] = null;
				all[1] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTObjectChanged.Read(r, ref index);
			ssSTError.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCObjectChangedErrorRecord r) {
			this = r;
		}


		public static bool operator == (RCObjectChangedErrorRecord a, RCObjectChangedErrorRecord b) {
			if (a.ssSTObjectChanged != b.ssSTObjectChanged) return false;
			if (a.ssSTError != b.ssSTError) return false;
			return true;
		}

		public static bool operator != (RCObjectChangedErrorRecord a, RCObjectChangedErrorRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCObjectChangedErrorRecord)) return false;
			return (this == (RCObjectChangedErrorRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTObjectChanged.GetHashCode()
				^ ssSTError.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCObjectChangedErrorRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTObjectChanged = new STObjectChangedStructure(null);
			ssSTError = new STErrorStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTObjectChanged", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTObjectChanged' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTObjectChanged = (STObjectChangedStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssSTError", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTError' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTError = (STErrorStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTObjectChanged.RecursiveReset();
			ssSTError.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTObjectChanged.InternalRecursiveSave();
			ssSTError.InternalRecursiveSave();
		}


		public RCObjectChangedErrorRecord Duplicate() {
			RCObjectChangedErrorRecord t;
			t.ssSTObjectChanged = (STObjectChangedStructure) this.ssSTObjectChanged.Duplicate();
			t.ssSTError = (STErrorStructure) this.ssSTError.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTObjectChanged.ToXml(this, recordElem, "ObjectChanged", detailLevel - 1);
				ssSTError.ToXml(this, recordElem, "Error", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "objectchanged") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ObjectChanged")) variable.Value = ssSTObjectChanged; else variable.Optimized = true;
				variable.SetFieldName("objectchanged");
			} else if (head == "error") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Error")) variable.Value = ssSTError; else variable.Optimized = true;
				variable.SetFieldName("error");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdObjectChanged) {
				return ssSTObjectChanged;
			} else if (key == IdError) {
				return ssSTError;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTObjectChanged.FillFromOther((IRecord) other.AttributeGet(IdObjectChanged));
			ssSTError.FillFromOther((IRecord) other.AttributeGet(IdError));
		}
		public bool IsDefault() {
			RCObjectChangedErrorRecord defaultStruct = new RCObjectChangedErrorRecord(null);
			if (this.ssSTObjectChanged != defaultStruct.ssSTObjectChanged) return false;
			if (this.ssSTError != defaultStruct.ssSTError) return false;
			return true;
		}
	} // RCObjectChangedErrorRecord
}
