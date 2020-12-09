using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoOffice
    {
        static void Main(string[] args)
        {
            //Interface MSOffice
            MSOffice office = new MSExcel();

            //Interface MSProduct
            MSProduct product = new MSExcel();

            MSExcel excel = new MSExcel();

            excel.Print();

            office.NewFile();

            excel.NavigationBar();

            MSProduct msProduct = (MSProduct)office;
            msProduct.NavigationBar();
            
            ((MSProduct)office).NavigationBar();

            product.NavigationBar();



        }
    }
}
