package com.tsoft.dao;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MembersInfo;

public class MemberAllowDao extends JdbcDaoSupport{

	public List<MemberAllowInfo> getMemberAllow(MembersInfo mi)
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)getJdbcTemplate().queryForList("select md.cGUID,CONVERT(varchar(100), ml.dDate, 23) dDate,md.iMemberAllow,md.iRecNum,md.iTeamNum from MEM_MemberAllowDetail md inner join MEM_MemberAllowList ml on md.cHeadGUID = ml.cGUID where md.cMemberCode =?",new Object[]{mi.getCode()});
		List<MemberAllowInfo> memAllowDetail = new ArrayList<MemberAllowInfo>();
		for(Map m:result)
		{
			MemberAllowInfo mai = new MemberAllowInfo();
			mai.setAllowAmt(Double.valueOf(m.get("iMemberAllow").toString()));
			mai.setAllowDate(m.get("dDate").toString());
			mai.setRecNum(Integer.valueOf(m.get("iRecNum").toString()));
			mai.setTeamNum(Integer.valueOf(m.get("iTeamNum").toString()));
			memAllowDetail.add(mai);
		}
		return memAllowDetail;
		
		
	}
	
	
}
