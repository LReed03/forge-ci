namespace ForgeCI.Core;

public class Build
{
    public Guid Id { get; set; }

    public string RepositoryUrl { get; set; } = string.Empty;

    public string Branch { get; set; } = string.Empty;

    public BuildStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? FinishedAt { get; set; }
}