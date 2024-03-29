-- SQL Manager 2008 for SQL Server 3.3.0.1
-- ---------------------------------------
-- Host      : 192.168.0.103,1433
-- Database  : TS3000SZ
-- Version   : Microsoft SQL Server  9.00.3042.00


--
-- Definition for table CM_Csgl : 
--

CREATE TABLE [dbo].[CM_Csgl] (
  [cGUID] bigint IDENTITY(1, 1) NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cParent] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cType] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cUserValue] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cDefValue] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cValueFetch] nvarchar(max) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Customer : 
--

CREATE TABLE [dbo].[CM_Customer] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] varchar(25) COLLATE Chinese_PRC_CI_AS NULL,
  [cClassGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint CONSTRAINT [DF_BS_Customer_iLeaf] DEFAULT 0 NOT NULL,
  [cParentGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cPostCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cRegion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cSupBank] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAccount] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cLPersion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFax] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iCreLimit] numeric(21, 9) NULL,
  [iStatus] smallint CONSTRAINT [DF_BS_Customer_iStatus] DEFAULT 1 NULL,
  [cRemark] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cContact] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cContactPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Department : 
--

CREATE TABLE [dbo].[CM_Department] (
  [cGUID] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint NULL,
  [cParent] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iDisabledFlag] smallint NULL,
  [cRemark] nvarchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cFullName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', N'所属部门', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'cParent'
GO

EXEC sp_addextendedproperty 'MS_Description', N'禁用标示：0启用；1禁用', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'iForbidden'
GO

EXEC sp_addextendedproperty 'MS_Description', N'全名', 'schema', 'dbo', 'table', 'CM_Department', 'column', 'cFullName'
GO

--
-- Definition for table CM_Employee : 
--

CREATE TABLE [dbo].[CM_Employee] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iSex] int NULL,
  [cID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint NULL,
  [cDepartment] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cOfficePhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEmail] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cBirthplace] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iStatus] smallint NULL,
  [dBirthDate] datetime NULL,
  [iDimisssion] nchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [cRemark] nvarchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cGroupGUID] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEducational] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [dEnterDate] datetime NULL,
  [cGraduateschool] nchar(10) COLLATE Chinese_PRC_CI_AS NULL,
  [cAge] int NULL,
  [iForbidden] int NULL,
  [cBank] varchar(30) COLLATE Chinese_PRC_CI_AS NULL,
  [cBankAccount] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dExitDate] datetime NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', N'1:男;0:女', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'iSex'
GO

EXEC sp_addextendedproperty 'MS_Description', N'身份证号码', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cID'
GO

EXEC sp_addextendedproperty 'MS_Description', N'所属部门', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cDepartment'
GO

EXEC sp_addextendedproperty 'MS_Description', N'入职时间', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'dEnterDate'
GO

EXEC sp_addextendedproperty 'MS_Description', N'1：禁用；0:启用', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'iForbidden'
GO

EXEC sp_addextendedproperty 'MS_Description', N'开户银行', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cBank'
GO

EXEC sp_addextendedproperty 'MS_Description', N'银行账号', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'cBankAccount'
GO

EXEC sp_addextendedproperty 'MS_Description', N'离职时间', 'schema', 'dbo', 'table', 'CM_Employee', 'column', 'dExitDate'
GO

--
-- Definition for table CM_Member : 
--

CREATE TABLE [dbo].[CM_Member] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
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
  [dRecommendDate] datetime NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Region : 
--

CREATE TABLE [dbo].[CM_Region] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_Supply : 
--

CREATE TABLE [dbo].[CM_Supply] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cShortName] varchar(25) COLLATE Chinese_PRC_CI_AS NULL,
  [cClassGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iLeaf] smallint CONSTRAINT [DF_BS_Supply_iLeaf] DEFAULT 0 NOT NULL,
  [cParent] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cAddress] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cPostCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cRegion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cSupBank] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cAccount] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cLPersion] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFax] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iCreLimit] numeric(21, 9) NULL,
  [iStatus] smallint CONSTRAINT [DF_BS_Supply_iStatus] DEFAULT 1 NULL,
  [cRemark] nvarchar(150) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cContact] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cContactPhone] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cFullName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table CM_SysInfo : 
