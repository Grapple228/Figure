Drop table if exists CategoriesAndProducts;
Drop table if exists Products;
Drop table if exists Categories;

Create Table Products(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null
);
Create Table Categories(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null
);
Create Table CategoriesAndProducts(
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id),
	Primary key (ProductId, CategoryId)
);

insert into Products(Name) 
Values 
('Product1'),
('Product2'),
('Product3'),
('Product4');

insert into Categories(Name) 
Values 
('Category1'),
('Category2'),
('Category3');

insert into CategoriesAndProducts(ProductId, CategoryId) 
Values 
(1,1),
(2,2),
(2,3),
(3,1),
(3,3);

Select Products.Id, Products.Name, Categories.Id, Categories.Name
from Products
left join CategoriesAndProducts
on Products.Id = CategoriesAndProducts.ProductId
left join Categories
on CategoriesAndProducts.CategoryId = Categories.Id;

