using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace WzComparerR2
{
    public class SpritePivotProcessor
    {
        public static void SaveSkillXml()
        {
            RootData rootData = new RootData();
            rootData.dataList.Add(new Data("example1.png", new Vector2(1.0f, 2.0f)));
            rootData.dataList.Add(new Data("example2.png", new Vector2(3.0f, 4.0f)));
            rootData.Save("D:\\Games\\MapleStory\\Pivot\\Skill.xml");
        }
    }
}
