<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/jsp/manage/util/Import.inc" %>
 

<body class="bodyBg">
<div class="header">
	<h1><img style="margin-top:25px" align="absbottom" src="${imgPath}/title.png" alt="工友易联网"/></h1>
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
        <h2 id="title1"></h2>
      </div>      
     
	  <div class="content">
		 <div id="categoryinfo">
		  <form id="categoryForm" action="">
		 	<ul class="form">
		 		<li>
						<label width="100px"><span class="red">*</span>&nbsp;内容标题：</label>
						 
						<div class="formContent">
							<input id="title" name="title" class="textLong" />
						</div>
				</li> 
				<li>
						<label><span class="red">*</span>&nbsp;内容：</label>
						<div class="formContent">
							<textarea class="ckeditor" cols="80" id="content" name="content" rows="10"></textarea>
						</div>
				</li>
				<li>
						<label>&nbsp;</label>			
						<a class="btnOk" href="javascript:var c = CKEDITOR.instances.content.getData();PRS.addContent(c);"><span>保存</span></a> <span class="errorSml" id="notice_submit" ></span>
					</li>
		 	</ul>
		 	</form> 
		 </div>
         
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
 	 /*window.location.href="/PRS/jsp/LoginPage.jsp";*/
 }
 var type = ${contentType};
     alert(type);
     if(type===1)
     {
     	$("#title1").html("添加公告"); 
     	$('#service_notice').attr('class','cur');
     }
     else{
     	$("#title1").html("添加新闻"); 
     	$('#service_news').attr('class','cur');
     } 
     $('.errorSml').hide();
	     $('.checkSml').hide();
	 //senfe("表格名称","奇数行背景","偶数行背景","鼠标经过背景");
	 //PRS.senfe("allowInfo","#f8fbfc","#e5f1f4","#ecfbd4");
	  
});


</script>
</body>
</html>
