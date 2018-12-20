using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Icosahedron.Math;

namespace Icosahedron.ThirdDimension
{
    public class Camera
    {
        public Matrix4 View { get; set; }
        public Matrix4 Projection { get; set; }
        public Matrix4 Translation { get; set; }
        
        public Camera()
        {
            View = Matrix4.One();
            Projection = Matrix4.One();
            Translation = Matrix4.One();
        }

        public Camera(float xRotate, float yRotate, float zRotate, float delta)
        {
            View = Matrix4.One();
            Projection = Matrix4.One();
            Translation = Matrix4.One();

            Projection *= Matrix4.CreateRotationMatrix(0, (float)(xRotate * System.Math.PI / 180));//ZY
            Projection *= Matrix4.CreateRotationMatrix(2, (float)(zRotate * System.Math.PI / 180));//XY
            Projection *= Matrix4.CreateRotationMatrix(1, (float)(yRotate * System.Math.PI / 180));//XZ
        }

        public Vector3 Model2Camera(Vector3 point)
        {
            return Translation * Projection * View * ((Vector4)point);
        }

        public Vector3 Camera2Model(Vector3 point)
        {
            return Projection * View * ((Vector4)point);
        }
    }
}
