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