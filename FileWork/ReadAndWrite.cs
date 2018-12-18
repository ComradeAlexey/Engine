using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Icosahedron.Models;
using Icosahedron.ThirdDimension;
using System.Drawing;

namespace Icosahedron.FileWork
{
    public class ReadAndWrite
    {
        public string Path { get; set; }

        public ReadAndWrite(string path)
        {
            this.Path = path;
        }

        public List<KeyValuePair<PolyLine3D, Color>> Read()
        {
            List<KeyValuePair<PolyLine3D, Color>> listOfLines = new List<KeyValuePair<PolyLine3D, Color>>();
            //List<PolyLine3D> listOfLines = new List<PolyLine3D>();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream aFile = new FileStream(Path, FileMode.Open))
            {
                listOfLines = (List<KeyValuePair<PolyLine3D, Color>>)binaryFormatter.Deserialize(aFile);
            }
            return listOfLines;
        }

        public void Write(List<KeyValuePair<PolyLine3D, Color>> listOfLines)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream aFile = new FileStream(Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(aFile, listOfLines);
            }
        }

    }
}
