using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icosahedron.ThirdDimension;
using Icosahedron.Math;
using Objects.Transform;

namespace Icosahedron.Models
{
    public class Cube : IModel
    {
        public Transform transform;
        public Vector3 TLF { get; private set; }
        public Vector3 BRN { get; private set; }
        public float EdgeLength { get; set; }

        public Cube(Vector3 tlf, Vector3 brn, float EdgeLength)
        {
            TLF = tlf;
            BRN = brn;
            this.EdgeLength = EdgeLength;
        }

        private List<PolyLine3D> l;

        public List<PolyLine3D> GetLines()
        {
            l = new List<PolyLine3D>();
            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(TLF.X, TLF.Y, TLF.Z), new Vector3(BRN.X, TLF.Y, TLF.Z),
                new Vector3(BRN.X, BRN.Y, TLF.Z), new Vector3(TLF.X, BRN.Y, TLF.Z) }));
            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(TLF.X, TLF.Y, BRN.Z), new Vector3(BRN.X, TLF.Y, BRN.Z),
                new Vector3(BRN.X, BRN.Y, BRN.Z), new Vector3(TLF.X, BRN.Y, BRN.Z) }));
            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(TLF.X, TLF.Y, BRN.Z), new Vector3(TLF.X, BRN.Y, BRN.Z),
                new Vector3(TLF.X, BRN.Y, TLF.Z), new Vector3(TLF.X, TLF.Y, TLF.Z) }));
            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(BRN.X, TLF.Y, TLF.Z), new Vector3(BRN.X, TLF.Y, BRN.Z),
                new Vector3(BRN.X, BRN.Y, BRN.Z), new Vector3(BRN.X, BRN.Y, TLF.Z) }));

            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(TLF.X, TLF.Y, TLF.Z), new Vector3(BRN.X, TLF.Y, TLF.Z),
                new Vector3(BRN.X, TLF.Y, BRN.Z), new Vector3(TLF.X, TLF.Y, BRN.Z) }));

            l.Add(new PolyLine3D(new List<Vector3>() {
                new Vector3(TLF.X, BRN.Y, TLF.Z), new Vector3(BRN.X, BRN.Y, TLF.Z),
                new Vector3(BRN.X, BRN.Y, BRN.Z), new Vector3(TLF.X, BRN.Y, BRN.Z) }));
            UpgradeCube();
            return l;
        }
        public void UpgradeCube()
        {
            for (int i = 0; i < l.Count(); i++)
            {
                for (int j = 0; j < l[i].points.Count(); j++)
                {
                    l[i].points[j] *= EdgeLength;
                }
            }
        }
    }
}
