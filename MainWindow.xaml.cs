using GMap.NET.MapProviders;
using GMap.NET;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET.WindowsPresentation;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;
using System.Windows.Threading;
using System.Diagnostics;

namespace GmapTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>




public partial class MainWindow : Window
{
    private List<PointLatLng> turkeyCoordinates;
    private int currentZoom = 7;
    private int slpTime = 1;
    private int maxZoom = 16;
    private int currentPositionIndex = 0;
    private DispatcherTimer timer;

    public MainWindow()
    {
        InitializeComponent();
        InitializeMap();
        StartAutoCache();
    }

    private void InitializeMap()
    {
        // **Offline Modu Aç**
        GMaps.Instance.Mode = AccessMode.ServerAndCache;

        // **Harita Sağlayıcısı (Google Yok, OpenStreetMap)**
        GMapControl.MapProvider = GMapProviders.OpenStreetMap;

        // **Cache Konumu Ayarla**
        string cacheDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GMapCache");
        if (!Directory.Exists(cacheDirectory))
        {
            Directory.CreateDirectory(cacheDirectory);
        }
        GMapControl.CacheLocation = cacheDirectory;

        // **Başlangıç Konumu: Türkiye (Ankara)**
        GMapControl.Position = new PointLatLng(39.9334, 32.8597);
        GMapControl.MinZoom = 1;
        GMapControl.MaxZoom = maxZoom;
        GMapControl.Zoom = currentZoom;
        GMapControl.ShowCenter = false;



        turkeyCoordinates = new List<PointLatLng>
{
    new PointLatLng(41.0082, 28.9784), // İstanbul
    new PointLatLng(39.9208, 32.8541), // Ankara
    new PointLatLng(38.4192, 27.1287), // İzmir
    new PointLatLng(37.0662, 37.3833), // Gaziantep
    new PointLatLng(40.1826, 29.0669), // Bursa
    new PointLatLng(36.8969, 30.7133), // Antalya
    new PointLatLng(37.0021, 35.3213), // Adana
    new PointLatLng(41.0130, 39.7421), // Trabzon
    new PointLatLng(38.6746, 39.2232), // Elazığ
    new PointLatLng(38.6120, 34.7271), // Nevşehir (Kapadokya)
    new PointLatLng(39.7500, 37.0167), // Sivas
    new PointLatLng(41.6333, 26.6667), // Edirne
    new PointLatLng(37.2333, 38.3167), // Şanlıurfa
    new PointLatLng(40.6500, 43.1000), // Kars
    new PointLatLng(39.9208, 32.8541), // Ankara
    new PointLatLng(40.7696, 30.3938), // Sakarya
    new PointLatLng(38.7312, 35.4787), // Kayseri
    new PointLatLng(38.4192, 27.1287), // İzmir
    new PointLatLng(39.9208, 41.2707), // Erzurum
    new PointLatLng(37.2153, 28.3636), // Muğla
    new PointLatLng(37.0741, 36.2476), // Osmaniye
    new PointLatLng(37.1806, 36.9371), // Kahramanmaraş
    new PointLatLng(39.7667, 30.5250), // Eskişehir
    new PointLatLng(40.9833, 27.5167), // Tekirdağ
    new PointLatLng(37.9615, 34.6798), // Aksaray
    new PointLatLng(40.8500, 31.1667), // Düzce
    new PointLatLng(37.7500, 30.5500), // Isparta
    new PointLatLng(40.7370, 37.4973), // Tokat
    new PointLatLng(41.4500, 31.7833), // Zonguldak
    new PointLatLng(39.9167, 32.8500), // Çankırı
    new PointLatLng(40.5500, 34.9500), // Çorum
    new PointLatLng(41.7500, 34.6667), // Kastamonu
    new PointLatLng(37.7667, 29.0833), // Denizli
    new PointLatLng(38.3333, 38.5000), // Malatya
    new PointLatLng(40.8333, 31.1667), // Bolu
    new PointLatLng(38.7304, 41.4908), // Van
    new PointLatLng(39.6420, 27.8826), // Balıkesir
    new PointLatLng(39.9199, 33.8860), // Kırıkkale
    new PointLatLng(41.0200, 40.5233), // Rize
    new PointLatLng(38.6667, 39.5000), // Bingöl
    new PointLatLng(37.5833, 36.9333), // Adıyaman
    new PointLatLng(40.3167, 36.5500), // Amasya
    new PointLatLng(39.7500, 43.5000), // Iğdır
    new PointLatLng(39.8883, 44.0047), // Ağrı
    new PointLatLng(38.6820, 39.1822), // Tunceli
    new PointLatLng(37.7500, 38.2786), // Batman
    new PointLatLng(40.7667, 37.3667), // Giresun
    new PointLatLng(40.9800, 39.7167), // Gümüşhane
    new PointLatLng(37.0742, 38.3167), // Mardin
    new PointLatLng(40.5833, 33.5000), // Karabük
    new PointLatLng(40.5500, 35.0000), // Yozgat
    new PointLatLng(37.8833, 41.1333), // Siirt
    new PointLatLng(39.4167, 29.9833), // Uşak
    new PointLatLng(38.6312, 34.6928), // Nevşehir
    new PointLatLng(41.1781, 27.8022), // Kırklareli
    new PointLatLng(37.7500, 39.2833), // Şırnak
    new PointLatLng(37.6667, 30.5000), // Burdur
    new PointLatLng(41.6333, 32.0833), // Bartın
    new PointLatLng(38.6083, 27.2000), // Manisa
    new PointLatLng(37.0811, 36.2270), // Kilis
    new PointLatLng(38.5000, 43.3833), // Muş
    new PointLatLng(40.6500, 33.6000), // Çankırı
    new PointLatLng(39.7510, 37.0167), // Sivas
    new PointLatLng(39.5000, 32.7167), // Kırıkkale
    new PointLatLng(40.0000, 31.0000), // Bartın
    new PointLatLng(39.1500, 32.6167), // Kırşehir
    new PointLatLng(41.2500, 33.4500), // Sinop
    new PointLatLng(37.3333, 42.1833), // Hakkari
    new PointLatLng(40.7333, 31.6000), // Karabük
    new PointLatLng(39.4800, 31.5700), // Afyonkarahisar
    new PointLatLng(40.1333, 29.6333), // Yalova
};

    }

    private void StartAutoCache()
    {
        timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(slpTime); // **Her 2 saniyede bir değiştir**
        timer.Tick += CacheNextArea;
        timer.Start();
    }

    private void CacheNextArea(object sender, EventArgs e)
    {
        if (currentZoom > maxZoom)
        {
            currentZoom = 1; // **Başa dön**
            currentPositionIndex = 0;
        }

        if (currentPositionIndex >= turkeyCoordinates.Count)
        {
            currentPositionIndex = 0; // **Şehirler bitince başa dön**
            currentZoom++;
            slpTime++;
            timer.Interval = TimeSpan.FromSeconds(slpTime);
        }

        // **Yeni konuma git ve zoom seviyesini değiştir**
        PointLatLng newPos = turkeyCoordinates[currentPositionIndex];
        GMapControl.Position = newPos;
        GMapControl.Zoom = currentZoom;

        currentPositionIndex++;

        Debug.WriteLine($"📍 Önbelleğe Alınıyor: {newPos.Lat}, {newPos.Lng} | Zoom: {currentZoom}");
    }
}

