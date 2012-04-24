package com.tsoft.action;

import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MemberSalaryInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.service.MemberAllowService;
import com.tsoft.service.MemberSalaryService;
import com.tsoft.service.MembersService;

public class MemberAction extends ActionSupport {

	private MembersService membersService;
	private MemberAllowService memberAllowService;
	private MemberSalaryService memberSalaryService;	 
	private String userid;
	public String getUserid() {
		return userid;
	}

	public void setUserid(String userid) {
		this.userid = userid;
	}

	/**
	 * 查询当前登录人的津贴信息
	 * @return
	 */
	public String queryAllow()
	{
		try {

			MembersInfo memInfo = new MembersInfo();
			memInfo.setId(userid);
			memInfo = membersService.GetMemberInfo(memInfo);
			List<MemberAllowInfo> memberAllow = memberAllowService
					.getMemberAllow(memInfo);  
			ServletActionContext.getRequest().setAttribute("memAllow",
					memberAllow);

			return SUCCESS;

		} catch (DataAccessException ex) {
			ResultInfo result = new ResultInfo();
			result.setMsgResult("服务器出现异常，请重新登录！");
			result.setActionUrl("loginForm.action");
			ServletActionContext.getRequest()
					.setAttribute("resultInfo", result);
			return ERROR;
		} 
		catch(Exception ae)
		{
			return ERROR;
		} 
	}
	
	/**
	 * 查询当前登录人的工资信息
	 * @return
	 */
	public String querySalary()
	{
		try {
			  
			MembersInfo memInfo = new MembersInfo();
			memInfo.setId(userid);
			memInfo = membersService.GetMemberInfo(memInfo);
			List<MemberSalaryInfo> memberSalary = memberSalaryService.getMemberSalary(memInfo);			  
			ServletActionContext.getRequest().setAttribute("memSalary",
					memberSalary);			 
				return SUCCESS;
			 
		} catch (DataAccessException ex) {
			ResultInfo result = new ResultInfo();
			result.setMsgResult("服务器出现异常，请重新登录！");
			result.setActionUrl("loginForm.action");
			ServletActionContext.getRequest().setAttribute("resultInfo",
					result);
			return ERROR;
		} 
		catch(Exception ae)
		{
			return ERROR;
		} 
		
	}
	
	public MembersService getMembersService() {
		return membersService;
	}

	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}
	
	public MemberSalaryService getMemberSalaryService() {
		return memberSalaryService;
	}

	public void setMemberSalaryService(MemberSalaryService memberSalaryService) {
		this.memberSalaryService = memberSalaryService;
	}


	public MemberAllowService getMemberAllowService() {
		return memberAllowService;
	}

	public void setMemberAllowService(MemberAllowService memberAllowService) {
		this.memberAllowService = memberAllowService;
	}

	 
}
