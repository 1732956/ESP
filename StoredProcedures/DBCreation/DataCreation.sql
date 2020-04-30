INSERT INTO Tbl_Category(Description, IsActive)
VALUES('Filtreur', 1),
	  ('Nourriture', 1),
	  ('Serviettes', 1),
	  ('Ménage',1);

INSERT INTO Tbl_Departement(Nom, Description, IsActive)
VALUES('Cuisine', 'Produits utilisés dans la cuisine', 1),
	  ('Ménage', 'Produtis utilisés pour faire le ménage', 1);

INSERT INTO Tbl_Location(Name, Description, IsActive)
VALUES('Entrepôt étage 1 Sud', 'Entrepôt situé au premier étage', 1),
	  ('Entrepôt étage 2', 'Entrepôt situé au deuxième étage', 1);

INSERT INTO Tbl_Supplier(Name, ResourcePerson, Adress, Email, PhoneNumber, MinOrderPrice, Active)
VALUES('Choquette CKS', 'Louis Choquette', '875, Boulevard Charest Est, Québec', 'lc@hotmail.com', '418-225-8284', 165, 1),
	  ('Girard Supplies', 'George girard', '12, 1ere rue, Saint-Côme', 'girard.supplies@gsupplies.ca', '418-685-7298', 35, 1);

INSERT INTO Tbl_Product(Name, Brand, Description, MeasureUnit, MeasureQty, UnitNbr, QtyMin, QtyMax, Price,IsActive, CategoryID, SupplierID, LastUpdate, BarCodeId, SupplierCode)
VALUES('Filtreur a eau pour four', 'Alto-Shaam', 'Filtreur a eau pour four (compatible Rational)', 'unité', 1, 1, 10, 50, 13.50, 1, 1, 1, GETDATE(), 'p000100', 'FI-26356'),
	  ('Balais pour plancher', 'Swiffer', 'Balais swiffer pour plancher des chambres', 'unité', 1, 6, 2, 15, 26.25, 1, 4, 2, GETDATE(), 'p000101', '13605078');

INSERT INTO Tbl_productdepartments(ProductId, DepartementsId)
VALUES(1,1),
	  (2,1),
	  (2,2)