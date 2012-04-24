<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/Header.inc" %>

<body class="bodyBg">
<div class="header">
	<h1><img style="margin-top:25px" align="absbottom" src="../img/title.png" alt="工友易联网"/></h1>
	<div class="headerLink"><a href="http://www.szcrh.com">苏州川润海</a></div>
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
        <h2>我的津贴</h2>
      </div>      
	  <div class="content">
		 <table class="tabForm" id="allowInfo">
		 	<tr>
		 		<th>津贴发放时间</th>
		    	<th class="c100">津贴金额</th>
                <th class="c100">推荐人数</th>
		    	<th class="c100">团队人数</th> 
		 	</tr>	
            <s:iterator value="#request.memAllow" id="rm">		          
		 	<tr>
		    	<td><s:property value="#rm.allowDate"/></td>
				<td><s:property value="#rm.allowAmt"/></td>
				<td><s:property value="#rm.recNum"/></td>
				<td><s:property value="#rm.teamNum"/></td>  
            </tr>
            </s:iterator>   
		 </table>
         
	  </div>   
    </div>
    
	<div class="colSide menuSide">
		<h3>服务中心</h3>
		<ul>
			<li id="service_salary"><a href="${path}/PRS/bus/Member_querySalary">我的工资</a></li>
			<li id="service_allow"><a href="${path}/PRS/bus/Member_queryAllow">我的津贴</a></li> 
			<li id="manager_operinfo"><a href="${path}/PRS/jsp/Error_ResultPage.jsp">个人信息维护</a></li>		
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
     $('#service_allow').attr('class','cur');
	 //senfe("表格名称","奇数行背景","偶数行背景","鼠标经过背景");
	 PRS.senfe("allowInfo","#f8fbfc","#e5f1f4","#ecfbd4");
});
 

</script>
</body>
</html>
