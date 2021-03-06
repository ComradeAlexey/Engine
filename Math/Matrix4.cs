﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Icosahedron.ThirdDimension;

namespace Icosahedron.Math
{
    public struct Matrix4
    {
        private float[] matrix;
        private Matrix4(float[,] m)
        {
            matrix = new float[16];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    matrix[i * 4 + j] = m[i, j];
        }
        public float this[int r, int c]
        {
            get { return matrix[r * 4 + c]; }
            set { matrix[r * 4 + c] = value; }
        }

        public static Matrix4 operator +(Matrix4 left, Matrix4 right) {
            Matrix4 ret = Matrix4.One();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ret[i, j] = left[i, j] + right[i, j];
            return ret;
        }

        public static Matrix4 operator *(Matrix4 matrix, float number)
        {
            var m = Zero();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    m[i, j] = matrix[i, j] * number;
            return m;
        }
        public static Matrix4 operator *(Matrix4 first, Matrix4 second)
        {
            var m = Zero();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        m[i, j] += first[i, k] * second[k, j];
            return m;
        }

        public static Matrix4 Zero()
        {
            var m = new float[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            return new Matrix4(m);
        }

        public static Matrix4 One()
        {
            var m = Zero();
            for (int i = 0; i < 4; i++)
                m[i, i] = 1;
            return m;
        }

        public static Matrix4 Two()
        {
            var m = Zero();
            for (int i = 0; i < 3; i++)
                m[i, i] = 2;
            m[3, 3] = 1;
            return m;
        }

        public static Matrix4 Scrolling(float d)
        {
            var m = Zero();
            for (int i = 0; i < 3; i++)
                m[i, i] = d;
            m[3, 3] = 1;
            return m;
        }

        public static Matrix4 Create(float[,] matrix)
        {
            return new Matrix4(matrix);
        }

        public static Matrix4 CreateRotationMatrix(int axis, float angle)
        {
            var m = Matrix4.One();
            int a1 = (axis + 1) % 3;
            int a2 = (axis + 2) % 3;

            m[a1, a1] = (float)System.Math.Cos(angle);
            m[a1, a2] = (float)-System.Math.Sin(angle);
            m[a2, a1] = (float)System.Math.Sin(angle);
            m[a2, a2] = (float)System.Math.Cos(angle);

            return m;
        }

        public static Matrix4 CreateScrollingMatrix(int delta)
        {
            double coeff;
            if (delta < 0)
                coeff = 1.03;
            else
                coeff = 0.97;
            var m = Matrix4.One();
            m[0, 0] = (float)coeff;
            m[1, 1] = (float)coeff;
            m[2, 2] = (float)coeff;
            return m;
        }

        public static Matrix4 CreateMovingMatrix(int dx, int dy)
        {
            var m = Matrix4.One();
            m[0, 3] = (float)dx;
            m[1, 3] = (float)dy;
            m[2, 3] = (float)10;
            return m;
        }
    }
}
