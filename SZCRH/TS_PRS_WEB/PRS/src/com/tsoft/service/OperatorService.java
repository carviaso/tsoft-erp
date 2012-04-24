package com.tsoft.service;

import org.springframework.dao.DataAccessException;

import com.tsoft.Info.OperatorInfo;
import com.tsoft.exception.BusinessException;


public interface OperatorService {
	
	public void AddOper(OperatorInfo operInfo) throws DataAccessException,BusinessException;
	
	public OperatorInfo GetOperatorInfo(OperatorInfo operInfo);
	
	public Boolean CheckOperatorName(OperatorInfo operInfo);
	
	public Boolean CheckOperatorId(OperatorInfo operInfo);
}
