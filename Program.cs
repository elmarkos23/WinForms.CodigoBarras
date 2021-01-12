using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZXing;

namespace WinForms.CodigoBarras
{
    class Program
    {
        static void Main(string[] args)
        {
            //instalar nuget
            // Install-Package ZXing.Net 

            //codigo
            string strCodigo = "1911201301110302914400110010010000000041234567810";

            // instantiate a writer object
            var barcodeWriter = new BarcodeWriter();

            // set the barcode format
            barcodeWriter.Format = BarcodeFormat.CODE_39;

            // write text and generate a 2-D barcode as a bitmap
            barcodeWriter.Write(strCodigo).Save(@"D:\\"+ strCodigo + ".png");
        }
    }
}
