package com.tsoft.dao;

import java.util.List;
import java.util.Map;

import org.springframework.dao.DataAccessException;
import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.OperatorInfo; 
import com.tsoft.exception.BusinessException;
import com.tsoft.util.InfoUtil;

public class OperatorDao extends JdbcDaoSupport {
 
	/**
	 * 新增操作员
	 * @param operInfo
	 * @throws DataAccessException
	 * @throws BusinessException
	 */
	public void AddOper(OperatorInfo operInfo) throws DataAccessException,BusinessException
	{
		Object [] params = new Object[]{operInfo.getPassword(),operInfo.getUsername(),operInfo.getId()};
		if(this.getJdbcTemplate().update("insert into PRS_Operator values(?,?,?)",params)<=0)
		{
			throw new BusinessException("数据库操作失败，请联系系统管理员！");
		}
			
		
	}
	
	/**
	 * 验证用户信息
	 * 通过两种方式验证用户信息，分别为用户名/身份证来验证
	 * @param operInfo
	 * @return
	 * @throws DataAccessException
	 * @throws BusinessException 
	 */
	public OperatorInfo GetOperatorInfo(OperatorInfo operInfo)  throws DataAccessException, BusinessException
	{
		String checkFlag = "username";
		
		Object[] params = new Object[2];
		if(operInfo.getId()!=null&&!operInfo.getId().isEmpty())
		{
			checkFlag = "id";
			params = new Object[]{operInfo.getId(),operInfo.getPassword()};
		}
		else
		{
			checkFlag = "username";
			params = new Object[]{operInfo.getUsername(),operInfo.getPassword()};
		}
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select * from PRS_Operator oper where oper."+checkFlag+" =? and oper.password= ?",params);
		if(result!=null&&result.size()==0)
		{
			return null;		
		}		
		else
		{
			Map<String,Object> detail = (Map<String,Object>)result.get(0);
			InfoUtil.mapResultToInfo(operInfo, detail);
			return operInfo;				
		}
	}
	
	/**
	 * 校验操作员用户名是否存在
	 * 存在返回false,不存在返回true
	 * @param operInfo
	 * @return
	 * @throws DataAccessException
	 */
	public Boolean CheckOperatorName(OperatorInfo operInfo) throws DataAccessException
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select 1 from PRS_Operator oper where oper.username =?",new Object[]{operInfo.getUsername()});
		if(result!=null&&result.size()!=0)
		{
			return false;		
		}		
		else
		{
			return true;				
		}
	}
	
	/**
	 * 操作员身份证是否存在
	 * @param operInfo
	 * @return
	 * @throws DataAccessException
	 */
	public Boolean CheckOperatorId(OperatorInfo operInfo) throws DataAccessException
	{
		List<Map<String,Object>> result = (List<Map<String,Object>>)this.getJdbcTemplate().queryForList("select 1 from PRS_Operator oper where oper.id =?",new Object[]{operInfo.getId()});
		if(result!=null&&result.size()!=0)
		{
			return false;		
		}		
		else
		{
			return true;				
		}
	}
 
}
