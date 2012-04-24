 <%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
 <%@ include file="Header.inc" %>
 <title>工友易联网</title>
  </head>
  <script language="javascript" type="text/javascript">           
  		function returnClick()
  		{
  			window.location.href="${resultInfo.actionUrl}"; 
  		} 
  </script>
  
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
    	 <tr height="20" align="right">
        	<td align="center">
        		<div id="ResultInfo">
					<s:property value="#request.resultInfo.msgResult"/>
        		</div>
        	</td>
        </tr>
        <tr>
        	<td align="center">
        		<input type="button" style="width:70;" value="返回" id="ok" onclick="returnClick();"/>
        	</td>
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
