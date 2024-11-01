# Netflix Mikroservis Projesi

Netflix Mikroservis Projesi, dizileri sezon sezon ve bölüm bölüm listeleyen bir sistemdir. Bu proje, kullanıcılara geniş bir dizi veritabanına erişim sağlar ve her bir bölüm için dil desteği sunar. Proje, **ASP.NET Core 8.0** kullanılarak geliştirilmiştir.

## Kullanılan Teknolojiler ve Uygulamalar 🤖

- **ASP.NET Core 8.0**: Web uygulamasının temel çerçevesi olarak kullanıldı. ✅
- **Docker**: PostgreSQL ve MSSQL veritabanları için konteyner yönetimi sağlandı. ✅
- **PostgreSQL ve MSSQL**: Veritabanı yönetimi ve depolama için kullanıldı. ✅
- **Ocelot API Gateway**: Mikroservislerin yönetimi ve yönlendirilmesi için kullanıldı. ✅
- **SOLID Prensipleri**: Proje, SOLID prensiplerine uygun olarak geliştirilmiştir. ✅
- **DTO Yapıları**: Verilerin taşınması ve işlenmesi için kullanıldı. ✅

## Proje Özellikleri

- **Dizi Listeleme**: Kullanıcılar dizileri sezon ve bölüm bazında listeleyebilirler. ✅
- **Bölüm Başına Dil Desteği**: Her bölüm için farklı dillerin desteği sağlandı. ✅
- **Dizilere Yorum Yapma**: Kullanıcılar dizilere yorum yapabilir, bu sayede etkileşim artırılmıştır. ✅
- **Mikroservis Mimarisi**: Servislerin monolitik yapıda yazılmasıyla hızlı ve etkili bir sistem oluşturuldu. ✅
- **Mikroservisler Arası İletişim**: Mikroservisler arasında etkili bir iletişim sağlanmıştır. Bu iletişim, projenin mikroservis mimarisi kullanılarak yapılandırılmasından kaynaklanmaktadır. Her mikroservis belirli bir işlevi yerine getirirken, ihtiyaç duyduğu verileri diğer mikroservislerden alarak işlem yapabilmektedir.

- **API Entegrasyonu**: Harici API'ler consume edilerek veri alınabilir. ✅

Bu yapıyla, projemiz hem verimli hem de yönetilebilir bir mikroservis mimarisi sunmaktadır.
