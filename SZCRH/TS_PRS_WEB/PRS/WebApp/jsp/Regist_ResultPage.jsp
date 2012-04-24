<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/Header.inc" %>

<body>
<div class="smlWrap">
	
<div class="header2">
	<img src="${imgPath}/logo.jpg" alt="苏州川润海"/> 
	<div class="fr"> <a href="http://www.szcrh.com">苏州川润海</a>	
	</div>
</div>	 
		<div id="registerStep1Wrap" class="body">			 
            <img src="${imgPath}/Banner-regist.png" width="922" height="31" />
 
			<div class="regisTop" align="center">
				 
                
                
                <ul class="form">
					
                    <li>
						 <font size="+1"><h1><img align="absbottom" src="${imgPath}/symbol_check.png" width="85" height="85"></img>恭喜您，${user.name}，注册成功！</h1></font>
						 
	        </li>

					<li>
						 欢迎来到工友易联网,现在您可以去<a href="javascript:$.cookie('username','${user.name}', {expires: 1, path: '/'});window.location.href='/PRS/bus/Member_querySalary.action?userid=${user.id}';">工作台>></a> 查看相关的信息
						 
					</li>

					 
				</ul>
                 
				
			
				 
		</div> 
	 
	
<div class="footer">
	 <p>Copyright © 2012 天时软件工作室 版权所有</p>
</div>
</div>
 
</body>
</html>
