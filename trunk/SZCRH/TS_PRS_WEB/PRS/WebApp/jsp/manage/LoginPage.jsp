<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="/jsp/util/Header.inc" %>
<body id="loginWrap">
	<div id="scrollnotice" style="display: none">
           <div class="ieBox">
                                          您正在使用 Internet Explorer 6，为有更好更快的体验。建议您升级到
                <a href="http://www.microsoft.com/china/windows/internet-explorer/" target="_blank">Internet Explorer 8</a>
                                           或以下浏览器：<a href="http://www.mozillaonline.com/">Firefox</a> / <a href="http://www.google.com/chrome/?hl=zh-CN">谷歌浏览器</a>
           </div>
    </div>
	
<div class="header2"> 
	 <img src="${imgPath}/logo.jpg" alt="苏州川润海"/>  
	<div class="fr"> <a href="/PRS/bus/portal_Portal_welcome">川润海首页</a><a id="addFavorite" href="javascript:addFavorite(window.location.href,document.title);">加入收藏</a> 
	</div>
</div>
<div class="content" id="send">
	  　
	    <div id="login">
	      <ul>
	        <li>
	          <label>登录名</label>
	          <input class="t" type="text"  id="userinfo" maxlength="55" value="用户名/身份证" style="color:#c7c7c7" onblur="blurFunc()" onfocus="focusFunc()" s="1"/>
	          <span class="errorSml" id="notice_userinfo" ></span>
            </li>
	        <li>
	          <label>密　码</label>
	          <input class="t" type="password" id="password" maxlength="20"/>
	          <span class="errorSml" id="notice_password" ></span>
            </li>
          </ul>
	      <div class="submit">	         
	      
	        	 <button tabindex="5" onclick ="javascript:PRS.login('#editForm')" ><img src="${imgPath}/portal/but-login_cn.gif" alt="登录" /></button> 
		      <label><input type="checkbox" name="rememberMe" id="rememberMe" /> 记住登录名</label>                     
             
          </div>
	      <div class="line">&nbsp;</div>         
	      <div class="other">
	        <p></p>
	        <p>还不是会员？ <a href="/PRS/sys/manage_RegistionPage">立即注册</a></p>
          </div>
        </div>      　
	  <div class="loginBg" id="logonBg"> 
	  		<ul class="bannerPic" rel="moveBox" moveWidth="1000">
				<li><img src="${imgPath}/bk_login1.jpg" alt="" width="578" height="338" /></li>
				<li><img src="${imgPath}/bk_login2.jpg" alt="" width="578" height="338"/></li> 
			</ul>
      </div>
</div>
<div class="footer">
  <!--
	<p><a href="http://www.leadong.com/aboutus.html" target="_blank">关于我们</a> - <a href="http://www.leadong.com/declaration.html" target="_blank">法律声明</a> - <a href="http://www.leadong.com/terms.html" target="_blank">用户协议</a> - <a href="http://www.leadong.com/privacy.html" target="_blank">隐私报告</a> - <a href="http://www.leadong.com/partner.html" target="_blank">合作伙伴</a> - <a href="http://www.leadong.com/contact.html" target="_blank">联系我们</a> - <a href="http://www.leadong.com/sitemap.html" target="_blank">网站地图</a> </p>-->
  <p>Copyright © 2012 天时软件工作室 版权所有 </p>
</div>
	<script type="text/javascript">
		var blurFunc = function() {
		    var $this = $('#userinfo');
		    var value = $.trim($this.val());
		    if (!value) {
		        $this.val('用户名/身份证').attr('s', '1').attr('style', 'color:#c7c7c7');
		    }
		};
		var focusFunc = function() {
		    var $this = $('#userinfo');
		    var value = $.trim($this.val());
		    if ($this.attr('s') === '1') {
		        $this.val('').attr('s', '2').css({
		            color: ''
		        });
		    }
		};
		var doSubmit = function() {
	        var uln = $('#userinfo');
	        if (uln.attr('s') === '1') {
	            uln.val('');
	        }
	        return true;
		}
		var changeRandom = function() {
            var url = '/common/validate_' + 'cn' + '.jsp';
            $.post(url, function() {
                //对返回结果做trim()，否则由于换行、空格等，在ie下图片显示会往右边移
                var imageHtml = arguments[0].replace(/(^\s*)|(\s*$)/g, "");
                $('#validateimage').html(imageHtml);
            });
		}
	</script>
	<script type="text/javascript">
		var AutoMove = (function(){
		    var _moveBox,
		        _count = 0,
		        _active = 0,
		        _autoTime = 7000,
		        _stop = false;
		    var move = function(index){
		        var ind = index;
		        _active = ind;
		        _moveBox.each(function(i){
		            var end = ind * 690;
				    $(this).stop().animate({left: -end}, 600);
		        })
		    }
		    var autoMove = function(){
		        if(_stop) return;
		        _active++;
		        if(_active >= _count){
		            _active = 0;
		    	}
		        move(_active);
		    }
		    return {
		       Bind: function(box){
		           _count = 2;
		           _moveBox = box.find("[rel='moveBox']");
		           window.setInterval(autoMove, _autoTime);
		       }
		    }
		})();
	</script>
	<script type="text/javascript">
		$(document).ready(function() {
			$('.errorSml').hide(); 
			PRS.init();
			// 如果是IE6.0出现浏览器升级提示
			if($.browser.msie && $.browser.version=='6.0'){
		         $('#scrollnotice').show();
		     }
	        // 如果是IE和FF显示保存收藏夹功能
	        if($.browser.msie || navigator.userAgent.indexOf("Firefox")>-1){
	           $('#addFavorite').show();
	        }  
			if($.cookie('loginName')){
		        $('#userinfo').val($.cookie('loginName')).attr('s', '2').css({ color: ''});
		        // 再次勾选
		        $('#rememberMe').attr('checked', true);
			}
			//
	        var uln = $('#userinfo');
	        var value = $.trim(uln.val());
	        if (!value) {
	            uln.val('用户名/身份证').attr('s', '1').attr('style', 'color:#c7c7c7');
	        }
	        else {
		        if (uln.attr('s') !== '1') {
		            uln.attr('s', '2').css({
		                color: ''
		            });
				}
	        }
	        AutoMove.Bind($("#logonBg"));
		});
	</script>
	
	<script type="text/javascript" src="../js/common.js"></script>
</body>
</html>