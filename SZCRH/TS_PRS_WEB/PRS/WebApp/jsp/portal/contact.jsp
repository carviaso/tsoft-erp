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
        	<div id="left">
        	<div id="img">
        		<img src="${imgPath}/portal/contact.jpg">
        	</div>
        	<div id="contactinfo">
            <table  width="300px">
            <tr>
            	<td class="content">
            		<strong>苏州川润海劳务派遣有限公司</strong>
                </td>
            </tr>
            <tr>
            	<td class="content">
            		地　址：苏州市吴中区东吴南路388号吴中商城大厦1707室
                </td>
            </tr>
            <tr>
            	<td class="content">
            		电　话：0512-66593679
                </td>
            </tr>
			<tr>
            	<td class="content">
            		传　真：0512-66593679
                </td>
            </tr>   
            <tr>
            	<td class="content">
            		联系人：付小姐
                </td>
            </tr>  
            <tr>
            	<td class="content">
            		在线客服：<a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=2782502009&site=qq&menu=yes"><img border="0" src="http://wpa.qq.com/pa?p=2:2782502009:41" alt="点击这里给我发消息" title="点击这里给我发消息"></a>
                </td>
            </tr>        
            <tr>
                <td class="content">
                	<strong>全国服务热线：400-004-1889 </strong>
  
                </td>
            </tr>
            <tr>
                <td class="content">
            		<strong>业务咨询电话：18015565679 </strong>
                </td>
             </tr> 
              
           	</table>
           	</div>
           	</div>
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
		$("#cont").attr("class","now");
		
	});
</script>

</body>
</html>