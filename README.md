# OnlineGroceryStore

Ürünlerin admin tarafından yönetildiği ve tüm kullanıcılar tarafından satın alındığı, tüm işlemlerin veritabanına kaydının tutulduğu bu ödevde varlıklarımızı ve bu varlıkların veritabanında gerçekleşecek işlemlerini programlama ilkelerinden birisi olan Single Responsibility Principle (= Her sınıfın, o programın tek bir parçası üzerinde sorumluluğa sahip olması gerekliliği.) ilkesi altında klasörlere ayırdık. Bu klasörler;

# Entities Klasörü
![image](https://user-images.githubusercontent.com/58256256/159504278-6efecc3e-fc06-4dd3-be6b-b1289bb29c1d.png)

İçerisinde projenin varlıkları olan, aynı zamanda veritabını tablolarını temsil eden Product, User ve ShoppingCart sınıflarını ve uygulama başlatıldığında Login olan kullanıcının bilgilerini tutan, içerisinde Singleton Design Pattern kullandığımız Logined User sınıfını bulunduran klasördür. 

Abstacts ve Concretes olarak ikiye ayrılır. Abstracts içerisinde Product, User ve ShoppingCart sınıflarının veritabını tablolarını temsil etmesi ortaklığı nedeniyle IEntity interface’i bulunur. İçerisinde herhangi bir operasyon bulundurmamasına rağmen bu interface’i eklememizin amacı yazılımda sürdürülebilirlik önlemlerini almaktır. 

Concretes klasörü ise soyut sınıfların bulunduğu klasördür.

# DataAccessLayer Klasörü
![image](https://user-images.githubusercontent.com/58256256/159504672-46379547-a769-4902-a919-c5433a5be147.png)

Bu klasör yukarıda bulunan, projenin her bir varlığının ayrı ayrı veritabını işlemlerini metotlar halinde tutan klasördür. Entities klasörü gibi Abstracts ve Concretes olmak üzere 2 klasörden oluşur. Aynı mantıkta soyut sınıflar (interface’ler, abstract sınıflar vb.) abstacts klasörü içerisinde, abstract sınıfları implement eden somut sınıflar concretes klasörü içerisinde yer alır.

Bu klasöre başlarken, proje içerisinde veritabanı tablolarını temsil eden Product, User ve ShoppingCart sınıflarının hepsi için CRUD (create, read, update, delete) operasyonları yapılacağı için bu operasyonların ortaklığı nedeniyle Abstract klasörü içerisine IRepositoryDal adında bir templete interface sınıf oluşturduk. 

![image](https://user-images.githubusercontent.com/58256256/159504719-d2afd75d-cc9c-4d2e-b398-f229728523ff.png)
IRepositoryDal Template Interface Sınıfı

DataAccessLayer/Abstracts klasörü içerisinde geri kalan I(Entity)Dal isimli 3 sınıf ise bu template interface’i implement eden, ve içerilerinde kendilerine özgü metotları barındıran interface’lerdir.  

DataAccessLayer/Concretes klasörü içerisindeki (Entity)ManagerDal isimli 3 sınıf yukarıdaki I(Entity)Dal isimli 3 sınıf’ı implement eden ve ayrı ayrı herbirinin içindeki metotların görevini yapacak kodları barındıran sınıflardır.

DataAccessLayer/Concretes klasörü içerisinde ayrı olarak DatabaseConnectionManager isimli bir sınıf bulunur ve bu sınıf veritabanına bağlanma ve bağlantıyı kesme işlemlerini yapan sınıftır. Bu sınıf (Entity)ManagerDal isimli dosyalar içerisinde gerektiği yerde veritabanına ulaşmak amacıyla kullanılır.

# Core Klasörü

![image](https://user-images.githubusercontent.com/58256256/159504815-317d9ae0-26a2-41f6-8b96-82d927e1d1c5.png)

İçerisinde çok fazla sınıf veya metot barındırmasa da bu projede kullanılan ve herhangi bir .Net projesinde de aynen bu şekilde Plug and Play ilkesiyle çalışabilecek kodları içeren, proje içerisinde bir framework gibi bize yardım eden fonksiyonların olduğu sınıfları bulunduran klasördür.

# Resources Klasörü

![image](https://user-images.githubusercontent.com/58256256/159504903-2af50b29-e3f6-4ece-8907-b73ac1496419.png)

Projede kullanılan ürün resmi, kullanıcı resmi, ikonlar ve formların arka plan görüntüleri gibi resim dosyalarının içerisinde bulunduruğu klasördür.

# Forms Klasörü

![image](https://user-images.githubusercontent.com/58256256/159504958-5e0f2783-d01e-49b5-8d9b-80c3d2341a6b.png)

Bu .Net Form Uygulamasının formlarını içeren klasördür.

# Proje Özellikleri

* Kullanıcı kayıt ekranında kayıt yaparken girdiği şifre, veritabınında MD5 algoritmasına göre Hash’lenmiş bir biçimde tutulur.
* Aynı kullanıcı adına sahip bir başka kullanıcı oluşturulamaz.
* Admin girişi ile müşteri girişi birbirinden farklıdır. Müşteri, ürünlerin özelliklerinin değiştirilebileceği forma erişemez.
* Admin tarafından bir ürün silindiği anda, o ürünün bulunduğu sepetlerin tamamından o ürün de çıkarılır.
* Kullanıcı alışverişini tamamladığında ekranda bir fatura formu çıkar ve o anda sepetteki ürünler veritabanından silinir. Kullanıcı fatura ekranından sonra tekrar mağaza ekranına yönlendirilir.
* Kullanıcı sepet ekranında ürünlerin miktarını arttırabilir, azaltabilir veya tamamen sepetten çıkarabilir. Tüm bu işlemler anında veritabanındaki ShoppingCart tablosuna ve arayüzde kullanıcıya gösterilen Total Payment miktarına etki eder.

# İş Yükü

Ömer Faruk LALE - %25

Mesut KIZILAY - %25	

Ezgi ÖZDİKYAR - %25	

Ahmet Halim UZUN - %25	

# Proje Görüntüleri

![image](https://user-images.githubusercontent.com/58256256/159505135-1bd142d7-7567-4886-b26c-8b9c4323f18a.png)

Giriş Formu

![image](https://user-images.githubusercontent.com/58256256/159505169-1820a944-4482-4217-92dc-7b4206408b6e.png)

Kayıt Formu

![image](https://user-images.githubusercontent.com/58256256/159505219-ff591999-f022-477a-98f8-db132089609a.png)

Admin Ana Menu ve Mağaza Ekranı

![image](https://user-images.githubusercontent.com/58256256/159505255-b35c2375-0b36-4b87-b097-dc5b14a2ccb3.png)

Mağazada Ürün Fotoğrafına Basıldığında Ürün Özelliklerini Gösteren Ekran

![image](https://user-images.githubusercontent.com/58256256/159505293-48c9edb4-48d2-458c-9da9-6dc1a6fb5495.png)

Sepetim Ekranı

![image](https://user-images.githubusercontent.com/58256256/159505317-573015f7-99ff-4e3e-b9d6-4cc4a489dbfe.png)

Alışveriş Tamamlandığında Gelen Fatura Ekranı

![image](https://user-images.githubusercontent.com/58256256/159505343-60057811-54a6-42ce-8352-427e8c40fd96.png)

Admin Girişine Özel Ayarlar Formu

![image](https://user-images.githubusercontent.com/58256256/159505373-59d99595-44b2-4014-b2af-a46521787122.png)

Müşteri Girişi (Ayarlar Sekmesi Gizli)

![image](https://user-images.githubusercontent.com/58256256/159505405-3ef37ade-6e6a-433c-9358-d105f293b778.png)

Profilim Ekranı

# Veritabanı Görüntüleri
![image](https://user-images.githubusercontent.com/58256256/159505459-df5a4f14-ff45-4121-9d5a-4933b9678c42.png)
Veritabanı Tabloları İlişkisi
![image](https://user-images.githubusercontent.com/58256256/159505487-9c70119f-32a3-42cb-a44d-4a992401cc27.png)
Ürünler Tablosu
![image](https://user-images.githubusercontent.com/58256256/159505517-6a9ff897-aa33-4851-a26b-c0dcf0b35121.png)
Kullanıcılar Tablosu

 <p align = "center">
  <img src="https://user-images.githubusercontent.com/58256256/159505538-3f0bee1d-c0fc-4777-9928-2404ef325fdc.png">
</p>  

![image](https://user-images.githubusercontent.com/58256256/159505538-3f0bee1d-c0fc-4777-9928-2404ef325fdc.png)
Sepette Bulunan Ürünler Tablosu
