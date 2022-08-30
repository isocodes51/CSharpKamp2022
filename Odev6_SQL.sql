select p.ProductName as 'Ürün Adı', 
sum(od.UnitPrice*od.Quantity) as 'Toplam Kazanç Miktarı'
from (([Order Details] as od
inner join Products as p on p.ProductID=od.ProductID)
inner join Orders as o on o.OrderID=od.OrderID)
group by p.ProductName
order by sum(od.UnitPrice*od.Quantity)  desc
