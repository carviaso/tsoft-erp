package com.tsoft.service.impl;

import org.springframework.dao.DataAccessException;

import com.tsoft.Info.OperatorInfo;
import com.tsoft.dao.OperatorDao;
import com.tsoft.exception.BusinessException;
import com.tsoft.service.OperatorService;

public class OperatorServiceImpl implements OperatorService {
	private OperatorDao operatorDao;

 
	@Override
	public OperatorInfo GetOperatorInfo(OperatorInfo operInfo) {
		return operatorDao.GetOperatorInfo(operInfo);
	}


	public OperatorDao getOperatorDao() {
		return operatorDao;
	}


	public void setOperatorDao(OperatorDao operatorDao) {
		this.operatorDao = operatorDao;
	}


	@Override
	public void AddOper(OperatorInfo operInfo) throws DataAccessException,BusinessException {
		this.operatorDao.AddOper(operInfo);
		
	}


	@Override
	public Boolean CheckOperatorName(OperatorInfo operInfo) {
		return operatorDao.CheckOperatorName(operInfo);
	}


	@Override
	public Boolean CheckOperatorId(OperatorInfo operInfo) {
		return operatorDao.CheckOperatorId(operInfo);
	}

 
	
 
}
