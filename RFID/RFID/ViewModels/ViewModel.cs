using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using ES.Dmoral.Toasty;
using Newtonsoft.Json;
using Plugin.CurrentActivity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using RFID.Common;
using RFID.Droid;
using RFID.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.Mobile;

namespace RFID.ViewModels
{
    public class ViewModel
    {

    }

    public class CarPageViewModel : ViewModelBase
    {
        // Token: 0x06000272 RID: 626 RVA: 0x00014770 File Offset: 0x00012970
        public CarPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.SearchCommand = new DelegateCommand(new Action(this.Search));
            this.SelectCommand = new DelegateCommand<AppCar>(new Action<AppCar>(this.Select));
            this.AddCommand = new DelegateCommand(new Action(this.Add));
        }

        // Token: 0x170000E1 RID: 225
        // (get) Token: 0x06000274 RID: 628 RVA: 0x000147FD File Offset: 0x000129FD
        // (set) Token: 0x06000273 RID: 627 RVA: 0x000147CC File Offset: 0x000129CC
        public string CarNo
        {
            get;set;
        }

        // Token: 0x170000E2 RID: 226
        // (get) Token: 0x06000276 RID: 630 RVA: 0x00014838 File Offset: 0x00012A38
        // (set) Token: 0x06000275 RID: 629 RVA: 0x00014808 File Offset: 0x00012A08
        public ObservableCollection<AppCar> CarSource
        {
            get; set;
        }

        // Token: 0x170000E3 RID: 227
        // (get) Token: 0x06000278 RID: 632 RVA: 0x00014870 File Offset: 0x00012A70
        // (set) Token: 0x06000277 RID: 631 RVA: 0x00014840 File Offset: 0x00012A40
        public DelegateCommand SearchCommand
        {
            get; set;
        }

        // Token: 0x170000E4 RID: 228
        // (get) Token: 0x0600027A RID: 634 RVA: 0x000148A8 File Offset: 0x00012AA8
        // (set) Token: 0x06000279 RID: 633 RVA: 0x00014878 File Offset: 0x00012A78
        public DelegateCommand AddCommand
        {
            get; set;
        }

        // Token: 0x170000E5 RID: 229
        // (get) Token: 0x0600027C RID: 636 RVA: 0x000148E0 File Offset: 0x00012AE0
        // (set) Token: 0x0600027B RID: 635 RVA: 0x000148B0 File Offset: 0x00012AB0
        public DelegateCommand<AppCar> SelectCommand
        {
            get; set;
        }

        // Token: 0x170000E6 RID: 230
        // (get) Token: 0x0600027E RID: 638 RVA: 0x00014915 File Offset: 0x00012B15
        // (set) Token: 0x0600027D RID: 637 RVA: 0x000148E8 File Offset: 0x00012AE8
        public bool IsException
        {
            get; set;
        }

        // Token: 0x170000E7 RID: 231
        // (get) Token: 0x06000280 RID: 640 RVA: 0x0001494D File Offset: 0x00012B4D
        // (set) Token: 0x0600027F RID: 639 RVA: 0x00014920 File Offset: 0x00012B20
        public bool IsAll
        {
            get; set;
        }

        // Token: 0x170000E8 RID: 232
        // (get) Token: 0x06000282 RID: 642 RVA: 0x00014985 File Offset: 0x00012B85
        // (set) Token: 0x06000281 RID: 641 RVA: 0x00014958 File Offset: 0x00012B58
        private bool isLock
        {
            get; set;
        }

