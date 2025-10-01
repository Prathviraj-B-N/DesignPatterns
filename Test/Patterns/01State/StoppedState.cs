namespace Test.patterns.State
{
    public class StoppedState : IPlayerState
    {
        private readonly MusicPlayer Player;

        public string Icon => "X";

        public StoppedState(MusicPlayer player)
        {
            Player = player;
        }

        public void PlayPauseClicked()
        {
            Console.WriteLine("Switching to Play State");
            Player._state = new PlayingState(Player);
        }

        public void StopClicked()
        {
            Console.WriteLine("Already in Stopped State");
        }
    }
}