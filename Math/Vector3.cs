using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icosahedron.Math
{
    [Serializable]
    public struct Vector3
    {
        private float[] values;
        public Vector3(float x, float y, float z)
        {
            values = new float[3];
            values[0] = x; values[1] = y; values[2] = z;
        }
        public float X { get { return values[0]; } set { values[0] = value; } }
        public float Y { get { return values[1]; } set { values[1] = value; } }
        public float Z { get { return values[2]; } set { values[2] = value; } }
        public float this[int idx]
        {
            get { return values[idx]; }
            set { values[idx] = value; }
        }
        public static implicit operator Vector3(Vector4 v)
        {
            return v.W == 0 ? new Vector3(v.X, v.Y, v.Z) : new Vector3(v.X / v.W, v.Y / v.W, v.Z / v.W);
        }

        public static Vector3 operator *(Vector3 v,float a)
        {
            return new Vector3(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3 operator +(Vector3 v, float a)
        {
            return new Vector3(v.X + a, v.Y + a, v.Z + a);
        }

        public override string ToString()
        {
            return string.Format("x={0} y={1} z={2}", values[0], values[1], values[2]);
        }
    }
}
