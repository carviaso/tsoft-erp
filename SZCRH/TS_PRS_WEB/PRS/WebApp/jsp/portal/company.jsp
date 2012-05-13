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
        	<h2>公司简介</h2>
            <table class="mendian_con" width="500px">
            <tr>
            	<td class="content">
            		<strong>苏州川润海劳务派遣有限公司</strong>，成立于2011年，是经苏州市劳动和社会保障局批准成立，在市工商行政管理局登记注册，是一家从事人事代理、劳务派遣的专业机构。有着优良的团队，丰富的经验以及一流的服务，本着用心做好每项服务的理念为客户及派遣员工提供专业、高效、便捷的服务。
                </td>
             </tr>
             <tr>
             	<td>
                	<img src="${imgPath}/portal/2011092223594132.jpg">
                </td>
             </tr> 
           	</table>
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
<script type="text/javascript">
	$(document).ready(function() {
		$("#comp").attr("class","now");
		
	});
</script>

</body>
</html>