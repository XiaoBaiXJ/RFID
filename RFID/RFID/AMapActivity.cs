
using System;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Amap.Api.Maps2d;
using Com.Amap.Api.Maps2d.Model;
using Java.Util;

namespace RFID.Droid
{
    [Activity(Label = "地图展示", Theme = "@style/Theme.AppCompat")]
    public class AMapActivity : AppCompatActivity
    {
        MarkerOptions markerOption;
        AMap aMap;
        MapView mapView;
        LatLng startLatlng;
        LatLng endLatlng;
        bool isLine;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            startLatlng = new LatLng(Intent.GetDoubleExtra("StartLatitude",0), Intent.GetDoubleExtra("StartLongitude",0));
            isLine = Intent.GetBooleanExtra("isLine", false);
            if (isLine)
            {
                endLatlng = new LatLng(Intent.GetDoubleExtra("EndLatitude", 0), Intent.GetDoubleExtra("EndLongitude", 0));
            }
            SetContentView(Resource.Layout.amap_layout);
            //SetSupportActionBar(new Android.Support.V7.Widget.Toolbar(this));
            var actionBar = SupportActionBar;
            if (actionBar!=null)
            {
                actionBar.SetHomeButtonEnabled(true);
                actionBar.SetDisplayHomeAsUpEnabled(true);
            }
           
            mapView = FindViewById<MapView>(Resource.Id.map);

            //AMapOptions options = new AMapOptions();
            //options.InvokeCamera(new CameraPosition(latlng, 15,  0, 0));
            //mapView = new MapView(this, options);
            mapView.OnCreate(savedInstanceState);

            if (aMap == null)
            {
                aMap = mapView.Map;
                //设置marker
                markerOption = new MarkerOptions().InvokeIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueRed))
                                                  .InvokeTitle("施封位置").InvokeSnippet(Intent.GetStringExtra("startAddress")).InvokePosition(startLatlng).Draggable(true);
                aMap.AddMarker(markerOption).ShowInfoWindow();
                if (isLine)
                {
                    //设置中心点
                    var update = CameraUpdateFactory.NewCameraPosition(new CameraPosition(endLatlng, 5, 0, 0));
                    aMap.MoveCamera(update);
                    //设置marker
                    MarkerOptions endMarkerOption = new MarkerOptions().InvokeIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueGreen))
                                                                       .InvokeTitle("拆封位置").InvokeSnippet(Intent.GetStringExtra("endAddress")).InvokePosition(endLatlng).Draggable(true);
                    aMap.AddMarker(endMarkerOption).ShowInfoWindow();
                    PolylineOptions polylineOptions = new PolylineOptions();
                    var laglngs = new ArrayList();
                    laglngs.Add(startLatlng);
                    laglngs.Add(endLatlng);
                    polylineOptions.AddAll(laglngs);
                    polylineOptions.InvokeWidth(10);
                    polylineOptions.InvokeColor(Color.Argb(255, 0, 205, 205));
                    polylineOptions.Visible(true);
                    var polyline = aMap.AddPolyline(polylineOptions);
                    polyline.Visible = true;
                    var endupdate = CameraUpdateFactory.NewCameraPosition(new CameraPosition(endLatlng, 10, 0, 0));
                    aMap.MoveCamera(update);
                }
                else
                {
                    //设置中心点
                    var update = CameraUpdateFactory.NewCameraPosition(new CameraPosition(startLatlng, 15, 0, 0));
                    aMap.MoveCamera(update);
                }
            }
        }
        /// <summary>
        /// 重写返回按钮
        /// </summary>
        /// <returns><c>true</c>, if options item selected was oned, <c>false</c> otherwise.</returns>
        /// <param name="item">Item.</param>
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case  Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
            
        }

        /// <summary>
        /// 必须要重写这些方法
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }
        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnResume();
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }
    }

    

}
