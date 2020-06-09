/*----------------------------------------------------------
MASV: 4301104032	
HO TEN: VO THE DUY
LAB: 03_a
NGAY:
----------------------------------------------------------*/

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