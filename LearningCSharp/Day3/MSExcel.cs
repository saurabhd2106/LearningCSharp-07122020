using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class MSExcel : MSOffice, MSProduct
    {
        public void Info()
        {
            Console.WriteLine("MSExcel :Info Method");
        }

        public void NewFile()
        {
            Console.WriteLine("MSExcel :New File Method");
        }

        public void Save()
        {
            Console.WriteLine("MSExcel :Save Method");
        }

        public void SaveAs()
        {
            Console.WriteLine("MSExcel :Save As Method");
        }

        public void Print()
        {
            Console.WriteLine("MSExcel :Print Method");
        }

        public void NavigationBar()
        {
            Console.WriteLine("MSExcel :Navigation Bar Method");
        }
    }
}
