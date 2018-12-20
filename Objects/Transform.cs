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
        //интерфейс объекта, содержит методы для взаимодействия с объектом
        public interface IObject
        {
            List<IModel> GetModel();//получение модели, модель - куб, икосаэдр
            List<KeyValuePair<PolyLine3D, Color>> GetLinesAndColors();//получение списка линий и цветов для модели
            Vector3 GetPosition();//получаем позицию объекта
            List<PolyLine3D> GetLines();//получаем линии объекта
            List<Color> GetColors();//получаем цвета линий
            Camera GetCamera();//получаем камеру
            void Update(float delta);//обновление объекта(глобально)
            void Update();
            void CheckTextBox();//проверка входных данных
            void DataDisplay();//вывод данных в отдельные окна
            void SetRotate(float x, float y);//установка поворота объекта
            void SetPosition(float x, float y);//установка позиции объекта
            void SetView(Matrix4 view);
            Matrix4 GetView(Matrix4 view);
        }
        public class Transform : IObject
        {
            public Camera camera;//камера
            public List<IModel> Model = new List<IModel>();//данные модели
            List<KeyValuePair<PolyLine3D, Color>> linesAndColors = new List<KeyValuePair<PolyLine3D, Color>>();//лист с линиями и цветами модели
            public List<PolyLine3D> Lines = new List<PolyLine3D>();//лист с линиями
            public List<Color> Colors = new List<Color>();//лист с цветами
            string name;//имя объекта
            public string Name { get => name; set => name = value; }//свойство name
            public Vector3 position, rotation, rotating;//различные вектора, позиция, поворот, скейл, вектор скорости
            public TextBox posX, posY, rotX, rotY, rotZ, rotatingX, rotatingY, rotatingZ;//различные текст боксы нужные для ввода данных
            public TextBox getPosX, getPosY, getRotX, getRotY, getRotZ, getRotatingX, getRotatingY, getRotatingZ;//различные текст боксы нужные для ввода данных
            public  bool isErrorUpdate;//ошибка обновления данных
            public Label labelNameObject;//надпись имени объекта
            public float EdgeLength;//Длина 
            public float scale;
            public Matrix4 view = Matrix4.One();
            public void Update(float scale)
            {
                if (!isErrorUpdate)
                {
                    camera = new Camera(rotation.X+= rotating.X, rotation.Y += rotating.Y, rotation.Z += rotating.Z, scale);
                    
                }
                
            }

            public void Update()
            {
                if (!isErrorUpdate)
                {
                    camera = new Camera(rotation.X += rotating.X, rotation.Y += rotating.Y, rotation.Z += rotating.Z, 1);
                    camera.View = view;
                }
            }

            public void SetRotate(float x, float y)
            {
                rotation.X = x;
                rotation.Y = y;
            }

            public void SetPosition(float x, float y)
            {
                position.X = x;
                position.Y = y;
            }

            public List<PolyLine3D> SetLines(List<PolyLine3D> l)
            {
                Lines = l;
                return Lines;
            }

            public void SetView(Matrix4 view)
            {
                this.view = view;
            }

            public Matrix4 GetView(Matrix4 view)
            {
                return this.view *= view;
            }

            public void CheckTextBox()
            {
                try
                {
                    position.X = float.Parse(posX.Text);
                    position.Y = float.Parse(posY.Text);
                    rotation.X = float.Parse(rotX.Text);
                    rotation.Y = float.Parse(rotY.Text);
                    rotation.Z = float.Parse(rotZ.Text);

                    rotating.X = float.Parse(rotatingX.Text);
                    rotating.Y = float.Parse(rotatingY.Text);
                    rotating.Z = float.Parse(rotatingZ.Text);
                    isErrorUpdate = false;
                    labelNameObject.Text = Name;
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите верные данные");
                    isErrorUpdate = true; ;
                }
            }
            public void DataDisplay()
            {
                getPosX.Text = position.X + "";
                getPosY.Text = position.Y + "";
                getRotX.Text = rotation.X + "";
                getRotY.Text = rotation.Y + "";
                getRotZ.Text = rotation.Z + "";
                getRotatingX.Text = rotating.X + "";
                getRotatingY.Text = rotating.Y + "";
                getRotatingZ.Text = rotating.Z + "";

            }
            public Transform(Cube cube, Scene scene, Vector3 _position, Vector3 _rotation, Vector3 _rotating, TextBox posX, TextBox posY,  TextBox rotX, TextBox rotY, TextBox rotZ, Label labelNameObject, TextBox getPosX, TextBox getPosY, TextBox getRotX, TextBox getRotY, TextBox getRotZ,  TextBox rotatingX, TextBox rotatingY, TextBox rotatingZ, float EdgeLength, float scale, TextBox getRotatingX, TextBox getRotatingY, TextBox getRotatingZ)
            {
                Model.Add(cube);
                Name = "Cube object #" + scene.objects.Count;
                this.position = _position;
                
                this.rotation = _rotation;
                this.rotation.isVectorRotate = true;
                this.scale = scale;
                camera = new Camera(rotation.X, rotation.Y, rotation.Z, scale);
                this.labelNameObject = labelNameObject;
                this.posX = posX;
                this.posY = posY;

                this.rotX = rotX;
                this.rotY = rotY;
                this.rotZ = rotZ;

                this.getPosX = getPosX;
                this.getPosY = getPosY;

                this.getRotX = getRotX;
                this.getRotY = getRotY;
                this.getRotZ = getRotZ;

                this.rotatingX = rotatingX;
                this.rotatingY = rotatingY;
                this.rotatingZ = rotatingZ;
                this.getRotatingX = getRotatingX;
                this.getRotatingY = getRotatingY;
                this.getRotatingZ = getRotatingZ;
                rotating = _rotating;
                this.EdgeLength = EdgeLength;
            }

            public Transform(IcosahedronModel icosahedronModel, Scene scene, Vector3 _position, Vector3 _rotation, Vector3 _rotating, TextBox posX, TextBox posY, TextBox rotX, TextBox rotY, TextBox rotZ, Label labelNameObject, TextBox getPosX, TextBox getPosY, TextBox getRotX, TextBox getRotY, TextBox getRotZ, TextBox rotatingX, TextBox rotatingY, TextBox rotatingZ, float EdgeLength, float scale, TextBox getRotatingX, TextBox getRotatingY, TextBox getRotatingZ)
            {
                Model.Add(icosahedronModel);
                Name = "Icosahedron object #" + scene.objects.Count;
                this.position = _position;

                this.rotation = _rotation;
                this.rotation.isVectorRotate = true;
                camera = new Camera(rotation.X, rotation.Y, rotation.Z, scale);
                this.labelNameObject = labelNameObject;
                this.posX = posX;
                this.posY = posY;

                this.rotX = rotX;
                this.rotY = rotY;
                this.rotZ = rotZ;

                this.getPosX = getPosX;
                this.getPosY = getPosY;

                this.getRotX = getRotX;
                this.getRotY = getRotY;
                this.getRotZ = getRotZ;

                this.rotatingX = rotatingX;
                this.rotatingY = rotatingY;
                this.rotatingZ = rotatingZ;
                this.getRotatingX = getRotatingX;
                this.getRotatingY = getRotatingY;
                this.getRotatingZ = getRotatingZ;
                rotating = _rotating;
                this.EdgeLength = EdgeLength;
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
                return position;
            }

            public Camera GetCamera()
            {
                return camera;
            }
        }
    }
}