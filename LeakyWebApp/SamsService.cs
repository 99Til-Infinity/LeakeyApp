class SamsService : ISamsService
{
    private Audit? _audit;

    public void DoIt(string message)
    {
        _audit = new Audit(_audit, message);
    }

}