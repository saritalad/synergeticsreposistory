--create procedure SPGetStudentByID
--( @id int            )
--as
--begin
--select * from students where rollno=@id;
--end
--go
--execute SPGetStudentByID 103
--drop procedure myprocedure 
create procedure SPShowEmployeeSalary
(@sal decimal)
as
Begin
select * from employee where salary <@sal;
end
go
