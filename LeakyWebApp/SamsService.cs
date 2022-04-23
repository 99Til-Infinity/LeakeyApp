class SamsService : ISamsService
{
    private Audit? _audit;
    private Audit? _previousAudit;

    public void DoIt(string message)
    {
        _previousAudit = _audit;
        _audit = new Audit(message);
    }

}