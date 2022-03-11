-- Strored Procedure
create procedure PROC_DT
AS
BEGIN
    select * from Dlithe_Trainees where TID <4;
	END
	exec PROC_DT
	----alter
	alter procedure PROC_DT
	AS
	BEGIN
	   select * from Dlithe_Trainees where TID < 4 and TADDRESS ='Bangalore';
	   end
	   exec PROC_DT
	   
 --DROP SP

 drop procedure Proc_dt

 --SP with Input parameters
 create procedure PROC_DT(@TADDRESS varchar(50)) --@TADDRESS-Table variable
 as
 BEGIN
	Select * from DLithe_Trainees where TADDRESS=@TADDRESS
 END

 exec PROC_DT @TADDRESS='Delhi'


 
 --SP with Output Parameters
 create procedure PROC_DT1(@TID int output)
 as
 BEGIN
 
	select @TID=max(TID) from DLithe_Trainees
 END
  Declare @TID int



 exec PROC_DT1 @TID OUTPUT

 print @TID