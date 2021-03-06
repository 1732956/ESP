USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[Category_sp]    Script Date: 2020-04-30 11:16:00 ******/
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


