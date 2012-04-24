package com.tsoft.dao;

import java.util.List;
import java.util.Map;
 
import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.MembersInfo;

public class MembersDao extends JdbcDaoSupport{
	 

	public MembersInfo GetMemberInfo(MembersInfo membersInfo)  
	{
		 
		List<Map<String,Object>> result = (List<Map<String,Object>>)getJdbcTemplate().queryForList("select * from CM_Member m where m.cID =?",new Object[]{membersInfo.getId()});
		 
		
		if(result==null||result.size()==0)
		{
			return null;
		}
		
		Map<String,Object> detail = (Map<String,Object>)result.get(0);
		membersInfo.setCode(detail.get("cCode").toString());
		membersInfo.setName(detail.get("cName").toString());
		membersInfo.setId(detail.get("cID").toString());	
		return membersInfo;
	}
}
