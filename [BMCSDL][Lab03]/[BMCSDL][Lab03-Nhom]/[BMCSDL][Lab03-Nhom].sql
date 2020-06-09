CREATE DATABASE QLSV_NHOM
GO

USE QLSV_NHOM
GO

CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20) NULL,
	LUONG VARBINARY NULL,
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY NOT NULL,
	PUBKEY VARCHAR(20) NOT NULL
)
GO 

CREATE TABLE LOP
(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20) NULL
)
GO 

CREATE TABLE SINHVIEN
(
	MSSV NVARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME NULL,
	DIACHI NVARCHAR(200) NULL,
	MALOP VARCHAR(20) NULL,
	TENDN NVARCHAR(20) NOT NULL,
	MATKHAU VARBINARY NOT NULL
)
GO 

CREATE TABLE HOCPHAN
(
	MAHP VARCHAR(20) PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT NULL
)
GO 

CREATE TABLE BANGDIEM
(
	MSSV VARCHAR(20) NOT NULL,
	MAHP VARCHAR(20) NOT NULL,
	DIEMTHI VARBINARY(8000) NULL

	PRIMARY KEY (MSSV, MAHP)
)
GO 

--ALTER TABLE dbo.LOP ADD CONSTRAINT fk_LOP_NHANVIEN FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV)
--ALTER TABLE dbo.SINHVIEN ADD CONSTRAINT fk_SINHVIEN_LOP FOREIGN KEY (MALOP) REFERENCES dbo.LOP(MALOP)
--ALTER TABLE dbo.BANGDIEM ADD CONSTRAINT fk_BANGDIEM_SINHVIEN FOREIGN KEY (MSSV) REFERENCES dbo.SINHVIEN(MSSV)
--ALTER TABLE dbo.BANGDIEM ADD CONSTRAINT fk_BANGDIEM_HOCPHAN FOREIGN KEY (MAHP) REFERENCES dbo.HOCPHAN(MAHP)


--i)********************************************************

ALTER PROCEDURE SP_INS_PUBLIC_NHANVIEN
	@MANV VARCHAR(20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR(20),
	@LUONGCB VARCHAR(MAX),
	@TENDN NVARCHAR(100),
	@MK VARCHAR(MAX)
AS
BEGIN
    DECLARE @MATKHAU_ENCRYPTED VARBINARY(8000)
	DECLARE @LUONG_ENCRYPTED VARBINARY(8000)
	DECLARE @STR_CRE_ASYM VARCHAR(MAX)

	SELECT @MATKHAU_ENCRYPTED = HASHBYTES('SHA1', @MK)
	SET @STR_CRE_ASYM = '
		CREATE ASYMMETRIC KEY ' + @MANV + N'
		WITH ALGORITHM = RSA_2048
		ENCRYPTION BY PASSWORD = ''' + @MK + N''';
	'
	EXEC (@STR_CRE_ASYM)
	SELECT @LUONG_ENCRYPTED = ENCRYPTBYASYMKEY(ASYMKEY_ID('' + @MANV + ''), CONVERT(VARCHAR(32), @LUONGCB))

	INSERT dbo.NHANVIEN (MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU, PUBKEY)
	VALUES (@MANV, @HOTEN, @EMAIL, @LUONG_ENCRYPTED, @TENDN, @MATKHAU_ENCRYPTED, @MANV)
END
GO 

EXEC dbo.SP_INS_PUBLIC_NHANVIEN @MANV = 'NV01',
                                @HOTEN = N'NGUYEN VAN A',
                                @EMAIL = 'NVA@',
                                @LUONGCB = '3000000',
                                @TENDN = N'NVA',
                                @MK = 'abcd12'
GO 

SELECT * FROM dbo.NHANVIEN 
GO 
 DELETE dbo.NHANVIEN
 DROP ASYMMETRIC KEY NV01

 