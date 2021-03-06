USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[Departement_sp]    Script Date: 2020-04-30 11:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Departement_sp]
    @Action           VarChar(50),
    @DepartementId INT,
    @Description   VarChar(200),
    @Nom           VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_Departement(Nom,Description, IsActive)
        VALUES(@Nom, @Description, @isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_Departement 
        SET Nom           = @Nom,
            Description    = @Description,
            IsActive       = @isActive
            WHERE DepartementID = @DepartementId

    END ELSE BEGIN

    UPDATE Tbl_Departement
    set IsActive = 0
    WHERE DepartementID = @DepartementId

    END