--

CREATE TABLE [dbo].[CM_SysInfo] (
  [cGUID] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table MEM_MemberAllowDetail : 
--

CREATE TABLE [dbo].[MEM_MemberAllowDetail] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cHeadGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cMemberCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
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
  [cMemberCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cRecommendCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iYear] int NULL,
  [iMonth] int NULL,
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [iState] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Log : 
--

CREATE TABLE [dbo].[Sys_Log] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dDateTime] datetime NULL,
  [cAction] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cUserName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cRoleName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cModualName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Menu : 
--

CREATE TABLE [dbo].[Sys_Menu] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(200) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cTitle] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cForm] varchar(200) COLLATE Chinese_PRC_CI_AS NULL,
  [cField] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [iOrder] int NULL,
  [cImgPath] varchar(250) COLLATE Chinese_PRC_CI_AS NULL,
  [cAction] varchar(30) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', N'基础数据、列表、账表', 'schema', 'dbo', 'table', 'Sys_Menu', 'column', 'cField'
GO

--
-- Definition for table Sys_Modual : 
--

CREATE TABLE [dbo].[Sys_Modual] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cTitle] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cType] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cImgPath] varchar(200) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_ModualFlow : 
--

CREATE TABLE [dbo].[Sys_ModualFlow] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [cModual] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cButton] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iX] int NULL,
  [iY] int NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_Role : 
--

CREATE TABLE [dbo].[Sys_Role] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_RoleBtnSecu : 
--

CREATE TABLE [dbo].[Sys_RoleBtnSecu] (
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cBtnSecu] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cModual] varchar(50) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_RoleSecu : 
--

CREATE TABLE [dbo].[Sys_RoleSecu] (
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cSecu] varchar(100) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_SysMenu : 
--

CREATE TABLE [dbo].[Sys_SysMenu] (
  [cGUID] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_SysModualBtn : 
--

CREATE TABLE [dbo].[Sys_SysModualBtn] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] varchar(100) COLLATE Chinese_PRC_CI_AS NULL,
  [cParent] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int NULL,
  [cTimeStamp] varchar(20) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_User : 
--

CREATE TABLE [dbo].[Sys_User] (
  [cGUID] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cEmployee] nvarchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cTimeStamp] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cRole] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [iForbidden] int CONSTRAINT [DF_Sys_User_iForbidden] DEFAULT 0 NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Sys_UserSecu : 
--

CREATE TABLE [dbo].[Sys_UserSecu] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cUser] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cPassword] varchar(18) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Data for table dbo.CM_Customer  (LIMIT 0,500)
--

INSERT INTO [dbo].[CM_Customer] ([cGUID], [cCode], [cName], [cShortName], [cClassGUID], [iLeaf], [cParentGUID], [cAddress], [cPostCode], [cRegion], [cSupBank], [cAccount], [cLPersion], [cPhone], [cFax], [iCreLimit], [iStatus], [cRemark], [cTimeStamp], [cContact], [cContactPhone], [iForbidden])
VALUES 
  (N'842436572909591255', N'001', N'Google', NULL, NULL, 0, NULL, NULL, NULL, N'001', NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, N'412264006359285145', NULL, NULL, 0)
GO

INSERT INTO [dbo].[CM_Customer] ([cGUID], [cCode], [cName], [cShortName], [cClassGUID], [iLeaf], [cParentGUID], [cAddress], [cPostCode], [cRegion], [cSupBank], [cAccount], [cLPersion], [cPhone], [cFax], [iCreLimit], [iStatus], [cRemark], [cTimeStamp], [cContact], [cContactPhone], [iForbidden])
VALUES 
  (N'651289553367433456', N'002', N'00010', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, N'993749674981762037', NULL, NULL, 0)
GO

