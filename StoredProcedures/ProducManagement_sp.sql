USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[ProductManagement_sp]    Script Date: 2020-05-07 10:38:17 ******/
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
	@QtyInventoryOut Float,
	@CategoryId    Int,
	@Departement   VarChar(2000),
	@Description   VarChar(200),
	@Price         DEC(18,2),
	@SupplierId	   Int,
	@isActive      Bit,
	@supplierCode  VARCHAR(50),
	@MeasureUnit   VarChar(100),
    @MeasureQty    INT
	AS

	DECLARE
	@BarCode Varchar(7)

	

	IF @Action = 'add' BEGIN

		INSERT INTO Tbl_Product(Name,Brand,Description,UnitNbr,QtyMin,QtyMax, QtyInventoryOut ,Price,IsActive,CategoryID, SupplierID ,LastUpdate,BarCodeId,SupplierCode,MeasureUnit,MeasureQty)
		VALUES(@Name, @Brand, @Description,  @UnitNbr, @QtyMin, @QtyMax, @QtyInventoryOut, @Price, @isActive, @CategoryId ,@SupplierId ,GETDATE(), '',@supplierCode,@MeasureUnit,@MeasureQty)
		
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
			QtyInventoryOut = @QtyInventoryOut,
			Price		   = @Price,
			IsActive	   = @isActive,
			CategoryID	   = @CategoryId,
			SupplierID     = @SupplierId,
			LastUpdate     = GETDATE(),
			SupplierCode   = @supplierCode,
			MeasureUnit    = @MeasureUnit,
			MeasureQty	   = @MeasureQty
			WHERE ProductID = @Productid

	END ELSE BEGIN
	
	UPDATE Tbl_Product
	set IsActive = 0
	WHERE ProductID = @Productid

	END


	DELETE FROM [Tbl_ProductDepartments]
	WHERE Productid = @Productid

	INSERT INTO Tbl_ProductDepartments(productid,departementsid)
	SELECT @Productid, CONVERT(INT,value) FROM fn_split_string_to_column(@Departement, ',') WHERE value <>''




