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
using Xamarin.Essentials;

namespace RFID.Services
{
    // Token: 0x020000C5 RID: 197
    public class ConfigrationOfModelD2Service
    {
        // Token: 0x06000453 RID: 1107 RVA: 0x0001DB12 File Offset: 0x0001BD12
        public static ConfigrationOfModelD2Service GetService()
        {
            return ConfigrationOfModelD2Service.instance;
        }

        // Token: 0x06000454 RID: 1108 RVA: 0x000026F6 File Offset: 0x000008F6
        private ConfigrationOfModelD2Service()
        {
        }

        // Token: 0x06000455 RID: 1109 RVA: 0x0001DB19 File Offset: 0x0001BD19
        public void UseProtocol(ConfigrationOfModelD2Service.Protocol protocol)
        {
            Preferences.Set("key_useProtocal", Enum.GetName(protocol.GetType(), protocol));
        }

        // Token: 0x06000456 RID: 1110 RVA: 0x0001DB3C File Offset: 0x0001BD3C
        public ConfigrationOfModelD2Service.Protocol UsingProtocol()
        {
            string key = "key_useProtocal";
            ConfigrationOfModelD2Service.Protocol result = ConfigrationOfModelD2Service.Protocol.I8k6c;
            string value = Preferences.Get(key, result.ToString());
            try
            {
                result = (ConfigrationOfModelD2Service.Protocol)Enum.Parse(typeof(ConfigrationOfModelD2Service.Protocol), value);
            }
            catch
            {
                result = ConfigrationOfModelD2Service.Protocol.I8k6c;
            }
            return result;
        }

        // Token: 0x040002DF RID: 735
        private static readonly ConfigrationOfModelD2Service instance = new ConfigrationOfModelD2Service();

        // Token: 0x040002E0 RID: 736
        private const string key_useProtocol = "key_useProtocal";

        // Token: 0x020000C6 RID: 198
        public enum Protocol
        {
            // Token: 0x040002E2 RID: 738
            I8k6c,
            // Token: 0x040002E3 RID: 739
            I8k6b
        }
    }
}