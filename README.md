# PolymorphismPratik

Bu proje, **Polymorphism (Çok Biçimlilik)** prensibini kullanarak `Kare`, `Dikdörtgen` ve `Dik Üçgen` şekillerinin alan hesaplarını ortak bir tabandan yönetir. Ortak taban sınıfı `BaseGeometrikSekil` olup, `Genislik`, `Yukseklik` özelliklerini ve tüm şekiller için geçerli `AlanHesapla()` metodunun temel davranışını içerir. `DikUcgen` sınıfı bu metodu farklı bir formülle ezerek (override) kendi alanını hesaplar.

---

## 🎯 Amaç

* Ortak özellikleri tek bir **base class** altında toplamak.
* Aynı isimli metodu farklı şekillerde **farklı davranışlarla** çalıştırmak (override).
* Polymorphism’in pratikte nasıl işlediğini net bir örnekle göstermek.

---

## 🧠 Mantık Özeti

* **BaseGeometrikSekil**: Genislik ve Yukseklik özellikleri; varsayılan alan hesabı genişlik × yükseklik.
* **Kare** ve **Dikdörtgen**: Temel formülü aynen kullanır.
* **Dik Üçgen**: Alan hesabı (genişlik × yükseklik) ÷ 2 olduğundan `AlanHesapla()` metodu **override** edilir.
* **Polymorphism Etkisi**: Aynı `AlanHesapla()` çağrısı, nesnenin gerçek tipine göre farklı sonuç üretir.

---

## 📁 Önerilen Proje Yapısı

* Program.cs
* BaseGeometrikSekil.cs
* Kare.cs
* Dikdortgen.cs
* DikUcgen.cs

> İstersen tüm sınıfları tek dosyada da toplayabilirsin; eğitim amaçlı ayrı dosyalar daha okunaklıdır.

---

## 🚀 Çalıştırma Adımları (Özet)

1. .NET versiyonunun güncel olduğundan emin ol (6 ve üzeri önerilir).
2. Yeni bir konsol projesi oluştur.
3. `BaseGeometrikSekil`, `Kare`, `Dikdortgen`, `DikUcgen` sınıflarını ekle.
4. `Main` içinde her sınıftan birer örnek oluştur; genişlik ve yükseklik değerlerini ver.
5. `AlanHesapla()` çağrılarıyla sonuçları konsola yazdır.

> Not: Komut ve kod detaylarını özellikle **eklemedik**; bu dosya kavramsal rehber olarak hazırlanmıştır.

---

## 🖨️ Örnek Çıktı (Temsili)

* Kare (G: 5, Y: 5) → Alan: 25
* Dikdörtgen (G: 4, Y: 8) → Alan: 32
* Dik Üçgen (G: 6, Y: 10) → Alan: 30

> Rakamlar örnektir; verdiğin değerlere göre değişir.

---

## 📈 Neden Bu Tasarım İyi?

* **Tek Sorumluluk**: Formül farkları sadece ilgili sınıfta tutulur.
* **Genişlemeye Açık**: Yeni bir şekil eklerken ortak yapıyı bozmadan sadece kendi davranışını tanımlarsın.
* **Bakımı Kolay**: Ortak özellikleri tek noktada yönetirsin.

---

## 🔧 Genişletme Fikirleri

* Çevre hesabı için `CevreHesapla()` metodu ekleyip her sınıfta uygun şekilde ezmek.
* Arayüz tabanlı kurguyu denemek (ör. `IGeometrikSekil`).
* Kullanıcıdan genişlik ve yükseklik değerlerini alan basit bir menü ile etkileşimli hale getirmek.

---

## 📝 Notlar

* İsimlendirmeleri Türkçe tuttuk; istersen İngilizce isimlendirme ile aynı yapıyı kurabilirsin.
* Test amaçlı farklı değerler deneyerek polymorphism etkisini gözlemleyebilirsin.
