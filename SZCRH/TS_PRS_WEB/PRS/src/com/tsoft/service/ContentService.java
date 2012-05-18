package com.tsoft.service;

import java.util.List;

import org.springframework.dao.DataAccessException;

import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.exception.BusinessException;


public interface ContentService {
	
	public void addContent(ContentInfo contInfo) throws DataAccessException,BusinessException;
	
	public void updateContent(ContentInfo contInfo) throws DataAccessException,BusinessException;
	
	public void deleteContent(ContentInfo contInfo) throws DataAccessException,BusinessException;
	
	public void queryContentInfo(ContentInfo contInfo) throws DataAccessException,BusinessException;
	
	public List<ContentInfo> queryContentByCategory(CategoryInfo cateInfo,int num) throws DataAccessException,BusinessException;
	 
}
