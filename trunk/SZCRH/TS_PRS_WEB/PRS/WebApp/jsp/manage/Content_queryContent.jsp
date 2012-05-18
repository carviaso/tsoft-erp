<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/jsp/util/Header.inc" %>

<body class="bodyBg">
<div class="header">
	<h1><img style="margin-top:25px" align="absbottom" src="../img/title.png" alt="工友易联网"/></h1>
	<div class="headerLink"><a href="/PRS/bus/portal_Portal_welcome">苏州川润海</a></div>
	<div id="welcomeInfo">欢迎<span id="username"></span>进入工作台 [<a href="javascript:PRS.logout()">安全退出</a>]</div>
</div>
<div class="topNav">
	<ul class="topNavLinks">
		<li class="" id="wp"><a class="siteLink">工作台</a></li>
	</ul>
	<div class="clr">&nbsp;</div>	 
</div> 
<div class="body"> 
  <div class="wrap">
    <div class="colMain">
      <div class="title">
        <h2 id="title"></h2>
        
      </div> 
      <div id="oper">
        	<input id="add" type="button" value="新增公告" width="150px" onclick="addContent();"></input>
        </div>     
	  <div class="content">
		 <table class="tabForm" id="allowInfo">
		 	<tr>
		 		<th>公告标题</th>
		    	<th class="c100">创建时间</th>
                <th class="c100">修改公告</th>
		    	<th class="c100">删除公告</th> 
		 	</tr>	
            <s:iterator value="#request.contentList" id="rm">		          
		 	<tr>
		 		<td><s:property value="#rm.title"/></td>  
		    	<td><s:property value="#rm.date"/></td> 
		    	<td><a href="/">修改</a></td>
		    	<td><a href="javascript:PRS.deleteContent(${rm.code});">删除</a></td>
            </tr>
            </s:iterator>   
		 </table>
         
	  </div>   
    </div>
    
	<div class="colSide menuSide">
		<h3>服务中心</h3>
		<ul>
			<li id="service_notice"><a href="/PRS/bus/manage_Content_queryContent?contentType=001">公告管理</a></li>
			<li id="service_news"><a href="/PRS/bus/manage_Content_queryContent?contentType=002">新闻管理</a></li> 
			<li id="manager_meminfo"><a href="/PRS/jsp/Error_ResultPage.jsp">会员管理</a></li>		
		</ul>
		<div class="cloSideShadow">&nbsp;</div>
	</div>
  </div>
</div>
<div class="bodyBtmShadow">&nbsp;</div>
<script type="text/javascript">
$(document).ready(function(){  
 if($.cookie('username'))
 {
 	$("#username").html($.cookie('username'));
 }
 else
 {
 	 window.location.href="/PRS/jsp/LoginPage.jsp";
 }
     
     var type = ${contentType};
     
     if(type===1)
     {
     	$("#title").html("公告管理");
     	$('#add').val('添加公告');
     	$('#service_notice').attr('class','cur');
     }
     else{
     	$("#title").html("新闻管理");
     	$('#add').val('添加新闻');
     	$('#service_news').attr('class','cur');
     }
	 //senfe("表格名称","奇数行背景","偶数行背景","鼠标经过背景");
	 PRS.senfe("allowInfo","#f8fbfc","#e5f1f4","#ecfbd4");
});
 
function addContent(){
	var type = ${contentType};
	 if(type===1)
     {
     	window.location.href="/PRS/sys/manage_Content_addNotice?contentType=001";
     }
     else{
     	window.location.href="/PRS/sys/manage_Content_addNew?contentType=002";
     }
}
</script>
</body>
</html>
