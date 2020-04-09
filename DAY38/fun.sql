-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists

--SCHEMA Name: duringCovid
--IF OBJECT_ID('SchemaName.TableName', 'U') IS NOT NULL
IF OBJECT_ID('duringCovid.card_rank', 'U') IS NOT NULL
DROP TABLE duringCovid.card_rank
IF OBJECT_ID('duringCovid.card_suit', 'U') IS NOT NULL
DROP TABLE duringCovid.card_suit
IF OBJECT_ID('duringCovid.games', 'U') IS NOT NULL
DROP TABLE duringCovid.games
IF OBJECT_ID('duringCovid.inventory', 'U') IS NOT NULL
DROP TABLE duringCovid.inventory
GO

CREATE TABLE duringCovid.card_rank
(
    Id INT NOT NULL PRIMARY KEY, -- primary key 
    rankCard string NOT NULL,
    valueCard TINYINT
);
CREATE TABLE duringCovid.card_suit
(
    TableNameId INT NOT NULL PRIMARY KEY, -- primary key column
    Column1 [NVARCHAR](50) NOT NULL,
    Column2 [NVARCHAR](50) NOT NULL
    -- specify more columns here
);
CREATE TABLE duringCovid.games
(
    TableNameId INT NOT NULL PRIMARY KEY, -- primary key column
    Column1 [NVARCHAR](50) NOT NULL,
    Column2 [NVARCHAR](50) NOT NULL
    -- specify more columns here
);
CREATE TABLE duringCovid.inventory
(
    TableNameId INT NOT NULL PRIMARY KEY, -- primary key column
    Column1 [NVARCHAR](50) NOT NULL,
    Column2 [NVARCHAR](50) NOT NULL
    -- specify more columns here
);    
GO