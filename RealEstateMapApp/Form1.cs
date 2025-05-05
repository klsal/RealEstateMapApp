using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateMapApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, DistrictInfo> districts;

        public Form1()
        {
            InitializeComponent();
            InitializeDistricts();
            SetBrowserFeatureControl();
            // Handle document complete event to ensure the map is fully loaded before manipulating it
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void SetBrowserFeatureControl()
        {
            // Get the process filename
            string appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            // Set feature control registry keys
            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", appName, 11000);
        }


        private void SetBrowserFeatureControlKey(string feature, string appName, uint value)
        {
            using (var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Internet Explorer\Main\FeatureControl\" + feature,
                Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                key.SetValue(appName, value, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the Google Maps HTML into the WebBrowser control
            LoadGoogleMapsHtml();
        }

        private void InitializeDistricts()
        {
            // Initialize sample district data as mentioned in the report
            districts = new Dictionary<string, DistrictInfo>
            {
                { "Al-Rehab", new DistrictInfo { Name = "Al-Rehab", Price = 500000, Category = PriceCategory.Affordable, Latitude = 21.613, Longitude = 39.156 } },
                { "Al-Rawdah", new DistrictInfo { Name = "Al-Rawdah", Price = 1200000, Category = PriceCategory.Expensive, Latitude = 21.573, Longitude = 39.173 } },
                { "Al-Safa", new DistrictInfo { Name = "Al-Safa", Price = 800000, Category = PriceCategory.MidRange, Latitude = 21.597, Longitude = 39.195 } },
                { "Al-Naeem", new DistrictInfo { Name = "Al-Naeem", Price = 1500000, Category = PriceCategory.Expensive, Latitude = 21.628, Longitude = 39.183 } },
                { "Obhur", new DistrictInfo { Name = "Al-Naeem", Price = 2000000, Category = PriceCategory.Expensive, Latitude = 21.699, Longitude = 39.187 } }
            };
        }

        private void LoadGoogleMapsHtml()
        {
            string htmlContent = GetMapHtml();
            webBrowser.DocumentText = htmlContent;
        }

        private string GetMapHtml()
        {
            return @"
    <!DOCTYPE html>
    <html>
    <head>
        <title>Real Estate Prices in Jeddah</title>
        <meta charset='utf-8'>
        <link rel='stylesheet' href='https://unpkg.com/leaflet@1.9.4/dist/leaflet.css' />
        <style>
            #map {
                height: 100%;
                width: 100%;
            }
            html, body {
                height: 100%;
                margin: 0;
                padding: 0;
            }
            .info-window {
                font-family: Arial, sans-serif;
                font-size: 14px;
                padding: 10px;
            }
            .district-name {
                font-weight: bold;
                margin-bottom: 5px;
            }
            .price {
                color: #333;
            }
        </style>
    </head>
    <body>
        <div id='map'></div>
        <script src='https://unpkg.com/leaflet@1.9.4/dist/leaflet.js'></script>
        <script>
            var map;
            var markers = [];

            function initMap() {
                // Center on Jeddah
                map = L.map('map').setView([21.5906, 39.1676], 12);
                
                // Add OpenStreetMap tiles
                L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                    attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
                }).addTo(map);
            }

            function addMarker(lat, lng, title, price, color) {
                var circleMarker = L.circleMarker([lat, lng], {
                    radius: 15,
                    fillColor: color,
                    color: '#FFFFFF',
                    weight: 1,
                    opacity: 1,
                    fillOpacity: 0.6
                }).addTo(map);
                
                circleMarker.bindPopup(
                    '<div class=""info-window"">' +
                    '<div class=""district-name"">' + title + '</div>' +
                    '<div class=""price"">Average Price: SAR ' + price.toLocaleString() + '</div>' +
                    '</div>'
                );
                
                markers.push(circleMarker);
            }
            
            // Initialize map
            initMap();
        </script>
    </body>
    </html>";
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                // Add markers for each district once the map is loaded
                foreach (var district in districts.Values)
                {
                    string colorCode = GetColorCodeForCategory(district.Category);
                    AddMarkerToMap(district.Latitude, district.Longitude, district.Name, district.Price, colorCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading map markers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetColorCodeForCategory(PriceCategory category)
        {
            switch (category)
            {
                case PriceCategory.Affordable:
                    return "#4CAF50"; // Green
                case PriceCategory.MidRange:
                    return "#FF9800"; // Orange
                case PriceCategory.Expensive:
                    return "#F44336"; // Red
                default:
                    return "#2196F3"; // Blue (default)
            }
        }

        private void AddMarkerToMap(double latitude, double longitude, string title, decimal price, string colorCode)
        {
            // Execute JavaScript to add a marker to the map
            string script = $"addMarker({latitude}, {longitude}, '{title}', {price}, '{colorCode}')";
            webBrowser.Document.InvokeScript("eval", new object[] { script });
        }
    }

    public enum PriceCategory
    {
        Affordable,
        MidRange,
        Expensive
    }

    public class DistrictInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PriceCategory Category { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
