USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[MesuringUnit_sp]    Script Date: 2020-04-08 10:26:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[MesuringUnit_sp]
    @Action           VarChar(50),
    @UnitId           INT,
    @Descr           VarChar(200),
    @UnitCode       VarChar(200),
    @isActive      Bit
    AS

    IF @Action = 'add' BEGIN

        INSERT INTO Tbl_MesuringUnit(Description, UnitCode, IsActive)
        VALUES(@Descr, @UnitCode ,@isActive)

    END ELSE IF @Action = 'update' BEGIN

        UPDATE Tbl_MesuringUnit 
        SET Description    = @Descr,
            UnitCode       =@UnitCode,
            IsActive       = @isActive
            WHERE MesuringUnitID = @UnitId

    END ELSE BEGIN

    UPDATE Tbl_MesuringUnit
    set IsActive = 0
    WHERE MesuringUnitID = @UnitId

    END