namespace Test.patterns.State
{
    public class PausedState : IPlayerState
    {
        private readonly MusicPlayer Player;

        public string Icon => "||";

        public PausedState(MusicPlayer player)
        {
            Player = player;
        }

        void IPlayerState.PlayPauseClicked()
        {
            Console.WriteLine("Switching to Play State");
            Player._state = new PlayingState(Player);
        }

        void IPlayerState.StopClicked()
        {
            Console.WriteLine("Switching to Stop State");
            Player._state = new StoppedState(Player);
        }
    }
}