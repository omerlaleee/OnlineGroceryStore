# OnlineGroceryStore

Ürünlerin admin tarafından yönetildiği ve tüm kullanıcılar tarafından satın alındığı, tüm işlemlerin veritabanına kaydının tutulduğu bu ödevde varlıklarımızı ve bu varlıkların veritabanında gerçekleşecek işlemlerini programlama ilkelerinden birisi olan Single Responsibility Principle (= Her sınıfın, o programın tek bir parçası üzerinde sorumluluğa sahip olması gerekliliği.) ilkesi altında klasörlere ayırdık. Bu klasörler;

# Entities Klasörü
	
İçerisinde projenin varlıkları olan, aynı zamanda veritabını tablolarını temsil eden Product, User ve ShoppingCart sınıflarını ve uygulama başlatıldığında Login olan kullanıcının bilgilerini tutan, içerisinde Singleton Design Pattern kullandığımız Logined User sınıfını bulunduran klasördür.

![image](https://user-images.githubusercontent.com/58256256/159504278-6efecc3e-fc06-4dd3-be6b-b1289bb29c1d.png)