--
-- Data for table dbo.CM_MemberDetail  (LIMIT 0,500)
--

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'964655839200545439', N'00001', N'张三', N'001', N'000000', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'529413535451865208', NULL, 1, NULL, NULL, NULL, N'3210000000', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'993602616051509312', N'00002', N'lisi', N'001', N'00001', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'540498530173687616', NULL, 1, NULL, NULL, NULL, N'33333333', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'035670361805054423', N'00003', N'付', N'001', N'00001', 1, N'444444444', NULL, NULL, NULL, NULL, NULL, 0, N'407893999968221654', NULL, 1, N'汉族', NULL, NULL, N'5555555555', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20120308')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'370873409364154114', N'00004', N'wang', N'001', N'00001', 1, NULL, NULL, NULL, NULL, NULL, N'355555498712351254', 0, N'707494508677684218', NULL, 1, NULL, NULL, NULL, N'355555498712351254', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'229923049686202671', N'00005', N'chne', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'269612513417347540', NULL, 1, NULL, NULL, NULL, N'1111', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'806939810730943630', N'00006', N'www', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'054635399589757426', NULL, 1, NULL, NULL, NULL, N'33', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'614609889342808465', N'00007', N'www', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'127477782388967595', NULL, 1, NULL, NULL, NULL, N'333', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'639404205485473185', N'00008', N'ss', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'702722797662761153', NULL, 1, NULL, NULL, NULL, N'3332', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'682069601737387070', N'00009', N'22', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'174417147045616895', NULL, 1, NULL, NULL, NULL, N'3232', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'789254781614107895', N'00010', N'ee', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'538298427379914649', NULL, 1, NULL, NULL, NULL, N'322', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'672163954616611336', N'00011', N'32', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'671082409825262714', NULL, 1, N'23', NULL, NULL, N'333333333333333', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'468370545143849745', N'00012', N'21212', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'316705305929384250', NULL, 1, NULL, NULL, NULL, N'321123', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'482192573092485200', N'00013', N'11', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'764201662466976141', NULL, NULL, NULL, NULL, NULL, N'4323', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'786190290949813063', N'00014', N'2132', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'112856086698718229', NULL, NULL, NULL, NULL, NULL, N'321231', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'947959153621341405', N'00015', N'211', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'282184758177569469', NULL, NULL, NULL, NULL, NULL, N'2131', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'398736559845978951', N'00016', N'231', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'538649450570519905', NULL, NULL, N'22', NULL, NULL, N'32121', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'528186353667993902', N'00017', N'weqr', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'315722310665461473', NULL, NULL, NULL, NULL, NULL, N'32132', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'352883378859031692', N'00018', N'32', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'969633360483581623', NULL, NULL, NULL, NULL, NULL, N'21213', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'353086818454731538', N'00019', N'321', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'903503254992406137', NULL, NULL, NULL, NULL, NULL, N'31213213123123', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'759227925640567420', N'00020', N'w', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'643488375811093434', NULL, NULL, NULL, NULL, NULL, N'2123123', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'401742292192412752', N'00021', N'wqeq', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'958040814671125294', NULL, NULL, NULL, NULL, NULL, N'212312312312', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'867384013960333697', N'00022', N'1231', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'615917524221272516', NULL, NULL, NULL, NULL, NULL, N'31231231231231', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'331859743510613669', N'00023', N'd', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'358590050076940709', NULL, NULL, NULL, NULL, NULL, N'1231312341234', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'051638349194277441', N'00024', N'231', N'001', N'00004', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'247114247502922717', NULL, NULL, N'123', NULL, NULL, N'312312312312312312', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'625404629342840327', N'00025', N'itmail@3g.sina.cn', N'001', N'00004', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'740930499805230481', NULL, 1, NULL, NULL, NULL, N'3534543', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'465779457050876057', N'00026', N'44', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'471121700234555349', NULL, NULL, NULL, NULL, NULL, N'3455', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'618980786289275009', N'00027', N'3455', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'864418019544272070', NULL, NULL, NULL, NULL, NULL, N'5354', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'846879451878125387', N'00028', N'5634', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'760861036682902285', NULL, NULL, NULL, NULL, NULL, N'56346', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'640443101784868903', N'00029', N'3456', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'046947034177886775', NULL, NULL, NULL, NULL, NULL, N'6356', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'754973794676328110', N'00030', N'634', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'644428469325798680', NULL, NULL, NULL, NULL, NULL, N'6346', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'387016802073968311', N'00031', N'63', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'703121659910643975', NULL, NULL, NULL, NULL, NULL, N'636', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'098431733879585122', N'00032', N'546', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'282171479121452365', NULL, NULL, NULL, NULL, NULL, N'63466', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'447215308367895490', N'00033', N'636', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'385466950550772298', NULL, NULL, NULL, NULL, NULL, N'63557346', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'941965386534762178', N'00034', N'63', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'004276853028230238', NULL, NULL, NULL, NULL, NULL, N'654667', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'279528242296395037', N'00035', N'643', N'001', N'00004', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'802882215070299450', NULL, NULL, NULL, NULL, NULL, N'64674567', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'253280959343897548', N'00036', N'itmail@3g.sina.cn', N'001', N'00008', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'848080035414501023', NULL, 1, NULL, NULL, NULL, N'65654', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'765219660122893932', N'00037', N'2', N'001', N'00008', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'181449571692515372', NULL, 1, NULL, NULL, NULL, N'361654', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'293357789535028661', N'00038', N'3', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'728921959831204039', NULL, NULL, NULL, NULL, NULL, N'5245', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'742328874149547437', N'00039', N'4', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'078892302016819051', NULL, NULL, NULL, NULL, NULL, N'364', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'484620669901519803', N'00040', N'5', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'418062778491852381', NULL, NULL, NULL, NULL, NULL, N'3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'696948535389535674', N'00041', N'6', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'302157052091135578', NULL, NULL, NULL, NULL, NULL, N'2', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'886883223159441501', N'00042', N'7', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'567656823154974607', NULL, NULL, NULL, NULL, NULL, N'6', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'005327178554722800', N'00043', N'5', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'539882166388039572', NULL, NULL, NULL, NULL, NULL, N'32346', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'564933420305014105', N'00044', N'8', N'001', N'00008', 0, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'133877742835150300', NULL, NULL, NULL, NULL, NULL, N'3135', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

