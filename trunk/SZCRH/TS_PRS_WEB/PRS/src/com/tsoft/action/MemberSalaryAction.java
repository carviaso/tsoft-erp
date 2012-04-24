package com.tsoft.action;

import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MemberSalaryInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.service.MemberSalaryService;
import com.tsoft.service.MembersService;

public class MemberSalaryAction extends ActionSupport {
	private MembersService membersService;
	private MemberSalaryService memberSalaryService;
	private OperatorInfo operInfo; 

	public MemberSalaryService getMemberSalaryService() {
		return memberSalaryService;
	}

	public void setMemberSalaryService(MemberSalaryService memberSalaryService) {
		this.memberSalaryService = memberSalaryService;
	}

	public MembersService getMembersService() {
		return membersService;
	}

  


	public OperatorInfo getOperInfo() {
		return operInfo;
	}



	public void setOperInfo(OperatorInfo operInfo) {
		this.operInfo = operInfo;
	}



	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}

	public String toSalary()
	{
		try {
			  
			MembersInfo memInfo = new MembersInfo();
			memInfo.setId(operInfo.getId());
			memInfo = membersService.GetMemberInfo(memInfo);
			List<MemberSalaryInfo> memberSalary = memberSalaryService.getMemberSalary(memInfo);
			ServletActionContext.getRequest().setAttribute("operInfo",
					operInfo);
			ServletActionContext.getRequest().setAttribute("memInfo",memInfo);
			ServletActionContext.getRequest().setAttribute("memSalary",
					memberSalary);
			 
				return SUCCESS;
			 
		} catch (DataAccessException ex) {
			ResultInfo result = new ResultInfo();
			result.setMsgResult("��������쳣�������µ�¼������ϵ����Ա��");
			result.setActionUrl("loginForm.action");
			ServletActionContext.getRequest().setAttribute("resultInfo",
					result);
			return ERROR;
		}
	}
 
}
