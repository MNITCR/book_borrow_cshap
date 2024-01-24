# book_borrow_cshap

=============> Start Create table in oracle <=============

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

=============> End Create table in oracle <=============