INSERT INTO [dbo].[CM_MemberDetail] ([cGUID], [cCode], [cName], [cCompany], [cRecomMember], [iSex], [cPhone], [cEduLevel], [iAge], [dBirthDate], [cEmail], [cAddress], [iForbidden], [cTimeStamp], [cDegreeLevel], [iMarriage], [cNation], [cLanguageLevel], [cHukou], [cId], [cZip], [cFamName1], [cFamRela1], [cFamWork1], [cFamName2], [cFamRela2], [cFamWork2], [cFamName3], [cFamRela3], [cFamWork3], [cFamName4], [cFamRela4], [cFamWork4], [cFamName5], [cFamRela5], [cFamWork5], [dEduDateStart1], [dEduDateEnd1], [cEduSchool1], [cEduField1], [dEduDateStart2], [dEduDateEnd2], [cEduSchool2], [cEduField2], [dEduDateStart3], [dEduDateEnd3], [cEduSchool3], [cEduField3], [dRecommendDate])
VALUES 
  (N'414493099570823831', N'00045', N'drs', N'001', N'00008', 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'101425551988569294', NULL, 1, NULL, NULL, NULL, N'564565432', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '20111127')
GO

--
-- Data for table dbo.CM_Region  (LIMIT 0,500)
--

INSERT INTO [dbo].[CM_Region] ([cGUID], [cCode], [cName], [cParent], [cTimeStamp], [iForbidden])
VALUES 
  (N'671100108809282090', N'001', N'江苏', N'000000', N'553347244024699353', 0)
GO

