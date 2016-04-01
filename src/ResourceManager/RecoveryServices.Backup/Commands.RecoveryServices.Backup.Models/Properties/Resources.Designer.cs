﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.RecoveryServices.Backup.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handling aggregate exception.
        /// </summary>
        public static string AggregateException {
            get {
                return ResourceManager.GetString("AggregateException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All retention schedules are Empty in retentionPolicy. Alteast one is expected..
        /// </summary>
        public static string AllRetentionSchedulesEmptyException {
            get {
                return ResourceManager.GetString("AllRetentionSchedulesEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received ArgumentException.
        /// </summary>
        public static string ArgumentException {
            get {
                return ResourceManager.GetString("ArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BackupManagementType value should be empty or AzureVM for WorkloadType=AzureVM.
        /// </summary>
        public static string AzureVMUnsupportedBackupManagementTypeException {
            get {
                return ResourceManager.GetString("AzureVMUnsupportedBackupManagementTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionTime in retention schedule should be same as backup time in SchedulePolicy.
        /// </summary>
        public static string BackupAndRetentionTimesMismatch {
            get {
                return ResourceManager.GetString("BackupAndRetentionTimesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both RetentionPolicy and SchedulePolicy are empty, nothing to update.
        /// </summary>
        public static string BothRetentionAndSchedulePoliciesEmpty {
            get {
                return ResourceManager.GetString("BothRetentionAndSchedulePoliciesEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received CloudException, ErrorCode: {0}, Message: {1}.
        /// </summary>
        public static string CloudException {
            get {
                return ResourceManager.GetString("CloudException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received CloudException, StatusCode: {0}.
        /// </summary>
        public static string CloudExceptionCodeNotFound {
            get {
                return ResourceManager.GetString("CloudExceptionCodeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Daily Retention Schedule can&apos;t be null if Daily Backup Schedule is enabled.
        /// </summary>
        public static string DailyRetentionScheduleNullException {
            get {
                return ResourceManager.GetString("DailyRetentionScheduleNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionPolicy: IsDailyScheduleEnabled=true but DailySchedule is NULL.
        /// </summary>
        public static string DailyScheduleEnabledButScheduleIsNullException {
            get {
                return ResourceManager.GetString("DailyScheduleEnabledButScheduleIsNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DaysOfWeek specified in a weekly retention schedule should be same as of DaysOfWeek value specified in the backup schedule.
        /// </summary>
        public static string DaysofTheWeekInWeeklyRetentionException {
            get {
                return ResourceManager.GetString("DaysofTheWeekInWeeklyRetentionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty response received from Service/Hydra.
        /// </summary>
        public static string EmptyHydraResponseException {
            get {
                return ResourceManager.GetString("EmptyHydraResponseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Caught exception, type: {0}.
        /// </summary>
        public static string ExceptionInExecution {
            get {
                return ResourceManager.GetString("ExceptionInExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ONE BackupTime is Allowed in SchedulePolicy.
        /// </summary>
        public static string InvalidBackupTimesInSchedulePolicyException {
            get {
                return ResourceManager.GetString("InvalidBackupTimesInSchedulePolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, Day in DaysOfMonth should be 1-28 (or) IsLast=true set for one day only.
        /// </summary>
        public static string InvalidDayInDaysOfMonthOfMonthlyYearlyRetentionPolicyException {
            get {
                return ResourceManager.GetString("InvalidDayInDaysOfMonthOfMonthlyYearlyRetentionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, DaysOfMonth is NULL or empty or contains duplicate entires.
        /// </summary>
        public static string InvalidDaysOfMonthInMonthlyYearlyRetentionPolicyException {
            get {
                return ResourceManager.GetString("InvalidDaysOfMonthInMonthlyYearlyRetentionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, DaysOfWeek is NULL or empty or contains duplicate entires.
        /// </summary>
        public static string InvalidDaysOfWeekInMonthlyYearlyRetentionPolicyException {
            get {
                return ResourceManager.GetString("InvalidDaysOfWeekInMonthlyYearlyRetentionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InvalidDurationType - {0}.
        /// </summary>
        public static string InvalidDurationTypeException {
            get {
                return ResourceManager.GetString("InvalidDurationTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid ProtectionPolicy - either NULL or NOT of type: {0}.
        /// </summary>
        public static string InvalidProtectionPolicyException {
            get {
                return ResourceManager.GetString("InvalidProtectionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid RetentionPolicy - either NULL or NOT of type: {0}.
        /// </summary>
        public static string InvalidRetentionPolicyException {
            get {
                return ResourceManager.GetString("InvalidRetentionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ONE RetentionTime is Allowed in RententionSchedules.
        /// </summary>
        public static string InvalidRetentionTimesInPolicyException {
            get {
                return ResourceManager.GetString("InvalidRetentionTimesInPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid SchedulePolicy - either NULL or NOT of type: {0}.
        /// </summary>
        public static string InvalidSchedulePolicyException {
            get {
                return ResourceManager.GetString("InvalidSchedulePolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Schedule, if ScheduleRunFrequency is Weekly then ScheduleRunDays should not be empty and not contain duplicate entries.
        /// </summary>
        public static string InvalidScheduleRunDaysInScheduleException {
            get {
                return ResourceManager.GetString("InvalidScheduleRunDaysInScheduleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ScheduleTimes in Schedule should be in UTC Timezone, have ONE time and must be of multiples of 30 Mins with seconds and milliseconds set to 0.
        /// </summary>
        public static string InvalidScheduleTimeInScheduleException {
            get {
                return ResourceManager.GetString("InvalidScheduleTimeInScheduleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, WeeksOfMonth is NULL or empty or contains duplicate entires.
        /// </summary>
        public static string InvalidWeeksOfMonthInMonthlyYearlyRetentionPolicyException {
            get {
                return ResourceManager.GetString("InvalidWeeksOfMonthInMonthlyYearlyRetentionPolicyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To filter should not be more than 30 days away from From filter..
        /// </summary>
        public static string JobAllowedDateTimeRangeExceeded {
            get {
                return ResourceManager.GetString("JobAllowedDateTimeRangeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to cancel the job. Error code: {0}.
        /// </summary>
        public static string JobCouldNotCancelJob {
            get {
                return ResourceManager.GetString("JobCouldNotCancelJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JobID and Job object provided don&apos;t match each other..
        /// </summary>
        public static string JobJobIdAndJobMismatch {
            get {
                return ResourceManager.GetString("JobJobIdAndJobMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are more than 1000 jobs for the filter combination you have provided. Kindly refine your filters to fetch the job you want..
        /// </summary>
        public static string JobRefineFilters {
            get {
                return ResourceManager.GetString("JobRefineFilters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify From and To filter values in UTC. Other timezones are not supported..
        /// </summary>
        public static string JobTimeFiltersShouldBeSpecifiedInUtc {
            get {
                return ResourceManager.GetString("JobTimeFiltersShouldBeSpecifiedInUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To filter should not be less than From filter..
        /// </summary>
        public static string JobToShouldBeGreaterThanFrom {
            get {
                return ResourceManager.GetString("JobToShouldBeGreaterThanFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please pass Job or List of Jobs as input. Your input is of type: {0}.
        /// </summary>
        public static string JobWaitJobInvalidInput {
            get {
                return ResourceManager.GetString("JobWaitJobInvalidInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionPolicy: IsMonthlyScheduleEnabled=true but MonthlySchedule is NULL.
        /// </summary>
        public static string MonthlyScheduleEnabledButScheduleIsNullException {
            get {
                return ResourceManager.GetString("MonthlyScheduleEnabledButScheduleIsNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly and Yearly retention schedules, RetentionFormatType cannot be &apos;Daily&apos; if Weekly BackupSchedule is selected.
        /// </summary>
        public static string MonthlyYearlyInvalidDailyRetentionFormatTypeException {
            get {
                return ResourceManager.GetString("MonthlyYearlyInvalidDailyRetentionFormatTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, if RetentionScheduleFormatType=Daily then RetentionScheduleDaily should NOT be null.
        /// </summary>
        public static string MonthlyYearlyRetentionDailySchedulePolicyNULLException {
            get {
                return ResourceManager.GetString("MonthlyYearlyRetentionDailySchedulePolicyNULLException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DaysOfWeek specified for monthly and yearly retention policies should be a subset of the DaysOfWeek value specified in the backup schedule.
        /// </summary>
        public static string MonthlyYearlyRetentionDaysOfWeekException {
            get {
                return ResourceManager.GetString("MonthlyYearlyRetentionDaysOfWeekException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In Monthly/Yearly retention schedule, if RetentionScheduleFormatType=Weekly then RetentionScheduleWeekly should NOT be null.
        /// </summary>
        public static string MonthlyYearlyRetentionWeeklySchedulePolicyNULLException {
            get {
                return ResourceManager.GetString("MonthlyYearlyRetentionWeeklySchedulePolicyNULLException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A protection policy with the specified name already exists: {0}.
        /// </summary>
        public static string PolicyAlreadyExistException {
            get {
                return ResourceManager.GetString("PolicyAlreadyExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Policy not found with name: {0}.
        /// </summary>
        public static string PolicyNotFoundException {
            get {
                return ResourceManager.GetString("PolicyNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The protection policy name should contain alphanumeric characters and cannot start with a number.
        /// </summary>
        public static string ProtectionPolicyNameException {
            get {
                return ResourceManager.GetString("ProtectionPolicyNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The protection policy name must contain between 3 and 150 characters.
        /// </summary>
        public static string ProtectionPolicyNameLengthException {
            get {
                return ResourceManager.GetString("ProtectionPolicyNameLengthException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified resource does not exist.
        /// </summary>
        public static string ResourceNotFoundMessage {
            get {
                return ResourceManager.GetString("ResourceNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionDuration in Days/Weeks/Months/Years should be from 1 - 9999.
        /// </summary>
        public static string RetentionDurationCountInvalidException {
            get {
                return ResourceManager.GetString("RetentionDurationCountInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryServicesBackupVault.Name.
        /// </summary>
        public static string RsVaultResNameNullOrEmpty {
            get {
                return ResourceManager.GetString("RsVaultResNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryServicesBackupVault.ResourceGroupName.
        /// </summary>
        public static string RsVaultRGNameNullOrEmpty {
            get {
                return ResourceManager.GetString("RsVaultRGNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ScheduleRunTimes in Schedule Policy should be in UTC Timezone.
        /// </summary>
        public static string ScheduleTimeNotInUTCTimeZoneException {
            get {
                return ResourceManager.GetString("ScheduleTimeNotInUTCTimeZoneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected WorkloadType - expected:{0}, current:{1}.
        /// </summary>
        public static string UnExpectedWorkLoadTypeException {
            get {
                return ResourceManager.GetString("UnExpectedWorkLoadTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported combination for WorkloadType: {0}, BackupManagementType:{1}.
        /// </summary>
        public static string UnsupportedWorkloadBackupManagementTypeException {
            get {
                return ResourceManager.GetString("UnsupportedWorkloadBackupManagementTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported WorkloadType: {0}.
        /// </summary>
        public static string UnsupportedWorkloadTypeException {
            get {
                return ResourceManager.GetString("UnsupportedWorkloadTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data truncated. Please upgrade to latest version of Azure Powershell.
        /// </summary>
        public static string UpdateToNewAzurePowershellWarning {
            get {
                return ResourceManager.GetString("UpdateToNewAzurePowershellWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received WebException, Response: {0}, Status: {1}.
        /// </summary>
        public static string WebException {
            get {
                return ResourceManager.GetString("WebException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For a weekly retention policy, DaysOfTheWeek is mandatory and should not contain duplicate entries.
        /// </summary>
        public static string WeeklyRetentionScheduleDaysOfWeekException {
            get {
                return ResourceManager.GetString("WeeklyRetentionScheduleDaysOfWeekException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If Weekly backup schedule is enabled, Daily retention schedule should be null and Weekly retention schedule should not be null.
        /// </summary>
        public static string WeeklyRetentionScheduleNullException {
            get {
                return ResourceManager.GetString("WeeklyRetentionScheduleNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For a weekly backup schedule, using the DaysOfWeek parameter is mandatory.
        /// </summary>
        public static string WeeklyScheduleDaysOfWeekException {
            get {
                return ResourceManager.GetString("WeeklyScheduleDaysOfWeekException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionPolicy: IsWeeklyScheduleEnabled=true but WeeklySchedule is NULL.
        /// </summary>
        public static string WeeklyScheduleEnabledButScheduleIsNullException {
            get {
                return ResourceManager.GetString("WeeklyScheduleEnabledButScheduleIsNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RetentionPolicy: IsYearlyScheduleEnabled=true but YearlySchedule is NULL.
        /// </summary>
        public static string YearlyScheduleEnabledButScheduleIsNullException {
            get {
                return ResourceManager.GetString("YearlyScheduleEnabledButScheduleIsNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MonthsOfYear list in YearlyRetentionSchedule should not be NULL and not contain duplicate entires.
        /// </summary>
        public static string YearlyScheduleMonthsOfYearException {
            get {
                return ResourceManager.GetString("YearlyScheduleMonthsOfYearException", resourceCulture);
            }
        }
    }
}
