using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Icosahedron.Math;
using Icosahedron.ThirdDimension;

namespace Icosahedron.Models
{
    public class IcosahedronModel : ThirdDimension.IModel
    {
        private Vector3[] arr = new Vector3[12];
        public float TrianglesLength { get; set; }
        public Vector3[] Vertices { get; protected set; }
        public List<Vector3> vertices;
        public Vector3 Center
        {
            get
            {
                Vector3 center = new Vector3(0, 0, 0);
                int cnt = arr.Length;
                foreach (var vert in arr)
                {
                    center.X += vert.X;
                    center.Y += vert.Y;
                    center.Z += vert.Z;
                }
                center.X /= cnt;
                center.Y /= cnt;
                center.Z /= cnt;
                return center;
            }
        }

        public IcosahedronModel(float TrianglesLength)
        {
            arr = new Vector3[12];
            this.TrianglesLength = TrianglesLength;
            vertices = new List<Vector3>();
            // создание 12 вершин икосаэдра;
            float t = (float)((1.0 + System.Math.Sqrt(5.0)) / 2.0);

            vertices.Add(new Vector3(-1, t, 0));
            vertices.Add(new Vector3(1, t, 0));
            vertices.Add(new Vector3(-1, -t, 0));
            vertices.Add(new Vector3(1, -t, 0));

            vertices.Add(new Vector3(0, -1, t));
            vertices.Add(new Vector3(0, 1, t));
            vertices.Add(new Vector3(0, -1, -t));
            vertices.Add(new Vector3(0, 1, -t));

            vertices.Add(new Vector3(t, 0, -1));
            vertices.Add(new Vector3(t, 0, 1));
            vertices.Add(new Vector3(-t, 0, -1));
            vertices.Add(new Vector3(-t, 0, 1));

            arr = vertices.ToArray();
            UpgrageIkos();
        }

        // подтягиваем вершины до пользовательских настроек;
        public void UpgrageIkos()
        {
            for (int j = 0; j < 12; j++)
            {
                arr[j] *= TrianglesLength;
            }
        }

        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> l = new List<PolyLine3D>();
            //построение равносторонних треугольников по соответствующим вершинам;
            l.Add(new PolyLine3D(new List<Vector3>() { arr[0], arr[11], arr[5] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[0], arr[5], arr[1] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[0], arr[1], arr[7] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[0], arr[7], arr[10] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[0], arr[10], arr[11] }));

            l.Add(new PolyLine3D(new List<Vector3>() { arr[1], arr[5], arr[9] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[5], arr[11], arr[4] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[11], arr[10], arr[2] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[10], arr[7], arr[6] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[7], arr[1], arr[8] }));

            l.Add(new PolyLine3D(new List<Vector3>() { arr[3], arr[9], arr[4] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[3], arr[4], arr[2] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[3], arr[2], arr[6] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[3], arr[6], arr[8] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[3], arr[8], arr[9] }));

            l.Add(new PolyLine3D(new List<Vector3>() { arr[4], arr[9], arr[5] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[2], arr[4], arr[11] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[6], arr[2], arr[10] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[8], arr[6], arr[7] }));
            l.Add(new PolyLine3D(new List<Vector3>() { arr[9], arr[8], arr[1] }));

            Vertices = arr;
            return l;
        }
    }
}
