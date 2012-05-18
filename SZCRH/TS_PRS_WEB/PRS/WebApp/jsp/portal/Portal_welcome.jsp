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
		        <h2><a href="/PRS/bus/portal_Content_queryContent?contentType=001">站内公告</a></h2>
		        <div id="content">
                	<table>
                		<s:iterator value="#request.noticeList" id="rm">		          
		 					<tr>
		 						<td class="c10"><img src="${imgPath}/portal/control_right.png"></td>  
		    					<td class="c100""><a href="/PRS/bus/portal_Content_queryContentInfo?code=${rm.code}"> <s:property value="#rm.title"/></a></td>  
            				</tr>
            			</s:iterator>   
                	</table>
                </div>
		</div>
          <div id="centerBanner">
			      <a  href="/search-keyword/GekmhNxUsriciqHmsdBMfrlL/madeinchina.html" target="_blank" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01ivhTOdjMLrlL/made-in-china.jpg" height="170" width="545" alt="LED 品牌采购专场" border="0" /></a><a  href="/search-keyword/ueVEyNxMCRloHblxfZNynYID/madeinchina.html" target="_blank" style="display: none;" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01hCltfANyEgVW/made-in-china.jpg" height="170" width="545" alt="塑料产业 一站式采购" border="0" /></a><a  href="/search-keyword/zqlmCycxHpiHOeHEIJuPJUic/madeinchina.html" target="_blank" style="display: none;" rel="nofollow" ><img  src="http://image.cn.made-in-china.com/8f4j01JehEVaIPazic/made-in-china.jpg" height="170" width="545" alt="麦通在线 沟通无限" border="0" /></a><ul id="adMenu3"><li class="now">LED 品牌采购专场</li><li>塑料产业 一站式采购</li><li class="lst">麦通在线 沟通无限</li></ul>
			    </div>
			     
          
     
</div>
<div id="right">
<div   id="login">
     <h2>工友易联网|登录</h2>
		  <div id="fourInOne">	      
		         
		        <div class="sign" id="tabcontent_10">

		         <label>登录名：</label> <input tabindex="1" s="1" class="inputtext" type="text" maxlength="100" value="用户名/身份证" id="userinfo" name= "logonUserName" style="color:#c7c7c7" onblur="blurFunc()" onfocus="focusFunc()"/>
		         <span class="errorSml" id="notice_userinfo" ></span><br/>
		         <label>密&nbsp;&nbsp;&nbsp;码：</label> <input tabindex="2" class="inputtext" type="password" id="password" name="logonPassword"/>
		           <span class="errorSml" id="notice_password" ></span>   
		          <br />
		          <button tabindex="5" onclick ="javascript:PRS.login('#editForm')" ><img src="${imgPath}/portal/but-login_cn.gif" alt="登录" /></button> 
		         <input tabindex="6" type="checkbox" value="1" name="rememberMe" />记住登录名<br/> 
 
		        </div>

		    </div>
		    
	</div>
</div>
<div id="side">
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
		        <h2><a href="/PRS/bus/portal_Content_queryContent?contentType=002">新闻中心</a></h2>
		        <div id="new1">
                	<table>
                		<s:iterator value="#request.newList" id="rm">		          
		 					<tr>
		 						<td class="c10"><img src="${imgPath}/portal/control_right.png"></td>  
		    					<td class="c100""><a href="/PRS/bus/portal_Content_queryContentInfo?code=${rm.code}"> <s:property value="#rm.title"/></a></td>  
            				</tr>
            			</s:iterator>   
                	</table>
                </div>
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
<div id="footer">
<%@ include file="/jsp/portal/util/Footer.inc" %>
</div>
 
<script type="text/javascript">
		var blurFunc = function() {
		    var $this = $("#userinfo");
		    var value = $.trim($this.val());
		    if (!value) {
		        $this.val("用户名/身份证").attr("s", "1").attr("style", "color:#c7c7c7");
		    }
		};
		var focusFunc = function() {
		    var $this = $("#userinfo");
		    var value = $.trim($this.val());
		    if ($this.attr("s") === "1") {
		        $this.val("").attr("s", "2").css({
		            color: ""
		        });
		    }
		};
		var doSubmit = function() {
	        var uln = $("#userinfo");
	        if (uln.attr("s") === "1") {
	            uln.val("");
	        }
	        return true;
		}
		 
		 
	</script>
	 
	<script type="text/javascript">
		$(document).ready(function() {
		 
			$("#home").attr("class","now");
			$(".errorSml").hide(); 
			PRS.init(); 
			if($.cookie("loginName")){
		        $("#userinfo").val($.cookie('loginName')).attr('s', '2').css({ color: ''});
		        // 再次勾选
		        $("#rememberMe").attr("checked", true);
			};
		 
			//
	        var uln = $("#userinfo");
	        var value = $.trim(uln.val());
	        if (!value) {
	            uln.val("用户名/身份证").attr("s", "1").attr("style", "color:#c7c7c7");
	        }
	        else {
		        if (uln.attr("s") !== "1") {
		            uln.attr("s", "2").css({
		                color: ''
		            });
				}
	        } 
		});
	</script>
</body>
</html>