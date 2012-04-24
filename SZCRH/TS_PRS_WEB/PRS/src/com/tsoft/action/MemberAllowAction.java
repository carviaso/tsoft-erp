package com.tsoft.action;

import java.util.List;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.service.MemberAllowService; 
import com.tsoft.service.MembersService;

public class MemberAllowAction extends ActionSupport {
	private MembersService membersService;
	private MemberAllowService memberAllowService;
	private OperatorInfo operInfo;

	public String toAllow() {

		try {

			MembersInfo memInfo = new MembersInfo();
			memInfo.setId(operInfo.getId());
			memInfo = membersService.GetMemberInfo(memInfo);
			List<MemberAllowInfo> memberAllow = memberAllowService
					.getMemberAllow(memInfo);
			ServletActionContext.getRequest()
					.setAttribute("operInfo", operInfo);
			ServletActionContext.getRequest().setAttribute("memInfo", memInfo);
			ServletActionContext.getRequest().setAttribute("memAllow",
					memberAllow);

			return SUCCESS;

		} catch (DataAccessException ex) {
			ResultInfo result = new ResultInfo();
			result.setMsgResult("��������쳣�������µ�¼������ϵ����Ա��");
			result.setActionUrl("loginForm.action");
			ServletActionContext.getRequest()
					.setAttribute("resultInfo", result);
			return ERROR;
		}
	}

	public MembersService getMembersService() {
		return membersService;
	}

	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}

	 

	public MemberAllowService getMemberAllowService() {
		return memberAllowService;
	}

	public void setMemberAllowService(MemberAllowService memberAllowService) {
		this.memberAllowService = memberAllowService;
	}

	public OperatorInfo getOperInfo() {
		return operInfo;
	}

	public void setOperInfo(OperatorInfo operInfo) {
		this.operInfo = operInfo;
	}

}
