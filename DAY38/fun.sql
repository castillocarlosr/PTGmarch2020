-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('SchemaName.TableName', 'U') IS NOT NULL
DROP TABLE duringCovid.card_rank
DROP TABLE duringCovid.card_suit
DROP TABLE duringCovid.games
DROP TABLE duringCovid.inventory
GO

-- Create the table in the specified schema
CREATE TABLE duringCovid.card_rank
(
    Id INT NOT NULL PRIMARY KEY, -- primary key column
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