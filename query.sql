CREATE TABLE Products (
                          Id INT PRIMARY KEY,
                          "Name" TEXT
);

INSERT INTO Products
VALUES
    (1, 'Apples'),
    (2, 'Milk'),
    (3, 'Tomato');

CREATE TABLE Categories (
                            Id INT PRIMARY KEY,
                            "Name" TEXT
);

INSERT INTO Categories
VALUES
    (1, 'Fruits'),
    (2, 'Dairy_produce'),
    (3, 'Vegetables');

CREATE TABLE ProductCategories (
                                   ProductId INT FOREIGN KEY REFERENCES Products(Id),
                                   CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
                                   PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
    (1, 1),
    (2, 2),
    (3, 3);

SELECT P."Name" as ProductName, C."Name" as CategoryName
FROM Products P
         LEFT JOIN ProductCategories PC
                   ON P.Id = PC.ProductId
         LEFT JOIN Categories C
                   ON PC.CategoryId = C.Id;