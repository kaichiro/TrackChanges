using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssTrackChanges {

	/// <summary>
	/// Structure <code>STIgnoreItemStructure</code> that represents the Service Studio structure
	///  <code>IgnoreItem</code> <p> Description: . Item to be ignored by comparison. .</p>
	/// </summary>
	[Serializable()]
	public partial struct STIgnoreItemStructure: ISerializable, ITypedRecord<STIgnoreItemStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*CbGempqtEU6Wxd3doQSnaQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Item")]
		public string ssItem;


		public BitArray OptimizedAttributes;

		public STIgnoreItemStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssItem = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssItem = r.ReadText(index++, "IgnoreItem.Item", "");
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
		public void ReadIM(STIgnoreItemStructure r) {
			this = r;
		}


		public static bool operator == (STIgnoreItemStructure a, STIgnoreItemStructure b) {
			if (a.ssItem != b.ssItem) return false;
			return true;
		}

		public static bool operator != (STIgnoreItemStructure a, STIgnoreItemStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STIgnoreItemStructure)) return false;
			return (this == (STIgnoreItemStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssItem.GetHashCode()
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

		public STIgnoreItemStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssItem = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssItem", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssItem' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssItem = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STIgnoreItemStructure Duplicate() {
			STIgnoreItemStructure t;
			t.ssItem = this.ssItem;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Item")) VarValue.AppendAttribute(recordElem, "Item", ssItem, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Item");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "item") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Item")) variable.Value = ssItem; else variable.Optimized = true;
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
			if (key == IdItem) {
				return ssItem;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssItem = (string) other.AttributeGet(IdItem);
		}
		public bool IsDefault() {
			STIgnoreItemStructure defaultStruct = new STIgnoreItemStructure(null);
			if (this.ssItem != defaultStruct.ssItem) return false;
			return true;
		}
	} // STIgnoreItemStructure

	/// <summary>
	/// Structure <code>STItemChangedStructure</code> that represents the Service Studio structure
	///  <code>ItemChanged</code> <p> Description: . Structure that contains the list of items / attribute
	/// s with different values between the Original and Modified states. .</p>
	/// </summary>
	[Serializable()]
	public partial struct STItemChangedStructure: ISerializable, ITypedRecord<STItemChangedStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAttribute = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*f1+o9JcUIE+HF1Rsb2E9Lg");
		internal static readonly GlobalObjectKey IdOriginalValue = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*gf4ORfujJEedUv7lJXMP_g");
		internal static readonly GlobalObjectKey IdModifieldValue = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*rY8EZz0U8kCLpIbXc+DlMA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Attribute")]
		public string ssAttribute;

		[System.Xml.Serialization.XmlElement("OriginalValue")]
		public string ssOriginalValue;

		[System.Xml.Serialization.XmlElement("ModifieldValue")]
		public string ssModifieldValue;


		public BitArray OptimizedAttributes;

		public STItemChangedStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAttribute = "";
			ssOriginalValue = "";
			ssModifieldValue = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAttribute = r.ReadText(index++, "ItemChanged.Attribute", "");
			ssOriginalValue = r.ReadText(index++, "ItemChanged.OriginalValue", "");
			ssModifieldValue = r.ReadText(index++, "ItemChanged.ModifieldValue", "");
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
		public void ReadIM(STItemChangedStructure r) {
			this = r;
		}


		public static bool operator == (STItemChangedStructure a, STItemChangedStructure b) {
			if (a.ssAttribute != b.ssAttribute) return false;
			if (a.ssOriginalValue != b.ssOriginalValue) return false;
			if (a.ssModifieldValue != b.ssModifieldValue) return false;
			return true;
		}

		public static bool operator != (STItemChangedStructure a, STItemChangedStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STItemChangedStructure)) return false;
			return (this == (STItemChangedStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAttribute.GetHashCode()
				^ ssOriginalValue.GetHashCode()
				^ ssModifieldValue.GetHashCode()
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

		public STItemChangedStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAttribute = "";
			ssOriginalValue = "";
			ssModifieldValue = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssAttribute", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttribute' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttribute = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssOriginalValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssOriginalValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssOriginalValue = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssModifieldValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssModifieldValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssModifieldValue = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STItemChangedStructure Duplicate() {
			STItemChangedStructure t;
			t.ssAttribute = this.ssAttribute;
			t.ssOriginalValue = this.ssOriginalValue;
			t.ssModifieldValue = this.ssModifieldValue;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attribute")) VarValue.AppendAttribute(recordElem, "Attribute", ssAttribute, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attribute");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".OriginalValue")) VarValue.AppendAttribute(recordElem, "OriginalValue", ssOriginalValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "OriginalValue");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ModifieldValue")) VarValue.AppendAttribute(recordElem, "ModifieldValue", ssModifieldValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ModifieldValue");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attribute") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attribute")) variable.Value = ssAttribute; else variable.Optimized = true;
			} else if (head == "originalvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".OriginalValue")) variable.Value = ssOriginalValue; else variable.Optimized = true;
			} else if (head == "modifieldvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ModifieldValue")) variable.Value = ssModifieldValue; else variable.Optimized = true;
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
			if (key == IdAttribute) {
				return ssAttribute;
			} else if (key == IdOriginalValue) {
				return ssOriginalValue;
			} else if (key == IdModifieldValue) {
				return ssModifieldValue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAttribute = (string) other.AttributeGet(IdAttribute);
			ssOriginalValue = (string) other.AttributeGet(IdOriginalValue);
			ssModifieldValue = (string) other.AttributeGet(IdModifieldValue);
		}
		public bool IsDefault() {
			STItemChangedStructure defaultStruct = new STItemChangedStructure(null);
			if (this.ssAttribute != defaultStruct.ssAttribute) return false;
			if (this.ssOriginalValue != defaultStruct.ssOriginalValue) return false;
			if (this.ssModifieldValue != defaultStruct.ssModifieldValue) return false;
			return true;
		}
	} // STItemChangedStructure

	/// <summary>
	/// Structure <code>STObjectChangedStructure</code> that represents the Service Studio structure
	///  <code>ObjectChanged</code> <p> Description: . Structure that contains the attributes / fields wit
	/// h different values between the Original and Modified states. .</p>
	/// </summary>
	[Serializable()]
	public partial struct STObjectChangedStructure: ISerializable, ITypedRecord<STObjectChangedStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*VeTEVTkqy0iJWp4hoxyYTA");
		internal static readonly GlobalObjectKey IdAttributies = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*f2T2pa6d90O1PmkA1201Xw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("Attributies")]
		public RLItemChangedRecordList ssAttributies;


		public BitArray OptimizedAttributes;

		public STObjectChangedStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssAttributies = new RLItemChangedRecordList();
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssName = r.ReadText(index++, "ObjectChanged.Name", "");
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
		public void ReadIM(STObjectChangedStructure r) {
			this = r;
		}


		public static bool operator == (STObjectChangedStructure a, STObjectChangedStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssAttributies != b.ssAttributies) return false;
			return true;
		}

		public static bool operator != (STObjectChangedStructure a, STObjectChangedStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STObjectChangedStructure)) return false;
			return (this == (STObjectChangedStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssAttributies.GetHashCode()
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

		public STObjectChangedStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssAttributies = new RLItemChangedRecordList();
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttributies", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttributies' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttributies = (RLItemChangedRecordList) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssAttributies.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssAttributies.InternalRecursiveSave();
		}


		public STObjectChangedStructure Duplicate() {
			STObjectChangedStructure t;
			t.ssName = this.ssName;
			t.ssAttributies = (RLItemChangedRecordList) this.ssAttributies.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				ssAttributies.ToXml(this, recordElem, "Attributies", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "attributies") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attributies")) variable.Value = ssAttributies; else variable.Optimized = true;
				variable.SetFieldName("attributies");
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
			if (key == IdName) {
				return ssName;
			} else if (key == IdAttributies) {
				return ssAttributies;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssAttributies = new RLItemChangedRecordList();
			ssAttributies.FillFromOther((IOSList) other.AttributeGet(IdAttributies));
		}
		public bool IsDefault() {
			STObjectChangedStructure defaultStruct = new STObjectChangedStructure(null);
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssAttributies != null && this.ssAttributies.Length != 0) return false;
			return true;
		}
	} // STObjectChangedStructure

	/// <summary>
	/// Structure <code>STErrorStructure</code> that represents the Service Studio structure
	///  <code>Error</code> <p> Description: . Error structure. .</p>
	/// </summary>
	[Serializable()]
	public partial struct STErrorStructure: ISerializable, ITypedRecord<STErrorStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*z24KUd6u1E+4z12qrQ36Bg");
		internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("XtJSeC7yu0CUgJofQ64gLA*Wk5t1NeitEuEcGmvNlUckQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IsError")]
		public bool ssIsError;

		[System.Xml.Serialization.XmlElement("ErrorMessage")]
		public string ssErrorMessage;


		public BitArray OptimizedAttributes;

		public STErrorStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssIsError = false;
			ssErrorMessage = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssIsError = r.ReadBoolean(index++, "Error.IsError", false);
			ssErrorMessage = r.ReadText(index++, "Error.ErrorMessage", "");
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
		public void ReadIM(STErrorStructure r) {
			this = r;
		}


		public static bool operator == (STErrorStructure a, STErrorStructure b) {
			if (a.ssIsError != b.ssIsError) return false;
			if (a.ssErrorMessage != b.ssErrorMessage) return false;
			return true;
		}

		public static bool operator != (STErrorStructure a, STErrorStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STErrorStructure)) return false;
			return (this == (STErrorStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssIsError.GetHashCode()
				^ ssErrorMessage.GetHashCode()
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

		public STErrorStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssIsError = false;
			ssErrorMessage = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssIsError", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsError' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsError = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssErrorMessage", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssErrorMessage' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssErrorMessage = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STErrorStructure Duplicate() {
			STErrorStructure t;
			t.ssIsError = this.ssIsError;
			t.ssErrorMessage = this.ssErrorMessage;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsError")) VarValue.AppendAttribute(recordElem, "IsError", ssIsError, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsError");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ErrorMessage")) VarValue.AppendAttribute(recordElem, "ErrorMessage", ssErrorMessage, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ErrorMessage");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "iserror") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
			} else if (head == "errormessage") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
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
			if (key == IdIsError) {
				return ssIsError;
			} else if (key == IdErrorMessage) {
				return ssErrorMessage;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssIsError = (bool) other.AttributeGet(IdIsError);
			ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
		}
		public bool IsDefault() {
			STErrorStructure defaultStruct = new STErrorStructure(null);
			if (this.ssIsError != defaultStruct.ssIsError) return false;
			if (this.ssErrorMessage != defaultStruct.ssErrorMessage) return false;
			return true;
		}
	} // STErrorStructure

} // OutSystems.NssTrackChanges
