﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonoSoftware.MonoX.Resources.WebParts {
    using System;
    using System.Web.Configuration;
    using MonoSoftware.Web.ResourceProviderModel;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorProviderModel custom tool. (Mono Wrapper based on Dmytro Kryvko builder)
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorProviderModel custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2012 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("MonoSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "4.5.3044.40")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class PortalWebPartZone {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PortalWebPartZone() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.WebParts.PortalWebPartZone", typeof(PortalWebPartZone).Assembly));
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
        /// Looks up a localized string similar to 'Close'.
        /// </summary>
        public static string CloseVerb {
            get {
                return ResourceManager.GetString("CloseVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Hides the part on the page without deleting it completely'.
        /// </summary>
        public static string CloseVerbDescription {
            get {
                return ResourceManager.GetString("CloseVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Connect'.
        /// </summary>
        public static string ConnectVerb {
            get {
                return ResourceManager.GetString("ConnectVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Activates the Connect mode in which Web parts can exchange information'.
        /// </summary>
        public static string ConnectVerbDescription {
            get {
                return ResourceManager.GetString("ConnectVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'copied'.
        /// </summary>
        public static string Copied {
            get {
                return ResourceManager.GetString("Copied", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Copy'.
        /// </summary>
        public static string CopyVerb {
            get {
                return ResourceManager.GetString("CopyVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Copies the Web part to the clipboard'.
        /// </summary>
        public static string CopyVerbDescription {
            get {
                return ResourceManager.GetString("CopyVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Delete'.
        /// </summary>
        public static string DeleteVerb {
            get {
                return ResourceManager.GetString("DeleteVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Deletes the Web part from a page'.
        /// </summary>
        public static string DeleteVerbDescription {
            get {
                return ResourceManager.GetString("DeleteVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Edit part source'.
        /// </summary>
        public static string EditSourceVerb {
            get {
                return ResourceManager.GetString("EditSourceVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Allows you to edit the Web part source code'.
        /// </summary>
        public static string EditSourceVerbDescription {
            get {
                return ResourceManager.GetString("EditSourceVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Edit the Web part properties'.
        /// </summary>
        public static string EditVerbDescription {
            get {
                return ResourceManager.GetString("EditVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Export'.
        /// </summary>
        public static string ExportVerb {
            get {
                return ResourceManager.GetString("ExportVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Exports the personalization data for a Web part into the XML file'.
        /// </summary>
        public static string ExportVerbDescription {
            get {
                return ResourceManager.GetString("ExportVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Minimize'.
        /// </summary>
        public static string MinimizeVerb {
            get {
                return ResourceManager.GetString("MinimizeVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Minimizes the Web part'.
        /// </summary>
        public static string MinimizeVerbDescription {
            get {
                return ResourceManager.GetString("MinimizeVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Properties'.
        /// </summary>
        public static string PersonalizationScopeEditVerbShared {
            get {
                return ResourceManager.GetString("PersonalizationScopeEditVerbShared", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Properties'.
        /// </summary>
        public static string PersonalizationScopeEditVerbUser {
            get {
                return ResourceManager.GetString("PersonalizationScopeEditVerbUser", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Reset personalization'.
        /// </summary>
        public static string ResetPersonalization {
            get {
                return ResourceManager.GetString("ResetPersonalization", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Restore'.
        /// </summary>
        public static string RestoreVerb {
            get {
                return ResourceManager.GetString("RestoreVerb", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Restores the Web part to its original size'.
        /// </summary>
        public static string RestoreVerbDescription {
            get {
                return ResourceManager.GetString("RestoreVerbDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the CloseVerb property value.
        /// </summary>
        /// <returns>The CloseVerb property value.</returns>
        public static string CloseVerbFormat() {
            return CloseVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the CloseVerbDescription property value.
        /// </summary>
        /// <returns>The CloseVerbDescription property value.</returns>
        public static string CloseVerbDescriptionFormat() {
            return CloseVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the ConnectVerb property value.
        /// </summary>
        /// <returns>The ConnectVerb property value.</returns>
        public static string ConnectVerbFormat() {
            return ConnectVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the ConnectVerbDescription property value.
        /// </summary>
        /// <returns>The ConnectVerbDescription property value.</returns>
        public static string ConnectVerbDescriptionFormat() {
            return ConnectVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the Copied property value.
        /// </summary>
        /// <returns>The Copied property value.</returns>
        public static string CopiedFormat() {
            return Copied;
        }
        
        /// <summary>
        /// The stub formatting method returning the CopyVerb property value.
        /// </summary>
        /// <returns>The CopyVerb property value.</returns>
        public static string CopyVerbFormat() {
            return CopyVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the CopyVerbDescription property value.
        /// </summary>
        /// <returns>The CopyVerbDescription property value.</returns>
        public static string CopyVerbDescriptionFormat() {
            return CopyVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the DeleteVerb property value.
        /// </summary>
        /// <returns>The DeleteVerb property value.</returns>
        public static string DeleteVerbFormat() {
            return DeleteVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the DeleteVerbDescription property value.
        /// </summary>
        /// <returns>The DeleteVerbDescription property value.</returns>
        public static string DeleteVerbDescriptionFormat() {
            return DeleteVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the EditSourceVerb property value.
        /// </summary>
        /// <returns>The EditSourceVerb property value.</returns>
        public static string EditSourceVerbFormat() {
            return EditSourceVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the EditSourceVerbDescription property value.
        /// </summary>
        /// <returns>The EditSourceVerbDescription property value.</returns>
        public static string EditSourceVerbDescriptionFormat() {
            return EditSourceVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the EditVerbDescription property value.
        /// </summary>
        /// <returns>The EditVerbDescription property value.</returns>
        public static string EditVerbDescriptionFormat() {
            return EditVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the ExportVerb property value.
        /// </summary>
        /// <returns>The ExportVerb property value.</returns>
        public static string ExportVerbFormat() {
            return ExportVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the ExportVerbDescription property value.
        /// </summary>
        /// <returns>The ExportVerbDescription property value.</returns>
        public static string ExportVerbDescriptionFormat() {
            return ExportVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the MinimizeVerb property value.
        /// </summary>
        /// <returns>The MinimizeVerb property value.</returns>
        public static string MinimizeVerbFormat() {
            return MinimizeVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the MinimizeVerbDescription property value.
        /// </summary>
        /// <returns>The MinimizeVerbDescription property value.</returns>
        public static string MinimizeVerbDescriptionFormat() {
            return MinimizeVerbDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the PersonalizationScopeEditVerbShared property value.
        /// </summary>
        /// <returns>The PersonalizationScopeEditVerbShared property value.</returns>
        public static string PersonalizationScopeEditVerbSharedFormat() {
            return PersonalizationScopeEditVerbShared;
        }
        
        /// <summary>
        /// The stub formatting method returning the PersonalizationScopeEditVerbUser property value.
        /// </summary>
        /// <returns>The PersonalizationScopeEditVerbUser property value.</returns>
        public static string PersonalizationScopeEditVerbUserFormat() {
            return PersonalizationScopeEditVerbUser;
        }
        
        /// <summary>
        /// The stub formatting method returning the ResetPersonalization property value.
        /// </summary>
        /// <returns>The ResetPersonalization property value.</returns>
        public static string ResetPersonalizationFormat() {
            return ResetPersonalization;
        }
        
        /// <summary>
        /// The stub formatting method returning the RestoreVerb property value.
        /// </summary>
        /// <returns>The RestoreVerb property value.</returns>
        public static string RestoreVerbFormat() {
            return RestoreVerb;
        }
        
        /// <summary>
        /// The stub formatting method returning the RestoreVerbDescription property value.
        /// </summary>
        /// <returns>The RestoreVerbDescription property value.</returns>
        public static string RestoreVerbDescriptionFormat() {
            return RestoreVerbDescription;
        }
    }
}
