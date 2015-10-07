-- J McGarr
-- GraphicNovelSysData.sql
-- This script populates the database created by GraphicNovelSys.sql
PROMPT GraphicNovelSysData Execution Started....
PROMPT
PROMPT Clearing Tables....
PROMPT


--@c:\GraphicNovelSys.sql
PROMPT
PROMPT Populating Table Members (4 Records)
PROMPT
INSERT INTO Members
VALUES (1,'r','James','McGarr','James@yeah.com','50.00','A','r');
INSERT INTO Members
VALUES (2,'a','Peter','Croft','Peter@yeah.com','50.00','A','a');
INSERT INTO Members
VALUES (3,'myUserName','Alan','Apples','Alan@yeah.com','50.00','A','qwerty3');
INSERT INTO Members
VALUES (4,'ar','Rachael','Griffin','Rachael@yeah.com','50.00','A','ar');


PROMPT
PROMPT Populating Table Categories (4 Records)
PROMPT
INSERT INTO Categories
VALUES (1,'R','This is a reader');
INSERT INTO Categories
VALUES (2,'A','This is an author');
INSERT INTO Categories
VALUES (3,'A','This is an author');
INSERT INTO Categories
VALUES (4,'R','This is a reader');
INSERT INTO Categories
VALUES (4,'A','This is a reader');


PROMPT
PROMPT Populating Table Novels (4 Records)
PROMPT
INSERT INTO Novels
VALUES (1,'03/MAY/1988','Unknown','HOR','22.01','C:\PATH',2);
INSERT INTO Novels
VALUES (2,'16/JUL/2010','New','FAN','45.33','C:\PATH',3);
INSERT INTO Novels
VALUES (3,'08/DEC/2000','Unknown','COM','5.50','C:\PATH',3);
INSERT INTO Novels
VALUES (4,'01/JAN/2015','Getting To Know You','ROM','30.00','C:\PATH',2);


PROMPT
PROMPT Populating Table Purchases (4 Records)
PROMPT
INSERT INTO Purchases
VALUES (1,'02/JAN/2015',1,4);
INSERT INTO Purchases
VALUES (2,'02/JAN/2015',4,4);
INSERT INTO Purchases
VALUES (3,'03/JAN/2015',4,4);
INSERT INTO Purchases
VALUES (4,'03/JAN/2015',2,4);

COMMIT;
  
PROMPT Populate Tables Script Execution Ended