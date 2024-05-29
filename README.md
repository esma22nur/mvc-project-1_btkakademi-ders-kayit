
**BTK Akademi Ders Seçimi Formu Raporu**

**1. Giriş**

BTK Akademi, öğrencilerine geniş bir ders yelpazesi sunmak amacıyla çeşitli eğitim programları düzenlemektedir. Öğrenciler, bu programlardan birine kaydolmak ve ders seçimini yapmak için çevrimiçi bir form kullanabilirler.BTK Akademi'nin ders seçimi için geliştirilen MVC tabanlı formunun detaylı bir açıklamasını sunmaktadır.

---

**2. Form Özellikleri**

- **E-posta Adresi (email):** Öğrencinin iletişim için kullandığı e-posta adresi. Bu alan zorunludur ve geçerli bir e-posta adresi girmesi gerekmektedir.

- **Ad (name):** Öğrencinin adı. Bu alan zorunludur ve en az bir karakter içermelidir.

- **Soyad (lastname):** Öğrencinin soyadı. Bu alan zorunludur ve en az bir karakter içermelidir.

- **Yaş (age):** Öğrencinin yaşını belirten sayısal bir değer.

- **Seçilen Ders (selectedcourse):** Öğrencinin katılmak istediği dersin adı veya kodu.

- **Başvuru Tarihi (applyat):** Öğrencinin başvuru tarihini belirten bir tarih ve saat.

---

**3. Formun İşlevselliği**

- Form, MVC (Model-View-Controller) mimarisi kullanılarak geliştirilmiştir. Model kısmında öğrenci bilgilerini temsil eden bir sınıf tanımlanmıştır.
- Controller, formun sunulduğu sayfayı yönetir ve kullanıcıdan gelen verileri işler.
- View, formun HTML tabanlı görsel tasarımını içerir ve kullanıcıyla etkileşim sağlar.

---

**4. Örnek Senaryo**

Bir öğrenci, BTK Akademi web sitesine giriş yapar ve ders seçimi formunu doldurur. Formda istenilen bilgileri eksiksiz bir şekilde girer ve "Gönder" düğmesine basar. Sunucu, gönderilen bilgileri doğrular ve başarılı bir şekilde işler. Öğrenci, ders seçim işleminin tamamlandığına dair bir onay mesajı alır.

