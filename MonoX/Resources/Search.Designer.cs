﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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
    // Copyright (c) Dmytro Kryvko 2006-2014 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("MonoSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "4.8.40.4594")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class Search {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Search() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.Search", typeof(Search).Assembly));
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
        /// Gets the strongly typed name for property 'AllProviders'.
        /// </summary>
        public static string AllProviders_PropertyName {
            get {
                return "AllProviders";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'All'.
        /// </summary>
        public static string AllProviders {
            get {
                return ResourceManager.GetString("AllProviders", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'BlogProviderTitle'.
        /// </summary>
        public static string BlogProviderTitle_PropertyName {
            get {
                return "BlogProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Blogs'.
        /// </summary>
        public static string BlogProviderTitle {
            get {
                return ResourceManager.GetString("BlogProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'CalendarEventSearchProviderTitle'.
        /// </summary>
        public static string CalendarEventSearchProviderTitle_PropertyName {
            get {
                return "CalendarEventSearchProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Calendars'.
        /// </summary>
        public static string CalendarEventSearchProviderTitle {
            get {
                return ResourceManager.GetString("CalendarEventSearchProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'DiscussionProviderTitle'.
        /// </summary>
        public static string DiscussionProviderTitle_PropertyName {
            get {
                return "DiscussionProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Discussions'.
        /// </summary>
        public static string DiscussionProviderTitle {
            get {
                return ResourceManager.GetString("DiscussionProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'FileProviderTitle'.
        /// </summary>
        public static string FileProviderTitle_PropertyName {
            get {
                return "FileProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Files'.
        /// </summary>
        public static string FileProviderTitle {
            get {
                return ResourceManager.GetString("FileProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'GroupProviderTitle'.
        /// </summary>
        public static string GroupProviderTitle_PropertyName {
            get {
                return "GroupProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Groups'.
        /// </summary>
        public static string GroupProviderTitle {
            get {
                return ResourceManager.GetString("GroupProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'IndexingServiceProviderTitle'.
        /// </summary>
        public static string IndexingServiceProviderTitle_PropertyName {
            get {
                return "IndexingServiceProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'File system (Indexing Service)'.
        /// </summary>
        public static string IndexingServiceProviderTitle {
            get {
                return ResourceManager.GetString("IndexingServiceProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'LuceneProviderTitle'.
        /// </summary>
        public static string LuceneProviderTitle_PropertyName {
            get {
                return "LuceneProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'File system (Lucene.Net)'.
        /// </summary>
        public static string LuceneProviderTitle {
            get {
                return ResourceManager.GetString("LuceneProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'NewsProviderTitle'.
        /// </summary>
        public static string NewsProviderTitle_PropertyName {
            get {
                return "NewsProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News'.
        /// </summary>
        public static string NewsProviderTitle {
            get {
                return ResourceManager.GetString("NewsProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'NoSearchCriteria'.
        /// </summary>
        public static string NoSearchCriteria_PropertyName {
            get {
                return "NoSearchCriteria";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Please enter the search criteria.'.
        /// </summary>
        public static string NoSearchCriteria {
            get {
                return ResourceManager.GetString("NoSearchCriteria", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'NoSearchResults'.
        /// </summary>
        public static string NoSearchResults_PropertyName {
            get {
                return "NoSearchResults";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'There are no documents that match your search criteria.'.
        /// </summary>
        public static string NoSearchResults {
            get {
                return ResourceManager.GetString("NoSearchResults", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PagesProviderTitle'.
        /// </summary>
        public static string PagesProviderTitle_PropertyName {
            get {
                return "PagesProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Pages'.
        /// </summary>
        public static string PagesProviderTitle {
            get {
                return ResourceManager.GetString("PagesProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'PhotoGalleryProviderTitle'.
        /// </summary>
        public static string PhotoGalleryProviderTitle_PropertyName {
            get {
                return "PhotoGalleryProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Photos'.
        /// </summary>
        public static string PhotoGalleryProviderTitle {
            get {
                return ResourceManager.GetString("PhotoGalleryProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'SearchFilterCaption'.
        /// </summary>
        public static string SearchFilterCaption_PropertyName {
            get {
                return "SearchFilterCaption";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Search in:'.
        /// </summary>
        public static string SearchFilterCaption {
            get {
                return ResourceManager.GetString("SearchFilterCaption", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'SearchResultsTemplateError'.
        /// </summary>
        public static string SearchResultsTemplateError_PropertyName {
            get {
                return "SearchResultsTemplateError";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Search results were not rendered correctly.'.
        /// </summary>
        public static string SearchResultsTemplateError {
            get {
                return ResourceManager.GetString("SearchResultsTemplateError", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Gets the strongly typed name for property 'UserProfileProviderTitle'.
        /// </summary>
        public static string UserProfileProviderTitle_PropertyName {
            get {
                return "UserProfileProviderTitle";
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'User profiles'.
        /// </summary>
        public static string UserProfileProviderTitle {
            get {
                return ResourceManager.GetString("UserProfileProviderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the AllProviders property value.
        /// </summary>
        /// <returns>The AllProviders property value.</returns>
        public static string AllProvidersFormat() {
            return AllProviders;
        }
        
        /// <summary>
        /// The stub formatting method returning the BlogProviderTitle property value.
        /// </summary>
        /// <returns>The BlogProviderTitle property value.</returns>
        public static string BlogProviderTitleFormat() {
            return BlogProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the CalendarEventSearchProviderTitle property value.
        /// </summary>
        /// <returns>The CalendarEventSearchProviderTitle property value.</returns>
        public static string CalendarEventSearchProviderTitleFormat() {
            return CalendarEventSearchProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the DiscussionProviderTitle property value.
        /// </summary>
        /// <returns>The DiscussionProviderTitle property value.</returns>
        public static string DiscussionProviderTitleFormat() {
            return DiscussionProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the FileProviderTitle property value.
        /// </summary>
        /// <returns>The FileProviderTitle property value.</returns>
        public static string FileProviderTitleFormat() {
            return FileProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the GroupProviderTitle property value.
        /// </summary>
        /// <returns>The GroupProviderTitle property value.</returns>
        public static string GroupProviderTitleFormat() {
            return GroupProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the IndexingServiceProviderTitle property value.
        /// </summary>
        /// <returns>The IndexingServiceProviderTitle property value.</returns>
        public static string IndexingServiceProviderTitleFormat() {
            return IndexingServiceProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the LuceneProviderTitle property value.
        /// </summary>
        /// <returns>The LuceneProviderTitle property value.</returns>
        public static string LuceneProviderTitleFormat() {
            return LuceneProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsProviderTitle property value.
        /// </summary>
        /// <returns>The NewsProviderTitle property value.</returns>
        public static string NewsProviderTitleFormat() {
            return NewsProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the NoSearchCriteria property value.
        /// </summary>
        /// <returns>The NoSearchCriteria property value.</returns>
        public static string NoSearchCriteriaFormat() {
            return NoSearchCriteria;
        }
        
        /// <summary>
        /// The stub formatting method returning the NoSearchResults property value.
        /// </summary>
        /// <returns>The NoSearchResults property value.</returns>
        public static string NoSearchResultsFormat() {
            return NoSearchResults;
        }
        
        /// <summary>
        /// The stub formatting method returning the PagesProviderTitle property value.
        /// </summary>
        /// <returns>The PagesProviderTitle property value.</returns>
        public static string PagesProviderTitleFormat() {
            return PagesProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the PhotoGalleryProviderTitle property value.
        /// </summary>
        /// <returns>The PhotoGalleryProviderTitle property value.</returns>
        public static string PhotoGalleryProviderTitleFormat() {
            return PhotoGalleryProviderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the SearchFilterCaption property value.
        /// </summary>
        /// <returns>The SearchFilterCaption property value.</returns>
        public static string SearchFilterCaptionFormat() {
            return SearchFilterCaption;
        }
        
        /// <summary>
        /// The stub formatting method returning the SearchResultsTemplateError property value.
        /// </summary>
        /// <returns>The SearchResultsTemplateError property value.</returns>
        public static string SearchResultsTemplateErrorFormat() {
            return SearchResultsTemplateError;
        }
        
        /// <summary>
        /// The stub formatting method returning the UserProfileProviderTitle property value.
        /// </summary>
        /// <returns>The UserProfileProviderTitle property value.</returns>
        public static string UserProfileProviderTitleFormat() {
            return UserProfileProviderTitle;
        }
    }
}
