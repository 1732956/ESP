CREATE PROCEDURE [dbo].[Supplier_sp]
    @Action           VarChar(50),
    @SupplierId       INT,
    @Name           VarChar(200),
    @Code           VarChar(200),
    @ResourcePerson           VarChar(200),
    @Adress           VarChar(200),
    @Email           VarChar(200),
    @PhoneNumber   VarChar(200),
    @MinOrdrPrice  MONEY,
    @Active      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_Supplier(Name, Code, ResourcePerson, Adress, Email, PhoneNumber, MinOrderPrice, Active)
        VALUES(@Name, @Code, @ResourcePerson, @Adress, @Email, @PhoneNumber, @MinOrdrPrice, @Active)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_Supplier 
        SET Name    = @Name,
            Code    = @Code,
            ResourcePerson = @ResourcePerson,
            Adress    = @Adress,
            Email = @Email,
            PhoneNumber = @PhoneNumber,
            MinOrderPrice = @MinOrdrPrice,
            Active       = @Active
            WHERE SupplierID = @SupplierId

    END ELSE BEGIN

    UPDATE Tbl_Supplier
    set Active = 0
    WHERE SupplierID = @SupplierId

    END
