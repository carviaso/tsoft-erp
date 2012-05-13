<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.setAttribute("cssPath",path+"/css");
request.setAttribute("jsPath",path+"/js");
request.setAttribute("imgPath",path+"/img");

%>
<%@taglib prefix="s" uri="/struts-tags" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head> 
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<link rel="stylesheet" type="text/css" href="${cssPath}/common.css"/>
	<link rel="stylesheet" type="text/css" href="${cssPath}/prs_portal.css"/>
	<script type="text/javascript" src="${jsPath}/PRS.js"></script>
	<script type="text/javascript" src="${jsPath}/jquery.js"></script>
	<script type="text/javascript" src="${jsPath}/jquery.cookie.js"></script>
<title>川润海•工友易联网</title>
</head>