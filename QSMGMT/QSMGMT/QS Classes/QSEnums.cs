using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSMGMT.QS_Classes
{
    public enum RuleContext
    {
        BothQlikSenseAndQMC,
        QlikSenseOnly,
        QMCOnly
    }

    public enum ReloadTaskType
    {
        Reload,
        ExternalProgram,
        UserSync
    }
    public enum ReloadTaskStatus
    {
        NeverStarted,
        Triggered,
        Started,
        Queued,
        AbortInitiated,
        Aborting,
        Aborted,
        FinishedSuccess,
        FinishedFail,
        Skipped,
        Retry,
        Error,
        Reset
    }

    public enum DetailsType
    {
        Error,
        Warning,
        Information
    }

    public enum AppAvailabilityStatus
    {
        NotApplicable,
        Available,
        NoActiveRoute,
        NoConfiguredRoute,
        NotSynced,
        NotMigrated
    }
}
