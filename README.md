# ShapesLibrary
1. Непонятно из условия как обрабатывать double.maxValue, поэтому для площади в этом случае было выбрано значение infinity

# Задание 2
CREATE TABLE Product 
(
	Id     int,
    "Name" text,
    primary key (Id)
); 

CREATE TABLE Category 
(
	Id     int, 
    "Name" text,
    primary key (Id)
); 

CREATE TABLE ProductCategory (
	ProductId INT,
	CategoryId INT,
	primary key (ProductId, CategoryId),
	foreign key (ProductId) references Product(Id),
	foreign key (CategoryId) references Category(Id)
);

SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC ON P.Id = PC.ProductId
LEFT JOIN Category		  C  ON PC.CategoryId = C.Id;