--
-- Data for table dbo.CM_SysInfo  (LIMIT 0,500)
--

INSERT INTO [dbo].[CM_SysInfo] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'1', N'123', N'test模块', NULL)
GO

--
-- Data for table dbo.Sys_Log  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Log] ([cGUID], [dDateTime], [cAction], [cUserName], [cRoleName], [cModualName])
VALUES 
  (N'670252422660781461', '20120206 20:21:16.497', N'同步失败', N'admin', N'admin', N'系统管理')
GO

INSERT INTO [dbo].[Sys_Log] ([cGUID], [dDateTime], [cAction], [cUserName], [cRoleName], [cModualName])
VALUES 
  (N'394114529329259443', '20120206 20:29:46.260', N'同步失败', N'admin', N'admin', N'系统管理')
GO

INSERT INTO [dbo].[Sys_Log] ([cGUID], [dDateTime], [cAction], [cUserName], [cRoleName], [cModualName])
VALUES 
  (N'444555228152388050', '20120206 20:32:19.730', N'同步失败', N'admin', N'admin', N'系统管理')
GO

INSERT INTO [dbo].[Sys_Log] ([cGUID], [dDateTime], [cAction], [cUserName], [cRoleName], [cModualName])
VALUES 
  (N'184617521330122009', '20120206 20:34:33.433', N'同步失败', N'admin', N'admin', N'系统管理')
GO

INSERT INTO [dbo].[Sys_Log] ([cGUID], [dDateTime], [cAction], [cUserName], [cRoleName], [cModualName])
VALUES 
  (N'390068243187138188', '20120206 20:35:08.307', N'同步失败', N'admin', N'admin', N'系统管理')
GO

--
-- Data for table dbo.Sys_Menu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'1', N'Employee', N'Member;BaseData', N'职员', N'TS.Sys.Platform.Forms.BaseDataForms.EmployeeForm', N'base;item', N'Employee', NULL, N'\\Employee.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'10', N'MemberAllowList', N'Member;', N'会员津贴列表', N'TS.Sys.Platform.Forms.MemberMan.MemberAllowListForm', N'list', N'MemberAllowList', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'2', N'Office', N'Member;', N'公司信息', N'TS.Sys.Platform.Forms.BaseDataForms.CompanyForm', N'base;item', N'Company', NULL, N'\\Employee.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'3', N'Department', N'BaseData;Member;', N'部门', N'TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm', N'base;item', N'Department', NULL, N'\\Department.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'4', N'MemberList', N'Member;', N'会员列表', N'TS.Sys.Platform.Forms.MemberMan.MemberListForm', N'list', N'MemberList', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'425868004605718620', N'Region', N'Member;BaseData;', N'区域', N'TS.Sys.Platform.Forms.BaseDataForms.RegionForm', N'base;', N'Region', NULL, N'\\Region.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'5', N'User', N'SysManager;', N'用戶', N'TS.Sys.Platform.Forms.SysManager.UserForm', N'item', N'User', NULL, N'\\User.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'6', N'Role', N'SysManager;', N'角色管理', N'TS.Sys.Platform.Forms.SysManager.RoleForm', N'item', N'Role', NULL, N'\\Role.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'687704809578090819', N'Customer', N'Member;BaseData;', N'公司', N'TS.Sys.Platform.Forms.BaseDataForms.CustomerForm', N'base;item;', N'Customer', NULL, N'\\Company.png', NULL)
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'7', N'MemberDetail', N'Member;', N'会员信息', N'TS.Sys.Platform.Forms.MemberMan.MemberDetailForm', N'bill;', N'MemberDetail', NULL, N'\\Employee.png', N'new')
GO

INSERT INTO [dbo].[Sys_Menu] ([cGUID], [cCode], [cParent], [cTitle], [cForm], [cField], [cName], [iOrder], [cImgPath], [cAction])
VALUES 
  (N'9', N'MemberAllowDetail', N'Member;', N'会员津贴', N'TS.Sys.Platform.Forms.MemberMan.MemberAllowDetailForm', N'bill;', N'MemberAllowDetail', NULL, N'\\money.png', N'new')
