use TTN_Ex2;

go

create table LOP(
	MaLop char(10) primary key,
	TenLop nvarchar(50),
)

create table GIAOVIEN(
	MaGV char(10) primary key,
	TenGV nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
	DayMon nvarchar(50),
	HocVan nvarchar(50),
	MaLop char(10) references LOP(MaLop)
)

create table HOCSINH(
	MaHS char(10) primary key,
	TenHS nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
	MaLop char(10) references LOP(MaLop)
)

select * from LOP;

insert into LOP(MaLop,TenLop)
values('LP0001',N'Manchester United');
insert into LOP(MaLop,TenLop)
values('LP0002',N'Manchester City');
insert into LOP(MaLop,TenLop)
values('LP0003',N'Liverpool');
insert into LOP(MaLop,TenLop)
values('LP0004',N'Chelsea');
insert into LOP(MaLop,TenLop)
values('LP0005',N'Tottenham');



insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0001',N'Đỗ Duy Mạnh',N'Nam','1996-01-01',N'Hà Nội',N'Đại Học',N'Toán','LP0001');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0002',N'Trần Đình Trọng',N'Nam','1996-02-02',N'Hà Nội',N'Đại Học',N'Văn','LP0001');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0003',N'Phạm Đức Huy',N'Nam','1995-03-03',N'Hà Nội',N'Đại Học',N'Toán','LP0002');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0004',N'Nguyễn Quang Hải',N'Nam','1997-03-01',N'Hà Nội',N'Đại Học',N'Văn','LP0002');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0005',N'Lương Xuân Trường',N'Nam','1995-10-21',N'Gia Lai',N'Đại Học',N'Toán','LP0003');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0006',N'Nguyễn Công Phượng',N'Nam','1995-08-22',N'Gia Lai',N'Đại Học',N'Văn','LP0003');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0007',N'Bùi Tiến Dũng',N'Nam','1997-09-23',N'Thanh Hóa',N'Đại Học',N'Toán','LP0004');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0008',N'Nguyễn Trọng Hoàng',N'Nam','1989-12-22',N'Thanh Hóa',N'Đại Học',N'Văn','LP0004');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0009',N'Phan Văn Đức',N'Nam','1996-08-12',N'Nghệ An',N'Đại Học',N'Toán','LP0005');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan, DayMon, MaLop)
values('GV0010',N'Nguyễn Anh Đức',N'Nam','1985-06-14',N'Bình Dương',N'Đại Học',N'Văn','LP0005');

select * from GIAOVIEN;

insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0001',N'Nguyễn Hoàng Lam',N'Nam','2000-06-23',N'Hải Phòng','LP0001');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0002',N'Mạc Trung Kiên',N'Nam','2000-09-24',N'Hải Phòng','LP0001');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0003',N'Nguyễn Thanh Tùng',N'Nam','2000-07-18',N'Hà Nội','LP0001');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0004',N'Nguyễn Minh Hiếu',N'Nam','2000-12-23',N'Hà Nội','LP0002');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0005',N'Nguyễn Gia Lộc',N'Nam','2000-11-13',N'Hà Nội','LP0002');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0006',N'Bùi Doãn Hưng',N'Nam','2000-11-22',N'Hà Nội','LP0002');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi,MaLop)
values('HS0007',N'Vũ Anh Tú',N'Nam','2000-03-31',N'Hà Nội','LP0002');

select * from HOCSINH;

--select * from HOCSINH where MaLop = 'LP0001';

create sequence giaovienSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
		select next value for giaovienSeq

create procedure selectAllGV
as
	select MaGV,TenGV, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh, HocVan, DayMon,MaLop
	from GIAOVIEN 
go
exec selectALlGV

alter procedure selectGVByID @MaGV char(10)
as
begin
	select MaGV,TenGV, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh, HocVan, DayMon,MaLop
	from GIAOVIEN 
	where @MaGV = MaGV
