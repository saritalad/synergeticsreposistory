USE [sample]
drop table person
CREATE TABLE [dbo].[person]
	([personid] [int] PRIMARY KEY CLUSTERED IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](15) NULL,
	[lastname] [varchar](10)  NULL,
	[email] [varchar](30) NULL)

	insert into person(firstname,lastname,email)values ('Bill','Gates','Bill@gmail.com');
	
	insert into person(firstname,lastname,email)
	select 'Mill','James','Mill@gmail.com'
	union All
	select 'Jill','Kate','Jill@gmail.com'
	union All
	select 'Gill','James','Gill@gmail.com'
	union All
	select 'Thomas','Alva','Thomas@gmail.com'