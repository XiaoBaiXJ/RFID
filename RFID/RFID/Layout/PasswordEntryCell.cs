using System;
using Xamarin.Forms;

namespace RFID.Layout
{
    // Token: 0x020000E0 RID: 224
    public class PasswordEntryCell : EntryCell
    {
        // Token: 0x17000163 RID: 355
        // (get) Token: 0x060004DA RID: 1242 RVA: 0x00021A42 File Offset: 0x0001FC42
        // (set) Token: 0x060004DB RID: 1243 RVA: 0x00021A54 File Offset: 0x0001FC54
        public bool IsPassword
        {
            get
            {
                return (bool)base.GetValue(PasswordEntryCell.IsPasswordProperty);
            }
            set
            {
                if (this.IsPassword == value)
                {
                    return;
                }
                base.SetValue(PasswordEntryCell.IsPasswordProperty, value);
                this.OnPropertyChanged("IsPassword");
            }
        }

        // Token: 0x04000358 RID: 856
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create("IsPassword", typeof(bool), typeof(PasswordEntryCell), false, BindingMode.OneWay, null, null, null, null, null);
    }
}
