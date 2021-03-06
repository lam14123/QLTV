USE [QLTV]
GO
/****** Object:  StoredProcedure [dbo].[sua_docgia]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sua_docgia](
@s nvarchar(10),
@cmnd nvarchar(10),
@ten nvarchar (70),
@ngaysinh date,
@diachi text,
@gioitinh nchar(10),
@taikhoan nvarchar(50),
@matkhau nvarchar(10))
as
update Docgia
set cmnd=@cmnd,ten=@ten,ngaysinh=@ngaysinh,diachi=@diachi,gioitinh=@gioitinh,taikhoan=@taikhoan,matkhau=@matkhau
where cmnd=@s
GO
/****** Object:  StoredProcedure [dbo].[sua_sach]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_sach](
@s nvarchar(10),
@id nvarchar(10),
@ten nvarchar (70),
@soluong int,
@tacgia nvarchar (100),
@theloai nvarchar(50),
@nxb nvarchar (50)
)
as
update Sach
set id=@id, ten=@ten, soluong=@soluong, tacgia=@tacgia, theloai=@theloai, nxb=@nxb
where id=@s

GO
/****** Object:  StoredProcedure [dbo].[them_docgia]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_docgia](
@cmnd nvarchar(10),
@ten nvarchar (70),
@ngaysinh date,
@diachi text,
@gioitinh nchar(10),
@taikhoan nvarchar(50),
@matkhau nvarchar(10))
as
insert into Docgia values(@cmnd,@ten,@ngaysinh,@diachi,@gioitinh,@taikhoan,@matkhau)
GO
/****** Object:  StoredProcedure [dbo].[them_sach]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_sach](@id nvarchar(10), @ten nvarchar(70), @soluong int, @tacgia nvarchar(100), @theloai nvarchar(50), @nxb nvarchar(50))
as
insert into Sach values(@id,@ten,@soluong,@tacgia,@theloai, @nxb)
GO
/****** Object:  StoredProcedure [dbo].[xem_docgia]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xem_docgia]
as
select * from Docgia
GO
/****** Object:  StoredProcedure [dbo].[xem_sach]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xem_sach]
as
select * from Sach
GO
/****** Object:  StoredProcedure [dbo].[xoa_docgia]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_docgia](
@s nvarchar(10)
)
as
delete
from Docgia
where cmnd=@s

GO
/****** Object:  StoredProcedure [dbo].[xoa_sach]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_sach](
@s nvarchar(10)
)
as
delete
from Sach
where id=@s
GO
/****** Object:  Table [dbo].[Docgia]    Script Date: 5/22/2017 8:02:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docgia](
	[cmnd] [nvarchar](10) NOT NULL,
	[ten] [nvarchar](70) NULL,
	[ngaysinh] [date] NULL,
	[diachi] [text] NULL,
	[gioitinh] [nchar](10) NULL,
	[taikhoan] [nvarchar](50) NULL,
	[matkhau] [nvarchar](10) NULL,
 CONSTRAINT [PK_Docgia_1] PRIMARY KEY CLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Muontra]    Script Date: 5/22/2017 8:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muontra](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[tendocgia] [nvarchar](70) NULL,
	[cmnd] [nvarchar](10) NULL,
	[tensach] [nvarchar](70) NULL,
	[masach] [nvarchar](10) NULL,
	[ngaymuon] [date] NULL,
	[hantra] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 5/22/2017 8:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[id] [nvarchar](10) NOT NULL,
	[ten] [nvarchar](70) NULL,
	[soluong] [int] NULL,
	[tacgia] [nvarchar](100) NULL,
	[theloai] [nvarchar](50) NULL,
	[nxb] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Muontra]  WITH CHECK ADD  CONSTRAINT [fk_cmnd] FOREIGN KEY([cmnd])
REFERENCES [dbo].[Docgia] ([cmnd])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Muontra] CHECK CONSTRAINT [fk_cmnd]
GO
ALTER TABLE [dbo].[Muontra]  WITH CHECK ADD  CONSTRAINT [fk_masach] FOREIGN KEY([masach])
REFERENCES [dbo].[Sach] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Muontra] CHECK CONSTRAINT [fk_masach]
GO
