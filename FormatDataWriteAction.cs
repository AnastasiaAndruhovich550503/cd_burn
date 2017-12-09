using System.ComponentModel;

namespace IMAPI2
{
    public enum FormatDataWriteAction
    {
        [Description("Validating Media")]
        ValidatingMedia,
        [Description("Formatting Media")]
        FormattingMedia,
        [Description("Initializing Hardware")]
        InitializingHardware,
        [Description("Calibrating Power")]
        CalibratingPower,
        [Description("Writing Data")]
        WritingData,
        Finalization,
        Completed,
        Verifying
    }
}
