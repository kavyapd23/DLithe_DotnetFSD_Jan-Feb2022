use dml;



--Information Schema View
SELECT * FROM INFORMATION_SCHEMA.COLUMNS
where TABLE_NAME='Trainees28';

--Catalog View
select * from sys.tables ;

--Dynamic Management View


 --To see all SQL Server connections
SELECT connection_id,session_id,client_net_address,auth_scheme
FROM sys.dm_exec_connections ;

-- Create view on single table Trainees28
create VIEW Trainees28Toppers
AS
Select *
From trainees28 where score>97;

select * from Trainees28Toppers;



insert into Trainees28Toppers values(17,'Lucky','HR',98);

update Trainees28Toppers set designation='Tester' where empid=17;

delete from Trainees28Toppers where empid=17;

--Complex View
--When we create a view on more than one table, it is called a complex view.

create view onlineshoppingview
as
SELECT OC.CUSTOMERID,customerName, customercity, customermail, salestotal,o.orderid
FROM onlinecustomers AS oc
   INNER JOIN
   orders AS o
   ON oc.customerid = o.customerid
   INNER JOIN
   sales AS s
   ON o.orderId = s.orderId;

select * from onlineshoppingview;

--We can only update data in a complex view. We can't insert data in a complex view.

update onlineshoppingview set salestotal=salestotal-50;