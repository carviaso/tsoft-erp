package com.tsoft.exception;

public class BusinessException extends Exception {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public BusinessException()
	{
		super();
	}
	
	public BusinessException(String msg)
	{
		super(msg);
	}

}
