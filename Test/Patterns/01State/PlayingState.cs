namespace Test.patterns.State
{
    public class PlayingState : IPlayerState
    {
        private readonly MusicPlayer Player;

        public string Icon => ">";
        public PlayingState(MusicPlayer player)
        {
            Player = player;
        }

        public void PlayPauseClicked()
        {
            Console.WriteLine("Switching to Pause State");
            Player._state = new PausedState(Player);
        }

        public void StopClicked()
        {
            Console.WriteLine("Switching to Stopped State");
            Player._state = new StoppedState(Player);
        }
    }
}