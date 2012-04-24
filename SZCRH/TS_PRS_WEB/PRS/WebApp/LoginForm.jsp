<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="Header.inc" %>
<title>工友易联网</title>
<script lanuguage="javascript">
 
	function valiField()
	{  
	 	 
		var username = $("input#username").val(); 
		var password = $("input#password").val();
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
	}
</script>
</head> 


<body>

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
  <table width="556" height ="400">
    <tr>
      <th height="185" width="50%" scope="col">
      	<table width="100%" height="300">
  			<tr>
   			  <th height="50" align="left"><h1>工友易联网</h1></th>
    		</tr>
  			<tr>
    			<td>&nbsp;</td>
  			</tr>
  			<tr>
  			  <td height="54"><a href="regForm.action">注册用户</a></td>
		  </tr>
  		</table>
	  </th>
      <th width="50">
      <table width="20" height="300">
      	<tr>
        	<td width="50" height="100%" style="background-image:url('img/line-vo.png')">
            </td>
        </tr>
      </table>
      </th>
      <th height="185" scope="col" width="50%">
      <table width="100%" height="300">
        <tr>
          <th height="50" align="left"><h1>登录</h1></th>
          </tr>
        <tr>
          <td >
          	<form action="login.action" method="post" onsubmit = "return valiField();">
   					<table width="100%" height="100%">
   				 
   						<tr>
   						  <td align="left">用户名：</td>
					  </tr>
   						<tr>
   							<td width="72" height="27" align="left">
                            	<input id="username" type="text" name="username" style="width:100%"/>
                            </td>
						</tr>
                        <tr>
                        	<td height="20">
                            </td>
                        </tr>
   						<tr>
   							<td width="72" align="left">
   								密码：
   							</td>
						</tr>
   						<tr>
   						  <td height="26" align="left">
                          	<input id="password" type="password" name="password" style="width:100%"/></td>
					  </tr>
   						<tr>
   							<td height="50" align="left"><input type="submit" value="登录" width="60"/></td>
						</tr>
   					</table> 
   				</form> 
          </td>
        </tr>
      </table></th>
    </tr>
  </table>
	 
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
