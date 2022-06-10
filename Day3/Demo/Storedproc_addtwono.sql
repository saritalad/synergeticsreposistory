use STUDYdb
Create Procedure AddTwoNumber(@p1 int,@p2 int,@Result int output)
as
Begin
	Set @Result = @p1+ @p2
End
--------------------------------
declare @p3 int
execute addtwonumber @p1=78,@p2=89,
@Result= @p3 out
select @p3 as 'result';