GO

--
-- Data for table dbo.Sys_Modual  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Modual] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cTitle], [cType], [cImgPath])
VALUES 
  (N'1', N'002', N'BaseData', N'2', 0, N'基础数据', N'base', N'\\basedata.png')
GO

INSERT INTO [dbo].[Sys_Modual] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cTitle], [cType], [cImgPath])
VALUES 
  (N'2', N'003', N'SysManager', N'3', 0, N'系统管理', N'base', N'\\SysManager.png')
GO

INSERT INTO [dbo].[Sys_Modual] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cTitle], [cType], [cImgPath])
VALUES 
  (N'3', N'001', N'Member', N'1', 0, N'会员管理', N'business', N'\\Employee.png')
GO

--
-- Data for table dbo.Sys_ModualFlow  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_ModualFlow] ([cGUID], [cModual], [cButton], [iX], [iY])
VALUES 
  (N'1', N'Member', N'Customer', 216, 57)
GO

INSERT INTO [dbo].[Sys_ModualFlow] ([cGUID], [cModual], [cButton], [iX], [iY])
VALUES 
  (N'2', N'Member', N'Department', 65, 308)
GO

INSERT INTO [dbo].[Sys_ModualFlow] ([cGUID], [cModual], [cButton], [iX], [iY])
VALUES 
  (N'3', N'Member', N'MemberDetail', 216, 184)
GO

INSERT INTO [dbo].[Sys_ModualFlow] ([cGUID], [cModual], [cButton], [iX], [iY])
VALUES 
  (N'4', N'Member', N'MemberAllowDetail', 216, 308)
GO

INSERT INTO [dbo].[Sys_ModualFlow] ([cGUID], [cModual], [cButton], [iX], [iY])
VALUES 
  (N'5', N'Member', N'User', 378, 308)
GO

--
-- Data for table dbo.Sys_Role  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_Role] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cParent])
VALUES 
  (N'196474437873810042', N'001', N'系统管理员', N'834379212212367802', 0, N'000000')
GO

INSERT INTO [dbo].[Sys_Role] ([cGUID], [cCode], [cName], [cTimeStamp], [iForbidden], [cParent])
VALUES 
  (N'709754019572694177', N'002', N'操作员', N'764084492202530149', 0, N'000000')
GO

--
-- Data for table dbo.Sys_RoleBtnSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'MemberList')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'Employee')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'Department')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'Customer')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'Region')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnDelete', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'002', N'btnSave', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnNew', N'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSecu', N'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'MemberList')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnNew', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'Department')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'Employee')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnNew', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnNew', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'User')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'Role')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnNew', N'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'MemberAllowList')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnAudit', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnUnAudit', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnValueable', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnForbidden', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnUnAudit', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'RoleDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'Customer')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnDelete', N'Region')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnModifyRecom', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnSave', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnAudit', N'MemberAllowList')
GO

INSERT INTO [dbo].[Sys_RoleBtnSecu] ([cRole], [cBtnSecu], [cModual])
VALUES 
  (N'001', N'btnUnAudit', N'MemberAllowList')
GO

--
-- Data for table dbo.Sys_RoleSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'Member')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'MemberList')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'MemberAllowList')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'BaseData')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'Employee')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'Department')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'Customer')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'Region')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'002', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Member')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'MemberList')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'MemberDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'MemberAllowList')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'MemberAllowDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'BaseData')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Employee')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Department')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'EmployeeDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'DepartmentDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Customer')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'CustomerDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Region')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'RegionDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'SysManager')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'User')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'Role')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'UserDetail')
GO

INSERT INTO [dbo].[Sys_RoleSecu] ([cRole], [cSecu])
VALUES 
  (N'001', N'RoleDetail')
GO

