create database StudentAttendence
use StudentAttendence

create table Batch
(Bid varchar(20) primary key,
Bname varchar(50),
Bdate date )
drop table Batch

create table Module
(Mid varchar(20) primary key,
Mname varchar(50),
No_of_lecs int)

drop table Module

create table Student
(S_id varchar(20) primary key,
Bid varchar(20) references Batch(Bid),
Sname varchar(50) not null,
Saddress varchar (50)not null,
Tp int not null,
DOB date,
Password varchar(50) not null,
 Qr varbinary(max))

drop table BatchModule
select * from Module
drop table Student

create table BatchModule
(Bid varchar(20) references Batch(Bid),
Mid varchar(20) references Module(Mid),
s_date date,
e_date date)
select * from BatchModule

create table StudentModule
(S_id varchar(20) references Student(S_id),
Mid varchar(20) references Module(Mid),
A_date datetime,
A_status varchar(20) default 'Absent')
select * from StudentModule

insert into StudentModule
values('DSE1','M01','2023-07-10','Present')
insert into StudentModule
values('DNE1','M02','2023-07-26','Present');
insert into Batch
values('B1','DSE','2022-12-13'),
('B2','DCSD','2022-12-13');

select * from StudentModule

insert into Module
values('M1','GUI',10),
('M2','CN',12);

insert into Student
values('S01','B1','kamal','Colombo',0745124523,'temp123',''),
('S02','B2','Amila','Galle',0751245256,'');


select * from Student




insert into BatchModule
values('B1','M1','2022-12-20','2022-01-01'),
('B2','M2','2022-12-15','2022-12-25');


insert into StudentModule
values('S01','M1',GETDATE(),'Present');

select * from StudentModule

insert into StudentModule (S_id,Mid,A_date)
values ('S01','M1',GETDATE());


drop table BatchModule
drop table StudentModule
drop table Student
drop table Module
drop table Batch

select * from Student



/*Get the maximum numeric part of the BatchID for the current 'B' characters.*/
DECLARE @maxNumericPart INT;
SELECT @maxNumericPart = MAX(CONVERT(INT, RIGHT(Bid, LEN(Bid) - 1)))
FROM Batch
WHERE Bid LIKE 'B%';

/* Increment the numeric part.*/
SET @maxNumericPart = COALESCE(@maxNumericPart, 0) + 1;

/*Concatenate 'B' with the incremented numeric part and pad with leading zeros.*/
DECLARE @newBatchID VARCHAR(10);
SET @newBatchID = 'B' + RIGHT('00' + CAST(@maxNumericPart AS VARCHAR(2)), 2);

/*Insert the new batch ID into the BatchTable.*/
INSERT INTO Batch (Bid)
VALUES ('','DNE','2023-07-26');


select * from Batch
drop table Batch

CREATE SEQUENCE BatchIdSeq
    START WITH 1
    INCREMENT BY 1;
	drop sequence BatchIdSeq
CREATE TABLE Batch (
    Bid varchar(20) PRIMARY KEY DEFAULT 'B' + RIGHT('0' + CAST(NEXT VALUE FOR BatchIdSeq AS varchar(2)), 2),
    Bname varchar(50),
    Bdate date
);

GO -- Separate the following code with 'GO' to create a function

/*CREATE OR ALTER FUNCTION GenerateBatchId()
RETURNS TRIGGER AS
BEGIN
    DECLARE @new_id varchar(20);
    SET @new_id = 'B' + RIGHT('00' + CAST(NEXT VALUE FOR BatchIdSeq AS varchar(2)), 2);
    INSERT INTO Batch (Bid, Bname, Bdate)
    VALUES (@new_id, '', GETDATE()); -- You can change the default value for Bname or BatchStartDate here
    RETURN;
END;



GO
CREATE TRIGGER BatchIdAutoIncrement
ON Batch
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    WITH CTE AS (
        SELECT Bid, Bname,
               ROW_NUMBER() OVER (ORDER BY Bid) AS RowNum
        FROM Batch
        WHERE Bname = ''
    )
    UPDATE CTE
    SET Bname = 'Batch ' + CAST(RowNum AS varchar(10));
	END;*/

	INSERT INTO Batch (Bid, Bname, Bdate)
VALUES
    ('B001', 'Batch 1', '2023-07-25');
	insert into Batch(Bname,Bdate)
	values('DSE','2023-07-25');
	insert into Batch(Bname,Bdate)
	values('DSE2','2023-07-26');
	insert into Batch(Bname,Bdate)
	values('DNE','2023-07-30');


	select * from Module



	CREATE SEQUENCE ModuleIdSeq
    START WITH 1
    INCREMENT BY 1;
	

CREATE TABLE Module (
    Mid varchar(20) primary key DEFAULT 'M' + RIGHT('0' + CAST(NEXT VALUE FOR ModuleIdSeq AS varchar(2)), 2),
    Mname varchar(50),
  No_of_lecs int
);
insert into Module(Mname,No_of_lecs)
	values('GUI',10);

	insert into Module(Mname,No_of_lecs)
	values('CN',9);
	select * from Batch


	truncate table Batch
	select*from