﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonoSoftware.MonoX.Resources {
    using System;
    using System.Web.Configuration;
    using MonoSoftware.Web.ResourceProviderModel;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorProviderModel custom tool. (Mono Wrapper based on Dmytro Kryvko builder)
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorProviderModel custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2013 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("MonoSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "4.7.40.4282")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MetaWeblog {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MetaWeblog() {
        }
        
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.MetaWeblog.MetaWeblog", typeof(MetaWeblog).Assembly));
                        }
                    }
                    finally {
                        System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Blog'.
        /// </summary>
        public static string Blog_PropertyName {
            get {
                return "Blog";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Blog'.
        /// </summary>
        public static string Blog {
            get {
                return ResourceManager.GetString("Blog", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'FileError'.
        /// </summary>
        public static string FileError_PropertyName {
            get {
                return "FileError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'File upload error for file {0}.'.
        /// </summary>
        public static string FileError {
            get {
                return ResourceManager.GetString("FileError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'InsertNotAllowed'.
        /// </summary>
        public static string InsertNotAllowed_PropertyName {
            get {
                return "InsertNotAllowed";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Insert not allowed on non default language!'.
        /// </summary>
        public static string InsertNotAllowed {
            get {
                return ResourceManager.GetString("InsertNotAllowed", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'News'.
        /// </summary>
        public static string News_PropertyName {
            get {
                return "News";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News'.
        /// </summary>
        public static string News {
            get {
                return ResourceManager.GetString("News", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'NoEditPermissions'.
        /// </summary>
        public static string NoEditPermissions_PropertyName {
            get {
                return "NoEditPermissions";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'No edit permissions!'.
        /// </summary>
        public static string NoEditPermissions {
            get {
                return ResourceManager.GetString("NoEditPermissions", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PortalPages'.
        /// </summary>
        public static string PortalPages_PropertyName {
            get {
                return "PortalPages";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Portal pages'.
        /// </summary>
        public static string PortalPages {
            get {
                return ResourceManager.GetString("PortalPages", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Undefined'.
        /// </summary>
        public static string Undefined_PropertyName {
            get {
                return "Undefined";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Undefined'.
        /// </summary>
        public static string Undefined {
            get {
                return ResourceManager.GetString("Undefined", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UserNotValid'.
        /// </summary>
        public static string UserNotValid_PropertyName {
            get {
                return "UserNotValid";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'User is not valid!'.
        /// </summary>
        public static string UserNotValid {
            get {
                return ResourceManager.GetString("UserNotValid", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the Blog property value.
        /// </summary>
        /// <returns>The Blog property value.</returns>
        public static string BlogFormat() {
            return Blog;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'File upload error for file {0}.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string FileErrorFormat(object arg0) {
            return string.Format(_resourceCulture, FileError, arg0);
        }
        
        /// <summary>
        /// The stub formatting method returning the InsertNotAllowed property value.
        /// </summary>
        /// <returns>The InsertNotAllowed property value.</returns>
        public static string InsertNotAllowedFormat() {
            return InsertNotAllowed;
        }
        
        /// <summary>
        /// The stub formatting method returning the News property value.
        /// </summary>
        /// <returns>The News property value.</returns>
        public static string NewsFormat() {
            return News;
        }
        
        /// <summary>
        /// The stub formatting method returning the NoEditPermissions property value.
        /// </summary>
        /// <returns>The NoEditPermissions property value.</returns>
        public static string NoEditPermissionsFormat() {
            return NoEditPermissions;
        }
        
        /// <summary>
        /// The stub formatting method returning the PortalPages property value.
        /// </summary>
        /// <returns>The PortalPages property value.</returns>
        public static string PortalPagesFormat() {
            return PortalPages;
        }
        
        /// <summary>
        /// The stub formatting method returning the Undefined property value.
        /// </summary>
        /// <returns>The Undefined property value.</returns>
        public static string UndefinedFormat() {
            return Undefined;
        }
        
        /// <summary>
        /// The stub formatting method returning the UserNotValid property value.
        /// </summary>
        /// <returns>The UserNotValid property value.</returns>
        public static string UserNotValidFormat() {
            return UserNotValid;
        }
    }
}
