USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[Location_sp]    Script Date: 2020-04-30 11:16:55 ******/
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


