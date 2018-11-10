using GUI.Datatypes;
using GUI.Memory;

namespace GUI
{
    public static class FFXIV_Core
    {
        public static void TeleportTo(Vector3 v3)
        {
            var address = new Pointer(Form1.xivgame.Process, Form1.xivgame.Definitions.ActorTable + 8, 0);

            Form1.proc.Write(address + Form1.xivgame.Definitions.PositionX, v3.x);
            Form1.proc.Write(address + Form1.xivgame.Definitions.PositionY, v3.y);
            Form1.proc.Write(address + Form1.xivgame.Definitions.PositionZ, v3.z);
        }

        public static float MapToMemory(float x)
        {
            float map_max = 41.9f;
            float loc_max = 1024f;

            float divider = map_max / x;
            return (((loc_max * 2) / divider) - loc_max);
        }
    }
}
