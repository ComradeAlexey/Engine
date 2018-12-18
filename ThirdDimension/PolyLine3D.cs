using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Icosahedron.Math;

namespace Icosahedron.ThirdDimension
{
    [Serializable]
    public class PolyLine3D
    {
        public List<Vector3> points { get; private set; }
        public PolyLine3D(IList<Vector3> p, bool closed = true)
        {
            points = new List<Vector3>(p);
            if (closed)
                points.Add(points[0]);
        }
    }
}
