```
/*----------------------------------------------------------
MASV: 	4301104032	
HO TEN: VO THE DUY
LAB: 	03
NGAY:
----------------------------------------------------------*/
```

## 1. Viết script tạo Database có tên QLSV.
```
USE [master]
GO
 
IF(DB_ID(N'QLSV') IS NOT NULL)
BEGIN
	DROP DATABASE [QLSV]
END
GO 
 
CREATE DATABASE [QLSV]
GO 
 
USE [QLSV]
GO
```

## 2. Viết script tạo mới các Table SINHVIEN, NHANVIEN, LOP như mô tả.
```
USE [QLSV]
GO
  
CREATE TABLE [NHANVIEN]
(
	[MANV] VARCHAR(20) PRIMARY KEY,
	[HOTEN] NVARCHAR(100) NOT NULL,
	[EMAIL] VARCHAR(20) NULL,
	[LUONG] VARBINARY(8000) NULL,
	[TENDN] NVARCHAR(100) NOT NULL,
	[MATKHAU] VARBINARY(8000) NOT NULL
)
GO 
 
CREATE TABLE [LOP]
(
	[MALOP] VARCHAR(20) PRIMARY KEY,
	[TENLOP] NVARCHAR(100) NOT NULL,
	[MANV] VARCHAR(20) NULL
)
GO 
 
CREATE TABLE [SINHVIEN]
(
	[MSSV] NVARCHAR(20) PRIMARY KEY,
	[HOTEN] NVARCHAR(100) NOT NULL,
	[NGAYSINH] DATETIME NULL,
	[DIACHI] NVARCHAR(200) NULL,
	[MALOP] VARCHAR(20) NULL,
	[TENDN] NVARCHAR(20) NOT NULL,
	[MATKHAU] VARBINARY(8000) NOT NULL
)
GO 
 
--ALTER TABLE dbo.[LOP] ADD CONSTRAINT fk_LOP_NHANVIEN FOREIGN KEY ([MANV]) REFERENCES dbo.[NHANVIEN]([MANV])
--ALTER TABLE dbo.[SINHVIEN] ADD CONSTRAINT fk_SINHVIEN_LOP FOREIGN KEY ([MALOP]) REFERENCES dbo.[LOP]([MALOP])
```

## 3. Viết các Stored procedure
### 3.1. Stored dùng để thêm mới dữ liệu (Insert) vào table SINHVIEN, trong đó thuộc tính MATKHAU được mã hóa (HASH) sử dụng MD5
```
CREATE PROCEDURE [SP_INS_SINHVIEN]
	@MSSV NVARCHAR(20),
	@HOTEN NVARCHAR(100),
	@NGAYSINH DATETIME,
	@DIACHI NVARCHAR(200),
	@MALOP VARCHAR(20),
	@TENDN NVARCHAR(100),
	@MATKHAU VARCHAR(MAX)
AS 
BEGIN
	DECLARE @MATKHAU_ENCRYPTION VARBINARY(8000)
	SET @MATKHAU_ENCRYPTION = HASHBYTES('MD5', @MATKHAU)
	INSERT dbo.SINHVIEN ([MSSV], [HOTEN], [NGAYSINH], [DIACHI], [MALOP], [TENDN], [MATKHAU])
	VALUES (@MSSV, @HOTEN, @NGAYSINH, @DIACHI, @MALOP, @TENDN, @MATKHAU_ENCRYPTION)
END
GO 
```

