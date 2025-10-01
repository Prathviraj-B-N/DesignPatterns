// You’re designing a Media Player. The player can be in one of these states:
    // Playing: Music is playing.
    // Paused: Music is paused.
    // Stopped: Music is stopped.

// Depending on the state, the player should behave differently:
    // If it’s Playing and the user presses Pause, it should switch to Paused.
    // If it’s Paused and the user presses Play, it should switch to Playing.
    // If it’s Stopped and the user presses Play, it should switch to Playing.
    // If it’s Playing and the user presses Stop, it should switch to Stopped.

// Implement this using the State Pattern.

namespace Test.patterns.State
{
    public class MusicPlayer
    {
        public IPlayerState _state;
        public MusicPlayer()
        {
            _state = new StoppedState(this);
        }

        public void PlayPauseClicked()
        {
            Console.WriteLine($"Current State: {_state.Icon}");
            _state.PlayPauseClicked();
        }

        public void StopClicked()
        {
            Console.WriteLine($"Current State: {_state.Icon}");
            _state.StopClicked();
        }
       
    }
}