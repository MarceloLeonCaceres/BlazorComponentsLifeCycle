namespace BTCascadingState.AppStateFolder
{
    public class AppStateData : IAppState
    {
        public int TimeToLiveInSeconds { get; set; }
        public DateTime LastAccessed { get; set; }

        public DateTime dDesde { get; set; }

        public DateTime dHasta { get; set; }

        public List<int> listUsers { get; set; }
    }
}
