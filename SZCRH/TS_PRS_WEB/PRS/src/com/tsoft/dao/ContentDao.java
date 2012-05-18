package com.tsoft.dao;
 

import java.lang.reflect.InvocationTargetException;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import org.springframework.dao.DataAccessException;
import org.springframework.jdbc.core.support.JdbcDaoSupport;

import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.util.InfoUtil;

public class ContentDao extends JdbcDaoSupport{
	private final static String EXCEP_BUSI = "数据库操作失败，请联系系统管理员！";
	/**
	 * 新增操作员
	 * @param operInfo
	 * @throws DataAccessException
	 * @throws BusinessException
	 */
	public void addContent(ContentInfo contInfo) throws DataAccessException,BusinessException
	{
		String content = "";
		if(((String[])contInfo.getContent()).length>0)
		{
			content = ((String[])contInfo.getContent())[0];
		}
		System.out.println(content.toString());
		Object [] params = new Object[]{contInfo.getCode(),contInfo.getTitle(),contInfo.getParent(),content,contInfo.getDate()};
		if(this.getJdbcTemplate().update("insert into WEB_Content values(?,?,?,?,?)",params)<=0)
		{
			throw new BusinessException(EXCEP_BUSI);
		}
			
	}
	
	/**
	 * 修改栏目信息
	 * @param cateInfo
	 * @throws DataAccessException
	 * @throws BusinessException
	 */
	public void updateContent(ContentInfo contInfo) throws DataAccessException,BusinessException
	{
		Object [] params = new Object[]{contInfo.getCode(),contInfo.getDate(),contInfo.getTitle(),contInfo.getContent()};
		if(this.getJdbcTemplate().update("update WEB_Content set code=?,date=?,title=?,content=?", params)<=0)
		{
			throw new BusinessException(EXCEP_BUSI);
		}
	}
	
	/**
	 * 删除栏目信息
	 * @param cateInfo
	 * @throws DataAccessException
	 * @throws BusinessException
	 */
	public void deleteContent(ContentInfo contInfo) throws DataAccessException,BusinessException
	{
		Object[] params = new Object[] {contInfo.getCode()};
		if(this.getJdbcTemplate().update("delete from WEB_Content where code=?",params)<=0)
		{
			throw new BusinessException(EXCEP_BUSI);
		}
	}
	
	/**
	 * 根据code查询内容的信息
	 * @param contInfo
	 * @return
	 * @throws BusinessException 
	 */
	public void queryContentInfo(ContentInfo contInfo) throws BusinessException
	{
		Object[] params = new Object[]{contInfo.getCode()};
		List<Map<String,Object>> result =  getJdbcTemplate().queryForList("select  c.code,c.title,CONVERT(varchar(100), c.date, 23) date,c.content from WEB_Content c where c.code=?",params);
		if(result==null||result.size()==0)
		{
			throw new BusinessException("该记录不存在");
		}
		else
		{
			Map<String,Object> info =  result.get(0);
			InfoUtil.mapResultToInfo(contInfo, info);
		}
	}
	
	/**
	 * 根据栏目查询内容，返回内容标题的列表
	 * @param cateInfo
	 * @return
	 * @throws InvocationTargetException 
	 * @throws IllegalArgumentException 
	 * @throws IllegalAccessException 
	 */
	public List<ContentInfo> queryContentByCategory(CategoryInfo cateInfo,int num) throws BusinessException
	{
		Object[] params = new Object[]{cateInfo.getCode()};
		List<ContentInfo> result = new ArrayList<ContentInfo>();
		List<Map<String,Object>> dbresult = this.getJdbcTemplate().queryForList("select top "+num+" c.code,c.title,CONVERT(varchar(100), c.date, 23) date,c.content from WEB_Content c where c.parent =?",params);
		try {
		for(Map<String,Object> m:dbresult)
		{
			ContentInfo content = new ContentInfo();
			
				InfoUtil.mapResultToInfo(content, m);
			
			result.add(content);
		}
		} catch (Exception e) {			
			throw new BusinessException(e.getMessage());
		}  
		return result;
	}
	 
}
