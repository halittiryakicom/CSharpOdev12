using CSharpOdev12;

Person teacher = new Person();
teacher.Name = "Halit";
teacher.Surname = "Tiryaki";
teacher.BirthDate = new DateTime(1997, 3, 22);
teacher.Information();

Person ogrenci1 = new Person();
ogrenci1.Name = "Hamza";
ogrenci1.Surname = "Tiryaki";
ogrenci1.BirthDate = new DateTime(2008, 2, 29);
ogrenci1.Information();

Person ogrenci2 = new Person();
ogrenci2.Name = "Mehmet";
ogrenci2.Surname = "Bodur";
ogrenci2.BirthDate = new DateTime(2000, 7, 13);
ogrenci2.Information();

Person ogrenci3 = new Person();
ogrenci3.Name = "Ahmet";
ogrenci3.Surname = "Çağlayan";
ogrenci3.BirthDate = new DateTime(2005, 12, 30);
ogrenci3.Information();