--
-- Data for table dbo.Sys_SysMenu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'1', N'Member', N'会员管理', N'000000')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'2', N'BaseData', N'基础数据', N'000000')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'3', N'SysManager', N'系统管理', N'000000')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'4', N'Employee', N'职员', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'5', N'MemberList', N'会员列表', N'Member')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'6', N'User', N'用户管理', N'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'7', N'Department', N'部门', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'8', N'Role', N'角色', N'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'804212863163847839', N'MemberDetail', N'会员信息', N'Member')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'641598202973036461', N'EmployeeDetail', N'职员信息', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'620862060877880539', N'DepartmentDetail', N'部门信息', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'882440247293767373', N'UserDetail', N'用户信息', N'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'291476838162828188', N'RoleDetail', N'角色信息', N'SysManager')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'9', N'MemberAllowList', N'会员津贴列表', N'Member')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'10', N'MemberAllowDetail', N'会员津贴明细', N'Member')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'630667100210013334', N'Customer', N'公司', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'990299510370251156', N'CustomerDetail', N'公司信息', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'264791715305606171', N'Region', N'区域', N'BaseData')
GO

INSERT INTO [dbo].[Sys_SysMenu] ([cGUID], [cCode], [cName], [cParent])
VALUES 
  (N'826199088004984525', N'RegionDetail', N'区域信息', N'BaseData')
GO

--
-- Data for table dbo.Sys_SysModualBtn  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'562201868196224881', N'btnDelete', N'删除', N'MemberList', 0, N'556060435429354037')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'615032542291679103', N'btnForbidden', N'禁用', N'UserDetail', 0, N'392536713903971003')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'193348118955599114', N'btnSave', N'保存', N'EmployeeDetail', 0, N'341689994402234891')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'668931806611010372', N'btnDelete', N'删除', N'EmployeeDetail', 0, N'915636740064937803')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'397658173471912685', N'btnDelete', N'删除', N'Employee', 0, N'636155490666508260')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'683314221269324579', N'btnValueable', N'启用', N'UserDetail', 0, N'367284895471814174')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'636959251796138763', N'btnSave', N'保存', N'DepartmentDetail', 0, N'291436290509433181')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'914346473544937556', N'btnDelete', N'删除', N'DepartmentDetail', 0, N'143469551375984330')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'745953918632380294', N'btnForbidden', N'禁用', N'RoleDetail', 0, N'248918062558787320')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'233227569489918091', N'btnDelete', N'删除', N'UserDetail', 0, N'012472683455175720')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'441223097265463606', N'btnSave', N'保存', N'UserDetail', 0, N'506003733478022182')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'987877896566183265', N'btnValueable', N'启用', N'RoleDetail', 0, N'918686846218065860')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'969338681484832765', N'btnSave', N'保存', N'RoleDetail', 0, N'125521296172879353')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'759303068101182276', N'btnDelete', N'删除', N'RoleDetail', 0, N'935174608532053106')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'430840550890611849', N'btnSecu', N'权限分配', N'RoleDetail', 0, N'624333667281143779')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'592534133867519865', N'btnDelete', N'删除', N'User', 0, N'236689144393614346')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'671802600219286326', N'btnDelete', N'删除', N'Role', 0, N'203687408239755277')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'512644861232527246', N'btnSave', N'保存', N'MemberAllowDetail', 0, N'193430502516091447')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'148636407132561792', N'btnDelete', N'删除', N'MemberAllowList', 0, N'736724616507934359')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'640231130470001109', N'btnDelete', N'删除', N'MemberAllowDetail', 0, N'209403397137769531')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'281271779130565105', N'btnDelete', N'删除', N'Customer', 0, N'878739460208056940')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'766956880568337818', N'btnAudit', N'审核', N'MemberAllowList', 0, N'804319965005733830')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'666592778861445393', N'btnUnAudit', N'反审核', N'MemberAllowList', 0, N'684607870064438069')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'612731592658259401', N'btnAudit', N'审核', N'MemberAllowDetail', 0, N'606529108971038689')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'962528379528635759', N'btnUnAudit', N'反审核', N'MemberAllowDetail', 0, N'384603599342878306')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'100527768707532741', N'btnDelete', N'删除', N'Region', 0, N'510220205343907466')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'051195229814682831', N'btnDelete', N'删除', N'RegionDetail', 0, N'733096946367535137')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'214946546043728205', N'btnSave', N'保存', N'RegionDetail', 0, N'343532904347579610')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'065858407472169254', N'btnForbidden', N'禁用', N'RegionDetail', 0, N'637192043785322098')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'667889330382817508', N'btnValueable', N'启用', N'RegionDetail', 0, N'924961563207768867')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'506632072150134434', N'btnModifyRecom', N'修改推荐人', N'MemberDetail', 0, N'597795428448100419')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'149522094948933056', N'btnDelete', N'删除', N'Department', 0, N'635608406818216810')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'725959854634320758', N'btnSave', N'保存', N'MemberDetail', 0, N'594865245515517096')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'744565666666453937', N'btnDelete', N'删除', N'MemberDetail', 0, N'590208504772279299')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'917893950176042522', N'btnSave', N'保存', N'CustomerDetail', 0, N'179081200317631687')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'810489547581584122', N'btnDelete', N'删除', N'CustomerDetail', 0, N'493032964861766235')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'642283503699053895', N'btnForbidden', N'禁用', N'CustomerDetail', 0, N'457877719066921630')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'060228029925049052', N'btnValueable', N'启用', N'CustomerDetail', 0, N'064487629486476781')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'960062558109745991', N'btnForbidden', N'禁用', N'EmployeeDetail', 0, N'685965379229960648')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'120613416675825623', N'btnValueable', N'启用', N'EmployeeDetail', 0, N'933576268429180530')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'865849684843598941', N'btnForbidden', N'禁用', N'DepartmentDetail', 0, N'395828163508544670')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'590804953655480083', N'btnValueable', N'启用', N'DepartmentDetail', 0, N'708494476720658823')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'333201705496213564', N'btnForbidden', N'禁用', N'MemberDetail', 0, N'791578545515715327')
GO

