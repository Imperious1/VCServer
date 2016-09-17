using System.Net.Sockets;

namespace VControlWClient
{
    class Utils
    {
        public static void handleVol(int request, int increment)
        {
            switch (request)
            {
                case 1:
                    VolumeChanger.VolumeUp(increment);
                    break;
                case 2:
                    VolumeChanger.VolumeDown(increment);
                    break;
                case 3:
                    VolumeChanger.Mute();
                    break;
            }
        }
    }
}
