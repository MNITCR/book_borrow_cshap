# book_borrow_cshap

=============> Start Create table users in oracle <=============

CREATE TABLE lbr_tbl_users
(
UserID NUMBER GENERATED AS IDENTITY Primary Key,
FirstName VARCHAR2(50),
MiddleName VARCHAR2(50),
LastName VARCHAR2(50),
Address VARCHAR2(50),
PhoneNumber VARCHAR2(50),
Email VARCHAR2(50),
UserName VARCHAR2(50),
Password VARCHAR2(50),
IsAdmin VARCHAR2(50)
);

=============> End Create table users in oracle <=============

=============> Start Create table Books in oracle <=============

create table LBR_TBL_Books
(
BookID NUMBER GENERATED AS IDENTITY Primary Key,
ISBN VARCHAR2(50),
Category VARCHAR2(50),
Title VARCHAR2(50),
Author VARCHAR2(50),
Abstract VARCHAR2(255)
);

=============> End Create table Books in oracle <=============

=============> Start Create table BookSupplyTransaction in oracle <=============

create table LBR_TBL_BookSupplyTransaction
(
SupplyTransID NUMBER GENERATED AS IDENTITY Primary Key,
BookID NUMBER,
Supplies NUMBER(10,2)
);

=============> End Create table BookSupplyTransaction in oracle <=============

=============> Start Create table BorrowingTransaction in oracle <=============

create table LBR_TBL_BorrowingTransaction
(
BorrowTransID NUMBER GENERATED AS IDENTITY Primary Key,
BookID NUMBER,
UserID NUMBER,
Quantity NUMBER(10,2)
);

=============> End Create table BorrowingTransaction in oracle <=============

=============> Start Create table BookReturnTransaction in oracle <=============

create table LBR_TBL_BookReturnTransaction
(
BookReturnTransID NUMBER GENERATED AS IDENTITY Primary Key,
BookID NUMBER,
UserID NUMBER,
Quantity NUMBER(10,2)
);

=============> End Create table BookReturnTransaction in oracle <=============
