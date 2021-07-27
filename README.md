# Tren Rezervasyon API Projesi

Rezervasyon istenilen trenin bilgileri, vagon ayrıntıları, kaç kişilik rezervasyon istenildiği ve kişilerin farklı vagonlara yerleştirilip yerleştirilemeyeceği bilgilerini içeren bir post isteği attığımızda rezervasyon yapılıp yapılamayacağını ve yapılabiliyorsa rezervasyonla ilgili bilgileri geri döndüren bir API geliştirildi.  .NET CORE kullanılarak katmanlı mimariye göre geliştirildi ve  Swagger ile API dökümantasyonu hazırlandı.
<br>
## Nasıl kullanılır
- Rezervasyon yapılıp yapılamayacağını sorgulamak için  **/api/Rezervasyon**  endpointine, gövdesinde gerekli bilgileri içeren bir **POST** isteği atılmalıdır.
- API dökümantasyonunu görmek için **/swagger** endpointine tarayıcı üzerinden **GET** isteği atabilirsiniz.

## Postman ve Swagger ekran görüntüleri

![Postman 1](https://user-images.githubusercontent.com/51864835/127169914-752b8836-1e9e-4bf9-abb7-6e1e2f529701.png)
![Postman 2](https://user-images.githubusercontent.com/51864835/127170019-b0edc4cf-c37b-4dee-bd96-d5c24287f524.png)
![Swagger](https://user-images.githubusercontent.com/51864835/127169974-07ff2b25-d7e7-4c9f-b811-8a9851421429.png)
