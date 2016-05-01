// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMCSSPrimitiveValue.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    /// <summary>
    /// The nsIDOMCSSPrimitiveValue interface is a datatype for a primitive
    /// CSS value in the Document Object Model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Style
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f6df7293-2dc9-4cb9-9531-778caf4370e0")]
	public interface nsIDOMCSSPrimitiveValue : nsIDOMCSSValue
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);
		
		/// <summary>
        /// raises(DOMException) on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetCssValueTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPrimitiveTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFloatValue(ushort unitType, float floatValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetFloatValue(ushort unitType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringValue(ushort stringType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase stringValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringValue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCounter GetCounterValue();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRect GetRectValue();
	}
	
	/// <summary>nsIDOMCSSPrimitiveValueConsts </summary>
	public class nsIDOMCSSPrimitiveValueConsts
	{
		
		// <summary>
        // UnitTypes
        // </summary>
		public const ushort CSS_UNKNOWN = 0;
		
		// 
		public const ushort CSS_NUMBER = 1;
		
		// 
		public const ushort CSS_PERCENTAGE = 2;
		
		// 
		public const ushort CSS_EMS = 3;
		
		// 
		public const ushort CSS_EXS = 4;
		
		// 
		public const ushort CSS_PX = 5;
		
		// 
		public const ushort CSS_CM = 6;
		
		// 
		public const ushort CSS_MM = 7;
		
		// 
		public const ushort CSS_IN = 8;
		
		// 
		public const ushort CSS_PT = 9;
		
		// 
		public const ushort CSS_PC = 10;
		
		// 
		public const ushort CSS_DEG = 11;
		
		// 
		public const ushort CSS_RAD = 12;
		
		// 
		public const ushort CSS_GRAD = 13;
		
		// 
		public const ushort CSS_MS = 14;
		
		// 
		public const ushort CSS_S = 15;
		
		// 
		public const ushort CSS_HZ = 16;
		
		// 
		public const ushort CSS_KHZ = 17;
		
		// 
		public const ushort CSS_DIMENSION = 18;
		
		// 
		public const ushort CSS_STRING = 19;
		
		// 
		public const ushort CSS_URI = 20;
		
		// 
		public const ushort CSS_IDENT = 21;
		
		// 
		public const ushort CSS_ATTR = 22;
		
		// 
		public const ushort CSS_COUNTER = 23;
		
		// 
		public const ushort CSS_RECT = 24;
		
		// 
		public const ushort CSS_RGBCOLOR = 25;
	}
}
