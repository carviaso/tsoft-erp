package com.tsoft.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse; 

public class SecurityFilter implements Filter {
public void doFilter(ServletRequest request,
        ServletResponse response,
        FilterChain chain)
        throws IOException, ServletException {
  
    HttpServletRequest req = (HttpServletRequest) request;
    HttpServletResponse res = (HttpServletResponse) response; 
    res.sendRedirect("../jsp/Error_ResultPage.html");
     
}

@Override
public void destroy() {
	// TODO Auto-generated method stub
	
}

@Override
public void init(FilterConfig arg0) throws ServletException {
	// TODO Auto-generated method stub
	
}
}

