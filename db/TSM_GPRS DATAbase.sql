if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AccessAttach]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[AccessAttach]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AccessCust]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[AccessCust]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AccessEmp]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[AccessEmp]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SaveBank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SaveBank]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SaveCust]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SaveCust]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SaveEmp]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SaveEmp]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SaveLic]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SaveLic]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SaveRation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SaveRation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Savepan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Savepan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[bill]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[company]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[company]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[compdist]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[compdist]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[complain]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[complain]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[cust_photo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[cust_photo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[customer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[customer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[employee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[employee]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[login]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[login]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[receipt]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[receipt]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tmp]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tmp]
GO

CREATE TABLE [dbo].[bill] (
	[billno] [numeric](18, 0) IDENTITY (1000, 1) NOT NULL ,
	[custname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[address] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[area] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[contactno] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[paymentstatus] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[periodfrom] [datetime] NULL ,
	[periodto] [datetime] NULL ,
	[amount] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[company] (
	[companyname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[companyadd] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[city] [char] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[chairman] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[contact] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[fax] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[website] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[slogan] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[policy] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[compdist] (
	[Area] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Employees] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Complains] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[High] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Medium] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Low] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[complain] (
	[compno] [numeric](10, 0) IDENTITY (100, 1) NOT NULL ,
	[comptname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[phoneno] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[area] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[probtype] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[priority] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[compdate] [datetime] NULL ,
	[comptime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[status] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[emp_id] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[cust_photo] (
	[cust_id] [numeric](18, 0) NOT NULL ,
	[pic] [image] NULL ,
	[licence] [image] NULL ,
	[pan] [image] NULL ,
	[ration] [image] NULL ,
	[bank] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[customer] (
	[cust_id] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[custname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[custnominee] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pan] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[telephone] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[postadd] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[postarea] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[billadd] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[billarea] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[gender] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[facility] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[purpose] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[tele_pco] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[regdate] [datetime] NULL ,
	[mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[employee] (
	[emp_id] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[fname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[lname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[address] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Role] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[contactno] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[location] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[joindate] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pic] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[login] (
	[uname] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[password] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[role] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[receipt] (
	[receiptno] [numeric](18, 0) IDENTITY (2100, 1) NOT NULL ,
	[custname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[contactno] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pamount] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[paytype] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[bank] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[cheque] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pdate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tmp] (
	[id] [int] NULL ,
	[adflag] [int] NULL ,
	[emflag] [int] NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE [dbo].[AccessAttach]
( 
   @cust_id numeric (9,0) output
)
AS
select licence,pan,ration,bank  
from cust_photo
where cust_id=@cust_id

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE [dbo].[AccessCust]
( 
   @cust_id numeric (9,0) output
)
AS
select pic 
from cust_photo
where cust_id=@cust_id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE [dbo].[AccessEmp]
( 
   @emp_id numeric (9,0) output
)
AS
select pic  
from employee
where emp_id=@emp_id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE [dbo].[SaveBank]
( 
@cust_id numeric (9,0) output, 
@bank image
)
AS
update cust_photo set bank=@bank where cust_id=@cust_id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE [dbo].[SaveCust]
( 
@cust_id numeric (9,0) output, 
@pic image
)
AS
update cust_photo set pic=@pic where cust_id=@cust_id

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE [dbo].[SaveEmp]
( 
@emp_id numeric (9,0) output, 
@pic image
)
AS
update employee set pic=@pic where emp_id=@emp_id

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE [dbo].[SaveLic]
( 
@cust_id numeric (9,0) output, 
@licence image
)
AS
update cust_photo set licence=@licence where cust_id=@cust_id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE [dbo].[SaveRation]
( 
@cust_id numeric (9,0) output, 
@ration image
)
AS
update cust_photo set ration=@ration where cust_id=@cust_id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE [dbo].[Savepan]
( 
@cust_id numeric (9,0) output, 
@pan image
)
AS
update cust_photo set pan=@pan where cust_id=@cust_id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

