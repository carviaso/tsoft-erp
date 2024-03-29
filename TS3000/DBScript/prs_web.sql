-- SQL Manager 2008 for SQL Server 3.3.0.1
-- ---------------------------------------
-- Host      : mssql1.netjsp.com
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
  [dRecommendDate] datetime NULL,
  [cParent] varchar(18) COLLATE Chinese_PRC_CI_AS NULL
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
-- Definition for table MEM_MemberSalaryDetail : 
--

CREATE TABLE [dbo].[MEM_MemberSalaryDetail] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cHeadGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cMemberCode] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cMemberName] varchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [cMemberId] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [iDayNumPersonCurrMon] decimal(9, 2) NULL,
  [iDayNumDeptCurrMon] decimal(9, 2) NULL,
  [iDayNumPersonLastMon] decimal(9, 2) NULL,
  [iDayNumDeptLastMon] decimal(9, 2) NULL,
  [iOvertimeSum_workday] decimal(9, 2) NULL,
  [iOvertimeSum_holiday] decimal(9, 2) NULL,
  [iOvertimeSum_festival] decimal(9, 2) NULL,
  [iOvertimeSum_allow] decimal(9, 2) NULL,
  [iOwetimeSum] decimal(9, 2) NULL,
  [iAwaytimeSum] decimal(9, 2) NULL,
  [iOfftimeSum] decimal(9, 2) NULL,
  [iBaseSalary] decimal(9, 2) NULL,
  [iOvertimeFeeSum] decimal(9, 2) NULL,
  [iNighttimeAllowSum] decimal(9, 2) NULL,
  [iOwetimeFeeSum] decimal(9, 2) NULL,
  [iSalarySum] decimal(9, 2) NULL,
  [iDayNum] decimal(9, 2) NULL,
  [iElectriBill] decimal(9, 2) NULL,
  [iWaterBill] decimal(9, 2) NULL,
  [iGasBill] decimal(9, 2) NULL,
  [iAccidentInsure] decimal(9, 2) NULL,
  [iDormBill] decimal(9, 2) NULL,
  [iBillSum] decimal(9, 2) NULL,
  [iPrePay] decimal(9, 2) NULL,
  [iRecomBill] decimal(9, 2) NULL,
  [iCutManPay] decimal(9, 2) NULL,
  [iCutCertifyPay] decimal(9, 2) NULL,
  [iCutEduPay] decimal(9, 2) NULL,
  [iMemberSalary] decimal(9, 2) NULL,
  [cSalaryRemark] nvarchar(255) COLLATE Chinese_PRC_CI_AS NULL
)
ON [PRIMARY]
GO

EXEC sp_addextendedproperty 'MS_Description', N'cGUID 唯一标识', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'cGUID'
GO

EXEC sp_addextendedproperty 'MS_Description', N'身份证', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'cMemberId'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月个人工作天数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDayNumPersonCurrMon'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月部门工作天数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDayNumDeptCurrMon'
GO

EXEC sp_addextendedproperty 'MS_Description', N'上月个人工作天数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDayNumPersonLastMon'
GO

EXEC sp_addextendedproperty 'MS_Description', N'上月部门工作天数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDayNumDeptLastMon'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月平时加班时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOvertimeSum_workday'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月假日加班时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOvertimeSum_holiday'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月节日加班时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOvertimeSum_festival'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月夜班津贴时数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOvertimeSum_allow'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月欠班时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOwetimeSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月旷职时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iAwaytimeSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'本月请假时数合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOfftimeSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'基本工资', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iBaseSalary'
GO

EXEC sp_addextendedproperty 'MS_Description', N'加班费合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOvertimeFeeSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'夜班津贴合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iNighttimeAllowSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'缺勤扣款合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iOwetimeFeeSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'应领合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iSalarySum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'计费天数', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDayNum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'电费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iElectriBill'
GO

EXEC sp_addextendedproperty 'MS_Description', N'水费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iWaterBill'
GO

EXEC sp_addextendedproperty 'MS_Description', N'燃气费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iGasBill'
GO

EXEC sp_addextendedproperty 'MS_Description', N'意外险', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iAccidentInsure'
GO

EXEC sp_addextendedproperty 'MS_Description', N'宿舍费用', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iDormBill'
GO

EXEC sp_addextendedproperty 'MS_Description', N'费用合计', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iBillSum'
GO

EXEC sp_addextendedproperty 'MS_Description', N'预支工资', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iPrePay'
GO

EXEC sp_addextendedproperty 'MS_Description', N'推荐费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iRecomBill'
GO

EXEC sp_addextendedproperty 'MS_Description', N'扣管理费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iCutManPay'
GO

EXEC sp_addextendedproperty 'MS_Description', N'扣办证费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iCutCertifyPay'
GO

EXEC sp_addextendedproperty 'MS_Description', N'扣大专费', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iCutEduPay'
GO

EXEC sp_addextendedproperty 'MS_Description', N'应领工资', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'iMemberSalary'
GO

EXEC sp_addextendedproperty 'MS_Description', N'备注', 'schema', 'dbo', 'table', 'MEM_MemberSalaryDetail', 'column', 'cSalaryRemark'
GO

--
-- Definition for table MEM_MemberSalaryList : 
--

CREATE TABLE [dbo].[MEM_MemberSalaryList] (
  [cGUID] varchar(18) COLLATE Chinese_PRC_CI_AS NULL,
  [cCode] varchar(20) COLLATE Chinese_PRC_CI_AS NULL,
  [dDate] datetime NULL,
  [iMemberNum] int NULL,
  [iMemberSalarySum] decimal(9, 2) NULL,
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