INSERT INTO [dbo].[Sys_SysModualBtn] ([cGUID], [cCode], [cName], [cParent], [iForbidden], [cTimeStamp])
VALUES 
  (N'579245471623907330', N'btnValueable', N'启用', N'MemberDetail', 0, N'063011701290385630')
GO

--
-- Data for table dbo.Sys_User  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_User] ([cGUID], [cName], [cEmployee], [cCode], [cTimeStamp], [cRole], [iForbidden])
VALUES 
  (N'1', N'admin', NULL, N'001', N'691447842641059515', N'001', 0)
GO

INSERT INTO [dbo].[Sys_User] ([cGUID], [cName], [cEmployee], [cCode], [cTimeStamp], [cRole], [iForbidden])
VALUES 
  (N'981876562626462170', N'test1', NULL, N'002', N'288119421871472415', N'001', 0)
GO

--
-- Data for table dbo.Sys_UserSecu  (LIMIT 0,500)
--

INSERT INTO [dbo].[Sys_UserSecu] ([cGUID], [cUser], [cPassword])
VALUES 
  (N'1', N'001', N'admin1')
GO

INSERT INTO [dbo].[Sys_UserSecu] ([cGUID], [cUser], [cPassword])
VALUES 
  (N'462890013449200044', N'002', N'123')
GO

INSERT INTO [dbo].[Sys_UserSecu] ([cGUID], [cUser], [cPassword])
VALUES 
  (N'404712049409926072', N'002', N'123')
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

ALTER TABLE [dbo].[CM_Region]
ADD CONSTRAINT [PK__CM_Regio__FF6300F72B3F6F97] 
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

ALTER TABLE [dbo].[Sys_Menu]
ADD CONSTRAINT [Sys_Menu_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_Modual]
ADD CONSTRAINT [Sys_Modual_pk] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sys_ModualFlow]
ADD CONSTRAINT [PK__SysModua__FF6300F75CD6CB2B] 
PRIMARY KEY CLUSTERED ([cGUID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

