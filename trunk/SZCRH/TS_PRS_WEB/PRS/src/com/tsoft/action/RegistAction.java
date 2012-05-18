package com.tsoft.action;

  
import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.json.annotations.JSON;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.CategoryInfo;
import com.tsoft.Info.ContentInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.ContentService;
import com.tsoft.service.MembersService;
import com.tsoft.service.OperatorService;

public class RegistAction extends ActionSupport{
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String username;
	private String userid;
	private String checkflag;
	private String name;
	

	private String password;
	private static final String REGIST_SUCCESS = "regist_success";
	private static final String ADMIN_SUCCESS = "admin_success";

	//是否成功的标志
	private String flag;	
	//页面提示信息
	private String msg;	
	private OperatorService operatorService; 
	private MembersService membersService;
	private ContentService contentService;
	
	/**
	 * @category校验用户是否存在
	 * @return
	 */
	public String userExists()
	{ 
		try
		{
			
			OperatorInfo operInfo = new OperatorInfo(); 
			operInfo.setUsername(username);
			validForOperName(operInfo); 
			flag = "true";
			operInfo = null;
			return SUCCESS;
		}
		catch (DataAccessException de)
		{
			
			flag = "false";
			msg = "服务器忙，请稍后再试。"; 
			return SUCCESS;
		}	
		catch(BusinessException be)
		{
			flag = "false";
			msg = be.getMessage();
			return SUCCESS;
		} 
		catch(Exception ae)
		{
			return ERROR;
		} 
		
	}	
	
	/**
	 * 用户信息验证
	 * @category
	 * 1、判断用户名是否存在
	 * 2、判断用户身份证是否存在
	 * 3、根据用户名或者身份证获取用户信息
	 * 4、如果没有用户信息，登录失败。
	 * @return
	 */
	public String userValidate()
	{
		try { 
			OperatorInfo operInfo = new OperatorInfo(); 
			if("username".equalsIgnoreCase(checkflag))
			{
				//如果输入的是用户名
				operInfo.setUsername(username);
			}
			else if("id".equalsIgnoreCase(checkflag))
			{
				operInfo.setId(userid);
			}
			operInfo.setPassword(password);
			if(operatorService.GetOperatorInfo(operInfo)==null)
			{
				throw new BusinessException("密码错误！");
			}
			else
			{
				this.userid = operInfo.getId(); 
				if("oper".equals(operInfo.getAuthor()))
				{
					
					MembersInfo mi  = new MembersInfo();
					mi.setId(operInfo.getId());
					mi= membersService.GetMemberInfo(mi);
					this.name = mi.getName();
					flag = "true";
					
				
				}
				else
				{
					this.name = "admin";
					flag = "adimn_true";					 
				}
				return SUCCESS;
			}
		} catch (DataAccessException de)
		{
			
			flag = "false";
			msg = "服务器忙，请稍后再试。"; 
			return SUCCESS;
		}	catch (BusinessException e) {
			flag = "false";
			msg = e.getMessage();
			return SUCCESS;
		}
		catch(Exception ae)
		{
			return ERROR;
		} 
	}
	
	public ContentService getContentService() {
		return contentService;
	}

	public void setContentService(ContentService contentService) {
		this.contentService = contentService;
	}

	/**
	 * 身份证校验
	 * 校验该身份证是否在川润海人力资源系统中注册过
	 * @return
	 */
	public String idRegist()
	{
		OperatorInfo operInfo = new OperatorInfo();
		operInfo.setId(userid);
		try {
			validForIdRegist(operInfo);
		} catch (BusinessException e) {
			flag = "false"; 
			msg = "该身份证未被注册过，请先联系川润海！";
		}
		return SUCCESS;
	}
	/**
	 * 身份证校验
	 * @return
	 */
	public String idExists()
	{
		try
		{			
			OperatorInfo operInfo = new OperatorInfo(); 
			operInfo.setId(userid);
			validForOperId(operInfo); 
			flag = "true";
			operInfo = null;
			return SUCCESS;
		}
		catch (DataAccessException de)
		{
			
			flag = "false";
			msg = "服务器忙，请稍后再试。"; 
			return SUCCESS;
		}	
		catch(BusinessException be)
		{
			flag = "false";
			msg = be.getMessage();
			return SUCCESS;
		} 
		catch(Exception ae)
		{
			return ERROR;
		}
	}
	
	/**
	 * 注册用户
	 * @return
	 */
	public String addOper()
	{
		try
		{
			OperatorInfo operInfo = new OperatorInfo();
			operInfo.setId(userid);
			operInfo.setPassword(password);
			operInfo.setUsername(username); 
			operatorService.AddOper(operInfo);
			MembersInfo mi  = new MembersInfo();
			mi.setId(operInfo.getId());
			mi= membersService.GetMemberInfo(mi);			
			ServletActionContext.getRequest().setAttribute("user",mi);
			return REGIST_SUCCESS;
		}
		catch(DataAccessException de)
		{
			return ERROR;
		}
		catch(BusinessException be)
		{
			flag = "false";
			msg = be.getMessage();
			return ERROR;
		} 
		catch(Exception ae)
		{
			return ERROR;
		}
	}
	
	private void validForIdRegist(OperatorInfo operInfo) throws BusinessException{
		MembersInfo mi  = new MembersInfo();
		mi.setId(operInfo.getId());
		mi= membersService.GetMemberInfo(mi);
		if(mi==null)
		{
			throw new BusinessException("该身份证未被注册过，请联系川润海！");			
		}
	}
	
	/**
	 * 校验用户名是否存在
	 * 存在返回false,不存在返回true
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validForOperName(OperatorInfo operInfo) throws BusinessException {
		if(!operatorService.CheckOperatorName(operInfo))
		{
			throw new BusinessException("用户名已存在！");
		}
	}
	
	/**
	 * 校验身份证是否存在
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validForOperId(OperatorInfo operInfo) throws BusinessException  {
		if(!operatorService.CheckOperatorId(operInfo))
		{
			throw new BusinessException("该身份证已经注册！");
		}
	}

	
	public String getUsername() {
		return username;
	}



	public void setUsername(String username) {
		this.username = username;
	}


	@JSON(serialize=false)
	public OperatorService getOperatorService() {
		return operatorService;
	}



	public void setOperatorService(OperatorService operatorService) {
		this.operatorService = operatorService;
	}

	@JSON(serialize=false)
	public MembersService getMembersService() {
		return membersService;
	}
	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}

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

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getUserid() {
		return userid;
	}

	public void setUserid(String userid) {
		this.userid = userid;
	}

	public String getCheckflag() {
		return checkflag;
	}

	public void setCheckflag(String checkflag) {
		this.checkflag = checkflag;
	}
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	} 

}
