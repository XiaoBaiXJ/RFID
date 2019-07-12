using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RFID.Services
{
    public interface ILocalFileProvider
    {
        // Token: 0x06000488 RID: 1160
        Task<string> SaveFileToDisk(Stream stream, string fileName);
    }
}