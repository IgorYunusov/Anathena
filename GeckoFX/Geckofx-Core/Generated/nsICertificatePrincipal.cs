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
// Generated by IDLImporter from file nsICertificatePrincipal.idl
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
    /// Historically, principals, certificates, and signed JARs were all linked
    /// together in one big mess. When that mess was cleaned up, it turned out that
    /// the principals used to store certificate information didn't overlap at all
    /// with the principals used for security policy. So this interface was created
    /// so that real principals wouldn't have to carry around all that baggage.
    ///
    /// The name here is totally a misnomer. This isn't a principal at all, and would
    /// better be called nsICertificateHolder or something. But that would require
    /// renaming some APIs, so let's just let this be for now.
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7cd4af5a-64d3-44a8-9700-804a42a6109a")]
	public interface nsICertificatePrincipal
	{
		
		/// <summary>
        /// Historically, principals, certificates, and signed JARs were all linked
        /// together in one big mess. When that mess was cleaned up, it turned out that
        /// the principals used to store certificate information didn't overlap at all
        /// with the principals used for security policy. So this interface was created
        /// so that real principals wouldn't have to carry around all that baggage.
        ///
        /// The name here is totally a misnomer. This isn't a principal at all, and would
        /// better be called nsICertificateHolder or something. But that would require
        /// renaming some APIs, so let's just let this be for now.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFingerprint);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrettyNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrettyName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSubjectName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCertificateAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasCertificateAttribute();
		
		/// <summary>
        /// For compat; always true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsICertificatePrincipal aOther);
	}
}
