﻿use QLSV_Ex2
go

create table MONHOC(
	MaMH char(10) primary key,
	TenMH nvarchar(50),
	TC int default(3) 
) 

create table GIAOVIEN(
	MaGV char(10) primary key,
	TenGV nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
	HocVan nvarchar(50)
)

create table SINHVIEN(
	MaSV char(10) primary key,
	TenSV nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
)

create table DIEM(
	MaMH char(10) references MONHOC(MaMH),
	MaGV char(10) references GIAOVIEN(MaGV),
	MaSV char(10) references SINHVIEN(MaSV),
	DiemThi1 int,
	DiemThi2 int
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

select * from SINHVIEN;

insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0001',N'Nguyễn Hoàng Lam',N'Nam','2000-06-23',N'Hải Phòng');

insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0002',N'Mạc Trung Kiên',N'Nam','2000-09-24',N'Hải Phòng');
insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0003',N'Nguyễn Thanh Tùng',N'Nam','2000-07-18',N'Hà Nội');
insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0004',N'Nguyễn Minh Hiếu',N'Nam','2000-12-23',N'Hà Nội');
insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0005',N'Nguyễn Gia Lộc',N'Nam','2000-11-13',N'Hà Nội');
insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0006',N'Bùi Doãn Hưng',N'Nam','2000-11-22',N'Hà Nội');
insert into SINHVIEN(MaSV,TenSV,GioiTinh,NgaySinh,DiaChi)
values('SV0007',N'Vũ Anh Tú',N'Nam','2000-03-31',N'Hà Nội');

select * from MONHOC;

insert into MONHOC(MaMH, TenMH, TC)
values('MH0001',N'Toán',3);

insert into MONHOC(MaMH, TenMH, TC)
values('MH0002',N'Ngữ Văn',3);

insert into MONHOC(MaMH, TenMH, TC)
values('MH0003',N'Lý',2);

insert into MONHOC(MaMH, TenMH, TC)
values('MH0004',N'Hóa ',2);

insert into MONHOC(MaMH, TenMH, TC)
values('MH0005',N'Sinh',2);
