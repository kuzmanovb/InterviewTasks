USE master
GO

CREATE DATABASE A1
GO

USE A1
GO

CREATE TABLE Offers(
  offerId INT IDENTITY NOT NULL,
  monthlyFee VARCHAR(15) NOT NULL,
  newContractsForMonth INT NOT NULL,
  sameContractsForMonth INT NOT NULL,
  CancelledContractsForMonth INT NOT NULL
)
GO


BULK INSERT Offers FROM 'C:\offers.csv'
    WITH(
           FIRSTROW = 2,
           FIELDTERMINATOR = ';',
           ROWTERMINATOR = '\n', 
           TABLOCK
         )