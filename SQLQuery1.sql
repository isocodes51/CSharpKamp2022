--select * from Customers
--select Address from Customers
--select ContactName Adı,CompanyName ŞirketAdı, City Şehir from Customers
--Select * from Customers where City='London'
--Select * from Products where CategoryID=1 or CategoryID=3
--Select * from Products where CategoryID=1 and UnitPrice >= 10
--select * from products where CategoryID=1 order by UnitPrice desc
--select count(*) Adet from Products
--select categoryId, count(*) from Products group by CategoryID
--select count(*) from products group by CategoryID

--içerisinde 10 adetten az ürün çeişidi olan kategorileri gösster
--select categoryId, count(*) from Products group by CategoryID having count(*) < 10 

--Fiyatı 20 den büyük olup içerisinde 10 adetten az ürün çeişidi olan kategorileri gösster (Önce Where çalışır unutma!!)
--select categoryId, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10 

--join birleştirmek demek
--Ürünlerden fiyatı 10 dan büyük olanlar için ürünleri kategori ismi ile join et (birleştir) ve göster
  --select Products.ProductID, products.ProductName,products.UnitPrice, Categories.CategoryName 
   --from Products inner join Categories
   --on Products.CategoryID = Categories.CategoryID
   --where Products.UnitPrice >10

--hiç satış yapamadığımız ürünleri göster (solda olup sağda olmayanları da getir)
  --select * from products p left join [Order Details] od on p.ProductID = od.ProductID

--hem join olanları hem de customer tablosunda olup orders tablosunda olmayanları da getir (Her ikisi birden)
  --select * from customers c left join orders o on c.CustomerID =o.CustomerID

--sisteme kayıt olmuş ama bizden hiç ürün almamış kişileri getir
  --select * from customers c left join orders o on c.CustomerID =o.CustomerID where o.CustomerID is null
--null "is" ile göterilir
-- is null olayını her zaman primary Key'e uygularız.

--ikiden fazla tabloyu join etmek için
  --select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o
   --on o.OrderID = od.OrderID
--ne kadar çok tablo eklemek istersen sonuna "inner join" ekledikten sonra tablodaki eşitlenecek yeri yaz
--DTO Data Tranformation Object

--select sum(Products) from products

CREATE PROCEDURE SelectAllCustomers
AS
SELECT * FROM Customers
GO;