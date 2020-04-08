USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[ProductManagement_sp]    Script Date: 2020-04-08 10:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProductManagement_sp]
	@Action		   VarChar(50),
	@Productid	   INT,
	@Name		   VarChar(100),
	@Brand		   VarChar(100),
	@UnitNbr	   Int,
	@QtyMin		   Int, 
	@QtyMax		   Int,
	@CategoryId    Int,
	@DepartementId Int,
	@Description   VarChar(200),
	@Price         DEC(18,2),
	@UnitId        Int,
	@SupplierCode  VarChar(50),
	@SupplierName  VARCHAR(100),
	@isActive      Bit
	AS

	DECLARE
	@BarCode Varchar(7)

	
	

	IF @Action = 'add' BEGIN

		INSERT INTO Tbl_Product(Name,Brand,Description,UnitNbr,QtyMin,QtyMax ,Price,IsActive,MesuringUnitID,CategoryID,DepartementID,SupplierName,SupplierCode,LastUpdate,BarCodeId)
		VALUES(@Name, @Brand, @Description,  @UnitNbr, @QtyMin, @QtyMax, @Price, @isActive, @UnitId, @CategoryId, @DepartementId, @SupplierName, @SupplierCode, GETDATE(), '')
		
		SET @Productid = SCOPE_IDENTITY()

		IF LEN(@Productid) = 3 BEGIN
			SET @BarCode = 'P000' + CONVERT(VARCHAR(3),@Productid)
		END ELSE IF LEN(@Productid) = 4 BEGIN
			SET @BarCode = 'P00'  + CONVERT(VARCHAR(4),@Productid)
		END ELSE IF LEN(@Productid) = 5 BEGIN
			SET @BarCode = 'P0'   + CONVERT(VARCHAR(5),@Productid)
		END ELSE BEGIN
			SET @BarCode = 'P'   + CONVERT(VARCHAR(6),@Productid)
		END

		UPDATE Tbl_Product 
		SET BarCodeId = @BarCode
		WHERE ProductID = @Productid

	END ELSE IF @Action = 'update' BEGIN
		
		UPDATE Tbl_Product 
		SET Name           = @Name,
			Brand          = @Brand,
			Description    = @Description,
			UnitNbr        = @UnitNbr,
			QtyMin		   = @QtyMin,
			QtyMax         = @QtyMax,
			Price		   = @Price,
			IsActive	   = @isActive,
			MesuringUnitID = @UnitId,
			CategoryID	   = @CategoryId,
			DepartementID  = @DepartementId,
			SupplierName   = @SupplierName,
			SupplierCode   = @SupplierCode,
			LastUpdate     = GETDATE()
			WHERE ProductID = @Productid

	END ELSE BEGIN
	
		UPDATE Tbl_Product
		SET IsActive = 0
		WHERE ProductID = @Productid


	END
