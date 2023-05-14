CREATE DATABASE `MobileStoreDb`;
USE `MobileStoreDb`;

CREATE TABLE `Category`
(
  `Id`   INT           NOT NULL,
  `Name` NVARCHAR(256) NOT NULL,
  PRIMARY KEY (`Id`)
);

CREATE TABLE `Product`
(
	`Id`          INT            NOT NULL,	
    `Name`        NVARCHAR(256)  NOT NULL,
    `Description` NVARCHAR(2048) NULL,
    `ImagePath`   NVARCHAR(1024) NOT NULL,
    `StartPrice`  NUMERIC(9, 2)  NOT NULL,
	PRIMARY KEY (`Id`)
);

CREATE TABLE `CategoryProduct`
(
	`CategoryId` INT NOT NULL,
    `ProductId`  INT NOT NULL,
    PRIMARY KEY (`CategoryId`, `ProductId`),
    FOREIGN KEY (`CategoryId`) REFERENCES `Category` (`Id`),
    FOREIGN KEY (`ProductId`)  REFERENCES `Product` (`Id`)
);

CREATE TABLE `ProductVolume`
(
	`ProductId` INT           NOT NULL,
    `Number`    INT           NOT NULL,
    `Volume`    INT           NOT NULL,
    PRIMARY KEY (`ProductId`, `Number`),
    FOREIGN KEY (`ProductId`)  REFERENCES `Product` (`Id`)
);

CREATE TABLE `ProductComponent`
(
	`ProductId`   INT  NOT NULL,
    `ComponentId` INT  NOT NULL,
    `IsStandart`  BIT  NOT NULL,
    PRIMARY KEY (`ProductId`, `ComponentId`)
);

CREATE TABLE `Component`
(
	`Id`        INT            NOT NULL,	
    `Name`      NVARCHAR(256)  NOT NULL,
    `ImagePath` NVARCHAR(1024) NOT NULL,
    `Price`		NUMERIC(9, 2)  NOT NULL,
	PRIMARY KEY (`Id`)
);

CREATE TABLE `Order`
(
	`Id`            INT          NOT NULL,
    `Code`          VARCHAR(512) NULL,
    `Status`        INT          NOT NULL, -- NotSended - 0, InProgress - 1, Ready - 2
    `TakingDate`    DATETIME     NULL,
    `CompletedDate` DATETIME     NULL,
    `UserId`        INT          NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `OrderProduct`
(
	`OrderId`      INT NOT NULL,
    `ProductId`    INT NOT NULL,
    `VolumeNumber` INT NOT NULL,
    `Count`        INT NOT NULL,
    PRIMARY KEY (`OrderId`, `ProductId`, `VolumeNumber`),
    FOREIGN KEY (`OrderId`)                    REFERENCES `Order` (`Id`),
    FOREIGN KEY (`ProductId`, `VolumeNumber`)  REFERENCES `ProductVolume` (`ProductId`, `Number`)
);

CREATE TABLE `OrderProductComponent`
(
	`OrderId`      INT NOT NULL,
    `ProductId`    INT NOT NULL,
    `VolumeNumber` INT NOT NULL,
    `ComponentId`  INT NOT NULL,
    PRIMARY KEY (`OrderId`, `ProductId`, `VolumeNumber`, `ComponentId`),
    FOREIGN KEY (`OrderId`, `ProductId`, `VolumeNumber`) REFERENCES `OrderProduct` (`OrderId`, `ProductId`, `VolumeNumber`),
    FOREIGN KEY (`ComponentId`)                          REFERENCES `Component` (`Id`)
);
