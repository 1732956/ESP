USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[SingleProductInfo_sp]    Script Date: 2020-04-08 10:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SingleProductInfo_sp]
@BarCode VARCHAR(8)
AS
IF EXISTS(SELECT Tbl_Product.ProductID  FROM Tbl_Product WHERE Tbl_Product.BarCodeId = @BarCode) BEGIN
	SELECT Tbl_Product.ProductID, Tbl_Product.Name AS ProductName, Tbl_Product.Brand, 
		   Tbl_Product.Description AS DescrProduct,
		   Tbl_Product.Price, Tbl_Product.BarCodeId, 
		   Tbl_Category.Description AS CatDescr,
		   Tbl_Departement.Nom AS DepNom
		   FROm Tbl_Product
		   INNER JOIN Tbl_Category    ON Tbl_Category.CategoryID = Tbl_Product.CategoryID
		   INNER JOIN Tbl_Departement ON Tbl_Departement.DepartementID = Tbl_Product.DepartementID
	END ELSE BEGIN
		SELECT 0 AS ProductID, '' AS ProductName, '' AS Brand, 
		   '' AS DescrProduct,
		   0 AS Price, '' AS BarCodeId, 
		   '' AS CatDescr,
		   '' AS DepNom
		   FROM Tbl_Product
		   INNER JOIN Tbl_Category    ON Tbl_Category.CategoryID = Tbl_Product.CategoryID
		   INNER JOIN Tbl_Departement ON Tbl_Departement.DepartementID = Tbl_Product.DepartementID
		   WHERE Tbl_Product.BarCodeId = @BarCode
	END

	   
		