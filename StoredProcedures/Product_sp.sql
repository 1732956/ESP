USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[Product_sp]    Script Date: 2020-05-29 10:03:22 ******/
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
			     Tbl_Category.Description as CategoryDescription, 
                 Tbl_Category.isactive as CategoryIsActive,  
                 Tbl_Supplier.SupplierID as SupID, Tbl_Supplier.Name as SupName, Tbl_Supplier.ResourcePerson as SupResPers, Tbl_Supplier.Adress as SupAdress, Tbl_Supplier.Email as SupEmail, Tbl_Supplier.PhoneNumber as SupPhone, Tbl_Supplier.MinOrderPrice as SupMinOrderPrice, Tbl_Supplier.Active as SupActive
                 FROM Tbl_Product
                 LEFT JOIN Tbl_Category     ON Tbl_Category.CategoryID =Tbl_Product.CategoryID
                 INNER JOIN TBL_Supplier     ON Tbl_Supplier.SupplierID = Tbl_Product.SupplierID'



IF @isActive  = 1 BEGIN

    SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 1'

END ELSE IF @isActive = 0 BEGIN

    SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 0'

END
	SET @SQLSTRING = @SQLSTRING + 'ORDER BY Tbl_Product.Name'
    SET @Param = '@isActive INT'
    EXEC sp_executesql @SQLSTRING, @Param , 
    @isActive = @isActive


