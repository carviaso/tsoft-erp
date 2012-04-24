package com.tsoft.dao;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MemberSalaryInfo;
import com.tsoft.Info.MembersInfo;

public class MemberSalaryDao extends JdbcDaoSupport{

	public List<MemberSalaryInfo> getMemberSalary(MembersInfo mi)
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)getJdbcTemplate().queryForList("select ms.cGUID, CONVERT (varchar (100), msl.dDate, 23) dDate,ms.iAccidentInsure,ms.iAwaytimeSum,ms.iBaseSalary,ms.iBillSum, ms.iDayNum,ms.iDayNumDeptCurrMon, ms.iDayNumDeptLastMon, ms.iDayNumPersonCurrMon, ms.iDayNumPersonLastMon, ms.iDormBill, ms.iElectriBill, ms.iGasBill, ms.iMemberSalary,ms.iNighttimeAllowSum, ms.iOfftimeSum,ms.iOvertimeFeeSum,ms.iOvertimeSum_allow, ms.iOvertimeSum_festival,ms.iOvertimeSum_holiday,ms.iOvertimeSum_workday,ms.iOwetimeFeeSum,ms.iSalarySum,ms.iWaterBill,ms.iPrepay,ms.iRecomBill,ms.iCutManPay,ms.iCutCertifyPay,ms.iCutEduPay,ms.cSalaryRemark from MEM_MemberSalaryDetail ms inner join MEM_MemberSalaryList msl on ms.cHeadGUID = msl.cGUID where ms.cMemberId = ?",new Object[]{mi.getId()});
		List<MemberSalaryInfo> memSalaryDetail = new ArrayList<MemberSalaryInfo>();
		for(Map m:result)
		{
			
			MemberSalaryInfo mai = new MemberSalaryInfo();
			mai.setSalaryDate(m.get("dDate").toString());
			mai.setSalaryRemark(m.get("cSalaryRemark").toString());
			mai.setAccidentInsure(Double.valueOf(m.get("iAccidentInsure").toString()));
			mai.setAwaytimeSum(Double.valueOf(m.get("iAwaytimeSum").toString()));
			mai.setBaseSalary(Double.valueOf(m.get("iBaseSalary").toString()));
			mai.setBillSum(Double.valueOf(m.get("iBillSum").toString()));
			mai.setDayNum(Double.valueOf(m.get("iDayNum").toString()));
			mai.setDayNumDeptCurrMon(Double.valueOf(m.get("iDayNumDeptCurrMon").toString()));
			mai.setDayNumDeptLastMon(Double.valueOf(m.get("iDayNumDeptLastMon").toString()));
			mai.setDayNumPersonCurrMon(Double.valueOf(m.get("iDayNumPersonCurrMon").toString()));
			mai.setDayNumPersonLastMon(Double.valueOf(m.get("iDayNumPersonLastMon").toString()));
			mai.setDormBill(Double.valueOf(m.get("iDormBill").toString()));
			mai.setElectriBill(Double.valueOf(m.get("iElectriBill").toString()));
			mai.setGasBill(Double.valueOf(m.get("iGasBill").toString()));
			mai.setMemberSalary(Double.valueOf(m.get("iMemberSalary").toString()));
			mai.setNighttimeAllowSum(Double.valueOf(m.get("iNighttimeAllowSum").toString()));
			mai.setOfftimeSum(Double.valueOf(m.get("iOfftimeSum").toString()));
			mai.setOvertimeFeeSum(Double.valueOf(m.get("iOvertimeFeeSum").toString()));
			mai.setOvertimeSum_allow(Double.valueOf(m.get("iOvertimeSum_allow").toString()));
			mai.setOvertimeSum_festival(Double.valueOf(m.get("iOvertimeSum_festival").toString()));
			mai.setOvertimeSum_holiday(Double.valueOf(m.get("iOvertimeSum_holiday").toString()));
			mai.setOvertimeSum_workday(Double.valueOf(m.get("iOvertimeSum_workday").toString()));
			mai.setOwetimeFeeSum(Double.valueOf(m.get("iOwetimeFeeSum").toString()));
			mai.setSalarySum(Double.valueOf(m.get("iSalarySum").toString()));
			mai.setPrePay(Double.valueOf(m.get("iPrePay").toString()));
			mai.setRecomBill(Double.valueOf(m.get("iRecomBill").toString()));
			mai.setCutManPay(Double.valueOf(m.get("iCutManPay").toString()));
			mai.setCutCertifyPay(Double.valueOf(m.get("iCutCertifyPay").toString()));
			if(m.get("iCutEduPay")==null)
			{
				mai.setCutEduPay(0);
			}
			else				
			{
				mai.setCutEduPay(Double.valueOf(m.get("iCutEduPay").toString()));
			}
			mai.setWaterBill(Double.valueOf(m.get("iWaterBill").toString()));
			 
			memSalaryDetail.add(mai);
		}
		return memSalaryDetail;
		
		
	}
	
	
}
