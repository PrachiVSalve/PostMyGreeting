USE [PostMyGreetingfinal]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTable](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CartTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartTable](
	[CartId] [bigint] IDENTITY(1,1) NOT NULL,
	[CartDate] [datetime2](7) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Qty] [int] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[StoreId] [bigint] NOT NULL,
 CONSTRAINT [PK_CartTable] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoryTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTable](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CategoryTable] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CityTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTable](
	[CityId] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NOT NULL,
	[CityDescription] [nvarchar](max) NULL,
	[StateId] [bigint] NOT NULL,
 CONSTRAINT [PK_CityTable] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComplaintTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComplaintTable](
	[ComplaintId] [bigint] IDENTITY(1,1) NOT NULL,
	[CompliantDate] [datetime2](7) NOT NULL,
	[CompliantResion] [nvarchar](max) NULL,
	[ProductId] [bigint] NOT NULL,
	[OrderId] [bigint] NOT NULL,
 CONSTRAINT [PK_ComplaintTable] PRIMARY KEY CLUSTERED 
(
	[ComplaintId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CountryTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryTable](
	[CountryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NOT NULL,
	[CountryDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_CountryTable] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dispatch]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dispatch](
	[DispatchId] [bigint] IDENTITY(1,1) NOT NULL,
	[DispatchDate] [datetime2](7) NOT NULL,
	[DocketNo] [nvarchar](max) NULL,
	[ExpectedRichDate] [datetime2](7) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[DispatchAgencyId] [bigint] NOT NULL,
 CONSTRAINT [PK_Dispatch] PRIMARY KEY CLUSTERED 
(
	[DispatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DispatchAgencyTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DispatchAgencyTable](
	[DispatchAgencyId] [bigint] IDENTITY(1,1) NOT NULL,
	[AgencyName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Emial] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[ContactPerson] [nvarchar](max) NULL,
 CONSTRAINT [PK_DispatchAgencyTable] PRIMARY KEY CLUSTERED 
(
	[DispatchAgencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiftItem]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiftItem](
	[GiftItemId] [bigint] IDENTITY(1,1) NOT NULL,
	[GiftItemTitle] [nvarchar](max) NULL,
	[PhotoPath] [nvarchar](max) NULL,
	[GiftItemDescription] [nvarchar](max) NULL,
	[ProductId] [bigint] NOT NULL,
	[SubCategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_GiftItem] PRIMARY KEY CLUSTERED 
(
	[GiftItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GreetingCardTable ]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GreetingCardTable ](
	[GreetingCardId] [bigint] IDENTITY(1,1) NOT NULL,
	[CardTitle] [nvarchar](max) NULL,
	[CardDescription] [nvarchar](max) NULL,
	[DesignerName] [nvarchar](max) NULL,
	[IsDigital] [bit] NOT NULL,
	[PhotoPath] [nvarchar](max) NULL,
	[SubCategoryId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
 CONSTRAINT [PK_GreetingCardTable ] PRIMARY KEY CLUSTERED 
(
	[GreetingCardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OfferTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfferTable](
	[OfferId] [bigint] IDENTITY(1,1) NOT NULL,
	[OfferTitle] [nvarchar](max) NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[FromDate] [datetime2](7) NOT NULL,
	[ToDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OfferTable] PRIMARY KEY CLUSTERED 
(
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDeliveryTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDeliveryTable](
	[OrderDeliveryId] [bigint] IDENTITY(1,1) NOT NULL,
	[DeliverToPersonName] [nvarchar](max) NULL,
	[DeliveryAddress] [nvarchar](max) NULL,
	[PinCode] [nvarchar](max) NULL,
	[ContactNo] [nvarchar](max) NULL,
	[OrderId] [bigint] NOT NULL,
	[CityId] [bigint] NOT NULL,
 CONSTRAINT [PK_OrderDeliveryTable] PRIMARY KEY CLUSTERED 
(
	[OrderDeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailsId] [bigint] IDENTITY(1,1) NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[OrderId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[StoreId] [bigint] NOT NULL,
 CONSTRAINT [PK_OrderTable] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaymentTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTable](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
	[PaymentMode] [int] NOT NULL,
	[OrderId] [bigint] NOT NULL,
 CONSTRAINT [PK_PaymentTable] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTable](
	[ProductId] [bigint] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ProductType] [int] NOT NULL,
	[StoreId] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductTable] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RefundTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefundTable](
	[RefundId] [bigint] IDENTITY(1,1) NOT NULL,
	[RefundDate] [datetime2](7) NOT NULL,
	[RefundAmount] [decimal](18, 2) NOT NULL,
	[ReturnId] [bigint] NOT NULL,
 CONSTRAINT [PK_RefundTable] PRIMARY KEY CLUSTERED 
(
	[RefundId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReturnTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTable](
	[ReturnId] [bigint] IDENTITY(1,1) NOT NULL,
	[ReturnDate] [datetime2](7) NOT NULL,
	[ReturnReasion] [nvarchar](max) NULL,
	[ProductId] [bigint] NOT NULL,
	[OrderId] [bigint] NOT NULL,
 CONSTRAINT [PK_ReturnTable] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Solution]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solution](
	[SolutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
	[SolutionDescription] [nvarchar](max) NULL,
	[ComplaintId] [bigint] NOT NULL,
 CONSTRAINT [PK_Solution] PRIMARY KEY CLUSTERED 
(
	[SolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[State]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[StateId] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NOT NULL,
	[StatDescription] [nvarchar](max) NULL,
	[CountryId] [bigint] NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StoreReviewTale]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StoreReviewTale](
	[StoreReviewId] [bigint] IDENTITY(1,1) NOT NULL,
	[Review] [nvarchar](max) NULL,
	[ReviewDate] [datetime2](7) NOT NULL,
	[Rating] [int] NOT NULL,
	[StoreId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_StoreReviewTale] PRIMARY KEY CLUSTERED 
(
	[StoreReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StoreTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StoreTable](
	[StoreId] [bigint] IDENTITY(1,1) NOT NULL,
	[StoreName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[ContactNo] [nvarchar](max) NOT NULL,
	[EmailAddress] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[ContactPersonName] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CityId] [bigint] NOT NULL,
 CONSTRAINT [PK_StoreTable] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategoryTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryTable](
	[SubCategoryId] [bigint] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [nvarchar](max) NULL,
	[CategoryID] [bigint] NOT NULL,
 CONSTRAINT [PK_SubCategoryTable] PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaxTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxTable](
	[TaxId] [bigint] IDENTITY(1,1) NOT NULL,
	[CGSTRate] [decimal](18, 2) NOT NULL,
	[SGSTRate] [decimal](18, 2) NOT NULL,
	[IGSTRate] [decimal](18, 2) NOT NULL,
	[HSNSACNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_TaxTable] PRIMARY KEY CLUSTERED 
(
	[TaxId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 07-06-2024 14:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[Gender] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240607075956_init', N'7.0.18')
SET IDENTITY_INSERT [dbo].[AdminTable] ON 

INSERT [dbo].[AdminTable] ([AdminId], [FirstName], [LastName], [EmailId], [MobileNo], [Password], [Address]) VALUES (1, N'Prachi', N'Salve', N'prachi@gmail.com', N'4356378965', N'123', N'Pune')
SET IDENTITY_INSERT [dbo].[AdminTable] OFF
SET IDENTITY_INSERT [dbo].[CartTable] ON 

INSERT [dbo].[CartTable] ([CartId], [CartDate], [Price], [Qty], [ProductId], [UserId], [StoreId]) VALUES (132, CAST(N'2024-06-06 15:24:38.9092852' AS DateTime2), CAST(1000.00 AS Decimal(18, 2)), 1, 18, 4, 2)
SET IDENTITY_INSERT [dbo].[CartTable] OFF
SET IDENTITY_INSERT [dbo].[CategoryTable] ON 

INSERT [dbo].[CategoryTable] ([CategoryID], [CategoryName]) VALUES (1, N'Events')
INSERT [dbo].[CategoryTable] ([CategoryID], [CategoryName]) VALUES (2, N'Toys')
SET IDENTITY_INSERT [dbo].[CategoryTable] OFF
SET IDENTITY_INSERT [dbo].[CityTable] ON 

INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (1, N'Kolhapur', NULL, 1)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (2, N'Pune', NULL, 1)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (3, N'Sambhaji Nagar', NULL, 1)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (4, N'Pimpari', NULL, 1)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (5, N'Vadodara', NULL, 6)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (6, N'Veraval', NULL, 6)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (7, N'Warngal', NULL, 6)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (8, N'Somnath', NULL, 6)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (9, N'Happa', NULL, 6)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (10, N'Bihar', NULL, 7)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (11, N'Los Angeles', NULL, 2)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (12, N'San Fransisco', NULL, 2)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (13, N'San Diego', NULL, 2)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (14, N'Manhattan', NULL, 8)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (15, N'Albany', NULL, 8)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (16, N'Yonkers', NULL, 8)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (17, N'Arligton', NULL, 10)
INSERT [dbo].[CityTable] ([CityId], [CityName], [CityDescription], [StateId]) VALUES (18, N'Rockvile', NULL, 10)
SET IDENTITY_INSERT [dbo].[CityTable] OFF
SET IDENTITY_INSERT [dbo].[ComplaintTable] ON 

INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (1, CAST(N'2024-05-19 18:53:21.6938143' AS DateTime2), N'Product is not good', 19, 150)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (3, CAST(N'2024-05-19 19:19:00.0000000' AS DateTime2), N'Card is not good', 15, 150)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (4, CAST(N'2024-05-19 20:06:00.0000000' AS DateTime2), N'Product is not good', 15, 150)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (5, CAST(N'2024-05-17 20:09:00.0000000' AS DateTime2), N'Money Plant is not good', 1, 145)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (8, CAST(N'2024-05-20 13:11:04.0826191' AS DateTime2), N' Quality of sofa is not good', 3, 143)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (9, CAST(N'2024-05-20 13:30:36.3107471' AS DateTime2), N'Hand made card is not good', 11, 161)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (10, CAST(N'2024-05-20 16:31:42.0996833' AS DateTime2), N'jhkjl', 15, 156)
INSERT [dbo].[ComplaintTable] ([ComplaintId], [CompliantDate], [CompliantResion], [ProductId], [OrderId]) VALUES (11, CAST(N'2024-05-20 16:45:13.7096863' AS DateTime2), N'cushion is not good', 12, 162)
SET IDENTITY_INSERT [dbo].[ComplaintTable] OFF
SET IDENTITY_INSERT [dbo].[CountryTable] ON 

INSERT [dbo].[CountryTable] ([CountryId], [CountryName], [CountryDescription]) VALUES (2, N'India', NULL)
INSERT [dbo].[CountryTable] ([CountryId], [CountryName], [CountryDescription]) VALUES (4, N'South Korea', NULL)
INSERT [dbo].[CountryTable] ([CountryId], [CountryName], [CountryDescription]) VALUES (5, N'Japan', NULL)
INSERT [dbo].[CountryTable] ([CountryId], [CountryName], [CountryDescription]) VALUES (6, N'America', NULL)
SET IDENTITY_INSERT [dbo].[CountryTable] OFF
SET IDENTITY_INSERT [dbo].[Dispatch] ON 

INSERT [dbo].[Dispatch] ([DispatchId], [DispatchDate], [DocketNo], [ExpectedRichDate], [OrderId], [DispatchAgencyId]) VALUES (8, CAST(N'2024-05-28 19:14:40.2851280' AS DateTime2), N'434576', CAST(N'2024-05-31 19:14:00.0000000' AS DateTime2), 161, 1)
INSERT [dbo].[Dispatch] ([DispatchId], [DispatchDate], [DocketNo], [ExpectedRichDate], [OrderId], [DispatchAgencyId]) VALUES (9, CAST(N'2024-06-06 15:51:08.8271598' AS DateTime2), N'45665', CAST(N'2024-06-09 15:50:00.0000000' AS DateTime2), 137, 3)
INSERT [dbo].[Dispatch] ([DispatchId], [DispatchDate], [DocketNo], [ExpectedRichDate], [OrderId], [DispatchAgencyId]) VALUES (10, CAST(N'2024-06-06 16:12:07.9524318' AS DateTime2), N'45669', CAST(N'2024-06-09 16:12:00.0000000' AS DateTime2), 164, 1)
SET IDENTITY_INSERT [dbo].[Dispatch] OFF
SET IDENTITY_INSERT [dbo].[DispatchAgencyTable] ON 

INSERT [dbo].[DispatchAgencyTable] ([DispatchAgencyId], [AgencyName], [Address], [Emial], [MobileNo], [ContactPerson]) VALUES (1, N'Flex', N'Pune', N'flex@gmail.com', N'567890890', N'Riya')
INSERT [dbo].[DispatchAgencyTable] ([DispatchAgencyId], [AgencyName], [Address], [Emial], [MobileNo], [ContactPerson]) VALUES (3, N'Pack & Track', N'Delhi', N'pack&track@gmail.com', N'8080790978', N'Meghana')
SET IDENTITY_INSERT [dbo].[DispatchAgencyTable] OFF
SET IDENTITY_INSERT [dbo].[GiftItem] ON 

INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (1, N'Money Plant', N'\GiftImages\money-plant1.jpg', N'Giftitem', 1, 1)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (3, N'Eston Sofa', N'\GiftImages\eston sofa.webp', N'Eston Sofa Soft Toys', 3, 5)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (4, N'Chocolate', N'\GiftImages\HampersChocolates.webp', N'Chocolate Giftitem', 4, 2)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (5, N'Cake', N'\GiftImages\chocolate-cake.webp', N'Cake Giftitem', 5, 3)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (6, N'Car', N'\GiftImages\Car.jpg', N'Car ', 6, 4)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (7, N'Helicopter', N'\GiftImages\RemotControlHelicaptor.webp', N'Helicopter', 7, 4)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (8, N'Cushion', N'\GiftImages\cushion.webp', N'fdgjghilfduiutfujgbu', 12, 6)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (9, N'Chocolates', N'\GiftImages\chocolatey.webp', N'fgffhfygjhik', 13, 1)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (10, N'Elephant Soft Pillow', N'\GiftImages\ElephantSoftPillow.webp', N'fgtyutyuyiu', 16, 5)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (11, N'Penguin', N'\GiftImages\Penguin.jpg', N'gjooiyyujlklk', 17, 5)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (12, N'Photo Frame', N'\GiftImages\Mom-photo-frame.webp', N'rtuyyiuoi', 18, 6)
INSERT [dbo].[GiftItem] ([GiftItemId], [GiftItemTitle], [PhotoPath], [GiftItemDescription], [ProductId], [SubCategoryId]) VALUES (13, N'Photos', N'\GiftImages\Photo Tree.jpg', N'fgfhjhkh', 19, 3)
SET IDENTITY_INSERT [dbo].[GiftItem] OFF
SET IDENTITY_INSERT [dbo].[GreetingCardTable ] ON 

INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (1, N'BirthdayCard', N'Birthday Card ', N'Megha', 0, N'\GreetingImages\BirthdayCard.webp', 1, 8)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (2, N'Anniversary Card', N'Anniversary Card', N'Disha', 0, N'\GreetingImages\AnniversaryCard1.jpg', 3, 9)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (3, N'Mothers Day Card', N'Mothers Day Card', N'Priya', 0, N'\GreetingImages\Handmade-Mothers-Day-Card.jpg', 6, 10)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (4, N'Hand Made Card', N'HandMade Card', N'Rina', 0, N'\GreetingImages\MothersdayCard.webp', 6, 11)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (5, N'Anniversary Card', N'tytuyju', N'Disha', 0, N'\GreetingImages\AnniversaryCard2.png', 3, 14)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (6, N'Wedding Card', N'hjhkjl', N'Gaytri', 0, N'\GreetingImages\wooden plaque.webp', 2, 15)
INSERT [dbo].[GreetingCardTable ] ([GreetingCardId], [CardTitle], [CardDescription], [DesignerName], [IsDigital], [PhotoPath], [SubCategoryId], [ProductId]) VALUES (7, N'Anniversary Card', N'tyuyuiu', N'Megha', 0, N'\GreetingImages\AnniversaryCard.webp', 3, 20)
SET IDENTITY_INSERT [dbo].[GreetingCardTable ] OFF
SET IDENTITY_INSERT [dbo].[OrderDeliveryTable] ON 

INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (54, N'Nikita', N'Pune', N'486502', NULL, 113, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (55, N'Priyanka', N'Albany', N'546309', NULL, 114, 15)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (56, N'Shradha', N'Mumbai', N'410405', NULL, 113, 14)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (57, N'Sonali', N'Yonkers', N'546309', NULL, 120, 16)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (58, N'Sweety', N'Pune', N'410405', N'9090897867', 143, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (59, N'Sweety', N'Pune', N'410405', N'9090897867', 143, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (60, N'Sweety', N'Pune', N'410405', N'9090897867', 144, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (61, N'Sweety', N'Pune', N'410405', N'9090897867', 144, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (62, N'Nisha', N'Manhattan', N'546309', N'2341543675', 145, 14)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (63, N'Nisha', N'Manhattan', N'546309', N'2341543675', 145, 14)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (64, N'Nisha', N'Manhattan', N'546309', N'2341543675', 146, 14)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (65, N'Nisha', N'Manhattan', N'546309', N'2341543675', 146, 14)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (66, N'Ankita', N'Mumbai', N'410405', N'9087909867', 149, 15)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (67, N'Ankita', N'Mumbai', N'410405', N'9087909867', 150, 15)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (68, N'Shabdshri', N'Akurdi', N'422410', N'9068958746', 155, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (69, N'Shabdshri', N'Akurdi', N'422410', N'9068958746', 156, 2)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (70, N'Ashwini', N'Pune', N'431401', N'3445666789', 161, 4)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (71, N'Ashwini', N'Pune', N'431401', N'3445666789', 162, 4)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (72, N' Megha', N'tytkuljouj;', N'5667', N'9087909867', 163, 17)
INSERT [dbo].[OrderDeliveryTable] ([OrderDeliveryId], [DeliverToPersonName], [DeliveryAddress], [PinCode], [ContactNo], [OrderId], [CityId]) VALUES (73, N'Shivangi', N'pimpri', N'546767', N'4567656768', 164, 2)
SET IDENTITY_INSERT [dbo].[OrderDeliveryTable] OFF
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (13, 1, CAST(8000.00 AS Decimal(18, 2)), 113, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (14, 1, CAST(400.00 AS Decimal(18, 2)), 113, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (15, 1, CAST(1200.00 AS Decimal(18, 2)), 113, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (16, 1, CAST(650.00 AS Decimal(18, 2)), 114, 8)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (17, 1, CAST(850.00 AS Decimal(18, 2)), 114, 9)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (18, 1, CAST(8000.00 AS Decimal(18, 2)), 119, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (19, 1, CAST(4520.00 AS Decimal(18, 2)), 119, 7)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (20, 1, CAST(650.00 AS Decimal(18, 2)), 119, 8)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (21, 1, CAST(400.00 AS Decimal(18, 2)), 119, 12)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (22, 1, CAST(1200.00 AS Decimal(18, 2)), 119, 13)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (23, 1, CAST(3000.00 AS Decimal(18, 2)), 119, 15)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (24, 1, CAST(8000.00 AS Decimal(18, 2)), 120, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (25, 1, CAST(900.00 AS Decimal(18, 2)), 120, 16)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (26, 1, CAST(800.00 AS Decimal(18, 2)), 120, 17)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (27, 1, CAST(1200.00 AS Decimal(18, 2)), 138, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (28, 1, CAST(8000.00 AS Decimal(18, 2)), 138, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (29, 1, CAST(650.00 AS Decimal(18, 2)), 138, 8)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (30, 1, CAST(400.00 AS Decimal(18, 2)), 139, 12)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (31, 1, CAST(8000.00 AS Decimal(18, 2)), 143, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (32, 1, CAST(1200.00 AS Decimal(18, 2)), 143, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (33, 1, CAST(3000.00 AS Decimal(18, 2)), 144, 15)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (34, 1, CAST(400.00 AS Decimal(18, 2)), 144, 20)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (35, 1, CAST(850.00 AS Decimal(18, 2)), 145, 9)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (36, 1, CAST(1200.00 AS Decimal(18, 2)), 145, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (37, 1, CAST(4520.00 AS Decimal(18, 2)), 145, 7)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (38, 1, CAST(3000.00 AS Decimal(18, 2)), 146, 15)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (39, 1, CAST(1200.00 AS Decimal(18, 2)), 149, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (40, 1, CAST(3000.00 AS Decimal(18, 2)), 150, 19)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (41, 1, CAST(3000.00 AS Decimal(18, 2)), 150, 15)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (42, 1, CAST(8000.00 AS Decimal(18, 2)), 155, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (43, 1, CAST(650.00 AS Decimal(18, 2)), 155, 8)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (44, 1, CAST(1000.00 AS Decimal(18, 2)), 156, 18)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (45, 1, CAST(400.00 AS Decimal(18, 2)), 156, 12)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (46, 1, CAST(3000.00 AS Decimal(18, 2)), 156, 15)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (47, 1, CAST(8000.00 AS Decimal(18, 2)), 161, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (48, 1, CAST(1200.00 AS Decimal(18, 2)), 161, 11)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (49, 1, CAST(400.00 AS Decimal(18, 2)), 162, 12)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (50, 1, CAST(800.00 AS Decimal(18, 2)), 162, 17)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (51, 1, CAST(400.00 AS Decimal(18, 2)), 162, 20)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (52, 1, CAST(2000.00 AS Decimal(18, 2)), 163, 14)
INSERT [dbo].[OrderDetails] ([OrderDetailsId], [Qty], [Price], [OrderId], [ProductId]) VALUES (53, 1, CAST(650.00 AS Decimal(18, 2)), 164, 8)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[OrderTable] ON 

INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (113, CAST(N'2024-05-14 18:35:40.1748557' AS DateTime2), 1, 2, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (114, CAST(N'2024-05-14 18:40:12.5701980' AS DateTime2), 0, 1, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (115, CAST(N'2024-05-15 12:44:23.6717145' AS DateTime2), 0, 2, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (116, CAST(N'2024-05-15 12:44:23.6956043' AS DateTime2), 0, 2, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (117, CAST(N'2024-05-15 12:44:29.6449135' AS DateTime2), 0, 2, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (118, CAST(N'2024-05-15 12:44:29.6450219' AS DateTime2), 0, 2, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (119, CAST(N'2024-05-15 12:47:06.0350085' AS DateTime2), 1, 2, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (120, CAST(N'2024-05-16 15:14:39.3210497' AS DateTime2), 1, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (131, CAST(N'2024-05-16 20:09:41.4790873' AS DateTime2), 0, 1, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (135, CAST(N'2024-05-16 20:38:10.9311779' AS DateTime2), 0, 1, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (136, CAST(N'2024-05-17 11:46:51.5573724' AS DateTime2), 0, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (137, CAST(N'2024-05-17 13:32:05.8326522' AS DateTime2), 0, 1, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (138, CAST(N'2024-05-17 16:41:20.2890006' AS DateTime2), 1, 1, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (139, CAST(N'2024-05-17 16:43:11.6216075' AS DateTime2), 1, 1, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (143, CAST(N'2024-05-17 17:54:41.9484587' AS DateTime2), 1, 2, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (144, CAST(N'2024-05-17 17:56:02.1363509' AS DateTime2), 1, 2, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (145, CAST(N'2024-05-17 18:00:16.4725939' AS DateTime2), 1, 3, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (146, CAST(N'2024-05-17 18:00:16.7419341' AS DateTime2), 1, 3, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (147, CAST(N'2024-05-17 18:04:44.2403284' AS DateTime2), 0, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (148, CAST(N'2024-05-17 18:04:44.2704403' AS DateTime2), 0, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (149, CAST(N'2024-05-17 18:06:31.0361792' AS DateTime2), 1, 4, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (150, CAST(N'2024-05-17 18:07:18.9139502' AS DateTime2), 1, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (151, CAST(N'2024-05-20 13:14:24.7319344' AS DateTime2), 0, 3, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (152, CAST(N'2024-05-20 13:14:24.7339143' AS DateTime2), 0, 3, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (153, CAST(N'2024-05-20 13:14:27.8066047' AS DateTime2), 0, 3, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (154, CAST(N'2024-05-20 13:14:27.8067188' AS DateTime2), 0, 3, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (155, CAST(N'2024-05-20 13:16:26.7199137' AS DateTime2), 1, 3, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (156, CAST(N'2024-05-20 13:16:26.7818664' AS DateTime2), 1, 3, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (157, CAST(N'2024-05-20 13:20:50.4651055' AS DateTime2), 0, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (158, CAST(N'2024-05-20 13:20:50.4652011' AS DateTime2), 0, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (159, CAST(N'2024-05-20 13:20:53.4869500' AS DateTime2), 0, 4, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (160, CAST(N'2024-05-20 13:20:53.4871098' AS DateTime2), 0, 4, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (161, CAST(N'2024-05-20 13:22:52.8619278' AS DateTime2), 1, 4, 1)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (162, CAST(N'2024-05-20 13:22:52.8666701' AS DateTime2), 1, 4, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (163, CAST(N'2024-06-02 17:50:53.1486914' AS DateTime2), 1, 3, 2)
INSERT [dbo].[OrderTable] ([OrderId], [OrderDate], [IsPaid], [UserId], [StoreId]) VALUES (164, CAST(N'2024-06-06 16:05:38.3642956' AS DateTime2), 0, 2, 1)
SET IDENTITY_INSERT [dbo].[OrderTable] OFF
SET IDENTITY_INSERT [dbo].[PaymentTable] ON 

INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (6, CAST(N'2024-05-14 18:36:17.9076164' AS DateTime2), CAST(9600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 113)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (7, CAST(N'2024-05-15 12:47:05.8427598' AS DateTime2), CAST(13170.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 119)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (8, CAST(N'2024-05-15 12:47:06.0376451' AS DateTime2), CAST(4600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 119)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (9, CAST(N'2024-05-16 15:14:39.2600978' AS DateTime2), CAST(8000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 120)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (10, CAST(N'2024-05-16 15:14:39.3236764' AS DateTime2), CAST(1700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 120)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (11, CAST(N'2024-05-17 16:42:38.5331581' AS DateTime2), CAST(9850.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 138)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (12, CAST(N'2024-05-17 16:43:28.6382363' AS DateTime2), CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 139)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (13, CAST(N'2024-05-17 17:55:54.5169902' AS DateTime2), CAST(9200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 143)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (14, CAST(N'2024-05-17 17:56:13.1178351' AS DateTime2), CAST(3400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 144)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (15, CAST(N'2024-05-17 18:00:16.4939445' AS DateTime2), CAST(6570.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 145)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (16, CAST(N'2024-05-17 18:00:16.7426790' AS DateTime2), CAST(3000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 146)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (17, CAST(N'2024-05-17 18:07:14.3923995' AS DateTime2), CAST(1200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 149)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (18, CAST(N'2024-05-17 18:07:21.4216721' AS DateTime2), CAST(6000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 150)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (19, CAST(N'2024-05-20 13:16:26.7318353' AS DateTime2), CAST(8650.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 155)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (20, CAST(N'2024-05-20 13:16:26.7824744' AS DateTime2), CAST(4400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 156)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (21, CAST(N'2024-05-20 13:22:52.8631266' AS DateTime2), CAST(9200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 161)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (22, CAST(N'2024-05-20 13:22:52.8671965' AS DateTime2), CAST(1600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 162)
INSERT [dbo].[PaymentTable] ([PaymentId], [PaymentDate], [Amount], [DiscountAmount], [PaymentMode], [OrderId]) VALUES (23, CAST(N'2024-06-02 17:50:53.1594640' AS DateTime2), CAST(2000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 2, 163)
SET IDENTITY_INSERT [dbo].[PaymentTable] OFF
SET IDENTITY_INSERT [dbo].[ProductTable] ON 

INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (1, CAST(1200.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (3, CAST(8000.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (4, CAST(400.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (5, CAST(1200.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (6, CAST(345.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (7, CAST(4520.00 AS Decimal(18, 2)), 2, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (8, CAST(650.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (9, CAST(850.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (10, CAST(2500.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (11, CAST(1200.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (12, CAST(400.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (13, CAST(1200.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (14, CAST(2000.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (15, CAST(3000.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (16, CAST(900.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (17, CAST(800.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (18, CAST(1000.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (19, CAST(3000.00 AS Decimal(18, 2)), 2, 2)
INSERT [dbo].[ProductTable] ([ProductId], [Price], [ProductType], [StoreId]) VALUES (20, CAST(400.00 AS Decimal(18, 2)), 1, 2)
SET IDENTITY_INSERT [dbo].[ProductTable] OFF
SET IDENTITY_INSERT [dbo].[RefundTable] ON 

INSERT [dbo].[RefundTable] ([RefundId], [RefundDate], [RefundAmount], [ReturnId]) VALUES (1, CAST(N'2024-05-28 16:07:21.9128543' AS DateTime2), CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[RefundTable] ([RefundId], [RefundDate], [RefundAmount], [ReturnId]) VALUES (2, CAST(N'2024-05-28 16:16:21.7225573' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[RefundTable] ([RefundId], [RefundDate], [RefundAmount], [ReturnId]) VALUES (3, CAST(N'2024-05-28 16:54:35.7454584' AS DateTime2), CAST(8000.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[RefundTable] OFF
SET IDENTITY_INSERT [dbo].[ReturnTable] ON 

INSERT [dbo].[ReturnTable] ([ReturnId], [ReturnDate], [ReturnReasion], [ProductId], [OrderId]) VALUES (1, CAST(N'2024-05-20 17:21:22.6608768' AS DateTime2), N'I don''t Like This Product', 19, 150)
INSERT [dbo].[ReturnTable] ([ReturnId], [ReturnDate], [ReturnReasion], [ProductId], [OrderId]) VALUES (2, CAST(N'2024-05-28 16:15:38.6036258' AS DateTime2), N'Product is not good', 20, 162)
INSERT [dbo].[ReturnTable] ([ReturnId], [ReturnDate], [ReturnReasion], [ProductId], [OrderId]) VALUES (3, CAST(N'2024-05-28 16:53:04.6786223' AS DateTime2), N'Product is not good', 3, 143)
SET IDENTITY_INSERT [dbo].[ReturnTable] OFF
SET IDENTITY_INSERT [dbo].[Solution] ON 

INSERT [dbo].[Solution] ([SolutionId], [SolutionDate], [SolutionDescription], [ComplaintId]) VALUES (4, CAST(N'2024-05-20 17:32:16.9198900' AS DateTime2), N'Ok We are Working On It', 5)
SET IDENTITY_INSERT [dbo].[Solution] OFF
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (1, N'Maharashtra', NULL, 2)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (2, N'California', NULL, 6)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (3, N'Chiba', NULL, 5)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (4, N'Fukui', NULL, 5)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (5, N'Aamori', NULL, 5)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (6, N'Gujarat', NULL, 2)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (7, N'UP', NULL, 2)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (8, N'New York City', NULL, 6)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (9, N'Boston', NULL, 6)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (10, N'Washington D.C', NULL, 6)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (11, N'Texes', NULL, 6)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (12, N'Busan', NULL, 4)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (13, N'Daegu', NULL, 4)
INSERT [dbo].[State] ([StateId], [StateName], [StatDescription], [CountryId]) VALUES (14, N'Incheon', NULL, 4)
SET IDENTITY_INSERT [dbo].[State] OFF
SET IDENTITY_INSERT [dbo].[StoreReviewTale] ON 

INSERT [dbo].[StoreReviewTale] ([StoreReviewId], [Review], [ReviewDate], [Rating], [StoreId], [UserId]) VALUES (2, N'Good Store', CAST(N'2024-06-07 13:45:00.0000000' AS DateTime2), 2, 1, 4)
INSERT [dbo].[StoreReviewTale] ([StoreReviewId], [Review], [ReviewDate], [Rating], [StoreId], [UserId]) VALUES (3, N'Nice Shop', CAST(N'2024-06-08 13:57:00.0000000' AS DateTime2), 1, 2, 3)
SET IDENTITY_INSERT [dbo].[StoreReviewTale] OFF
SET IDENTITY_INSERT [dbo].[StoreTable] ON 

INSERT [dbo].[StoreTable] ([StoreId], [StoreName], [Address], [ContactNo], [EmailAddress], [Password], [ContactPersonName], [IsActive], [CityId]) VALUES (1, N'GreetingShop', N'Nigdi, Pune', N'1232456545', N'priya@gmail.com', N'1234', N'Priyanka', 0, 2)
INSERT [dbo].[StoreTable] ([StoreId], [StoreName], [Address], [ContactNo], [EmailAddress], [Password], [ContactPersonName], [IsActive], [CityId]) VALUES (2, N'Greetings&Gift', N'Mumbai', N'2341543675', N'poonam@gmail.com', N'123', N'Poonam', 0, 2)
SET IDENTITY_INSERT [dbo].[StoreTable] OFF
SET IDENTITY_INSERT [dbo].[SubCategoryTable] ON 

INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (1, N'Birthday', 1)
INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (2, N'Wedding', 1)
INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (3, N'Anniversary', 1)
INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (4, N'ElectronicToys', 2)
INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (5, N'SoftToys', 2)
INSERT [dbo].[SubCategoryTable] ([SubCategoryId], [SubCategoryName], [CategoryID]) VALUES (6, N'Mothers Day', 1)
SET IDENTITY_INSERT [dbo].[SubCategoryTable] OFF
SET IDENTITY_INSERT [dbo].[UserTable] ON 

INSERT [dbo].[UserTable] ([UserId], [FirstName], [LastName], [Email], [Password], [MobileNo], [Address], [DateOfBirth], [Gender], [IsActive]) VALUES (1, N'prachi', N'Salve', N'prachi@gmail.com', N'1234', N'8879456301', N'Nigdi,pune', CAST(N'2001-04-12 02:48:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[UserTable] ([UserId], [FirstName], [LastName], [Email], [Password], [MobileNo], [Address], [DateOfBirth], [Gender], [IsActive]) VALUES (2, N'Ranika', N'Sharma', N'ranika@gmail.com', N'123', N'4565456789', N'Delhi', CAST(N'2000-05-09 15:24:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[UserTable] ([UserId], [FirstName], [LastName], [Email], [Password], [MobileNo], [Address], [DateOfBirth], [Gender], [IsActive]) VALUES (3, N'Pallavi', N'More', N'pallavi@gmail.com', N'123', N'12909089890', N'Goa', CAST(N'2002-02-12 17:28:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[UserTable] ([UserId], [FirstName], [LastName], [Email], [Password], [MobileNo], [Address], [DateOfBirth], [Gender], [IsActive]) VALUES (4, N'Shreya', N'Shinde', N'shreya@gmail.com', N'123', N'9080807896', N'delhi', CAST(N'2003-08-23 15:10:00.0000000' AS DateTime2), 2, 0)
SET IDENTITY_INSERT [dbo].[UserTable] OFF
ALTER TABLE [dbo].[CartTable]  WITH CHECK ADD  CONSTRAINT [FK_CartTable_ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[CartTable] CHECK CONSTRAINT [FK_CartTable_ProductTable_ProductId]
GO
ALTER TABLE [dbo].[CartTable]  WITH CHECK ADD  CONSTRAINT [FK_CartTable_StoreTable_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[StoreTable] ([StoreId])
GO
ALTER TABLE [dbo].[CartTable] CHECK CONSTRAINT [FK_CartTable_StoreTable_StoreId]
GO
ALTER TABLE [dbo].[CartTable]  WITH CHECK ADD  CONSTRAINT [FK_CartTable_UserTable_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[CartTable] CHECK CONSTRAINT [FK_CartTable_UserTable_UserId]
GO
ALTER TABLE [dbo].[CityTable]  WITH CHECK ADD  CONSTRAINT [FK_CityTable_State_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([StateId])
GO
ALTER TABLE [dbo].[CityTable] CHECK CONSTRAINT [FK_CityTable_State_StateId]
GO
ALTER TABLE [dbo].[ComplaintTable]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintTable_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[ComplaintTable] CHECK CONSTRAINT [FK_ComplaintTable_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[ComplaintTable]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintTable_ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[ComplaintTable] CHECK CONSTRAINT [FK_ComplaintTable_ProductTable_ProductId]
GO
ALTER TABLE [dbo].[Dispatch]  WITH CHECK ADD  CONSTRAINT [FK_Dispatch_DispatchAgencyTable_DispatchAgencyId] FOREIGN KEY([DispatchAgencyId])
REFERENCES [dbo].[DispatchAgencyTable] ([DispatchAgencyId])
GO
ALTER TABLE [dbo].[Dispatch] CHECK CONSTRAINT [FK_Dispatch_DispatchAgencyTable_DispatchAgencyId]
GO
ALTER TABLE [dbo].[Dispatch]  WITH CHECK ADD  CONSTRAINT [FK_Dispatch_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[Dispatch] CHECK CONSTRAINT [FK_Dispatch_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[GiftItem]  WITH CHECK ADD  CONSTRAINT [FK_GiftItem_ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[GiftItem] CHECK CONSTRAINT [FK_GiftItem_ProductTable_ProductId]
GO
ALTER TABLE [dbo].[GiftItem]  WITH CHECK ADD  CONSTRAINT [FK_GiftItem_SubCategoryTable_SubCategoryId] FOREIGN KEY([SubCategoryId])
REFERENCES [dbo].[SubCategoryTable] ([SubCategoryId])
GO
ALTER TABLE [dbo].[GiftItem] CHECK CONSTRAINT [FK_GiftItem_SubCategoryTable_SubCategoryId]
GO
ALTER TABLE [dbo].[GreetingCardTable ]  WITH CHECK ADD  CONSTRAINT [FK_GreetingCardTable _ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[GreetingCardTable ] CHECK CONSTRAINT [FK_GreetingCardTable _ProductTable_ProductId]
GO
ALTER TABLE [dbo].[GreetingCardTable ]  WITH CHECK ADD  CONSTRAINT [FK_GreetingCardTable _SubCategoryTable_SubCategoryId] FOREIGN KEY([SubCategoryId])
REFERENCES [dbo].[SubCategoryTable] ([SubCategoryId])
GO
ALTER TABLE [dbo].[GreetingCardTable ] CHECK CONSTRAINT [FK_GreetingCardTable _SubCategoryTable_SubCategoryId]
GO
ALTER TABLE [dbo].[OrderDeliveryTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderDeliveryTable_CityTable_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityTable] ([CityId])
GO
ALTER TABLE [dbo].[OrderDeliveryTable] CHECK CONSTRAINT [FK_OrderDeliveryTable_CityTable_CityId]
GO
ALTER TABLE [dbo].[OrderDeliveryTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderDeliveryTable_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDeliveryTable] CHECK CONSTRAINT [FK_OrderDeliveryTable_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ProductTable_ProductId]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderTable_StoreTable_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[StoreTable] ([StoreId])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [FK_OrderTable_StoreTable_StoreId]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderTable_UserTable_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [FK_OrderTable_UserTable_UserId]
GO
ALTER TABLE [dbo].[PaymentTable]  WITH CHECK ADD  CONSTRAINT [FK_PaymentTable_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[PaymentTable] CHECK CONSTRAINT [FK_PaymentTable_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[ProductTable]  WITH CHECK ADD  CONSTRAINT [FK_ProductTable_StoreTable_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[StoreTable] ([StoreId])
GO
ALTER TABLE [dbo].[ProductTable] CHECK CONSTRAINT [FK_ProductTable_StoreTable_StoreId]
GO
ALTER TABLE [dbo].[RefundTable]  WITH CHECK ADD  CONSTRAINT [FK_RefundTable_ReturnTable_ReturnId] FOREIGN KEY([ReturnId])
REFERENCES [dbo].[ReturnTable] ([ReturnId])
GO
ALTER TABLE [dbo].[RefundTable] CHECK CONSTRAINT [FK_RefundTable_ReturnTable_ReturnId]
GO
ALTER TABLE [dbo].[ReturnTable]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTable_OrderTable_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[ReturnTable] CHECK CONSTRAINT [FK_ReturnTable_OrderTable_OrderId]
GO
ALTER TABLE [dbo].[ReturnTable]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTable_ProductTable_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTable] ([ProductId])
GO
ALTER TABLE [dbo].[ReturnTable] CHECK CONSTRAINT [FK_ReturnTable_ProductTable_ProductId]
GO
ALTER TABLE [dbo].[Solution]  WITH CHECK ADD  CONSTRAINT [FK_Solution_ComplaintTable_ComplaintId] FOREIGN KEY([ComplaintId])
REFERENCES [dbo].[ComplaintTable] ([ComplaintId])
GO
ALTER TABLE [dbo].[Solution] CHECK CONSTRAINT [FK_Solution_ComplaintTable_ComplaintId]
GO
ALTER TABLE [dbo].[State]  WITH CHECK ADD  CONSTRAINT [FK_State_CountryTable_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[CountryTable] ([CountryId])
GO
ALTER TABLE [dbo].[State] CHECK CONSTRAINT [FK_State_CountryTable_CountryId]
GO
ALTER TABLE [dbo].[StoreReviewTale]  WITH CHECK ADD  CONSTRAINT [FK_StoreReviewTale_StoreTable_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[StoreTable] ([StoreId])
GO
ALTER TABLE [dbo].[StoreReviewTale] CHECK CONSTRAINT [FK_StoreReviewTale_StoreTable_StoreId]
GO
ALTER TABLE [dbo].[StoreReviewTale]  WITH CHECK ADD  CONSTRAINT [FK_StoreReviewTale_UserTable_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[StoreReviewTale] CHECK CONSTRAINT [FK_StoreReviewTale_UserTable_UserId]
GO
ALTER TABLE [dbo].[StoreTable]  WITH CHECK ADD  CONSTRAINT [FK_StoreTable_CityTable_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityTable] ([CityId])
GO
ALTER TABLE [dbo].[StoreTable] CHECK CONSTRAINT [FK_StoreTable_CityTable_CityId]
GO
ALTER TABLE [dbo].[SubCategoryTable]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryTable_CategoryTable_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CategoryTable] ([CategoryID])
GO
ALTER TABLE [dbo].[SubCategoryTable] CHECK CONSTRAINT [FK_SubCategoryTable_CategoryTable_CategoryID]
GO
