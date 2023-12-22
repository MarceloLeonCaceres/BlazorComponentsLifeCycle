namespace BTCascadingState.AppStateFolder
{
    public interface IAppState
    {
        int TimeToLiveInSeconds { get; set; }
        DateTime LastAccessed {  get; set; }

        DateTime dDesde { get; }
        DateTime dHasta { get; }
        List<int> listUsers { get; }

    }
}
