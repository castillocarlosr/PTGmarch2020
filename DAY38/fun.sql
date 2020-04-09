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
    --gameId INT NOT NULL PRIMARY KEY, -- primary key column
    game_Name NVARCHAR(50) NOT NULL PRIMARY KEY,  --primary key is a string to prevent duplicate games added
    inventor NVARCHAR(50),
    year NVARCHAR(50),
    min_Age TINYINT,
    min_Players TINYINT,
    max_Players TINYINT,
    manufacture_Price TINYINT
);
CREATE TABLE duringCovid.inventory
(
    id INT NOT NULL PRIMARY KEY, -- primary key column
    shop NVARCHAR(50),
    game_Name NVARCHAR(50) FOREIGN KEY REFERENCES games.game_Name,  --FOREIGN key to games table
    qty INT,
    aisle TINYINT,
    store_Price DECIMAL(5,2) --In $US currency
);    
GO