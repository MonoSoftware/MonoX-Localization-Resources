﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4455
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
    // Copyright (c) Dmytro Kryvko 2006-2010 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("MonoSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "1.0.0.314")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NewsAdmin {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NewsAdmin() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.News.NewsAdmin", typeof(NewsAdmin).Assembly));
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
        /// Looks up a localized string similar to 'Select category'.
        /// </summary>
        public static string Categories_Text {
            get {
                return ResourceManager.GetString("Categories_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Category manager'.
        /// </summary>
        public static string CategoryAdminTitle {
            get {
                return ResourceManager.GetString("CategoryAdminTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Note: Use drag &amp; drop to move categories '.
        /// </summary>
        public static string CategoryDragAndDrop {
            get {
                return ResourceManager.GetString("CategoryDragAndDrop", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News Quick Post'.
        /// </summary>
        public static string Global_Title {
            get {
                return ResourceManager.GetString("Global_Title", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Ignored meta keywords manager'.
        /// </summary>
        public static string IgnoredMetaWordsTitle {
            get {
                return ResourceManager.GetString("IgnoredMetaWordsTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Note: If you leave this field empty, Meta description will be autogenerated.'.
        /// </summary>
        public static string MetaDescriptionNote {
            get {
                return ResourceManager.GetString("MetaDescriptionNote", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Note: If you leave this field empty, Meta keywords will be autogenerated.'.
        /// </summary>
        public static string MetaKeywordsNote {
            get {
                return ResourceManager.GetString("MetaKeywordsNote", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Add new'.
        /// </summary>
        public static string News_AddNew_Text {
            get {
                return ResourceManager.GetString("News_AddNew_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Content'.
        /// </summary>
        public static string News_Content_Text {
            get {
                return ResourceManager.GetString("News_Content_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Save'.
        /// </summary>
        public static string News_Save_Text {
            get {
                return ResourceManager.GetString("News_Save_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News post saved successfully'.
        /// </summary>
        public static string News_Saved_Text {
            get {
                return ResourceManager.GetString("News_Saved_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Title'.
        /// </summary>
        public static string News_Title_Text {
            get {
                return ResourceManager.GetString("News_Title_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News manager'.
        /// </summary>
        public static string NewsAdminTitle {
            get {
                return ResourceManager.GetString("NewsAdminTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Root'.
        /// </summary>
        public static string NewsCategoryRoot {
            get {
                return ResourceManager.GetString("NewsCategoryRoot", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News File Content type not set.'.
        /// </summary>
        public static string NewsContentTypeNotSet {
            get {
                return ResourceManager.GetString("NewsContentTypeNotSet", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Note: Use drag &amp; drop to move news to category'.
        /// </summary>
        public static string NewsDragAndDrop {
            get {
                return ResourceManager.GetString("NewsDragAndDrop", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News item id not set.'.
        /// </summary>
        public static string NewsItemIdNotSet {
            get {
                return ResourceManager.GetString("NewsItemIdNotSet", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News publishing'.
        /// </summary>
        public static string PublisherAdminTitle {
            get {
                return ResourceManager.GetString("PublisherAdminTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Please note that you need to add news categories before you can add news.'.
        /// </summary>
        public static string QuickNews_NoCategories {
            get {
                return ResourceManager.GetString("QuickNews_NoCategories", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'News'.
        /// </summary>
        public static string TreeViewNewsCountTitle {
            get {
                return ResourceManager.GetString("TreeViewNewsCountTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Order'.
        /// </summary>
        public static string TreeViewOrderTitle {
            get {
                return ResourceManager.GetString("TreeViewOrderTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Insert is not allowed for non default language!'.
        /// </summary>
        public static string Validation_InsertNoAllowedNonDefaultLang {
            get {
                return ResourceManager.GetString("Validation_InsertNoAllowedNonDefaultLang", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to '*'.
        /// </summary>
        public static string Validation_News_Title_Text {
            get {
                return ResourceManager.GetString("Validation_News_Title_Text", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Please select a category.'.
        /// </summary>
        public static string Validation_PleaseSelectCategory {
            get {
                return ResourceManager.GetString("Validation_PleaseSelectCategory", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the Categories_Text property value.
        /// </summary>
        /// <returns>The Categories_Text property value.</returns>
        public static string Categories_TextFormat() {
            return Categories_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the CategoryAdminTitle property value.
        /// </summary>
        /// <returns>The CategoryAdminTitle property value.</returns>
        public static string CategoryAdminTitleFormat() {
            return CategoryAdminTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the CategoryDragAndDrop property value.
        /// </summary>
        /// <returns>The CategoryDragAndDrop property value.</returns>
        public static string CategoryDragAndDropFormat() {
            return CategoryDragAndDrop;
        }
        
        /// <summary>
        /// The stub formatting method returning the Global_Title property value.
        /// </summary>
        /// <returns>The Global_Title property value.</returns>
        public static string Global_TitleFormat() {
            return Global_Title;
        }
        
        /// <summary>
        /// The stub formatting method returning the IgnoredMetaWordsTitle property value.
        /// </summary>
        /// <returns>The IgnoredMetaWordsTitle property value.</returns>
        public static string IgnoredMetaWordsTitleFormat() {
            return IgnoredMetaWordsTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the MetaDescriptionNote property value.
        /// </summary>
        /// <returns>The MetaDescriptionNote property value.</returns>
        public static string MetaDescriptionNoteFormat() {
            return MetaDescriptionNote;
        }
        
        /// <summary>
        /// The stub formatting method returning the MetaKeywordsNote property value.
        /// </summary>
        /// <returns>The MetaKeywordsNote property value.</returns>
        public static string MetaKeywordsNoteFormat() {
            return MetaKeywordsNote;
        }
        
        /// <summary>
        /// The stub formatting method returning the News_AddNew_Text property value.
        /// </summary>
        /// <returns>The News_AddNew_Text property value.</returns>
        public static string News_AddNew_TextFormat() {
            return News_AddNew_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the News_Content_Text property value.
        /// </summary>
        /// <returns>The News_Content_Text property value.</returns>
        public static string News_Content_TextFormat() {
            return News_Content_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the News_Save_Text property value.
        /// </summary>
        /// <returns>The News_Save_Text property value.</returns>
        public static string News_Save_TextFormat() {
            return News_Save_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the News_Saved_Text property value.
        /// </summary>
        /// <returns>The News_Saved_Text property value.</returns>
        public static string News_Saved_TextFormat() {
            return News_Saved_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the News_Title_Text property value.
        /// </summary>
        /// <returns>The News_Title_Text property value.</returns>
        public static string News_Title_TextFormat() {
            return News_Title_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsAdminTitle property value.
        /// </summary>
        /// <returns>The NewsAdminTitle property value.</returns>
        public static string NewsAdminTitleFormat() {
            return NewsAdminTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsCategoryRoot property value.
        /// </summary>
        /// <returns>The NewsCategoryRoot property value.</returns>
        public static string NewsCategoryRootFormat() {
            return NewsCategoryRoot;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsContentTypeNotSet property value.
        /// </summary>
        /// <returns>The NewsContentTypeNotSet property value.</returns>
        public static string NewsContentTypeNotSetFormat() {
            return NewsContentTypeNotSet;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsDragAndDrop property value.
        /// </summary>
        /// <returns>The NewsDragAndDrop property value.</returns>
        public static string NewsDragAndDropFormat() {
            return NewsDragAndDrop;
        }
        
        /// <summary>
        /// The stub formatting method returning the NewsItemIdNotSet property value.
        /// </summary>
        /// <returns>The NewsItemIdNotSet property value.</returns>
        public static string NewsItemIdNotSetFormat() {
            return NewsItemIdNotSet;
        }
        
        /// <summary>
        /// The stub formatting method returning the PublisherAdminTitle property value.
        /// </summary>
        /// <returns>The PublisherAdminTitle property value.</returns>
        public static string PublisherAdminTitleFormat() {
            return PublisherAdminTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the QuickNews_NoCategories property value.
        /// </summary>
        /// <returns>The QuickNews_NoCategories property value.</returns>
        public static string QuickNews_NoCategoriesFormat() {
            return QuickNews_NoCategories;
        }
        
        /// <summary>
        /// The stub formatting method returning the TreeViewNewsCountTitle property value.
        /// </summary>
        /// <returns>The TreeViewNewsCountTitle property value.</returns>
        public static string TreeViewNewsCountTitleFormat() {
            return TreeViewNewsCountTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the TreeViewOrderTitle property value.
        /// </summary>
        /// <returns>The TreeViewOrderTitle property value.</returns>
        public static string TreeViewOrderTitleFormat() {
            return TreeViewOrderTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validation_InsertNoAllowedNonDefaultLang property value.
        /// </summary>
        /// <returns>The Validation_InsertNoAllowedNonDefaultLang property value.</returns>
        public static string Validation_InsertNoAllowedNonDefaultLangFormat() {
            return Validation_InsertNoAllowedNonDefaultLang;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validation_News_Title_Text property value.
        /// </summary>
        /// <returns>The Validation_News_Title_Text property value.</returns>
        public static string Validation_News_Title_TextFormat() {
            return Validation_News_Title_Text;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validation_PleaseSelectCategory property value.
        /// </summary>
        /// <returns>The Validation_PleaseSelectCategory property value.</returns>
        public static string Validation_PleaseSelectCategoryFormat() {
            return Validation_PleaseSelectCategory;
        }
    }
}
