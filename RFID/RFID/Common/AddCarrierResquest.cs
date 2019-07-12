using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Java.Lang;
using Java.Net;
using Java.Util;
using Prism.Commands;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RFID.Common
{
    // Token: 0x02000040 RID: 64
    public class AddCarrierResquest : BaseRequest
    {
        // Token: 0x170000B0 RID: 176
        // (get) Token: 0x060001A4 RID: 420 RVA: 0x0000364B File Offset: 0x0000184B
        // (set) Token: 0x060001A3 RID: 419 RVA: 0x00003642 File Offset: 0x00001842
        public new AppCarrier data { get; set; }
    }

    public class AddVehicleResquest : BaseRequest
    {
        // Token: 0x170000AB RID: 171
        // (get) Token: 0x06000197 RID: 407 RVA: 0x000035F6 File Offset: 0x000017F6
        // (set) Token: 0x06000196 RID: 406 RVA: 0x000035ED File Offset: 0x000017ED
        public new AppVehicle data { get; set; }
    }
    public class AllLogisticsBatchResponse : BaseResponse
    {
        // Token: 0x17000084 RID: 132
        // (get) Token: 0x0600013C RID: 316 RVA: 0x00003337 File Offset: 0x00001537
        // (set) Token: 0x0600013B RID: 315 RVA: 0x0000332E File Offset: 0x0000152E
        public new List<MyAppLogisticsBatch> data { get; set; }
    }

    // Token: 0x02000031 RID: 49
    public class ApiRoute
    {
        // Token: 0x040000B3 RID: 179
        public const string test = "data/Test";

        // Token: 0x040000B4 RID: 180
        public const string login = "data/VerificationUser";

        // Token: 0x040000B5 RID: 181
        public const string vehicle_finish = "data/GetVehicleFinished";

        // Token: 0x040000B6 RID: 182
        public const string vehicle_transport = "data/GetVehicleTransport";

        // Token: 0x040000B7 RID: 183
        public const string GetAllVehicle = "data/GetAllVehicle";

        // Token: 0x040000B8 RID: 184
        public const string GetCarrier = "data/GetCarrier";

        // Token: 0x040000B9 RID: 185
        public const string personalInfomation = "data/PersonalInfomation";

        // Token: 0x040000BA RID: 186
        public const string changePwd = "data/ChangePwd";

        // Token: 0x040000BB RID: 187
        public const string AddCarrier = "data/AddCarrier";

        // Token: 0x040000BC RID: 188
        public const string Addshifeng = "data/AddShiFeng";

        // Token: 0x040000BD RID: 189
        public const string EPCshiFeng = "data/EPCshiFeng";

        // Token: 0x040000BE RID: 190
        public const string EPConSiteInspection = "data/EPConSiteInspection";

        // Token: 0x040000BF RID: 191
        public const string UnsealEPC = "data/UnsealEPC";

        // Token: 0x040000C0 RID: 192
        public const string Waybill = "data/Waybill";

        // Token: 0x040000C1 RID: 193
        public const string ScarpEPC = "data/ScarpEPC";

        // Token: 0x040000C2 RID: 194
        public const string AbnormalEPC = "data/AbnormalEPC";

        // Token: 0x040000C3 RID: 195
        public const string GetAppShiFeng = "data/GetAppShiFeng";

        // Token: 0x040000C4 RID: 196
        public const string addVehicle = "data/AddVehicle";

        // Token: 0x040000C5 RID: 197
        public const string QueryWaybill = "data/QueryWaybill";

        // Token: 0x040000C6 RID: 198
        public const string QueryScarpEPC = "data/QueryScarpEPC";

        // Token: 0x040000C7 RID: 199
        public const string ReadEPC = "data/ReadEPC";

        // Token: 0x040000C8 RID: 200
        public const string VehicleLogisticsBatch = "data/VehicleLogisticsBatch";

        // Token: 0x040000C9 RID: 201
        public const string AParamsLogisticsBatch = "data/AParamsLogisticsBatch";

        // Token: 0x040000CA RID: 202
        public const string QueryBatchWithParams = "data/QueryBatchWithParams";

        // Token: 0x040000CB RID: 203
        public const string AppShiFengLocation = "data/AppShiFengLocation";

        // Token: 0x040000CC RID: 204
        public const string AppQueryWaybill = "data/AppQueryWaybill";

        // Token: 0x040000CD RID: 205
        public const string SearchRFIDInfo = "SearchRFIDInfo";

        // Token: 0x040000CE RID: 206
        public const string GetConfiguration = "data/GetEnterpriseConfiguration";

        // Token: 0x040000CF RID: 207
        public const string GetAllCars = "data/GetAllCars";

        // Token: 0x040000D0 RID: 208
        public const string UploadCarInfo = "data/UploadCarInfo";

        // Token: 0x040000D1 RID: 209
        public const string GetAllCarrier = "data/GetAllCarrier";

        // Token: 0x040000D2 RID: 210
        public const string UploadCarrierInfo = "data/UploadCarrierInfo";

        // Token: 0x040000D3 RID: 211
        public const string GetAllSealingaddress = "data/GetAllSealingaddress";

        // Token: 0x040000D4 RID: 212
        public const string UploadSealingaddressInfo = "data/UploadSealingaddressInfo";

        // Token: 0x040000D5 RID: 213
        public const string SearchRFIDInfoDetalImage = "SearchRFIDInfoDetalImage";

        // Token: 0x040000D6 RID: 214
        public const string SearchRFIDInfoWayBill = "SearchRFIDInfoWayBill";

        // Token: 0x040000D7 RID: 215
        public const string VerificationRFID = "data/VerificationRFID";

        // Token: 0x040000D8 RID: 216
        public const string VerificationCar = "data/VerificationCar";

        // Token: 0x040000D9 RID: 217
        public const string EPCShiFeng = "data/EPCShiFeng";

        // Token: 0x040000DA RID: 218
        public const string AppSenderCarInfo = "data/AppSenderCarInfo";
    }

    // Token: 0x0200004B RID: 75
    public class AppAbnormalEPC
    {
        // Token: 0x170000CF RID: 207
        // (get) Token: 0x060001ED RID: 493 RVA: 0x0000385A File Offset: 0x00001A5A
        // (set) Token: 0x060001EC RID: 492 RVA: 0x00003851 File Offset: 0x00001A51
        public Guid CompanyOid { get; set; }

        // Token: 0x170000D0 RID: 208
        // (get) Token: 0x060001EF RID: 495 RVA: 0x0000386B File Offset: 0x00001A6B
        // (set) Token: 0x060001EE RID: 494 RVA: 0x00003862 File Offset: 0x00001A62
        public Guid CarOid { get; set; }

        // Token: 0x170000D1 RID: 209
        // (get) Token: 0x060001F1 RID: 497 RVA: 0x0000387C File Offset: 0x00001A7C
        // (set) Token: 0x060001F0 RID: 496 RVA: 0x00003873 File Offset: 0x00001A73
        public decimal Longitude { get; set; }

        // Token: 0x170000D2 RID: 210
        // (get) Token: 0x060001F3 RID: 499 RVA: 0x0000388D File Offset: 0x00001A8D
        // (set) Token: 0x060001F2 RID: 498 RVA: 0x00003884 File Offset: 0x00001A84
        public decimal Latitude { get; set; }

        // Token: 0x170000D3 RID: 211
        // (get) Token: 0x060001F5 RID: 501 RVA: 0x0000389E File Offset: 0x00001A9E
        // (set) Token: 0x060001F4 RID: 500 RVA: 0x00003895 File Offset: 0x00001A95
        public string CurrentAddress { get; set; }

        // Token: 0x170000D4 RID: 212
        // (get) Token: 0x060001F7 RID: 503 RVA: 0x000038AF File Offset: 0x00001AAF
        // (set) Token: 0x060001F6 RID: 502 RVA: 0x000038A6 File Offset: 0x00001AA6
        public string ErrorInfo { get; set; }

        // Token: 0x170000D5 RID: 213
        // (get) Token: 0x060001F9 RID: 505 RVA: 0x000038C0 File Offset: 0x00001AC0
        // (set) Token: 0x060001F8 RID: 504 RVA: 0x000038B7 File Offset: 0x00001AB7
        public string ImageDataStrings { get; set; }
    }
    // Token: 0x0200004C RID: 76
    public class AppAbnormalEPCRequest : BaseRequest
    {
        // Token: 0x170000D6 RID: 214
        // (get) Token: 0x060001FC RID: 508 RVA: 0x000038D1 File Offset: 0x00001AD1
        // (set) Token: 0x060001FB RID: 507 RVA: 0x000038C8 File Offset: 0x00001AC8
        public new AppAbnormalEPC data { get; set; }
    }
    // Token: 0x02000041 RID: 65
    public class AppAddShiFeng
    {
        // Token: 0x170000B1 RID: 177
        // (get) Token: 0x060001A7 RID: 423 RVA: 0x0000365C File Offset: 0x0000185C
        // (set) Token: 0x060001A6 RID: 422 RVA: 0x00003653 File Offset: 0x00001853
        public string ShiFenglocation { get; set; }
    }
    // Token: 0x02000042 RID: 66
    public class AppAddShiFengResquest : BaseRequest
    {
        // Token: 0x170000B2 RID: 178
        // (get) Token: 0x060001AA RID: 426 RVA: 0x0000366D File Offset: 0x0000186D
        // (set) Token: 0x060001A9 RID: 425 RVA: 0x00003664 File Offset: 0x00001864
        public new AppAddShiFeng data { get; set; }
    }
    // Token: 0x02000019 RID: 25
    public class AppCar
    {
        // Token: 0x17000038 RID: 56
        // (get) Token: 0x06000095 RID: 149 RVA: 0x00002D7D File Offset: 0x00000F7D
        // (set) Token: 0x06000096 RID: 150 RVA: 0x00002D85 File Offset: 0x00000F85
        public Guid Oid { get; set; }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x06000097 RID: 151 RVA: 0x00002D8E File Offset: 0x00000F8E
        // (set) Token: 0x06000098 RID: 152 RVA: 0x00002D96 File Offset: 0x00000F96
        public Guid CompanyOid { get; set; }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x06000099 RID: 153 RVA: 0x00002D9F File Offset: 0x00000F9F
        // (set) Token: 0x0600009A RID: 154 RVA: 0x00002DA7 File Offset: 0x00000FA7
        public string ID { get; set; }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x0600009B RID: 155 RVA: 0x00002DB0 File Offset: 0x00000FB0
        // (set) Token: 0x0600009C RID: 156 RVA: 0x00002DB8 File Offset: 0x00000FB8
        public bool EIsTransportation { get; set; }
    }
    // Token: 0x0200001C RID: 28
    public class AppCarrier
    {
        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060000AE RID: 174 RVA: 0x00002E38 File Offset: 0x00001038
        // (set) Token: 0x060000AF RID: 175 RVA: 0x00002E40 File Offset: 0x00001040
        public Guid Oid { get; set; }

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060000B0 RID: 176 RVA: 0x00002E49 File Offset: 0x00001049
        // (set) Token: 0x060000B1 RID: 177 RVA: 0x00002E51 File Offset: 0x00001051
        public Guid CompanyOid { get; set; }

        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060000B2 RID: 178 RVA: 0x00002E5A File Offset: 0x0000105A
        // (set) Token: 0x060000B3 RID: 179 RVA: 0x00002E62 File Offset: 0x00001062
        public string Name { get; set; }

        // Token: 0x17000046 RID: 70
        // (get) Token: 0x060000B4 RID: 180 RVA: 0x00002E6B File Offset: 0x0000106B
        // (set) Token: 0x060000B5 RID: 181 RVA: 0x00002E73 File Offset: 0x00001073
        public string Tell { get; set; }

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x060000B7 RID: 183 RVA: 0x00002E85 File Offset: 0x00001085
        // (set) Token: 0x060000B6 RID: 182 RVA: 0x00002E7C File Offset: 0x0000107C
        public bool Transporting { get; set; }
    }
    // Token: 0x02000025 RID: 37
    public class AppCarrierResponse : BaseResponse
    {
        // Token: 0x1700006A RID: 106
        // (get) Token: 0x06000105 RID: 261 RVA: 0x000030D8 File Offset: 0x000012D8
        // (set) Token: 0x06000104 RID: 260 RVA: 0x000030CF File Offset: 0x000012CF
        public new List<AppCarrier> data { get; set; }
    }
    // Token: 0x0200003E RID: 62
    public class AppChangePwd
    {
        // Token: 0x170000AC RID: 172
        // (get) Token: 0x0600019A RID: 410 RVA: 0x00003607 File Offset: 0x00001807
        // (set) Token: 0x06000199 RID: 409 RVA: 0x000035FE File Offset: 0x000017FE
        public string oldpwd { get; set; }

        // Token: 0x170000AD RID: 173
        // (get) Token: 0x0600019C RID: 412 RVA: 0x00003618 File Offset: 0x00001818
        // (set) Token: 0x0600019B RID: 411 RVA: 0x0000360F File Offset: 0x0000180F
        public string newpwd { get; set; }

        // Token: 0x170000AE RID: 174
        // (get) Token: 0x0600019E RID: 414 RVA: 0x00003629 File Offset: 0x00001829
        // (set) Token: 0x0600019D RID: 413 RVA: 0x00003620 File Offset: 0x00001820
        public string surepwd { get; set; }
    }
    // Token: 0x0200003F RID: 63
    public class AppChangePwdResquest : BaseRequest
    {
        // Token: 0x170000AF RID: 175
        // (get) Token: 0x060001A1 RID: 417 RVA: 0x0000363A File Offset: 0x0000183A
        // (set) Token: 0x060001A0 RID: 416 RVA: 0x00003631 File Offset: 0x00001831
        public new AppChangePwd data { get; set; }
    }
    // Token: 0x02000018 RID: 24
    public class AppEnterpriseConfiguration
    {
        // Token: 0x17000036 RID: 54
        // (get) Token: 0x06000091 RID: 145 RVA: 0x00002D64 File Offset: 0x00000F64
        // (set) Token: 0x06000090 RID: 144 RVA: 0x00002D5B File Offset: 0x00000F5B
        public bool eIsUseDestination { get; set; }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x06000093 RID: 147 RVA: 0x00002D75 File Offset: 0x00000F75
        // (set) Token: 0x06000092 RID: 146 RVA: 0x00002D6C File Offset: 0x00000F6C
        public bool eIsUseCarrier { get; set; }
    }
    // Token: 0x0200004D RID: 77
    public class AppEntryParameter
    {
        // Token: 0x170000D7 RID: 215
        // (get) Token: 0x060001FF RID: 511 RVA: 0x000038E2 File Offset: 0x00001AE2
        // (set) Token: 0x060001FE RID: 510 RVA: 0x000038D9 File Offset: 0x00001AD9
        public int count { get; set; }

        // Token: 0x170000D8 RID: 216
        // (get) Token: 0x06000201 RID: 513 RVA: 0x000038F3 File Offset: 0x00001AF3
        // (set) Token: 0x06000200 RID: 512 RVA: 0x000038EA File Offset: 0x00001AEA
        public int page { get; set; }

        // Token: 0x170000D9 RID: 217
        // (get) Token: 0x06000203 RID: 515 RVA: 0x00003904 File Offset: 0x00001B04
        // (set) Token: 0x06000202 RID: 514 RVA: 0x000038FB File Offset: 0x00001AFB
        public string licenseplatenumber { get; set; }

        // Token: 0x170000DA RID: 218
        // (get) Token: 0x06000205 RID: 517 RVA: 0x00003915 File Offset: 0x00001B15
        // (set) Token: 0x06000204 RID: 516 RVA: 0x0000390C File Offset: 0x00001B0C
        public int year { get; set; }

        // Token: 0x170000DB RID: 219
        // (get) Token: 0x06000207 RID: 519 RVA: 0x00003926 File Offset: 0x00001B26
        // (set) Token: 0x06000206 RID: 518 RVA: 0x0000391D File Offset: 0x00001B1D
        public int month { get; set; }
    }
    // Token: 0x02000050 RID: 80
    public class AppEntryParameterRequset : BaseRequest
    {
        // Token: 0x170000E0 RID: 224
        // (get) Token: 0x06000214 RID: 532 RVA: 0x0000397B File Offset: 0x00001B7B
        // (set) Token: 0x06000213 RID: 531 RVA: 0x00003972 File Offset: 0x00001B72
        public new AppEntryParameter data { get; set; }
    }
    public class AppEPCshiFeng
    {
        // Token: 0x170000B3 RID: 179
        // (get) Token: 0x060001AD RID: 429 RVA: 0x0000367E File Offset: 0x0000187E
        // (set) Token: 0x060001AC RID: 428 RVA: 0x00003675 File Offset: 0x00001875
        public Guid CompanyOid { get; set; }

        // Token: 0x170000B4 RID: 180
        // (get) Token: 0x060001AF RID: 431 RVA: 0x0000368F File Offset: 0x0000188F
        // (set) Token: 0x060001AE RID: 430 RVA: 0x00003686 File Offset: 0x00001886
        public string RFIDCode { get; set; }

        // Token: 0x170000B5 RID: 181
        // (get) Token: 0x060001B1 RID: 433 RVA: 0x000036A0 File Offset: 0x000018A0
        // (set) Token: 0x060001B0 RID: 432 RVA: 0x00003697 File Offset: 0x00001897
        public string Number { get; set; }

        // Token: 0x170000B6 RID: 182
        // (get) Token: 0x060001B3 RID: 435 RVA: 0x000036B1 File Offset: 0x000018B1
        // (set) Token: 0x060001B2 RID: 434 RVA: 0x000036A8 File Offset: 0x000018A8
        public Guid? CarOid { get; set; }

        // Token: 0x170000B7 RID: 183
        // (get) Token: 0x060001B5 RID: 437 RVA: 0x000036C2 File Offset: 0x000018C2
        // (set) Token: 0x060001B4 RID: 436 RVA: 0x000036B9 File Offset: 0x000018B9
        public string CurrentAddress { get; set; }

        // Token: 0x170000B8 RID: 184
        // (get) Token: 0x060001B7 RID: 439 RVA: 0x000036D3 File Offset: 0x000018D3
        // (set) Token: 0x060001B6 RID: 438 RVA: 0x000036CA File Offset: 0x000018CA
        public Guid? CarrierOid { get; set; }

        // Token: 0x170000B9 RID: 185
        // (get) Token: 0x060001B9 RID: 441 RVA: 0x000036E4 File Offset: 0x000018E4
        // (set) Token: 0x060001B8 RID: 440 RVA: 0x000036DB File Offset: 0x000018DB
        public decimal Longitude { get; set; }

        // Token: 0x170000BA RID: 186
        // (get) Token: 0x060001BB RID: 443 RVA: 0x000036F5 File Offset: 0x000018F5
        // (set) Token: 0x060001BA RID: 442 RVA: 0x000036EC File Offset: 0x000018EC
        public decimal Latitude { get; set; }

        // Token: 0x170000BB RID: 187
        // (get) Token: 0x060001BD RID: 445 RVA: 0x00003706 File Offset: 0x00001906
        // (set) Token: 0x060001BC RID: 444 RVA: 0x000036FD File Offset: 0x000018FD
        public Guid? SealingaddressOid { get; set; }

        // Token: 0x170000BC RID: 188
        // (get) Token: 0x060001BF RID: 447 RVA: 0x00003717 File Offset: 0x00001917
        // (set) Token: 0x060001BE RID: 446 RVA: 0x0000370E File Offset: 0x0000190E
        public string PurposeAddress { get; set; }

        // Token: 0x170000BD RID: 189
        // (get) Token: 0x060001C1 RID: 449 RVA: 0x00003728 File Offset: 0x00001928
        // (set) Token: 0x060001C0 RID: 448 RVA: 0x0000371F File Offset: 0x0000191F
        public string ImageDataStrings { get; set; }
    }
    // Token: 0x02000044 RID: 68
    public class AppEPCshiFengResquest : BaseRequest
    {
        // Token: 0x170000BE RID: 190
        // (get) Token: 0x060001C4 RID: 452 RVA: 0x00003739 File Offset: 0x00001939
        // (set) Token: 0x060001C3 RID: 451 RVA: 0x00003730 File Offset: 0x00001930
        public new AppEPCshiFeng data { get; set; }
    }
    // Token: 0x0200001D RID: 29
    public class AppInspectionInfo
    {
        // Token: 0x17000048 RID: 72
        // (get) Token: 0x060000B9 RID: 185 RVA: 0x00002E8D File Offset: 0x0000108D
        // (set) Token: 0x060000BA RID: 186 RVA: 0x00002E95 File Offset: 0x00001095
        public string Address { get; set; }

        // Token: 0x17000049 RID: 73
        // (get) Token: 0x060000BB RID: 187 RVA: 0x00002E9E File Offset: 0x0000109E
        // (set) Token: 0x060000BC RID: 188 RVA: 0x00002EA6 File Offset: 0x000010A6
        public string ImageStrings { get; set; }

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x060000BD RID: 189 RVA: 0x00002EAF File Offset: 0x000010AF
        // (set) Token: 0x060000BE RID: 190 RVA: 0x00002EB7 File Offset: 0x000010B7
        public DateTime Operator { get; set; }
    }
    // Token: 0x0200003B RID: 59
    public class AppLogin
    {
        // Token: 0x170000A8 RID: 168
        // (get) Token: 0x0600018F RID: 399 RVA: 0x000035C3 File Offset: 0x000017C3
        // (set) Token: 0x0600018E RID: 398 RVA: 0x000035BA File Offset: 0x000017BA
        public string username { get; set; }

        // Token: 0x170000A9 RID: 169
        // (get) Token: 0x06000191 RID: 401 RVA: 0x000035D4 File Offset: 0x000017D4
        // (set) Token: 0x06000190 RID: 400 RVA: 0x000035CB File Offset: 0x000017CB
        public string password { get; set; }
    }
    // Token: 0x0200003A RID: 58
    public class AppLoginRequset : BaseRequest
    {
        // Token: 0x170000A7 RID: 167
        // (get) Token: 0x0600018C RID: 396 RVA: 0x000035B2 File Offset: 0x000017B2
        // (set) Token: 0x0600018B RID: 395 RVA: 0x000035A9 File Offset: 0x000017A9
        public new AppLogin data { get; set; }
    }
    // Token: 0x02000029 RID: 41
    public class AppLogisticsBatch
    {
        // Token: 0x1700006E RID: 110
        // (get) Token: 0x06000111 RID: 273 RVA: 0x0000311C File Offset: 0x0000131C
        // (set) Token: 0x06000110 RID: 272 RVA: 0x00003113 File Offset: 0x00001313
        public string licenseplatenumber { get; set; }

        // Token: 0x1700006F RID: 111
        // (get) Token: 0x06000113 RID: 275 RVA: 0x0000312D File Offset: 0x0000132D
        // (set) Token: 0x06000112 RID: 274 RVA: 0x00003124 File Offset: 0x00001324
        public string rfid { get; set; }

        // Token: 0x17000070 RID: 112
        // (get) Token: 0x06000115 RID: 277 RVA: 0x0000313E File Offset: 0x0000133E
        // (set) Token: 0x06000114 RID: 276 RVA: 0x00003135 File Offset: 0x00001335
        public string begincompany { get; set; }

        // Token: 0x17000071 RID: 113
        // (get) Token: 0x06000117 RID: 279 RVA: 0x0000314F File Offset: 0x0000134F
        // (set) Token: 0x06000116 RID: 278 RVA: 0x00003146 File Offset: 0x00001346
        public string endcompany { get; set; }

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x06000119 RID: 281 RVA: 0x00003160 File Offset: 0x00001360
        // (set) Token: 0x06000118 RID: 280 RVA: 0x00003157 File Offset: 0x00001357
        public string beginaddress { get; set; }

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x0600011B RID: 283 RVA: 0x00003171 File Offset: 0x00001371
        // (set) Token: 0x0600011A RID: 282 RVA: 0x00003168 File Offset: 0x00001368
        public double latitude { get; set; }

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x0600011D RID: 285 RVA: 0x00003182 File Offset: 0x00001382
        // (set) Token: 0x0600011C RID: 284 RVA: 0x00003179 File Offset: 0x00001379
        public double longitude { get; set; }

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x0600011F RID: 287 RVA: 0x00003193 File Offset: 0x00001393
        // (set) Token: 0x0600011E RID: 286 RVA: 0x0000318A File Offset: 0x0000138A
        public double endLongitude { get; set; }

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x06000121 RID: 289 RVA: 0x000031A4 File Offset: 0x000013A4
        // (set) Token: 0x06000120 RID: 288 RVA: 0x0000319B File Offset: 0x0000139B
        public double endLatitude { get; set; }

        // Token: 0x17000077 RID: 119
        // (get) Token: 0x06000123 RID: 291 RVA: 0x000031B5 File Offset: 0x000013B5
        // (set) Token: 0x06000122 RID: 290 RVA: 0x000031AC File Offset: 0x000013AC
        public string endaddress { get; set; }

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x06000125 RID: 293 RVA: 0x000031C6 File Offset: 0x000013C6
        // (set) Token: 0x06000124 RID: 292 RVA: 0x000031BD File Offset: 0x000013BD
        public string aimaddress { get; set; }

        // Token: 0x17000079 RID: 121
        // (get) Token: 0x06000127 RID: 295 RVA: 0x000031D7 File Offset: 0x000013D7
        // (set) Token: 0x06000126 RID: 294 RVA: 0x000031CE File Offset: 0x000013CE
        public DateTime begintime { get; set; }

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x06000129 RID: 297 RVA: 0x000031E8 File Offset: 0x000013E8
        // (set) Token: 0x06000128 RID: 296 RVA: 0x000031DF File Offset: 0x000013DF
        public DateTime endtime { get; set; }

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x0600012B RID: 299 RVA: 0x000031F9 File Offset: 0x000013F9
        // (set) Token: 0x0600012A RID: 298 RVA: 0x000031F0 File Offset: 0x000013F0
        public string ShiFenglocation { get; set; }

        // Token: 0x1700007C RID: 124
        // (get) Token: 0x0600012D RID: 301 RVA: 0x0000320A File Offset: 0x0000140A
        // (set) Token: 0x0600012C RID: 300 RVA: 0x00003201 File Offset: 0x00001401
        public string number { get; set; }

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x0600012F RID: 303 RVA: 0x0000321B File Offset: 0x0000141B
        // (set) Token: 0x0600012E RID: 302 RVA: 0x00003212 File Offset: 0x00001412
        public string carrier { get; set; }
    }
    // Token: 0x02000045 RID: 69
    public class AppOnSiteInspection
    {
        // Token: 0x170000BF RID: 191
        // (get) Token: 0x060001C7 RID: 455 RVA: 0x0000374A File Offset: 0x0000194A
        // (set) Token: 0x060001C6 RID: 454 RVA: 0x00003741 File Offset: 0x00001941
        public Guid CompanyOid { get; set; }

        // Token: 0x170000C0 RID: 192
        // (get) Token: 0x060001C9 RID: 457 RVA: 0x0000375B File Offset: 0x0000195B
        // (set) Token: 0x060001C8 RID: 456 RVA: 0x00003752 File Offset: 0x00001952
        public string RFIDCode { get; set; }

        // Token: 0x170000C1 RID: 193
        // (get) Token: 0x060001CB RID: 459 RVA: 0x0000376C File Offset: 0x0000196C
        // (set) Token: 0x060001CA RID: 458 RVA: 0x00003763 File Offset: 0x00001963
        public string ImageDataStrings { get; set; }

        // Token: 0x170000C2 RID: 194
        // (get) Token: 0x060001CD RID: 461 RVA: 0x0000377D File Offset: 0x0000197D
        // (set) Token: 0x060001CC RID: 460 RVA: 0x00003774 File Offset: 0x00001974
        public decimal Longitude { get; set; }

        // Token: 0x170000C3 RID: 195
        // (get) Token: 0x060001CF RID: 463 RVA: 0x0000378E File Offset: 0x0000198E
        // (set) Token: 0x060001CE RID: 462 RVA: 0x00003785 File Offset: 0x00001985
        public decimal Latitude { get; set; }

        // Token: 0x170000C4 RID: 196
        // (get) Token: 0x060001D1 RID: 465 RVA: 0x0000379F File Offset: 0x0000199F
        // (set) Token: 0x060001D0 RID: 464 RVA: 0x00003796 File Offset: 0x00001996
        public string remark { get; set; }

        // Token: 0x170000C5 RID: 197
        // (get) Token: 0x060001D3 RID: 467 RVA: 0x000037B0 File Offset: 0x000019B0
        // (set) Token: 0x060001D2 RID: 466 RVA: 0x000037A7 File Offset: 0x000019A7
        public string CurrentAddress { get; set; }
    }
    // Token: 0x02000048 RID: 72
    public class AppOnSiteInspectionResquest : BaseRequest
    {
        // Token: 0x170000CC RID: 204
        // (get) Token: 0x060001E4 RID: 484 RVA: 0x00003827 File Offset: 0x00001A27
        // (set) Token: 0x060001E3 RID: 483 RVA: 0x0000381E File Offset: 0x00001A1E
        public new AppOnSiteInspection data { get; set; }
    }
    // Token: 0x02000023 RID: 35
    public class AppPersonalInfomation
    {
        // Token: 0x17000063 RID: 99
        // (get) Token: 0x060000F5 RID: 245 RVA: 0x00003061 File Offset: 0x00001261
        // (set) Token: 0x060000F4 RID: 244 RVA: 0x00003058 File Offset: 0x00001258
        public byte[] avatar { get; set; }

        // Token: 0x17000064 RID: 100
        // (get) Token: 0x060000F7 RID: 247 RVA: 0x00003072 File Offset: 0x00001272
        // (set) Token: 0x060000F6 RID: 246 RVA: 0x00003069 File Offset: 0x00001269
        public string Username { get; set; }

        // Token: 0x17000065 RID: 101
        // (get) Token: 0x060000F9 RID: 249 RVA: 0x00003083 File Offset: 0x00001283
        // (set) Token: 0x060000F8 RID: 248 RVA: 0x0000307A File Offset: 0x0000127A
        public string name { get; set; }

        // Token: 0x17000066 RID: 102
        // (get) Token: 0x060000FB RID: 251 RVA: 0x00003094 File Offset: 0x00001294
        // (set) Token: 0x060000FA RID: 250 RVA: 0x0000308B File Offset: 0x0000128B
        public string company { get; set; }

        // Token: 0x17000067 RID: 103
        // (get) Token: 0x060000FD RID: 253 RVA: 0x000030A5 File Offset: 0x000012A5
        // (set) Token: 0x060000FC RID: 252 RVA: 0x0000309C File Offset: 0x0000129C
        public string dept { get; set; }

        // Token: 0x17000068 RID: 104
        // (get) Token: 0x060000FF RID: 255 RVA: 0x000030B6 File Offset: 0x000012B6
        // (set) Token: 0x060000FE RID: 254 RVA: 0x000030AD File Offset: 0x000012AD
        public string role { get; set; }
    }

    // Token: 0x0200004E RID: 78
    public class AppQueryBatchWithParams
    {
        // Token: 0x170000DC RID: 220
        // (get) Token: 0x0600020A RID: 522 RVA: 0x00003937 File Offset: 0x00001B37
        // (set) Token: 0x06000209 RID: 521 RVA: 0x0000392E File Offset: 0x00001B2E
        public string licenseplatenumber { get; set; }

        // Token: 0x170000DD RID: 221
        // (get) Token: 0x0600020C RID: 524 RVA: 0x00003948 File Offset: 0x00001B48
        // (set) Token: 0x0600020B RID: 523 RVA: 0x0000393F File Offset: 0x00001B3F
        public int year { get; set; }

        // Token: 0x170000DE RID: 222
        // (get) Token: 0x0600020E RID: 526 RVA: 0x00003959 File Offset: 0x00001B59
        // (set) Token: 0x0600020D RID: 525 RVA: 0x00003950 File Offset: 0x00001B50
        public int month { get; set; }
    }
    // Token: 0x0200004F RID: 79
    public class AppQueryRequset : BaseRequest
    {
        // Token: 0x170000DF RID: 223
        // (get) Token: 0x06000211 RID: 529 RVA: 0x0000396A File Offset: 0x00001B6A
        // (set) Token: 0x06000210 RID: 528 RVA: 0x00003961 File Offset: 0x00001B61
        public new AppQueryBatchWithParams data { get; set; }
    }
    // Token: 0x0200002C RID: 44
    public class AppQueryWaybill
    {
        // Token: 0x17000085 RID: 133
        // (get) Token: 0x0600013E RID: 318 RVA: 0x0000333F File Offset: 0x0000153F
        // (set) Token: 0x0600013F RID: 319 RVA: 0x00003347 File Offset: 0x00001547
        public string rfid { get; set; }

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x06000140 RID: 320 RVA: 0x00003350 File Offset: 0x00001550
        // (set) Token: 0x06000141 RID: 321 RVA: 0x00003358 File Offset: 0x00001558
        public string billdiscribe { get; set; }

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x06000142 RID: 322 RVA: 0x00003361 File Offset: 0x00001561
        // (set) Token: 0x06000143 RID: 323 RVA: 0x00003369 File Offset: 0x00001569
        public byte[] waybillphoto { get; set; }
    }
    // Token: 0x0200002F RID: 47
    public class AppQueryWaybillResponse : BaseResponse
    {
        // Token: 0x17000092 RID: 146
        // (get) Token: 0x0600015A RID: 346 RVA: 0x0000343B File Offset: 0x0000163B
        // (set) Token: 0x06000159 RID: 345 RVA: 0x00003432 File Offset: 0x00001632
        public new List<AppQueryWaybill> data { get; set; }
    }
    // Token: 0x02000011 RID: 17
    public class AppResult<T> : BaseResponse
    {
        // Token: 0x17000019 RID: 25
        // (get) Token: 0x06000056 RID: 86 RVA: 0x00002AAE File Offset: 0x00000CAE
        // (set) Token: 0x06000055 RID: 85 RVA: 0x00002AA5 File Offset: 0x00000CA5
        public new T data { get; set; }
    }
    // Token: 0x02000014 RID: 20
    public class AppRFIDInfo
    {
        // Token: 0x17000023 RID: 35
        // (get) Token: 0x0600006C RID: 108 RVA: 0x00002B60 File Offset: 0x00000D60
        // (set) Token: 0x0600006B RID: 107 RVA: 0x00002B57 File Offset: 0x00000D57
        public Guid RFIDInfoOid { get; set; }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x0600006E RID: 110 RVA: 0x00002B71 File Offset: 0x00000D71
        // (set) Token: 0x0600006D RID: 109 RVA: 0x00002B68 File Offset: 0x00000D68
        public BillStatus EBillStatus { get; set; }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x06000070 RID: 112 RVA: 0x00002B82 File Offset: 0x00000D82
        // (set) Token: 0x0600006F RID: 111 RVA: 0x00002B79 File Offset: 0x00000D79
        public RecordStatus ERecordStatus { get; set; }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x06000072 RID: 114 RVA: 0x00002B93 File Offset: 0x00000D93
        // (set) Token: 0x06000071 RID: 113 RVA: 0x00002B8A File Offset: 0x00000D8A
        public string CarID { get; set; }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000074 RID: 116 RVA: 0x00002BA4 File Offset: 0x00000DA4
        // (set) Token: 0x06000073 RID: 115 RVA: 0x00002B9B File Offset: 0x00000D9B
        public string BeginAddress { get; set; }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000076 RID: 118 RVA: 0x00002BB5 File Offset: 0x00000DB5
        // (set) Token: 0x06000075 RID: 117 RVA: 0x00002BAC File Offset: 0x00000DAC
        public string EndAddress { get; set; }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x06000078 RID: 120 RVA: 0x00002BC6 File Offset: 0x00000DC6
        // (set) Token: 0x06000077 RID: 119 RVA: 0x00002BBD File Offset: 0x00000DBD
        public string PurposeAddress { get; set; }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x0600007A RID: 122 RVA: 0x00002BD7 File Offset: 0x00000DD7
        // (set) Token: 0x06000079 RID: 121 RVA: 0x00002BCE File Offset: 0x00000DCE
        public DateTime BeginDate { get; set; }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x0600007C RID: 124 RVA: 0x00002BE8 File Offset: 0x00000DE8
        // (set) Token: 0x0600007B RID: 123 RVA: 0x00002BDF File Offset: 0x00000DDF
        public DateTime EndDate { get; set; }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x0600007E RID: 126 RVA: 0x00002BF9 File Offset: 0x00000DF9
        // (set) Token: 0x0600007D RID: 125 RVA: 0x00002BF0 File Offset: 0x00000DF0
        public decimal BeginLongitude { get; set; }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x06000080 RID: 128 RVA: 0x00002C0A File Offset: 0x00000E0A
        // (set) Token: 0x0600007F RID: 127 RVA: 0x00002C01 File Offset: 0x00000E01
        public decimal BeginLatitude { get; set; }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x06000082 RID: 130 RVA: 0x00002C1B File Offset: 0x00000E1B
        // (set) Token: 0x06000081 RID: 129 RVA: 0x00002C12 File Offset: 0x00000E12
        public decimal EndLongitude { get; set; }

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000084 RID: 132 RVA: 0x00002C2C File Offset: 0x00000E2C
        // (set) Token: 0x06000083 RID: 131 RVA: 0x00002C23 File Offset: 0x00000E23
        public decimal EndLatitude { get; set; }
    }
    // Token: 0x0200001E RID: 30
    public class AppRFIDInfoImage
    {
        // Token: 0x1700004B RID: 75
        // (get) Token: 0x060000C1 RID: 193 RVA: 0x00002EC9 File Offset: 0x000010C9
        // (set) Token: 0x060000C0 RID: 192 RVA: 0x00002EC0 File Offset: 0x000010C0
        public string CarID { get; set; }

        // Token: 0x1700004C RID: 76
        // (get) Token: 0x060000C3 RID: 195 RVA: 0x00002EDA File Offset: 0x000010DA
        // (set) Token: 0x060000C2 RID: 194 RVA: 0x00002ED1 File Offset: 0x000010D1
        public string BeginAddress { get; set; }

        // Token: 0x1700004D RID: 77
        // (get) Token: 0x060000C5 RID: 197 RVA: 0x00002EEB File Offset: 0x000010EB
        // (set) Token: 0x060000C4 RID: 196 RVA: 0x00002EE2 File Offset: 0x000010E2
        public string PurposeAddress { get; set; }

        // Token: 0x1700004E RID: 78
        // (get) Token: 0x060000C7 RID: 199 RVA: 0x00002EFC File Offset: 0x000010FC
        // (set) Token: 0x060000C6 RID: 198 RVA: 0x00002EF3 File Offset: 0x000010F3
        public DateTime SaelingDate { get; set; }

        // Token: 0x1700004F RID: 79
        // (get) Token: 0x060000C9 RID: 201 RVA: 0x00002F0D File Offset: 0x0000110D
        // (set) Token: 0x060000C8 RID: 200 RVA: 0x00002F04 File Offset: 0x00001104
        public string SealingImageStrings { get; set; }

        // Token: 0x17000050 RID: 80
        // (get) Token: 0x060000CB RID: 203 RVA: 0x00002F1E File Offset: 0x0000111E
        // (set) Token: 0x060000CA RID: 202 RVA: 0x00002F15 File Offset: 0x00001115
        public DateTime UnpackingDate { get; set; }

        // Token: 0x17000051 RID: 81
        // (get) Token: 0x060000CD RID: 205 RVA: 0x00002F2F File Offset: 0x0000112F
        // (set) Token: 0x060000CC RID: 204 RVA: 0x00002F26 File Offset: 0x00001126
        public string UnpackingImageStrings { get; set; }

        // Token: 0x17000052 RID: 82
        // (get) Token: 0x060000CF RID: 207 RVA: 0x00002F40 File Offset: 0x00001140
        // (set) Token: 0x060000CE RID: 206 RVA: 0x00002F37 File Offset: 0x00001137
        public string SealingAddress { get; set; }

        // Token: 0x17000053 RID: 83
        // (get) Token: 0x060000D1 RID: 209 RVA: 0x00002F51 File Offset: 0x00001151
        // (set) Token: 0x060000D0 RID: 208 RVA: 0x00002F48 File Offset: 0x00001148
        public List<AppInspectionInfo> Inspectiopns { get; set; }
    }
    // Token: 0x02000020 RID: 32
    public class AppRFIDVerification
    {
        // Token: 0x17000054 RID: 84
        // (get) Token: 0x060000D4 RID: 212 RVA: 0x00002F62 File Offset: 0x00001162
        // (set) Token: 0x060000D3 RID: 211 RVA: 0x00002F59 File Offset: 0x00001159
        public bool IsExit { get; set; }

        // Token: 0x17000055 RID: 85
        // (get) Token: 0x060000D6 RID: 214 RVA: 0x00002F73 File Offset: 0x00001173
        // (set) Token: 0x060000D5 RID: 213 RVA: 0x00002F6A File Offset: 0x0000116A
        public bool EBillStatus { get; set; }

        // Token: 0x17000056 RID: 86
        // (get) Token: 0x060000D8 RID: 216 RVA: 0x00002F84 File Offset: 0x00001184
        // (set) Token: 0x060000D7 RID: 215 RVA: 0x00002F7B File Offset: 0x0000117B
        public RecordStatus ERecordStatus { get; set; }

        // Token: 0x17000057 RID: 87
        // (get) Token: 0x060000DA RID: 218 RVA: 0x00002F95 File Offset: 0x00001195
        // (set) Token: 0x060000D9 RID: 217 RVA: 0x00002F8C File Offset: 0x0000118C
        public string CarID { get; set; }

        // Token: 0x17000058 RID: 88
        // (get) Token: 0x060000DC RID: 220 RVA: 0x00002FA6 File Offset: 0x000011A6
        // (set) Token: 0x060000DB RID: 219 RVA: 0x00002F9D File Offset: 0x0000119D
        public string SealingAddress { get; set; }

        // Token: 0x17000059 RID: 89
        // (get) Token: 0x060000DE RID: 222 RVA: 0x00002FB7 File Offset: 0x000011B7
        // (set) Token: 0x060000DD RID: 221 RVA: 0x00002FAE File Offset: 0x000011AE
        public string BeginAddress { get; set; }

        // Token: 0x1700005A RID: 90
        // (get) Token: 0x060000E0 RID: 224 RVA: 0x00002FC8 File Offset: 0x000011C8
        // (set) Token: 0x060000DF RID: 223 RVA: 0x00002FBF File Offset: 0x000011BF
        public string PurposeAddress { get; set; }

        // Token: 0x1700005B RID: 91
        // (get) Token: 0x060000E2 RID: 226 RVA: 0x00002FD9 File Offset: 0x000011D9
        // (set) Token: 0x060000E1 RID: 225 RVA: 0x00002FD0 File Offset: 0x000011D0
        public string CarrierName { get; set; }

        // Token: 0x1700005C RID: 92
        // (get) Token: 0x060000E4 RID: 228 RVA: 0x00002FEA File Offset: 0x000011EA
        // (set) Token: 0x060000E3 RID: 227 RVA: 0x00002FE1 File Offset: 0x000011E1
        public string Number { get; set; }

        // Token: 0x1700005D RID: 93
        // (get) Token: 0x060000E6 RID: 230 RVA: 0x00002FFB File Offset: 0x000011FB
        // (set) Token: 0x060000E5 RID: 229 RVA: 0x00002FF2 File Offset: 0x000011F2
        public string RFIDCode { get; set; }

        // Token: 0x1700005E RID: 94
        // (get) Token: 0x060000E8 RID: 232 RVA: 0x0000300C File Offset: 0x0000120C
        // (set) Token: 0x060000E7 RID: 231 RVA: 0x00003003 File Offset: 0x00001203
        public DateTime BeginDate { get; set; }

        // Token: 0x1700005F RID: 95
        // (get) Token: 0x060000EA RID: 234 RVA: 0x0000301D File Offset: 0x0000121D
        // (set) Token: 0x060000E9 RID: 233 RVA: 0x00003014 File Offset: 0x00001214
        public DateTime EndDate { get; set; }

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x060000EC RID: 236 RVA: 0x0000302E File Offset: 0x0000122E
        // (set) Token: 0x060000EB RID: 235 RVA: 0x00003025 File Offset: 0x00001225
        public string EndAddress { get; set; }
    }
    // Token: 0x02000013 RID: 19
    public enum AppRoleType
    {
        // Token: 0x0400003B RID: 59
        施封,
        // Token: 0x0400003C RID: 60
        巡检,
        // Token: 0x0400003D RID: 61
        拆封
    }
    // Token: 0x02000049 RID: 73
    public class AppScarpEPC
    {
        // Token: 0x170000CD RID: 205
        // (get) Token: 0x060001E7 RID: 487 RVA: 0x00003838 File Offset: 0x00001A38
        // (set) Token: 0x060001E6 RID: 486 RVA: 0x0000382F File Offset: 0x00001A2F
        public string rfid { get; set; }
    }
    // Token: 0x0200004A RID: 74
    public class AppScarpEPCRequest : BaseRequest
    {
        // Token: 0x170000CE RID: 206
        // (get) Token: 0x060001EA RID: 490 RVA: 0x00003849 File Offset: 0x00001A49
        // (set) Token: 0x060001E9 RID: 489 RVA: 0x00003840 File Offset: 0x00001A40
        public new AppScarpEPC data { get; set; }
    }
    // Token: 0x0200001A RID: 26
    public class AppSealingaddress
    {
        // Token: 0x1700003C RID: 60
        // (get) Token: 0x0600009E RID: 158 RVA: 0x00002DC1 File Offset: 0x00000FC1
        // (set) Token: 0x0600009F RID: 159 RVA: 0x00002DC9 File Offset: 0x00000FC9
        public Guid Oid { get; set; }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060000A0 RID: 160 RVA: 0x00002DD2 File Offset: 0x00000FD2
        // (set) Token: 0x060000A1 RID: 161 RVA: 0x00002DDA File Offset: 0x00000FDA
        public Guid CompanyOid { get; set; }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060000A2 RID: 162 RVA: 0x00002DE3 File Offset: 0x00000FE3
        // (set) Token: 0x060000A3 RID: 163 RVA: 0x00002DEB File Offset: 0x00000FEB
        public string Name { get; set; }
    }
    // Token: 0x02000039 RID: 57
    public class AppSenderCarInfo
    {
        // Token: 0x170000A5 RID: 165
        // (get) Token: 0x06000187 RID: 391 RVA: 0x00003590 File Offset: 0x00001790
        // (set) Token: 0x06000186 RID: 390 RVA: 0x00003587 File Offset: 0x00001787
        public Guid CompanyOid { get; set; }

        // Token: 0x170000A6 RID: 166
        // (get) Token: 0x06000189 RID: 393 RVA: 0x000035A1 File Offset: 0x000017A1
        // (set) Token: 0x06000188 RID: 392 RVA: 0x00003598 File Offset: 0x00001798
        public Guid CarOid { get; set; }
    }
    // Token: 0x02000036 RID: 54
    public class AppSenderDataCollect
    {
        // Token: 0x170000A1 RID: 161
        // (get) Token: 0x0600017C RID: 380 RVA: 0x0000354C File Offset: 0x0000174C
        // (set) Token: 0x0600017B RID: 379 RVA: 0x00003543 File Offset: 0x00001743
        public Guid CompanyOid { get; set; }
    }
    // Token: 0x02000038 RID: 56
    public class AppSenderRFID
    {
        // Token: 0x170000A3 RID: 163
        // (get) Token: 0x06000182 RID: 386 RVA: 0x0000356E File Offset: 0x0000176E
        // (set) Token: 0x06000181 RID: 385 RVA: 0x00003565 File Offset: 0x00001765
        public Guid CompanyOid { get; set; }

        // Token: 0x170000A4 RID: 164
        // (get) Token: 0x06000184 RID: 388 RVA: 0x0000357F File Offset: 0x0000177F
        // (set) Token: 0x06000183 RID: 387 RVA: 0x00003576 File Offset: 0x00001776
        public string RFIDCode { get; set; }
    }
    public class AppSenderRFIDInfo
    {
        // Token: 0x170000A2 RID: 162
        // (get) Token: 0x0600017F RID: 383 RVA: 0x0000355D File Offset: 0x0000175D
        // (set) Token: 0x0600017E RID: 382 RVA: 0x00003554 File Offset: 0x00001754
        public Guid RFIDInfoOid { get; set; }
    }
    // Token: 0x02000035 RID: 53
    public class AppSenderSearch
    {
        // Token: 0x1700009D RID: 157
        // (get) Token: 0x06000173 RID: 371 RVA: 0x00003508 File Offset: 0x00001708
        // (set) Token: 0x06000172 RID: 370 RVA: 0x000034FF File Offset: 0x000016FF
        public Guid CompanyOid { get; set; }

        // Token: 0x1700009E RID: 158
        // (get) Token: 0x06000175 RID: 373 RVA: 0x00003519 File Offset: 0x00001719
        // (set) Token: 0x06000174 RID: 372 RVA: 0x00003510 File Offset: 0x00001710
        public Guid? CarOid { get; set; }

        // Token: 0x1700009F RID: 159
        // (get) Token: 0x06000177 RID: 375 RVA: 0x0000352A File Offset: 0x0000172A
        // (set) Token: 0x06000176 RID: 374 RVA: 0x00003521 File Offset: 0x00001721
        public int SearchYear { get; set; }

        // Token: 0x170000A0 RID: 160
        // (get) Token: 0x06000179 RID: 377 RVA: 0x0000353B File Offset: 0x0000173B
        // (set) Token: 0x06000178 RID: 376 RVA: 0x00003532 File Offset: 0x00001732
        public int SearchMonth { get; set; }
    }
    // Token: 0x02000034 RID: 52
    public class AppSender<T> : BaseRequest
    {
        // Token: 0x17000099 RID: 153
        // (get) Token: 0x0600016D RID: 365 RVA: 0x000034B2 File Offset: 0x000016B2
        // (set) Token: 0x0600016C RID: 364 RVA: 0x000034A9 File Offset: 0x000016A9
        public new T data { get; set; }

        // Token: 0x1700009A RID: 154
        // (get) Token: 0x0600016E RID: 366 RVA: 0x000034BA File Offset: 0x000016BA
        public new string username
        {
            get
            {
                return Preferences.Get("username", "");
            }
        }

        // Token: 0x1700009B RID: 155
        // (get) Token: 0x0600016F RID: 367 RVA: 0x000034CB File Offset: 0x000016CB
        public Guid UserOid
        {
            get
            {
                return BasicData.User.UserOid;
            }
        }

        // Token: 0x1700009C RID: 156
        // (get) Token: 0x06000170 RID: 368 RVA: 0x000034D8 File Offset: 0x000016D8
        public new string senddate
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }
    }

    // Token: 0x0200002E RID: 46
    public class AppShiFengData
    {
        // Token: 0x1700008E RID: 142
        // (get) Token: 0x06000150 RID: 336 RVA: 0x000033EE File Offset: 0x000015EE
        // (set) Token: 0x06000151 RID: 337 RVA: 0x000033F6 File Offset: 0x000015F6
        public string rfid { get; set; }

        // Token: 0x1700008F RID: 143
        // (get) Token: 0x06000152 RID: 338 RVA: 0x000033FF File Offset: 0x000015FF
        // (set) Token: 0x06000153 RID: 339 RVA: 0x00003407 File Offset: 0x00001607
        public string licenseplatenumber { get; set; }

        // Token: 0x17000090 RID: 144
        // (get) Token: 0x06000154 RID: 340 RVA: 0x00003410 File Offset: 0x00001610
        // (set) Token: 0x06000155 RID: 341 RVA: 0x00003418 File Offset: 0x00001618
        public string ShiFenglocation { get; set; }

        // Token: 0x17000091 RID: 145
        // (get) Token: 0x06000156 RID: 342 RVA: 0x00003421 File Offset: 0x00001621
        // (set) Token: 0x06000157 RID: 343 RVA: 0x00003429 File Offset: 0x00001629
        public List<AppShiFengImage> shiFengImage { get; set; }
    }
    // Token: 0x02000030 RID: 48
    public class AppShiFengDataResponse : BaseResponse
    {
        // Token: 0x17000093 RID: 147
        // (get) Token: 0x0600015D RID: 349 RVA: 0x0000344C File Offset: 0x0000164C
        // (set) Token: 0x0600015C RID: 348 RVA: 0x00003443 File Offset: 0x00001643
        public new AppShiFengData data { get; set; }
    }
    public class AppShiFengImage
    {
        // Token: 0x17000088 RID: 136
        // (get) Token: 0x06000145 RID: 325 RVA: 0x00003372 File Offset: 0x00001572
        // (set) Token: 0x06000146 RID: 326 RVA: 0x0000337A File Offset: 0x0000157A
        public string operate { get; set; }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x06000147 RID: 327 RVA: 0x00003383 File Offset: 0x00001583
        // (set) Token: 0x06000148 RID: 328 RVA: 0x0000338B File Offset: 0x0000158B
        public DateTime time { get; set; }

        // Token: 0x1700008A RID: 138
        // (get) Token: 0x06000149 RID: 329 RVA: 0x00003394 File Offset: 0x00001594
        // (set) Token: 0x0600014A RID: 330 RVA: 0x0000339C File Offset: 0x0000159C
        public string photo { get; set; }

        // Token: 0x1700008B RID: 139
        // (get) Token: 0x0600014B RID: 331 RVA: 0x000033A5 File Offset: 0x000015A5
        public string TimeTitle
        {
            get
            {
                return this.operate + "时间";
            }
        }

        // Token: 0x1700008C RID: 140
        // (get) Token: 0x0600014C RID: 332 RVA: 0x000033B7 File Offset: 0x000015B7
        public string PhotoTitle
        {
            get
            {
                return this.operate + "照片";
            }
        }

        // Token: 0x1700008D RID: 141
        // (get) Token: 0x0600014D RID: 333 RVA: 0x000033C9 File Offset: 0x000015C9
        public ImageSource PhotoSource
        {
            get
            {
                return ImageSource.FromStream(() => new System.IO.MemoryStream(Convert.FromBase64String(this.photo)));
            }
        }
    }
    public class AppShiFengResponse : BaseResponse
    {
        // Token: 0x17000069 RID: 105
        // (get) Token: 0x06000102 RID: 258 RVA: 0x000030C7 File Offset: 0x000012C7
        // (set) Token: 0x06000101 RID: 257 RVA: 0x000030BE File Offset: 0x000012BE
        public new List<AppAddShiFeng> data { get; set; }
    }
    public class AppUnseal
    {
        // Token: 0x170000C6 RID: 198
        // (get) Token: 0x060001D6 RID: 470 RVA: 0x000037C1 File Offset: 0x000019C1
        // (set) Token: 0x060001D5 RID: 469 RVA: 0x000037B8 File Offset: 0x000019B8
        public string rfid { get; set; }

        // Token: 0x170000C7 RID: 199
        // (get) Token: 0x060001D8 RID: 472 RVA: 0x000037D2 File Offset: 0x000019D2
        // (set) Token: 0x060001D7 RID: 471 RVA: 0x000037C9 File Offset: 0x000019C9
        public string currentaddress { get; set; }

        // Token: 0x170000C8 RID: 200
        // (get) Token: 0x060001DA RID: 474 RVA: 0x000037E3 File Offset: 0x000019E3
        // (set) Token: 0x060001D9 RID: 473 RVA: 0x000037DA File Offset: 0x000019DA
        public byte[] photo { get; set; }

        // Token: 0x170000C9 RID: 201
        // (get) Token: 0x060001DC RID: 476 RVA: 0x000037F4 File Offset: 0x000019F4
        // (set) Token: 0x060001DB RID: 475 RVA: 0x000037EB File Offset: 0x000019EB
        public double endLongitude { get; set; }

        // Token: 0x170000CA RID: 202
        // (get) Token: 0x060001DE RID: 478 RVA: 0x00003805 File Offset: 0x00001A05
        // (set) Token: 0x060001DD RID: 477 RVA: 0x000037FC File Offset: 0x000019FC
        public double endLatitude { get; set; }
    }
    // Token: 0x02000047 RID: 71
    public class AppUnsealResquest : BaseRequest
    {
        // Token: 0x170000CB RID: 203
        // (get) Token: 0x060001E1 RID: 481 RVA: 0x00003816 File Offset: 0x00001A16
        // (set) Token: 0x060001E0 RID: 480 RVA: 0x0000380D File Offset: 0x00001A0D
        public new AppUnseal data { get; set; }
    }
    // Token: 0x02000012 RID: 18
    public class AppUser
    {
        // Token: 0x1700001A RID: 26
        // (get) Token: 0x06000059 RID: 89 RVA: 0x00002AC7 File Offset: 0x00000CC7
        // (set) Token: 0x06000058 RID: 88 RVA: 0x00002ABE File Offset: 0x00000CBE
        public string AppImageData { get; set; }

        // Token: 0x1700001B RID: 27
        // (get) Token: 0x0600005B RID: 91 RVA: 0x00002AD8 File Offset: 0x00000CD8
        // (set) Token: 0x0600005A RID: 90 RVA: 0x00002ACF File Offset: 0x00000CCF
        public string CompanyName { get; set; }

        // Token: 0x1700001C RID: 28
        // (get) Token: 0x0600005D RID: 93 RVA: 0x00002AE9 File Offset: 0x00000CE9
        // (set) Token: 0x0600005C RID: 92 RVA: 0x00002AE0 File Offset: 0x00000CE0
        public Guid CompanyOid { get; set; }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x0600005F RID: 95 RVA: 0x00002AFA File Offset: 0x00000CFA
        // (set) Token: 0x0600005E RID: 94 RVA: 0x00002AF1 File Offset: 0x00000CF1
        public string DeptName { get; set; }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000061 RID: 97 RVA: 0x00002B0B File Offset: 0x00000D0B
        // (set) Token: 0x06000060 RID: 96 RVA: 0x00002B02 File Offset: 0x00000D02
        public string RoleName { get; set; }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000063 RID: 99 RVA: 0x00002B1C File Offset: 0x00000D1C
        // (set) Token: 0x06000062 RID: 98 RVA: 0x00002B13 File Offset: 0x00000D13
        public Guid UserOid { get; set; }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000065 RID: 101 RVA: 0x00002B2D File Offset: 0x00000D2D
        // (set) Token: 0x06000064 RID: 100 RVA: 0x00002B24 File Offset: 0x00000D24
        public string Name { get; set; }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x06000067 RID: 103 RVA: 0x00002B3E File Offset: 0x00000D3E
        // (set) Token: 0x06000066 RID: 102 RVA: 0x00002B35 File Offset: 0x00000D35
        public string ImageData { get; set; }

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x06000069 RID: 105 RVA: 0x00002B4F File Offset: 0x00000D4F
        // (set) Token: 0x06000068 RID: 104 RVA: 0x00002B46 File Offset: 0x00000D46
        public AppRoleType[] AppRoles { get; set; }
    }
    // Token: 0x0200003C RID: 60
    public class AppVehicle
    {
        // Token: 0x170000AA RID: 170
        // (get) Token: 0x06000194 RID: 404 RVA: 0x000035E5 File Offset: 0x000017E5
        // (set) Token: 0x06000193 RID: 403 RVA: 0x000035DC File Offset: 0x000017DC
        public string licenseplatenumber { get; set; }
    }
    // Token: 0x0200001B RID: 27
    public class AppWayBill
    {
        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060000A5 RID: 165 RVA: 0x00002DF4 File Offset: 0x00000FF4
        // (set) Token: 0x060000A6 RID: 166 RVA: 0x00002DFC File Offset: 0x00000FFC
        public Guid CompanyOid { get; set; }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060000A7 RID: 167 RVA: 0x00002E05 File Offset: 0x00001005
        // (set) Token: 0x060000A8 RID: 168 RVA: 0x00002E0D File Offset: 0x0000100D
        public string RFIDCode { get; set; }

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060000A9 RID: 169 RVA: 0x00002E16 File Offset: 0x00001016
        // (set) Token: 0x060000AA RID: 170 RVA: 0x00002E1E File Offset: 0x0000101E
        public string Description { get; set; }

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060000AB RID: 171 RVA: 0x00002E27 File Offset: 0x00001027
        // (set) Token: 0x060000AC RID: 172 RVA: 0x00002E2F File Offset: 0x0000102F
        public string ImageDataStrings { get; set; }
    }
    public class BaseRequest
    {
        // Token: 0x17000096 RID: 150
        // (get) Token: 0x06000166 RID: 358 RVA: 0x0000347F File Offset: 0x0000167F
        // (set) Token: 0x06000165 RID: 357 RVA: 0x00003476 File Offset: 0x00001676
        public string username { get; set; }

        // Token: 0x17000097 RID: 151
        // (get) Token: 0x06000168 RID: 360 RVA: 0x00003490 File Offset: 0x00001690
        // (set) Token: 0x06000167 RID: 359 RVA: 0x00003487 File Offset: 0x00001687
        public DateTime senddate { get; set; }

        // Token: 0x17000098 RID: 152
        // (get) Token: 0x0600016A RID: 362 RVA: 0x000034A1 File Offset: 0x000016A1
        // (set) Token: 0x06000169 RID: 361 RVA: 0x00003498 File Offset: 0x00001698
        public string data { get; set; }
    }
    // Token: 0x02000010 RID: 16
    public class BaseResponse
    {
        // Token: 0x17000016 RID: 22
        // (get) Token: 0x0600004F RID: 79 RVA: 0x00002A7B File Offset: 0x00000C7B
        // (set) Token: 0x0600004E RID: 78 RVA: 0x00002A72 File Offset: 0x00000C72
        public string msg { get; set; }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x06000051 RID: 81 RVA: 0x00002A8C File Offset: 0x00000C8C
        // (set) Token: 0x06000050 RID: 80 RVA: 0x00002A83 File Offset: 0x00000C83
        public string data { get; set; }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000053 RID: 83 RVA: 0x00002A9D File Offset: 0x00000C9D
        // (set) Token: 0x06000052 RID: 82 RVA: 0x00002A94 File Offset: 0x00000C94
        public bool successed { get; set; }
    }
    // Token: 0x0200000F RID: 15
    public class BasicData
    {
        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000037 RID: 55 RVA: 0x000028C3 File Offset: 0x00000AC3
        // (set) Token: 0x06000036 RID: 54 RVA: 0x000028BB File Offset: 0x00000ABB
        public static bool CanUhf { get; set; }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000039 RID: 57 RVA: 0x000028D2 File Offset: 0x00000AD2
        // (set) Token: 0x06000038 RID: 56 RVA: 0x000028CA File Offset: 0x00000ACA
        public static int Power { get; set; }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x0600003B RID: 59 RVA: 0x000028E1 File Offset: 0x00000AE1
        // (set) Token: 0x0600003A RID: 58 RVA: 0x000028D9 File Offset: 0x00000AD9
        public static AppPersonalInfomation PersonalInfomation { get; set; }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x0600003D RID: 61 RVA: 0x000028F0 File Offset: 0x00000AF0
        // (set) Token: 0x0600003C RID: 60 RVA: 0x000028E8 File Offset: 0x00000AE8
        public static AppUser User { get; set; }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x0600003F RID: 63 RVA: 0x000028FF File Offset: 0x00000AFF
        // (set) Token: 0x0600003E RID: 62 RVA: 0x000028F7 File Offset: 0x00000AF7
        public static AppEnterpriseConfiguration AppConfiguration { get; set; }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000041 RID: 65 RVA: 0x0000290E File Offset: 0x00000B0E
        // (set) Token: 0x06000040 RID: 64 RVA: 0x00002906 File Offset: 0x00000B06
        public static string BaseUrl { get; set; } = "http://www.zcrfid.com/API/";

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000043 RID: 67 RVA: 0x0000291D File Offset: 0x00000B1D
        // (set) Token: 0x06000042 RID: 66 RVA: 0x00002915 File Offset: 0x00000B15
        public static string Apiaddress { get; set; }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000044 RID: 68 RVA: 0x00002924 File Offset: 0x00000B24
        public static string UserOid
        {
            get
            {
                return Preferences.Get("userOid", "");
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000045 RID: 69 RVA: 0x00002935 File Offset: 0x00000B35
        public static string CompanyOid
        {
            get
            {
                return Preferences.Get("companyOid", "");
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x06000046 RID: 70 RVA: 0x00002946 File Offset: 0x00000B46
        public string MacAddress
        {
            get
            {
                return this.GetMacAddress();
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x06000047 RID: 71 RVA: 0x0000294E File Offset: 0x00000B4E
        // (set) Token: 0x06000048 RID: 72 RVA: 0x00002955 File Offset: 0x00000B55
        public static ScanMode NowScanMode { get; set; }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x06000049 RID: 73 RVA: 0x0000295D File Offset: 0x00000B5D
        // (set) Token: 0x0600004A RID: 74 RVA: 0x00002964 File Offset: 0x00000B64
        public static Operation NowOperation { get; set; }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x0600004B RID: 75 RVA: 0x0000296C File Offset: 0x00000B6C
        public static bool NowOutline
        {
            get
            {
                return Preferences.Get("NowOutline", false);
            }
        }

        // Token: 0x0600004C RID: 76 RVA: 0x0000297C File Offset: 0x00000B7C
        private string GetMacAddress()
        {
            System.Collections.IList list = Collections.List(NetworkInterface.NetworkInterfaces);
            string result = "";
            foreach (object obj in list)
            {
                byte[] hardwareAddress = (obj as NetworkInterface).GetHardwareAddress();
                if (hardwareAddress != null)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (byte b in hardwareAddress)
                    {
                        stringBuilder.Append(((int)(b & byte.MaxValue)).ToString("X2") + ":");
                    }
                    result = stringBuilder.ToString().Remove(stringBuilder.Length() - 1);
                }
            }
            return result;
        }

        // Token: 0x04000023 RID: 35
        public static string FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "shifeng.txt");
    }
    // Token: 0x02000016 RID: 22
    public enum BillStatus
    {
        // Token: 0x0400004F RID: 79
        运输中,
        // Token: 0x04000050 RID: 80
        已完成
    }

    // Token: 0x0200000D RID: 13
    public enum DriverMode
    {
        // Token: 0x04000020 RID: 32
        New,
        // Token: 0x04000021 RID: 33
        OnDrivery,
        // Token: 0x04000022 RID: 34
        Error
    }
    // Token: 0x0200000A RID: 10
    public enum InventoryMode
    {
        // Token: 0x04000013 RID: 19
        SingleTag,
        // Token: 0x04000014 RID: 20
        SingleStep,
        // Token: 0x04000015 RID: 21
        AntiCollision,
        // Token: 0x04000016 RID: 22
        Custom
    }
    // Token: 0x0200002A RID: 42
    public class MyAppLogisticsBatch : AppLogisticsBatch
    {
        // Token: 0x1700007E RID: 126
        // (get) Token: 0x06000131 RID: 305 RVA: 0x00003224 File Offset: 0x00001424
        public string DateDay
        {
            get
            {
                return base.begintime.Month + "/" + base.begintime.Day;
            }
        }

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x06000132 RID: 306 RVA: 0x00003261 File Offset: 0x00001461
        public bool HasWayBill
        {
            get
            {
                return !string.IsNullOrEmpty(base.endaddress);
            }
        }

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x06000133 RID: 307 RVA: 0x00003274 File Offset: 0x00001474
        public string Detail
        {
            get
            {
                return string.Concat(new string[]
                {
                    "目的地址: ",
                    base.aimaddress,
                    "\n起始时间: ",
                    base.begintime.ToString(),
                    "\n起始地址: ",
                    base.beginaddress,
                    "\n结束时间: ",
                    base.endtime.ToString(),
                    "\n结束地址: ",
                    base.endaddress
                });
            }
        }

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x06000135 RID: 309 RVA: 0x000032FC File Offset: 0x000014FC
        // (set) Token: 0x06000134 RID: 308 RVA: 0x000032F3 File Offset: 0x000014F3
        public DelegateCommand<string> LocationCommand { get; set; }

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x06000137 RID: 311 RVA: 0x0000330D File Offset: 0x0000150D
        // (set) Token: 0x06000136 RID: 310 RVA: 0x00003304 File Offset: 0x00001504
        public DelegateCommand<string> WayBillCommand { get; set; }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x06000139 RID: 313 RVA: 0x0000331E File Offset: 0x0000151E
        // (set) Token: 0x06000138 RID: 312 RVA: 0x00003315 File Offset: 0x00001515
        public DelegateCommand<MyAppLogisticsBatch> MapCommand { get; set; }
    }

    // Token: 0x0200000C RID: 12
    public enum Operation
    {
        // Token: 0x0400001C RID: 28
        Read,
        // Token: 0x0400001D RID: 29
        Delete,
        // Token: 0x0400001E RID: 30
        Upload
    }

    // Token: 0x02000032 RID: 50
    public class OutLineRequest
    {
        // Token: 0x17000094 RID: 148
        // (get) Token: 0x06000161 RID: 353 RVA: 0x0000345D File Offset: 0x0000165D
        // (set) Token: 0x06000160 RID: 352 RVA: 0x00003454 File Offset: 0x00001654
        public BaseRequest Request { get; set; }

        // Token: 0x17000095 RID: 149
        // (get) Token: 0x06000163 RID: 355 RVA: 0x0000346E File Offset: 0x0000166E
        // (set) Token: 0x06000162 RID: 354 RVA: 0x00003465 File Offset: 0x00001665
        public string Route { get; set; }
    }
    // Token: 0x02000022 RID: 34
    public class PersonalResponse : BaseResponse
    {
        // Token: 0x17000062 RID: 98
        // (get) Token: 0x060000F2 RID: 242 RVA: 0x00003050 File Offset: 0x00001250
        // (set) Token: 0x060000F1 RID: 241 RVA: 0x00003047 File Offset: 0x00001247
        public new AppPersonalInfomation data { get; set; }
    }
    // Token: 0x02000027 RID: 39
    public class QueryScarpEPCResponse : BaseResponse
    {
        // Token: 0x1700006C RID: 108
        // (get) Token: 0x0600010B RID: 267 RVA: 0x000030FA File Offset: 0x000012FA
        // (set) Token: 0x0600010A RID: 266 RVA: 0x000030F1 File Offset: 0x000012F1
        public new AppLogisticsBatch data { get; set; }
    }
    // Token: 0x02000026 RID: 38
    public class QueryWaybillResponse : BaseResponse
    {
        // Token: 0x1700006B RID: 107
        // (get) Token: 0x06000108 RID: 264 RVA: 0x000030E9 File Offset: 0x000012E9
        // (set) Token: 0x06000107 RID: 263 RVA: 0x000030E0 File Offset: 0x000012E0
        public new AppLogisticsBatch data { get; set; }
    }
    // Token: 0x02000028 RID: 40
    public class ReadEPCResponse : BaseResponse
    {
        // Token: 0x1700006D RID: 109
        // (get) Token: 0x0600010E RID: 270 RVA: 0x0000310B File Offset: 0x0000130B
        // (set) Token: 0x0600010D RID: 269 RVA: 0x00003102 File Offset: 0x00001302
        public new AppLogisticsBatch data { get; set; }
    }
    // Token: 0x0200001F RID: 31
    public enum RecordStatus
    {
        // Token: 0x04000073 RID: 115
        施封成功,
        // Token: 0x04000074 RID: 116
        巡检成功,
        // Token: 0x04000075 RID: 117
        巡检失败,
        // Token: 0x04000076 RID: 118
        拆封成功,
        // Token: 0x04000077 RID: 119
        拆封失败,
        // Token: 0x04000078 RID: 120
        铅封报废
    }
    // Token: 0x02000015 RID: 21
    public class RFidInfo : AppRFIDInfo
    {
        // Token: 0x17000030 RID: 48
        // (get) Token: 0x06000086 RID: 134 RVA: 0x00002C34 File Offset: 0x00000E34
        public string DateDay
        {
            get
            {
                return base.BeginDate.Month + "/" + base.BeginDate.Day;
            }
        }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x06000087 RID: 135 RVA: 0x00002C71 File Offset: 0x00000E71
        public bool HasWayBill
        {
            get
            {
                return !string.IsNullOrEmpty(base.EndAddress);
            }
        }

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x06000088 RID: 136 RVA: 0x00002C84 File Offset: 0x00000E84
        public string Detail
        {
            get
            {
                return string.Concat(new string[]
                {
                    "目的地址: ",
                    base.PurposeAddress,
                    "\n起始时间: ",
                    base.BeginDate.ToString(),
                    "\n起始地址: ",
                    base.BeginAddress,
                    base.EBillStatus.Equals(BillStatus.已完成) ? ("\n结束时间: " + base.EndDate.ToString() + "\n结束地址: " + base.EndAddress) : string.Empty
                });
            }
        }

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x0600008A RID: 138 RVA: 0x00002D29 File Offset: 0x00000F29
        // (set) Token: 0x06000089 RID: 137 RVA: 0x00002D20 File Offset: 0x00000F20
        public DelegateCommand<Guid?> LocationCommand { get; set; }

        // Token: 0x17000034 RID: 52
        // (get) Token: 0x0600008C RID: 140 RVA: 0x00002D3A File Offset: 0x00000F3A
        // (set) Token: 0x0600008B RID: 139 RVA: 0x00002D31 File Offset: 0x00000F31
        public DelegateCommand<Guid?> WayBillCommand { get; set; }

        // Token: 0x17000035 RID: 53
        // (get) Token: 0x0600008E RID: 142 RVA: 0x00002D4B File Offset: 0x00000F4B
        // (set) Token: 0x0600008D RID: 141 RVA: 0x00002D42 File Offset: 0x00000F42
        public DelegateCommand<RFidInfo> MapCommand { get; set; }
    }

    public enum ScanMode
    {
        // Token: 0x04000018 RID: 24
        UHF,
        // Token: 0x04000019 RID: 25
        QRCode,
        // Token: 0x0400001A RID: 26
        NFC
    }
    // Token: 0x0200000E RID: 14
    public class ValidateHelper
    {
        // Token: 0x06000033 RID: 51 RVA: 0x00002888 File Offset: 0x00000A88
        public static bool ValidateIPAddress(string ipAddress)
        {
            Regex regex = new Regex("^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return ipAddress != "" && regex.IsMatch(ipAddress.Trim());
        }
    }
    public class VehicleResponse : BaseResponse
    {
        // Token: 0x17000061 RID: 97
        // (get) Token: 0x060000EF RID: 239 RVA: 0x0000303F File Offset: 0x0000123F
        // (set) Token: 0x060000EE RID: 238 RVA: 0x00003036 File Offset: 0x00001236
        public new List<AppVehicle> data { get; set; }
    }
    // Token: 0x02000017 RID: 23
    public enum YesNoMark
    {
        // Token: 0x04000052 RID: 82
        Y = 1,
        // Token: 0x04000053 RID: 83
        N = 0
    }
}