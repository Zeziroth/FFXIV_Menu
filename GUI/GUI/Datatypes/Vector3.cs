using System;

namespace GUI.Datatypes
{
    public class Vector3
    {
        public float x { get; }
        public float y { get; }
        public float z { get; }

        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public override string ToString()
        {
            return "X: " + x.ToString() + " | Y: " + y.ToString() + " | Z:" + z.ToString();
        }

        public double DistanceTo(Vector3 target)
        {
            Vector3 difference = new Vector3(x - target.x, y - target.y, z - target.z);
            double distance = Math.Sqrt(Math.Pow(difference.x, 2f) + Math.Pow(difference.y, 2f) + Math.Pow(difference.z, 2f));
            return distance;
        }
    }
}
