using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class HashTest
    {

        public void Test()
        {
            string filePath = "D:\\Games\\MapleStory\\hashTest\\Character.wz";

            // 使用MD5算法计算文件的哈希值
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    string fileHash = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    Console.WriteLine(fileHash);
                    // 比较文件的当前哈希值与保存的哈希值
                    //if (fileHash == savedHash)
                    //{
                    //    Console.WriteLine("File has not been modified.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("File has been modified.");
                    //}
                }
            }
        }
    }
}
