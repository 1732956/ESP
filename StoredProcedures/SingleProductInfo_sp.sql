USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[SingleProductInfo_sp]    Script Date: 2020-04-09 11:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SingleProductInfo_sp]
@BarCode VARCHAR(8)
AS
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