namespace ForgeCI.Core;

public enum BuildStatus
{
    Queued,
    Running,
    Succeeded,
    Failed,
    Cancelled,
    TimedOut
}