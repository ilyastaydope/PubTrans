using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PubTrans
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void window_Load(object sender, EventArgs e)
        {
            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.Position = new PointLatLng(50.4277651, 30.5500251);
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomType =
            MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.ShowCenter = false;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = 12;
            gMapControl1.MapProvider =
            GMapProviders.GoogleMap;
            GMaps.Instance.Mode =
            AccessMode.ServerOnly;
            infoList.HorizontalScrollbar = true;

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.DimGray, 3))
            {
                g.DrawRectangle(selPen, 10, 10, 1328, 793);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            infoList.Items.Clear();

            // METRO

            for (int i = 0; i < checkBoxMetro.CheckedIndices.Count; i++) 
            { 
                if (checkBoxMetro.CheckedIndices[i] == 0)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.4763422, 30.430702));
                    points.Add(new PointLatLng(50.4730682, 30.4522347));
                    points.Add(new PointLatLng(50.4611787, 30.4836702));
                    points.Add(new PointLatLng(50.4482819, 30.5137002));
                    points.Add(new PointLatLng(50.4381287, 30.5208564));
                    points.Add(new PointLatLng(50.43702, 30.5317757));
                    points.Add(new PointLatLng(50.4265517, 30.54012));
                    points.Add(new PointLatLng(50.4182208, 30.5449212));
                    points.Add(new PointLatLng(50.4018213, 30.5604887));
                    points.Add(new PointLatLng(50.3942641, 30.6048578));
                    points.Add(new PointLatLng(50.3952473, 30.6162304));
                    points.Add(new PointLatLng(50.3979437, 30.6345794));
                    points.Add(new PointLatLng(50.4007237, 30.6524831));
                    points.Add(new PointLatLng(50.4031207, 30.6668919));
                    points.Add(new PointLatLng(50.4033754, 30.6841949));
                    points.Add(new PointLatLng(50.4094731, 30.6962031)); 

                    GMapOverlay routesOverlay = new GMapOverlay("");
                 var route = new GMapRoute(points, "");
                 route.Stroke.DashStyle = DashStyle.Solid;
                 route.Stroke = new Pen(Color.Green);
                 route.Stroke.Width = 3;
                 routesOverlay.Routes.Add(route);
                 gMapControl1.Overlays.Add(routesOverlay); 
                 infoList.Items.Add("Метро зелёная ветка: Цена 8 грн, Интервал 3-12 мин, Расстояние 24.05 км");
                }

                if (checkBoxMetro.CheckedIndices[i] == 1)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.4646892, 30.6456757));

                    points.Add(new PointLatLng(50.4598946, 30.6302905));

                    points.Add(new PointLatLng(50.4559671, 30.6129634));
                    
                    points.Add(new PointLatLng(50.4518651, 30.5981576));

                    points.Add(new PointLatLng(50.4459795, 30.5768824));

                    points.Add(new PointLatLng(50.4412275, 30.5593354));

                    points.Add(new PointLatLng(50.4444389, 30.5453718));

                    points.Add(new PointLatLng(50.4471615, 30.5230987));

                    points.Add(new PointLatLng(50.4451358, 30.518378));

                    points.Add(new PointLatLng(50.4444389, 30.5059862));

                    points.Add(new PointLatLng(50.4509531, 30.4651442));

                    points.Add(new PointLatLng(50.4544883, 30.4472378));

                    points.Add(new PointLatLng(50.4592697, 30.4190129));
                    points.Add(new PointLatLng(50.4586276, 30.4039282));
                    points.Add(new PointLatLng(50.4577704, 30.3905922));
                    points.Add(new PointLatLng(50.4561311, 30.3653204));
                    points.Add(new PointLatLng(50.4649282,30.3552675));

                    GMapOverlay routesOverlay = new GMapOverlay("");
                    var route = new GMapRoute(points, "");
                    route.Stroke.DashStyle = DashStyle.Solid;
                    route.Stroke = new Pen(Color.Red);
                    route.Stroke.Width = 3;
                    routesOverlay.Routes.Add(route);
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Метро красная ветка: Цена 8 грн, Интервал 1.35-11 мин, Расстояние 21.71 км");
                }

                if (checkBoxMetro.CheckedIndices[i] == 2)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.5227382, 30.4989696));
                    points.Add(new PointLatLng(50.5014653, 30.4982293));
                    points.Add(new PointLatLng(50.4860811, 30.497843));
                    points.Add(new PointLatLng(50.4741539, 30.5034864));
                    points.Add(new PointLatLng(50.4660482, 30.5149984));
                    points.Add(new PointLatLng(50.4592663, 30.5244076));
                    points.Add(new PointLatLng(50.4479745, 30.5252767));
                    points.Add(new PointLatLng(50.4396662, 30.5166829));
                    points.Add(new PointLatLng(50.4322312, 30.5168653));
                    points.Add(new PointLatLng(50.4211859, 30.5206096));
                    points.Add(new PointLatLng(50.4144385, 30.5248797));
                    points.Add(new PointLatLng(50.4047875, 30.5168706));
                    points.Add(new PointLatLng(50.3974599, 30.5083627));
                    points.Add(new PointLatLng(50.3932502, 30.4876721));
                    points.Add(new PointLatLng(50.3824113, 30.4776567));
                    points.Add(new PointLatLng(50.3670328, 30.4540211));

                    GMapOverlay routesOverlay = new GMapOverlay("");
                    var route = new GMapRoute(points, "");
                    route.Stroke.DashStyle = DashStyle.Solid;
                    route.Stroke = new Pen(Color.Blue);
                    route.Stroke.Width = 3;
                    routesOverlay.Routes.Add(route);
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Метро синяя ветка: Цена 8 грн, Интервал 3-10 мин, Расстояние 20.89 км");
                }
            }

            // AUTOBUSES

            for (int i = 0; i < checkBoxAutobus.CheckedIndices.Count; i++)
            {
                if (checkBoxAutobus.CheckedIndices[i] == 0)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.375241, 30.593491));
                    points.Add(new PointLatLng(50.378423, 30.593169));
                    points.Add(new PointLatLng(50.381453, 30.595980));
                    points.Add(new PointLatLng(50.383054, 30.604810));
                    points.Add(new PointLatLng(50.387987, 30.603479));
                    points.Add(new PointLatLng(50.393158, 30.603286));
                    points.Add(new PointLatLng(50.394382, 30.609444));
                    points.Add(new PointLatLng(50.395319, 30.615892));
                    points.Add(new PointLatLng(50.401980, 30.620559));
                    points.Add(new PointLatLng(50.404681, 30.622383));
                    points.Add(new PointLatLng(50.407909, 30.620216));
                    points.Add(new PointLatLng(50.410446, 30.615968));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Brown);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 35: Цена 8 грн, Расстояние 6.92 км, Интервал 13 - 18 мин");
                }

                if (checkBoxAutobus.CheckedIndices[i] == 1)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.345734, 30.534900));
                    points.Add(new PointLatLng(50.349000, 30.538216));
                    points.Add(new PointLatLng(50.352539, 30.540866));
                    points.Add(new PointLatLng(50.354237, 30.541627));
                    points.Add(new PointLatLng(50.358899, 30.544095));
                    points.Add(new PointLatLng(50.363416, 30.546037));
                    points.Add(new PointLatLng(50.372511, 30.545812));
                    points.Add(new PointLatLng(50.377348, 30.537325));
                    points.Add(new PointLatLng(50.380927, 30.533431));
                    points.Add(new PointLatLng(50.383793, 30.531811));
                    points.Add(new PointLatLng(50.385216, 30.531296));
                    points.Add(new PointLatLng(50.390702, 30.529815));
                    points.Add(new PointLatLng(50.393021, 30.531006));
                    points.Add(new PointLatLng(50.398041, 30.530866));
                    points.Add(new PointLatLng(50.400264, 30.529064));
                    points.Add(new PointLatLng(50.405981, 30.522101));
                    points.Add(new PointLatLng(50.413071, 30.525126));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkOliveGreen);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 27: Цена 8 грн, Расстояние 9.35 км, Интервал 16 - 27 мин");
                }

                if (checkBoxAutobus.CheckedIndices[i] == 2)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.397857, 30.510664));
                    points.Add(new PointLatLng(50.402008, 30.515546));
                    points.Add(new PointLatLng(50.404258, 30.517262));
                    points.Add(new PointLatLng(50.405358, 30.519462));
                    points.Add(new PointLatLng(50.405242, 30.522294));
                    points.Add(new PointLatLng(50.404675, 30.529515));
                    points.Add(new PointLatLng(50.402876, 30.536714));
                    points.Add(new PointLatLng(50.393944, 30.604091));
                    points.Add(new PointLatLng(50.395278, 30.615925));
                    points.Add(new PointLatLng(50.396557, 30.624132));
                    points.Add(new PointLatLng(50.397973, 30.633616));
                    points.Add(new PointLatLng(50.401905, 30.633938));
                    points.Add(new PointLatLng(50.407553, 30.639635));
                    points.Add(new PointLatLng(50.411061, 30.638863));
                    points.Add(new PointLatLng(50.412456, 30.643841));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Black);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 91: Цена 8 грн, Расстояние 12.48 км, Интервал 10 - 28 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 3)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.499561, 30.364666));
                    points.Add(new PointLatLng(50.495385, 30.364773));
                    points.Add(new PointLatLng(50.496900, 30.370106));
                    points.Add(new PointLatLng(50.493003, 30.379386));
                    points.Add(new PointLatLng(50.487617, 30.393033));
                    points.Add(new PointLatLng(50.481760, 30.404545));
                    points.Add(new PointLatLng(50.478196, 30.405639));
                    points.Add(new PointLatLng(50.476318, 30.405639));
                    points.Add(new PointLatLng(50.471293, 30.405704));
                    points.Add(new PointLatLng(50.463842, 30.405693));
                    points.Add(new PointLatLng(50.459232, 30.405436));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Black);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 14: Цена 8 грн, Расстояние 7.84 км, Интервал 16 - 27 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 4)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.466410, 30.648186));
                    points.Add(new PointLatLng(50.471327, 30.642049));
                    points.Add(new PointLatLng(50.475117, 30.639464));
                    points.Add(new PointLatLng(50.479637, 30.636352));
                    points.Add(new PointLatLng(50.482920, 30.635301));
                    points.Add(new PointLatLng(50.486525, 30.644195));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Chocolate);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 81: Цена 8 грн, Расстояние 3.29 км, Интервал 8 - 16 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 5)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.406227, 30.554942));
                    points.Add(new PointLatLng(50.409557, 30.554320));
                    points.Add(new PointLatLng(50.415546, 30.556669));
                    points.Add(new PointLatLng(50.418034, 30.552925));
                    points.Add(new PointLatLng(50.420482, 30.547228));
                    points.Add(new PointLatLng(50.428055, 30.539567));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DeepPink);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 76: Цена 8 грн, Расстояние 3.28 км, Интервал 30 - 34 мин");

                }
                if (checkBoxAutobus.CheckedIndices[i] == 6)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.496094, 30.512820));
                    points.Add(new PointLatLng(50.498817, 30.505289));
                    points.Add(new PointLatLng(50.501595, 30.500139));
                    points.Add(new PointLatLng(50.502919, 30.491459));
                    points.Add(new PointLatLng(50.506078, 30.489764));
                    points.Add(new PointLatLng(50.507313, 30.487179));
                    points.Add(new PointLatLng(50.506679, 30.473896));
                    points.Add(new PointLatLng(50.505723, 30.463876));
                    points.Add(new PointLatLng(50.505880, 30.453951));
                    points.Add(new PointLatLng(50.505273, 30.443491));
                    points.Add(new PointLatLng(50.503615, 30.434167));
                    points.Add(new PointLatLng(50.505437, 30.418643));
                    points.Add(new PointLatLng(50.507115, 30.409963));
                    points.Add(new PointLatLng(50.512294, 30.411175));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkSlateGray);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 102: Цена 8 грн, Расстояние 11.48 км, Интервал 5 - 12 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 7)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.451629, 30.598480));
                    points.Add(new PointLatLng(50.458802, 30.603769));
                    points.Add(new PointLatLng(50.461909, 30.600657));
                    points.Add(new PointLatLng(50.468821, 30.598748));
                    points.Add(new PointLatLng(50.472529, 30.599638));
                    points.Add(new PointLatLng(50.473396, 30.596194));
                    points.Add(new PointLatLng(50.476250, 30.589725));
                    points.Add(new PointLatLng(50.487767, 30.584275));
                    points.Add(new PointLatLng(50.491569, 30.585487));
                    points.Add(new PointLatLng(50.495159, 30.581024));
                    points.Add(new PointLatLng(50.491760, 30.575294));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkSlateBlue);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 70: Цена 8 грн, Расстояние 8.45 км, Интервал 24 - 38 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 8)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.485405, 30.499420));
                    points.Add(new PointLatLng(50.486716, 30.503958));
                    points.Add(new PointLatLng(50.488586, 30.507993));
                    points.Add(new PointLatLng(50.488402, 30.528882));
                    points.Add(new PointLatLng(50.492962, 30.544224));
                    points.Add(new PointLatLng(50.495228, 30.574071));
                    points.Add(new PointLatLng(50.495228, 30.580809));
                    points.Add(new PointLatLng(50.500435, 30.589242));
                    points.Add(new PointLatLng(50.506815, 30.585712));
                    points.Add(new PointLatLng(50.510329, 30.594563));
                    points.Add(new PointLatLng(50.515487, 30.604702));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Red);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 21: Цена 8 грн, Расстояние 12.94 км, Интервал 6 - 11 мин");
                }
                if (checkBoxAutobus.CheckedIndices[i] == 9)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.491808, 30.575284));
                    points.Add(new PointLatLng(50.495098, 30.581206));
                    points.Add(new PointLatLng(50.491160, 30.584865));
                    points.Add(new PointLatLng(50.482436, 30.585938));
                    points.Add(new PointLatLng(50.479473, 30.582558));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Tomato);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 59: Цена 8 грн, Расстояние 3.37 км, Интервал 32 - 59 мин");

                }
                if (checkBoxAutobus.CheckedIndices[i] == 10)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.514266, 30.422183));
                    points.Add(new PointLatLng(50.512246, 30.425220));
                    points.Add(new PointLatLng(50.511230, 30.430369));
                    points.Add(new PointLatLng(50.512935, 30.435079));
                    points.Add(new PointLatLng(50.508303, 30.445143));
                    points.Add(new PointLatLng(50.496374, 30.457009));
                    points.Add(new PointLatLng(50.492927, 30.463489));
                    points.Add(new PointLatLng(50.488518, 30.473993));
                    points.Add(new PointLatLng(50.485173, 30.483799));
                    points.Add(new PointLatLng(50.476148, 30.496631));
                    points.Add(new PointLatLng(50.466622, 30.513647));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkGreen);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dot;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Автобус 72: Цена 8 грн, Расстояние 10.02 км, Интервал 14 - 19 мин");
                }
            }
            // TAXIES

            for (int i = 0; i < checkBoxTaxi.CheckedIndices.Count; i++)
            {
                if (checkBoxTaxi.CheckedIndices[i] == 0)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.458761, 30.403901));
                    points.Add(new PointLatLng(50.457962, 30.392475));
                    points.Add(new PointLatLng(50.455065, 30.387422));
                    points.Add(new PointLatLng(50.448712, 30.388634));
                    points.Add(new PointLatLng(50.443650, 30.388860));
                    points.Add(new PointLatLng(50.440944, 30.384740));
                    points.Add(new PointLatLng(50.437541, 30.386059));
                    points.Add(new PointLatLng(50.435634, 30.379043));
                    points.Add(new PointLatLng(50.434083, 30.372949));
                    points.Add(new PointLatLng(50.432511, 30.369387));
                    points.Add(new PointLatLng(50.427994, 30.372509));
                    points.Add(new PointLatLng(50.426230, 30.367230));
                    points.Add(new PointLatLng(50.429996, 30.365921));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Brown);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 187: Цена 7 грн, Расстояние 7.61 км, Интервал 7 - 13 мин");
                }

                if (checkBoxTaxi.CheckedIndices[i] == 1)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.488791, 30.499581));
                    points.Add(new PointLatLng(50.488634, 30.507960));
                    points.Add(new PointLatLng(50.488108, 30.520041));
                    points.Add(new PointLatLng(50.488443, 30.528914));
                    points.Add(new PointLatLng(50.492989, 30.544267));
                    points.Add(new PointLatLng(50.495200, 30.561948));
                    points.Add(new PointLatLng(50.495262, 30.574007));
                    points.Add(new PointLatLng(50.497309, 30.590658));
                    points.Add(new PointLatLng(50.497350, 30.600067));
                    points.Add(new PointLatLng(50.500865, 30.610946));
                    points.Add(new PointLatLng(50.507695, 30.619122));
                    points.Add(new PointLatLng(50.510104, 30.621536));
                    points.Add(new PointLatLng(50.517697, 30.626943));
                    points.Add(new PointLatLng(50.523434, 30.628145));
                    points.Add(new PointLatLng(50.528222, 30.628424));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkOliveGreen);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 151: Цена 8 грн, Расстояние 12.4 км, Интервал 9 - 15 мин");
                }

                if (checkBoxTaxi.CheckedIndices[i] == 2)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.479671, 30.340451));
                    points.Add(new PointLatLng(50.477848, 30.343573));
                    points.Add(new PointLatLng(50.474878, 30.346245));
                    points.Add(new PointLatLng(50.473471, 30.357209));
                    points.Add(new PointLatLng(50.465932, 30.355268));
                    points.Add(new PointLatLng(50.464566, 30.347618));
                    points.Add(new PointLatLng(50.460086, 30.338799));
                    points.Add(new PointLatLng(50.455093, 30.342575));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Black);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 200К: Цена 7 грн, Расстояние 5.53 км, Интервал 5 мин");

                }
                if (checkBoxTaxi.CheckedIndices[i] == 3)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.457108, 30.446506));
                    points.Add(new PointLatLng(50.451124, 30.444081));
                    points.Add(new PointLatLng(50.442884, 30.442429));
                    points.Add(new PointLatLng(50.440172, 30.441592));
                    points.Add(new PointLatLng(50.431452, 30.431721));
                    points.Add(new PointLatLng(50.422895, 30.426335));
                    points.Add(new PointLatLng(50.416216, 30.423814));
                    points.Add(new PointLatLng(50.410288, 30.415145));
                    points.Add(new PointLatLng(50.415997, 30.404695));
                    points.Add(new PointLatLng(50.418670, 30.401402));
                    points.Add(new PointLatLng(50.416469, 30.391681));
                    points.Add(new PointLatLng(50.417713, 30.388752));
                    points.Add(new PointLatLng(50.420338, 30.381907));
                    points.Add(new PointLatLng(50.421787, 30.379043));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Black);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 201: Цена 8 грн, Расстояние 10.73 км, Интервал 5 - 10 мин");
                }
                if (checkBoxTaxi.CheckedIndices[i] == 4)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.485665, 30.395522));
                    points.Add(new PointLatLng(50.481132, 30.395726));
                    points.Add(new PointLatLng(50.474441, 30.395758));
                    points.Add(new PointLatLng(50.466786, 30.395790));
                    points.Add(new PointLatLng(50.458658, 30.395930));
                    points.Add(new PointLatLng(50.457108, 30.387948));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Chocolate);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 186: Цена 8 грн, Расстояние 4.48 км, Интервал 6 - 10 мин");
                }
                if (checkBoxTaxi.CheckedIndices[i] == 5)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.397993, 30.633638));
                    points.Add(new PointLatLng(50.401980, 30.633885));
                    points.Add(new PointLatLng(50.406671, 30.639614));
                    points.Add(new PointLatLng(50.413844, 30.636899));
                    points.Add(new PointLatLng(50.415143, 30.626042));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DeepPink);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 250: Цена 5 грн, Расстояние 3.76 км, Интервал 6 - 10 мин");
                }
                if (checkBoxTaxi.CheckedIndices[i] == 6)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.412928, 30.524429));
                    points.Add(new PointLatLng(50.405365, 30.519515));
                    points.Add(new PointLatLng(50.405276, 30.522176));
                    points.Add(new PointLatLng(50.399354, 30.529429));
                    points.Add(new PointLatLng(50.396489, 30.532486));
                    points.Add(new PointLatLng(50.399354, 30.536059));
                    points.Add(new PointLatLng(50.399642, 30.538849));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkSlateGray);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 457: Цена 5 грн, Расстояние 3.59 км, Интервал 15 - 20 мин");

                }
                if (checkBoxTaxi.CheckedIndices[i] == 7)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.419723, 30.425198));
                    points.Add(new PointLatLng(50.423954, 30.426636));
                    points.Add(new PointLatLng(50.429955, 30.415049));
                    points.Add(new PointLatLng(50.439912, 30.409073));
                    points.Add(new PointLatLng(50.445406, 30.416014));
                    points.Add(new PointLatLng(50.447155, 30.420467));
                    points.Add(new PointLatLng(50.457866, 30.420102));
                    points.Add(new PointLatLng(50.461950, 30.436850));
                    points.Add(new PointLatLng(50.462845, 30.451355));
                    points.Add(new PointLatLng(50.462381, 30.465646));
                    points.Add(new PointLatLng(50.461513, 30.480945));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkSlateBlue);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 566: Цена 7 грн, Расстояние 10.22 км, Интервал 12 мин");
                }
                if (checkBoxTaxi.CheckedIndices[i] == 8)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.511107, 30.612009));
                    points.Add(new PointLatLng(50.503956, 30.596977));
                    points.Add(new PointLatLng(50.497459, 30.589253));
                    points.Add(new PointLatLng(50.489965, 30.590948));
                    points.Add(new PointLatLng(50.483282, 30.593308));
                    points.Add(new PointLatLng(50.474318, 30.596398));
                    points.Add(new PointLatLng(50.467237, 30.598705));
                    points.Add(new PointLatLng(50.458679, 30.603318));
                    points.Add(new PointLatLng(50.453166, 30.599992));
                    points.Add(new PointLatLng(50.451411, 30.598673));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Red);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 222: Цена 7 грн, Расстояние 9.34 км, Интервал 6 - 15 мин");

                }
                if (checkBoxTaxi.CheckedIndices[i] == 9)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.514232, 30.422248));
                    points.Add(new PointLatLng(50.508384, 30.432140));
                    points.Add(new PointLatLng(50.504488, 30.440100));
                    points.Add(new PointLatLng(50.505321, 30.449874));
                    points.Add(new PointLatLng(50.504754, 30.456773));
                    points.Add(new PointLatLng(50.505853, 30.470066));
                    points.Add(new PointLatLng(50.506965, 30.487897));
                    points.Add(new PointLatLng(50.509538, 30.491492));
                    points.Add(new PointLatLng(50.511980, 30.496287));
                    points.Add(new PointLatLng(50.511871, 30.500579)); 
                    points.Add(new PointLatLng(50.513884, 30.508218));
                    points.Add(new PointLatLng(50.521060, 30.513872));
                    points.Add(new PointLatLng(50.526592, 30.516554));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.Tomato);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 530: Цена 8 грн, Расстояние 9.33 км, Интервал 6 - 8 мин");

                }
                if (checkBoxTaxi.CheckedIndices[i] == 10)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(50.465994, 30.355793));
                    points.Add(new PointLatLng(50.473109, 30.357735));
                    points.Add(new PointLatLng(50.475642, 30.358926));
                    points.Add(new PointLatLng(50.477233, 30.356469));
                    points.Add(new PointLatLng(50.474195, 30.355514));
                    points.Add(new PointLatLng(50.474605, 30.346148));
                    points.Add(new PointLatLng(50.472699, 30.331149));
                    points.Add(new PointLatLng(50.466526, 30.331299));
                    points.Add(new PointLatLng(50.467974, 30.334228));
                    GMapOverlay routesOverlay = new GMapOverlay("");
                    for (int k = 0; k < points.Count - 1; k++)
                    {
                        MapRoute route = GMapProviders.OpenStreetMap.GetRoute(points[k], points[k + 1], false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "");
                        r.Stroke = new Pen(Color.DarkGreen);
                        r.Stroke.Width = 4;
                        r.Stroke.DashStyle = DashStyle.Dash;

                        routesOverlay.Routes.Add(r);
                    }
                    gMapControl1.Overlays.Add(routesOverlay);
                    infoList.Items.Add("Маршрутка 497: Цена 6 грн, Расстояние 4.96 км, Интервал 5 - 10 мин");

                }
            }
            gMapControl1.Zoom = 12;
            gMapControl1.Position = new PointLatLng(50.4277651, 30.5500251); 
        }
    }
}
