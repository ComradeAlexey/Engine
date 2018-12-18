using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icosahedron;
using Icosahedron.Math;
using Icosahedron.Models;
using Icosahedron.ThirdDimension;

namespace Objects
{

    namespace Transform
    {
        public interface IObject
        {
            List<IModel> GetModel();
            List<KeyValuePair<PolyLine3D, Color>> GetLinesAndColors();
            Vector3 GetPosition();
            List<PolyLine3D> GetLines();
            List<Color> GetColors();
            Camera GetCamera();
        }
        public class Transform : IObject
        {
            public Camera camera;
            public List<IModel> Model = new List<IModel>();
            List<KeyValuePair<PolyLine3D, Color>> linesAndColors = new List<KeyValuePair<PolyLine3D, Color>>();
            public List<PolyLine3D> Lines = new List<PolyLine3D>();
            public List<Color> Colors = new List<Color>();
            string name;
            Vector3 moveVector;
            public string Name { get => name; set => name = value; }
            public Vector3 MoveVector { get => moveVector; set => moveVector = value; }
            public Vector3 _position;

            public Transform(Cube cube, Scene scene, Vector3 _position, Vector3 _rotation)
            {
                Model.Add(cube);
                Name = "Cube object #" + scene.objects.Count;
                this._position = _position;
                camera = new Camera(_rotation.X, _rotation.Y, _rotation.Z);
            }

            public Transform(IcosahedronModel icosahedronModel, Scene scene, Vector3 _position, Vector3 _rotation)
            {
                Model.Add(icosahedronModel);
                Name = "Icosahedron object #" + scene.objects.Count;
                this._position = _position;
                camera = new Camera(_rotation.X, _rotation.Y, _rotation.Z);

            }

            public List<IModel> GetModel()
            {
                return Model;
            }

            public List<KeyValuePair<PolyLine3D, Color>> GetLinesAndColors()
            {
                return linesAndColors;
            }

            public List<PolyLine3D> GetLines()
            {
                return Lines;
            }
            public List<Color> GetColors()
            {
                return Colors;
            }
            public Vector3 GetPosition()
            {
                return _position;
            }

            public Camera GetCamera()
            {
                return camera;
            }
            class Position
            {
                Matrix4 position;//позиция объекта

                public Matrix4 _position { get => position; set => position = value; }

                public static Matrix4 CreateMovingMatrix(int dx, int dy, int dz)
                {
                    var m = Matrix4.One();
                    m[0, 3] = (float)dx;
                    m[1, 3] = (float)dy;
                    m[2, 3] = (float)dz;
                    return m;
                }

                public static Vector3 MovingVertex(Matrix4 moveMatrix, Vector3 moveVector3, Vector4 vertex)
                {
                    Vector3 v3MP = moveVector3;
                    return CreateMovingMatrix((int)v3MP.X, (int)v3MP.Y, (int)v3MP.Z) * vertex;
                }
            }
        }
    }
}