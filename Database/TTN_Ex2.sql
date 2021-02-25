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

create table SINHVIEN(
	MaSV char(10) primary key,
	TenSV nvarchar(50),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	NgaySinh datetime,
	DiaChi nvarchar(50),
)

create table LOP(
	MaLop char(10),
	MonHoc nvarchar(50),
	MaGV char(10) references GIAOVIEN(MaGV),
	MaSV char(10) references SINHVIEN(MaSV)
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

select *from LOP;

insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0001');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0002');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0003');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0004');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0005');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0006');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0001',N'Toán','GV0001','SV0007');

insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0001');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0002');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0003');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0004');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0005');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0006');
insert into LOP(MaLop,MonHoc,MaGV,MaSV)
values('LP0002',N'Ngữ Văn','GV0002','SV0007');

