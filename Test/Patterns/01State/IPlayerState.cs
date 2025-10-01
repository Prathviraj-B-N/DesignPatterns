
namespace Test.patterns.State
{
    public interface IPlayerState
    {
        public string Icon { get; }
        public void PlayPauseClicked();
        public void StopClicked();
    }
}