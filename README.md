
📥 [Download Data.gmdb]    https://drive.google.com/file/d/1wAWpeDXUgDqQ9HAp2Udt-hVCysR0TTiW/view?usp=sharing

# GMap.NET Türkiye Cache Veritabanı (GMDB) 🌍

Bu repo, **GMap.NET** için **Türkiye'nin tamamının** önbelleğe alınmış harita verilerini içeren bir **GMDB** dosyası sağlar. Bu sayede internet bağlantısı olmadan, Türkiye'nin tüm harita verilerine **hızlı ve sorunsuz** bir şekilde erişebilirsiniz.

İndirilen Dosyayı projeye ekleyin:

İndirdiğiniz Data.gmdb dosyasını, projenizde bulunan Maps klasörüne taşıyın.
Dosyanın Copy Always olarak ayarlandığından emin olun:

Visual Studio’da Data.gmdb dosyasına sağ tıklayın.
"Properties" (Özellikler) → "Copy to Output Directory" ayarını "Copy always" olarak değiştirin.

 GMaps.Instance.Mode = AccessMode.CacheOnly; olarak değiştirip kullanablirsiniz.

## 📌 Özellikler
- **Tüm Türkiye'nin** detaylı harita verileri
- **Offline kullanım** için optimize edilmiş
- **GMap.NET** ile tam uyumlu
- **Hızlı erişim** ve gecikmesiz kullanım
- **Zoom aralığı: 7 - 16** (Büyük ölçekten detaylı sokak seviyesine kadar)

## 📥 Kurulum & Kullanım
1. **GMap.NET** kütüphanesini projenize ekleyin.
2. Bu repo içerisindeki `Turkey.gmdb` dosyasını indirin.
3. **GMap.NET** ayarlarında **cache database path** olarak bu dosyanın konumunu belirtin:
   ```csharp
   GMaps.Instance.Mode = AccessMode.ServerAndCache;
   MainMap.CacheLocation = @"C:\Path\To\Turkey.gmdb";
   ```
4. **Keyifli kullanımlar!** 🚀

## 📌 Lisans ve Katkı
Bu proje açık kaynak olup, dilediğiniz gibi kullanabilir ve geliştirebilirsiniz. **Katkılarınızı bekliyoruz!** 😊

---

# GMap.NET Turkey Cache Database (GMDB) 🌍

This repository provides a **GMDB file** containing cached map data for **the entire Turkey** for **GMap.NET**. With this, you can access detailed map data of Turkey **quickly and seamlessly, even without an internet connection**.

Move the downloaded file to the project:

Place the downloaded Data.gmdb file inside the Maps folder in your project.
Ensure the file is set to "Copy Always":
In Visual Studio, right-click on Data.gmdb.
Go to "Properties" → "Copy to Output Directory" and set it to "Copy always".
GMaps.Instance.Mode = AccessMode.CacheOnly; 

## 📌 Features
- **Complete Turkey** map data
- **Optimized for offline usage**
- **Fully compatible** with **GMap.NET**
- **Fast access** with no lag
- **Zoom range: 7 - 16** (From broad overview to detailed street-level maps)

## 📥 Installation & Usage
1. Add the **GMap.NET** library to your project.
2. Download the `Turkey.gmdb` file from this repository.
3. Set the **cache database path** in **GMap.NET** settings:
   ```csharp
   GMaps.Instance.Mode = AccessMode.ServerAndCache;
   MainMap.CacheLocation = @"C:\Path\To\Turkey.gmdb";
   ```
4. **Enjoy seamless mapping!** 🚀

## 📌 License & Contribution
This project is open-source; feel free to use and contribute. **We welcome your support!** 😊
