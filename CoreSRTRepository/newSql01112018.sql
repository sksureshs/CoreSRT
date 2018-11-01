CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `AccountDetails` (
    `AccountNo` int NOT NULL AUTO_INCREMENT,
    `IFSCCode` longtext NOT NULL,
    `BankName` longtext NOT NULL,
    `Branch` longtext NOT NULL,
    CONSTRAINT `PK_AccountDetails` PRIMARY KEY (`AccountNo`)
);

CREATE TABLE `Customers` (
    `CustomerId` int NOT NULL AUTO_INCREMENT,
    `Name` longtext NOT NULL,
    `Address` longtext NOT NULL,
    `EmailId` longtext NULL,
    `ContactNumber` longtext NOT NULL,
    `GSTNo` longtext NOT NULL,
    `Type` int NOT NULL,
    CONSTRAINT `PK_Customers` PRIMARY KEY (`CustomerId`)
);

CREATE TABLE `Items` (
    `ItemId` int NOT NULL AUTO_INCREMENT,
    `Description` longtext NOT NULL,
    `Rate` double NOT NULL,
    `CGST` double NOT NULL,
    `SGST` double NOT NULL,
    `DateFrom` datetime(6) NOT NULL,
    `DateTo` datetime(6) NOT NULL,
    CONSTRAINT `PK_Items` PRIMARY KEY (`ItemId`)
);

CREATE TABLE `Producers` (
    `ProducerId` int NOT NULL AUTO_INCREMENT,
    `Name` longtext NOT NULL,
    `Address` longtext NOT NULL,
    `EmailId` longtext NULL,
    `ContactNo` longtext NOT NULL,
    `AccountDetailsAccountNo` int NOT NULL,
    CONSTRAINT `PK_Producers` PRIMARY KEY (`ProducerId`),
    CONSTRAINT `FK_Producers_AccountDetails_AccountDetailsAccountNo` FOREIGN KEY (`AccountDetailsAccountNo`) REFERENCES `AccountDetails` (`AccountNo`) ON DELETE CASCADE
);

CREATE TABLE `Bills` (
    `BillId` int NOT NULL AUTO_INCREMENT,
    `ShopIdCustomerId` int NOT NULL,
    `Date` datetime(6) NOT NULL,
    `TotalQuantity` int NOT NULL,
    `TotalPrice` double NOT NULL,
    `OutStandingAmount` double NOT NULL,
    CONSTRAINT `PK_Bills` PRIMARY KEY (`BillId`),
    CONSTRAINT `FK_Bills_Customers_ShopIdCustomerId` FOREIGN KEY (`ShopIdCustomerId`) REFERENCES `Customers` (`CustomerId`) ON DELETE CASCADE
);

CREATE TABLE `BillingItems` (
    `BillingItmeId` int NOT NULL AUTO_INCREMENT,
    `ItemId` int NOT NULL,
    `OriginalPrice` double NOT NULL,
    `SellingPrice` double NOT NULL,
    `CGST` double NOT NULL,
    `SGCT` double NOT NULL,
    `Quantity` int NOT NULL,
    `TotalPrice` double NOT NULL,
    CONSTRAINT `PK_BillingItems` PRIMARY KEY (`BillingItmeId`),
    CONSTRAINT `FK_BillingItems_Items_ItemId` FOREIGN KEY (`ItemId`) REFERENCES `Items` (`ItemId`) ON DELETE CASCADE
);

CREATE TABLE `Payment` (
    `PaymentId` int NOT NULL AUTO_INCREMENT,
    `BillId` int NOT NULL,
    `Date` datetime(6) NOT NULL,
    `PayemntType` int NOT NULL,
    `Details` longtext NULL,
    CONSTRAINT `PK_Payment` PRIMARY KEY (`PaymentId`),
    CONSTRAINT `FK_Payment_Bills_BillId` FOREIGN KEY (`BillId`) REFERENCES `Bills` (`BillId`) ON DELETE CASCADE
);

CREATE INDEX `IX_BillingItems_ItemId` ON `BillingItems` (`ItemId`);

CREATE INDEX `IX_Bills_ShopIdCustomerId` ON `Bills` (`ShopIdCustomerId`);

