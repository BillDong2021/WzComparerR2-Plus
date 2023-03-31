using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzComparerR2.WzLib;

namespace Test
{
    internal class Program
    {
        public static Wz_Structure Wz_Structure;
        public static Wz_Image Wz_Image;
        static void Main(string[] args)
        {
            Load();

            var node = Wz_Structure.WzNode.GetChild($"Character\\00012000.img\\walk1\\0\\head", true);
            var node2 = Wz_Structure.WzNode.GetChild($"Character\\00012000.img\\walk1\\0\\head\\origin", true);
            //var node3 = node.GetValue<Wz_Uol>().HandleUol(node);

            Wz_Node character = Wz_Structure.WzNode.Nodes.ElementAt(4);  //Character
            Wz_Node imgNode = character.Nodes.ElementAt(8); //00002000;

            //var image = imgNode.Value as Wz_Image;
            //image.TryExtract();
            //Console.WriteLine(image.Node == imgNode);
            //Console.WriteLine(image.Node == imgNode.Value);

            //Wz_Node t = imgNode.FindNodeByPath("stand1\\0", true);
            //Console.WriteLine("");
            //Wz_Node m = imgNode.FindNodeByPath("doublefire\\0", true);

            Wz_Node w = character.FindNodeByPath("Weapon", true);
            Wz_Node w2 = character.FindNodeByPath("Weapon\\01302000.img", true);
            Wz_Node w3 = character.FindNodeByPath("Weapon\\01302000.img\\walk1", false);
            Wz_Node w4 = character.FindNodeByPath("Weapon\\01302000.img\\walk1\\0", false);
            Wz_Node w5 = character.FindNodeByPath("Weapon\\01302000.img\\walk1\\2\\weapon", true);
            //Wz_Node test = w5.ResolveUol();

            Wz_Node h = Wz_Structure.WzNode.FindNodeByPath("Character\\Afterimage", true);
            Wz_Node h2 = Wz_Structure.WzNode.FindNodeByPath("Character\\Afterimage\\swordOL.img", true);
            Wz_Node h3 = Wz_Structure.WzNode.GetChild("Character\\Afterimage\\swordOL.img", true);
            Wz_Node h4 = Wz_Structure.WzNode.GetChild("Character\\Afterimage\\swordOL.img\\7\\swingO1\\2\\0", true);

            //Console.WriteLine(h.Nodes["swordOL.img"]== h3);

            Wz_Node s = Wz_Structure.WzNode.GetChild("Skill", true);
            Wz_Node s2 = Wz_Structure.WzNode.GetChild("Skill\\131.img", true);
            Wz_Node s3 = Wz_Structure.WzNode.GetChild("Skill\\131.img\\skill\\1311002\\effect", true);
            Wz_Node test = s3.ResolveUol();
            
            Console.WriteLine("");
        }

        public static void Load()
        {
            var wzFilePath = "D:\\Games\\MapleStory\\wz\\Base.wz";
            Wz_Structure = new Wz_Structure();
            Wz_Structure.Load(wzFilePath, true);
            Console.WriteLine("");
            Console.WriteLine("Done");
        }
    }
}
