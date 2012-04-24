package com.tsoft.action;

import org.apache.struts2.ServletActionContext;
import org.springframework.dao.DataAccessException;

import com.opensymphony.xwork2.ActionSupport;
import com.tsoft.Info.MembersInfo;
import com.tsoft.Info.OperatorInfo;
import com.tsoft.Info.ResultInfo;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.MembersService;
import com.tsoft.service.OperatorService;

public class RegistionAction extends ActionSupport{

	private String username;
	private String password;
	private String id;
	private OperatorService operatorService;
	private MembersService membersService;
	
	public OperatorService getOperatorService() {
		return operatorService;
	}
	public void setOperatorService(OperatorService operatorService) {
		this.operatorService = operatorService;
	}
	public MembersService getMembersService() {
		return membersService;
	}
	public void setMembersService(MembersService membersService) {
		this.membersService = membersService;
	}
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	
	public String memReg()
	{
		ResultInfo result = null;
		try
		{
			
			OperatorInfo operInfo = new OperatorInfo();
			operInfo.setId(id);
			operInfo.setPassword(password);
			operInfo.setUsername(username);
			validation(operInfo);
			operatorService.AddOper(operInfo);
			result = new ResultInfo();
			result.setActionUrl("loginForm.action");
			result.setMsgResult("ע��ɹ����뷵�ص�¼ϵͳ!");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return SUCCESS;
		}
		catch (DataAccessException ex)
		{
			result= new ResultInfo();
			result.setMsgResult("��������쳣������ϵ����Ա��");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return ERROR;
		}	
		catch(BusinessException ex)
		{
			result = new ResultInfo();
			result.setMsgResult(ex.getMessage());
			result.setActionUrl("javascript:history.go(-1)");
			ServletActionContext.getRequest().setAttribute("resultInfo",result);
			return ERROR;
		}
	}
	
	/**
	 * ���У��
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validation(OperatorInfo operInfo) throws BusinessException {
		validForOperName(operInfo);
		validForOperId(operInfo);
		validForOperIdReg(operInfo);
	}
	
	/**
	 * У�����֤�Ƿ�ע��
	 * @param result
	 * @param operInfo
	 * @throws BusinessException
	 */
	private void validForOperId(OperatorInfo operInfo) throws BusinessException  {
		MembersInfo mi  = new MembersInfo();
		mi.setId(operInfo.getId());
		mi= membersService.GetMemberInfo(mi);
		if(mi==null)
		{
			throw new BusinessException("������֤��û����ϵͳ�Ǽǹ�����ϵ����Ա��");			
		}
	}
	
	private void validForOperName(OperatorInfo operInfo) throws BusinessException {
		if(!operatorService.CheckOperatorName(operInfo))
		{
			throw new BusinessException("���û����Ѿ���ע�ᣡ");
		}
	}
	
	private void validForOperIdReg(OperatorInfo operInfo) throws BusinessException {
		if(!operatorService.CheckOperatorId(operInfo))
		{
			throw new BusinessException("�����֤�Ѿ���ע�ᣡ");
		}
	}
}
