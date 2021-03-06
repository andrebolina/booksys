USE [BooksysBD]
GO
/****** Object:  Table [dbo].[Livros]    Script Date: 20/11/2019 11:50:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](200) NULL,
	[autor] [varchar](100) NULL,
	[editora] [varchar](50) NULL,
	[ano] [int] NULL,
	[estoque] [int] NULL,
	[valor] [float] NULL,
 CONSTRAINT [PK_Livros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Livros] ON 

INSERT [dbo].[Livros] ([id], [nome], [autor], [editora], [ano], [estoque], [valor]) VALUES (14, N'Como Fazer Amigos e Influenciar Pessoas', N'Dale Carnegie', N'Companhia Editora Nacional', 2012, 8, 19.9)
INSERT [dbo].[Livros] ([id], [nome], [autor], [editora], [ano], [estoque], [valor]) VALUES (15, N'Escravidão – Vol. 1: Do primeiro leilão de cativos em Portugal até a morte de Zumbi dos Palmares', N'Laurentino Gomes', N'Globo Livros', 2019, 175, 29.99)
INSERT [dbo].[Livros] ([id], [nome], [autor], [editora], [ano], [estoque], [valor]) VALUES (16, N'O conto da aia', N'Margaret Atwood', N'Rocco', 2017, 0, 21)
INSERT [dbo].[Livros] ([id], [nome], [autor], [editora], [ano], [estoque], [valor]) VALUES (17, N'Sapiens: Uma breve história da humanidade', N'Yuval Noah Harari', N'L&PM', 2015, 56, 41.5)
INSERT [dbo].[Livros] ([id], [nome], [autor], [editora], [ano], [estoque], [valor]) VALUES (18, N'21 lições para o século 21', N'Yuval Noah Harari', N'Companhia das Letras', 2018, 112, 47.8)
SET IDENTITY_INSERT [dbo].[Livros] OFF
