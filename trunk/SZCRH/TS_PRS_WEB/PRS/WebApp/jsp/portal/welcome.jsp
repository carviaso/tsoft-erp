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
		<div class="box" id="notice">
		        <h2>站内公告</h2>
		        <div id="content">
                查询公告信息
                </div>
		</div>
          <div id="centerBanner">
			      <a  href="/search-keyword/GekmhNxUsriciqHmsdBMfrlL/madeinchina.html" target="_blank" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01ivhTOdjMLrlL/made-in-china.jpg" height="170" width="545" alt="LED 品牌采购专场" border="0" /></a><a  href="/search-keyword/ueVEyNxMCRloHblxfZNynYID/madeinchina.html" target="_blank" style="display: none;" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01hCltfANyEgVW/made-in-china.jpg" height="170" width="545" alt="塑料产业 一站式采购" border="0" /></a><a  href="/search-keyword/zqlmCycxHpiHOeHEIJuPJUic/madeinchina.html" target="_blank" style="display: none;" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01JehEVaIPazic/made-in-china.jpg" height="170" width="545" alt="麦通在线 沟通无限" border="0" /></a><ul id="adMenu3"><li class="now">LED 品牌采购专场</li><li>塑料产业 一站式采购</li><li class="lst">麦通在线 沟通无限</li></ul>
			    </div>
			     
          
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

	<div class="box" id="company">
		        <h2>推荐企业</h2>
		        <ul>
                	<li><img src="${imgPath}/portal/company/qisda_logo.jpg"></li>
                
                </ul>
		</div>
<div id="side">
     <div  class="box" id="business">
		        <h2>公司简介</h2>
		        <ul>
                	<li> 
                    <strong>苏州川润海劳务派遣有限公司</strong>，成立于2011年，是经苏州市劳动和社会保障局批准成立，在市工商行政管理局登记注册，是一家从事人事代理、劳务派遣的专业机构。有着优良的团队，丰富的经验以及一流的服务，本着用心做好每项服务的理念为客户及派遣员工提供专业、高效、便捷的服务。
                    </li>
                
                </ul>
		</div>
        <div>
        <div class="box"   id="new">
		        <h2>新闻中心</h2>
		        <ul>
                	<li> 
                    庆祝网站开通
                    </li>
                
                </ul>
		</div>
        
        <div class="box"   id="position">
		        <h2>热门职位</h2>
		        <ul>
                	<li> 
                    庆祝网站开通
                    </li>
                
                </ul>
		</div>
        </div>
        
</div>
</div>
<script type="text/javascript">
	$(document).ready(function() {
		$("#home").attr("class","now");
		
	});
</script>

</body>
</html>