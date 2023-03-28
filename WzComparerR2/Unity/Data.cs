using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Xna.Framework;

namespace WzComparerR2
{
    public class Data
    {
        public string path;

        [XmlElement("pivot")]
        public Vector2 Pivot { get; set; }
        
        public Data()
        {
            // This constructor is required for XML serialization.
        }

        public Data(string path, Vector2 pivot)
        {
            this.path = path;
            this.Pivot = pivot;
        }
    }

    [XmlRoot("Root")]
    public class RootData
    {
        [XmlArray("dataList")]
        [XmlArrayItem("data")]
        public List<Data> dataList = new List<Data>();

        public void Save(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RootData));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static RootData Load(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RootData));
            using (StreamReader reader = new StreamReader(fileName))
            {
                return serializer.Deserialize(reader) as RootData;
            }
        }
    }

    //public class Data
    //{
    //    public string path;

    //    [XmlElement("position")]
    //    public Vector2 Position { get; set; }



    //    public void Save(string fileName)
    //    {
    //        XmlSerializer serializer = new XmlSerializer(typeof(Data));
    //        using (StreamWriter writer = new StreamWriter(fileName))
    //        {
    //            serializer.Serialize(writer, this);
    //        }
    //    }

    //    public static Data Load(string fileName)
    //    {
    //        XmlSerializer serializer = new XmlSerializer(typeof(Data));
    //        using (StreamReader reader = new StreamReader(fileName))
    //        {
    //            return serializer.Deserialize(reader) as Data;
    //        }
    //    }
    //}
}


