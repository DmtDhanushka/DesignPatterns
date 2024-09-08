using DesignPatterns;



// Client code using IVideoPlayer
class Program
{
    static void Main(string[] args)
    {
        // Play MP4 using the standard player
        IVideoPlayer mp4Player = new MP4Player();
        mp4Player.PlayVideo("movie.mp4");  // Output: Playing MP4 video: movie.mp4

        // VLC player
        VLCPlayer vlcPlayer = new VLCPlayer();
        
        // Play VLC video using the adapter
        IVideoPlayer vlcAdapter = new VLCPlayerAdapter(vlcPlayer);
        vlcAdapter.PlayVideo("clip.vlc");  // Output: Playing VLC video: clip.vlc
    }
}