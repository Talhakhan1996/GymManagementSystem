create database Gym_Mgt_System

create table Admin_Login
(
username nvarchar (50) Not null primary key,
pass nvarchar (50) Not null,
);

create table Member
(
Member_id int NOT NULL IDENTITY(1,1) primary key,
Member_name nvarchar (150) Not null,
Member_CNIC nvarchar (150) Not null,
Member_gender nvarchar (20) Not null,
Member_dob nvarchar (100) Not null,
Member_mobile nvarchar (100) Not null,
Member_Email nvarchar (150) Not null,
Join_date nvarchar (100) Not null,
Gym_time nvarchar (150) Not null,
Member_address nvarchar (150) Not null,
Membership_type nvarchar (150) Not null,
);

create table Trainer
(
Trainer_id int NOT NULL IDENTITY(1,1) primary key,
Trainer_name nvarchar (150) Not null,
Trainer_gender nvarchar (20) Not null,
Trainer_dob nvarchar (100) Not null,
Trainer_mobile nvarchar (100) Not null,
Trainer_Email nvarchar (150) Not null,
Trainer_address nvarchar (150) Not null,
);

create table Payment
(
Payment_id int NOT NULL IDENTITY(1,1) primary key,
Payment_Customer_name nvarchar (150) Not null,
Payment_amount nvarchar (100) Not null,
Payment_description nvarchar (150) Not null,
Payment_date nvarchar (100) Not null,
Package_name nvarchar (150) Not null,
Package_type nvarchar (100) Not null,
);


select * from Admin_Login
select * from Member
select * from Payment
select * from Trainer