using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using RFID.Services;
using RFID.Droid.Services;
using ZXing.Mobile;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

[assembly:Dependency(typeof(IQRCodeScanService))]
namespace RFID.Droid.Services
{
    public class QRCodeScanService : IQRCodeScanService
    {
        public async Task<string> ScanAsync()
        {
            var optionDefaut = new MobileBarcodeScanningOptions();
            var scanner = new MobileBarcodeScanner()
            {
                TopText = AppResource.scan,
                BottomText = AppResource.sacndetail
            };
            var scanResult = await scanner.Scan(optionDefaut);
            return scanResult.Text;
        }
    }
}