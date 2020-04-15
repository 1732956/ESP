/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/
use DATA_MANOIRQUARTIER

/*------------------------------------------------------------
-- Table: Tbl_MesuringUnit
------------------------------------------------------------*/
DROP TABLE IF EXISTS dbo.Tbl_InventoryTransaction;
DROP TABLE IF EXISTS dbo.Tbl_Inventory;
DROP TABLE IF EXISTS dbo.Tbl_ReasonCode;
DROP TABLE IF EXISTS dbo.Tbl_Product;
DROP TABLE IF EXISTS dbo.Tbl_Departement;
DROP TABLE IF EXISTS dbo.Tbl_Category;
DROP TABLE IF EXISTS dbo.Tbl_Location;
DROP TABLE IF EXISTS dbo.Tbl_MesuringUnit;
DROP TABLE IF EXISTS dbo.Tbl_Supplier;


CREATE TABLE Tbl_MesuringUnit(
	MesuringUnitID   INT IDENTITY (1,1) NOT NULL ,
	Description      VARCHAR (50) NOT NULL ,
	UnitCode         VARCHAR (50) NOT NULL ,
	IsActive         bit  NOT NULL  ,
	CONSTRAINT Tbl_MesuringUnit_PK PRIMARY KEY (MesuringUnitID)
);


/*------------------------------------------------------------
-- Table: Tbl_Category
------------------------------------------------------------*/
CREATE TABLE Tbl_Category(
	CategoryID    INT IDENTITY (1,1) NOT NULL ,
	Description   VARCHAR (50) NOT NULL ,
	IsActive      bit  NOT NULL  ,
	CONSTRAINT Tbl_Category_PK PRIMARY KEY (CategoryID)
);


/*------------------------------------------------------------
-- Table: Tbl_Departement
------------------------------------------------------------*/
CREATE TABLE Tbl_Departement(
	DepartementID   INT IDENTITY (1,1) NOT NULL ,
	Nom             VARCHAR (50) NOT NULL ,
	Description     VARCHAR (50) NOT NULL  ,
	IsActive		bit NOT NULL
	CONSTRAINT Tbl_Departement_PK PRIMARY KEY (DepartementID)
);

/*------------------------------------------------------------
-- Table: Tbl_Supplier
------------------------------------------------------------*/
CREATE TABLE Tbl_Supplier(
	SupplierID         INT IDENTITY (1,1) NOT NULL ,
	Name			   VARCHAR (100) NOT NULL ,
	Code			   VARCHAR (100) NOT NULL ,
	ResourcePerson     VARCHAR (100) NOT NULL ,
	Adress			   VARCHAR (100) NOT NULL ,
	Email			   VARCHAR (100) NOT NULL ,
	PhoneNumber		   VARCHAR (100) NOT NULL , 
	MinOrderPrice	   MONEY		 NOT NULL ,
	Active			   bit			 NOT NULL ,
	CONSTRAINT Tbl_Supplier_PK PRIMARY KEY (SupplierID)
);


/*------------------------------------------------------------
-- Table: Tbl_Product
------------------------------------------------------------*/
CREATE TABLE Tbl_Product(
	ProductID       INT IDENTITY (100,1) NOT NULL ,
	Name             VARCHAR (50) NOT NULL ,
	Brand            VARCHAR (50) NOT NULL ,
	Description      VARCHAR (50) NOT NULL ,
	UnitNbr          INT  NOT NULL ,
	QtyMin			 INT  NOT NULL ,
	QtyMax			 INT  NOT NULL ,
	Price            MONEY  NOT NULL ,
	IsActive         bit  NOT NULL ,
	MesuringUnitID   INT  NOT NULL ,
	CategoryID       INT  NOT NULL ,
	SupplierID		 INT  NOT NULL ,
	DepartementID    INT  NOT NULL  ,
	LastUpdate       DateTime,
	BarCodeId        VARCHAR(7)
	CONSTRAINT Tbl_Product_PK PRIMARY KEY (ProductID)

	,CONSTRAINT Tbl_Product_Tbl_Supplier_FK FOREIGN KEY (SupplierID) REFERENCES Tbl_Supplier(SupplierID)
	,CONSTRAINT Tbl_Product_Tbl_MesuringUnit_FK FOREIGN KEY (MesuringUnitID) REFERENCES Tbl_MesuringUnit(MesuringUnitID)
	,CONSTRAINT Tbl_Product_Tbl_Category0_FK FOREIGN KEY (CategoryID) REFERENCES Tbl_Category(CategoryID)
	,CONSTRAINT Tbl_Product_Tbl_Departement1_FK FOREIGN KEY (DepartementID) REFERENCES Tbl_Departement(DepartementID)
);


