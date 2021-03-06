CREATE DATABASE [OnlineGroceryStore]
GO

USE [OnlineGroceryStore]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3.06.2021 17:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[Image] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCarts]    Script Date: 3.06.2021 17:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCarts](
	[UserId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3.06.2021 17:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ProfilePhoto] [varchar](max) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](13) NOT NULL,
	[UserType] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (1, N'Cake', 35, N'Cake Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\cake.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (2, N'Chocolate', 2, N'Chocolate Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\chocolate.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (3, N'Salt', 4.75, N'Salt Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\salt.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (4, N'Tomato Paste', 38.9900016784668, N'Tomato Paste Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\tomatoPaste.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (5, N'Pasta', 6.5, N'Pasta Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\pasta.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (6, N'Gum', 1, N'Gum Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\gum.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (7, N'Toy', 27.889999389648438, N'Toy Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\toy.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (8, N'Meat', 75, N'Meat Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\meat.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (9, N'Hurma', 40, N'Hurma Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\hurma.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (10, N'Baking Powder', 3.4900000095367432, N'Baking Powder Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\powder.png')
INSERT [dbo].[Products] ([Id], [ProductName], [Price], [Description], [Image]) VALUES (16, N'Gum2', 2, N'Gum2 Description', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\productImages\gum.png')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2006, 1, 1)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2006, 8, 2)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2006, 9, 1)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2006, 4, 2)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2005, 3, 1)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2005, 6, 2)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2005, 2, 1)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2005, 7, 1)
INSERT [dbo].[ShoppingCarts] ([UserId], [ProductId], [Amount]) VALUES (2005, 10, 3)
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [ProfilePhoto], [Address], [PhoneNumber], [UserType]) VALUES (2005, N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\userImages\admin.png', N'Eskisehir', N'+902223456789', 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [ProfilePhoto], [Address], [PhoneNumber], [UserType]) VALUES (2006, N'omer', N'3295c76acbf4caaed33c36b1b5fc2cb1', N'C:\Users\omer_\OneDrive\Masaüstü\SQL\OnlineGroceryStore\OnlineGroceryStore\Resources\userImages\omer.png', N'Yozgat', N'+905412345678', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_Products]
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_Users]
GO
