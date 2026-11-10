\# 3D Top Toplama Oyunu



\## Proje Hakkında

Bu proje, Unity oyun motoru ve C# programlama dili kullanılarak geliştirilmiş 3 boyutlu bir top toplama oyunudur.



Oyuncu, sahnedeki topu klavye tuşlarıyla kontrol eder. Amaç yeşil topları toplayarak puan kazanmak, kırmızı toplardan kaçınmak, engellerin üzerinden zıplamak ve en az 50 puana ulaşarak bitiş alanına varmaktır.



\## Oyun Kontrolleri

\- W: İleri hareket

\- S: Geri hareket

\- A: Sola hareket

\- D: Sağa hareket

\- Yön tuşları: Hareket

\- Space: Zıplama



\## Puanlama Sistemi

\- Yeşil top: +10 puan

\- Kırmızı top: -5 puan

\- Bitiş alanına ulaşmak için en az 50 puan gereklidir.

\- 50 puana ulaşılmadan bitiş alanına girilirse oyun devam eder.

\- 50 veya daha fazla puanla bitiş alanına girildiğinde sahne yeniden yüklenir ve oyun baştan başlar.



\## Kullanılan Scriptler



\### PlayerController.cs

Oyuncu hareketlerini, zıplama sistemini ve puan takibini yönetir. Rigidbody kullanarak fizik tabanlı hareket sağlar. Oyuncunun puanını ekranda gösterir.



\### Collectible.cs

Toplanabilir nesnelerin puan değerlerini yönetir. Oyuncu yeşil veya kırmızı bir topla temas ettiğinde puanı günceller ve toplanan nesneyi sahneden kaldırır.



\### FinishZone.cs

Oyuncunun bitiş alanına ulaşıp ulaşmadığını kontrol eder. Oyuncunun puanı 50 veya üzerindeyse mevcut sahneyi yeniden yükler.



\## Kullanılan Unity Özellikleri

\- Rigidbody

\- AddForce

\- Update ve FixedUpdate

\- OnTriggerEnter

\- OnCollisionEnter ve OnCollisionExit

\- CompareTag

\- GetComponent

\- Destroy

\- SceneManager.LoadScene

\- TextMeshPro



\## Sonuç

Proje kapsamında oyuncu hareketi, zıplama, puan toplama, engeller ve puana bağlı bitiş sistemi gerçekleştirilmiştir. Oyun test edilmiş ve temel işlevlerinin doğru çalıştığı kontrol edilmiştir.

