-- J McGarr 22 JAN 2015
-- GraphicNovelSys.sql
-- This script creates the database for the Graphic Novel System

PROMPT Script Execution Started....
PROMPT
PROMPT Dropping Tables....
DROP TABLE Purchases;
DROP TABLE Novels;
DROP TABLE Members;
DROP TABLE Categories;


PROMPT Creating Tables
PROMPT
PROMPT Creating Table Members
PROMPT
CREATE TABLE Members
(MemID NUMBER(10),
 uName CHAR(30),
 fName CHAR(30),
 lName CHAR(30),
 eMail CHAR(50),
 credit NUMBER(6,2),
 status CHAR(1) CHECK (status = 'A' OR status = 'I'), 
 password CHAR(10),
 CONSTRAINT pk_Members PRIMARY KEY (MemID));
 
 PROMPT
 PROMPT Creating Table Categories
 PROMPT
 CREATE TABLE Categories
 (MemID NUMBER(10),
  CatCode CHAR(1),
  description VARCHAR(30),
  CONSTRAINT pk_Categories PRIMARY KEY (MemID,CatCode));
  
  PROMPT
  PROMPT Creating Table Novels
  PROMPT
  CREATE TABLE Novels
  (NovelID NUMBER(10),
   creationDate DATE,
   title CHAR(30),
   genre CHAR(3),
   price NUMBER(6,2) CHECK (price > 0),
   path VARCHAR(300),
   MemID NUMBER(10),
   CONSTRAINT pk_Novels PRIMARY KEY (NovelID),
   CONSTRAINT fk_Novels_Members FOREIGN KEY (MemID) REFERENCES Members(MemID));
   
  PROMPT
  PROMPT Creating Table Purchases
  PROMPT
  CREATE TABLE Purchases
  (PurchaseID NUMBER(10),
   pDate DATE,
   MemID NUMBER(10),
   NovelID NUMBER(10),
   CONSTRAINT pk_Purchases PRIMARY KEY (PurchaseID),
   CONSTRAINT fk_Purchases_Members FOREIGN KEY (MemID) REFERENCES Members(MemID),
   CONSTRAINT fk_Purchases_Novels FOREIGN KEY (NovelID) REFERENCES Novels(NovelID));
   
  COMMIT;
  
  PROMPT Create Tables Script Execution Ended