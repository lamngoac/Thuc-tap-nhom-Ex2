use TTN_Ex2

go

create table GIAOVIEN(
	MaGV char(10) primary key,
	TenGV nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
	HocVan nvarchar(50)
)

create table HOCSINH(
	MaHS char(10) primary key,
	TenHS nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
)

create table LOP(
	MaLop char(10),
	MonHoc nvarchar(50),
	MaGV char(10) references GIAOVIEN(MaGV) ON DELETE CASCADE,
	MaHS char(10) references HOCSINH(MaHS) ON DELETE CASCADE
)

select * from GIAOVIEN;

insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0001',N'Đỗ Duy Mạnh',N'Nam','1996-01-01',N'Hà Nội',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0002',N'Trần Đình Trọng',N'Nam','1996-02-02',N'Hà Nội',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0003',N'Phạm Đức Huy',N'Nam','1995-03-03',N'Hà Nội',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0004',N'Nguyễn Quang Hải',N'Nam','1997-03-01',N'Hà Nội',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0005',N'Lương Xuân Trường',N'Nam','1995-10-21',N'Gia Lai',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0006',N'Nguyễn Công Phượng',N'Nam','1995-08-22',N'Gia Lai',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0007',N'Bùi Tiến Dũng',N'Nam','1997-09-23',N'Thanh Hóa',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0008',N'Nguyễn Trọng Hoàng',N'Nam','1989-12-22',N'Thanh Hóa',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0009',N'Phan Văn Đức',N'Nam','1996-08-12',N'Nghệ An',N'Đại Học');
insert into GIAOVIEN(MaGV, TenGV, GioiTinh, NgaySinh, DiaChi, HocVan)
values('GV0010',N'Nguyễn Anh Đức',N'Nam','1985-06-14',N'Bình Dương',N'Đại Học');

select * from HOCSINH;

insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0001',N'Nguyễn Hoàng Lam',N'Nam','2000-06-23',N'Hải Phòng');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0002',N'Mạc Trung Kiên',N'Nam','2000-09-24',N'Hải Phòng');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0003',N'Nguyễn Thanh Tùng',N'Nam','2000-07-18',N'Hà Nội');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0004',N'Nguyễn Minh Hiếu',N'Nam','2000-12-23',N'Hà Nội');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0005',N'Nguyễn Gia Lộc',N'Nam','2000-11-13',N'Hà Nội');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0006',N'Bùi Doãn Hưng',N'Nam','2000-11-22',N'Hà Nội');
insert into HOCSINH(MaHS,TenHS,GioiTinh,NgaySinh,DiaChi)
values('HS0007',N'Vũ Anh Tú',N'Nam','2000-03-31',N'Hà Nội');

select *from LOP;

insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0001');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0002');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0003');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0004');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0005');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0006');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0001',N'Toán','GV0001','HS0007');

insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0001');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0002');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0003');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0004');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0005');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0006');
insert into LOP(MaLop,MonHoc,MaGV,MaHS)
values('LP0002',N'Ngữ Văn','GV0002','HS0007');

create sequence giaovienSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
----------------------------------------------------------------------------------------------------
	select next value for giaovienSeq
	go

create procedure selectAllGV
as
	select distinct GV.MaGV, GV.TenGV, convert(varchar(10),GV.NgaySinh,103) as NgaySinh, GV.DiaChi, GV.GioiTinh, GV.HocVan
	from GIAOVIEN GV
go
exec selectALlGV
go
create procedure selectGVByID @MaGV char(10)
as
begin
	select distinct GV.MaGV, GV.TenGV, convert(varchar(10),GV.NgaySinh,103) as NgaySinh, GV.DiaChi, GV.GioiTinh, GV.HocVan
	from GIAOVIEN GV
	where GV.MaGV = @MaGV
end
exec selectGVByID 'GV0001'
go
create procedure ThemMoiGV
	@MaGV char(10),
	@TenGV nvarchar(50),
	@NS datetime,
	@DC nvarchar(50),
	@GT char(3),
	@HocVan nvarchar(50)

as 
begin
	insert into GIAOVIEN
	(
		MaGV,TenGV,NgaySinh,DiaChi,GioiTinh,HocVan
	)values(
		'GV' + cast(next value for giaovienSeq as char(10)),
		@TenGV,
		@NS,
		@DC,
		@GT,
		@HocVan
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
create procedure selectAllHS
as
	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh
	from HOCSINH
go
exec selectAllHS
go
create procedure selectHSById @Ma char(10)
as
begin

	select MaHS, TenHS, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh
	from HOCSINH
	where MaHS = @Ma

end
go
create procedure ThemMoiHS 
	@TenHS nvarchar(50),
	@NS datetime,
	@DC nvarchar(50),
	@GT char(3)
as
begin
insert into HOCSINH
	(
		MaHS,TenHS,NgaySinh,DiaChi,GioiTinh
	)values(
		'HS' + cast(next value for giaovienSeq as char(10)),
		@TenHS,
		@NS,
		@DC,
		@GT
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end


go

create procedure UpdateHS
	@MaHS char(10),
	@TenHS nvarchar(45),
	@NS datetime,
	@DC nvarchar(45),
	@GT char(3)
as 
begin
	update HOCSINH
	set 
		TenHS = @TenHS,
		NgaySinh = @NS,
		DiaChi = @DC,
		GioiTinh = @GT
	where MaHS = @MaHS;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end
