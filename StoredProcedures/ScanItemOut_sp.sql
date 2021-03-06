USE [DATA_MANOIRQUARTIER]
GO
/****** Object:  StoredProcedure [dbo].[ScanItemOut_sp]    Script Date: 2020-05-29 11:41:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ScanItemOut_sp]
@ProductId INT,
@LocId     INT,
@Qty       INT
AS


IF EXISTS (SELECT InventoryId FROM Tbl_Inventory WHERE LocationID =@LocId AND ProductID_ = @ProductId) BEGIN

	UPDATE Tbl_Inventory 
	SET Quantity = Quantity - ABS(@Qty)
	FROM Tbl_Inventory
	WHERE LocationID =@LocId AND ProductID_ = @ProductId

	END ELSE BEGIN
		INSERT INTO Tbl_Inventory(Quantity,ProductID_,LocationID)
		VALUES(ABS(@Qty)*-1, @ProductId, @LocId)

	END


	INSERT INTO Tbl_InventoryTransaction(QuantityDelta,Date,ProductID,LocationID,Movement)
	VALUES(@Qty, GETDATE(), @ProductId, @LocId,'Sortie')



	
