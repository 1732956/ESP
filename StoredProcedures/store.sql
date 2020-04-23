USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[SingleProductInfo_sp]    Script Date: 2020-04-21 13:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SingleProductInfo_sp]
@BarCode VARCHAR(8)
AS
IF EXISTS  (SELECT Tbl_Product.ProductID FROm Tbl_Product WHERE barcodeId = @BarCode) BEGIN

	SELECT Tbl_Product.ProductID, Tbl_Product.Name AS ProductName, Tbl_Product.Brand, 
	       Tbl_Product.Description AS DescrProduct,
	       Tbl_Product.Price, Tbl_Product.BarCodeId, 
	       Tbl_Category.Description AS CatDescr,
	       Tbl_Departement.Nom AS DepNom,
	       Tbl_Supplier.Name AS SupName
	       FROm Tbl_Product
	       INNER JOIN Tbl_Category    ON Tbl_Category.CategoryID = Tbl_Product.CategoryID
	       INNER JOIN Tbl_Departement ON Tbl_Departement.DepartementID = Tbl_Product.DepartementID
	       INNER JOIN Tbl_Supplier    ON Tbl_Supplier.SupplierID = Tbl_Product.SupplierID
		   WHERE barcodeId = @BarCode
	END ELSE BEGIN 
		SELECT 0 AS  ProductID, '' AS ProductName, ''  AS Brand, 
	       '' AS DescrProduct,
	       0 AS Price, '' AS BarcodeId, 
	       '' AS CatDescr,
	       '' AS DepNom,
	       '' AS SupName

	END
	

GO
/****** Object:  StoredProcedure [dbo].[ScanItemOut_sp]    Script Date: 2020-04-08 10:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ScanItemOut_sp]
@ProductId INT,
@LocId     INT,
@Qty       INT,
@ReasonId  INT
AS


IF EXISTS (SELECT InventoryId FROM Tbl_Inventory WHERE LocationID =@LocId AND ProductID_ = @ProductId) BEGIN

	UPDATE Tbl_Inventory 
	SET Quantity = Quantity - ABS(@Qty)
	FROM Tbl_Inventory
	WHERE LocationID =@LocId AND ProductID_ = @ProductId

	END ELSE BEGIN
		INSERT INTO Tbl_Inventory(Quantity,ProductID_,LocationID)
		VALUES(ABS(@Qty)*-1, @ProductId, @LocId)

	END


	INSERT INTO Tbl_InventoryTransaction(QuantityDelta,Date,ProductID,ReasonID,LocationID)
	VALUES(@Qty, GETDATE(), @ProductId, @ReasonId, @LocId)



	
GO
/****** Object:  StoredProcedure [dbo].[ScanItemIn_sp]    Script Date: 2020-04-08 10:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ScanItemIn_sp]
@ProductId INT,
@LocId     INT,
@Qty       INT
AS


IF EXISTS (SELECT InventoryId FROM Tbl_Inventory WHERE LocationID =@LocId AND ProductID_ = @ProductId) BEGIN

	UPDATE Tbl_Inventory 
	SET Quantity = Quantity + @Qty
	FROM Tbl_Inventory
	WHERE LocationID =@LocId AND ProductID_ = @ProductId

	END ELSE BEGIN
		INSERT INTO Tbl_Inventory(Quantity,ProductID_,LocationID)
		VALUES(@Qty, @ProductId, @LocId)

	END



	

GO
/** Object:  StoredProcedure [dbo].[Product_sp]    Script Date: 2020-04-09 10:37:04 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Product_sp] 
@isActive INT
AS

DECLARE @SQLSTRING NVARCHAR(2000),
        @Param     NVARCHAR(600)


SET @SQLSTRING ='SELECT  Tbl_Product.*, Tbl_Product.description as Descr,
                 Tbl_MesuringUnit.MesuringUnitID as UnitId, Tbl_MesuringUnit.MesuringUnitId as MeasuringUnitId, Tbl_MesuringUnit.UnitCode, Tbl_MesuringUnit.Description as MeasuringUnitDescription,
                 Tbl_MesuringUnit.isActive as MeasuringUnitisActive, Tbl_Category.Description as CategoryDescription, 
                 Tbl_Category.isactive as CategoryIsActive,  Tbl_Departement.Nom as DepartmentName, Tbl_Departement.Description as DepartmentDescription, Tbl_Departement.isActive as DepartmentisActive,
                 Tbl_Supplier.SupplierID as SupID, Tbl_Supplier.Name as SupName, Tbl_Supplier.Code as SupCode, Tbl_Supplier.ResourcePerson as SupResPers, Tbl_Supplier.Adress as SupAdress, Tbl_Supplier.Email as SupEmail, Tbl_Supplier.PhoneNumber as SupPhone, Tbl_Supplier.MinOrderPrice as SupMinOrderPrice, Tbl_Supplier.Active as SupActive
                 FROM Tbl_Product
                 INNER JOIN Tbl_MesuringUnit ON Tbl_MesuringUnit.MesuringUnitID = Tbl_Product.MesuringUnitID
                 INNER JOIN Tbl_Category     ON Tbl_Category.CategoryID =Tbl_Product.CategoryID
                 INNER JOIN Tbl_Departement  ON Tbl_Departement.DepartementID = Tbl_Product.DepartementID 
                 INNER JOIN TBL_Supplier     ON Tbl_Supplier.SupplierID = Tbl_Product.SupplierID'



IF @isActive  = 1 BEGIN

    SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 1'

END ELSE IF @isActive = 0 BEGIN

    SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 0'

END

    SET @Param = '@isActive INT'
    EXEC sp_executesql @SQLSTRING, @Param , 
    @isActive = @isActive


GO
/****** Object:  StoredProcedure [dbo].[ProductManagement_sp]    Script Date: 2020-04-09 10:54:54 ******/
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
	@SupplierId	   Int,
	@isActive      Bit
	AS

	DECLARE
	@BarCode Varchar(7)

	
	

	IF @Action = 'add' BEGIN

		INSERT INTO Tbl_Product(Name,Brand,Description,UnitNbr,QtyMin,QtyMax ,Price,IsActive,MesuringUnitID,CategoryID,DepartementID, SupplierID ,LastUpdate,BarCodeId)
		VALUES(@Name, @Brand, @Description,  @UnitNbr, @QtyMin, @QtyMax, @Price, @isActive, @UnitId, @CategoryId, @DepartementId,@SupplierId ,GETDATE(), '')
		
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
			SupplierID   = @SupplierId,
			LastUpdate     = GETDATE()
			WHERE ProductID = @Productid

	END ELSE BEGIN
	
	UPDATE Tbl_Product
	set IsActive = 0
	WHERE ProductID = @Productid

	END


