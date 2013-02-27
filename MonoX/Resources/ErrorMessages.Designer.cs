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
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.ErrorMessages", typeof(ErrorMessages).Assembly));
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
        /// Gets the strongly typed name for property 'Authorization_Description'.
        /// </summary>
        public static string Authorization_Description_PropertyName {
            get {
                return "Authorization_Description";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'You are not authorized to view this page.'.
        /// </summary>
        public static string Authorization_Description {
            get {
                return ResourceManager.GetString("Authorization_Description", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Authorization_Login'.
        /// </summary>
        public static string Authorization_Login_PropertyName {
            get {
                return "Authorization_Login";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'You are not authorized to view this page. Please login with proper credentials to proceed to this page.'.
        /// </summary>
        public static string Authorization_Login {
            get {
                return ResourceManager.GetString("Authorization_Login", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Authorization_Title'.
        /// </summary>
        public static string Authorization_Title_PropertyName {
            get {
                return "Authorization_Title";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Access Denied'.
        /// </summary>
        public static string Authorization_Title {
            get {
                return ResourceManager.GetString("Authorization_Title", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'CannotFindLicenseFile'.
        /// </summary>
        public static string CannotFindLicenseFile_PropertyName {
            get {
                return "CannotFindLicenseFile";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'License file cannot be found. Please register your MonoX installation and place the license in the bin folder.'.
        /// </summary>
        public static string CannotFindLicenseFile {
            get {
                return ResourceManager.GetString("CannotFindLicenseFile", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'DomainNotLicensed'.
        /// </summary>
        public static string DomainNotLicensed_PropertyName {
            get {
                return "DomainNotLicensed";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Domain {0} is not in the list of licensed domains. Please register this domain.'.
        /// </summary>
        public static string DomainNotLicensed {
            get {
                return ResourceManager.GetString("DomainNotLicensed", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'EmailSendingFailed'.
        /// </summary>
        public static string EmailSendingFailed_PropertyName {
            get {
                return "EmailSendingFailed";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An error has occured while sending you an e-mail. Please try again, if the problem persists, please contact us.'.
        /// </summary>
        public static string EmailSendingFailed {
            get {
                return ResourceManager.GetString("EmailSendingFailed", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'EntityIdRequired'.
        /// </summary>
        public static string EntityIdRequired_PropertyName {
            get {
                return "EntityIdRequired";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Entity id required!'.
        /// </summary>
        public static string EntityIdRequired {
            get {
                return ResourceManager.GetString("EntityIdRequired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'ImageTypeRequired'.
        /// </summary>
        public static string ImageTypeRequired_PropertyName {
            get {
                return "ImageTypeRequired";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Image type is required!'.
        /// </summary>
        public static string ImageTypeRequired {
            get {
                return ResourceManager.GetString("ImageTypeRequired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'LicenseExpired'.
        /// </summary>
        public static string LicenseExpired_PropertyName {
            get {
                return "LicenseExpired";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'This license has expired. Please obtain a valid license and place it to the bin folder of this portal.'.
        /// </summary>
        public static string LicenseExpired {
            get {
                return ResourceManager.GetString("LicenseExpired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_Create_UnknownError'.
        /// </summary>
        public static string Membership_Create_UnknownError_PropertyName {
            get {
                return "Membership_Create_UnknownError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An unknown error occured. The account could not be created, please try again later. If the problem persists, please contact us.'.
        /// </summary>
        public static string Membership_Create_UnknownError {
            get {
                return ResourceManager.GetString("Membership_Create_UnknownError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_DuplicateEmail'.
        /// </summary>
        public static string Membership_DuplicateEmail_PropertyName {
            get {
                return "Membership_DuplicateEmail";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An user with this e-mail address already exists.'.
        /// </summary>
        public static string Membership_DuplicateEmail {
            get {
                return ResourceManager.GetString("Membership_DuplicateEmail", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_DuplicateUserName'.
        /// </summary>
        public static string Membership_DuplicateUserName_PropertyName {
            get {
                return "Membership_DuplicateUserName";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An user with this user name already exists.'.
        /// </summary>
        public static string Membership_DuplicateUserName {
            get {
                return ResourceManager.GetString("Membership_DuplicateUserName", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_InvalidPassword'.
        /// </summary>
        public static string Membership_InvalidPassword_PropertyName {
            get {
                return "Membership_InvalidPassword";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'The password you provided is invalid. It must be at least {0} character(s) long{1}.'.
        /// </summary>
        public static string Membership_InvalidPassword {
            get {
                return ResourceManager.GetString("Membership_InvalidPassword", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_InvalidPassword_Suffix'.
        /// </summary>
        public static string Membership_InvalidPassword_Suffix_PropertyName {
            get {
                return "Membership_InvalidPassword_Suffix";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to ' and contain at least {0} non-alphanumeric character(s).'.
        /// </summary>
        public static string Membership_InvalidPassword_Suffix {
            get {
                return ResourceManager.GetString("Membership_InvalidPassword_Suffix", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Membership_Update_UnknownError'.
        /// </summary>
        public static string Membership_Update_UnknownError_PropertyName {
            get {
                return "Membership_Update_UnknownError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An unknown error occured. The account could not be updated, please try again later. If the problem persists, please contact us.'.
        /// </summary>
        public static string Membership_Update_UnknownError {
            get {
                return ResourceManager.GetString("Membership_Update_UnknownError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PageNotFound'.
        /// </summary>
        public static string PageNotFound_PropertyName {
            get {
                return "PageNotFound";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Page not found'.
        /// </summary>
        public static string PageNotFound {
            get {
                return ResourceManager.GetString("PageNotFound", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PageNotFoundDescription'.
        /// </summary>
        public static string PageNotFoundDescription_PropertyName {
            get {
                return "PageNotFoundDescription";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'We couldn&apos;t find the page you requested.'.
        /// </summary>
        public static string PageNotFoundDescription {
            get {
                return ResourceManager.GetString("PageNotFoundDescription", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PageNotFoundPersonalizationFound'.
        /// </summary>
        public static string PageNotFoundPersonalizationFound_PropertyName {
            get {
                return "PageNotFoundPersonalizationFound";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'We couldn&apos;t find the page you requested but the database contains personalization data for the page.'.
        /// </summary>
        public static string PageNotFoundPersonalizationFound {
            get {
                return ResourceManager.GetString("PageNotFoundPersonalizationFound", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PageNotFoundRemovePersonalization'.
        /// </summary>
        public static string PageNotFoundRemovePersonalization_PropertyName {
            get {
                return "PageNotFoundRemovePersonalization";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Do you want to remove personalization data for the page?'.
        /// </summary>
        public static string PageNotFoundRemovePersonalization {
            get {
                return ResourceManager.GetString("PageNotFoundRemovePersonalization", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'SessionExpired_Description'.
        /// </summary>
        public static string SessionExpired_Description_PropertyName {
            get {
                return "SessionExpired_Description";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'A certain amount of time has elapsed since your last browsing action. As a result, the temporary data for this page has expired and you need to start your current browsing process from the beginning.'.
        /// </summary>
        public static string SessionExpired_Description {
            get {
                return ResourceManager.GetString("SessionExpired_Description", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'SessionExpired_Title'.
        /// </summary>
        public static string SessionExpired_Title_PropertyName {
            get {
                return "SessionExpired_Title";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Session Expired'.
        /// </summary>
        public static string SessionExpired_Title {
            get {
                return ResourceManager.GetString("SessionExpired_Title", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'SignatureNotValid'.
        /// </summary>
        public static string SignatureNotValid_PropertyName {
            get {
                return "SignatureNotValid";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'The signature in your license file is not valid. Please obtain a valid license file.'.
        /// </summary>
        public static string SignatureNotValid {
            get {
                return ResourceManager.GetString("SignatureNotValid", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'ToContinueWorkingWithApplication'.
        /// </summary>
        public static string ToContinueWorkingWithApplication_PropertyName {
            get {
                return "ToContinueWorkingWithApplication";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'To continue working with the application please click'.
        /// </summary>
        public static string ToContinueWorkingWithApplication {
            get {
                return ResourceManager.GetString("ToContinueWorkingWithApplication", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'ToContinueWorkingWithApplicationClickHere'.
        /// </summary>
        public static string ToContinueWorkingWithApplicationClickHere_PropertyName {
            get {
                return "ToContinueWorkingWithApplicationClickHere";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'here'.
        /// </summary>
        public static string ToContinueWorkingWithApplicationClickHere {
            get {
                return ResourceManager.GetString("ToContinueWorkingWithApplicationClickHere", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'Unexpected_Title'.
        /// </summary>
        public static string Unexpected_Title_PropertyName {
            get {
                return "Unexpected_Title";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Unexpected Error'.
        /// </summary>
        public static string Unexpected_Title {
            get {
                return ResourceManager.GetString("Unexpected_Title", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UnhandledError'.
        /// </summary>
        public static string UnhandledError_PropertyName {
            get {
                return "UnhandledError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'An error has occured in the application.'.
        /// </summary>
        public static string UnhandledError {
            get {
                return ResourceManager.GetString("UnhandledError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UnhandledErrorLongMessage'.
        /// </summary>
        public static string UnhandledErrorLongMessage_PropertyName {
            get {
                return "UnhandledErrorLongMessage";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'This event has been logged and will be addressed by the maintenance department. We appreciate your patience.'.
        /// </summary>
        public static string UnhandledErrorLongMessage {
            get {
                return ResourceManager.GetString("UnhandledErrorLongMessage", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'VersionError'.
        /// </summary>
        public static string VersionError_PropertyName {
            get {
                return "VersionError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'The license file needs to be upgraded to version {0}.'.
        /// </summary>
        public static string VersionError {
            get {
                return ResourceManager.GetString("VersionError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the Authorization_Description property value.
        /// </summary>
        /// <returns>The Authorization_Description property value.</returns>
        public static string Authorization_DescriptionFormat() {
            return Authorization_Description;
        }
        
        /// <summary>
        /// The stub formatting method returning the Authorization_Login property value.
        /// </summary>
        /// <returns>The Authorization_Login property value.</returns>
        public static string Authorization_LoginFormat() {
            return Authorization_Login;
        }
        
        /// <summary>
        /// The stub formatting method returning the Authorization_Title property value.
        /// </summary>
        /// <returns>The Authorization_Title property value.</returns>
        public static string Authorization_TitleFormat() {
            return Authorization_Title;
        }
        
        /// <summary>
        /// The stub formatting method returning the CannotFindLicenseFile property value.
        /// </summary>
        /// <returns>The CannotFindLicenseFile property value.</returns>
        public static string CannotFindLicenseFileFormat() {
            return CannotFindLicenseFile;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Domain {0} is not in the list of licensed domains. Please register this domain.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string DomainNotLicensedFormat(object arg0) {
            return string.Format(_resourceCulture, DomainNotLicensed, arg0);
        }
        
        /// <summary>
        /// The stub formatting method returning the EmailSendingFailed property value.
        /// </summary>
        /// <returns>The EmailSendingFailed property value.</returns>
        public static string EmailSendingFailedFormat() {
            return EmailSendingFailed;
        }
        
        /// <summary>
        /// The stub formatting method returning the EntityIdRequired property value.
        /// </summary>
        /// <returns>The EntityIdRequired property value.</returns>
        public static string EntityIdRequiredFormat() {
            return EntityIdRequired;
        }
        
        /// <summary>
        /// The stub formatting method returning the ImageTypeRequired property value.
        /// </summary>
        /// <returns>The ImageTypeRequired property value.</returns>
        public static string ImageTypeRequiredFormat() {
            return ImageTypeRequired;
        }
        
        /// <summary>
        /// The stub formatting method returning the LicenseExpired property value.
        /// </summary>
        /// <returns>The LicenseExpired property value.</returns>
        public static string LicenseExpiredFormat() {
            return LicenseExpired;
        }
        
        /// <summary>
        /// The stub formatting method returning the Membership_Create_UnknownError property value.
        /// </summary>
        /// <returns>The Membership_Create_UnknownError property value.</returns>
        public static string Membership_Create_UnknownErrorFormat() {
            return Membership_Create_UnknownError;
        }
        
        /// <summary>
        /// The stub formatting method returning the Membership_DuplicateEmail property value.
        /// </summary>
        /// <returns>The Membership_DuplicateEmail property value.</returns>
        public static string Membership_DuplicateEmailFormat() {
            return Membership_DuplicateEmail;
        }
        
        /// <summary>
        /// The stub formatting method returning the Membership_DuplicateUserName property value.
        /// </summary>
        /// <returns>The Membership_DuplicateUserName property value.</returns>
        public static string Membership_DuplicateUserNameFormat() {
            return Membership_DuplicateUserName;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'The password you provided is invalid. It must be at least {0} character(s) long{1}.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <param name="arg1">An object (1) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Membership_InvalidPasswordFormat(object arg0, object arg1) {
            return string.Format(_resourceCulture, Membership_InvalidPassword, arg0, arg1);
        }
        
        /// <summary>
        /// Formats a localized string similar to ' and contain at least {0} non-alphanumeric character(s).'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Membership_InvalidPassword_SuffixFormat(object arg0) {
            return string.Format(_resourceCulture, Membership_InvalidPassword_Suffix, arg0);
        }
        
        /// <summary>
        /// The stub formatting method returning the Membership_Update_UnknownError property value.
        /// </summary>
        /// <returns>The Membership_Update_UnknownError property value.</returns>
        public static string Membership_Update_UnknownErrorFormat() {
            return Membership_Update_UnknownError;
        }
        
        /// <summary>
        /// The stub formatting method returning the PageNotFound property value.
        /// </summary>
        /// <returns>The PageNotFound property value.</returns>
        public static string PageNotFoundFormat() {
            return PageNotFound;
        }
        
        /// <summary>
        /// The stub formatting method returning the PageNotFoundDescription property value.
        /// </summary>
        /// <returns>The PageNotFoundDescription property value.</returns>
        public static string PageNotFoundDescriptionFormat() {
            return PageNotFoundDescription;
        }
        
        /// <summary>
        /// The stub formatting method returning the PageNotFoundPersonalizationFound property value.
        /// </summary>
        /// <returns>The PageNotFoundPersonalizationFound property value.</returns>
        public static string PageNotFoundPersonalizationFoundFormat() {
            return PageNotFoundPersonalizationFound;
        }
        
        /// <summary>
        /// The stub formatting method returning the PageNotFoundRemovePersonalization property value.
        /// </summary>
        /// <returns>The PageNotFoundRemovePersonalization property value.</returns>
        public static string PageNotFoundRemovePersonalizationFormat() {
            return PageNotFoundRemovePersonalization;
        }
        
        /// <summary>
        /// The stub formatting method returning the SessionExpired_Description property value.
        /// </summary>
        /// <returns>The SessionExpired_Description property value.</returns>
        public static string SessionExpired_DescriptionFormat() {
            return SessionExpired_Description;
        }
        
        /// <summary>
        /// The stub formatting method returning the SessionExpired_Title property value.
        /// </summary>
        /// <returns>The SessionExpired_Title property value.</returns>
        public static string SessionExpired_TitleFormat() {
            return SessionExpired_Title;
        }
        
        /// <summary>
        /// The stub formatting method returning the SignatureNotValid property value.
        /// </summary>
        /// <returns>The SignatureNotValid property value.</returns>
        public static string SignatureNotValidFormat() {
            return SignatureNotValid;
        }
        
        /// <summary>
        /// The stub formatting method returning the ToContinueWorkingWithApplication property value.
        /// </summary>
        /// <returns>The ToContinueWorkingWithApplication property value.</returns>
        public static string ToContinueWorkingWithApplicationFormat() {
            return ToContinueWorkingWithApplication;
        }
        
        /// <summary>
        /// The stub formatting method returning the ToContinueWorkingWithApplicationClickHere property value.
        /// </summary>
        /// <returns>The ToContinueWorkingWithApplicationClickHere property value.</returns>
        public static string ToContinueWorkingWithApplicationClickHereFormat() {
            return ToContinueWorkingWithApplicationClickHere;
        }
        
        /// <summary>
        /// The stub formatting method returning the Unexpected_Title property value.
        /// </summary>
        /// <returns>The Unexpected_Title property value.</returns>
        public static string Unexpected_TitleFormat() {
            return Unexpected_Title;
        }
        
        /// <summary>
        /// The stub formatting method returning the UnhandledError property value.
        /// </summary>
        /// <returns>The UnhandledError property value.</returns>
        public static string UnhandledErrorFormat() {
            return UnhandledError;
        }
        
        /// <summary>
        /// The stub formatting method returning the UnhandledErrorLongMessage property value.
        /// </summary>
        /// <returns>The UnhandledErrorLongMessage property value.</returns>
        public static string UnhandledErrorLongMessageFormat() {
            return UnhandledErrorLongMessage;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'The license file needs to be upgraded to version {0}.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string VersionErrorFormat(object arg0) {
            return string.Format(_resourceCulture, VersionError, arg0);
        }
    }
}