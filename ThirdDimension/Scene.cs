using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using Icosahedron.Math;
using Icosahedron.Models;
using Objects.Transform;

namespace Icosahedron.ThirdDimension
{
    public class Scene
    {
        public List<IObject> objects = new List<IObject>();
        

        
        public void SetLines()
        {
            foreach (var m in objects)
            {
                m.GetLines().Clear();
                foreach (var pl in m.GetModel())
                {
                    foreach (var pl1 in pl.GetLines())
                    {
                        m.GetLines().Add((pl1));
                    }
                }
            }
        }

        public void SetColors()
        {
            foreach (var m in objects)
            {
                m.GetColors().Clear();
                foreach (var n in m.GetModel())
                {
                    Random rnd = new Random();
                    int r, g, b;
                    for (int i = 0; i < n.GetLines().Count(); i++)
                    {
                        r = rnd.Next(0, 255);
                        g = rnd.Next(0, 255);
                        b = rnd.Next(0, 255);
                        m.GetColors().Add(Color.FromArgb(255, r, g, b));
                    }
                }
            }
        }


        public void SetLinesAndColorsInOneList()
        {
            foreach (var _object in objects)
            {
                
                _object.GetLinesAndColors().Clear();
                for (int i = 0; i < _object.GetLines().Count(); i++)
                {
                    _object.GetLinesAndColors().Add(new KeyValuePair<PolyLine3D, Color>(_object.GetLines()[i], _object.GetColors()[i]));
                }
            }
        }

        public void PrepareSceneImage()
        {
            SetLines();
            SetColors();
            SetLinesAndColorsInOneList();
        }


        public Bitmap DrawScene(Screen s, bool color)
        {
            Bitmap bmp = new Bitmap(s.Size.Width, s.Size.Height);
            Graphics g = Graphics.FromImage(bmp);


            foreach(var _object in objects)
            {
                bmp = DrawObject(bmp, g, _object, color);
            }

            g.Dispose();
            return bmp;
        }
        public Bitmap DrawObject(Bitmap bmp, Graphics g, IObject _IObject, bool color)
        {
            List<KeyValuePair<PolyLine3D, Color>> lines2 = new List<KeyValuePair<PolyLine3D, Color>>();
            g = Graphics.FromImage(bmp);

            for (int i = 0; i < _IObject.GetLinesAndColors().Count; ++i)
                {
                    var p = new PolyLine3D(_IObject.GetLinesAndColors()[i].Key.points.ConvertAll(a =>
                    {
                        Vector3 b = _IObject.GetCamera().Model2Camera(a);
                        b.X += _IObject.GetPosition().X;
                        b.Y += _IObject.GetPosition().Y;
                        b.Z += _IObject.GetPosition().Z;
                        return b;
                    }), false);


                    lines2.Add(new KeyValuePair<PolyLine3D, Color>(p, _IObject.GetLinesAndColors()[i].Value));
                }
            

            lines2.Sort((a, b) =>
            {
                float sumA = 0;
                float sumB = 0;
                for (int i = 0; i < a.Key.points.Count - 1; i++)
                {
                    sumA += a.Key.points[i].Z;
                    sumB += b.Key.points[i].Z;
                }
                return (int)(sumA - sumB);
            });

            int idx = 0;
            foreach (var l in lines2)
            {
                var p = l.Key;
                var p2 = p.points.ConvertAll(a => (new PointF(a.X, a.Y))).ToArray();
                if (color)
                    g.FillPolygon(new SolidBrush(l.Value), p2);
                else
                    g.DrawPolygon(Pens.Black, p2);
                ++idx;
            }

            g.Dispose();
            return bmp;
        }

        public Bitmap DrawSceneImage(Screen s, Camera c, bool color)
        {
            Bitmap bmp = new Bitmap(s.Size.Width*2, s.Size.Height*2);
            Graphics g = Graphics.FromImage(bmp);
            List<KeyValuePair<PolyLine3D, Color>> lines2 = new List<KeyValuePair<PolyLine3D, Color>>();

            foreach (var _object in objects)
            {
                for (int i = 0; i < _object.GetLinesAndColors().Count; ++i)
                {
                    var p = new PolyLine3D(_object.GetLinesAndColors()[i].Key.points.ConvertAll(a =>
                    {
                        Vector3 b = c.Model2Camera(a);
                        b.X += _object.GetPosition().X;
                        b.Y += _object.GetPosition().Y;
                        b.Z += _object.GetPosition().Z;
                        return b;
                    }), false);


                    lines2.Add(new KeyValuePair<PolyLine3D, Color>(p, _object.GetLinesAndColors()[i].Value));
                }
            }
            
            lines2.Sort((a, b) =>
            {
                float sumA = 0;
                float sumB = 0;
                for (int i = 0; i < a.Key.points.Count - 1; i++)
                {
                    sumA += a.Key.points[i].Z;
                    sumB += b.Key.points[i].Z;
                }
                return (int)(sumA - sumB);
            });

            int idx = 0;
            foreach (var l in lines2)
            {
                var p = l.Key;
                var p2 = p.points.ConvertAll(a => (new PointF(a.X, a.Y))).ToArray();
                if (color)
                    g.FillPolygon(new SolidBrush(l.Value), p2);
                else
                    g.DrawPolygon(Pens.Black, p2);
                ++idx;
            }

            g.Dispose();
            return bmp;
        }
    }
}
