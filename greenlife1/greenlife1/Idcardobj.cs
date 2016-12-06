using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Barcode;

namespace greenlife1
{
    public class Idcardobj
    {
        public string  QrData { get; set; }
        public string Name { get; set; }

        



        public Idcardobj(string data)
        {
            this.QrData = data;
        }


        public BarcodeSettings QRCODE()
        {
            BarcodeSettings settings = new BarcodeSettings();
            settings.Data = QrData;
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
            settings.ImageHeight = 150;
            settings.ImageWidth = 150;
            settings.X = 6;
            settings.FontColor = Color.Black;
            settings.BackColor = Color.White;
            settings.BottomMargin = 6;
            settings.TopMargin = 6;
            settings.RightMargin = 6;
            settings.LeftMargin = 6;
            settings.QRCodeECL = QRCodeECL.M;
            return settings;
        }

    }
}
