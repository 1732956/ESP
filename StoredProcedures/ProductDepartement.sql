USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[ProductDeparments_sp]    Script Date: 2020-04-30 11:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProductDeparments_sp] 
@ProductId INT
AS
SELECT Tbl_ProductDepartments.*, Tbl_Departement.Description, Tbl_Departement.Nom AS DepNom, Tbl_Departement.IsActive, Tbl_Departement.DepartementID
FROM Tbl_ProductDepartments
INNER JOIN Tbl_Departement ON Tbl_Departement.DepartementID = Tbl_ProductDepartments.DepartementsId
WHERE Tbl_ProductDepartments.productId = @ProductId AND Tbl_Departement.isActive =1






