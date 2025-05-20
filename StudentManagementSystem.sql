CREATE DATABASE StudentManagementSystem;

CREATE TABLE StudentTable
(
	UserID INT IDENTITY(1,1),
	UserName VARCHAR(150) UNIQUE,
	UserPass VARCHAR(150),
	UserPho VARCHAR(15),
	UserCNIC VARCHAR(15) UNIQUE,
	UserDOB VARCHAR(10),
	UserGender VARCHAR(10),
	UserEmail VARCHAR(30),
	UserRole VARCHAR(10),
	UserAdd VARCHAR(150),
	CONSTRAINT UserTable_PK PRIMARY KEY (UserID)
);

INSERT INTO StudentTable VALUES 
('Student', '1234', '+91 9696799341', '222-222','31/10/2005', 'Male', 'sengar@gmail.com','Student','India'),
('Faculty', '123', '+91 9696799341', '444-444','30/10/2008', 'Male', 'sengarajay@gmail.com','Faculty','India'),
('Admin', '12345', '+91 9839153051', '333-333','12/07/2004', 'Male', 'sengarvishu@gmail.com','Admin','Russia');