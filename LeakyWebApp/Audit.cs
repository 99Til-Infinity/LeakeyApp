public class Audit
{
    private Audit? _previousAudit;

    private string Details { get; set; }

    public Audit(Audit? previousAudit, string details)
    {
        _previousAudit = previousAudit;
        Details = details;
    }
}