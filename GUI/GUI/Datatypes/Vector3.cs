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
    }
}
