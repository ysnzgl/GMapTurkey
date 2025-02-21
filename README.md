GMap.NET Türkiye Harita Önbelleği (Cache) Veritabanı

📌 Açıklama (Description)

Bu repo, GMap.NET için Tüm Türkiye'nin harita verilerini içeren bir GMDB önbelleğini sunar. Bu sayede çevrimdışı kullanım için tüm Türkiye harita verilerine hızlı bir şekilde erişebilirsiniz. Özellikle GIS projelerinde, navigasyon uygulamalarında ve offline harita sistemlerinde kullanışlıdır.

This repository provides a GMDB cache database containing all Turkey map data for GMap.NET. This allows fast access to offline map data for Turkey. It is particularly useful for GIS projects, navigation applications, and offline mapping systems.

🌍 Özellikler (Features)

✅ Tam Türkiye haritasını kapsar. ✅ Çevrimdışı kullanım için uygundur. ✅ Hızlı erişim ve düşük gecikme süresi. ✅ GMap.NET ile uyumlu. ✅ Açık kaynak ve ücretsiz kullanım.

✅ Covers the entire map of Turkey. ✅ Suitable for offline usage. ✅ Fast access and low latency. ✅ Compatible with GMap.NET. ✅ Open-source and free to use.

📥 Kurulum ve Kullanım (Installation & Usage)

1️⃣ GMDB Dosyasını İndirin (Download GMDB File)

Repo içindeki turkey-map-cache.gmdb dosyasını indirin.

Download the turkey-map-cache.gmdb file from this repository.

2️⃣ GMap.NET ile Kullanım (Using with GMap.NET)

GMap.NET projelerinizde GMDB veritabanını kullanmak için aşağıdaki adımları izleyin:

Follow these steps to use the GMDB database in your GMap.NET projects:

GMapProvider.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)";
GMaps.Instance.Mode = AccessMode.CacheOnly;
gMapControl1.CacheLocation = @"C:\your_cache_path";

Dosyanın yolunu gMapControl1.CacheLocation olarak belirleyin. Set the path of the file in gMapControl1.CacheLocation.

🛠 Gereksinimler (Requirements)

.NET Framework / .NET Core

GMap.NET

Windows / Linux / macOS

📜 Lisans (License)

Bu proje MIT Lisansı ile lisanslanmıştır.

This project is licensed under the MIT License.

🙌 Katkıda Bulunun (Contribute)

Geliştirmeler ve yeni veri eklemeleri için katkılarınızı bekliyoruz! Pull request'lerinizi gönderebilirsiniz.

We welcome contributions for improvements and new data additions! Feel free to submit pull requests.

📧 İletişim (Contact)

Sorularınız veya önerileriniz için email@example.com adresinden bana ulaşabilirsiniz.

For questions or suggestions, you can contact me at email@example.com.

🚀 Harita verileri ile daha güçlü projeler geliştirin!

🚀 Build stronger projects with map data!

