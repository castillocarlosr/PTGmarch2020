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
    id INT NOT NULL PRIMARY KEY, -- primary key 
    rankCard NVARCHAR(50) NOT NULL,
    valueCard TINYINT
);
CREATE TABLE duringCovid.card_suit
(
    id INT NOT NULL PRIMARY KEY, -- primary key 
    suit NVARCHAR(50) NOT NULL,
    color NVARCHAR(50) NOT NULL
);
CREATE TABLE duringCovid.games
(
    id INT NOT NULL PRIMARY KEY, -- primary key column
    game_Name NVARCHAR(50),
    inventor NVARCHAR(50),
    year NVARCHAR(50),
    min_Age TINYINT,
    min_Players TINYINT,
    max_Players TINYINT,
    recommended_Price TINYINT
);
CREATE TABLE duringCovid.inventory
(
    id INT NOT NULL PRIMARY KEY, -- primary key column
    Column1 [NVARCHAR](50) NOT NULL,
);    
GO