select P.ProductName, C.CategoryName
from Product P
left join (ProductCategory PC
join Category C on C.CategoryID = PC.CategoryID) on P.ProductID = PC.ProductID
group by P.ProductName, C.CategoryName