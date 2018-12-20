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
            MyPictureBox.MouseWheel += new MouseEventHandler(MyPictureBox_MouseWheel);
        }
        Stream myStream = null;
        public string openPath = "", savePath = "";
        ReadAndWrite readAndWrite;
        private Scene scene = new Scene();
        private Camera camera = new Camera();
        Bitmap bmp;
        float trianglesLength = 0;
        byte choosingOfModel, pointerType;
        Point lastPosition = new Point();
        float scalingCoof = 4;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            bmp = scene.DrawScene(new ThirdDimension.Screen(Size, new RectangleF(-1f, 1f, 2f, 2f)), CheckColor());
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyPictureBox.Refresh();
        }

       

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        { 
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


        public void CreateModel(byte choose, Vector3 position, Vector3 rotation, Vector3 rotating)
        {
            switch (choose)
            {
                case 0:
                    scene.objects.Add(new Transform(new Cube(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f), float.Parse(lengthOfTriangle.Text)), scene , position, rotation, rotating, SetPosX, SetPosY, SetPosZ, SetRotX, SetRotY, SetRotZ, label14, GetPosX, GetPosY, GetPosZ, GetRotX, GetRotY, GetRotZ, SetRotatingX, SetRotatingY, SetRotatingZ, float.Parse(lengthOfTriangle.Text), scalingCoof));
                    break;
                case 1:
                    scene.objects.Add(new Transform(new Models.IcosahedronModel(float.Parse(lengthOfTriangle.Text)), scene, position, rotation, rotating, SetPosX, SetPosY, SetPosZ, SetRotX, SetRotY, SetRotZ, label14, GetPosX, GetPosY, GetPosZ, GetRotX, GetRotY, GetRotZ, SetRotatingX, SetRotatingY, SetRotatingZ, float.Parse(lengthOfTriangle.Text), scalingCoof));
                    break;
            }
            label9.Text = "" +  scene.objects.Count;
            Invalidate();
        }

        public bool isLowZeroOrZero(float number)
        {
            return number <= 0;
        }

        //private void FileOpen_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    openFile.Filter = "Бинарные файлы (*.dat)|*.dat";
        //    openFile.FilterIndex = 1;
        //    openFile.RestoreDirectory = true;
        //    using (myStream)
        //    {
        //        try
        //        {
        //            if (openFile.ShowDialog() == DialogResult.OK)
        //            {
        //                openPath = openFile.FileName;
        //                readAndWrite = new ReadAndWrite(openPath);
        //                scene.linesAndColors = readAndWrite.Read();
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Ошибка считывания файла");
        //        }
        //    }
        //}

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
                MessageBox.Show("Укажите размер грани!!!");

            }
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPosition = e.Location;
        }
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MyPictureBox.Focus();
            switch (pointerType)
            {
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

        private void MoveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pointerType = 0;
        }

        private void RotationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pointerType = 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            lastPosition = new Point();
        }

        private void ColorBox_CheckedChanged(object sender, EventArgs e)
        {
            scene.SetColors();
            scene.SetLinesAndColorsInOneList();
        }

        private void Icosahedron_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
if (!isLowZeroOrZero(float.Parse(lengthOfTriangle.Text)))
            {
                if(Icosahedron.Checked)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = 0;
            label24.Text = scalingCoof + "";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pointerType = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scalingCoof++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scalingCoof--;
        }

        private void menuStrip1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector3 position = new Vector3(), rotation = new Vector3(), rotating = new Vector3();
            try
            {
                position = new Vector3(int.Parse(SetCreatePosX.Text), int.Parse(SetCreatePosY.Text), int.Parse(SetCreatePosZ.Text));
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

        //private void FileSave_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFile = new SaveFileDialog();
        //    saveFile.Filter = "Бинарные файлы (*.dat)|*.dat";
        //    saveFile.FilterIndex = 1;
        //    saveFile.RestoreDirectory = true;
        //    using (myStream)
        //    {
        //        try
        //        {
        //            if (saveFile.ShowDialog() == DialogResult.OK)
        //            {
        //                savePath = saveFile.FileName;
        //                ReadAndWrite write = new ReadAndWrite(savePath);
        //                write.Write(scene.linesAndColors);
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Ошибка записи файла");
        //        }
        //    }
        //}
    }
}
