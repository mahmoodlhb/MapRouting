using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Diagnostics;
using System.Collections;
using System.Threading;

namespace robot_routing
{
    public partial class Form1 : Form
    {
        double lat, lang=0;
        RectLatLng area;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;
            GMap.NET.MapProviders.GoogleMapProvider.UserAgent = "IE";
            gmap.CacheLocation = Application.StartupPath;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;


            gmap.MinZoom = 5;
            gmap.MaxZoom = 20;
            gmap.Zoom = 5;
            gmap.SetPositionByKeywords("Iran");


            gmap.ShowCenter = false;

        }
        private void Func_Gmap()
        {
            area = gmap.SelectedArea;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;
        }
        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            Func_Gmap();
            if (!area.IsEmpty)
            {
                gmap.SetZoomToFitRect(area);
                gmap.CanDragMap = false;
                gmap.MinZoom = (int)gmap.Zoom;

            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                 lat= gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                 lang = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

             //    MessageBox.Show("lng: " + lang.ToString() + ", lat:" + lat.ToString());
            }
        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void gmap_MouseMove(object sender, MouseEventArgs e)
        {
            lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
            lang = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            txt_Lat.Text =Convert.ToString( lat);
            txt_Lang.Text =Convert.ToString( lang);
        }

        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            Func_Gmap();
            gmap.ReloadMap();
            RectLatLng area = gmap.SelectedArea;
            if (!area.IsEmpty)
            {
                gmap.SetZoomToFitRect(area);
                gmap.CanDragMap = false;
                gmap.MinZoom =(int) gmap.Zoom;

                
            }
        }

        private void btn_UnFit_Click(object sender, EventArgs e)
        {
            Func_Gmap();
            gmap.CanDragMap = true;
            gmap.MinZoom = 6;
        }
        TilePrefetcher obj;
        private void btn_Cache_Click(object sender, EventArgs e)
        {
            try
            {
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                GMap.NET.MapProviders.GoogleMapProvider.UserAgent = "IE";
                gmap.CacheLocation = Application.StartupPath;
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                RectLatLng area = gmap.SelectedArea;

                if (!area.IsEmpty)
                {
                    for (int i = gmap.MinZoom; i <= gmap.MaxZoom; i++)

                    {
                       obj = new TilePrefetcher();
                        obj.Icon = this.Icon;
                        obj.Owner = this;
                        obj.ShowCompleteMessage = false;
                        obj.Start(area, i, gmap.MapProvider, 1, 2); 
                    }
                }
                else
                {
                    MessageBox.Show("No Area Chosen", "Error");
                }
            }
            catch
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                 Process.GetCurrentProcess().Kill();
                 Application.Exit();
            }
            else
            {
                Process.GetCurrentProcess().Kill();
                e.Cancel = true;
                Application.Exit();
            }
            //gmap.Manager.CancelTileCaching();
            //gmap.Dispose();
            
        }

    }
}
