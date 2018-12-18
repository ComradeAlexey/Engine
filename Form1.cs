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

        void MyPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            camera.View *= Matrix4.CreateScrollingMatrix(e.Delta);
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        { 
            timer1.Enabled = true;
            timer1.Interval = 201 - trackBarSpeed.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


        public void CreateModel(byte choose, Vector3 position, Vector3 rotation)
        {
            switch (choose)
            {
                case 0:
                    scene.objects.Add(new Transform(new Cube(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f), float.Parse(lengthOfTriangle.Text)), scene , position, rotation));
                    break;
                case 1:
                    scene.objects.Add(new Transform(new Models.IcosahedronModel(float.Parse(lengthOfTriangle.Text)), scene, position, rotation));
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
            if (!isLowZeroOrZero(float.Parse(lengthOfTriangle.Text)))
            {
                if (CubeRadiobutton.Checked)
                    choosingOfModel = 0;
                else
                    choosingOfModel = 1;

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPosition = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (pointerType)
            {
                case 0:
                    if (e.Button.HasFlag(MouseButtons.Left) && !lastPosition.IsEmpty)
                    {
                        camera.Translation *= Matrix4.CreateMovingMatrix(e.X - lastPosition.X, e.Y - lastPosition.Y);
                        lastPosition = e.Location;
                        Invalidate();
                    }
                    break;
                case 1:
                    if (e.Button.HasFlag(MouseButtons.Left) && !lastPosition.IsEmpty)
                    {
                        Point dp = new Point(e.X - lastPosition.X, e.Y - lastPosition.Y);
                        float alpha = dp.X * (float)System.Math.PI / 180f;
                        float betta = dp.Y * (float)System.Math.PI / 180f;
                        camera.Projection = Matrix4.CreateRotationMatrix(0, -betta) * Matrix4.CreateRotationMatrix(1, alpha) * camera.Projection;
                        lastPosition = e.Location;
                        Invalidate();
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
            if (!isLowZeroOrZero(float.Parse(lengthOfTriangle.Text)))
            {
                if(Icosahedron.Checked)
                    choosingOfModel = 1;
                else
                    choosingOfModel = 0;
                scene.PrepareSceneImage();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                    CreateModel(choosingOfModel, new Vector3(int.Parse(SetPosX.Text), int.Parse(SetPosY.Text), int.Parse(SetPosZ.Text)), new Vector3(int.Parse(SetRotX.Text), int.Parse(SetRotY.Text), int.Parse(SetRotZ.Text)));
                    scene.PrepareSceneImage();
                }
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
