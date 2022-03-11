use Dlithe
create function te(@a int)
Returns int
as
   begin 
       return @a + @a
	   end
select dbo.te(10) as 'Result'
--create table
create table emp1
(
id int primary key IDENTITY,
NAME varchar(25),
dob Date
)

insert into emp1 values('John','12/12/12')
insert into emp1 values('John','12/12/34')
insert into emp1 values('John','12/12/56')
insert into emp1 values('John','12/12/05')
insert into emp1 values('John','12/12/21')
insert into emp1 values('John','12/12/90')

--create function
 create function calcage(@dob date)
 Returns int
 as
 begin
   Declare @age int
   set @age= DATEDIFF(year,@dob,getdate())
   return @age
   end
   select dbo.calcage('12/12/02') as Age
   select  id,name,dob,dbo.calcage(dob) as Age from emp1

   --inline function
  create function inl_tbl(@id int)
Returns table
as
        return(select * from emp1 where id=@id)

select * from inl_tbl(6)

select * from DLithe_Trainees

create function DLithe_Trainees_Fun(@dit varchar(25))
Returns table
as
        return(select * from DLithe_Trainees where TDEPT=@dit)

select * from DLithe_Trainees_Fun('DITDOTNET')

--Multistatement
CREATE function multi_stmt()
returns @table table(ID INT,NAME VARCHAR(25),DEPARTMENT VARCHAR(25))
as
        begin
                insert into @table
                select TID,TNAME,TDEPT from DLithe_Trainees where TADDRESS='Bangalore';
                Return
        end
SELECT * FROM multi_stmt();
select TID,TNAME,TDEPT from DLithe_Trainees where TADDRESS='Bangalore';