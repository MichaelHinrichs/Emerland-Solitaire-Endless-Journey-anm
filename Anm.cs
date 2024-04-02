using System.IO;

namespace Emerland_Solitaire_Endless_Journey_anm
{
    public static class Anm
    {
        static StreamReader sr;
        public static float[][] Read(string[] args)
        {
            sr = new StreamReader(File.OpenRead(args[0]));
            sr.Read();
            int lines = int.Parse(sr.ReadLine());
            sr.ReadLine();
            float[][] frames = new float[lines][];
            for (int i = 0; i < lines; i++)
                frames[i] = Floats();

            return frames;
        }

        public static float[] Floats()
        {
            string[] floatstrings = sr.ReadLine().Split(' ');
            float[] floats = new float[6];
            for (int i = 0; i < 6; i++)
                floats[i] = float.Parse(floatstrings[i]);

            return floats; 
        }
    }
}
