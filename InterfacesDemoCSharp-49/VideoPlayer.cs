namespace InterfacesDemoCSharp_49;

public class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Video is playing..");
    }

    public void Stop()
    {
        Console.WriteLine("Video is stopped..");
    }

    public void Pause()
    {
        Console.WriteLine("Video is paused..");
    }
}