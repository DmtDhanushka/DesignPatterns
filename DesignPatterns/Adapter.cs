using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    using System;

    // Existing Interface
    public interface IVideoPlayer
    {
        void PlayVideo(string fileName);
    }

    // Concrete Implementation that plays MP4 videos
    public class MP4Player : IVideoPlayer
    {
        public void PlayVideo(string fileName)
        {
            Console.WriteLine("Playing MP4 video: " + fileName);
        }
    }

    // Adapter class to make VLCPlayer compatible with IVideoPlayer
    public class VLCPlayerAdapter : IVideoPlayer
    {
        private VLCPlayer _vlcPlayer;

        // Adapter constructor takes in the incompatible class
        public VLCPlayerAdapter(VLCPlayer vlcPlayer)
        {
            _vlcPlayer = vlcPlayer;
        }

        // Implement PlayVideo using VLC's specific functionality
        public void PlayVideo(string fileName)
        {
            _vlcPlayer.PlayVLCFile(fileName);  // Delegating to VLCPlayer's PlayVLCFile method
        }
    }


}
