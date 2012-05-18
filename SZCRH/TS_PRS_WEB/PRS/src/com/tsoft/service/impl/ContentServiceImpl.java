package com.tsoft.service.impl;

import java.util.List;

import org.springframework.dao.DataAccessException;

import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.dao.ContentDao;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.ContentService;

public class ContentServiceImpl implements ContentService {
	private ContentDao contentDao;

	public void setContentDao(ContentDao contentDao) {
		this.contentDao = contentDao;
	}

	@Override
	public void addContent(ContentInfo contInfo) throws DataAccessException,
			BusinessException {
		contentDao.addContent(contInfo);
		
	}

	@Override
	public void updateContent(ContentInfo contInfo)
			throws DataAccessException, BusinessException {
		contentDao.updateContent(contInfo);
		
	}

	@Override
	public void deleteContent(ContentInfo contInfo)
			throws DataAccessException, BusinessException {
		contentDao.deleteContent(contInfo);
		
	}

	@Override
	public List<ContentInfo> queryContentByCategory(CategoryInfo cateInfo,int num) throws BusinessException  {
		return contentDao.queryContentByCategory(cateInfo,num);
		
	}

	@Override
	public void queryContentInfo(ContentInfo contInfo)
			throws DataAccessException, BusinessException {
		contentDao.queryContentInfo(contInfo);
		
	}

	
	 

 
	
 
}
