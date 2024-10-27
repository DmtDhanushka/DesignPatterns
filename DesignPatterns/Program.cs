using DesignPatterns;


// Main program to demonstrate the Adapter Pattern
class Program
{
    static void Main(string[] args)
    {
        // Playing an MP4 video using the MP4Player, which directly implements IVideoPlayer
        IVideoPlayer mp4Player = new MP4Player();
        mp4Player.PlayVideo("movie.mp4"); // Output: Playing MP4 video: movie.mp4

        // Playing a VLC video using VLCPlayer, adapted to IVideoPlayer using VLCPlayerAdapter
        VLCPlayer vlcPlayer = new VLCPlayer();
        IVideoPlayer vlcAdapter = new VLCPlayerAdapter(vlcPlayer);
        vlcAdapter.PlayVideo("documentary.vlc"); // Output: Playing VLC video: documentary.vlc
    }
}