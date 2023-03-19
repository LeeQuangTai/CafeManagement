﻿CREATE DATABASE CafeManagement
GO
USE CafeManagement
GO
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO
---------------------------------------
CREATE TABLE DrinkCategory
(
	DrinkCategoryID NVARCHAR(50) NOT NULL PRIMARY KEY,
	DrinkCategoryName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO
---------------------------------------
CREATE TABLE Drink
(
	DrinkID NVARCHAR(50) NOT NULL PRIMARY KEY,
	DrinkCategoryID NVARCHAR(50) NOT NULL,
	DrinkName NVARCHAR(50) NOT NULL,
	UnitPrice SMALLMONEY DEFAULT 0,
	Status BIT DEFAULT 1,
	FOREIGN KEY (DrinkCategoryID) REFERENCES dbo.DrinkCategory(DrinkCategoryID),
)
GO
---------------------------------------

CREATE TABLE TableManagement
(
	TableID NVARCHAR(50) PRIMARY KEY,
	TableName NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	Status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- unoccupied || occupied	
)
GO
---------------------------------------
CREATE TABLE Bill
(
	BillID int Identity PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	TableID NVARCHAR(50) NOT NULL,
	BillStatus INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (TableID) REFERENCES dbo.TableManagement(TableID)
)
GO
---------------------------------------
CREATE TABLE BillInfo 
(
	BillInfoID int Identity PRIMARY KEY,
	BillID int NOT NULL,
	DrinkID NVARCHAR(50) NOT NULL,
	Quantity INT NOT NULL DEFAULT 0
	FOREIGN KEY (BillID) REFERENCES dbo.Bill(BillID),
	FOREIGN KEY (DrinkID) REFERENCES dbo.Drink(DrinkID),
)
GO

----------------THỦ TỤC NHẬP LIỆU----------------------------
CREATE PROCEDURE sp_AddAccount
				@UserName NVARCHAR(100) ,	
				@DisplayName NVARCHAR(100),
				@PassWord NVARCHAR(1000),
				@Type INT 
AS
IF		EXISTS (SELECT * FROM	Account WHERE	UserName=@UserName)
		PRINT N'Đã tồn tại'
ELSE
		INSERT INTO [dbo].[Account]
           ([UserName]
           ,[DisplayName]
           ,[PassWord]
           ,[Type])
		VALUES
           (@UserName
           ,@DisplayName
           ,@PassWord
           ,@Type)
GO
----
EXEC sp_AddAccount
	@UserName = 'admin',
    @DisplayName = 'Admin',
    @PassWord = '123456',
    @Type = 1
GO
------------------------------
CREATE PROCEDURE sp_AddDrinkCategory
				@DrinkCategoryID NVARCHAR(50),
				@DrinkCategoryName NVARCHAR(100)
AS
IF		EXISTS (SELECT * FROM	DrinkCategory WHERE	DrinkCategoryID=@DrinkCategoryID)
		PRINT N'Đã tồn tại'
ELSE
	INSERT INTO [dbo].[DrinkCategory]
           ([DrinkCategoryID]
           ,[DrinkCategoryName])
     VALUES
           (@DrinkCategoryID
           ,@DrinkCategoryName)
GO
----

EXECUTE [dbo].[sp_AddDrinkCategory] 
   @DrinkCategoryID = 'CAFE'
  ,@DrinkCategoryName = N'Cà phê'
EXECUTE [dbo].[sp_AddDrinkCategory] 
   @DrinkCategoryID = 'NUOCEP'
  ,@DrinkCategoryName = N'Nước ép'
EXECUTE [dbo].[sp_AddDrinkCategory] 
   @DrinkCategoryID = 'TRASUA'
  ,@DrinkCategoryName = N'Trà sữa'
EXECUTE [dbo].[sp_AddDrinkCategory] 
   @DrinkCategoryID = 'DAXAY'
  ,@DrinkCategoryName = N'Đá xay'
  EXECUTE [dbo].[sp_AddDrinkCategory] 
   @DrinkCategoryID = 'SODA'
  ,@DrinkCategoryName = N'Soda'
GO
------------------------------
CREATE PROCEDURE sp_AddDrink
				@DrinkID NVARCHAR(50),
				@DrinkCategoryID NVARCHAR(50) ,
				@DrinkName NVARCHAR(50),
				@UnitPrice SMALLMONEY,
				@Status BIT 
AS
IF		EXISTS (SELECT * FROM	Drink WHERE	DrinkID=@DrinkID)
		PRINT N'Đã tồn tại'
ELSE
	INSERT INTO [dbo].[Drink]
           ([DrinkID]
           ,[DrinkCategoryID]
           ,[DrinkName]
           ,[UnitPrice]
           ,[Status])
     VALUES
           (@DrinkID
           ,@DrinkCategoryID
           ,@DrinkName
           ,@UnitPrice
           ,@Status)
GO
EXEC sp_AddDrink '01', N'CAFE', N'Cà phê đen', 25000, 10
EXEC sp_AddDrink '02', N'CAFE', N'Cà phê sữa', 25000, 10
EXEC sp_AddDrink '03', N'CAFE', N'Bạc xỉu', 25000, 10
EXEC sp_AddDrink '04', N'SODA', N'Soda chanh bạc hà', 40000, 10
EXEC sp_AddDrink '05', N'SODA', N'Soda đào', 40000, 10
EXEC sp_AddDrink '06', N'TRASUA', N'Trà sữa truyền thống', 35000, 10
EXEC sp_AddDrink '07', N'TRASUA', N'Trà sữa Thái xanh', 25000, 10
EXEC sp_AddDrink '08', N'NUOCEP', N'Nước ép cam', 25000, 10
EXEC sp_AddDrink '09', N'NUOCEP', N'Nước ép ổi', 25000, 10
EXEC sp_AddDrink '10', N'DAXAY', N'Matcha Đá xay', 25000, 10
	
--GO
------------------------------
CREATE PROCEDURE sp_AddTableManagement
				@TableID NVARCHAR(50),
				@TableName NVARCHAR(100),
				@Status VARCHAR(100)
AS
IF		EXISTS (SELECT * FROM	TableManagement WHERE	TableID=@TableID)
		PRINT N'Đã tồn tại'
ELSE
		INSERT INTO [dbo].[TableManagement]
           ([TableID]
           ,[TableName]
           ,[Status])
     VALUES
           (@TableID
           ,@TableName
           ,@Status)
GO
EXEC sp_AddTableManagement B01, N'Bàn 01', N'Trống'
EXEC sp_AddTableManagement B02, N'Bàn 02', N'Trống'
EXEC sp_AddTableManagement B03, N'Bàn 03', N'Trống'
EXEC sp_AddTableManagement B04, N'Bàn 04', N'Trống'
EXEC sp_AddTableManagement B05, N'Bàn 05', N'Trống'
EXEC sp_AddTableManagement B06, N'Bàn 06', N'Trống'
EXEC sp_AddTableManagement B07, N'Bàn 07', N'Trống'
EXEC sp_AddTableManagement B08, N'Bàn 08', N'Trống'
EXEC sp_AddTableManagement B09, N'Bàn 09', N'Trống'
EXEC sp_AddTableManagement B10, N'Bàn 10', N'Trống'

-----------------------------------------

CREATE PROCEDURE sp_AddBill
				@BillID int,
				@DateCheckIn DATE,
				@DateCheckOut DATE,
				@TableID NVARCHAR(50),
				@BillStatus INT
AS
IF		EXISTS (SELECT * FROM	Bill WHERE	BillID=@BillID)
		PRINT N'Đã tồn tại'
ELSE
		INSERT INTO [dbo].[Bill]
           (
           [DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus])
		VALUES
           (
           @DateCheckIn
           ,@DateCheckOut
           ,@TableID
           ,@BillStatus)
GO

		   
INSERT INTO [dbo].[Bill]
           (
           [DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus])
     values 
           (
           GETDATE()
           ,null
           ,'B01'
           ,0)
INSERT INTO [dbo].[Bill]
           (
           [DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus])
     values 
           (
           getdate()
           ,null
           ,'B01'
           ,1)
INSERT INTO [dbo].[Bill]
           (
           [DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus])
     values 
           (
           GETDATE()
           ,null
           ,'B02'
           ,0)


--------------------------

CREATE PROCEDURE sp_AddBillInfo 
				
				@BillID NVARCHAR(50),
				@DrinkID NVARCHAR(50),
				@Quantity INT
AS

		INSERT INTO [dbo].[BillInfo]
           (
           [BillID]
           ,[DrinkID]
           ,[Quantity])
     VALUES
           (
           @BillID
           ,@DrinkID
           ,@Quantity)
GO
EXEC sp_AddBillInfo  '01', '02', 2
EXEC sp_AddBillInfo  '01', '04', 1
EXEC sp_AddBillInfo '01', '05', 1
EXEC sp_AddBillInfo  '02', '05', 1
EXEC sp_AddBillInfo  '02', '05', 1
EXEC sp_AddBillInfo  '03', '05', 1
--------------------------
CREATE PROCEDURE sp_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
		SELECT * FROM dbo.Account WHERE @userName = UserName
END
GO
EXEC sp_GetAccountByUserName @userName = 'admin'
----------------
CREATE PROCEDURE sp_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
EXEC sp_Login @userName = 'admin', @passWord = '123456'
Go
-------------
Create procedure sp_GetListBillInfo @BillID int
as
begin
	select * from dbo.BillInfo where @BillID = BillID
end
exec sp_GetListBillInfo 2

--------------
Create procedure GetBillIDuncheck @TableID nvarchar(50), @BillStatus int
as
begin
	select * from dbo.Bill where @TableID = TableID and @BillStatus = BillStatus
end
exec GetBillIDuncheck 'B02', 0
------
select * from dbo.Bill
--lấy danh sách order
create procedure sp_GetListOrderByTable @TableID nvarchar(50), @BillStatus int
as
begin
		select DrinkName, UnitPrice, Quantity, UnitPrice*Quantity as TotalPrice
		from dbo.Bill b, dbo.BillInfo bi, dbo.Drink d
		where b.BillID = bi.BillID and bi.DrinkID = d.DrinkID and b.TableID = @TableID and  @BillStatus = BillStatus
end
exec sp_GetListOrderByTable 'B01', 0	
--------
--Lấy danh sách đồ uống dựa trên DrinkCategoryID
create procedure sp_GetListDrinkByDrinkCategory @DrinkCategoryID varchar(50)
as
begin
		select * from dbo.Drink where @DrinkCategoryID = DrinkCategoryID
end
exec sp_GetListDrinkByDrinkCategory @DrinkCategoryID = 'CAFE'
--------
--Thêm bill
CREATE PROCEDURE sp_InsertBill @BillID varchar(50), @TableID nvarchar(50)
As
Begin
IF		EXISTS (SELECT * FROM	Bill  WHERE	@BillID=BillID )
		PRINT N'Đã tồn tại'
ELSE
	INSERT INTO [dbo].[Bill]
           ([BillID] 
           ,[DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus])
		VALUES
           ( @BillID 
           ,Getdate()
           ,null
           ,@TableID
           ,0)
end
GO
-------------
---Thêm BillInfo
CREATE PROCEDURE sp_InsertBillInfo @BillID varchar(50), @BillInfoID varchar(50), @DrinkID varchar(50), @Quantity int
As
Begin
DECLARE @isExitsBillInfo varchar(50)
DECLARE @Drinkcount int = 1
	
SELECT @isExitsBillInfo = BillInfoID, @Drinkcount = b.Quantity 
FROM dbo.BillInfo AS b 
WHERE BillID = @BillID AND DrinkID = @DrinkID

	IF (@isExitsBillInfo > 0)
		BEGIN
			DECLARE @newCount INT = @Drinkcount + @Quantity
			IF (@newCount > 0)
				UPDATE dbo.BillInfo	SET Quantity = @Drinkcount + @Quantity WHERE DrinkID = @DrinkID
			ELSE
				DELETE dbo.BillInfo WHERE BillID = @BillID AND DrinkID = @DrinkID
		END
	ELSE
		INSERT INTO [dbo].[BillInfo]
           ([BillInfoID]
           ,[BillID]
           ,[DrinkID]
           ,[Quantity])
		VALUES
           (@BillInfoID
           ,@BillID
           ,@DrinkID
           ,@Quantity)
end
GO
--------
select * from Bill
select * from BillInfo
select * from TableManagement
select * from Drink
select * from DrinkCategory



SELECT * FROM dbo.BillInfo WHERE billID = '01'
SELECT * FROM dbo.Bill WHERE TableID = 'B01' AND BillStatus = 0
select * from Drink where DrinkCategoryID='CAFE'