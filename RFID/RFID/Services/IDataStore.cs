using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RFID.Services
{
    // Token: 0x020000C4 RID: 196
    public interface IDataStore<T>
    {
        // Token: 0x0600044E RID: 1102
        Task<bool> AddItemAsync(T item);

        // Token: 0x0600044F RID: 1103
        Task<bool> UpdateItemAsync(T item);

        // Token: 0x06000450 RID: 1104
        Task<bool> DeleteItemAsync(string id);

        // Token: 0x06000451 RID: 1105
        Task<T> GetItemAsync(string id);

        // Token: 0x06000452 RID: 1106
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}