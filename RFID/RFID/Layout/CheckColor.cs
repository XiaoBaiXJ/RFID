// RFID.Layout.Checkbox
// Token: 0x17000155 RID: 341
// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001F97E File Offset: 0x0001DB7E
// (set) Token: 0x0600049B RID: 1179 RVA: 0x0001F990 File Offset: 0x0001DB90
public Color CheckColor
{
    get
    {
        return (Color)base.GetValue(Checkbox.CheckColorProperty);
    }
    set
    {
        if (this.CheckColor == value)
        {
            return;
        }
        base.SetValue(Checkbox.CheckColorProperty, value);
        this.OnPropertyChanged("CheckColor");
    }
}
