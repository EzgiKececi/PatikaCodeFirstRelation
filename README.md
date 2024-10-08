# Patika Code First Projesi

Bu proje, Entity Framework Core kullanarak Code First yaklaşımı ile bir veritabanı ve ilişkiler oluşturmayı amaçlamaktadır. Proje, kullanıcılar ve onların gönderileri arasındaki ilişkiyi yönetmek için bir API geliştirmektedir.

## Proje İçeriği

### Veritabanı Modelleri

#### User Tablosu

- **Id**: `int`, birincil anahtar ve otomatik artan.
- **Username**: `string`, kullanıcının kullanıcı adı.
- **Email**: `string`, kullanıcının e-posta adresi.

#### Post Tablosu

- **Id**: `int`, birincil anahtar ve otomatik artan.
- **Title**: `string`, gönderinin başlığı.
- **Content**: `string`, gönderinin içeriği.
- **UserId**: `int`, gönderinin yazarı (kullanıcının kimliği).

### İlişkiler

- Bir kullanıcı (User) birden fazla gönderiye (Post) sahip olabilir.
- Her gönderi (Post) yalnızca bir kullanıcıya aittir.

## Proje Yapısı

- **Context Sınıfı**: `PatikaSecondDbContext` adında bir sınıf, veritabanı bağlantısını ve DbSet tanımlarını içerir.
- **Entities**: UserEntity ve PostEntity sınıfları, kullanıcı ve gönderi modellerini temsil eder.
- **Controllers**: Kullanıcı ve gönderi işlemlerini yönetmek için `UserController` ve `PostController` sınıfları bulunmaktadır.
