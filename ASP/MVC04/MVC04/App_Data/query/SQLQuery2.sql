CREATE TABLE tblProducts  (
  ProductID INT IDENTITY(1,1) PRIMARY KEY,
  ProductName NVARCHAR(255) NOT NULL,
  ImageURL VARCHAR(255),
  ProductPrice DECIMAL(10, 2) NOT NULL,
  Description NVARCHAR(255),
);

DROP TABLE tblProducts;

-- Thêm dữ liệu vào bảng
INSERT INTO tblProducts (ProductName, ImageURL, ProductPrice, Description)
VALUES
    ('Product 1', '/App_Data/img/5559315828_2_6_1-401x512.jpg', 19.99, 'Description 1'),
    ('Product 2', '/App_Data/img/5559315828_2_6_1-401x512.jpg', 29.99, 'Description 2'),
    ('Product 3', '/App_Data/img/5559315828_2_6_1-401x512.jpg', 39.99, 'Description 3'),
    ('Product 4', '/App_Data/img/5559315828_2_6_1-401x512.jpg', 49.99, 'Description 4'),
    ('Product 5', '/App_Data/img/5559315828_2_6_1-401x512.jpg', 59.99, 'Description 5');
