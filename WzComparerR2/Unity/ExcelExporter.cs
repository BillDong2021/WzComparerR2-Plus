using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using WzComparerR2.WzLib;

namespace WzComparerR2
{
    public class ExcelExporter
    {
        public static void OutputExcel()
        {
            var excelApp = new Application();
            var workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
            
            //Wz_Node commodity = BaseNode.GetChild("Etc\\Commodity.img");
            for (int i = 1; i < 10; i++)
            {
                worksheet.Cells[i , 1].Value2 = i;
            }

            workbook.SaveAs("D:\\Games\\MapleStory\\CashShop.xlsx");
            workbook.Close();
            excelApp.Quit();

            Console.WriteLine("Excel 文件已导出");
        }
    }
}