end

exec selectGVByID 'GV0001'
alter procedure ThemMoiGV
	@TenGV nvarchar(50),
	@NS datetime,
	@DC nvarchar(50),
	@GT char(3),
	@HocVan nvarchar(50),
	@DayMon nvarchar(50),
	@MaLop char(10)

as 
begin
	insert into GIAOVIEN
	(
		MaGV,TenGV,NgaySinh,DiaChi,GioiTinh,HocVan,DayMon,MaLop
	)values(
		'GV' + cast(next value for giaovienSeq as char(10)),
		@TenGV,
		@NS,
		@DC,
		@GT,
		@HocVan,
		@DayMon,
		@MaLop
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end


alter procedure selectAllHS
as
	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh,MaLop
	from HOCSINH
go
exec selectAllHS
go
alter procedure selectHSById @Ma char(10)
as
begin

	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh, MaLop
	from HOCSINH
	where MaHS = @Ma

end
go
alter procedure ThemMoiHS 
	@TenHS nvarchar(50),
	@NS datetime,
	@DC nvarchar(50),
	@GT char(3),
	@MaLop char(10)
as
begin
insert into HOCSINH
	(
		MaHS,TenHS,NgaySinh,DiaChi,GioiTinh,MaLop
	)values(
		'HS' + cast(next value for giaovienSeq as char(10)),
		@TenHS,
		@NS,
		@DC,
		@GT,
		@MaLop
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end


alter procedure UpdateHS
	@MaHS char(10),
	@TenHS nvarchar(45),
	@NS datetime,
	@DC nvarchar(45),
	@GT char(3),
	@MaLop char(10)
as 
begin
	update HOCSINH
	set 
		TenHS = @TenHS,
		NgaySinh = @NS,
		DiaChi = @DC,
		GioiTinh = @GT,
		MaLop=@MaLop
	where MaHS = @MaHS;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end




----------Tim kiem HS--------
--MaHS--
create procedure searchMHS @MaHS char(10)
as 
begin
	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaLop 
	from HOCSINH
	where MaHS = @MaHS
end
go
exec searchMHS 'HS0007'

go
--TenHS--
create procedure searchTHS @TenHS nvarchar(50)
as 
begin
	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaLop 
	from HOCSINH
	where TenHS = @TenHS
end
go
exec searchTHS N'Vũ Anh Tú'

go

--MaLop--
alter procedure searchHSfromML @MaLop char(10)
as 
begin
	select distinct hs.MaHS, hs.TenHS, convert(varchar(10),hs.NgaySinh,103) 
	as NgaySinh, hs.DiaChi, hs.GioiTinh, hs.MaLop
	from HOCSINH as hs, LOP as lh
	where hs.MaLop = @MaLop
end
go
exec searchHSfromML 'LP0001'


----------Tim kiem GV--------

select * from GIAOVIEN
--MaGV--
create procedure searchMGV @MaGV char(10)
as 
begin
	select MaGV, TenGV, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, DayMon, HocVan, MaLop
	from GIAOVIEN
	where MaGV = @MaGV
end
go
exec searchMGV 'GV0007'

go
--TenGV--
create procedure searchTGV @TenGV nvarchar(50)
as 
begin
	select MaGV, TenGV, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, DayMon, HocVan, MaLop
	from GIAOVIEN
	where TenGV = @TenGV
end
go
exec searchTGV N'Bùi Tiến Dũng'

go

--MaLop--
alter procedure searchGVfromML @MaLop char(10)
as 
begin
	select distinct gv.MaGV, gv.TenGV, convert(varchar(10),gv.NgaySinh,103) 
	as NgaySinh, gv.DiaChi, gv.GioiTinh, gv.DayMon, gv.HocVan, gv.MaLop
	from GIAOVIEN as gv, LOP as lh
	where gv.MaLop = @MaLop
end
go
exec searchGVfromML 'LP0001'