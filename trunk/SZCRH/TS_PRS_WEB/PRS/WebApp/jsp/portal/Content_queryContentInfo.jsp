<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/jsp/portal/util/Import.inc" %>
 
<body>
<div id="top">
  <%@ include file="/jsp/portal/util/Toper.inc" %>
</div>
<div id="header">
   	<%@ include file="/jsp/portal/util/Header.inc" %>
</div>
<div id="main">
	  <div id="content">
		
		<div class="detail">
			<h1><strong><s:property value="#request.contentinfo.title"/></strong></h1>
			<div class="tag"> 
				<span>发布时间：<s:property value="#request.contentinfo.date"/></span>
				</div> 
				<div class="otherfunction">
				<div class="fr">   </div>
			</div>
			<div id="cont_text"> 
				
			</div>
		</div>
	</div>
	<div id="right">
		<div   id="login">
     <h2>工友易联网|登录</h2>
		  <div id="fourInOne">	      
		         
		        <div class="sign" id="tabcontent_10">

		         <label>登录名：</label> <input tabindex="1" class="inputtext" type="text" maxlength="100" value="" id="userinfo" name= "logonUserName" />
		         <span class="errorSml" id="notice_userinfo" ></span><br/>
		         <label>密&nbsp;&nbsp;&nbsp;码：</label> <input tabindex="2" class="inputtext" type="password" id="password" name="logonPassword"/>
		           <span class="errorSml" id="notice_password" ></span>   
		          <br />
		          <button tabindex="5" onclick ="javascript:PRS.login('#editForm')" ><img src="${imgPath}/portal/but-login_cn.gif" alt="登录" /></button> 
		         <input tabindex="6" type="checkbox" value="1" name="rememberLogUserNameFlag" />记住登录名<br/> 
 
		        </div>

		    </div>
		    
	</div>
	<div class="box" id="company">
		        <h2>推荐企业</h2>
		        <ul>
                	<li><img src="${imgPath}/portal/company/qisda_logo.jpg"></li>
                
                </ul>
		</div>
		<div class="box" id="service">
		        <h2>客服联系</h2>
		        <ul>
		        	<li>
		        		<table width="150px">
		        			<tr>
		        				<td><strong>全国服务热线：</br>400-004-1889</strong></td>
		        			</tr>
		        			<tr>
		        				<td><strong>业务咨询电话：</br>18015565679</strong></td>
		        			</tr>
		        			<tr>
		        				<td>会员推荐奖励咨询/注册咨询/入会咨询/工资咨询</td>
		        			</tr>
		        		</table>
		        		
		        	</li>
                	<li><a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=2782502009&site=qq&menu=yes"><img border="0" src="http://wpa.qq.com/pa?p=2:2782502009:41" alt="点击这里给我发消息" title="点击这里给我发消息"></a>
                	</li>
                
                </ul>
		</div>
	</div>
	
</div>
<div id="footer">
<%@ include file="/jsp/portal/util/Footer.inc" %>
</div>
<script type="text/javascript">

	$(document).ready(function() {
		
		$("#home").attr("class","now"); 
		$("#cont_text").html("${contentinfo.content}"); 
	});
	
</script>

</body>
</html>