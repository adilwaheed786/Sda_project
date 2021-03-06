USE [final]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Admin_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](225) NULL,
	[Password] [varchar](225) NULL,
PRIMARY KEY CLUSTERED 
(
	[Admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[Attendance_Id] [int] IDENTITY(1,1) NOT NULL,
	[Absent] [int] NULL,
	[Month] [varchar](225) NULL,
	[Reason] [varchar](225) NULL,
	[Absent_Date] [nvarchar](30) NOT NULL,
	[EmployeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Attendance_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Cat_id] [int] IDENTITY(1,1) NOT NULL,
	[Cat_name] [varchar](100) NOT NULL,
	[Cat_Desc] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Cust_id] [int] IDENTITY(1,1) NOT NULL,
	[Cust_Name] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [varchar](255) NULL,
	[city] [varchar](255) NULL,
	[gender] [varchar](50) NULL,
	[member_ship] [int] NULL,
	[Password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[Discount_id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_id] [int] NOT NULL,
	[Discount_percent] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Discount_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
	[Job_Status] [nvarchar](30) NULL,
	[HireDate] [nvarchar](50) NULL,
	[Address] [nvarchar](60) NULL,
	[Contact] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Electricity_bill] [int] NOT NULL,
	[Rant] [int] NOT NULL,
	[Maintainance] [int] NOT NULL,
	[Date] [nvarchar](30) NOT NULL,
	[Expenses_id] [int] IDENTITY(1,1) NOT NULL,
	[Admin_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Expenses_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Investment]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investment](
	[Invester_id] [int] IDENTITY(1,1) NOT NULL,
	[Invester_name] [varchar](225) NULL,
	[Invest_amount] [int] NOT NULL,
	[Product_name] [varchar](225) NOT NULL,
	[Product_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Invester_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Desc] [varchar](255) NULL,
	[Cust_Name] [varchar](255) NULL,
	[Cust_id] [int] NOT NULL,
	[ShipperID] [int] NOT NULL,
	[Product_id] [int] NULL,
	[date] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order Details]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order Details](
	[OrderID] [int] NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_id] [int] IDENTITY(1,1) NOT NULL,
	[Cat_id] [int] NOT NULL,
	[Cat_name] [varchar](225) NULL,
	[Pr_name] [varchar](150) NOT NULL,
	[Pr_description] [text] NOT NULL,
	[Price] [int] NOT NULL,
	[Supplier_id] [int] NOT NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[Sal_Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [int] NOT NULL,
	[Employee_Name] [varchar](1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sal_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipping]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipping](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[cust_id] [int] NULL,
	[city] [nvarchar](40) NOT NULL,
	[Phone] [nvarchar](24) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 7/2/2021 10:24:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](60) NULL,
	[Phone] [nvarchar](24) NULL,
	[City] [varchar](225) NULL,
	[Country] [varchar](225) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([Admin_id], [username], [Password]) VALUES (1, N'adil', N'123')
INSERT [dbo].[Admin] ([Admin_id], [username], [Password]) VALUES (2, N'sumayya', N'123')
INSERT [dbo].[Admin] ([Admin_id], [username], [Password]) VALUES (3, N'abdullah', N'123')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Cat_id], [Cat_name], [Cat_Desc]) VALUES (1, N'Males', N'shirt,jeans')
INSERT [dbo].[Categories] ([Cat_id], [Cat_name], [Cat_Desc]) VALUES (2, N'Femalesd', N'skirt')
INSERT [dbo].[Categories] ([Cat_id], [Cat_name], [Cat_Desc]) VALUES (4, N'shirt', N'asdasdas')
INSERT [dbo].[Categories] ([Cat_id], [Cat_name], [Cat_Desc]) VALUES (8, N'asd', N'sd')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Cust_id], [Cust_Name], [Address], [Phone], [city], [gender], [member_ship], [Password]) VALUES (1, N'ad', N'asd', N'123', N'ad', N'Male', 0, N'1')
INSERT [dbo].[Customer] ([Cust_id], [Cust_Name], [Address], [Phone], [city], [gender], [member_ship], [Password]) VALUES (2, N'asd', N'asd', N'23', N'asd', N'Male', 1, N'23')
INSERT [dbo].[Customer] ([Cust_id], [Cust_Name], [Address], [Phone], [city], [gender], [member_ship], [Password]) VALUES (3, N'a', N'a', N'1', N'a', N'Male', 1, N'1')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (15, N'sss', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (16, N'sss', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (17, N'515', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (18, N'ad', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (19, N'sss', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (20, N'515', N'Part Time', N'Saturday, June 26, 2021', N'a', N'2')
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Job_Status], [HireDate], [Address], [Contact]) VALUES (21, N'adil', N'ad', N'Saturday, June 26, 2021', N'123', N'13123')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Order_id], [Order_Desc], [Cust_Name], [Cust_id], [ShipperID], [Product_id], [date]) VALUES (4, N'a', N'a', 1, 1, 6, N'1')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (4, 8, 2.0000, 4)
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Product_id], [Cat_id], [Cat_name], [Pr_name], [Pr_description], [Price], [Supplier_id], [Stock]) VALUES (6, 1, N'Males', N'asd', N'rr', 23, 1, 1)
INSERT [dbo].[Products] ([Product_id], [Cat_id], [Cat_name], [Pr_name], [Pr_description], [Price], [Supplier_id], [Stock]) VALUES (8, 2, N'Femalesd', N'a', N'a', 2, 1, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Shipping] ON 

INSERT [dbo].[Shipping] ([ShipperID], [cust_id], [city], [Phone]) VALUES (1, 1, N'a', N'1')
SET IDENTITY_INSERT [dbo].[Shipping] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [Address], [Phone], [City], [Country]) VALUES (1, N'jamshed', N'karachi 16 dha', N'0231', N'kch', N'pk')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
ALTER TABLE [dbo].[Attendance] ADD  DEFAULT ('0') FOR [Absent]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ('0') FOR [member_ship]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Discount]  WITH CHECK ADD FOREIGN KEY([Customer_id])
REFERENCES [dbo].[Customer] ([Cust_id])
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD FOREIGN KEY([Admin_id])
REFERENCES [dbo].[Admin] ([Admin_id])
GO
ALTER TABLE [dbo].[Investment]  WITH CHECK ADD FOREIGN KEY([Product_id])
REFERENCES [dbo].[Products] ([Product_id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Cust_id])
REFERENCES [dbo].[Customer] ([Cust_id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([Product_id])
REFERENCES [dbo].[Products] ([Product_id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shipping] ([ShipperID])
GO
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([Order_id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([Cat_id])
REFERENCES [dbo].[Categories] ([Cat_id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([Supplier_id])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Shipping]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[Customer] ([Cust_id])
GO
