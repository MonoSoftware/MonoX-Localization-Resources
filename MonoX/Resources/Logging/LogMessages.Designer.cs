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
    public class LogMessages {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LogMessages() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.Logging.LogMessages", typeof(LogMessages).Assembly));
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
        /// Gets the strongly typed name for property 'ApplicationEnd'.
        /// </summary>
        public static string ApplicationEnd_PropertyName {
            get {
                return "ApplicationEnd";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Application end'.
        /// </summary>
        public static string ApplicationEnd {
            get {
                return ResourceManager.GetString("ApplicationEnd", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'ApplicationError'.
        /// </summary>
        public static string ApplicationError_PropertyName {
            get {
                return "ApplicationError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Application error'.
        /// </summary>
        public static string ApplicationError {
            get {
                return ResourceManager.GetString("ApplicationError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'ApplicationStart'.
        /// </summary>
        public static string ApplicationStart_PropertyName {
            get {
                return "ApplicationStart";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Application start'.
        /// </summary>
        public static string ApplicationStart {
            get {
                return ResourceManager.GetString("ApplicationStart", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PageError'.
        /// </summary>
        public static string PageError_PropertyName {
            get {
                return "PageError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Page error'.
        /// </summary>
        public static string PageError {
            get {
                return ResourceManager.GetString("PageError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UniqueUserIdNoProvided'.
        /// </summary>
        public static string UniqueUserIdNoProvided_PropertyName {
            get {
                return "UniqueUserIdNoProvided";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Please provide unique user id.'.
        /// </summary>
        public static string UniqueUserIdNoProvided {
            get {
                return ResourceManager.GetString("UniqueUserIdNoProvided", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UserControlError'.
        /// </summary>
        public static string UserControlError_PropertyName {
            get {
                return "UserControlError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'User control error'.
        /// </summary>
        public static string UserControlError {
            get {
                return ResourceManager.GetString("UserControlError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the ApplicationEnd property value.
        /// </summary>
        /// <returns>The ApplicationEnd property value.</returns>
        public static string ApplicationEndFormat() {
            return ApplicationEnd;
        }
        
        /// <summary>
        /// The stub formatting method returning the ApplicationError property value.
        /// </summary>
        /// <returns>The ApplicationError property value.</returns>
        public static string ApplicationErrorFormat() {
            return ApplicationError;
        }
        
        /// <summary>
        /// The stub formatting method returning the ApplicationStart property value.
        /// </summary>
        /// <returns>The ApplicationStart property value.</returns>
        public static string ApplicationStartFormat() {
            return ApplicationStart;
        }
        
        /// <summary>
        /// The stub formatting method returning the PageError property value.
        /// </summary>
        /// <returns>The PageError property value.</returns>
        public static string PageErrorFormat() {
            return PageError;
        }
        
        /// <summary>
        /// The stub formatting method returning the UniqueUserIdNoProvided property value.
        /// </summary>
        /// <returns>The UniqueUserIdNoProvided property value.</returns>
        public static string UniqueUserIdNoProvidedFormat() {
            return UniqueUserIdNoProvided;
        }
        
        /// <summary>
        /// The stub formatting method returning the UserControlError property value.
        /// </summary>
        /// <returns>The UserControlError property value.</returns>
        public static string UserControlErrorFormat() {
            return UserControlError;
        }
    }
}