        // Token: 0x06000283 RID: 643 RVA: 0x00014990 File Offset: 0x00012B90
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            this.apiHelper = new ApiHelper();
            AppResult<List<AppCar>> appResult = await this.apiHelper.PostWithJson<AppResult<List<AppCar>>>("data/GetAllCars", new AppSender<AppSenderDataCollect>
            {
                data = new AppSenderDataCollect
                {
                    CompanyOid = BasicData.User.CompanyOid
                }
            });
            AppResult<List<AppCar>> appResult2 = appResult;
            if (!appResult2.successed || appResult2.data == null)
            {
                this.CarSource = new ObservableCollection<AppCar>();
                this.entireVehicles = new List<AppCar>();
                Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
            }
            else if (parameters.ContainsKey("all"))
            {
                this.IsAll = true;
                this.IsException = false;
                base.Title = "选择车牌号";
                this.entireVehicles = new List<AppCar>();
                this.entireVehicles.Add(new AppCar
                {
                    EIsTransportation = false,
                    ID = "全部车辆"
                });
                this.entireVehicles.AddRange(appResult2.data);
                this.CarSource = new ObservableCollection<AppCar>(this.entireVehicles);
            }
            else if (parameters.ContainsKey("isException"))
            {
                this.IsException = false;
                base.Title = AppResource.carex;
                this.entireVehicles = (from arg in appResult2.data
                                       where arg.EIsTransportation
                                       select arg).ToList<AppCar>();
                this.CarSource = new ObservableCollection<AppCar>(this.entireVehicles);
            }
            else if (parameters.ContainsKey("isLock"))
            {
                this.isLock = true;
                this.IsException = true;
                base.Title = AppResource.car_title;
                this.rfid = parameters["Tag"].ToString();
                this.entireVehicles = appResult2.data;
                this.CarSource = new ObservableCollection<AppCar>(this.entireVehicles);
            }
        }

        // Token: 0x06000284 RID: 644 RVA: 0x000149D1 File Offset: 0x00012BD1
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x06000285 RID: 645 RVA: 0x000149E4 File Offset: 0x00012BE4
        private async void Select(AppCar carno)
        {
            NavigationParameters pairs = new NavigationParameters();
            pairs.Add("car", carno.ID);
            pairs.Add("carno", carno.Oid);
            if (this.isLock)
            {
                base.IsBusy = true;
                pairs.Add("Tag", this.rfid);
                AppResult<AppRFIDVerification> appResult = await this.apiHelper.PostWithJson<AppResult<AppRFIDVerification>>("data/VerificationCar", new AppSender<AppSenderCarInfo>
                {
                    data = new AppSenderCarInfo
                    {
                        CompanyOid = BasicData.User.CompanyOid,
                        CarOid = carno.Oid
                    }
                });
                AppResult<AppRFIDVerification> appResult2 = appResult;
                if (!appResult2.successed)
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取车辆信息").Show();
                    base.IsBusy = false;
                }
                else
                {
                    if (appResult2.data != null && !appResult2.data.EBillStatus && !string.IsNullOrEmpty(appResult2.data.SealingAddress))
                    {
                        pairs.Add("detail", appResult2.data);
                        await base.NavigationService.NavigateAsync("ReLockPage", pairs);
                    }
                    else
                    {
                        await base.NavigationService.NavigateAsync("LockPage", pairs);
                    }
                    base.IsBusy = false;
                }
            }
            else if (this.IsAll)
            {
                await base.NavigationService.GoBackAsync(pairs);
            }
            else
            {
                await base.NavigationService.NavigateAsync("ExceptionPage", pairs);
            }
        }

        // Token: 0x06000286 RID: 646 RVA: 0x00014A28 File Offset: 0x00012C28
        private void Search()
        {
            if (this.entireVehicles == null || this.entireVehicles.Count == 0)
            {
                return;
            }
            this.CarSource.Clear();
            if (string.IsNullOrEmpty(this.CarNo))
            {
                foreach (AppCar item in this.entireVehicles)
                {
                    this.CarSource.Add(item);
                }
                return;
            }
            List<AppCar> list = this.entireVehicles.FindAll((AppCar arg) => arg.ID.Contains(this.CarNo));
            foreach (AppCar item2 in list)
            {
                this.CarSource.Add(item2);
            }
        }

        // Token: 0x06000287 RID: 647 RVA: 0x00014B0C File Offset: 0x00012D0C
        private async void Add()
        {
            AppCar vehicle = new AppCar
            {
                ID = this.CarNo,
                CompanyOid = BasicData.User.CompanyOid,
                Oid = default(Guid),
                EIsTransportation = false
            };
            AppResult<string> appResult = await this.apiHelper.PostWithJson<AppResult<string>>("data/UploadCarInfo", new AppSender<AppCar>
            {
                data = vehicle
            });
            AppResult<string> appResult2 = appResult;
            if (appResult2.successed)
            {
                this.CarSource.Add(vehicle);
                this.entireVehicles.Add(vehicle);
                Toasty.Success(CrossCurrentActivity.Current.Activity, "添加成功").Show();
            }
            else
            {
                Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
            }
        }

        // Token: 0x04000150 RID: 336
        private List<AppCar> entireVehicles;

        // Token: 0x04000155 RID: 341
        private ApiHelper apiHelper;

        // Token: 0x04000159 RID: 345
        private string rfid;
    }

    // Token: 0x02000075 RID: 117
    public class ChangePwdPageViewModel : ViewModelBase
    {
        // Token: 0x06000293 RID: 659 RVA: 0x0001539E File Offset: 0x0001359E
        public ChangePwdPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = AppResource.pwdchange;
            this.apiHelper = new ApiHelper();
            this.SaveCommand = new DelegateCommand(new Action(this.Save));
        }

        // Token: 0x06000294 RID: 660 RVA: 0x000153D4 File Offset: 0x000135D4
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x170000E9 RID: 233
        // (get) Token: 0x06000296 RID: 662 RVA: 0x00015419 File Offset: 0x00013619
        // (set) Token: 0x06000295 RID: 661 RVA: 0x000153E8 File Offset: 0x000135E8
        public string OldPwd
        {
            get; set;
        }

        // Token: 0x170000EA RID: 234
        // (get) Token: 0x06000298 RID: 664 RVA: 0x00015455 File Offset: 0x00013655
        // (set) Token: 0x06000297 RID: 663 RVA: 0x00015424 File Offset: 0x00013624
        public string NewPwd
        {
            get; set;
        }

        // Token: 0x170000EB RID: 235
        // (get) Token: 0x0600029A RID: 666 RVA: 0x00015491 File Offset: 0x00013691
        // (set) Token: 0x06000299 RID: 665 RVA: 0x00015460 File Offset: 0x00013660
        public string RePwd
        {
            get; set;
        }

        // Token: 0x170000EC RID: 236
        // (get) Token: 0x0600029C RID: 668 RVA: 0x000154CC File Offset: 0x000136CC
        // (set) Token: 0x0600029B RID: 667 RVA: 0x0001549C File Offset: 0x0001369C
        public DelegateCommand SaveCommand
        {
            get; set;
        }

        // Token: 0x0600029D RID: 669 RVA: 0x000154D4 File Offset: 0x000136D4
        private async void Save()
        {
            BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/ChangePwd", new AppSender<AppChangePwd>
            {
                data = new AppChangePwd
                {
                    oldpwd = this.OldPwd,
                    newpwd = this.NewPwd,
                    surepwd = this.RePwd
                }
            });
            BaseResponse baseResponse2 = baseResponse;
            if (baseResponse2.successed)
            {
                Toasty.Success(CrossCurrentActivity.Current.Activity, AppResource.changesuccess).Show();
                Preferences.Set("password", this.NewPwd);
            }
            else
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
            }
        }

        // Token: 0x0400016E RID: 366
        private ApiHelper apiHelper;
    }
    // Token: 0x020000B9 RID: 185
    public class CheckLockPageViewModel : LocationViewmodel
    {
        // Token: 0x06000413 RID: 1043 RVA: 0x0001CACE File Offset: 0x0001ACCE
        public CheckLockPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x1700013E RID: 318
        // (get) Token: 0x06000415 RID: 1045 RVA: 0x0001CB2D File Offset: 0x0001AD2D
        // (set) Token: 0x06000414 RID: 1044 RVA: 0x0001CAFC File Offset: 0x0001ACFC
        public string Driver
        {
            get; set;
        }

        // Token: 0x1700013F RID: 319
        // (get) Token: 0x06000417 RID: 1047 RVA: 0x0001CB69 File Offset: 0x0001AD69
        // (set) Token: 0x06000416 RID: 1046 RVA: 0x0001CB38 File Offset: 0x0001AD38
        public string Place
        {
            get; set;
        }

        // Token: 0x17000140 RID: 320
        // (get) Token: 0x06000419 RID: 1049 RVA: 0x0001CBA5 File Offset: 0x0001ADA5
        // (set) Token: 0x06000418 RID: 1048 RVA: 0x0001CB74 File Offset: 0x0001AD74
        public string Arrival
        {
            get; set;
        }

        // Token: 0x17000141 RID: 321
        // (get) Token: 0x0600041B RID: 1051 RVA: 0x0001CBE1 File Offset: 0x0001ADE1
        // (set) Token: 0x0600041A RID: 1050 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
        public string QianfengNo
        {
            get; set;
        }

        // Token: 0x17000142 RID: 322
        // (get) Token: 0x0600041D RID: 1053 RVA: 0x0001CC1C File Offset: 0x0001AE1C
        // (set) Token: 0x0600041C RID: 1052 RVA: 0x0001CBEC File Offset: 0x0001ADEC
        public List<byte[]> ImageFiles
        {
            get; set;
        }

        // Token: 0x17000143 RID: 323
        // (get) Token: 0x0600041F RID: 1055 RVA: 0x0001CC54 File Offset: 0x0001AE54
        // (set) Token: 0x0600041E RID: 1054 RVA: 0x0001CC24 File Offset: 0x0001AE24
        public DelegateCommand CommitCommand
        {
            get; set;
        }

        // Token: 0x06000420 RID: 1056 RVA: 0x0001CC5C File Offset: 0x0001AE5C
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("detail"))
            {
                this.data = (parameters["detail"] as AppRFIDVerification);
                base.Title = this.data.CarID + "->" + AppResource.checklock;
                this.Arrival = this.data.PurposeAddress;
                this.Driver = this.data.CarrierName;
                this.QianfengNo = this.data.Number;
                this.Place = this.data.SealingAddress;
            }
        }

        // Token: 0x06000421 RID: 1057 RVA: 0x00015864 File Offset: 0x00013A64
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x06000422 RID: 1058 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
        private async void Commit()
        {
            if (base.Location == null || base.Location.Longitude == 0.0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取定位信息").Show();
            }
            else if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交巡检照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                AppOnSiteInspection appOnSiteInspection = new AppOnSiteInspection
                {
                    CurrentAddress = base.Location.Address,
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0]),
                    RFIDCode = this.data.RFIDCode,
                    Latitude = Convert.ToDecimal(base.Location.Latitude),
                    Longitude = Convert.ToDecimal(base.Location.Longitude),
                    CompanyOid = BasicData.User.CompanyOid
                };
                BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/EPConSiteInspection", new AppSender<AppOnSiteInspection>
                {
                    data = appOnSiteInspection
                });
                BaseResponse baseResponse2 = baseResponse;
                if (baseResponse2.successed)
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                    await base.NavigationService.GoBackAsync();
                }
                else
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                }
                this.dialog.Dismiss();
            }
        }

        // Token: 0x040002B7 RID: 695
        private AppRFIDVerification data;
    }
    // Token: 0x02000077 RID: 119
    public class DataPageViewModel : LocationViewmodel
    {
        // Token: 0x060002A0 RID: 672 RVA: 0x00015666 File Offset: 0x00013866
        public DataPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = AppResource.shifeng;
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x170000ED RID: 237
        // (get) Token: 0x060002A2 RID: 674 RVA: 0x000156CD File Offset: 0x000138CD
        // (set) Token: 0x060002A1 RID: 673 RVA: 0x0001569C File Offset: 0x0001389C
        public string CarNo
        {
            get; set;
        }

        // Token: 0x170000EE RID: 238
        // (get) Token: 0x060002A4 RID: 676 RVA: 0x00015709 File Offset: 0x00013909
        // (set) Token: 0x060002A3 RID: 675 RVA: 0x000156D8 File Offset: 0x000138D8
        public string Driver
        {
            get; set;
        }

        // Token: 0x170000EF RID: 239
        // (get) Token: 0x060002A6 RID: 678 RVA: 0x00015745 File Offset: 0x00013945
        // (set) Token: 0x060002A5 RID: 677 RVA: 0x00015714 File Offset: 0x00013914
        public string Place
        {
            get; set;
        }

        // Token: 0x170000F0 RID: 240
        // (get) Token: 0x060002A8 RID: 680 RVA: 0x00015781 File Offset: 0x00013981
        // (set) Token: 0x060002A7 RID: 679 RVA: 0x00015750 File Offset: 0x00013950
        public string Arrival
        {
            get; set;
        }

        // Token: 0x170000F1 RID: 241
        // (get) Token: 0x060002AA RID: 682 RVA: 0x000157BD File Offset: 0x000139BD
        // (set) Token: 0x060002A9 RID: 681 RVA: 0x0001578C File Offset: 0x0001398C
        public string QianfengNo
        {
            get; set;
        }

        // Token: 0x170000F2 RID: 242
        // (get) Token: 0x060002AC RID: 684 RVA: 0x000157F8 File Offset: 0x000139F8
        // (set) Token: 0x060002AB RID: 683 RVA: 0x000157C8 File Offset: 0x000139C8
        public List<byte[]> ImageFiles
        {
            get; set;
        }

        // Token: 0x170000F3 RID: 243
        // (get) Token: 0x060002AE RID: 686 RVA: 0x00015830 File Offset: 0x00013A30
        // (set) Token: 0x060002AD RID: 685 RVA: 0x00015800 File Offset: 0x00013A00
        public DelegateCommand CommitCommand
        {
            get; set;
        }

        // Token: 0x060002AF RID: 687 RVA: 0x00015838 File Offset: 0x00013A38
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("Tag"))
            {
                this.rfid = parameters["Tag"].ToString();
            }
        }

        // Token: 0x060002B0 RID: 688 RVA: 0x00015864 File Offset: 0x00013A64
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x060002B1 RID: 689 RVA: 0x00015870 File Offset: 0x00013A70
        private async void Commit()
        {
            if (base.Location == null || base.Location.Longitude == 0.0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取定位信息").Show();
            }
            else if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交施封照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                await this.SaveOperate();
                this.dialog.Dismiss();
                await base.NavigationService.GoBackAsync();
            }
        }

        // Token: 0x060002B2 RID: 690 RVA: 0x000158A9 File Offset: 0x00013AA9
        private Task SaveOperate()
        {
            return Task.Run(delegate ()
            {
                File.WriteAllText(BasicData.FileName, "");
                AppEPCshiFeng data = new AppEPCshiFeng
                {
                    RFIDCode = this.rfid,
                    PurposeAddress = this.Arrival,
                    Number = this.QianfengNo,
                    CarrierOid = new Guid?(this.driverOid),
                    SealingaddressOid = new Guid?(this.placeOid),
                    CarOid = new Guid?(this.carOid),
                    Longitude = Convert.ToDecimal(base.Location.Longitude),
                    Latitude = Convert.ToDecimal(base.Location.Latitude),
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0])
                };
                AppEPCshiFengResquest value = new AppEPCshiFengResquest
                {
                    username = BasicData.PersonalInfomation.Username,
                    senddate = DateTime.Now,
                    data = data
                };
                string value2 = File.ReadAllText(BasicData.FileName);
                string str = JsonConvert.SerializeObject(value);
                if (string.IsNullOrEmpty(value2))
                {
                    File.WriteAllText(BasicData.FileName, str + ",");
                }
                else
                {
                    File.AppendAllText(BasicData.FileName, str + ",");
                }
                Device.BeginInvokeOnMainThread(delegate
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, "保存成功").Show();
                });
            });
        }

        // Token: 0x04000177 RID: 375
        public Guid carOid;

        // Token: 0x04000178 RID: 376
        public Guid driverOid;

        // Token: 0x04000179 RID: 377
        public Guid placeOid;
    }

    // Token: 0x0200007A RID: 122
    public class DriverPageViewModel : ViewModelBase
    {
        // Token: 0x060002B9 RID: 697 RVA: 0x00015C04 File Offset: 0x00013E04
        public DriverPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.SearchCommand = new DelegateCommand(new Action(this.Search));
            this.SelectCommand = new DelegateCommand<AppCarrier>(new Action<AppCarrier>(this.Select));
            this.AddCommand = new DelegateCommand(new Action(this.Add));
            this.SearchSource = new ObservableCollection<AppCarrier>();
            this.entireSource = new List<AppCarrier>();
        }

        // Token: 0x170000F4 RID: 244
        // (get) Token: 0x060002BB RID: 699 RVA: 0x00015CA5 File Offset: 0x00013EA5
        // (set) Token: 0x060002BA RID: 698 RVA: 0x00015C74 File Offset: 0x00013E74
        public string SearchText
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchText > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< SearchText > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< SearchText > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchText);
            }
        }

        // Token: 0x170000F5 RID: 245
        // (get) Token: 0x060002BD RID: 701 RVA: 0x00015CE0 File Offset: 0x00013EE0
        // (set) Token: 0x060002BC RID: 700 RVA: 0x00015CB0 File Offset: 0x00013EB0
        public ObservableCollection<AppCarrier> SearchSource
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchSource > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SearchSource > k__BackingField, value))
                {
                    return;
                }
                this.< SearchSource > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchSource);
            }
        }

        // Token: 0x170000F6 RID: 246
        // (get) Token: 0x060002BF RID: 703 RVA: 0x00015D18 File Offset: 0x00013F18
        // (set) Token: 0x060002BE RID: 702 RVA: 0x00015CE8 File Offset: 0x00013EE8
        public DelegateCommand SearchCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SearchCommand > k__BackingField, value))
                {
                    return;
                }
                this.< SearchCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchCommand);
            }
        }

        // Token: 0x170000F7 RID: 247
        // (get) Token: 0x060002C1 RID: 705 RVA: 0x00015D50 File Offset: 0x00013F50
        // (set) Token: 0x060002C0 RID: 704 RVA: 0x00015D20 File Offset: 0x00013F20
        public DelegateCommand AddCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< AddCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< AddCommand > k__BackingField, value))
                {
                    return;
                }
                this.< AddCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.AddCommand);
            }
        }

        // Token: 0x170000F8 RID: 248
        // (get) Token: 0x060002C3 RID: 707 RVA: 0x00015D88 File Offset: 0x00013F88
        // (set) Token: 0x060002C2 RID: 706 RVA: 0x00015D58 File Offset: 0x00013F58
        public DelegateCommand<AppCarrier> SelectCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< SelectCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SelectCommand > k__BackingField, value))
                {
                    return;
                }
                this.< SelectCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SelectCommand);
            }
        }

        // Token: 0x060002C4 RID: 708 RVA: 0x00015D90 File Offset: 0x00013F90
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            this.apiHelper = new ApiHelper();
            base.Title = AppResource.driver;
            AppResult<List<AppCarrier>> appResult = await this.apiHelper.PostWithJson<AppResult<List<AppCarrier>>>("data/GetAllCarrier", new AppSender<AppSenderDataCollect>
            {
                data = new AppSenderDataCollect
                {
                    CompanyOid = BasicData.User.CompanyOid
                }
            });
            AppResult<List<AppCarrier>> appResult2 = appResult;
            if (appResult2.successed && appResult2.data != null)
            {
                this.entireSource = appResult2.data;
                using (List<AppCarrier>.Enumerator enumerator = this.entireSource.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        AppCarrier item = enumerator.Current;
                        this.SearchSource.Add(item);
                    }
                    return;
                }
            }
            Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
        }

        // Token: 0x060002C5 RID: 709 RVA: 0x00015DD1 File Offset: 0x00013FD1
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x060002C6 RID: 710 RVA: 0x00015DE4 File Offset: 0x00013FE4
        private async void Select(AppCarrier carrier)
        {
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("driver", carrier.Name);
            navigationParameters.Add("driverOid", carrier.Oid);
            await base.NavigationService.GoBackAsync(navigationParameters);
        }

        // Token: 0x060002C7 RID: 711 RVA: 0x00015E28 File Offset: 0x00014028
        private void Search()
        {
            if (this.entireSource == null || this.entireSource.Count == 0)
            {
                return;
            }
            this.SearchSource.Clear();
            if (string.IsNullOrEmpty(this.SearchText))
            {
                foreach (AppCarrier item in this.entireSource)
                {
                    this.SearchSource.Add(item);
                }
                return;
            }
            List<AppCarrier> list = this.entireSource.FindAll((AppCarrier arg) => arg.Name.Contains(this.SearchText));
            foreach (AppCarrier item2 in list)
            {
                this.SearchSource.Add(item2);
            }
        }

        // Token: 0x060002C8 RID: 712 RVA: 0x00015F0C File Offset: 0x0001410C
        private async void Add()
        {
            AppCarrier obj = new AppCarrier
            {
                Name = this.SearchText,
                CompanyOid = BasicData.User.CompanyOid,
                Oid = default(Guid)
            };
            AppResult<string> appResult = await this.apiHelper.PostWithJson<AppResult<string>>("data/UploadCarrierInfo", new AppSender<AppCarrier>
            {
                data = obj
            });
            AppResult<string> appResult2 = appResult;
            if (appResult2.successed)
            {
                this.SearchSource.Add(obj);
                this.entireSource.Add(obj);
                Toasty.Success(CrossCurrentActivity.Current.Activity, "添加成功").Show();
            }
            else
            {
                Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
            }
        }

        // Token: 0x04000189 RID: 393
        private List<AppCarrier> entireSource;

        // Token: 0x0400018E RID: 398
        private ApiHelper apiHelper;
    }

    // Token: 0x0200007E RID: 126
    public class EndLockPageViewModel : LocationViewmodel
    {
        // Token: 0x060002D1 RID: 721 RVA: 0x000163AA File Offset: 0x000145AA
        public EndLockPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x170000F9 RID: 249
        // (get) Token: 0x060002D3 RID: 723 RVA: 0x00016409 File Offset: 0x00014609
        // (set) Token: 0x060002D2 RID: 722 RVA: 0x000163D8 File Offset: 0x000145D8
        public string Driver
        {
            [CompilerGenerated]
            get
            {
                return this.< Driver > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Driver > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Driver > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Driver);
            }
        }

        // Token: 0x170000FA RID: 250
        // (get) Token: 0x060002D5 RID: 725 RVA: 0x00016445 File Offset: 0x00014645
        // (set) Token: 0x060002D4 RID: 724 RVA: 0x00016414 File Offset: 0x00014614
        public string Place
        {
            [CompilerGenerated]
            get
            {
                return this.< Place > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Place > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Place > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Place);
            }
        }

        // Token: 0x170000FB RID: 251
        // (get) Token: 0x060002D7 RID: 727 RVA: 0x00016481 File Offset: 0x00014681
        // (set) Token: 0x060002D6 RID: 726 RVA: 0x00016450 File Offset: 0x00014650
        public string Arrival
        {
            [CompilerGenerated]
            get
            {
                return this.< Arrival > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Arrival > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Arrival > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Arrival);
            }
        }

        // Token: 0x170000FC RID: 252
        // (get) Token: 0x060002D9 RID: 729 RVA: 0x000164BD File Offset: 0x000146BD
        // (set) Token: 0x060002D8 RID: 728 RVA: 0x0001648C File Offset: 0x0001468C
        public string QianfengNo
        {
            [CompilerGenerated]
            get
            {
                return this.< QianfengNo > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< QianfengNo > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< QianfengNo > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.QianfengNo);
            }
        }

        // Token: 0x170000FD RID: 253
        // (get) Token: 0x060002DB RID: 731 RVA: 0x000164F8 File Offset: 0x000146F8
        // (set) Token: 0x060002DA RID: 730 RVA: 0x000164C8 File Offset: 0x000146C8
        public List<byte[]> ImageFiles
        {
            [CompilerGenerated]
            get
            {
                return this.< ImageFiles > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ImageFiles > k__BackingField, value))
                {
                    return;
                }
                this.< ImageFiles > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ImageFiles);
            }
        }

        // Token: 0x170000FE RID: 254
        // (get) Token: 0x060002DD RID: 733 RVA: 0x00016530 File Offset: 0x00014730
        // (set) Token: 0x060002DC RID: 732 RVA: 0x00016500 File Offset: 0x00014700
        public DelegateCommand CommitCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< CommitCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< CommitCommand > k__BackingField, value))
                {
                    return;
                }
                this.< CommitCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CommitCommand);
            }
        }

        // Token: 0x060002DE RID: 734 RVA: 0x00016538 File Offset: 0x00014738
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("detail"))
            {
                this.data = (parameters["detail"] as AppRFIDVerification);
                base.Title = this.data.CarID + "->" + AppResource.lockend;
                this.Arrival = this.data.PurposeAddress;
                this.Driver = this.data.CarrierName;
                this.QianfengNo = this.data.Number;
                this.Place = this.data.SealingAddress;
            }
        }

        // Token: 0x060002DF RID: 735 RVA: 0x00015864 File Offset: 0x00013A64
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x060002E0 RID: 736 RVA: 0x000165D4 File Offset: 0x000147D4
        private async void Commit()
        {
            if (base.Location == null || base.Location.Longitude == 0.0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取定位信息").Show();
            }
            else if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交拆封照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                AppOnSiteInspection appOnSiteInspection = new AppOnSiteInspection
                {
                    CompanyOid = BasicData.User.CompanyOid,
                    CurrentAddress = base.Location.Address,
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0]),
                    RFIDCode = this.data.RFIDCode,
                    Latitude = Convert.ToDecimal(base.Location.Latitude),
                    Longitude = Convert.ToDecimal(base.Location.Longitude)
                };
                BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/UnsealEPC", new AppSender<AppOnSiteInspection>
                {
                    data = appOnSiteInspection
                });
                BaseResponse baseResponse2 = baseResponse;
                if (baseResponse2.successed)
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                    await base.NavigationService.GoBackAsync();
                }
                else
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                }
                this.dialog.Dismiss();
            }
        }

        // Token: 0x040001A3 RID: 419
        private AppRFIDVerification data;
    }

    // Token: 0x02000080 RID: 128
    public class ExceptionPageViewModel : LocationViewmodel
    {
        // Token: 0x060002E3 RID: 739 RVA: 0x000168BA File Offset: 0x00014ABA
        public ExceptionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x170000FF RID: 255
        // (get) Token: 0x060002E5 RID: 741 RVA: 0x00016919 File Offset: 0x00014B19
        // (set) Token: 0x060002E4 RID: 740 RVA: 0x000168E8 File Offset: 0x00014AE8
        public string ExPlace
        {
            [CompilerGenerated]
            get
            {
                return this.< ExPlace > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< ExPlace > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< ExPlace > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ExPlace);
            }
        }

        // Token: 0x17000100 RID: 256
        // (get) Token: 0x060002E7 RID: 743 RVA: 0x00016955 File Offset: 0x00014B55
        // (set) Token: 0x060002E6 RID: 742 RVA: 0x00016924 File Offset: 0x00014B24
        public string StartTime
        {
            [CompilerGenerated]
            get
            {
                return this.< StartTime > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< StartTime > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< StartTime > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.StartTime);
            }
        }

        // Token: 0x17000101 RID: 257
        // (get) Token: 0x060002E9 RID: 745 RVA: 0x00016991 File Offset: 0x00014B91
        // (set) Token: 0x060002E8 RID: 744 RVA: 0x00016960 File Offset: 0x00014B60
        public string ExInfo
        {
            [CompilerGenerated]
            get
            {
                return this.< ExInfo > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< ExInfo > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< ExInfo > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ExInfo);
            }
        }

        // Token: 0x17000102 RID: 258
        // (get) Token: 0x060002EB RID: 747 RVA: 0x000169CC File Offset: 0x00014BCC
        // (set) Token: 0x060002EA RID: 746 RVA: 0x0001699C File Offset: 0x00014B9C
        public List<byte[]> ImageFiles
        {
            [CompilerGenerated]
            get
            {
                return this.< ImageFiles > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ImageFiles > k__BackingField, value))
                {
                    return;
                }
                this.< ImageFiles > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ImageFiles);
            }
        }

        // Token: 0x17000103 RID: 259
        // (get) Token: 0x060002ED RID: 749 RVA: 0x00016A04 File Offset: 0x00014C04
        // (set) Token: 0x060002EC RID: 748 RVA: 0x000169D4 File Offset: 0x00014BD4
        public DelegateCommand CommitCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< CommitCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< CommitCommand > k__BackingField, value))
                {
                    return;
                }
                this.< CommitCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CommitCommand);
            }
        }

        // Token: 0x060002EE RID: 750 RVA: 0x00016A0C File Offset: 0x00014C0C
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("car"))
            {
                this.carno = (Guid)parameters["carno"];
                base.Title = parameters["car"].ToString() + "->" + AppResource.exception;
                AppResult<AppRFIDVerification> appResult = await this.apiHelper.PostWithJson<AppResult<AppRFIDVerification>>("data/VerificationCar", new AppSender<AppSenderCarInfo>
                {
                    data = new AppSenderCarInfo
                    {
                        CompanyOid = BasicData.User.CompanyOid,
                        CarOid = this.carno
                    }
                });
                AppResult<AppRFIDVerification> appResult2 = appResult;
                if (!appResult2.successed)
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
                }
                else
                {
                    this.StartTime = appResult2.data.BeginDate.ToString("G");
                    this.ExPlace = appResult2.data.SealingAddress;
                }
            }
        }

        // Token: 0x060002EF RID: 751 RVA: 0x00016A4D File Offset: 0x00014C4D
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            parameters.Add("isException", true);
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x060002F0 RID: 752 RVA: 0x00016A68 File Offset: 0x00014C68
        private async void Commit()
        {
            if (base.Location == null || base.Location.Longitude == 0.0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取定位信息").Show();
            }
            else if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交异常照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                AppAbnormalEPC data = new AppAbnormalEPC
                {
                    CurrentAddress = base.Location.Address,
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0]),
                    ErrorInfo = this.ExInfo,
                    CarOid = this.carno,
                    CompanyOid = BasicData.User.CompanyOid,
                    Latitude = Convert.ToDecimal(base.Location.Latitude),
                    Longitude = Convert.ToDecimal(base.Location.Longitude)
                };
                BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/AbnormalEPC", new AppSender<AppAbnormalEPC>
                {
                    data = data
                });
                BaseResponse baseResponse2 = baseResponse;
                if (baseResponse2.successed)
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                    await base.NavigationService.GoBackAsync();
                }
                else
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                }
                this.dialog.Dismiss();
            }
        }

        // Token: 0x040001AE RID: 430
        private Guid carno;
    }

    // Token: 0x02000083 RID: 131
    public class HelpPageViewModel : BindableBase
    {
    }

    // Token: 0x02000097 RID: 151
    public interface IPageAppearing
    {
        // Token: 0x06000365 RID: 869
        void OnAppearing();

        // Token: 0x06000366 RID: 870
        void OnDisappearing();
    }

    // Token: 0x020000B7 RID: 183
    public class LocationViewmodel : ViewModelBase
    {
        // Token: 0x06000409 RID: 1033 RVA: 0x0001941A File Offset: 0x0001761A
        public LocationViewmodel(INavigationService navigationService) : base(navigationService)
        {
        }

        // Token: 0x0600040A RID: 1034 RVA: 0x0001C8AC File Offset: 0x0001AAAC
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            this.CurLocation = AppResource.locating;
            if (this.apiHelper == null)
            {
                this.apiHelper = new ApiHelper();
            }
            this.mapLocationClient = new AMapLocationClient(CrossCurrentActivity.Current.Activity);
            this.mapLocationClient.SetLocationListener(new MapLocationListener(new Action<AMapLocation>(this.LocationChanged)));
            AMapLocationClientOption amapLocationClientOption = new AMapLocationClientOption();
            if (BasicData.NowOutline)
            {
                amapLocationClientOption.SetLocationMode(AMapLocationClientOption.AMapLocationMode.DeviceSensors);
            }
            else
            {
                amapLocationClientOption.SetLocationMode(AMapLocationClientOption.AMapLocationMode.HightAccuracy);
            }
            amapLocationClientOption.SetOnceLocationLatest(true);
            amapLocationClientOption.SetNeedAddress(true);
            amapLocationClientOption.SetHttpTimeOut(20000L);
            amapLocationClientOption.SetMockEnable(true);
            amapLocationClientOption.SetLocationCacheEnable(false);
            this.mapLocationClient.SetLocationOption(amapLocationClientOption);
            this.mapLocationClient.StopLocation();
            this.mapLocationClient.StartLocation();
            this.dialog = new ProgressDialog(CrossCurrentActivity.Current.Activity);
            this.dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            this.dialog.SetCancelable(false);
        }

        // Token: 0x1700013C RID: 316
        // (get) Token: 0x0600040C RID: 1036 RVA: 0x0001C9E5 File Offset: 0x0001ABE5
        // (set) Token: 0x0600040B RID: 1035 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
        public string CurLocation
        {
            [CompilerGenerated]
            get
            {
                return this.< CurLocation > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< CurLocation > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< CurLocation > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CurLocation);
            }
        }

        // Token: 0x1700013D RID: 317
        // (get) Token: 0x0600040E RID: 1038 RVA: 0x0001CA20 File Offset: 0x0001AC20
        // (set) Token: 0x0600040D RID: 1037 RVA: 0x0001C9F0 File Offset: 0x0001ABF0
        protected AMapLocation Location
        {
            [CompilerGenerated]
            get
            {
                return this.< Location > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< Location > k__BackingField, value))
                {
                    return;
                }
                this.< Location > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Location);
            }
        }

        // Token: 0x0600040F RID: 1039 RVA: 0x0001CA28 File Offset: 0x0001AC28
        private void LocationChanged(AMapLocation mapLocation)
        {
            if (mapLocation.ErrorCode != 0)
            {
                this.CurLocation = mapLocation.ErrorInfo;
                return;
            }
            this.Location = mapLocation;
            if (BasicData.NowOutline)
            {
                this.CurLocation = string.Format("离线定位:经度:{0},维度:{1}", mapLocation.Longitude, this.Location.Latitude);
                return;
            }
            this.CurLocation = mapLocation.Address;
        }

        // Token: 0x06000410 RID: 1040 RVA: 0x0001CA90 File Offset: 0x0001AC90
        public override void Destroy()
        {
            this.mapLocationClient.OnDestroy();
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x040002AB RID: 683
        private AMapLocationClient mapLocationClient;

        // Token: 0x040002AC RID: 684
        protected ApiHelper apiHelper;

        // Token: 0x040002AE RID: 686
        protected string rfid;

        // Token: 0x040002AF RID: 687
        protected ProgressDialog dialog;
    }

    public class HomePageViewModel : ViewModelBase
    {
        // Token: 0x06000367 RID: 871 RVA: 0x0001941A File Offset: 0x0001761A
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }


    // Token: 0x02000084 RID: 132
    public class LockLocationPageViewModel : ViewModelBase
    {
        // Token: 0x060002F7 RID: 759 RVA: 0x00016F34 File Offset: 0x00015134
        public LockLocationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.SearchCommand = new DelegateCommand(new Action(this.Search));
            this.SelectCommand = new DelegateCommand<AppSealingaddress>(new Action<AppSealingaddress>(this.Select));
            this.AddCommand = new DelegateCommand(new Action(this.Add));
            this.SearchSource = new ObservableCollection<AppSealingaddress>();
            this.entireSource = new List<AppSealingaddress>();
        }

        // Token: 0x17000104 RID: 260
        // (get) Token: 0x060002F9 RID: 761 RVA: 0x00016FD5 File Offset: 0x000151D5
        // (set) Token: 0x060002F8 RID: 760 RVA: 0x00016FA4 File Offset: 0x000151A4
        public string SearchText
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchText > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< SearchText > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< SearchText > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchText);
            }
        }

        // Token: 0x17000105 RID: 261
        // (get) Token: 0x060002FB RID: 763 RVA: 0x00017010 File Offset: 0x00015210
        // (set) Token: 0x060002FA RID: 762 RVA: 0x00016FE0 File Offset: 0x000151E0
        public ObservableCollection<AppSealingaddress> SearchSource
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchSource > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SearchSource > k__BackingField, value))
                {
                    return;
                }
                this.< SearchSource > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchSource);
            }
        }

        // Token: 0x17000106 RID: 262
        // (get) Token: 0x060002FD RID: 765 RVA: 0x00017048 File Offset: 0x00015248
        // (set) Token: 0x060002FC RID: 764 RVA: 0x00017018 File Offset: 0x00015218
        public DelegateCommand SearchCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< SearchCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SearchCommand > k__BackingField, value))
                {
                    return;
                }
                this.< SearchCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SearchCommand);
            }
        }

        // Token: 0x17000107 RID: 263
        // (get) Token: 0x060002FF RID: 767 RVA: 0x00017080 File Offset: 0x00015280
        // (set) Token: 0x060002FE RID: 766 RVA: 0x00017050 File Offset: 0x00015250
        public DelegateCommand AddCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< AddCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< AddCommand > k__BackingField, value))
                {
                    return;
                }
                this.< AddCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.AddCommand);
            }
        }

        // Token: 0x17000108 RID: 264
        // (get) Token: 0x06000301 RID: 769 RVA: 0x000170B8 File Offset: 0x000152B8
        // (set) Token: 0x06000300 RID: 768 RVA: 0x00017088 File Offset: 0x00015288
        public DelegateCommand<AppSealingaddress> SelectCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< SelectCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< SelectCommand > k__BackingField, value))
                {
                    return;
                }
                this.< SelectCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.SelectCommand);
            }
        }

        // Token: 0x06000302 RID: 770 RVA: 0x000170C0 File Offset: 0x000152C0
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            this.apiHelper = new ApiHelper();
            base.Title = AppResource.lockplace;
            AppResult<List<AppSealingaddress>> appResult = await this.apiHelper.PostWithJson<AppResult<List<AppSealingaddress>>>("data/GetAllSealingaddress", new AppSender<AppSenderDataCollect>
            {
                data = new AppSenderDataCollect
                {
                    CompanyOid = BasicData.User.CompanyOid
                }
            });
            AppResult<List<AppSealingaddress>> appResult2 = appResult;
            if (appResult2.successed && appResult2.data != null)
            {
                this.entireSource = appResult2.data;
                using (List<AppSealingaddress>.Enumerator enumerator = this.entireSource.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        AppSealingaddress item = enumerator.Current;
                        this.SearchSource.Add(item);
                    }
                    return;
                }
            }
            Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
        }

        // Token: 0x06000303 RID: 771 RVA: 0x00017101 File Offset: 0x00015301
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x06000304 RID: 772 RVA: 0x00017114 File Offset: 0x00015314
        private async void Select(AppSealingaddress shifeng)
        {
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("place", shifeng.Name);
            navigationParameters.Add("placeOid", shifeng.Oid);
            await base.NavigationService.GoBackAsync(navigationParameters);
        }

        // Token: 0x06000305 RID: 773 RVA: 0x00017158 File Offset: 0x00015358
        private void Search()
        {
            if (this.entireSource == null || this.entireSource.Count == 0)
            {
                return;
            }
            this.SearchSource.Clear();
            if (string.IsNullOrEmpty(this.SearchText))
            {
                foreach (AppSealingaddress item in this.entireSource)
                {
                    this.SearchSource.Add(item);
                }
                return;
            }
            List<AppSealingaddress> list = this.entireSource.FindAll((AppSealingaddress arg) => arg.Name.Contains(this.SearchText));
            foreach (AppSealingaddress item2 in list)
            {
                this.SearchSource.Add(item2);
            }
        }

        // Token: 0x06000306 RID: 774 RVA: 0x0001723C File Offset: 0x0001543C
        private async void Add()
        {
            AppSealingaddress obj = new AppSealingaddress
            {
                Name = this.SearchText,
                Oid = default(Guid),
                CompanyOid = BasicData.User.CompanyOid
            };
            AppResult<string> appResult = await this.apiHelper.PostWithJson<AppResult<string>>("data/UploadSealingaddressInfo", new AppSender<AppSealingaddress>
            {
                data = obj
            });
            AppResult<string> appResult2 = appResult;
            if (appResult2.successed)
            {
                this.SearchSource.Add(obj);
                this.entireSource.Add(obj);
                Toasty.Success(CrossCurrentActivity.Current.Activity, "添加成功").Show();
            }
            else
            {
                Toasty.Info(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
            }
        }

        // Token: 0x040001BB RID: 443
        private List<AppSealingaddress> entireSource;

        // Token: 0x040001C0 RID: 448
        private ApiHelper apiHelper;
    }

    // Token: 0x020000B2 RID: 178
    public class LockPageViewModel : LocationViewmodel
    {
        // Token: 0x060003E4 RID: 996 RVA: 0x0001BE78 File Offset: 0x0001A078
        public LockPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = AppResource.shifeng;
            this.DriverCommand = new DelegateCommand(new Action(this.SelectDriver));
            this.PlaceCommand = new DelegateCommand(new Action(this.SelectPlace));
            this.Place = AppResource.placehint;
            this.Driver = AppResource.driverhint;
            this.CarNo = AppResource.carhint;
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x17000130 RID: 304
        // (get) Token: 0x060003E6 RID: 998 RVA: 0x0001BF39 File Offset: 0x0001A139
        // (set) Token: 0x060003E5 RID: 997 RVA: 0x0001BF08 File Offset: 0x0001A108
        public string CarNo
        {
            [CompilerGenerated]
            get
            {
                return this.< CarNo > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< CarNo > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< CarNo > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CarNo);
            }
        }

        // Token: 0x17000131 RID: 305
        // (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001BF75 File Offset: 0x0001A175
        // (set) Token: 0x060003E7 RID: 999 RVA: 0x0001BF44 File Offset: 0x0001A144
        public string Driver
        {
            [CompilerGenerated]
            get
            {
                return this.< Driver > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Driver > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Driver > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Driver);
            }
        }

        // Token: 0x17000132 RID: 306
        // (get) Token: 0x060003EA RID: 1002 RVA: 0x0001BFB1 File Offset: 0x0001A1B1
        // (set) Token: 0x060003E9 RID: 1001 RVA: 0x0001BF80 File Offset: 0x0001A180
        public string Place
        {
            [CompilerGenerated]
            get
            {
                return this.< Place > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Place > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Place > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Place);
            }
        }

        // Token: 0x17000133 RID: 307
        // (get) Token: 0x060003EC RID: 1004 RVA: 0x0001BFED File Offset: 0x0001A1ED
        // (set) Token: 0x060003EB RID: 1003 RVA: 0x0001BFBC File Offset: 0x0001A1BC
        public string Arrival
        {
            [CompilerGenerated]
            get
            {
                return this.< Arrival > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Arrival > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Arrival > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Arrival);
            }
        }

        // Token: 0x17000134 RID: 308
        // (get) Token: 0x060003EE RID: 1006 RVA: 0x0001C029 File Offset: 0x0001A229
        // (set) Token: 0x060003ED RID: 1005 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
        public string QianfengNo
        {
            [CompilerGenerated]
            get
            {
                return this.< QianfengNo > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< QianfengNo > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< QianfengNo > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.QianfengNo);
            }
        }

        // Token: 0x17000135 RID: 309
        // (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001C064 File Offset: 0x0001A264
        // (set) Token: 0x060003EF RID: 1007 RVA: 0x0001C034 File Offset: 0x0001A234
        public List<byte[]> ImageFiles
        {
            [CompilerGenerated]
            get
            {
                return this.< ImageFiles > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ImageFiles > k__BackingField, value))
                {
                    return;
                }
                this.< ImageFiles > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ImageFiles);
            }
        }

        // Token: 0x17000136 RID: 310
        // (get) Token: 0x060003F2 RID: 1010 RVA: 0x0001C09C File Offset: 0x0001A29C
        // (set) Token: 0x060003F1 RID: 1009 RVA: 0x0001C06C File Offset: 0x0001A26C
        public DelegateCommand CarCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< CarCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< CarCommand > k__BackingField, value))
                {
                    return;
                }
                this.< CarCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CarCommand);
            }
        }

        // Token: 0x17000137 RID: 311
        // (get) Token: 0x060003F4 RID: 1012 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
        // (set) Token: 0x060003F3 RID: 1011 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
        public DelegateCommand DriverCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< DriverCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< DriverCommand > k__BackingField, value))
                {
                    return;
                }
                this.< DriverCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.DriverCommand);
            }
        }

        // Token: 0x17000138 RID: 312
        // (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001C10C File Offset: 0x0001A30C
        // (set) Token: 0x060003F5 RID: 1013 RVA: 0x0001C0DC File Offset: 0x0001A2DC
        public DelegateCommand PlaceCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< PlaceCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< PlaceCommand > k__BackingField, value))
                {
                    return;
                }
                this.< PlaceCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.PlaceCommand);
            }
        }

        // Token: 0x17000139 RID: 313
        // (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001C144 File Offset: 0x0001A344
        // (set) Token: 0x060003F7 RID: 1015 RVA: 0x0001C114 File Offset: 0x0001A314
        public DelegateCommand CommitCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< CommitCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< CommitCommand > k__BackingField, value))
                {
                    return;
                }
                this.< CommitCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CommitCommand);
            }
        }

        // Token: 0x1700013A RID: 314
        // (get) Token: 0x060003F9 RID: 1017 RVA: 0x0001C14C File Offset: 0x0001A34C
        public bool UseDestination
        {
            get
            {
                return BasicData.AppConfiguration.eIsUseDestination;
            }
        }

        // Token: 0x1700013B RID: 315
        // (get) Token: 0x060003FA RID: 1018 RVA: 0x0001C158 File Offset: 0x0001A358
        public bool UseCarrier
        {
            get
            {
                return BasicData.AppConfiguration.eIsUseCarrier;
            }
        }

        // Token: 0x060003FB RID: 1019 RVA: 0x0001C164 File Offset: 0x0001A364
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("Tag"))
            {
                this.rfid = parameters["Tag"].ToString();
            }
            if (parameters.ContainsKey("car"))
            {
                this.CarNo = parameters["car"].ToString();
                this.carOid = new Guid?((Guid)parameters["carno"]);
            }
            if (parameters.ContainsKey("driver"))
            {
                this.Driver = parameters["driver"].ToString();
                this.driverOid = new Guid?((Guid)parameters["driverOid"]);
            }
            else if (parameters.ContainsKey("place"))
            {
                this.Place = parameters["place"].ToString();
                this.placeOid = new Guid?((Guid)parameters["placeOid"]);
            }
            if (parameters.ContainsKey("location"))
            {
                this.Arrival = parameters["location"].ToString();
            }
        }

        // Token: 0x060003FC RID: 1020 RVA: 0x00015864 File Offset: 0x00013A64
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x060003FD RID: 1021 RVA: 0x0001C27C File Offset: 0x0001A47C
        private async void SelectCar()
        {
            await base.NavigationService.NavigateAsync("CarPage");
        }

        // Token: 0x060003FE RID: 1022 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
        private async void SelectDriver()
        {
            await base.NavigationService.NavigateAsync("DriverPage");
        }

        // Token: 0x060003FF RID: 1023 RVA: 0x0001C2F4 File Offset: 0x0001A4F4
        private async void SelectPlace()
        {
            await base.NavigationService.NavigateAsync("LockLocationPage");
        }

        // Token: 0x06000400 RID: 1024 RVA: 0x0001C330 File Offset: 0x0001A530
        private async void Commit()
        {
            if (base.Location == null || base.Location.Longitude == 0.0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无法获取定位信息").Show();
            }
            else if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交施封照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                AppEPCshiFeng data = new AppEPCshiFeng
                {
                    CompanyOid = BasicData.User.CompanyOid,
                    RFIDCode = this.rfid,
                    PurposeAddress = this.Arrival,
                    CurrentAddress = base.CurLocation,
                    Number = this.QianfengNo,
                    CarrierOid = this.driverOid,
                    SealingaddressOid = this.placeOid,
                    CarOid = this.carOid,
                    Longitude = Convert.ToDecimal(base.Location.Longitude),
                    Latitude = Convert.ToDecimal(base.Location.Latitude),
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0])
                };
                BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/EPCshiFeng", new AppSender<AppEPCshiFeng>
                {
                    data = data
                });
                BaseResponse baseResponse2 = baseResponse;
                if (baseResponse2.successed)
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                    await base.NavigationService.GoBackToRootAsync(null);
                }
                else
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                }
                this.dialog.Dismiss();
            }
        }

        // Token: 0x0400028E RID: 654
        private Guid? carOid;

        // Token: 0x04000290 RID: 656
        private Guid? driverOid;

        // Token: 0x04000292 RID: 658
        private Guid? placeOid;
    }

    // Token: 0x02000099 RID: 153
    public class LoginPageViewModel : ViewModelBase
    {
        // Token: 0x06000368 RID: 872 RVA: 0x000194F0 File Offset: 0x000176F0
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.IsRemember = Preferences.Get("IsRemember", false);
            this.IsOutline = Preferences.Get("IsOutline", false);
            this.Username = Preferences.Get("Username", "");
            this.Password = Preferences.Get("Password", "");
            this.LoginCommand = new DelegateCommand(new Action(this.Login));
            this.ServerCommand = new DelegateCommand(new Action(this.SetServerAddress));
            this.Username = Preferences.Get("username", this.Username);
            this.Password = Preferences.Get("password", this.Password);
            BasicData.Apiaddress = Preferences.Get("ipaddress", "");
        }

        // Token: 0x17000118 RID: 280
        // (get) Token: 0x0600036A RID: 874 RVA: 0x000195F0 File Offset: 0x000177F0
        // (set) Token: 0x06000369 RID: 873 RVA: 0x000195C0 File Offset: 0x000177C0
        public DelegateCommand ServerCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< ServerCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ServerCommand > k__BackingField, value))
                {
                    return;
                }
                this.< ServerCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ServerCommand);
            }
        }

        // Token: 0x17000119 RID: 281
        // (get) Token: 0x0600036C RID: 876 RVA: 0x00019628 File Offset: 0x00017828
        // (set) Token: 0x0600036B RID: 875 RVA: 0x000195F8 File Offset: 0x000177F8
        public DelegateCommand LoginCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< LoginCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< LoginCommand > k__BackingField, value))
                {
                    return;
                }
                this.< LoginCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.LoginCommand);
            }
        }

        // Token: 0x1700011A RID: 282
        // (get) Token: 0x0600036E RID: 878 RVA: 0x00019661 File Offset: 0x00017861
        // (set) Token: 0x0600036D RID: 877 RVA: 0x00019630 File Offset: 0x00017830
        public string Username
        {
            [CompilerGenerated]
            get
            {
                return this.< Username > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Username > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Username > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Username);
            }
        }

        // Token: 0x1700011B RID: 283
        // (get) Token: 0x06000370 RID: 880 RVA: 0x0001969D File Offset: 0x0001789D
        // (set) Token: 0x0600036F RID: 879 RVA: 0x0001966C File Offset: 0x0001786C
        public string Password
        {
            [CompilerGenerated]
            get
            {
                return this.< Password > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Password > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Password > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Password);
            }
        }

        // Token: 0x1700011C RID: 284
        // (get) Token: 0x06000372 RID: 882 RVA: 0x000196D5 File Offset: 0x000178D5
        // (set) Token: 0x06000371 RID: 881 RVA: 0x000196A8 File Offset: 0x000178A8
        public bool IsRemember
        {
            [CompilerGenerated]
            get
            {
                return this.< IsRemember > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (this.< IsRemember > k__BackingField == value)
                {
                    return;
                }
                this.< IsRemember > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.IsRemember);
            }
        }

        // Token: 0x1700011D RID: 285
        // (get) Token: 0x06000374 RID: 884 RVA: 0x0001970D File Offset: 0x0001790D
        // (set) Token: 0x06000373 RID: 883 RVA: 0x000196E0 File Offset: 0x000178E0
        public bool IsOutline
        {
            [CompilerGenerated]
            get
            {
                return this.< IsOutline > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (this.< IsOutline > k__BackingField == value)
                {
                    return;
                }
                this.< IsOutline > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.IsOutline);
            }
        }

        // Token: 0x06000375 RID: 885 RVA: 0x00019715 File Offset: 0x00017915
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            this.apiHelper = new ApiHelper();
            base.OnNavigatedTo(parameters);
        }

        // Token: 0x06000376 RID: 886 RVA: 0x00019729 File Offset: 0x00017929
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x06000377 RID: 887 RVA: 0x0001973C File Offset: 0x0001793C

        // Token: 0x06000377 RID: 887 RVA: 0x0001973C File Offset: 0x0001793C
        private void SetServerAddress()
        {
            //         LoginPageViewModel.<> c__DisplayClass28_0 CS$<> 8__locals1 = new LoginPageViewModel.<> c__DisplayClass28_0();
            //         CS$<> 8__locals1.<> 4__this = this;
            //         CS$<> 8__locals1.editText = new EditText(CrossCurrentActivity.Current.Activity);
            //         CS$<> 8__locals1.editText.Text = BasicData.BaseUrl;
            //         new AlertDialog.Builder(CrossCurrentActivity.Current.Activity).SetTitle(AppResource.inputserver).SetView(CS$<> 8__locals1.editText).SetPositiveButton(AppResource.confirm, delegate (object sender, DialogClickEventArgs e)
            //         {
            //         LoginPageViewModel.<> c__DisplayClass28_0.<< SetServerAddress > b__0 > d << SetServerAddress > b__0 > d;

            //             << SetServerAddress > b__0 > d.<> 4__this = CS$<> 8__locals1;

            //             << SetServerAddress > b__0 > d.<> t__builder = AsyncVoidMethodBuilder.Create();

            //             << SetServerAddress > b__0 > d.<> 1__state = -1;
            //         AsyncVoidMethodBuilder<> t__builder = << SetServerAddress > b__0 > d.<> t__builder;

            //             <> t__builder.Start < LoginPageViewModel.<> c__DisplayClass28_0.<< SetServerAddress > b__0 > d > (ref << SetServerAddress > b__0 > d);
            //     }
            //     ).SetNegativeButton(AppResource.cancel, delegate (object sender, DialogClickEventArgs e)
            //{
            //}).Show();
        }

        // Token: 0x06000378 RID: 888 RVA: 0x000197E4 File Offset: 0x000179E4
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Username))
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "账号不能为空").Show();
            }
            else
            {
                base.IsBusy = true;
                if (this.IsOutline)
                {
                    bool flag = Preferences.Get("canOutline", false);
                    if (flag)
                    {
                        Preferences.Set("NowOutline", true);
                        await base.NavigationService.NavigateAsync("HomePage");
                    }
                    else
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, AppResource.not_outline).Show();
                    }
                }
                else
                {
                    AppResult<AppUser> appResult = await this.apiHelper.GetWithParams<AppResult<AppUser>>("data/VerificationUser", new Dictionary<string, string>
                                            {
                                                {
                                                    "userName",
                                                    this.Username
                                                },
                                                {
                                                    "passWord",
                                                    this.Password
                                                }
                                            });
                    if (appResult.successed)
                    {
                        Preferences.Set("username", this.Username);
                        Preferences.Set("password", this.Password);
                        Preferences.Set("canOutline", true);
                        Preferences.Set("NowOutline", false);
                        BasicData.User = appResult.data;
                        BasicData.AppConfiguration = (await this.apiHelper.PostWithJson<AppResult<AppEnterpriseConfiguration>>("data/GetEnterpriseConfiguration", new AppSender<AppSenderDataCollect>
                        {
                            data = new AppSenderDataCollect
                            {
                                CompanyOid = appResult.data.CompanyOid
                            }
                        })).data;
                        await base.NavigationService.NavigateAsync("/BlackTextNavigationPage/HomePage");
                    }
                    else
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, appResult.msg).Show();
                    }
                }
                base.IsBusy = false;
            }
        }

        // Token: 0x04000219 RID: 537
        private ApiHelper apiHelper;

    }



