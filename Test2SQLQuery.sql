GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[category_id] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO


Insert INTO Category(Name) Values ('Категория1');
Insert INTO Category(Name) Values ('Категория2');
Insert INTO Category(Name) Values ('Категория3');
Insert INTO Category(Name) Values ('Категория4');

Insert INTO Products(Name,category_id) Values ('Продукт1',1);
Insert INTO Products(Name,category_id) Values ('Продукт2',2);
Insert INTO Products(Name,category_id) Values ('Продукт3',2);
Insert INTO Products(Name,category_id) Values ('Продукт4',3);
Insert INTO Products(Name,category_id) Values ('Продукт5',3);
Insert INTO Products(Name,category_id) Values ('Продукт6',1);
Insert INTO Products(Name,category_id) Values ('Продукт7',2);
Insert INTO Products(Name,category_id) Values ('Продукт8',1);
Insert INTO Products(Name,category_id) Values ('Продукт9',4);
Insert INTO Products(Name,category_id) Values ('Продукт1',null);
Insert INTO Products(Name,category_id) Values ('Продукт1',null);

SELECT dbo.Category.Name, dbo.Products.Name 
FROM  dbo.Products LEFT JOIN dbo.Category ON dbo.Category.Id = dbo.Products.category_id 
