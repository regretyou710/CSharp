alter procedure uspProduct
@pid as integer
as
select p.ProductID,p.[Name],p.ListPrice from Production.Product as p
where p.ProductID < @pid