CREATE INDEX `IX_Payment_BillId` ON `Payment` (`BillId`);

CREATE INDEX `IX_Producers_AccountDetailsAccountNo` ON `Producers` (`AccountDetailsAccountNo`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20180801172745_InitialMigration', '2.1.4-rtm-31024');

ALTER TABLE `Bills` DROP FOREIGN KEY `FK_Bills_Customers_ShopIdCustomerId`;

ALTER TABLE `Bills` CHANGE `ShopIdCustomerId` `ShopCustomerId` int NOT NULL DEFAULT 0
ALTER TABLE `Bills` RENAME INDEX `IX_Bills_ShopIdCustomerId` TO `IX_Bills_ShopCustomerId`;

ALTER TABLE `BillingItems` CHANGE `SGCT` `SGST` double NOT NULL DEFAULT 0
ALTER TABLE `BillingItems` ADD `BillId` int NOT NULL DEFAULT 0;

CREATE INDEX `IX_BillingItems_BillId` ON `BillingItems` (`BillId`);

ALTER TABLE `BillingItems` ADD CONSTRAINT `FK_BillingItems_Bills_BillId` FOREIGN KEY (`BillId`) REFERENCES `Bills` (`BillId`) ON DELETE CASCADE;

ALTER TABLE `Bills` ADD CONSTRAINT `FK_Bills_Customers_ShopCustomerId` FOREIGN KEY (`ShopCustomerId`) REFERENCES `Customers` (`CustomerId`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181016194400_ColumnChanges_17102018', '2.1.4-rtm-31024');

ALTER TABLE `Bills` ADD `CreatedDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181028111931_billCreationDate_28102018', '2.1.4-rtm-31024');

ALTER TABLE `BillingItems` CHANGE `BillingItmeId` `BillingItemId` int NOT NULL DEFAULT 0
ALTER TABLE `Bills` ADD `UpdatedDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000';

ALTER TABLE `BillingItems` ADD `CreatedDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000';

CREATE TABLE `BillingAudit` (
    `BillingAutiId` int NOT NULL AUTO_INCREMENT,
    `BillId` int NOT NULL,
    `ShopCustomerId` int NOT NULL,
    `Date` datetime(6) NOT NULL,
    `TotalQuantity` int NOT NULL,
    `TotalPrice` double NOT NULL,
    `OutStandingAmount` double NOT NULL,
    `CreatedDate` datetime(6) NOT NULL,
    CONSTRAINT `PK_BillingAudit` PRIMARY KEY (`BillingAutiId`),
    CONSTRAINT `FK_BillingAudit_Customers_ShopCustomerId` FOREIGN KEY (`ShopCustomerId`) REFERENCES `Customers` (`CustomerId`) ON DELETE CASCADE
);

CREATE TABLE `BillingItemAudit` (
    `BillingItemAuditId` int NOT NULL AUTO_INCREMENT,
    `BillingItemId` int NOT NULL,
    `BillId` int NOT NULL,
    `ItemId` int NOT NULL,
    `OriginalPrice` double NOT NULL,
    `SellingPrice` double NOT NULL,
    `CGST` double NOT NULL,
    `SGST` double NOT NULL,
    `Quantity` int NOT NULL,
    `TotalPrice` double NOT NULL,
    `CreatedDate` datetime(6) NOT NULL,
    CONSTRAINT `PK_BillingItemAudit` PRIMARY KEY (`BillingItemAuditId`)
);

CREATE INDEX `IX_BillingAudit_ShopCustomerId` ON `BillingAudit` (`ShopCustomerId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181028122824_auditDate_28102018', '2.1.4-rtm-31024');

ALTER TABLE `BillingItems` ADD `UpdatedDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181028133443_auditDate_1_28102018', '2.1.4-rtm-31024');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181028141533_auditDate_2_28102018', '2.1.4-rtm-31024');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181031151454_billChange_31102018', '2.1.4-rtm-31024');


ALTER TABLE `BillingItems` MODIFY COLUMN `BillingItemId` Int( 11 ) AUTO_INCREMENT NOT NULL;
