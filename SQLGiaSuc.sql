CREATE DATABASE QUANLYGIASUC

CREATE TABLE GIASUC
(
	LoaiGiaSuc nvarchar(200),
	SoLuongBD int,
	SoConSinhRa int,
	SoLuongSua float,
	TongSoLuong int,
	TiengKeu nvarchar(200)
)

CREATE PROC giasuc_insert
@LoaiGiaSuc nvarchar(200),
@SoLuongBD int,
@SoConSinhRa int,
@SoLuongSua float,
@TongSoLuong int,
@TiengKeu nvarchar(200)
AS
BEGIN
	INSERT INTO GIASUC(LoaiGiaSuc,SoLuongBD, SoConSinhRa, SoLuongSua, TongSoLuong,TiengKeu)
				VALUES(@LoaiGiaSuc,@SoLuongBD, @SoConSinhRa, @SoLuongSua, @TongSoLuong,@TiengKeu)
END
GO

CREATE PROC giasuc_update
@LoaiGiaSuc nvarchar(200),
@SoLuongBD int,
@SoConSinhRa int,
@SoLuongSua float,
@TongSoLuong int,
@TiengKeu nvarchar(200)
AS
BEGIN
	UPDATE GIASUC SET SoLuongBD = @SoLuongBD, SoConSinhRa = @SoConSinhRa, SoLuongSua = @SoLuongSua, TongSoLuong = @TongSoLuong,TiengKeu = @TiengKeu
				  WHERE LoaiGiaSuc = @LoaiGiaSuc
END
GO

CREATE PROC giasuc_delete
AS
BEGIN
	DELETE FROM GIASUC
END
GO

CREATE PROC giasuc_select_all
AS
BEGIN
	SELECT * FROM GIASUC
END
GO

CREATE PROC giasuc_select_byname
@LoaiGiaSuc nvarchar(200)
AS
BEGIN
	SELECT * FROM GIASUC WHERE LoaiGiaSuc = @LoaiGiaSuc
END
GO


