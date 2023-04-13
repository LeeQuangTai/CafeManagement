CREATE DATABASE CafeManagement
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
	FOREIGN KEY (DrinkCategoryID) REFERENCES dbo.DrinkCategory(DrinkCategoryID),
)
GO
---------------------------------------
alter table Drink
drop column status

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
	TableID NVARCHAR (50) NOT NULL,
	BillStatus INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	Discount int not null default 0,
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
	
GO
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
EXEC sp_AddTableManagement N'B01', N'Bàn 01', N'Trống'
EXEC sp_AddTableManagement N'B02', N'Bàn 02', N'Trống'
EXEC sp_AddTableManagement N'B03', N'Bàn 03', N'Trống'
EXEC sp_AddTableManagement N'B04', N'Bàn 04', N'Trống'
EXEC sp_AddTableManagement N'B05', N'Bàn 05', N'Trống'
EXEC sp_AddTableManagement N'B06', N'Bàn 06', N'Trống'
EXEC sp_AddTableManagement N'B07', N'Bàn 07', N'Trống'
EXEC sp_AddTableManagement N'B08', N'Bàn 08', N'Trống'
EXEC sp_AddTableManagement N'B09', N'Bàn 09', N'Trống'
EXEC sp_AddTableManagement N'B10', N'Bàn 10', N'Trống'
GO
-----------------------------------------


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

--------------------------
CREATE PROCEDURE sp_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
		SELECT * FROM dbo.Account WHERE @userName = UserName
END
GO
----------------
CREATE PROCEDURE sp_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
-------------Lấy danh sách BillInfo
Create procedure sp_GetListBillInfo @BillID int
as
begin
	select * from dbo.BillInfo where @BillID = BillID
end
GO

--------------lấy ra BillID chưa thanh toán
Create procedure GetBillIDuncheck @TableID nvarchar(50), @BillStatus int
as
begin
	select * from dbo.Bill where @TableID = TableID and @BillStatus = BillStatus
end
Go
------

--lấy danh sách order
create procedure sp_GetListOrderByTable @TableID nvarchar(50), @BillStatus int
as
begin
		select DrinkName, UnitPrice, Quantity, UnitPrice*Quantity as TotalPrice
		from dbo.Bill b, dbo.BillInfo bi, dbo.Drink d
		where b.BillID = bi.BillID and bi.DrinkID = d.DrinkID and b.TableID = @TableID and  @BillStatus = b.BillStatus
end
Go
--------
--Lấy danh sách đồ uống dựa trên DrinkCategoryID
create procedure sp_GetListDrinkByDrinkCategory @DrinkCategoryID varchar(50)
as
begin
		select * from dbo.Drink where @DrinkCategoryID = DrinkCategoryID
end
Go
--------
--Thêm bill
CREATE PROCEDURE sp_InsertBill  @TableID nvarchar(50)
As
Begin

	INSERT INTO [dbo].[Bill]
           ( 
           [DateCheckIn]
           ,[DateCheckOut]
           ,[TableID]
           ,[BillStatus]
		   ,[Discount])
		VALUES
           ( 
           Getdate()
           ,null
           ,@TableID
           ,0,
		   0)
end
GO
-------------
---Thêm BillInfo
CREATE PROCEDURE sp_InsertBillInfo @BillID int, @DrinkID varchar(50), @Quantity int
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
           (
           [BillID]
           ,[DrinkID]
           ,[Quantity])
		VALUES
           (
           @BillID
           ,@DrinkID
           ,@Quantity)
end
GO 
--------

--------Xóa hóa bàn order--------

Create PROCEDURE sp_Delete @TableID nvarchar(50), @BillID int
AS
BEGIN
		SELECT @BillID = BillID FROM dbo.Bill WHERE @TableID = TableID and BillStatus = 0
		DELETE FROM BillInfo WHERE @BillID = BillID
		DELETE FROM Bill WHERE @TableID = TableID and BillStatus = 0
		UPDATE dbo.TableManagement SET Status = N'Trống' WHERE @TableID = TableID
END
GO
------- Lấy danh sách hóa đơn
Create procedure sp_GetListViewBill @BillID int, @DateCheckIn Date
as
begin
		select DrinkName, UnitPrice, Quantity, (UnitPrice*Quantity) as TotalPrice, DateCheckIn, TableID, Discount
		from dbo.Bill b, dbo.BillInfo bi, dbo.Drink d
		where b.BillID = @BillID and @DateCheckIn = DateCheckIn and
			b.BillID = bi.BillID and bi.DrinkID = d.DrinkID
end
Go
-----Lấy mã hóa đơn theo ngày
Create procedure sp_GetListBillID @DateCheckIn Date
as
begin
	select * 
	from dbo.Bill 
	where @DateCheckIn = DateCheckIn
end
go
exec sp_GetListBillID '4/10/2023'
----------
CREATE procedure sp_GetTotalMoney @BillID int
as
begin
	select SUM(UnitPrice * Quantity - UnitPrice * Quantity * (Discount * 1.0 / 100)) as TotalMoney
	from dbo.BillInfo bi, dbo.Drink d, dbo.Bill b
	where bi.BillID = @BillID and
			b.BillID = bi.BillID and
			bi.DrinkID = d.DrinkID
