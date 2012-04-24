<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="Header.inc" %>
    <base href="<%=basePath%>"> 
    <title>会员注册</title>    
	 
<script lanuguage="javascript">
 
	function valiField()
	{  
	 	 
		var username = $("#username").val(); 
		var password = $("#password").val();
		var pwdconfirm = $("#pwdconfirm").val();
		var id = $("#id").val();
		if(null == username||""==username)
		{
			alert("用户名不能为空！");
			return false;
		}
		if(null == password||""==password)
		{
			alert("密码不能为空！");
			return false;	
		}
		if(null == pwdconfirm||""==pwdconfirm)
		{
			alert("密码确认不能为空！");
			return false;	
		}
		if(null == id||""==id)
		{
			alert("身份证不能为空！");
			return false;	
		}
		if(password!=pwdconfirm)
		{
			alert("两次密码输入不一致！");
			return false;
		}
	}
</script>
  </head>
  
 <body style="background-color:#FFF;margin:0">
 <div id="Container" align="center">
  	<div id="Header">
	<table height="50" width="100%">
    	<tr height="20">
        	<td >
        		
            </td>
        </tr>
        <tr height="30" align="right">
        	<td>
        	</td>
        	<td>        	
        		<div style="padding:25px;height:100%;background-image:url(img/title.png);background-repeat: no-repeat;">  
        		</div>
        	</td>
        	<td style="vertical-align:bottom">
        		<a href="loginForm.action"><font color="#FFFFFF">注销登录</font></a>
        	</td>
        </tr>
    </table>
</div>
    <div id="PageBody">    
    <table width="600" >
    	<tr>
    		<td height="5">
    		</td>
    	</tr>
    	<tr>
      		<td align="left"  colspan="2"><h1>会员注册</h1></td> 
      	</tr>
  		<tr style="background-image:url('img/line-hy.png'); " height="15">
  			<td>
    		</td> 
  		</tr>    
  </table> 
    	<form action="registion.action" method="get" onsubmit="return valiField();">
    	<table width="300" >
    		<tr>
    			<td height="20" width="80" align="right">
    			</td>
    			<td align="left">
    			</td>
    		</tr>
    		<tr>
    			<td width="80" align="right">
    				用户名：
    			</td>
    			<td  align="left">
    				<input id="username" type="text" name="username" style="width:100%"/>
    			</td>
    		</tr>
    		<tr>
    			<td width="80" align="right">
    				密码：
    			</td>
    			<td  align="left">
    				<input id="password" type="password" name="password" style="width:100%"/>
    			</td>
    		</tr>
    		<tr>
    			<td width="80" align="right">
    				确认密码：
    			</td>
    			<td align="left">
    				<input id="pwdconfirm" type="password" name="pwdconfirm" style="width:100%"/>
    			</td>
    		</tr>
    		<tr>
    			<td width="80" align="right">
    				身份证：
    			</td>
    			<td align="left">
    				<input id="id" type="text" name="id" style="width:100%"/>
    			</td>
    		</tr>
    		<tr>
    			<td width="80" align="right"> 
    			</td>
    			<td  >
    				<input type="submit" value="提交"/>
    				<input type="button" value="重置"/>
    			</td>
    		</tr>
    	</table>
    	</form>
    </div>
    <div id="Foot"> 
    <table width="600">
  	<tr style="background-image:url('img/line-hy.png'); " height="20">
  		<td>
    	</td> 
  	</tr>
    <tr>
      <td align="left">&copy;2011 TSoft</td>
      <td>&nbsp;</td>
      </tr>
  </table> 
</div>
    </div>
  </body>
</html>