/*------------------------------------------------------------
-- Table: Tbl_Location
------------------------------------------------------------*/
CREATE TABLE Tbl_Location(
	LocationID    INT IDENTITY (1,1) NOT NULL ,
	Name          VARCHAR (50) NOT NULL ,
	Description   VARCHAR (50) NOT NULL ,
	IsActive      bit NOT NULL  ,
	CONSTRAINT Tbl_Location_PK PRIMARY KEY (LocationID)
);


/*------------------------------------------------------------
-- Table: Tbl_Inventory
------------------------------------------------------------*/
CREATE TABLE Tbl_Inventory(
	InventoryID   INT IDENTITY (1,1) NOT NULL ,
	Quantity      INT  NOT NULL ,
	ProductID_    INT  NOT NULL ,
	LocationID    INT  NOT NULL  ,
	CONSTRAINT Tbl_Inventory_PK PRIMARY KEY (InventoryID)

	,CONSTRAINT Tbl_Inventory_Tbl_Product_FK FOREIGN KEY (ProductID_) REFERENCES Tbl_Product(ProductID)
	,CONSTRAINT Tbl_Inventory_Tbl_Location0_FK FOREIGN KEY (LocationID) REFERENCES Tbl_Location(LocationID)
);


/*------------------------------------------------------------
-- Table: Tbl_ReasonCode
------------------------------------------------------------*/
CREATE TABLE Tbl_ReasonCode(
	ReasonID      INT IDENTITY (1,1) NOT NULL ,
	Code          VARCHAR (50) NOT NULL ,
	Description   VARCHAR (50) NOT NULL ,
	IsActive      bit  NOT NULL  ,
	CONSTRAINT Tbl_ReasonCode_PK PRIMARY KEY (ReasonID)
);


/*------------------------------------------------------------
-- Table: Tbl_InventoryTransaction
------------------------------------------------------------*/
CREATE TABLE Tbl_InventoryTransaction(
	InventoryTransactionID   INT IDENTITY (1,1) NOT NULL ,
	QuantityDelta            INT  NOT NULL ,
	Date                     DATETIME NOT NULL ,
	ProductID				 INT NOT NULL ,
	ReasonID                 INT  NOT NULL ,
	LocationID               INT  NOT NULL  ,
	CONSTRAINT Tbl_InventoryTransaction_PK PRIMARY KEY (InventoryTransactionID)
	,CONSTRAINT Tbl_InventoryTransaction_Tbl_Product_FK FOREIGN KEY (ProductID) REFERENCES Tbl_Product(ProductID)
	,CONSTRAINT Tbl_InventoryTransaction_Tbl_ReasonCode0_FK FOREIGN KEY (ReasonID) REFERENCES Tbl_ReasonCode(ReasonID)
	,CONSTRAINT Tbl_InventoryTransaction_Tbl_Location1_FK FOREIGN KEY (LocationID) REFERENCES Tbl_Location(LocationID)
);


INSERT INTO Tbl_MesuringUnit(Description,UnitCode,IsActive)
VALUES('DescriptionUnit', 'CodeUnit', 1)

INSERT INTO Tbl_Departement (Nom,Description,IsActive)
VALUES('NomDep','DescriptionDep',1)

INSERT INTO Tbl_Category ( Description,IsActive)
VALUES('DescriptionCat', 1)

INSERT INTO Tbl_Supplier (Name, Code, ResourcePerson, Adress, Email, PhoneNumber, MinOrderPrice, Active)
VALUES('nameSupplier', 'CodeSupplier', 'RessourcePerson', 'Adress', 'Email', 'PhoneNumber', 75, 1)

INSERT INTO Tbl_Product(Name,Brand,Description,UnitNbr,QtyMin,QtyMax,Price,IsActive,MesuringUnitID,CategoryID,DepartementID,SupplierID,LastUpdate,BarCodeId)
VALUES('nameProduct', 'BrandProduct', 'DescrPproduct',3 ,5, 18, 22, 1,1,1,1,1, GETDATE(),'P000100')
select * from Tbl_Product