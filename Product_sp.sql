USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[Product_sp]    Script Date: 2020-04-08 10:27:07 ******/
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
				 Tbl_Category.isactive as CategoryIsActive,  Tbl_Departement.Nom as DepartmentName, Tbl_Departement.Description as DepartmentDescription, Tbl_Departement.isActive as DepartmentisActive  FROM Tbl_Product
				 INNER JOIN Tbl_MesuringUnit ON Tbl_MesuringUnit.MesuringUnitID = Tbl_Product.MesuringUnitID
				 INNER JOIN Tbl_Category     ON Tbl_Category.CategoryID =Tbl_Product.CategoryID
				 INNER JOIN Tbl_Departement  ON Tbl_Departement.DepartementID = Tbl_Product.DepartementID '
				


IF @isActive  = 1 BEGIN

	SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 1'

END ELSE IF @isActive = 0 BEGIN

    SET @SQLSTRING = @SQLSTRING + ' WHERE Tbl_Product.isActive = 0'

END

	SET @Param = '@isActive INT'
    EXEC sp_executesql @SQLSTRING, @Param , 
	@isActive = @isActive

