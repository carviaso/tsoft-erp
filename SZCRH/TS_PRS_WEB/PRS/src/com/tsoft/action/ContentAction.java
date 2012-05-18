package com.tsoft.action;
 
import java.util.Calendar;
import java.util.Date;
import java.util.List;

import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.json.annotations.JSON;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.ContentService;

public class ContentAction extends ActionSupport{

	private ContentService contentService;
	private String contentType;
	private String title;
	private String code;
	private Object content;
	private String flag;
	
	public String delContent()
	{
		ContentInfo content = new ContentInfo();
		content.setCode(code);
		try {
			contentService.deleteContent(content);
			flag = "true";
		} catch (DataAccessException e) {
			msg = e.getMessage();
			flag = "false";
		} catch (BusinessException e) {
			msg = e.getMessage();
			flag = "false";
		}
		return SUCCESS;
	}

	public String addContent()
	{
		ContentInfo content = new ContentInfo();
		long now = System.currentTimeMillis(); // 排序前取得当前时间        
		Calendar c = Calendar.getInstance();       
		c.setTimeInMillis(now);       
		StringBuffer date = new StringBuffer();
		date.append(c.get(Calendar.YEAR)).append(c.get(Calendar.MONTH)).append(c.get(Calendar.DATE)).append(c.get(Calendar.HOUR_OF_DAY)).append(c.get(Calendar.MINUTE)).append(c.get(Calendar.SECOND)).append(c.get(Calendar.MILLISECOND));
		content.setCode(date.toString());
		content.setTitle(getTitle());
		content.setContent(getContent());
		content.setParent(getContentType());
		content.setDate(new Date());
		
		try {
			contentService.addContent(content);
			
			flag = "true";
		} catch (DataAccessException e) {
			msg = e.getMessage();
			flag = "false";
		} catch (BusinessException e) {
			msg = e.getMessage();
			flag = "false";
		}
		return SUCCESS;
	}
	
	
	public String queryContentInfo()
	{
		ContentInfo content = new ContentInfo();
		content.setCode(getCode());
		try {
			contentService.queryContentInfo(content);
			ServletActionContext.getRequest().setAttribute("contentinfo",content);
			
			
		} catch (DataAccessException e) {
			ServletActionContext.getRequest().setAttribute("errormsg","数据库操作失败，请联系管理员检查网络以及数据库情况！");
			return ERROR;
		} catch (BusinessException e) {
			ServletActionContext.getRequest().setAttribute("errormsg",e.getMessage());
			return ERROR;
		}
		return SUCCESS;
	}
	
	public String queryContent()
	{
		//001:News
		CategoryInfo cate = new CategoryInfo(getContentType());
		try {
			List<ContentInfo> result = contentService.queryContentByCategory(cate,99999);
			ServletActionContext.getRequest().setAttribute("contentList",result);
			String title = contentType.equals("001")?"公告中心":"新闻中心";
			ServletActionContext.getRequest().setAttribute("title",title);
		} catch (DataAccessException e) {
			return ERROR;
		} catch (BusinessException e) {
			return ERROR;
		}
		return SUCCESS;
	}
	
	public String getCode() {
		return code;
	}

	public void setCode(String code) {
		this.code = code;
	}

	
	//页面提示信息
	private String msg;	
	
	
	public String getFlag() {
		return flag;
	}

	public void setFlag(String flag) {
		this.flag = flag;
	}

	public String getMsg() {
		return msg;
	}

	public void setMsg(String msg) {
		this.msg = msg;
	}

	public String getContentType() {
		return contentType;
	}

	public void setContentType(String contentType) {
		this.contentType = contentType;
	}

	@JSON(serialize=false)
	public ContentService getContentService() {
		return contentService;
	}

	public void setContentService(ContentService contentService) {
		this.contentService = contentService;
	}

	
	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	 

	public Object getContent() {
		return content;
	}

	public void setContent(Object content) {
		this.content = content;
	}
	
	
}
