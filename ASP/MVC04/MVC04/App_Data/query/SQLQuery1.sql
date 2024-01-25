

CREATE TABLE tblProducts  (
  ProductID INT IDENTITY(1,1) PRIMARY KEY,
  ProductName NVARCHAR(255) NOT NULL,
  ImageURL VARCHAR(255),
  ProductPrice DECIMAL(10, 2) NOT NULL,
  Description NVARCHAR(255)
);

DROP TABLE tblProducts;

-- Thêm dữ liệu vào bảng
INSERT INTO tblProducts (ProductName, ImageURL, ProductPrice, Description)
VALUES
    ('Sản phẩm 1', 'http://example.com/image1.jpg', 19.99, 'Mô tả sản phẩm 1'),
    ('Sản phẩm 2', 'http://example.com/image2.jpg', 29.99, 'Mô tả sản phẩm 2'),
    ('Sản phẩm 3', 'http://example.com/image3.jpg', 39.99, 'Mô tả sản phẩm 3'),
    ('Sản phẩm 4', 'http://example.com/image4.jpg', 49.99, 'Mô tả sản phẩm 4'),
    ('Sản phẩm 5', 'http://example.com/image5.jpg', 59.99, 'Mô tả sản phẩm 5');

GO
CREATE PROCEDURE ThemSanPham
    @p_ProductName NVARCHAR(255),
    @p_ImageURL NVARCHAR(255),
    @p_ProductPrice DECIMAL(10, 2),
    @p_Description NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO TenBang (ProductName, ImageURL, ProductPrice, Description)
    VALUES (@p_ProductName, @p_ImageURL, @p_ProductPrice, @p_Description);
END;
GO

select * from tblProducts