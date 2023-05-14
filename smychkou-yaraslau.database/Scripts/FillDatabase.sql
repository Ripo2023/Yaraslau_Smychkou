USE `MobileStoreDb`;

INSERT INTO `Category` (`Id`, `Name`)
VALUES 
	(1, 'Coffee'),
	(2, 'Tea'),
    (3, 'Drinks'),
    (4, 'Deserts');
    
INSERT INTO `Product` (`Id`, `Name`, `Description`, `ImagePath`, `StartPrice`)
VALUES 
	(1, 'Cappucino', 'Description about Cappucino', 'ImagePath', 120),
	(2, 'Espresso',  'Description about Espresso',  'ImagePath', 120),
    (3, 'Latte',     'Description about Latte',     'ImagePath', 120),
    (4, 'Raff',      'Description about Raff',      'ImagePath', 120);
    
INSERT INTO `CategoryProduct` (`CategoryId`, `ProductId`)
VALUES 
	(1, 1),
	(1, 2),
    (1, 3),
    (1, 4);
    
INSERT INTO `ProductVolume` (`ProductId`, `Number`, `Volume`)
VALUES 
	(1, 1, 200),
	(1, 2, 300),
    (1, 3, 400),
    (2, 1, 200),
	(2, 2, 300),
    (2, 3, 400),
    (3, 1, 200),
	(3, 2, 300),
    (3, 3, 400),
    (4, 1, 200),
	(4, 2, 300),
    (4, 3, 400);
    
INSERT INTO `Component` (`Id`, `Name`, `ImagePath`, `Price`)
VALUES 
	(1, 'Espresso arabica', 'ImagePath', 80),
	(2, 'Cow''s milk',      'ImagePath', 40),
    (3, 'Without syrop',    'ImagePath', 20);
    
INSERT INTO `ProductComponent` (`ProductId`, `ComponentId`, `IsStandart`)
VALUES 
	(1, 1, 1),
	(1, 2, 1),
    (1, 3, 0);