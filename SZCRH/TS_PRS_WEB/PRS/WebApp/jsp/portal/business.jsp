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
	<div id="side">
   		<div id="contentlist">
        	<h2>业务简介</h2>
        	 <p>暂时没有内容</p>
        </div> 
   
	</div>
    <div id="right">
    	 <div   id="login">
     <h2>工友易联网|登录</h2>
		  <div id="fourInOne">
		      
		      <form name="logonform" action="http://membercenter.cn.made-in-china.com/login/" method="post" id="logonform" target="_self">
		        <div class="sign" id="tabcontent_10">

		         <label>登录名：</label> <input tabindex="1" class="inputtext" type="text" maxlength="100" value="" id="logonUserName" name= "logonUserName" /><br/>
		         <label>密&nbsp;&nbsp;&nbsp;码：</label> <input tabindex="2" class="inputtext" type="password" id="password" name="logonPassword"/>
		              
		          <br />
		         <button tabindex="5" type="submit"><img src="${imgPath}/portal/but-login_cn.gif" alt="登录" /></button>
		         <input tabindex="6" type="checkbox" value="1" name="rememberLogUserNameFlag" />记住登录名<br/>
		         <a href="http://membercenter.cn.made-in-china.com/retrieve_user_name/" target="_self" >忘记登录名?</a>
		         <a target="_self" href="http://membercenter.cn.made-in-china.com/retrieve_password/">忘记密码?</a>
 
		        </div>
		         
		      </form>

		    </div>
		    
	</div>
    </div>	 
</div>
<div id="footer">
<%@ include file="/jsp/portal/util/Footer.inc" %>
</div>
<script type="text/javascript">
	$(document).ready(function() {
		$("#busi").attr("class","now");
		
	});
</script>

</body>
</html>