namespace InterfacesDemoCSharp_49;

public class AudioPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing audio..");
    }

    public void Stop()
    {
        Console.WriteLine("Audio is stopped..");
    }

    public void Pause()
    {
        Console.WriteLine("Audio is paused..");
    }
}