### 3.2. Stored dùng để thêm mới dữ liệu (Insert) vào table NHANVIEN, trong đó thuộc tính MATKHAU được mã hóa (HASH) sử dụng SHA1 và thuộc tính LUONG sẽ được mã hóa sử dụng thuật toán AES 256, với khóa mã hóa là mã số của sinh viên thực hiện bài Lab này.
```
CREATE SYMMETRIC KEY [SK_4301104032]
WITH  
    ALGORITHM = AES_256,  
	KEY_SOURCE = '4301104032'
ENCRYPTION BY PASSWORD = 'K4301104032'; 
GO 
 
CREATE PROCEDURE [SP_INS_NHANVIEN ]
	@MANV VARCHAR(20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR(20),
	@LUONG VARCHAR(MAX),
	@TENDN NVARCHAR(100),
	@MATKHAU VARCHAR(MAX)
AS  
BEGIN  
    OPEN SYMMETRIC KEY [SK_4301104032] DECRYPTION BY PASSWORD = 'K4301104032'  
 
	DECLARE @MATKHAU_ENCRYPTION VARBINARY(8000)
	DECLARE @LUONG_ENCRYPTION VARBINARY(8000)
	SET @MATKHAU_ENCRYPTION = HASHBYTES('SHA1', @MATKHAU)
	SET @LUONG_ENCRYPTION = ENCRYPTBYKEY(KEY_GUID('SK_4301104032'), CONVERT(VARCHAR(MAX), @LUONG))
 
    INSERT INTO dbo.[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [LUONG], [TENDN], [MATKHAU])
    VALUES (@MANV, @HOTEN, @EMAIL, @LUONG_ENCRYPTION, @TENDN, @MATKHAU_ENCRYPTION)
 
    CLOSE SYMMETRIC KEY [SK_4301104032];
END 
GO
```

## 4. Viết màn hình quản lý đăng nhập hệ thống (sử dụng C#), cho phép nhập vào tên đăng nhập và mật khẩu (giả sử tên đăng nhập của sinh viên và nhân viên là duy nhất, nghĩa là tên đăng nhập của tất cả các sinh viên và tất cả nhân viên là khác nhau).

![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%204.1%20M%C3%A0n%20h%C3%ACnh%20%C4%91%C4%83ng%20nh%E1%BA%ADp.png?raw=true)
###### *Hình 4.1: Màn hình đăng nhập*
</br>

![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%204.2%20%C4%90%C4%83ng%20nh%E1%BA%ADp%20th%C3%A0nh%20c%C3%B4ng%20v%E1%BB%9Bi%20NVA%20123456.png?raw=true)
###### *Hình 4.2: Đăng nhập thành công với 'NVA/123456'*
</br>

![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%204.3%20%C4%90%C4%83ng%20nh%E1%BA%ADp%20th%E1%BA%A5t%20b%E1%BA%A1i%20v%E1%BB%9Bi%20VTD%20123.png?raw=true)
###### *Hình 4.3: Đăng nhập thất bại với 'VTD/123'*
</br>

## 5. Sử dụng công cụ SQL Profile để theo dõi thao tác đăng nhập từ màn hình quản lý đăng nhập trên, nhận xét.
### 5.1. Mở màn hình quản lý đăng nhập

![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%205.1%20M%C3%A0n%20h%C3%ACnh%20%C4%91%C4%83ng%20nh%E1%BA%ADp.png?raw=true)
###### *Hình 5.1: Màn hình đăng nhập*
</br>

### 5.2. Nhập tên đăng nhập và mật khẩu
![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%205.2%20%C4%90%C4%83ng%20nh%E1%BA%ADp%20th%C3%A0nh%20c%C3%B4ng%20v%E1%BB%9Bi%20NVA%20abcd12.png?raw=true)
###### *Hình 5.2: Màn hình đăng nhập với 'NVA/abcd12'*
</br>

### 5.3. Nhấn nút đăng nhập
![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%205.3%20M%C3%A0n%20h%C3%ACnh%20%C4%91%C4%83ng%20nh%E1%BA%ADp%20v%E1%BB%9Bi%20NVA%20abcd12.png?raw=true)
###### *Hình 5.3: Đăng nhập thành công với 'NVA/abcd12'*
</br>

### 5.4. Chuyển sang màn hình SQL Profile, xem kết quả và viết nhận xét
![alt text](https://github.com/duyvt-it/-BMCSDL-Lab03-CaNhan-/blob/master/%5BBMCSDL%5D%5BLab03-CaNhan%5D%5BCapture%5D/H%C3%ACnh%205.4%20SQL%20Profiler.png?raw=true)
###### *Hình 5.4: SQL Profiler*
</br>

> Nhận xét
> - Người dùng được cấp quyền Profiler có thể theo dõi được thời gian thực hiện, thời gian kết thúc và các tham số cũng như giá trị của tham số truyền vào khi khởi chạy stored procedure.
> - Mật khẩu không được mã hóa trước ở Màn hình đăng nhập nên có thể bị lộ khi thực hiện truy vấn tài khoản từ ứng dụng tới database