end
go
exec sp_GetTotalMoney 4
----------------------Xử lý chuyển Bàn--------------------
-----------------------Store Procedure ---------
Create PROCEDURE sp_Transfer @TableID1 nvarchar(50), @TableID2 nvarchar (50)
AS
BEGIN
	DECLARE @BillID1 int
	DECLARE @BillID2 int

	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1
	DECLARE @isTableEmpty1 INT = 1
	DECLARE @isTableEmpty2 INT = 1

	SELECT @BillID2 = BillID FROM dbo.Bill WHERE TableID = @TableID2 AND BillStatus = 0
	SELECT @BillID1 = BillID FROM dbo.Bill WHERE TableID = @TableID1 AND BillStatus = 0
	
	IF(@BillID1 is not null AND @BillID2 is not null)
		BEGIN
			--Gộp bàn thứ 1 vào bàn thứ 2 bằng cách thay BillID trong bảng BillInfo
			UPDATE BillInfo SET BillID = @BillID2 WHERE BillID = @BillID1

			--Khi gộp bàn sẽ xuất hiện các món trùng lặp với nhau
			--Tạo con trỏ và lấy ra các FoodID với số lần trùng lặp
			DECLARE BillInfoCursor CURSOR FOR SELECT DrinkID, count(*) AS 'Count' FROM BillInfo WHERE BillID = @BillID2 GROUP BY DrinkID
			OPEN BillInfoCursor

			DECLARE @DrinkID INT
			DECLARE @Quantity INT

			FETCH NEXT FROM BillInfoCursor INTO @DrinkID, @Quantity

			WHILE @@FETCH_STATUS = 0
				BEGIN
					--Trường hợp @count > 1 tức là món này bị trùng nhau, xuất hiện hơn 1 lần
					IF(@Quantity > 1) 
						BEGIN
							DECLARE @finalFoodCount INT = 0
							--Tính gộp tổng các FoodCount của món này
							SELECT @finalFoodCount = SUM(Quantity) FROM BillInfo WHERE BillID = @BillID2 AND DrinkID = @DrinkID
			
							DECLARE @maxID INT = 0
							--Lấy ra max ID của món này để tí nữa giữ lại, các ID khác xoá hết cho khỏi trùng nhau
							SELECT @maxID = MAX(BillInfoID) FROM BillInfo WHERE BillID = @BillID2 AND DrinkID = @DrinkID

							--update số lượng món ăn cho ID này
							UPDATE BillInfo SET Quantity = @finalFoodCount WHERE BillID = @BillID2 AND DrinkID = @DrinkID AND BillInfoID = @maxID --Cài nhiều điều kiện cho chắc kèo

							--Xoá các ID còn lại
							DELETE BillInfo WHERE BillID = @BillID2 AND DrinkID = @DrinkID AND BillInfoID != @maxID
						END

					FETCH NEXT FROM BillInfoCursor INTO @DrinkID, @Quantity
				END

			CLOSE BillInfoCursor
			DEALLOCATE BillInfoCursor
		END

	IF (@BillID1 IS NULL)
	BEGIN
	INSERT dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    TableID,
		    BillStatus,
		    Discount
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    NULL, -- DateCheckOut - date
		    @TableID1,         -- BanSo - nvarchar
		    0,         -- ThanhToan - int
		    0          -- discount - int
		    )
			SELECT @BillID1 = MAX(BillID) FROM dbo.Bill WHERE TableID = @TableID1 AND BillStatus = 0
	END

	SELECT @isFirstTableEmpty  = COUNT (*) FROM dbo.BillInfo WHERE BillID = @BillID1
	
	IF (@BillID2 IS NULL)
	BEGIN
	INSERT dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    TableID,
		    BillStatus,
		    Discount
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    NULL, -- DateCheckOut - date
		    @TableID2,         -- BanSo - nvarchar
		    0,         -- ThanhToan - int
		    0          -- discount - int
		    )
			SELECT @BillID2 = MAX(BillID) FROM dbo.Bill WHERE TableID = @TableID2 AND BillStatus = 0
		END

	SELECT @isSecondTableEmpty  = COUNT (*) FROM dbo.BillInfo WHERE BillID = @BillID2

	SELECT BillID INTO IDBillInfoTable FROM dbo.BillInfo WHERE BillID = @BillID1

	UPDATE dbo.BillInfo SET BillID = @BillID2 WHERE BillID = @BillID1
	UPDATE dbo.BillInfo SET BillID = @BillID1 WHERE BillID IN (SELECT * FROM dbo.IdBillInfoTable)	
	DROP TABLE dbo.IdBillInfoTable
	IF (@isTableEmpty1 = 0)
		Begin
		UPDATE dbo.TableManagement SET Status = N'Trống' WHERE TableID = @TableID2
		end
		
	IF (@isTableEmpty2= 0)
		begin
		UPDATE dbo.TableManagement SET Status = N'Trống' WHERE TableID = @TableID1
		
		end

END
GO
---------------------Create Trigger-----------------------

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @BillID INT
	
	SELECT @BillID = BillID FROM Inserted
	
	DECLARE @TableID nvarchar(50)
	
	SELECT @TableID = TableID FROM dbo.Bill WHERE BillID = @BillID AND BillStatus = 0
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE BillID = @BillID
	IF(@count>0)
	Begin

		UPDATE dbo.TableManagement SET Status = N'Có người' WHERE TableID = @TableID
	End
	Else
	Begin
		UPDATE dbo.TableManagement SET Status = N'Trống' WHERE TableID = @TableID	

	End
END
GO
------------
Create TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @BillID INT
	
	SELECT @BillID = BillID FROM Inserted	
	
	DECLARE @TableID nvarchar(50)
	
	SELECT @TableID = TableID FROM dbo.Bill WHERE BillID = @BillID

	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE @TableID = TableID AND BillStatus = 0
	
	IF (@count = 0)
		UPDATE dbo.TableManagement SET Status = N'Trống' WHERE @TableID = TableID
		
END
GO
------
---------
-------------------------------------------------TEST---------------------
select * from bill
select * from BillInfo
select * from TableManagement