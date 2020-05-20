DECLARE 
    @product_name VARCHAR(MAX), 
    @Marque       VARCHAR(MAX), 
    @Description  VARCHAR(MAX), 
	@Departement  VARCHAR(MAX), 
    @Categorie    VARCHAR(MAX), 
	@Fournisseur  VARCHAR(MAX),
    @Code	      VARCHAR(MAX), 
    @Qty          VARCHAR(MAX), 
	@Unité        VARCHAR(MAX), 
	@Mesure       VARCHAR(MAX), 
	@Prix         VARCHAR(MAX), 
	@isActive     VARCHAR(MAX),
	@LastDepId    INT,
	@LastCatID    INT,
	@LastFournisseurID INT,
	@LastUpdate   VARCHAR(MAX),
	@Productid    INT,
	@BarCode	  VARCHAR(MAX),
	@identification INT

	


DECLARE cursor_product CURSOR
FOR SELECT 
Identification,
		F2,
		F3,
		F4,
		F5,
		F6,
		Fournisseur,
		F8,
		F9,
		F11,
		F12,
		F13,
		F18,
		F16
    FROM 
        produits_
		WHERE ISNULL(Fournisseur,'')<> ''
		ORDER BY identification

OPEN cursor_product;
FETCH NEXT FROM cursor_product INTO 
@identification,
    @product_name, 
    @Marque     , 
    @Description, 
	@Departement, 
	@Categorie  , 
	@Fournisseur, 
	@Code	    , 
    @Qty        , 
	@Unité      , 
	@Mesure     , 
	@Prix       , 
	@isActive   ,
	@LastUpdate




WHILE @@FETCH_STATUS = 0
    BEGIN
	IF ISNULL(@identification,0) <> 0 BEGIN

		IF NOT EXISTS (SELECT DepartementID FROM Tbl_Departement WHERE Nom = @Departement) BEGIN

				INSERT INTO Tbl_Departement (Nom,Description,IsActive)
				VALUES(@Departement,'',1)
				SET @LastDepId = SCOPE_IDENTITY()

			END ELSE BEGIN

				SET @LastDepId = (SELECT DepartementID  FROM Tbl_Departement WHERE Nom = @Departement)

			END

		IF NOT EXISTS (SELECT * FROM Tbl_Supplier WHERE Name = @Fournisseur) BEGIN
				INSERT INTO Tbl_Supplier (Name,ResourcePerson,Adress,Email,PhoneNumber,MinOrderPrice,Active)
				VALUES(@Fournisseur,'','','','',1,1)
				SET @LastFournisseurID = SCOPE_IDENTITY()
			END ELSE BEGIN
				SET @LastFournisseurID = ISNULL((SELECT SupplierID  FROM Tbl_Supplier WHERE Name = @Fournisseur),0)
			END
	
		IF ISNULL(@Categorie,'') <> '' BEGIN
			IF NOT EXISTS (SELECT * FROM Tbl_Category WHERE Tbl_Category.Description = @Categorie ) BEGIN

				INSERT INTO Tbl_Category (Description, IsActive)
				VALUES(@Categorie,1)
				SET @LastCatID = SCOPE_IDENTITY()

			END ELSE BEGIN

				SET @LastCatID = (SELECT CategoryID  FROM Tbl_Category WHERE Description = @Categorie)

			END
		END
			

	INSERT INTO Tbl_Product(Name, Brand, Description, MeasureUnit, MeasureQty, QtyMin, QtyMax, Price,IsActive, LastUpdate,SupplierCode, UnitNbr,SupplierID,CategoryID,QtyInventoryOut)
	VALUES(ISNULL(@product_name,''),ISNULL(@Marque,''),ISNULL(@Description,''),ISNULL(@Mesure,''),CONVERT(INT,CONVERT(DEC(18,2),ISNULL(@Unité,0))),0,0,
	CONVERT(DEC(18,2),ISNULL(@Prix,0.00)),
		CASE 
			WHEN @isActive = 'oui' THEN 1
			ELSE 0
		END,CONVERT(DATE, ISNULL(@LastUpdate,getdate())),ISNULL(@Code,''), CONVERT(INT,CONVERT(DEC(18,2),ISNULL(@Qty,0))), @LastFournisseurID,@LastCatID, CONVERT(INT,CONVERT(DEC(18,2),ISNULL(@Unité,0))) * CONVERT(INT,CONVERT(DEC(18,2),ISNULL(@Qty,0))))


      SET @Productid = SCOPE_IDENTITY()

		IF LEN(@Productid) = 3 BEGIN
			SET @BarCode = 'P000' + CONVERT(VARCHAR(3),@Productid)
		END ELSE IF LEN(@Productid) = 4 BEGIN
			SET @BarCode = 'P00'  + CONVERT(VARCHAR(4),@Productid)
		END ELSE IF LEN(@Productid) = 5 BEGIN
			SET @BarCode = 'P0'   + CONVERT(VARCHAR(5),@Productid)
		END ELSE BEGIN
			SET @BarCode = 'P'   + CONVERT(VARCHAR(6),@Productid)
		END

		UPDATE Tbl_Product 
		SET BarCodeId = @BarCode
		WHERE ProductID = @Productid

		INSERT INTO Tbl_ProductDepartments(ProductId, DepartementsId)
		VALUES(@Productid, @LastDepId)
	END



        FETCH NEXT FROM cursor_product INTO 
		@identification,
		    @product_name, 
		    @Marque     , 
		    @Description, 
			@Departement, 
			@Categorie  , 
			@Fournisseur, 
			@Code	    , 
		    @Qty        , 
			@Unité      , 
			@Mesure     , 
			@Prix       , 
			@isActive   ,
			@LastUpdate
    END

CLOSE cursor_product;

DEALLOCATE cursor_product;









