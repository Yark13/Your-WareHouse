using System.ComponentModel;

namespace DataLayer.Entities;

public enum StatusOrder
{
    [Description("Canceled")]
    Canceled,
    [Description("In Queue")]
    InQueue,
    [Description("Currently running")]
    CurrentlyRunning,
    [Description("Done")]
    Done
}
