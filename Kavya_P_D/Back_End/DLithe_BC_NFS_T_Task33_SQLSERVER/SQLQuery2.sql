
--Create database
create database Dlithe
use Dlithe
--create table
create table trainees
(
ID int NOT NULL,
Name varchar(25) NOT NULL
);
-- insert records 
insert into trainees values(1,'Sachin');
--select
select * from trainees
select id from trainees
--alter
alter table trainees add departmentname varchar(25)
--update
update trainees set departmentname = 'CSE' where id=1
--insert multiple block
insert into trainees values(2,'Arun','CSE');
insert into trainees values(3,'Karthik','	ECE');
insert into trainees values(4,'Santhosh','CSE');
insert into trainees values(2,'Sagar','ECE');
insert into trainees values(2,'Varun','IME');
--create schema
create schema TE
--create table inside the schema
create table TE.Marchtrainees
(
id int NOT NULL,
Name varchar(25),
Mobile varchar(25),
department varchar(25)
);
--Drop schema
drop table TE.Marchtrainees
drop schema if exists TE
--Delete
delete from trainees where departmentname = 'CSE'
 --Truncate
 truncate table trainees