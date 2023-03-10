USE [MortgageData]
GO
/****** Object:  Table [dbo].[InterestRepayment]    Script Date: 3/1/2023 12:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InterestRepayment](
	[InterestRepaymentId] [int] IDENTITY(1,1) NOT NULL,
	[InterestRepaymentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InterestRepayment] PRIMARY KEY CLUSTERED 
(
	[InterestRepaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mortgage]    Script Date: 3/1/2023 12:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mortgage](
	[MortgageId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[MortgageTypeId] [int] NOT NULL,
	[InterestRepaymentId] [int] NOT NULL,
	[EffectiveStartDate] [datetime] NOT NULL,
	[EffectiveEndDate] [datetime] NOT NULL,
	[TermsInMonths] [int] NOT NULL,
	[CancellationFee] [decimal](18, 5) NOT NULL,
	[EstablishmentFee] [decimal](18, 5) NOT NULL,
	[SchemaIdentifier] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Mortgage] PRIMARY KEY CLUSTERED 
(
	[MortgageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MortgageType]    Script Date: 3/1/2023 12:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MortgageType](
	[MortgageTypeId] [int] IDENTITY(1,1) NOT NULL,
	[MortgageTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MortgageType] PRIMARY KEY CLUSTERED 
(
	[MortgageTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[InterestRepayment] ON 

INSERT [dbo].[InterestRepayment] ([InterestRepaymentId], [InterestRepaymentName]) VALUES (1, N'InterestOnly')
INSERT [dbo].[InterestRepayment] ([InterestRepaymentId], [InterestRepaymentName]) VALUES (2, N'PrincipalAndInterest')
SET IDENTITY_INSERT [dbo].[InterestRepayment] OFF
GO
SET IDENTITY_INSERT [dbo].[Mortgage] ON 

INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (2, N'HDFC', 1, 2, CAST(N'2023-02-28T11:32:00.233' AS DateTime), CAST(N'2023-03-28T11:32:00.233' AS DateTime), 12, CAST(1200.00000 AS Decimal(18, 5)), CAST(100.00000 AS Decimal(18, 5)), N'3a0cf3f5-d1ac-451c-ba67-929a1f831c8b')
INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (4, N'siva', 2, 1, CAST(N'2023-02-28T23:54:09.127' AS DateTime), CAST(N'2023-02-28T23:54:09.113' AS DateTime), 13, CAST(1000.00000 AS Decimal(18, 5)), CAST(1200.00000 AS Decimal(18, 5)), N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (5, N'SBI', 2, 2, CAST(N'2023-07-20T11:07:10.000' AS DateTime), CAST(N'2024-08-21T11:07:10.000' AS DateTime), 11, CAST(13000.00000 AS Decimal(18, 5)), CAST(1500.00000 AS Decimal(18, 5)), N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (6, N'IOB', 2, 2, CAST(N'2023-03-29T11:14:29.000' AS DateTime), CAST(N'2024-03-29T11:14:29.000' AS DateTime), 12, CAST(1100.00000 AS Decimal(18, 5)), CAST(1600.00000 AS Decimal(18, 5)), N'ef7f6490-6abe-4a26-bee9-2276f35a394a')
INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (7, N'IND', 1, 1, CAST(N'2023-03-24T11:16:00.000' AS DateTime), CAST(N'2023-04-19T11:16:00.000' AS DateTime), 13, CAST(1000.00000 AS Decimal(18, 5)), CAST(3000.00000 AS Decimal(18, 5)), N'9768438c-5711-4165-8976-94b0dd29e020')
INSERT [dbo].[Mortgage] ([MortgageId], [Name], [MortgageTypeId], [InterestRepaymentId], [EffectiveStartDate], [EffectiveEndDate], [TermsInMonths], [CancellationFee], [EstablishmentFee], [SchemaIdentifier]) VALUES (8, N'LGT', 1, 1, CAST(N'2023-03-01T11:19:36.320' AS DateTime), CAST(N'2024-03-28T11:19:36.000' AS DateTime), 12, CAST(1200.00000 AS Decimal(18, 5)), CAST(1500.00000 AS Decimal(18, 5)), N'258818ec-06b2-445c-9462-66aa069a0d63')
SET IDENTITY_INSERT [dbo].[Mortgage] OFF
GO
SET IDENTITY_INSERT [dbo].[MortgageType] ON 

INSERT [dbo].[MortgageType] ([MortgageTypeId], [MortgageTypeName]) VALUES (1, N'Variable')
INSERT [dbo].[MortgageType] ([MortgageTypeId], [MortgageTypeName]) VALUES (2, N'Fixed')
SET IDENTITY_INSERT [dbo].[MortgageType] OFF
GO
ALTER TABLE [dbo].[Mortgage]  WITH CHECK ADD  CONSTRAINT [FK_InterestRepayment_Mortgage] FOREIGN KEY([InterestRepaymentId])
REFERENCES [dbo].[InterestRepayment] ([InterestRepaymentId])
GO
ALTER TABLE [dbo].[Mortgage] CHECK CONSTRAINT [FK_InterestRepayment_Mortgage]
GO
ALTER TABLE [dbo].[Mortgage]  WITH CHECK ADD  CONSTRAINT [FK_MortgageType_Mortgage] FOREIGN KEY([MortgageTypeId])
REFERENCES [dbo].[MortgageType] ([MortgageTypeId])
GO
ALTER TABLE [dbo].[Mortgage] CHECK CONSTRAINT [FK_MortgageType_Mortgage]
GO
