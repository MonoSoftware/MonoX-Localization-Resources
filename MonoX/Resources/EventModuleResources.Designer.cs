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
    public class EventModuleResources {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EventModuleResources() {
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
                            System.Threading.Interlocked.Exchange(ref _resourceManager, MonoSoftware.Web.ResourceProviderModel.ResourceManagerProvider.GetResourceManager("MonoSoftware.MonoX.MonoX.Resources.EventModuleResources", typeof(EventModuleResources).Assembly));
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
        /// Looks up a localized string similar to 'Add new event'.
        /// </summary>
        public static string AddNewEvent {
            get {
                return ResourceManager.GetString("AddNewEvent", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'All day'.
        /// </summary>
        public static string AdvancedScheduler_AllDay {
            get {
                return ResourceManager.GetString("AdvancedScheduler_AllDay", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Move four months forward'.
        /// </summary>
        public static string AdvancedScheduler_CalendarFastNext {
            get {
                return ResourceManager.GetString("AdvancedScheduler_CalendarFastNext", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Move four months backward'.
        /// </summary>
        public static string AdvancedScheduler_CalendarFastPrev {
            get {
                return ResourceManager.GetString("AdvancedScheduler_CalendarFastPrev", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Move one month forward'.
        /// </summary>
        public static string AdvancedScheduler_CalendarNext {
            get {
                return ResourceManager.GetString("AdvancedScheduler_CalendarNext", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Move one month backward'.
        /// </summary>
        public static string AdvancedScheduler_CalendarPrev {
            get {
                return ResourceManager.GetString("AdvancedScheduler_CalendarPrev", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Date is out of range'.
        /// </summary>
        public static string AdvancedScheduler_DateIsOutOfRange {
            get {
                return ResourceManager.GetString("AdvancedScheduler_DateIsOutOfRange", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Day'.
        /// </summary>
        public static string AdvancedScheduler_Day {
            get {
                return ResourceManager.GetString("AdvancedScheduler_Day", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Are you sure you want to delete this event?'.
        /// </summary>
        public static string AdvancedScheduler_DeleteText {
            get {
                return ResourceManager.GetString("AdvancedScheduler_DeleteText", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Confirm delete'.
        /// </summary>
        public static string AdvancedScheduler_DeleteTitle {
            get {
                return ResourceManager.GetString("AdvancedScheduler_DeleteTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Month'.
        /// </summary>
        public static string AdvancedScheduler_Month {
            get {
                return ResourceManager.GetString("AdvancedScheduler_Month", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Next day'.
        /// </summary>
        public static string AdvancedScheduler_NextDay {
            get {
                return ResourceManager.GetString("AdvancedScheduler_NextDay", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Previous day'.
        /// </summary>
        public static string AdvancedScheduler_PrevDay {
            get {
                return ResourceManager.GetString("AdvancedScheduler_PrevDay", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Show 24 hours'.
        /// </summary>
        public static string AdvancedScheduler_Show24Hours {
            get {
                return ResourceManager.GetString("AdvancedScheduler_Show24Hours", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Show business hours'.
        /// </summary>
        public static string AdvancedScheduler_ShowBusinessHours {
            get {
                return ResourceManager.GetString("AdvancedScheduler_ShowBusinessHours", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Show more'.
        /// </summary>
        public static string AdvancedScheduler_ShowMore {
            get {
                return ResourceManager.GetString("AdvancedScheduler_ShowMore", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Today'.
        /// </summary>
        public static string AdvancedScheduler_Today {
            get {
                return ResourceManager.GetString("AdvancedScheduler_Today", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Week'.
        /// </summary>
        public static string AdvancedScheduler_Week {
            get {
                return ResourceManager.GetString("AdvancedScheduler_Week", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'All day'.
        /// </summary>
        public static string AllDay {
            get {
                return ResourceManager.GetString("AllDay", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Description'.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'End time'.
        /// </summary>
        public static string EndTime {
            get {
                return ResourceManager.GetString("EndTime", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to '{0} {1}({2} - {3}){4}{5}'.
        /// </summary>
        public static string Event_Description {
            get {
                return ResourceManager.GetString("Event_Description", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'at {0} '.
        /// </summary>
        public static string Event_Description_Place {
            get {
                return ResourceManager.GetString("Event_Description_Place", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Event details'.
        /// </summary>
        public static string EventEditorTitle {
            get {
                return ResourceManager.GetString("EventEditorTitle", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'There is no calendar selected.'.
        /// </summary>
        public static string NoCalendarSelected {
            get {
                return ResourceManager.GetString("NoCalendarSelected", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Place'.
        /// </summary>
        public static string Place {
            get {
                return ResourceManager.GetString("Place", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Clear filter'.
        /// </summary>
        public static string SimpleView_ClearFilter {
            get {
                return ResourceManager.GetString("SimpleView_ClearFilter", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Delete event'.
        /// </summary>
        public static string SimpleView_DeleteButtonTooltip {
            get {
                return ResourceManager.GetString("SimpleView_DeleteButtonTooltip", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Filter'.
        /// </summary>
        public static string SimpleView_Filter {
            get {
                return ResourceManager.GetString("SimpleView_Filter", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Update event'.
        /// </summary>
        public static string SimpleView_UpdateButtonTooltip {
            get {
                return ResourceManager.GetString("SimpleView_UpdateButtonTooltip", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Start time'.
        /// </summary>
        public static string StartTime {
            get {
                return ResourceManager.GetString("StartTime", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Title'.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'End time must be greater then start time'.
        /// </summary>
        public static string Validator_DateRange {
            get {
                return ResourceManager.GetString("Validator_DateRange", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'End time is required'.
        /// </summary>
        public static string Validator_EndTimeRequired {
            get {
                return ResourceManager.GetString("Validator_EndTimeRequired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Start time is required'.
        /// </summary>
        public static string Validator_StartTimeRequired {
            get {
                return ResourceManager.GetString("Validator_StartTimeRequired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Title is required'.
        /// </summary>
        public static string Validator_SubjectRequired {
            get {
                return ResourceManager.GetString("Validator_SubjectRequired", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the AddNewEvent property value.
        /// </summary>
        /// <returns>The AddNewEvent property value.</returns>
        public static string AddNewEventFormat() {
            return AddNewEvent;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_AllDay property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_AllDay property value.</returns>
        public static string AdvancedScheduler_AllDayFormat() {
            return AdvancedScheduler_AllDay;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_CalendarFastNext property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_CalendarFastNext property value.</returns>
        public static string AdvancedScheduler_CalendarFastNextFormat() {
            return AdvancedScheduler_CalendarFastNext;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_CalendarFastPrev property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_CalendarFastPrev property value.</returns>
        public static string AdvancedScheduler_CalendarFastPrevFormat() {
            return AdvancedScheduler_CalendarFastPrev;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_CalendarNext property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_CalendarNext property value.</returns>
        public static string AdvancedScheduler_CalendarNextFormat() {
            return AdvancedScheduler_CalendarNext;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_CalendarPrev property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_CalendarPrev property value.</returns>
        public static string AdvancedScheduler_CalendarPrevFormat() {
            return AdvancedScheduler_CalendarPrev;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_DateIsOutOfRange property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_DateIsOutOfRange property value.</returns>
        public static string AdvancedScheduler_DateIsOutOfRangeFormat() {
            return AdvancedScheduler_DateIsOutOfRange;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_Day property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_Day property value.</returns>
        public static string AdvancedScheduler_DayFormat() {
            return AdvancedScheduler_Day;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_DeleteText property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_DeleteText property value.</returns>
        public static string AdvancedScheduler_DeleteTextFormat() {
            return AdvancedScheduler_DeleteText;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_DeleteTitle property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_DeleteTitle property value.</returns>
        public static string AdvancedScheduler_DeleteTitleFormat() {
            return AdvancedScheduler_DeleteTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_Month property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_Month property value.</returns>
        public static string AdvancedScheduler_MonthFormat() {
            return AdvancedScheduler_Month;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_NextDay property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_NextDay property value.</returns>
        public static string AdvancedScheduler_NextDayFormat() {
            return AdvancedScheduler_NextDay;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_PrevDay property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_PrevDay property value.</returns>
        public static string AdvancedScheduler_PrevDayFormat() {
            return AdvancedScheduler_PrevDay;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_Show24Hours property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_Show24Hours property value.</returns>
        public static string AdvancedScheduler_Show24HoursFormat() {
            return AdvancedScheduler_Show24Hours;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_ShowBusinessHours property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_ShowBusinessHours property value.</returns>
        public static string AdvancedScheduler_ShowBusinessHoursFormat() {
            return AdvancedScheduler_ShowBusinessHours;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_ShowMore property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_ShowMore property value.</returns>
        public static string AdvancedScheduler_ShowMoreFormat() {
            return AdvancedScheduler_ShowMore;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_Today property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_Today property value.</returns>
        public static string AdvancedScheduler_TodayFormat() {
            return AdvancedScheduler_Today;
        }
        
        /// <summary>
        /// The stub formatting method returning the AdvancedScheduler_Week property value.
        /// </summary>
        /// <returns>The AdvancedScheduler_Week property value.</returns>
        public static string AdvancedScheduler_WeekFormat() {
            return AdvancedScheduler_Week;
        }
        
        /// <summary>
        /// The stub formatting method returning the AllDay property value.
        /// </summary>
        /// <returns>The AllDay property value.</returns>
        public static string AllDayFormat() {
            return AllDay;
        }
        
        /// <summary>
        /// The stub formatting method returning the Description property value.
        /// </summary>
        /// <returns>The Description property value.</returns>
        public static string DescriptionFormat() {
            return Description;
        }
        
        /// <summary>
        /// The stub formatting method returning the EndTime property value.
        /// </summary>
        /// <returns>The EndTime property value.</returns>
        public static string EndTimeFormat() {
            return EndTime;
        }
        
        /// <summary>
        /// Formats a localized string similar to '{0} {1}({2} - {3}){4}{5}'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <param name="arg1">An object (1) to format.</param>
        /// <param name="arg2">An object (2) to format.</param>
        /// <param name="arg3">An object (3) to format.</param>
        /// <param name="arg4">An object (4) to format.</param>
        /// <param name="arg5">An object (5) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Event_DescriptionFormat(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
            return string.Format(_resourceCulture, Event_Description, arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'at {0} '.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Event_Description_PlaceFormat(object arg0) {
            return string.Format(_resourceCulture, Event_Description_Place, arg0);
        }
        
        /// <summary>
        /// The stub formatting method returning the EventEditorTitle property value.
        /// </summary>
        /// <returns>The EventEditorTitle property value.</returns>
        public static string EventEditorTitleFormat() {
            return EventEditorTitle;
        }
        
        /// <summary>
        /// The stub formatting method returning the NoCalendarSelected property value.
        /// </summary>
        /// <returns>The NoCalendarSelected property value.</returns>
        public static string NoCalendarSelectedFormat() {
            return NoCalendarSelected;
        }
        
        /// <summary>
        /// The stub formatting method returning the Place property value.
        /// </summary>
        /// <returns>The Place property value.</returns>
        public static string PlaceFormat() {
            return Place;
        }
        
        /// <summary>
        /// The stub formatting method returning the SimpleView_ClearFilter property value.
        /// </summary>
        /// <returns>The SimpleView_ClearFilter property value.</returns>
        public static string SimpleView_ClearFilterFormat() {
            return SimpleView_ClearFilter;
        }
        
        /// <summary>
        /// The stub formatting method returning the SimpleView_DeleteButtonTooltip property value.
        /// </summary>
        /// <returns>The SimpleView_DeleteButtonTooltip property value.</returns>
        public static string SimpleView_DeleteButtonTooltipFormat() {
            return SimpleView_DeleteButtonTooltip;
        }
        
        /// <summary>
        /// The stub formatting method returning the SimpleView_Filter property value.
        /// </summary>
        /// <returns>The SimpleView_Filter property value.</returns>
        public static string SimpleView_FilterFormat() {
            return SimpleView_Filter;
        }
        
        /// <summary>
        /// The stub formatting method returning the SimpleView_UpdateButtonTooltip property value.
        /// </summary>
        /// <returns>The SimpleView_UpdateButtonTooltip property value.</returns>
        public static string SimpleView_UpdateButtonTooltipFormat() {
            return SimpleView_UpdateButtonTooltip;
        }
        
        /// <summary>
        /// The stub formatting method returning the StartTime property value.
        /// </summary>
        /// <returns>The StartTime property value.</returns>
        public static string StartTimeFormat() {
            return StartTime;
        }
        
        /// <summary>
        /// The stub formatting method returning the Title property value.
        /// </summary>
        /// <returns>The Title property value.</returns>
        public static string TitleFormat() {
            return Title;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validator_DateRange property value.
        /// </summary>
        /// <returns>The Validator_DateRange property value.</returns>
        public static string Validator_DateRangeFormat() {
            return Validator_DateRange;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validator_EndTimeRequired property value.
        /// </summary>
        /// <returns>The Validator_EndTimeRequired property value.</returns>
        public static string Validator_EndTimeRequiredFormat() {
            return Validator_EndTimeRequired;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validator_StartTimeRequired property value.
        /// </summary>
        /// <returns>The Validator_StartTimeRequired property value.</returns>
        public static string Validator_StartTimeRequiredFormat() {
            return Validator_StartTimeRequired;
        }
        
        /// <summary>
        /// The stub formatting method returning the Validator_SubjectRequired property value.
        /// </summary>
        /// <returns>The Validator_SubjectRequired property value.</returns>
        public static string Validator_SubjectRequiredFormat() {
            return Validator_SubjectRequired;
        }
    }
}
