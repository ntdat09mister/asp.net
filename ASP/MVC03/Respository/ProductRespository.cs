using System;
using System.Collections.Generic;
using System.Linq;

public class ProductRepository
{
    private List<ProductModel> _products;

    public ProductRepository()
    {
        //10 sản phẩm
        _products = new List<ProductModel> {
            new ProductModel {
                ProductID = 1,
                ProductName = "Product 1",
                ImageURL = "https://www.investopedia.com/thmb/DrTUqTdioD2ZougTouHbhrr9ho8=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Term-Definitions_Product-Line-Final-58870113a3ca4770a85cabf3549894bb.jpg",
                ProductPrice = 500,
                Description = "Description 1"
            },
            new ProductModel {
                ProductID = 2,
                ProductName = "Product 2",
                ImageURL = "https://www.shopbase.com/blog/wp-content/uploads/2022/05/winning-product-la-gi-1-1024x576.jpg",
                ProductPrice = 500,
                Description = "Description 2"
            },
            new ProductModel {
                ProductID = 3,
                ProductName = "Product 3",
                ImageURL = "https://cdn.vietnammoi.vn/2019/8/15/product-review-writing-services-15658537611611796432875.jpg",
                ProductPrice = 500,
                Description = "Description 3"
            },
            new ProductModel {
                ProductID = 4,
                ProductName = "Product 4",
                ImageURL = "https://www.shipbob.com/wp-content/uploads/2022/06/PRODUCT-RANGE.jpg",
                ProductPrice = 500,
                Description = "Description 4"
            },
            new ProductModel {
                ProductID = 5,
                ProductName = "Product 5",
                ImageURL = "https://d3hjf51r9j54j7.cloudfront.net/wp-content/uploads/sites/7/2019/05/Product-of-the-Year.jpg",
                ProductPrice = 500,
                Description = "Description 5"
            },
            new ProductModel {
                ProductID = 6,
                ProductName = "Product 6",
                ImageURL = "https://emeritus.org/wp-content/uploads/2022/08/Featured-Image-33.png",
                ProductPrice = 500,
                Description = "Description 6"
            },
            new ProductModel {
                ProductID = 7,
                ProductName = "Product 7",
                ImageURL = "https://payu.in/blog/wp-content/uploads/2018/06/product_pricing_coverimage.png",
                ProductPrice = 500,
                Description = "Description 7"
            },
            new ProductModel {
                ProductID = 8,
                ProductName = "Product 8",
                ImageURL = "https://www.simplilearn.com/ice9/free_resources_article_thumb/What_Product_Market_Fit.jpg",
                ProductPrice = 500,
                Description = "Description 8"
            },
            new ProductModel {
                ProductID = 9,
                ProductName = "Product 9",
                ImageURL = "https://enterpriseleague.com/blog/wp-content/uploads/product-store.jpg",
                ProductPrice = 500,
                Description = "Description 9"
            },
            new ProductModel {
                ProductID = 10,
                ProductName = "Product 10",
                ImageURL = "https://glints.com/vn/blog/wp-content/uploads/2022/10/Product-Owner-La-Gi-Co-Hoi-Viec-Lam-Product-Owner-Tai-Viet-Nam.jpg",
                ProductPrice = 500,
                Description = "Description 10"
            }


        };
    }

    public List<ProductModel> GetProducts()
    {
        return _products;
    }

    public ProductModel? GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.ProductID == id);
    }

}
