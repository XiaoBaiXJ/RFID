using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using RFID.Common;
using RFID.Droid;

namespace RFID.Services
{
    public class ApiHelper
    {
        // Token: 0x0600046F RID: 1135 RVA: 0x0001DFBC File Offset: 0x0001C1BC
        public ApiHelper()
        {
            this.client = new HttpClient();
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // Token: 0x06000470 RID: 1136 RVA: 0x0001E00E File Offset: 0x0001C20E
        public void Disconnect()
        {
            this.client = null;
        }

        // Token: 0x06000471 RID: 1137 RVA: 0x0001E018 File Offset: 0x0001C218
        public async Task<T> Post<T>(string method) where T : BaseResponse, new()
        {
            string uriString = BasicData.BaseUrl + method;
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, null);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = "访问网络错误,请稍后重试";
                result = t2;
            }
            return result;
        }

        // Token: 0x06000472 RID: 1138 RVA: 0x0001E068 File Offset: 0x0001C268
        public async Task<T> PostWithParams<T>(string method, Dictionary<string, string> keyValues) where T : BaseResponse, new()
        {
            string uriString = BasicData.BaseUrl + method + "?" + this.GetMethodParams(keyValues);
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, null);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = "访问网络错误,请稍后重试";
                result = t2;
            }
            return result;
        }

        // Token: 0x06000473 RID: 1139 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
        public async Task<T> GetWithParams<T>(string method, Dictionary<string, string> keyValues) where T : BaseResponse, new()
        {
            string requestUri = BasicData.BaseUrl + method + "?" + this.GetMethodParams(keyValues);
            T result;
            try
            {
                HttpResponseMessage httpResponseMessage = await this.client.GetAsync(requestUri);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = "访问网络错误,请稍后重试";
                result = t2;
            }
            return result;
        }

        // Token: 0x06000474 RID: 1140 RVA: 0x0001E118 File Offset: 0x0001C318
        public async Task<T> PostWithParam<T>(string method, string key, string value) where T : BaseResponse, new()
        {
            string uriString = string.Concat(new string[]
            {
                BasicData.BaseUrl,
                method,
                "?",
                key,
                "=",
                value
            });
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, null);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = "访问网络错误,请稍后重试";
                result = t2;
            }
            return result;
        }

        // Token: 0x06000475 RID: 1141 RVA: 0x0001E178 File Offset: 0x0001C378
        public async Task<T> PostWithJson<T>(string method, object obj) where T : BaseResponse, new()
        {
            string uriString = BasicData.BaseUrl + method;
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                string content = JsonConvert.SerializeObject(obj);
                StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, content2);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = "访问网络错误,请稍后重试";
                result = t2;
            }
            return result;
        }

        // Token: 0x06000476 RID: 1142 RVA: 0x0001E1D0 File Offset: 0x0001C3D0
        public async Task<T> PostWithJson200<T>(string method, object obj) where T : BaseResponse, new()
        {
            string uriString = BasicData.BaseUrl + method;
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                string content = JsonConvert.SerializeObject(obj);
                StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, content2);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    T t = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                    t.successed = true;
                    result = t;
                }
                else
                {
                    T t2 = Activator.CreateInstance<T>();
                    t2.msg = AppResource.servererror;
                    result = t2;
                }
            }
            catch (Exception ex)
            {
                T t3 = Activator.CreateInstance<T>();
                t3.msg = "访问网络错误,请稍后重试";
                result = t3;
            }
            return result;
        }

        // Token: 0x06000477 RID: 1143 RVA: 0x0001E228 File Offset: 0x0001C428
        public async Task<T> UploadWithJson<T>(string method, object obj, byte[] data) where T : BaseResponse, new()
        {
            string uriString = BasicData.BaseUrl + method;
            T result;
            try
            {
                Uri requestUri = new Uri(uriString);
                string content = JsonConvert.SerializeObject(obj);
                ByteArrayContent byteArrayContent = new ByteArrayContent(data);
                StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
                byteArrayContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                byteArrayContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = "upload.image.jpg"
                };
                string boundary = "luolan";
                MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(boundary);
                multipartFormDataContent.Add(byteArrayContent);
                multipartFormDataContent.Add(content2);
                HttpResponseMessage httpResponseMessage = await this.client.PostAsync(requestUri, multipartFormDataContent);
                HttpResponseMessage httpResponseMessage2 = httpResponseMessage;
                if (httpResponseMessage2.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<T>(await httpResponseMessage2.Content.ReadAsStringAsync());
                }
                else
                {
                    T t = Activator.CreateInstance<T>();
                    t.msg = AppResource.servererror;
                    result = t;
                }
            }
            catch (Exception ex)
            {
                T t2 = Activator.CreateInstance<T>();
                t2.msg = ex.Message + AppResource.servererror;
                result = t2;
            }
            return result;
        }

        // Token: 0x06000478 RID: 1144 RVA: 0x0001E288 File Offset: 0x0001C488
        private string GetMethodParams(Dictionary<string, string> param)
        {
            if (param != null && param.Count >= 1)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (KeyValuePair<string, string> keyValuePair in param)
                {
                    stringBuilder.Append(keyValuePair.Key + "=" + keyValuePair.Value + "&");
                }
                return stringBuilder.ToString().TrimEnd('&');
            }
            return string.Empty;
        }

        // Token: 0x040002F5 RID: 757
        private HttpClient client;
    }
}