GO
/****** Object:  StoredProcedure [dbo].[MesuringUnit_sp]    Script Date: 2020-04-08 10:26:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[MesuringUnit_sp]
    @Action           VarChar(50),
    @UnitId           INT,
    @Descr           VarChar(200),
    @UnitCode       VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_MesuringUnit(Description, UnitCode, IsActive)
        VALUES(@Descr, @UnitCode ,@isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_MesuringUnit 
        SET Description    = @Descr,
            UnitCode       =@UnitCode,
            IsActive       = @isActive
            WHERE MesuringUnitID = @UnitId

    END ELSE BEGIN

    UPDATE Tbl_MesuringUnit
    set IsActive = 0
    WHERE MesuringUnitID = @UnitId

    END


GO
/****** Object:  StoredProcedure [dbo].[Location_sp]    Script Date: 2020-04-08 10:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Location_sp]
    @Action           VarChar(50),
    @LocationId       INT,
    @Description   VarChar(200),
    @Name           VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_Location(Name,Description, IsActive)
        VALUES(@Name, @Description, @isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_Location 
        SET Name           = @Name,
            Description    = @Description,
            IsActive       = @isActive
            WHERE LocationID = @LocationId

    END ELSE BEGIN

    UPDATE Tbl_Location
    set IsActive = 0
    WHERE LocationID = @LocationId

    END


GO
/****** Object:  StoredProcedure [dbo].[Departement_sp]    Script Date: 2020-04-08 10:26:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Departement_sp]
    @Action           VarChar(50),
    @DepartementId INT,
    @Description   VarChar(200),
    @Nom           VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_Departement(Nom,Description, IsActive)
        VALUES(@Nom, @Description, @isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_Departement 
        SET Nom           = @Nom,
            Description    = @Description,
            IsActive       = @isActive
            WHERE DepartementID = @DepartementId

    END ELSE BEGIN

    UPDATE Tbl_Departement
    set IsActive = 0
    WHERE DepartementID = @DepartementId

    END


GO
/****** Object:  StoredProcedure [dbo].[Category_sp]    Script Date: 2020-04-08 10:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Category_sp]
    @Action           VarChar(50),
    @CategoryId INT,
    @Descr           VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_Category(Description, IsActive)
        VALUES(@Descr, @isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_Category 
        SET Description    = @Descr,
            IsActive       = @isActive
            WHERE CategoryID = @CategoryId

    END ELSE BEGIN

    UPDATE Tbl_Category
    set IsActive = 0
    WHERE CategoryID = @CategoryId

    END


GO
/****** Object:  StoredProcedure [dbo].[Supplier_sp]    Script Date: 2020-04-14 15:11:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Supplier_sp]
	@Action		   VarChar(50),
	@SupplierId	   INT,
	@Name		   VarChar(200),
	@Code		   VarChar(200),
	@ResourcePerson		   VarChar(200),
	@Adress		   VarChar(200),
	@Email	       VarChar(200),
	@PhoneNumber   VarChar(200),
	@MinOrderPrice  MONEY,
	@Active      Bit
	AS

	IF @Action = 'add' BEGIN

		INSERT INTO Tbl_Supplier(Name, Code, ResourcePerson, Adress, Email, PhoneNumber, MinOrderPrice, Active)
		VALUES(@Name, @Code, @ResourcePerson, @Adress, @Email, @PhoneNumber, @MinOrderPrice, @Active)

	END ELSE IF @Action = 'update' BEGIN
		
		UPDATE Tbl_Supplier 
		SET Name    = @Name,
			Code	= @Code,
			ResourcePerson = @ResourcePerson,
			Adress	= @Adress,
			Email = @Email,
			PhoneNumber = @PhoneNumber,
			MinOrderPrice = @MinOrderPrice,
			Active       = @Active
			WHERE SupplierID = @SupplierId

	END ELSE BEGIN
	
	UPDATE Tbl_Supplier
	set Active = 0
	WHERE SupplierID = @SupplierId

	END
