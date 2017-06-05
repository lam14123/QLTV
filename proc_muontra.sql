create proc them_muontra
(@ten nvarchar(70),
@cmnd nvarchar(10),
@tensach nvarchar(70),
@masach nvarchar(10),
@ngaymuon date,
@hantra date)
as
insert into Muontra
values (@ten,@cmnd,@tensach,@masach,@ngaymuon,@hantra)

create proc xoa_muontra(
@cmnd nvarchar(10))
as
delete from Muontra where cmnd=@cmnd

create proc xem_muontra
as
select * from Muontra