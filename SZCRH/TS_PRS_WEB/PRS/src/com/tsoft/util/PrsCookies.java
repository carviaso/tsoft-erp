package com.tsoft.util;

import javax.servlet.http.Cookie;

import com.tsoft.Info.OperatorInfo;

public class PrsCookies {
	
	public static Cookie registOper(String username)
	{
		Cookie userCookie = new Cookie("user",username);
		 

		userCookie.setMaxAge(3600);
		userCookie.setPath("/");
		return userCookie;
	}
}
