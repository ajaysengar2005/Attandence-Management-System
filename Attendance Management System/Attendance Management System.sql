CREATE DATABASE Attendance_Management_System;

CREATE TABLE User_Table
(
User_ID INT IDENTITY(1,1),
User_Name VARCHAR(150) UNIQUE,
User_Pass VARCHAR(150),
User_Pho VARCHAR(15),
User_CNIC VARCHAR(15) UNIQUE,
User_DOB VARCHAR(10),
User_Gender VARCHAR(6),
User_Email VARCHAR(30),
User_Role VARCHAR(5),
User_Add VARCHAR(150),
CONSTRAINT User_Table_PK PRIMARY KEY (User_ID)
);

INSERT INTO User_Table VALUES
('user','123','+11 111 1111','11111-11111-1','01/01/2005','Male','user@gmail.com','User','India'),
('admin','1234','+22 222 2222','22222-22222-2','02/02/2005','Male','admin@gmail.com','Admin','Canada');
