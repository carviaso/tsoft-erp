package com.tsoft.action;

import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.ContentService;

public class PortalAction extends ActionSupport{
	private ContentService contentService;
	
	public ContentService getContentService() {
		return contentService;
	}

	public void setContentService(ContentService contentService) {
		this.contentService = contentService;
	}

	public String welcome()
	{
		CategoryInfo cateInfo = new CategoryInfo("001");
		try {
			List<ContentInfo> noticeList = contentService.queryContentByCategory(cateInfo,8);
			cateInfo.setCode("002");
			List<ContentInfo> newList = contentService.queryContentByCategory(cateInfo,8);
			ServletActionContext.getRequest().setAttribute("noticeList",
					noticeList);
			ServletActionContext.getRequest().setAttribute("newList",newList);
		} catch (DataAccessException e) {
			return ERROR;
		} catch (BusinessException e) {
			return ERROR;
		}
		return SUCCESS;
	}
	
}
