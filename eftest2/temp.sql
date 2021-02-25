
sp_help EmployeeDetails
CREATE PROCEDURE getdetails
@empid int
as
begin
select * from EmployeeDetails where EmployeeID=@empid
end

exec GETDETAILS 11

-------------------------------------------------------------
CREATE PROCEDURE InsertEmployee
       @Empid int,
       @EmpName varchar(30),
       @salary int
AS
BEGIN
       INSERT INTO EmployeeDetails
              (EmployeeID, EmployeeName, salary)
       VALUES
              (@Empid, @EmpName, @salary)
END
--------------------------------------------------------------
exec InsertEmployee 29,'gdhdh',7888
--------------------------------------------------------------
CREATE PROCEDURE UpdateEmployee
       @Empid int,
       @EmpName varchar(30),
       @salary int
AS
BEGIN
       UPDATE EmployeeDetails SET  
             EmployeeName = @EmpName, salary = @salary
             WHERE EmployeeID = @Empid  
END

----------------------------------------------------------------
exec UpdateEmployee 23,'pan',90000
drop procedure UpdateEmployee
delete from EmployeeDetails where EmployeeID=23
----------------------------------------------------------------

CREATE PROCEDURE DeleteEmployee
       @Empid int
AS
BEGIN
       DELETE FROM EmployeeDetails
             WHERE EmployeeID = @Empid  
END
-------------------------------------------------------------------
exec DeleteEmployee 23

