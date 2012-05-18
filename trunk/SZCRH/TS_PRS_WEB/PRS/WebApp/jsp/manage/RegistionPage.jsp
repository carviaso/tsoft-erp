<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/jsp/util/Header.inc" %>
<body>
<div class="smlWrap">
	
<div class="header2">
	<img src="${imgPath}/logo.jpg" alt="苏州川润海"/> 
	<div class="fr"> <a href="/PRS/bus/portal_Portal_welcome">川润海首页</a>	
	</div>
</div>
	<form id="editForm" action="Regist_addOper.action" method="post">
		<div id="registerStep1Wrap" class="body">			 
            <img src="${imgPath}/Banner-regist.png" width="922" height="31" />
 
			<div class="regisTop">
				<strong class="red">*</strong>为必填项 </div>
				<ul class="form">
					<li>
						<label><span class="red">*</span>&nbsp;用户名：</label>
						<div class="formContent">
							<input id="username" name="username" class="textLong" onfocus="PRS.config.username = false;PRS.hideMessage('#notice_userName','#check_username');" onblur="PRS.vUserName()" type="text" value="" maxlength="20"/><span class="errorSml" id="notice_userName" ></span><img  class="checkSml" id="check_username" src="../img/symbol_check.png"  ></img>
						  <p>- 6-20位字母、数字组合</p>
						</div>
					</li>

					<li>
						<label><span class="red">*</span>&nbsp;登录密码：</label>
						<div class="formContent">
							<input id="password" name="password" class="textLong" type="password" onfocus="PRS.config.password = false;PRS.hideMessage('#notice_password','#check_password');" onblur="PRS.vPassword()" value="" maxlength="20"/>
							<span class="errorSml" id="notice_password" style="display: none;"></span><img class="checkSml" id="check_password" src="${imgPath}/symbol_check.png" ></img>
						  <p>- 6-20位字母、数字组合</p>
						</div>
					</li>

					<li>
						<label><span class="red">*</span>&nbsp;确认密码：</label>
						<div class="formContent">
							<input id="confirmPassword" name="confirmPassword" class="textLong"  type="password" onfocus="PRS.config.confirmpwd = false;PRS.hideMessage('#notice_confirmPassword','#check_comfirmpwd');" onblur="PRS.vConfirmpwd()" value="" maxlength="20"/><span class="errorSml" id="notice_confirmPassword" style="display: none;"></span><img  class="checkSml" id="check_comfirmpwd" src="${imgPath}/symbol_check.png" ></img>
                            <p>- 请再输入一次密码。</p>
						</div>
					</li>
                    <li>
						<label><span class="red">*</span>&nbsp;注册身份证：</label>
						<div class="formContent">
							<input id="userid" name="userid" class="textLong"  type="text" onfocus="PRS.config.idexists = false;PRS.hideMessage('#notice_userId','#check_userid')" onblur="PRS.vRegistID()" value="" maxlength="20"/><span class="errorSml" id="notice_userId" ></span><img  class="checkSml" id="check_userid" src="../img/symbol_check.png" ></img>
						  <p>- 此身份证需要在川润海成功注册</p>
						</div>
					</li>
				</ul>
			
		 <!--  <p style="margin-left:143px">会员资料一经提交，即表示您同意我们的 <a href="/common/userAgreement.html" target="_blank">用户协议</a> 并且已经阅读和理解了我们的 <a href="/common/privacyPolicy.html" target="_blank">隐私策略</a>。</p> -->
				<ul class="form" style="border:none">
					<li>
						<label>&nbsp;</label>			
						 <a class="btnOk" href="javascript:PRS.regist('#editForm')"><span>提交注册信息</span></a> <span class="errorSml" id="notice_submit" ></span>
					</li>
				</ul>
		</div> 
	</form>
	
<div class="footer">
	 <p>Copyright © 2012 天时软件工作室 版权所有 </p>
</div>
</div>
 
<script type="text/javascript">
	$(document).ready(function() { 
	     $('.errorSml').hide();
	     $('.checkSml').hide();
		PRS.init();
	})
</script>
</body>
</html>