// Token: 0x02000088 RID: 136
	public class MainPageViewModel : TabbedChildViewModel
{
    // Token: 0x0600030F RID: 783 RVA: 0x000176DC File Offset: 0x000158DC
    public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
    {
        this.pageDialogService = pageDialogService;
        this.ReadCommand = new DelegateCommand(new Action(this.ReadPage));
        this.DeleteCommand = new DelegateCommand(new Action(this.DeletePage));
        this.ExceptionCommand = new DelegateCommand(new Action(this.ExceptionPage));
        this.UploadCommand = new DelegateCommand(new Action(this.UploadPage));
        this.ScanModeCommand = new DelegateCommand(new Action(this.ScanModeChange));
        string value = Preferences.Get("ScanMode", "UHF");
        BasicData.NowScanMode = (ScanMode)Enum.Parse(typeof(ScanMode), value);
        this.SetModeText(BasicData.NowScanMode);
        this.dialog = new ProgressDialog(CrossCurrentActivity.Current.Activity);
        this.dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
        this.dialog.SetCancelable(false);
        MessagingCenter.Subscribe<NFCActivity, TagResponse>(this, "tag", new Action<NFCActivity, TagResponse>(this.UpdateTag), null);
        MessagingCenter.Subscribe<D2ReadActivity, TagResponse>(this, "tag", new Action<D2ReadActivity, TagResponse>(this.UpdateTag), null);
        if (BasicData.NowOutline)
        {
            this.HasTitle = true;
            base.Title = "离线模式只支持施封操作";
            Toasty.Warning(CrossCurrentActivity.Current.Activity, "离线模式只支持施封操作", 4000).Show();
        }
    }

