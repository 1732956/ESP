USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[SingleProductInfo_sp]    Script Date: 2020-04-30 14:29:13 ******/
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
		   Tbl_Product.MeasureQty, Tbl_Product.MeasureUnit,
	       Tbl_Category.Description AS CatDescr,
	       Tbl_Supplier.Name AS SupName
	       FROm Tbl_Product
	       INNER JOIN Tbl_Category    ON Tbl_Category.CategoryID = Tbl_Product.CategoryID
	       INNER JOIN Tbl_Supplier    ON Tbl_Supplier.SupplierID = Tbl_Product.SupplierID
		   WHERE barcodeId = @BarCode
	END ELSE BEGIN 
		SELECT 0 AS  ProductID, '' AS ProductName, ''  AS Brand, 
	       '' AS DescrProduct,
	       0 AS Price, '' AS BarcodeId, 
	       '' AS CatDescr,
	       '' AS DepNom,
	       '' AS SupName,
		   '' AS MeasureUnit,
		   0 AS MeasureQty

	END
	

