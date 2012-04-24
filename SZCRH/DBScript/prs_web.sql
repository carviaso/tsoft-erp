-- SQL Manager 2008 for SQL Server 3.3.0.1
-- ---------------------------------------
-- Host      : mssql1.netjsp.com,1433
-- Database  : za00036
-- Version   : Microsoft SQL Server  10.0.2531.0


--
-- Definition for table CM_Member : 
--

CREATE TABLE [dbo].[CM_Member] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cCompany] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cRecomMember] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iState] int NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cId] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [dRecommendDate] datetime NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_MemberDetail : 
--

CREATE TABLE [dbo].[CM_MemberDetail] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cCompany] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cRecomMember] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iSex] int NULL,
  [cPhone] varchar(30) COLLATE Chinese_PRC_CI_AS NULL,
  [cEduLevel] varchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [iAge] int NULL,
  [dBirthDate] datetime NULL,
  [cEmail] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] varchar(200) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cDegreeLevel] varchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [iMarriage] int NULL,
  [cNation] varchar(5) COLLATE Chinese_PRC_CI_AS NULL,
  [cLanguageLevel] varchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [cHukou] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cId] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cZip] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamName1] varchar(15) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamRela1] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamWork1] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamName2] varchar(15) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamRela2] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamWork2] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamName3] varchar(15) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamRela3] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamWork3] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamName4] varchar(15) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamRela4] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamWork4] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamName5] varchar(15) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamRela5] varchar(6) COLLATE Chinese_PRC_CI_AS NULL,
  [cFamWork5] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dEduDateStart1] datetime NULL,
  [dEduDateEnd1] datetime NULL,
  [cEduSchool1] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEduField1] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dEduDateStart2] datetime NULL,
  [dEduDateEnd2] datetime NULL,
  [cEduSchool2] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEduField2] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dEduDateStart3] datetime NULL,
  [dEduDateEnd3] datetime NULL,
  [cEduSchool3] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEduField3] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dRecommendDate] datetime NULL,
  [state] int NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', N'更新状态', 'schema', 'dbo', 'table', 'CM_MemberDetail', 'column', 'state'
GO

--
-- Definition for table MEM_MemberAllowDetail : 
--

CREATE TABLE [dbo].[MEM_MemberAllowDetail] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cHeadGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cMemberCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iMemberAllow] decimal(9, 2) NULL,
  [cMemberName] varchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [iRecNum] int NULL,
  [iTeamNum] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table MEM_MemberAllowList : 
--

CREATE TABLE [dbo].[MEM_MemberAllowList] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dDate] datetime NULL,
  [iMemberNum] int NULL,
  [iAllowSum] decimal(9, 2) NULL,
  [cAuditor] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dAuditDate] datetime NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cCreator] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cDepartment] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cRemark] varchar(250) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table MEM_MemberRecommend : 
--

CREATE TABLE [dbo].[MEM_MemberRecommend] (
  [cMemberCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cRecommendCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iYear] int NULL,
  [iMonth] int NULL,
  [iState] int NULL,
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL
)
ON [PRIMARY]
GO

--
-- Definition for table PRS_Operator : 
--

CREATE TABLE [dbo].[PRS_Operator] (
  [password] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [username] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [id] varchar(30) COLLATE Chinese_PRC_CI_AS NOT NULL
)
ON [PRIMARY]
GO

--
-- Data for table dbo.PRS_Operator  (LIMIT 0,500)
--

INSERT INTO [dbo].[PRS_Operator] ([password], [username], [id])
VALUES 
  (N'123', N'ice', N'001')
GO

--
-- Definition for indices : 
--

ALTER TABLE [dbo].[CM_Member]
ADD CONSTRAINT [CM_Member_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[MEM_MemberRecommend]
ADD CONSTRAINT [MEM_MemberRecommend_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[PRS_Operator]
ADD CONSTRAINT [PK__PRS_Oper__3213E83F023D5A04] 
PRIMARY KEY CLUSTERED ([id])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