    // Token: 0x17000109 RID: 265
    // (get) Token: 0x06000311 RID: 785 RVA: 0x00017861 File Offset: 0x00015A61
    // (set) Token: 0x06000310 RID: 784 RVA: 0x00017834 File Offset: 0x00015A34
    public bool HasTitle
    {
        [CompilerGenerated]
        get
        {
            return this.< HasTitle > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (this.< HasTitle > k__BackingField == value)
            {
                return;
            }
            this.< HasTitle > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.HasTitle);
        }
    }

    // Token: 0x06000312 RID: 786 RVA: 0x00017869 File Offset: 0x00015A69
    private void MainPageViewModel_IsActiveChanged(object sender, EventArgs e)
    {
        if (!base.IsActive)
        {
            base.IsBusy = true;
            return;
        }
        base.IsBusy = false;
    }

    // Token: 0x06000313 RID: 787 RVA: 0x00017882 File Offset: 0x00015A82
    public override void OnNavigatedTo(NavigationParameters parameters)
    {
        if (this.apiHelper == null)
        {
            this.apiHelper = new ApiHelper();
        }
        base.OnNavigatedTo(parameters);
    }

    // Token: 0x06000314 RID: 788 RVA: 0x0001789E File Offset: 0x00015A9E
    public override void OnAppearing()
    {
        base.OnAppearing();
        if (this.NotifyFromD2)
        {
            base.IsBusy = true;
            this.GoOperationPage(this.tagResponse.Tag);
            base.IsBusy = false;
        }
    }

    // Token: 0x06000315 RID: 789 RVA: 0x000178CD File Offset: 0x00015ACD
    public override void OnDisappearing()
    {
        base.OnDisappearing();
    }

    // Token: 0x06000316 RID: 790 RVA: 0x000178D8 File Offset: 0x00015AD8
    private void UpdateTag(Activity arg1, TagResponse arg2)
    {
        if (arg2.FromD2)
        {
            this.NotifyFromD2 = true;
            this.tagResponse = arg2;
            return;
        }
        if (arg2.CanTakeTag)
        {
            base.IsBusy = true;
            this.GoOperationPage(arg2.Tag);
            base.IsBusy = false;
            return;
        }
        Toasty.Error(CrossCurrentActivity.Current.Activity, arg2.Message).Show();
    }

    // Token: 0x06000317 RID: 791 RVA: 0x00017939 File Offset: 0x00015B39
    public override void Destroy()
    {
        MessagingCenter.Unsubscribe<D2ReadActivity, TagResponse>(this, "tag");
        MessagingCenter.Unsubscribe<NFCActivity, TagResponse>(this, "tag");
        this.apiHelper.Disconnect();
        base.Destroy();
    }

    // Token: 0x1700010A RID: 266
    // (get) Token: 0x06000319 RID: 793 RVA: 0x00017994 File Offset: 0x00015B94
    // (set) Token: 0x06000318 RID: 792 RVA: 0x00017964 File Offset: 0x00015B64
    public DelegateCommand ReadCommand
    {
        [CompilerGenerated]
        get
        {
            return this.< ReadCommand > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (object.Equals(this.< ReadCommand > k__BackingField, value))
            {
                return;
            }
            this.< ReadCommand > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.ReadCommand);
        }
    }

    // Token: 0x1700010B RID: 267
    // (get) Token: 0x0600031B RID: 795 RVA: 0x000179CC File Offset: 0x00015BCC
    // (set) Token: 0x0600031A RID: 794 RVA: 0x0001799C File Offset: 0x00015B9C
    public DelegateCommand DeleteCommand
    {
        [CompilerGenerated]
        get
        {
            return this.< DeleteCommand > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (object.Equals(this.< DeleteCommand > k__BackingField, value))
            {
                return;
            }
            this.< DeleteCommand > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.DeleteCommand);
        }
    }

    // Token: 0x1700010C RID: 268
    // (get) Token: 0x0600031D RID: 797 RVA: 0x00017A04 File Offset: 0x00015C04
    // (set) Token: 0x0600031C RID: 796 RVA: 0x000179D4 File Offset: 0x00015BD4
    public DelegateCommand ExceptionCommand
    {
        [CompilerGenerated]
        get
        {
            return this.< ExceptionCommand > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (object.Equals(this.< ExceptionCommand > k__BackingField, value))
            {
                return;
            }
            this.< ExceptionCommand > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.ExceptionCommand);
        }
    }

    // Token: 0x1700010D RID: 269
    // (get) Token: 0x0600031F RID: 799 RVA: 0x00017A3C File Offset: 0x00015C3C
    // (set) Token: 0x0600031E RID: 798 RVA: 0x00017A0C File Offset: 0x00015C0C
    public DelegateCommand UploadCommand
    {
        [CompilerGenerated]
        get
        {
            return this.< UploadCommand > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (object.Equals(this.< UploadCommand > k__BackingField, value))
            {
                return;
            }
            this.< UploadCommand > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.UploadCommand);
        }
    }

    // Token: 0x1700010E RID: 270
    // (get) Token: 0x06000321 RID: 801 RVA: 0x00017A74 File Offset: 0x00015C74
    // (set) Token: 0x06000320 RID: 800 RVA: 0x00017A44 File Offset: 0x00015C44
    public DelegateCommand ScanModeCommand
    {
        [CompilerGenerated]
        get
        {
            return this.< ScanModeCommand > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (object.Equals(this.< ScanModeCommand > k__BackingField, value))
            {
                return;
            }
            this.< ScanModeCommand > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.ScanModeCommand);
        }
    }

    // Token: 0x1700010F RID: 271
    // (get) Token: 0x06000323 RID: 803 RVA: 0x00017AAD File Offset: 0x00015CAD
    // (set) Token: 0x06000322 RID: 802 RVA: 0x00017A7C File Offset: 0x00015C7C
    public string ScanModeText
    {
        [CompilerGenerated]
        get
        {
            return this.< ScanModeText > k__BackingField;
        }
        [CompilerGenerated]
        set
        {
            if (string.Equals(this.< ScanModeText > k__BackingField, value, StringComparison.Ordinal))
            {
                return;
            }
            this.< ScanModeText > k__BackingField = value;
            this.OnPropertyChanged(<> PropertyChangedEventArgs.ScanModeText);
        }
    }

    // Token: 0x06000324 RID: 804 RVA: 0x00017AB8 File Offset: 0x00015CB8
    private async void GoOperationPage(string tag)
    {
        MainPageViewModel.<> c__DisplayClass40_0 CS$<> 8__locals1 = new MainPageViewModel.<> c__DisplayClass40_0();
        CS$<> 8__locals1.<> 4__this = this;
        CS$<> 8__locals1.tag = tag;
        NavigationParameters pairs = new NavigationParameters();
        pairs.Add("Tag", CS$<> 8__locals1.tag);
        AppResult<AppRFIDVerification> appResult = await this.apiHelper.PostWithJson200<AppResult<AppRFIDVerification>>("data/VerificationRFID", new AppSender<AppSenderRFID>
        {
            data = new AppSenderRFID
            {
                CompanyOid = BasicData.User.CompanyOid,
                RFIDCode = CS$<> 8__locals1.tag
            }
        });
        AppResult<AppRFIDVerification> appResult2 = appResult;
        if (!appResult2.successed)
        {
            Toasty.Error(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
        }
        else
        {
            switch (BasicData.NowOperation)
            {
                case Operation.Read:
                    if (BasicData.NowOutline)
                    {
                        await base.NavigationService.NavigateAsync("DataPage", pairs);
                    }
                    else if (appResult2.data == null)
                    {
                        if (!BasicData.User.AppRoles.Contains(AppRoleType.施封))
                        {
                            Toasty.Error(CrossCurrentActivity.Current.Activity, "无权限施封").Show();
                        }
                        else
                        {
                            pairs.Add("isLock", true);
                            await base.NavigationService.NavigateAsync("CarPage", pairs);
                        }
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.巡检失败) || appResult2.data.ERecordStatus.Equals(RecordStatus.拆封失败))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "异常铅封").Show();
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.拆封成功))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "已拆封铅封").Show();
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.铅封报废))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "该铅封已报废").Show();
                    }
                    else
                    {
                        pairs.Add("detail", appResult2.data);
                        string text = await this.pageDialogService.DisplayActionSheetAsync(AppResource.acar + ": " + appResult2.data.CarID, AppResource.cancel, null, new string[]
                        {
                            AppResource.checklock,
                            AppResource.lockend
                        });
                        if (text.Equals(AppResource.checklock))
                        {
                            if (!BasicData.User.AppRoles.Contains(AppRoleType.巡检))
                            {
                                Toasty.Error(CrossCurrentActivity.Current.Activity, "无权限巡检").Show();
                            }
                            else
                            {
                                await base.NavigationService.NavigateAsync("CheckLockPage", pairs);
                            }
                        }
                        else if (text.Equals(AppResource.lockend))
                        {
                            if (!BasicData.User.AppRoles.Contains(AppRoleType.拆封))
                            {
                                Toasty.Error(CrossCurrentActivity.Current.Activity, "无权限拆封").Show();
                            }
                            else
                            {
                                await base.NavigationService.NavigateAsync("EndLockPage", pairs);
                            }
                        }
                    }
                    break;
                case Operation.Delete:
                    if (appResult2.data == null)
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "未施封铅封,不可报废").Show();
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.巡检失败) || appResult2.data.ERecordStatus.Equals(RecordStatus.拆封失败))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "异常铅封,不可报废").Show();
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.拆封成功))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "已拆封铅封").Show();
                    }
                    else if (appResult2.data.ERecordStatus.Equals(RecordStatus.铅封报废))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "该铅封已报废").Show();
                    }
                    else if (!BasicData.User.AppRoles.Contains(AppRoleType.施封))
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "无权限报废").Show();
                    }
                    else if (await this.pageDialogService.DisplayAlertAsync(AppResource.deleteinfo, string.Concat(new object[]
                    {
                        AppResource.carinfo,
                        ": ",
                        appResult2.data.CarID,
                        "\n",
                        AppResource.starttime,
                        ": ",
                        appResult2.data.BeginDate,
                        "\n",
                        AppResource.lockplace,
                        ": ",
                        appResult2.data.SealingAddress,
                        "\n\n",
                        AppResource.isdelete
                    }), AppResource.confirm, AppResource.cancel))
                    {
                        this.dialog.SetTitle("正在报废铅封");
                        this.dialog.Show();
                        ThreadPool.QueueUserWorkItem(delegate (object state)
                        {
                        MainPageViewModel.<> c__DisplayClass40_0.<< GoOperationPage > b__0 > d << GoOperationPage > b__0 > d;

                            << GoOperationPage > b__0 > d.<> 4__this = CS$<> 8__locals1;

                            << GoOperationPage > b__0 > d.<> t__builder = AsyncVoidMethodBuilder.Create();

                            << GoOperationPage > b__0 > d.<> 1__state = -1;
                        AsyncVoidMethodBuilder<> t__builder = << GoOperationPage > b__0 > d.<> t__builder;

                            <> t__builder.Start < MainPageViewModel.<> c__DisplayClass40_0.<< GoOperationPage > b__0 > d > (ref << GoOperationPage > b__0 > d);
                    });
            }
            break;
				case Operation.Upload:
					if (appResult2.data == null || !appResult2.data.ERecordStatus.Equals(RecordStatus.拆封成功))
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "非已拆封成功的铅封,不可上传运单").Show();
            }
            else if (!BasicData.User.AppRoles.Contains(AppRoleType.拆封))
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "无权限上传运单").Show();
            }
            else
            {
                pairs.Add("detail", appResult2.data);
                await base.NavigationService.NavigateAsync("UploadPage", pairs);
            }
            break;
        }
        this.NotifyFromD2 = false;
    }

