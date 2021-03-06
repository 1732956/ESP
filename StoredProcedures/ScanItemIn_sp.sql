USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[ScanItemIn_sp]    Script Date: 2020-05-29 11:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ScanItemIn_sp]
@ProductId INT,
@LocId     INT,
@Qty       INT
AS


IF EXISTS (SELECT InventoryId FROM Tbl_Inventory WHERE LocationID =@LocId AND ProductID_ = @ProductId) BEGIN

	UPDATE Tbl_Inventory 
	SET Quantity = Quantity + @Qty
	FROM Tbl_Inventory
	WHERE LocationID =@LocId AND ProductID_ = @ProductId

	END ELSE BEGIN
		INSERT INTO Tbl_Inventory(Quantity,ProductID_,LocationID)
		VALUES(@Qty, @ProductId, @LocId)

	END

	INSERT INTO Tbl_InventoryTransaction(QuantityDelta,Date,ProductID,LocationID,Movement)
	VALUES(@Qty, GETDATE(), @ProductId, @LocId,'Entree')

