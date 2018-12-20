using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icosahedron.ThirdDimension;
using Icosahedron.Models;
using Icosahedron.Math;
using Icosahedron.FileWork;
using System.IO;
using Objects.Transform;

namespace Icosahedron
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //приделываем событие прокрутки колёсика 
            MyPictureBox.MouseWheel += new MouseEventHandler(MyPictureBox_MouseWheel);
        }
        //объявление переменных
        private Scene scene = new Scene();//создаём сцену
        Bitmap bmp;//создаём картинку
        float trianglesLength = 0;//длина треугольников
        byte choosingOfModel, pointerType;//переменные для выбора
        //отрисовка пикчербокса
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            //отрисовка сцены
            bmp = scene.DrawScene(new ThirdDimension.Screen(Size, new RectangleF(-1f, 1f, 2f, 2f)), CheckColor());
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
        //запуск перерисовки пикчербокса
        private void timer1_Tick(object sender, EventArgs e)
        {
            MyPictureBox.Refresh();
        }
        //создание модели
        public void CreateModel(byte choose, Vector3 position, Vector3 rotation, Vector3 rotating)
        {
            //выбор модели
            switch (choose)
            {
                case 0:
                    scene.objects.Add(new Transform(new Cube(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f), float.Parse(lengthOfTriangle.Text)), scene , position, rotation, rotating, SetPosX, SetPosY, SetRotX, SetRotY, SetRotZ, label14, GetPosX, GetPosY, GetRotX, GetRotY, GetRotZ, SetRotatingX, SetRotatingY, SetRotatingZ, float.Parse(lengthOfTriangle.Text),GetRotatingX, GetRotatingY, GetRotatingZ));
                    break;
                case 1:
                    scene.objects.Add(new Transform(new Models.IcosahedronModel(float.Parse(lengthOfTriangle.Text)), scene, position, rotation, rotating, SetPosX, SetPosY, SetRotX, SetRotY, SetRotZ, label14, GetPosX, GetPosY,  GetRotX, GetRotY, GetRotZ, SetRotatingX, SetRotatingY, SetRotatingZ, float.Parse(lengthOfTriangle.Text),  GetRotatingX, GetRotatingY, GetRotatingZ));
                    break;
            }
            //вывод кол-ва объектов на сцене
            label9.Text = "" +  scene.objects.Count;
            //запуск перерисовки пикчербокса
            Invalidate();
        }
        //проверка числа, меньше либо равно ли оно нулю
        public bool isLowZeroOrZero(float number)
        {
            return number <= 0;
        }

        //изменение выбора модели, куб
        private void Cube_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isLowZeroOrZero(float.Parse(lengthOfTriangle.Text)))
                {
                    if (CubeRadiobutton.Checked)
                        choosingOfModel = 0;
                    else
                        choosingOfModel = 1;

                }
            }
            catch (Exception)
            {
                //в случае если не указан размер грани то вылазит предупреждение
                MessageBox.Show("Укажите размер грани!!!");

            }
            
        }

        //событие прокрутки колёсика мыши
        void MyPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int i = 0;
            foreach (var _object in scene.objects)
            {
                if (i == ThisChoiseObject.Value)
                {
                    _object.SetView(_object.GetView(Matrix4.CreateScrollingMatrix(e.Delta)));

                    Invalidate();
                }
                i++;
            }

        }

        //событие передвижения мыши над пикчербоксом и дальнейший анализ действий юзера
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MyPictureBox.Focus();
            switch (pointerType)
            {
                //0 -> перемещение выбранной модели 1-> поворот выбранной модели
                case 0:
                    if (e.Button.HasFlag(MouseButtons.Left))
                    {
                        int i = 0;
                        foreach (var _object in scene.objects)
                        {
                            if (i == ThisChoiseObject.Value)
                            {
                                _object.SetPosition(e.X, e.Y);
                                Invalidate();
                            }
                            i++;
                        }
                    }
                    break;
                case 1:
                    if (e.Button.HasFlag(MouseButtons.Left))
                    {
                        int i = 0;
                        foreach (var _object in scene.objects)
                        {
                            if (i == ThisChoiseObject.Value)
                            {
                                _object.SetRotate(e.X, e.Y);
                                
                                Invalidate();
                            }
                            i++;
                        }
                    }
                    break;
            }

        }
        //установка типа взаимодействия при помощи мыши с моделями
        private void MoveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pointerType = 0;
        }
        //установка типа взаимодействия при помощи мыши с моделями
        private void RotationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pointerType = 1;
        }

        //установка окраски моделей
        private void ColorBox_CheckedChanged(object sender, EventArgs e)
        {
            scene.SetColors();
            scene.SetLinesAndColorsInOneList();
        }
        //тоже самое что и с изменением типа создаваемой модели куба
        private void Icosahedron_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isLowZeroOrZero(float.Parse(lengthOfTriangle.Text)))
                {
                    if (Icosahedron.Checked)
                        choosingOfModel = 1;
                    else
                        choosingOfModel = 0;
                    scene.PrepareSceneImage();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Укажите размер грани!!!");
            }
            
        }
        //смена(или нет) выбранного объекта
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            foreach(var _object in scene.objects)
            {
                
                if(i == ThisChoiseObject.Value)
                {
                    scene.selectedObject = _object;
                }
                i++;
            }
            scene.selectedObject.CheckTextBox();
        }
        //обновление объектов 
        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = 0;
            ThisChoiseObject.Maximum = scene.objects.Count - 1;
            ThisChoiseObject.Minimum = 0;
            foreach (var _object in scene.objects)
            {

                if (i == ThisChoiseObject.Value)
                {
                    _object.DataDisplay();
                    _object.Update();

                }
                else
                {
                    _object.Update();
                }
                i++;
            }
        }

        //создание нового объекта
        private void button2_Click(object sender, EventArgs e)
        {
            Vector3 position = new Vector3(), rotation = new Vector3(), rotating = new Vector3();
            try
            {
                position = new Vector3(int.Parse(SetCreatePosX.Text), int.Parse(SetCreatePosY.Text), 0);
                rotation = new Vector3(int.Parse(SetCreateRotX.Text), int.Parse(SetCreateRotY.Text), int.Parse(SetCreateRotZ.Text));
                rotating = new Vector3(int.Parse(SetCreateRotatingX.Text), int.Parse(SetCreateRotatingY.Text), int.Parse(SetCreateRotatingZ.Text));
                if (!float.TryParse(lengthOfTriangle.Text.Replace('.', ','), out trianglesLength))
                {
                    MessageBox.Show("Введите корректные данные");
                }
                else
                {
                    if (isLowZeroOrZero(trianglesLength))
                    {
                        MessageBox.Show("Длина меньше или равна нулю");
                    }
                    else
                    {
                        CreateModel(choosingOfModel, position, rotation, rotating);
                        scene.PrepareSceneImage();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
        //проверка галочки на чекбоксе цвета
        private bool CheckColor()
        {
            if (ColorBox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