// Token: 0x06000325 RID: 805 RVA: 0x00017AFC File Offset: 0x00015CFC
private async void GoReadPage()
{
    base.IsBusy = true;
    MainPageViewModel.<> c__DisplayClass41_0 CS$<> 8__locals1 = new MainPageViewModel<> c__DisplayClass41_0();
    CS$<> 8__locals1.<> 4__this = this;
    switch (BasicData.NowScanMode)
    {
        case ScanMode.UHF:
            try
            {
                AppManager.Instance.UhfInit();
                BasicData.CanUhf = true;
                ConfigrationOfModelD2Service.Protocol protocol = ConfigrationOfModelD2Service.GetService().UsingProtocol();
                ConfigrationOfModelD2Service.GetService().UseProtocol(protocol);
            }
            catch (Exception)
            {
                BasicData.CanUhf = false;
            }
            if (BasicData.CanUhf)
            {
                Intent intent = new Intent(CrossCurrentActivity.Current.Activity, typeof(D2ReadActivity));
                CrossCurrentActivity.Current.Activity.StartActivity(intent);
            }
            break;
        case ScanMode.QRCode:
            CS$<> 8__locals1.scanPage = new ZXingScannerPage(null, null)
            {
                Title = "条形码二维码扫描"
            };
            CS$<> 8__locals1.scanPage.OnScanResult += delegate (ZXing.Result result)
            {
                MainPageViewModel.<> c__DisplayClass41_1 CS$<> 8__locals2 = new MainPageViewModel.<> c__DisplayClass41_1();
                CS$<> 8__locals2.CS$<> 8__locals1 = CS$<> 8__locals1;
                CS$<> 8__locals2.result = result;
                CS$<> 8__locals1.scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(delegate
                {
                MainPageViewModel.<> c__DisplayClass41_1.<< GoReadPage > b__1 > d << GoReadPage > b__1 > d;

                        << GoReadPage > b__1 > d.<> 4__this = CS$<> 8__locals2;

                        << GoReadPage > b__1 > d.<> t__builder = AsyncVoidMethodBuilder.Create();

                        << GoReadPage > b__1 > d.<> 1__state = -1;
                AsyncVoidMethodBuilder<> t__builder = << GoReadPage > b__1 > d.<> t__builder;

                        <> t__builder.Start < MainPageViewModel.<> c__DisplayClass41_1.<< GoReadPage > b__1 > d > (ref << GoReadPage > b__1 > d);
            });
    };
    await App.CurNavigationPage.CurrentPage.Navigation.PushAsync(CS$<> 8__locals1.scanPage);
    break;
			case ScanMode.NFC:
			{
        Intent intent2 = new Intent(CrossCurrentActivity.Current.Activity, typeof(NFCActivity));
        CrossCurrentActivity.Current.Activity.StartActivity(intent2);
        break;
    }
			base.IsBusy = false;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00017B35 File Offset: 0x00015D35
		private void ReadPage()
                    {
                        BasicData.NowOperation = Operation.Read;
                        this.GoReadPage();
                    }

                    // Token: 0x06000327 RID: 807 RVA: 0x00017B43 File Offset: 0x00015D43
                    private void DeletePage()
                    {
                        BasicData.NowOperation = Operation.Delete;
                        this.GoReadPage();
                    }

                    // Token: 0x06000328 RID: 808 RVA: 0x00017B54 File Offset: 0x00015D54
                    private async void ExceptionPage()
                    {
                        base.IsBusy = true;
                        NavigationParameters navigationParameters = new NavigationParameters();
                        navigationParameters.Add("isException", true);
                        await base.NavigationService.NavigateAsync("CarPage", navigationParameters);
                        base.IsBusy = false;
                    }

                    // Token: 0x06000329 RID: 809 RVA: 0x00017B8D File Offset: 0x00015D8D
                    private void UploadPage()
                    {
                        BasicData.NowOperation = Operation.Upload;
                        this.GoReadPage();
                    }

                    // Token: 0x0600032A RID: 810 RVA: 0x00017B9C File Offset: 0x00015D9C
                    private void ScanModeChange()
                    {
                        string[] items = new string[]
                        {
                                    AppResource.uhf,
                                    AppResource.qrcode,
                                    AppResource.nfc
                        };
                        AlertDialog.Builder builder = new AlertDialog.Builder(CrossCurrentActivity.Current.Activity, 3);
                        builder.SetTitle(AppResource.modeselect);
                        builder.SetItems(items, delegate (object sender, DialogClickEventArgs e)
                        {
                            if (e.Which != (int)BasicData.NowScanMode)
                            {
                                ScanMode which = (ScanMode)e.Which;
                                switch (e.Which)
                                {
                                    case 0:
                                        Preferences.Set("ScanMode", which.ToString());
                                        BasicData.NowScanMode = which;
                                        this.SetModeText(which);
                                        break;
                                    case 1:
                                        Preferences.Set("ScanMode", which.ToString());
                                        BasicData.NowScanMode = which;
                                        this.SetModeText(which);
                                        break;
                                    case 2:
                                        Preferences.Set("ScanMode", which.ToString());
                                        BasicData.NowScanMode = which;
                                        this.SetModeText(which);
                                        break;
                                }
                            }
                            AlertDialog alertDialog = sender as AlertDialog;
                            if (alertDialog != null)
                            {
                                alertDialog.Cancel();
                            }
                        });
                        builder.Create().Show();
                    }

                    // Token: 0x0600032B RID: 811 RVA: 0x00017C04 File Offset: 0x00015E04
                    private void SetModeText(ScanMode mode)
                    {
                        switch (mode)
                        {
                            case ScanMode.UHF:
                                this.ScanModeText = "(" + AppResource.uhfmode + ")";
                                break;
                            case ScanMode.QRCode:
                                this.ScanModeText = "(" + AppResource.qrcode + ")";
                                break;
                            case ScanMode.NFC:
                                this.ScanModeText = "(" + AppResource.nfcmode + ")";
                                break;
                        }
                        Toast toast = Toasty.Info(CrossCurrentActivity.Current.Activity, this.ScanModeText);
                        toast.SetGravity(GravityFlags.Center, 0, 0);
                        toast.Show();
                    }

                    // Token: 0x0600032C RID: 812 RVA: 0x00017CA0 File Offset: 0x00015EA0
                    private async Task<string> QRScanAsync()
                    {
                        MobileBarcodeScanningOptions options = new MobileBarcodeScanningOptions();
                        MobileBarcodeScanner mobileBarcodeScanner = new MobileBarcodeScanner
                        {
                            TopText = AppResource.scan,
                            BottomText = AppResource.sacndetail,
                            CancelButtonText = AppResource.cancel
                        };
                        ZXing.Result result = await mobileBarcodeScanner.Scan(options);
                        ZXing.Result result2 = result;
                        return result2.Text;
                    }

                    // Token: 0x040001D0 RID: 464
                    private IPageDialogService pageDialogService;

                    // Token: 0x040001D1 RID: 465
                    private ProgressDialog dialog;

                    // Token: 0x040001D3 RID: 467
                    private ApiHelper apiHelper;

                    // Token: 0x040001D4 RID: 468
                    private bool NotifyFromD2;

                    // Token: 0x040001D5 RID: 469
                    private TagResponse tagResponse;
}

    // Token: 0x020000B8 RID: 184
    public class MapLocationListener : Java.Lang.Object, IAMapLocationListener, IJavaObject, IDisposable
    {
        // Token: 0x06000411 RID: 1041 RVA: 0x0001CAAE File Offset: 0x0001ACAE
        public MapLocationListener(Action<AMapLocation> action)
        {
            this.action = action;
        }

        // Token: 0x06000412 RID: 1042 RVA: 0x0001CABD File Offset: 0x0001ACBD
        public void OnLocationChanged(AMapLocation p0)
        {
            if (p0 != null)
            {
                this.action(p0);
            }
        }

        // Token: 0x040002B1 RID: 689
        private Action<AMapLocation> action;
    }

    // Token: 0x020000A9 RID: 169
    public class MenuItem
    {
        // Token: 0x17000127 RID: 295
        // (get) Token: 0x060003B5 RID: 949 RVA: 0x0001B04B File Offset: 0x0001924B
        // (set) Token: 0x060003B4 RID: 948 RVA: 0x0001B042 File Offset: 0x00019242
        public string Icon { get; set; }

        // Token: 0x17000128 RID: 296
        // (get) Token: 0x060003B7 RID: 951 RVA: 0x0001B05C File Offset: 0x0001925C
        // (set) Token: 0x060003B6 RID: 950 RVA: 0x0001B053 File Offset: 0x00019253
        public string Title { get; set; }

        // Token: 0x17000129 RID: 297
        // (get) Token: 0x060003B9 RID: 953 RVA: 0x0001B06D File Offset: 0x0001926D
        // (set) Token: 0x060003B8 RID: 952 RVA: 0x0001B064 File Offset: 0x00019264
        public DelegateCommand SelectCommand { get; set; }
    }

    public class MinePageViewModel : TabbedChildViewModel
    {
        // Token: 0x060003BB RID: 955 RVA: 0x0001B078 File Offset: 0x00019278
        public MinePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            this.pageDialogService = pageDialogService;
            this.MenuSource = new List<MenuItem>
            {
                new MenuItem
                {
                    Icon = "update.svg",
                    Title = AppResource.update,
                    SelectCommand = new DelegateCommand(new Action(this.CheckUpdate))
                },
                new MenuItem
                {
                    Icon = "Key.svg",
                    Title = AppResource.pwdchange,
                    SelectCommand = new DelegateCommand(new Action(this.ChangePassword))
                },
                new MenuItem
                {
                    Icon = "Bookmark.svg",
                    Title = AppResource.help,
                    SelectCommand = new DelegateCommand(new Action(this.UserHelp))
                },
                new MenuItem
                {
                    Icon = "setting.svg",
                    Title = AppResource.uhfset,
                    SelectCommand = new DelegateCommand(new Action(this.SetUHF))
                }
            };
            this.ExitCommand = new DelegateCommand(new Action(this.Exit));
        }

        // Token: 0x060003BC RID: 956 RVA: 0x00019418 File Offset: 0x00017618
        private void MinePageViewModel_IsActiveChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060003BD RID: 957 RVA: 0x0001B1A0 File Offset: 0x000193A0
        private void CheckUpdate()
        {
            Toasty.Error(CrossCurrentActivity.Current.Activity, "当前已是最新本").Show();
        }

        // Token: 0x060003BE RID: 958 RVA: 0x0001B1BC File Offset: 0x000193BC
        private void SetUHF()
        {
            EditText editText = new EditText(CrossCurrentActivity.Current.Activity);
            editText.Hint = AppResource.powerset;
            editText.InputType = InputTypes.ClassNumber;
            try
            {
                AppManager.Instance.UhfInit();
                StUhf.InterrogatorModelDs.InterrogatorModelD2 model;
                AppManager.Instance.GetInterrogatorModelD2(out model);
                new AlertDialog.Builder(CrossCurrentActivity.Current.Activity).SetTitle(AppResource.power + " " + model.OutputPower).SetView(editText).SetPositiveButton(AppResource.confirm, delegate (object sender, DialogClickEventArgs e)
                {
                    int num = Convert.ToInt32(editText.Text);
                    if (num < 0 || num > 32)
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, "功率必须在[0,32]区间").Show();
                        return;
                    }
                    Java.Lang.Boolean value = model.SetOutputPower(num);
                    if (Convert.ToBoolean(value))
                    {
                        Toasty.Success(CrossCurrentActivity.Current.Activity, AppResource.setsuccess).Show();
                        return;
                    }
                    Toasty.Error(CrossCurrentActivity.Current.Activity, "设置失败").Show();
                }).SetNegativeButton(AppResource.cancel, delegate (object sender, DialogClickEventArgs e)
                {
                }).Show();
            }
            catch (System.Exception)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "获取功率失败,确认该设备是否支持超高频读写").Show();
            }
        }

        // Token: 0x060003BF RID: 959 RVA: 0x0001B2DC File Offset: 0x000194DC
        private async void ChangePassword()
        {
            await base.NavigationService.NavigateAsync("ChangePwdPage");
        }

        // Token: 0x060003C0 RID: 960 RVA: 0x0001B318 File Offset: 0x00019518
        private async void DataSync()
        {
            if (BasicData.NowOutline)
            {
                Toasty.Warning(CrossCurrentActivity.Current.Activity, "请在非离线模式下同步").Show();
            }
            else
            {
                if (this.progressDialog == null)
                {
                    this.progressDialog = new ProgressDialog(CrossCurrentActivity.Current.Activity);
                    this.progressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
                    this.progressDialog.SetCancelable(false);
                    this.progressDialog.SetTitle("正在同步...");
                }
                this.progressDialog.Show();
                string result = "";
                try
                {
                    string text = File.ReadAllText(BasicData.FileName);
                    if (string.IsNullOrEmpty(text))
                    {
                        this.progressDialog.Dismiss();
                        Toasty.Info(CrossCurrentActivity.Current.Activity, "没有数据需要同步").Show();
                        return;
                    }
                    text = "[" + text.Remove(text.Length - 1, 1) + "]";
                    List<AppEPCshiFengResquest> list = JsonConvert.DeserializeObject<List<AppEPCshiFengResquest>>(text);
                    this.geocodeSearch = new GeocodeSearch(CrossCurrentActivity.Current.Activity);
                    this.geocodeSearch.SetOnGeocodeSearchListener(new SearchListener(delegate (string obj)
                    {
                        this.geoSearchs.Add(obj);
                    }));
                    foreach (AppEPCshiFengResquest appEPCshiFengResquest in list)
                    {
                        LatLonPoint p = new LatLonPoint(23.06904, 113.8069);
                        RegeocodeQuery p2 = new RegeocodeQuery(p, 200f, "autonavi");
                        this.geocodeSearch.GetFromLocation(p2);
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].data.CurrentAddress = this.geoSearchs[i];
                        BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/EPCshiFeng", list[i]);
                        BaseResponse baseResponse2 = baseResponse;
                        if (!baseResponse2.successed)
                        {
                            result = string.Concat(new object[]
                            {
                                result,
                                "同步失败施封操作:承运人",
                                list[i].data.CarrierOid,
                                " 车牌:",
                                list[i].data.CarOid,
                                " 铅封编号:",
                                list[i].data.Number,
                                baseResponse2.msg,
                                "\n"
                            });
                        }
                    }
                    list = null;
                }
                catch (System.Exception ex)
                {
                    this.progressDialog.Dismiss();
                    if (ex is AMapException)
                    {
                        Toasty.Error(CrossCurrentActivity.Current.Activity, ex.Message).Show();
                        return;
                    }
                    Toasty.Error(CrossCurrentActivity.Current.Activity, "请检查网络,稍后重试").Show();
                    return;
                }
                this.progressDialog.Dismiss();
                if (string.IsNullOrEmpty(result))
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, "全部同步成功").Show();
                    File.WriteAllText(BasicData.FileName, "");
                }
                else
                {
                    string a = await this.pageDialogService.DisplayActionSheetAsync("同步错误信息", result, "确定", new string[]
                    {
                        "清除数据"
                    });
                    if (!(a == "确定") && a == "清除数据")
                    {
                        File.WriteAllText(BasicData.FileName, "");
                        Toasty.Success(CrossCurrentActivity.Current.Activity, "同步数据已清除").Show();
                    }
                }
            }
        }

        // Token: 0x060003C1 RID: 961 RVA: 0x0001B354 File Offset: 0x00019554
        private async void UserHelp()
        {
            await base.NavigationService.NavigateAsync("PdfJsPage");
        }

        // Token: 0x060003C2 RID: 962 RVA: 0x0001B38D File Offset: 0x0001958D
        private void Exit()
        {
            base.NavigationService.NavigateAsync("/BlackTextNavigationPage/LoginPage");
        }

        // Token: 0x1700012A RID: 298
        // (get) Token: 0x060003C4 RID: 964 RVA: 0x0001B3D0 File Offset: 0x000195D0
        // (set) Token: 0x060003C3 RID: 963 RVA: 0x0001B3A0 File Offset: 0x000195A0
        public DelegateCommand ExitCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< ExitCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ExitCommand > k__BackingField, value))
                {
                    return;
                }
                this.< ExitCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ExitCommand);
            }
        }

        // Token: 0x1700012B RID: 299
        // (get) Token: 0x060003C5 RID: 965 RVA: 0x0001B3D8 File Offset: 0x000195D8
        // (set) Token: 0x060003C6 RID: 966 RVA: 0x0001B3E0 File Offset: 0x000195E0
        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.< Name > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Name > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Name > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Name);
            }
        }

        // Token: 0x1700012C RID: 300
        // (get) Token: 0x060003C8 RID: 968 RVA: 0x0001B444 File Offset: 0x00019644
        // (set) Token: 0x060003C7 RID: 967 RVA: 0x0001B414 File Offset: 0x00019614
        public List<MenuItem> MenuSource
        {
            [CompilerGenerated]
            get
            {
                return this.< MenuSource > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< MenuSource > k__BackingField, value))
                {
                    return;
                }
                this.< MenuSource > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.MenuSource);
            }
        }

        // Token: 0x1700012D RID: 301
        // (get) Token: 0x060003C9 RID: 969 RVA: 0x0001B44C File Offset: 0x0001964C
        // (set) Token: 0x060003CA RID: 970 RVA: 0x0001B454 File Offset: 0x00019654
        public ImageSource UserIcon
        {
            [CompilerGenerated]
            get
            {
                return this.< UserIcon > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< UserIcon > k__BackingField, value))
                {
                    return;
                }
                this.< UserIcon > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.UserIcon);
            }
        }

        // Token: 0x1700012E RID: 302
        // (get) Token: 0x060003CB RID: 971 RVA: 0x0001B484 File Offset: 0x00019684
        // (set) Token: 0x060003CC RID: 972 RVA: 0x0001B48C File Offset: 0x0001968C
        public ImageSource Background
        {
            [CompilerGenerated]
            get
            {
                return this.< Background > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< Background > k__BackingField, value))
                {
                    return;
                }
                this.< Background > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Background);
            }
        }

        // Token: 0x1700012F RID: 303
        // (get) Token: 0x060003CD RID: 973 RVA: 0x0001B4BC File Offset: 0x000196BC
        // (set) Token: 0x060003CE RID: 974 RVA: 0x0001B4C4 File Offset: 0x000196C4
        public string Introduce
        {
            [CompilerGenerated]
            get
            {
                return this.< Introduce > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Introduce > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Introduce > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Introduce);
            }
        }

        // Token: 0x060003CF RID: 975 RVA: 0x0001B4F8 File Offset: 0x000196F8
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            if (BasicData.NowOutline)
            {
                this.OutlineSetInfo();
            }
            else
            {
                this.apiHelper = new ApiHelper();
                if (BasicData.User == null)
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, "获取个人数据失败").Show();
                }
            }
            try
            {
                this.Name = BasicData.User.Name;
                this.Introduce = string.Format("{0} {1} {2}", BasicData.User.CompanyName, BasicData.User.DeptName, BasicData.User.RoleName);
                this.UserIcon = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(BasicData.User.ImageData)));
                ImageSource background;
                if (!string.IsNullOrEmpty(BasicData.User.AppImageData))
                {
                    background = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(BasicData.User.AppImageData)));
                }
                else
                {
                    background = ImageSource.FromFile("Photo.png");
                }
                this.Background = background;
            }
            catch (System.Exception)
            {
            }
        }

        // Token: 0x060003D0 RID: 976 RVA: 0x0001B60C File Offset: 0x0001980C
        private void OutlineSetInfo()
        {
            BasicData.User = new AppUser
            {
                ImageData = Preferences.Get("icon", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAAAXNSR0IArs4c6QAAB31JREFUeAHtm0uPFUUYhhkERmBm1AxynTEHRheOEIz3aILGjYl/QMOWyNKtqMTEhUb/gIkbdxpd+Bc0uFCjqBhQEwU5ysh1RgkzgkOG4Ps0pzp9zulLdVf1ufabvNPd1VVfVb/9VX1fd58ZWdVdjKr7CXEsQsrWRKjdVSsRLmt/KcIr2qesKxjpcK+3qb+7xU0Njnvqf1F25hu8pO0NT3YzzXRCQPqYFKfEbSLeVSbw1nPinLgg3hRLQ5kC4m3T4oy4obQrSDd8VadPiWfEUryyDAERriYiHOtZL4A1EiHrolchfQu4VQPcLa4XexHXNKgT4nlfg/MlIFMU4bb4GljJdi7IPkIyxZ3gQ0ACw4Ni2cHB6UJjGhNsjokEnMJgvSqK1WqI182K7PcbGPN2kXWaFKhQtC4q4Dp1+ISI9/U77tQFkJuyLuYOMEUEJEA8Kd4hDgq4JgIgayNT2xp5BRyT5afEbuV11hdWoCKziil9Ubxu2z6PgNwlxLvd1ngf1iMQsiwRWKw80VZA7g7TdhA9T5fVBETcLJ4VM9dEGwGJVgSMQVrzdDmpwGF4fud5OjU62whIqjII0VaXkQssWQjJmpiILAERbjax9eCfIMXhVRnvH2ORlgCz3vGEMexAg8S1P01Apm6/PZ6VcbPRAC1ikSQgSWW/vBiIvTDPhWiBJm2IE5B1MVHxNgvDU4AmbTEjTsCaKhKBKjQrgCa15qL2tygoPNNaqToOFUCbJi9s9cBpVeD1ToV4BdAGjUJEBeTlauV9oTSJO2gUvoiOCsijS2K+k2hu+E6gEVoFiAo4ZQqrbaYCoVZGQBbGYXzezVQqoQJaBcHECMgr7eqpI0GtmGK0QrPwYxC/VamQT4FAM+OBlYD5xKN2KCC5ja9fSeUfRv+2QLNRPJDf51UopsAEAo4Va1u1QrtKQDc/qAR00++WB1YvD4qrGASRKoEuLuAa1sBKwErA4go4tgw80NHGcDdnClv9iGa4ZUq8+pVKwERtrE5UAlrJlFxphQi8LLq+TODD8wvioyI4Kn4sXuCgB8D4XhQfaYzlW20/EV3Ht8zHkT1iTSwKBveOGH4naBha0PY18VzjuFsb3h6/LcaN75DKXUSsswYuiS7gzrYODnuUMcC1HHQJ9P2qmDQ+xu6CJR8CmmkRN5CdKjwQd6JDZfRdS+krbewpzcJTgYD8v22ZeF7GnymzgwTb9EnfZeIKHkgQWXTohQU5Cy+rwt6sSh7P0xd9ZsFm7Ek20GwZAcH8rU2hv5+qFTchDUR71qLZtEqeztEHfWU94zNmxl4UgWbBt01ZQMgdBS1xJ/4RH89oz4K+T/xD/CujbtHTjOGwaPOvGO+p3o9FO1K7k+KSEfCaDljwjUdqNxd+V23+SaWW0Yr++F8TvOMnMfUX8DpvC8a9Xzwo2kT9I6r3oVgUPP4eF28aAbkQvo24/CvDMbV/TOSH2WngYneLD4unxb9FF9ynxuSbeLeNAzADyAtd3gEwg4L81gio48Bg00+3KMwBBvSNiIdttGg3qTrPiXg+Il4S8+ABVX5JPCBiywb08bromnn8LBtX6XCEPw2w/6y4wRQU3E6p3bvieM72XBw34DeRJeGy+K8INop49i4Rj8PTg59WaGuLRVV8RZyzbZBQD+E+E4PlJyog9WviHnYcMaP2b4h3Odrx1Zwg96bIjXHFcRmoGyPRKUwZd+keMSsFoG4aGPBX4kPiRFrFDpzD4w6Lrp7HUEl9WOvD4NcqoDmRd3pgvBVMvy/Ee8WtrSc7dEyague5Bioz3F+1s2AO2LYKSBkLLOvYWg4ccV3tPxfxbCKvq2fLhBXwlA/E90XG4AOkek3eh9E4AfFCFsodVPAE7tyXIja3ebKZZOYHnXhL/C6pQsFyxMMRmtAaRKIniXRbogWe9u+Xnf3iXk/2jBmm60fiL6bA45Z3hmQIbUgTkHTmabGsaUew2tdg0TXyvNqzzsI/xTJAfntEZFa2IU1AKjPdXN+ZtXUaU4CYBJsZcadIzkfuBwEBCV4WT4unxJNiWaLJdIij2gueOsKSyE6WgFQlL6yxM4So65rJ+xIRF0RaK8+rgLRmfeuJAT8ml/1eJKgmwkZADLDWsE6tS7Q0WCf4TvS1yPqXChsBMXBDJBJtF8sKKjLdE/hPoyDlIpfMhK2AGOJuXBQJLIMqIuLxCBobcVXehjwC0pisnoi0WRy06cy0xfOsxVPd2CcRytOAJ54VJ8VBCSwEDNY8q2mreiHyeqBpyJo4J+KF5Gz9jLoGT7TNDBhxF1lUQGwRnVkTeT5kSq8W+wkIhnAk5ampStpF2STSae3NOR77eNtSxrOz6cPnlozihJhrvYsbgC8BjW1yRYTs1bWRV1IIR17rBb4FZFAsCzVxRhwVewEEB6ZqXWT99oYyBDSDQ8hpESGZ4t0AUxThzohehTMXU6aA0T5IeabETiThBAdyVbIEXr8XDhBqm4lOCBgdBF7Ji4lNDY5HTzrskwnw0gPyebQUb5PdNnRawNYBsEZOiGMRUsajoqF2gxwNz4KsZzw1GPINJ3cCrDZe8D8Odx9OaSgnIAAAAABJRU5ErkJggg=="),
                CompanyName = Preferences.Get("company", ""),
                DeptName = Preferences.Get("dept", ""),
                Name = Preferences.Get("name", ""),
                RoleName = Preferences.Get("role", "")
            };
        }

        // Token: 0x060003D1 RID: 977 RVA: 0x0001B68C File Offset: 0x0001988C
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x0400026A RID: 618
        private IPageDialogService pageDialogService;

        // Token: 0x0400026B RID: 619
        private List<string> geoSearchs = new List<string>();

        // Token: 0x0400026C RID: 620
        private ProgressDialog progressDialog;

        // Token: 0x0400026D RID: 621
        private GeocodeSearch geocodeSearch;

        // Token: 0x04000274 RID: 628
        private ApiHelper apiHelper;
    }

    public class PdfJsPageViewModel : ViewModelBase
    {
        // Token: 0x17000148 RID: 328
        // (get) Token: 0x0600043A RID: 1082 RVA: 0x0001D661 File Offset: 0x0001B861
        // (set) Token: 0x06000439 RID: 1081 RVA: 0x0001D630 File Offset: 0x0001B830
        public string PdfSource
        {
            [CompilerGenerated]
            get
            {
                return this.< PdfSource > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< PdfSource > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< PdfSource > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.PdfSource);
            }
        }

        // Token: 0x0600043B RID: 1083 RVA: 0x0001D669 File Offset: 0x0001B869
        public PdfJsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = "使用说明";
            this.PdfSource = "file:///android_asset/pdfjs/web/viewer.html?file=file:///android_asset/help.pdf";
        }
    }

    // Token: 0x020000BC RID: 188
    public class QueryLockPageViewModel : ViewModelBase
    {
        // Token: 0x06000427 RID: 1063 RVA: 0x0001941A File Offset: 0x0001761A
        public QueryLockPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        // Token: 0x17000144 RID: 324
        // (get) Token: 0x06000429 RID: 1065 RVA: 0x0001D071 File Offset: 0x0001B271
        // (set) Token: 0x06000428 RID: 1064 RVA: 0x0001D040 File Offset: 0x0001B240
        public string Place
        {
            [CompilerGenerated]
            get
            {
                return this.< Place > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Place > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Place > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Place);
            }
        }

        // Token: 0x17000145 RID: 325
        // (get) Token: 0x0600042B RID: 1067 RVA: 0x0001D0AD File Offset: 0x0001B2AD
        // (set) Token: 0x0600042A RID: 1066 RVA: 0x0001D07C File Offset: 0x0001B27C
        public string Address
        {
            [CompilerGenerated]
            get
            {
                return this.< Address > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Address > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Address > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Address);
            }
        }

        // Token: 0x17000146 RID: 326
        // (get) Token: 0x0600042D RID: 1069 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
        // (set) Token: 0x0600042C RID: 1068 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
        public ObservableCollection<AppShiFengImage> Queries
        {
            [CompilerGenerated]
            get
            {
                return this.< Queries > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< Queries > k__BackingField, value))
                {
                    return;
                }
                this.< Queries > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Queries);
            }
        }

        // Token: 0x0600042E RID: 1070 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("rfid"))
            {
                ApiHelper apiHelper = new ApiHelper();
                base.IsBusy = true;
                AppResult<AppRFIDInfoImage> appResult = await apiHelper.PostWithJson<AppResult<AppRFIDInfoImage>>("SearchRFIDInfoDetalImage", new AppSender<AppSenderRFIDInfo>
                {
                    data = new AppSenderRFIDInfo
                    {
                        RFIDInfoOid = (Guid)parameters["rfid"]
                    }
                });
                AppResult<AppRFIDInfoImage> appResult2 = appResult;
                if (appResult2.successed)
                {
                    base.Title = appResult2.data.CarID;
                    this.Address = appResult2.data.PurposeAddress;
                    this.Place = appResult2.data.SealingAddress;
                    List<AppShiFengImage> list = new List<AppShiFengImage>();
                    if (!string.IsNullOrEmpty(appResult2.data.SealingImageStrings))
                    {
                        list.Add(new AppShiFengImage
                        {
                            operate = "施封",
                            photo = appResult2.data.SealingImageStrings,
                            time = appResult2.data.SaelingDate
                        });
                    }
                    if (appResult2.data.Inspectiopns != null && appResult2.data.Inspectiopns.Count > 0)
                    {
                        foreach (AppInspectionInfo appInspectionInfo in appResult2.data.Inspectiopns)
                        {
                            list.Add(new AppShiFengImage
                            {
                                operate = "巡检",
                                photo = appInspectionInfo.ImageStrings,
                                time = appInspectionInfo.Operator
                            });
                        }
                    }
                    if (!string.IsNullOrEmpty(appResult2.data.UnpackingImageStrings))
                    {
                        list.Add(new AppShiFengImage
                        {
                            operate = "拆封",
                            photo = appResult2.data.UnpackingImageStrings,
                            time = appResult2.data.UnpackingDate
                        });
                    }
                    this.Queries = new ObservableCollection<AppShiFengImage>(list);
                }
                else
                {
                    Toasty.Warning(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
                }
                base.IsBusy = false;
            }
        }
    }

    // Token: 0x0200009E RID: 158
    public class QueryPageViewModel : TabbedChildViewModel
    {
        // Token: 0x1700011E RID: 286
        // (get) Token: 0x06000383 RID: 899 RVA: 0x00019E71 File Offset: 0x00018071
        // (set) Token: 0x06000382 RID: 898 RVA: 0x00019E40 File Offset: 0x00018040
        public string DateText
        {
            [CompilerGenerated]
            get
            {
                return this.< DateText > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< DateText > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< DateText > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.DateText);
            }
        }

        // Token: 0x1700011F RID: 287
        // (get) Token: 0x06000384 RID: 900 RVA: 0x00019E79 File Offset: 0x00018079
        public DelegateCommand<Guid?> WayBillCommand { get; }

        // Token: 0x17000120 RID: 288
        // (get) Token: 0x06000385 RID: 901 RVA: 0x00019E81 File Offset: 0x00018081
        public DelegateCommand CarCommand { get; }

        // Token: 0x17000121 RID: 289
        // (get) Token: 0x06000386 RID: 902 RVA: 0x00019E89 File Offset: 0x00018089
        public DelegateCommand RefreshCommand { get; }

        // Token: 0x17000122 RID: 290
        // (get) Token: 0x06000387 RID: 903 RVA: 0x00019E91 File Offset: 0x00018091
        public DelegateCommand<Guid?> LocationCommand { get; }

        // Token: 0x17000123 RID: 291
        // (get) Token: 0x06000388 RID: 904 RVA: 0x00019E99 File Offset: 0x00018099
        public DelegateCommand<RFidInfo> MapCommand { get; }

        // Token: 0x17000124 RID: 292
        // (get) Token: 0x06000389 RID: 905 RVA: 0x00019EA1 File Offset: 0x000180A1
        public DelegateCommand DateCommand { get; }

        // Token: 0x0600038A RID: 906 RVA: 0x00019EAC File Offset: 0x000180AC
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("car"))
            {
                if (parameters["car"].Equals("全部车辆"))
                {
                    this.carno = null;
                }
                else
                {
                    this.carno = new Guid?((Guid)parameters["carno"]);
                }
                base.Title = parameters["car"].ToString();
                base.IsBusy = true;
                this.Items.Clear();
                await this.GetItemsWithoutPage();
                base.IsBusy = false;
            }
        }

        // Token: 0x0600038B RID: 907 RVA: 0x00019EF0 File Offset: 0x000180F0
        protected override async void RaiseIsActiveChanged()
        {
            base.RaiseIsActiveChanged();
            if (!BasicData.NowOutline)
            {
                if (base.IsActive)
                {
                    if (!this.noquery)
                    {
                        base.IsBusy = true;
                        await this.GetItemsWithoutPage();
                        base.IsBusy = false;
                        this.noquery = true;
                    }
                }
            }
        }

        // Token: 0x0600038C RID: 908 RVA: 0x00019F2C File Offset: 0x0001812C
        private void GOMap(RFidInfo model)
        {
            Intent intent = new Intent(CrossCurrentActivity.Current.Activity, typeof(AMapActivity));
            intent.PutExtra("StartLatitude", Convert.ToDouble(model.BeginLatitude));
            intent.PutExtra("StartLongitude", Convert.ToDouble(model.BeginLongitude));
            intent.PutExtra("EndLatitude", Convert.ToDouble(model.BeginLatitude));
            intent.PutExtra("EndLongitude", Convert.ToDouble(model.EndLongitude));
            intent.PutExtra("startAddress", model.BeginAddress);
            intent.PutExtra("endAddress", model.EndAddress);
            CrossCurrentActivity.Current.Activity.StartActivity(intent);
        }

        // Token: 0x0600038D RID: 909 RVA: 0x00019FE4 File Offset: 0x000181E4
        private async void QueryLocation(Guid? rfid)
        {
            if (rfid == null)
            {
                Toasty.Info(CrossCurrentActivity.Current.Activity, "获取铅封编号错误").Show();
            }
            else
            {
                NavigationParameters navigationParameters = new NavigationParameters();
                navigationParameters.Add("rfid", rfid.Value);
                await base.NavigationService.NavigateAsync("QueryLockPage", navigationParameters);
            }
        }

        // Token: 0x0600038E RID: 910 RVA: 0x0001A028 File Offset: 0x00018228
        private async void QueryWayBill(Guid? rfid)
        {
            if (rfid == null)
            {
                Toasty.Info(CrossCurrentActivity.Current.Activity, "获取铅封编号错误").Show();
            }
            else
            {
                NavigationParameters navigationParameters = new NavigationParameters();
                navigationParameters.Add("rfid", rfid.Value);
                await base.NavigationService.NavigateAsync("QueryUploadPage", navigationParameters);
            }
        }

        // Token: 0x0600038F RID: 911 RVA: 0x0001A06C File Offset: 0x0001826C
        private void InitDatePicker()
        {
            this.datePicker = new DatePickerDialog(CrossCurrentActivity.Current.Activity, 16974064, async delegate (object sender, DatePickerDialog.DateSetEventArgs e)
            {
                this.year = e.Year;
                this.month = e.Month + 1;
                this.Items.Clear();
                await this.GetItemsWithoutPage();
                this.DateText = this.month + "月/" + this.year;
            }, this.year, this.month, 0);
            this.datePicker.SetTitle("选择查询的年份与月份");
        }

        // Token: 0x06000390 RID: 912 RVA: 0x0001A0BC File Offset: 0x000182BC
        private void SelectDate()
        {
            this.datePicker.Show();
            int num;
            try
            {
                num = Convert.ToInt32(Build.VERSION.Sdk);
            }
            catch (Exception)
            {
                num = 0;
            }
            ViewGroup viewGroup = (ViewGroup)this.datePicker.Window.DecorView;
            DatePicker datePicker = this.FindDatePicker(viewGroup);
            ViewGroup viewGroup2 = null;
            if (num != 0 && datePicker != null)
            {
                if (num < 11)
                {
                    viewGroup2 = (ViewGroup)datePicker.GetChildAt(0);
                }
                else if (num > 14)
                {
                    viewGroup2 = (ViewGroup)((ViewGroup)datePicker.GetChildAt(0)).GetChildAt(0);
                }
            }
            if (viewGroup2 != null)
            {
                viewGroup2.GetChildAt(2).Visibility = ViewStates.Gone;
            }
        }

        // Token: 0x06000391 RID: 913 RVA: 0x0001A160 File Offset: 0x00018360
        private DatePicker FindDatePicker(ViewGroup viewGroup)
        {
            if (viewGroup != null)
            {
                int i = 0;
                int childCount = viewGroup.ChildCount;
                while (i < childCount)
                {
                    View childAt = viewGroup.GetChildAt(i);
                    if (childAt is DatePicker)
                    {
                        return (DatePicker)childAt;
                    }
                    if (childAt is ViewGroup)
                    {
                        DatePicker datePicker = this.FindDatePicker((ViewGroup)childAt);
                        if (datePicker != null)
                        {
                            return datePicker;
                        }
                    }
                    i++;
                }
            }
            return null;
        }

        // Token: 0x06000392 RID: 914 RVA: 0x0001A1B8 File Offset: 0x000183B8
        private async void SelectCar()
        {
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("all", true);
            await base.NavigationService.NavigateAsync("CarPage", navigationParameters);
        }

        // Token: 0x06000393 RID: 915 RVA: 0x0001A1F4 File Offset: 0x000183F4
        private async void Refresh()
        {
            base.IsBusy = true;
            this.Items.Clear();
            this.page = 0;
            this.month = DateTime.Now.Month;
            this.year = DateTime.Now.Year;
            this.DateText = this.month + "月/" + this.year;
            await this.GetItemsWithoutPage();
            base.IsBusy = false;
        }

        // Token: 0x06000394 RID: 916 RVA: 0x0001A22D File Offset: 0x0001842D
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x06000395 RID: 917 RVA: 0x0001A240 File Offset: 0x00018440
        public QueryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.apiHelper = new ApiHelper();
            this.RefreshCommand = new DelegateCommand(new Action(this.Refresh));
            this.DateCommand = new DelegateCommand(new Action(this.SelectDate));
            this.CarCommand = new DelegateCommand(new Action(this.SelectCar));
            this.MapCommand = new DelegateCommand<RFidInfo>(new Action<RFidInfo>(this.GOMap));
            this.WayBillCommand = new DelegateCommand<Guid?>(new Action<Guid?>(this.QueryWayBill));
            this.LocationCommand = new DelegateCommand<Guid?>(new Action<Guid?>(this.QueryLocation));
            this.DateText = this.month + "月/" + this.year;
            this.Items = new ObservableCollection<RFidInfo>();
            this.InitDatePicker();
        }

        // Token: 0x06000396 RID: 918 RVA: 0x0001A354 File Offset: 0x00018554
        private async Task GetItemsWithoutPage()
        {
            AppResult<List<RFidInfo>> appResult = await this.apiHelper.PostWithJson<AppResult<List<RFidInfo>>>("SearchRFIDInfo", new AppSender<AppSenderSearch>
            {
                data = new AppSenderSearch
                {
                    CarOid = this.carno,
                    CompanyOid = BasicData.User.CompanyOid,
                    SearchMonth = this.month,
                    SearchYear = this.year
                }
            });
            AppResult<List<RFidInfo>> appResult2 = appResult;
            if (appResult2.data != null && appResult2.data.Count > 0)
            {
                foreach (RFidInfo rfidInfo in from r in appResult2.data
                                              orderby r.EndDate descending, r.BeginDate descending
                                              select r)
                {
                    rfidInfo.WayBillCommand = this.WayBillCommand;
                    rfidInfo.LocationCommand = this.LocationCommand;
                    rfidInfo.MapCommand = this.MapCommand;
                    this.Items.Add(rfidInfo);
                }
            }
        }

        // Token: 0x17000125 RID: 293
        // (get) Token: 0x06000397 RID: 919 RVA: 0x0001A399 File Offset: 0x00018599
        public ObservableCollection<RFidInfo> Items { get; }

        // Token: 0x17000126 RID: 294
        // (get) Token: 0x06000398 RID: 920 RVA: 0x0001A3A1 File Offset: 0x000185A1
        // (set) Token: 0x06000399 RID: 921 RVA: 0x0001A3AC File Offset: 0x000185AC
        public bool IsLoadingMore
        {
            [CompilerGenerated]
            get
            {
                return this.< IsLoadingMore > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (this.< IsLoadingMore > k__BackingField == value)
                {
                    return;
                }
                this.< IsLoadingMore > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.IsLoadingMore);
            }
        }

        // Token: 0x0600039A RID: 922 RVA: 0x0001A3DC File Offset: 0x000185DC
        private async Task<InfiniteScrollCollection<RFidInfo>> GetItems()
        {
            InfiniteScrollCollection<RFidInfo> items = new InfiniteScrollCollection<RFidInfo>();
            AppResult<List<RFidInfo>> appResult = await this.apiHelper.PostWithJson<AppResult<List<RFidInfo>>>("SearchRFIDInfo", new AppSenderSearch
            {
                CarOid = this.carno,
                CompanyOid = BasicData.User.CompanyOid,
                SearchMonth = this.month,
                SearchYear = this.year
            });
            AppResult<List<RFidInfo>> appResult2 = appResult;
            if (appResult2.data != null && appResult2.data.Count > 0)
            {
                foreach (RFidInfo rfidInfo in appResult2.data)
                {
                    rfidInfo.WayBillCommand = this.WayBillCommand;
                    rfidInfo.LocationCommand = this.LocationCommand;
                    rfidInfo.MapCommand = this.MapCommand;
                    items.Add(rfidInfo);
                }
            }
            return items;
        }

        // Token: 0x04000229 RID: 553
        private ApiHelper apiHelper;

        // Token: 0x0400022A RID: 554
        private int month = DateTime.Now.Month;

        // Token: 0x0400022B RID: 555
        private int year = DateTime.Now.Year;

        // Token: 0x0400022C RID: 556
        private int count = 5;

        // Token: 0x0400022D RID: 557
        private int page;

        // Token: 0x0400022E RID: 558
        private Guid? carno;

        // Token: 0x04000236 RID: 566
        private bool noquery;

        // Token: 0x04000237 RID: 567
        private DatePickerDialog datePicker;

        // Token: 0x04000239 RID: 569
        private bool canLoadMore = true;
    }

    // Token: 0x020000BE RID: 190
    public class QueryUploadPageViewModel : ViewModelBase
    {
        // Token: 0x06000432 RID: 1074 RVA: 0x0001D41E File Offset: 0x0001B61E
        public QueryUploadPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = "运单照片";
        }

        // Token: 0x17000147 RID: 327
        // (get) Token: 0x06000434 RID: 1076 RVA: 0x0001D464 File Offset: 0x0001B664
        // (set) Token: 0x06000433 RID: 1075 RVA: 0x0001D434 File Offset: 0x0001B634
        public ObservableCollection<AppWayBill> QueryWaybills
        {
            [CompilerGenerated]
            get
            {
                return this.< QueryWaybills > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< QueryWaybills > k__BackingField, value))
                {
                    return;
                }
                this.< QueryWaybills > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.QueryWaybills);
            }
        }

        // Token: 0x06000435 RID: 1077 RVA: 0x0001D46C File Offset: 0x0001B66C
        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            base.IsBusy = true;
            if (parameters.ContainsKey("rfid"))
            {
                ApiHelper apiHelper = new ApiHelper();
                AppResult<List<AppWayBill>> appResult = await apiHelper.PostWithJson<AppResult<List<AppWayBill>>>("SearchRFIDInfoWayBill", new AppSender<AppSenderRFIDInfo>
                {
                    data = new AppSenderRFIDInfo
                    {
                        RFIDInfoOid = (Guid)parameters["rfid"]
                    }
                });
                AppResult<List<AppWayBill>> appResult2 = appResult;
                if (appResult2.successed || appResult2.data != null)
                {
                    this.QueryWaybills = new ObservableCollection<AppWayBill>(appResult2.data);
                }
                else
                {
                    Toasty.Warning(CrossCurrentActivity.Current.Activity, appResult2.msg).Show();
                }
            }
            base.IsBusy = false;
        }
    }

    // Token: 0x020000C1 RID: 193
    public class ReLockPageViewModel : LocationViewmodel
    {
        // Token: 0x17000149 RID: 329
        // (get) Token: 0x0600043C RID: 1084 RVA: 0x0001D688 File Offset: 0x0001B888
        public DelegateCommand ContinueCommand { get; }

        // Token: 0x1700014A RID: 330
        // (get) Token: 0x0600043D RID: 1085 RVA: 0x0001D690 File Offset: 0x0001B890
        public DelegateCommand NewCommand { get; }

        // Token: 0x1700014B RID: 331
        // (get) Token: 0x0600043F RID: 1087 RVA: 0x0001D6C9 File Offset: 0x0001B8C9
        // (set) Token: 0x0600043E RID: 1086 RVA: 0x0001D698 File Offset: 0x0001B898
        public string Status
        {
            [CompilerGenerated]
            get
            {
                return this.< Status > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Status > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Status > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Status);
            }
        }

        // Token: 0x1700014C RID: 332
        // (get) Token: 0x06000441 RID: 1089 RVA: 0x0001D705 File Offset: 0x0001B905
        // (set) Token: 0x06000440 RID: 1088 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
        public string Begintime
        {
            [CompilerGenerated]
            get
            {
                return this.< Begintime > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Begintime > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Begintime > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Begintime);
            }
        }

        // Token: 0x1700014D RID: 333
        // (get) Token: 0x06000443 RID: 1091 RVA: 0x0001D741 File Offset: 0x0001B941
        // (set) Token: 0x06000442 RID: 1090 RVA: 0x0001D710 File Offset: 0x0001B910
        public string Address
        {
            [CompilerGenerated]
            get
            {
                return this.< Address > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Address > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Address > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Address);
            }
        }

        // Token: 0x1700014E RID: 334
        // (get) Token: 0x06000445 RID: 1093 RVA: 0x0001D77D File Offset: 0x0001B97D
        // (set) Token: 0x06000444 RID: 1092 RVA: 0x0001D74C File Offset: 0x0001B94C
        public string LockLocation
        {
            [CompilerGenerated]
            get
            {
                return this.< LockLocation > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< LockLocation > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< LockLocation > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.LockLocation);
            }
        }

        // Token: 0x06000446 RID: 1094 RVA: 0x0001D785 File Offset: 0x0001B985
        public ReLockPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.NewCommand = new DelegateCommand(new Action(this.New));
            this.ContinueCommand = new DelegateCommand(new Action(this.Continute));
        }

        // Token: 0x06000447 RID: 1095 RVA: 0x0001D7BC File Offset: 0x0001B9BC
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("detail"))
            {
                AppRFIDVerification appRFIDVerification = (AppRFIDVerification)parameters["detail"];
                this.Status = "运输中";
                this.Address = appRFIDVerification.PurposeAddress;
                this.Begintime = appRFIDVerification.BeginDate.ToString("G");
                this.LockLocation = appRFIDVerification.SealingAddress;
                base.Title = appRFIDVerification.CarID + " ->施封";
                this.car = parameters["car"];
                this.carno = parameters["carno"];
                this.rfid = parameters["Tag"];
            }
        }

        // Token: 0x06000448 RID: 1096 RVA: 0x0001D878 File Offset: 0x0001BA78
        private async void Continute()
        {
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("location", this.Address);
            navigationParameters.Add("car", this.car);
            navigationParameters.Add("carno", this.carno);
            navigationParameters.Add("Tag", this.rfid);
            await base.NavigationService.NavigateAsync("LockPage", navigationParameters);
        }

        // Token: 0x06000449 RID: 1097 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
        private async void New()
        {
            NavigationParameters navigationParameters = new NavigationParameters();
            navigationParameters.Add("car", this.car);
            navigationParameters.Add("carno", this.carno);
            navigationParameters.Add("Tag", this.rfid);
            await base.NavigationService.NavigateAsync("LockPage", navigationParameters);
        }

        // Token: 0x040002D4 RID: 724
        private object car;

        // Token: 0x040002D5 RID: 725
        private object carno;

        // Token: 0x040002D6 RID: 726
        private new object rfid;
    }

    // Token: 0x020000BB RID: 187
    public class ScanPageViewModel : ViewModelBase
    {
        // Token: 0x06000425 RID: 1061 RVA: 0x0001CFDE File Offset: 0x0001B1DE
        public ScanPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            base.Title = "条形码二维码扫描";
        }

        // Token: 0x06000426 RID: 1062 RVA: 0x0001CFF4 File Offset: 0x0001B1F4
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("scan"))
            {
                ZXingScannerPage.ScanResultDelegate b = parameters["scan"] as ZXingScannerPage.ScanResultDelegate;
                this.OnResultScan = (ZXingScannerPage.ScanResultDelegate)Delegate.Combine(this.OnResultScan, b);
            }
        }

        // Token: 0x040002BE RID: 702
        public ZXingScannerPage.ScanResultDelegate OnResultScan;
    }


    // Token: 0x020000B1 RID: 177
    public class SearchListener : Java.Lang.Object, GeocodeSearch.IOnGeocodeSearchListener, IJavaObject, IDisposable
    {
        // Token: 0x060003E1 RID: 993 RVA: 0x0001BE4E File Offset: 0x0001A04E
        public SearchListener(Action<string> action)
        {
            this.action = action;
        }

        // Token: 0x060003E2 RID: 994 RVA: 0x00019418 File Offset: 0x00017618
        public void OnGeocodeSearched(GeocodeResult p0, int p1)
        {
        }

        // Token: 0x060003E3 RID: 995 RVA: 0x0001BE5D File Offset: 0x0001A05D
        public void OnRegeocodeSearched(RegeocodeResult p0, int p1)
        {
            this.action(p0.RegeocodeAddress.FormatAddress);
        }

        // Token: 0x0400028C RID: 652
        private Action<string> action;
    }
    // Token: 0x02000096 RID: 150
    public class TabbedChildViewModel : ViewModelBase, IActiveAware
    {
        // Token: 0x0600035F RID: 863 RVA: 0x0001941A File Offset: 0x0001761A
        public TabbedChildViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        // Token: 0x14000001 RID: 1
        // (add) Token: 0x06000360 RID: 864 RVA: 0x00019424 File Offset: 0x00017624
        // (remove) Token: 0x06000361 RID: 865 RVA: 0x0001945C File Offset: 0x0001765C
        public event EventHandler IsActiveChanged;

        // Token: 0x17000117 RID: 279
        // (get) Token: 0x06000362 RID: 866 RVA: 0x00019491 File Offset: 0x00017691
        // (set) Token: 0x06000363 RID: 867 RVA: 0x0001949C File Offset: 0x0001769C
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                if (this._isActive == value)
                {
                    return;
                }
                this.SetProperty<bool>(ref this._isActive, value, new Action(this.RaiseIsActiveChanged), "IsActive");
            }
        }

        // Token: 0x06000364 RID: 868 RVA: 0x000194D7 File Offset: 0x000176D7
        protected virtual void RaiseIsActiveChanged()
        {
            EventHandler isActiveChanged = this.IsActiveChanged;
            if (isActiveChanged == null)
            {
                return;
            }
            isActiveChanged(this, EventArgs.Empty);
        }

        // Token: 0x04000212 RID: 530
        private bool _isActive;
    }
    // Token: 0x02000093 RID: 147
    public class UploadPageViewModel : ViewModelBase
    {
        // Token: 0x06000343 RID: 835 RVA: 0x00018EE2 File Offset: 0x000170E2
        public UploadPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.CommitCommand = new DelegateCommand(new Action(this.Commit));
            this.ImageFiles = new List<byte[]>();
        }

        // Token: 0x17000110 RID: 272
        // (get) Token: 0x06000345 RID: 837 RVA: 0x00018F41 File Offset: 0x00017141
        // (set) Token: 0x06000344 RID: 836 RVA: 0x00018F10 File Offset: 0x00017110
        public string Detail
        {
            [CompilerGenerated]
            get
            {
                return this.< Detail > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Detail > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Detail > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Detail);
            }
        }

        // Token: 0x17000111 RID: 273
        // (get) Token: 0x06000347 RID: 839 RVA: 0x00018F7D File Offset: 0x0001717D
        // (set) Token: 0x06000346 RID: 838 RVA: 0x00018F4C File Offset: 0x0001714C
        public string Delivery
        {
            [CompilerGenerated]
            get
            {
                return this.< Delivery > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (string.Equals(this.< Delivery > k__BackingField, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.< Delivery > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.Delivery);
            }
        }

        // Token: 0x17000112 RID: 274
        // (get) Token: 0x06000349 RID: 841 RVA: 0x00018FB8 File Offset: 0x000171B8
        // (set) Token: 0x06000348 RID: 840 RVA: 0x00018F88 File Offset: 0x00017188
        public List<byte[]> ImageFiles
        {
            [CompilerGenerated]
            get
            {
                return this.< ImageFiles > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< ImageFiles > k__BackingField, value))
                {
                    return;
                }
                this.< ImageFiles > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.ImageFiles);
            }
        }

        // Token: 0x17000113 RID: 275
        // (get) Token: 0x0600034B RID: 843 RVA: 0x00018FF0 File Offset: 0x000171F0
        // (set) Token: 0x0600034A RID: 842 RVA: 0x00018FC0 File Offset: 0x000171C0
        public DelegateCommand CommitCommand
        {
            [CompilerGenerated]
            get
            {
                return this.< CommitCommand > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (object.Equals(this.< CommitCommand > k__BackingField, value))
                {
                    return;
                }
                this.< CommitCommand > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.CommitCommand);
            }
        }

        // Token: 0x0600034C RID: 844 RVA: 0x00018FF8 File Offset: 0x000171F8
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (this.apiHelper == null)
            {
                this.apiHelper = new ApiHelper();
            }
            this.dialog = new ProgressDialog(CrossCurrentActivity.Current.Activity);
            this.dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            this.dialog.SetCancelable(false);
            if (parameters.ContainsKey("detail"))
            {
                this.data = (parameters["detail"] as AppRFIDVerification);
                base.Title = this.data.CarID + "->" + AppResource.upload;
                this.Detail = string.Concat(new object[]
                {
                    "结束时间: ",
                    this.data.EndDate,
                    "\n结束地址: ",
                    this.data.EndAddress
                });
            }
        }

        // Token: 0x0600034D RID: 845 RVA: 0x000190D1 File Offset: 0x000172D1
        public override void Destroy()
        {
            this.apiHelper.Disconnect();
            base.Destroy();
        }

        // Token: 0x0600034E RID: 846 RVA: 0x00015864 File Offset: 0x00013A64
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        // Token: 0x0600034F RID: 847 RVA: 0x000190E4 File Offset: 0x000172E4
        private async void Commit()
        {
            if (this.ImageFiles == null || this.ImageFiles.Count == 0)
            {
                Toasty.Error(CrossCurrentActivity.Current.Activity, "请提交运单照片").Show();
            }
            else
            {
                this.dialog.SetTitle("正在提交");
                this.dialog.Show();
                AppWayBill appWayBill = new AppWayBill
                {
                    CompanyOid = BasicData.User.CompanyOid,
                    Description = this.Delivery,
                    RFIDCode = this.data.RFIDCode,
                    ImageDataStrings = Convert.ToBase64String(this.ImageFiles[0])
                };
                BaseResponse baseResponse = await this.apiHelper.PostWithJson<BaseResponse>("data/Waybill", new AppSender<AppWayBill>
                {
                    data = appWayBill
                });
                BaseResponse baseResponse2 = baseResponse;
                if (baseResponse2.successed)
                {
                    Toasty.Success(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                    await base.NavigationService.GoBackAsync();
                }
                else
                {
                    Toasty.Error(CrossCurrentActivity.Current.Activity, baseResponse2.msg).Show();
                }
                this.dialog.Dismiss();
            }
        }

        // Token: 0x04000205 RID: 517
        private AppRFIDVerification data;

        // Token: 0x04000206 RID: 518
        private ApiHelper apiHelper;

        // Token: 0x04000208 RID: 520
        private ProgressDialog dialog;
    }
    public class ViewModelBase : BindableBase, INavigationAware, INavigatedAware, INavigatingAware, IDestructible, IPageAppearing
    {
        // Token: 0x17000114 RID: 276
        // (get) Token: 0x06000352 RID: 850 RVA: 0x0001935E File Offset: 0x0001755E
        // (set) Token: 0x06000353 RID: 851 RVA: 0x00019368 File Offset: 0x00017568
        private protected INavigationService NavigationService
        {
            [CompilerGenerated]
            protected get
            {
                return this.< NavigationService > k__BackingField;
            }
            [CompilerGenerated]
            private set
            {
                if (object.Equals(this.< NavigationService > k__BackingField, value))
                {
                    return;
                }
                this.< NavigationService > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.NavigationService);
            }
        }

        // Token: 0x17000115 RID: 277
        // (get) Token: 0x06000354 RID: 852 RVA: 0x00019398 File Offset: 0x00017598
        // (set) Token: 0x06000355 RID: 853 RVA: 0x000193A0 File Offset: 0x000175A0
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if (string.Equals(this._title, value, StringComparison.Ordinal))
                {
                    return;
                }
                this.SetProperty<string>(ref this._title, value, "Title");
            }
        }

        // Token: 0x17000116 RID: 278
        // (get) Token: 0x06000357 RID: 855 RVA: 0x00019401 File Offset: 0x00017601
        // (set) Token: 0x06000356 RID: 854 RVA: 0x000193D4 File Offset: 0x000175D4
        public bool IsBusy
        {
            [CompilerGenerated]
            get
            {
                return this.< IsBusy > k__BackingField;
            }
            [CompilerGenerated]
            set
            {
                if (this.< IsBusy > k__BackingField == value)
                {
                    return;
                }
                this.< IsBusy > k__BackingField = value;
                this.OnPropertyChanged(<> PropertyChangedEventArgs.IsBusy);
            }
        }

        // Token: 0x06000358 RID: 856 RVA: 0x00019409 File Offset: 0x00017609
        public ViewModelBase(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        // Token: 0x06000359 RID: 857 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        // Token: 0x0600035A RID: 858 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        // Token: 0x0600035B RID: 859 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        // Token: 0x0600035C RID: 860 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void Destroy()
        {
        }

        // Token: 0x0600035D RID: 861 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void OnAppearing()
        {
        }

        // Token: 0x0600035E RID: 862 RVA: 0x00019418 File Offset: 0x00017618
        public virtual void OnDisappearing()
        {
        }

        // Token: 0x0400020F RID: 527
        private string _title;
    }
}
