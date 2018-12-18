using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspector
{
    class Inspector 
    {
        //Позиция объекта
        float posX, posY, posZ;
        //Поворот объекта
        float rotX, rotY, rotZ;
        //Размер объекта
        float sclX, sclY, sclZ;
        public float PosX { get => posX; set => posX = value; }
        public float PosY { get => posY; set => posY = value; }
        public float PosZ { get => posZ; set => posZ = value; }
        public float RotX { get => rotX; set => rotX = value; }
        public float RotY { get => rotY; set => rotY = value; }
        public float RotZ { get => rotZ; set => rotZ = value; }
        public float SclX { get => sclX; set => sclX = value; }
        public float SclY { get => sclY; set => sclY = value; }
        public float SclZ { get => sclZ; set => sclZ = value; }

        public static void InspectorDraw()
        {

        }
    }
}
