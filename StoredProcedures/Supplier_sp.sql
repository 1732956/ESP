USE [DATA_MANOIRQUARTIER]
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
