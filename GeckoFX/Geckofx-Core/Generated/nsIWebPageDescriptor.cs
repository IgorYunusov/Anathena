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
// Generated by IDLImporter from file nsIWebPageDescriptor.idl
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
    /// The nsIWebPageDescriptor interface allows content being displayed in one
    /// window to be loaded into another window without refetching it from the
    /// network.
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6f30b676-3710-4c2c-80b1-0395fb26516e")]
	public interface nsIWebPageDescriptor
	{
		
		/// <summary>
        /// Tells the object to load the page specified by the page descriptor
        ///
        /// @throws NS_ERROR_FAILURE -
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadPage([MarshalAs(UnmanagedType.Interface)] nsISupports aPageDescriptor, uint aDisplayType);
		
		/// <summary>
        /// Retrieves the page descriptor for the curent document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCurrentDescriptorAttribute();
	}
	
	/// <summary>nsIWebPageDescriptorConsts </summary>
	public class nsIWebPageDescriptorConsts
	{
		
		// <summary>
        // The nsIWebPageDescriptor interface allows content being displayed in one
        // window to be loaded into another window without refetching it from the
        // network.
        // </summary>
		public const ulong DISPLAY_AS_SOURCE = 0x0001;
		
		// 
		public const ulong DISPLAY_NORMAL = 0x0002;
	}
}
