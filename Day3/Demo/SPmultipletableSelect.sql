USE [STUDYdb]
GO
/****** Object:  StoredProcedure [dbo].[SPShowEmployeeSalary]    Script Date: 11/19/2021 11:44:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure SPShowEmployeeSalary
(@sal decimal)
as
Begin
select * from employee where salary <@sal;
select * from employee where salary >=@sal;

end
