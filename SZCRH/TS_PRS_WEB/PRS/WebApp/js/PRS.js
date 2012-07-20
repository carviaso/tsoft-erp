(function(){
	var p=window.PRS=function(){
		if(typeof p=="undefined"){
			return window;
		}else{
			return p;
		};
	};
	p.config = {};
	p.init = function(){
		p.config = {username:false,password:false,userid:false,nameexists:false,idexists:false,idregist:false};
		
	};
	
	p.hideMessage = function(i,o){
		$(o).hide();
		$(i).hide();
		$(i).val("");
		
	};
	p.showMessage = function(i,m){
		$(i).show();
		$(i).html(m);
	};
	p.vRequire = function(i,si,m){
		 
		var o = $(i);
		var name = $.trim(o.val());
		 
		if(!name)
		{
			p.showMessage(si,m);
			return false;
		}
		return true;
	};
	p.nameexists = function(o){
		$.ajax({
			 type:"post",
			 url:"/PRS/Regist_userExists", 
			 data:"username="+o,
			 cache:false,
			 async:false,
			 success:function(r){		 
				 var q = r.flag; 
				 if(q==="false"){
					 $("#check_username").hide();
					 p.showMessage("#notice_userName",r.msg); 
					 p.config.nameexists = false;
				 } 
				 else{
					 p.config.nameexists = true;
				 }
				 return;	 
			 }
		 });  
	};
	p.idexists = function (userid){
		$.ajax({
			 type:"post",
			 url:"/PRS/Regist_idExists", 
			 data:"userid="+userid,
			 cache:false,
			 async:false,
			 success:function(r){		 
				 var q = r.flag;
				 if(q==="false"){
					 $("#check_userid").hide();
					 p.showMessage("#notice_userId",r.msg);					
					 p.config.idexists = false;
				 }
				 else{
					 p.config.idexists = true;
				 }
				 return;
			 }
		 });
		return true;
	};
	p.idvalidation = function(o,n){
		var pwd = $.trim($("#password").val());
		if(!p.vRequire("#password","#notice_password","请输入密码！")){
			$("#check_password").hide();
			return;
		}  
		var confirmpwd = $.trim($("#confirmPassword").val());
		if(!p.vRequire("#confirmPassword","#notice_confirmPassword","请输入密码！")){
			$("#check_confirmPassword").hide();
			return;
		}  
		if(!p.samePwd("#password","#confirmPassword")){
			return ;
		}			
		
		var i = $(o);
		var id = $.trim(i.val()); 
		$.ajax({
			 type:"post",
			 url:"/PRS/Regist_idExists", 
			 data:"userid="+id,
			 cache:false,
			 async:false,
			 success:function(r){		 
				 var q = r.flag;
				 if(q==="true"){
					 p.showMessage("#notice_userId","该身份证还未被注册过！");				
					 p.config.idexists = false;
				 }
				 else{
					 $("#check_userid").hide();
					 	
					 p.config.idexists = true;
				 } 
			 }
		 });
		 
 
		var pass = $("#password").val();
		var passvalue = $.trim(pass);  
		if(p.config.idexists===true&&p.pwdvalueable(passvalue)===true){ 
			$(n).submit();
		}
	};
	
	p.idregist = function (userid){
			$.ajax({
			 type:"post",
			 url:"/PRS/Regist_idRegist", 
			 data:"userid="+userid,
			 cache:false,
			 async:false,
			 success:function(r){		 
				 var q = r.flag; 
				 if(q==="false"){ 
					 $("#check_userid").hide();
					 p.showMessage("#notice_userId",r.msg);
					 p.config.idregist = false; 
				 }
				 else{
					 p.config.idregist = true; 
				 }
				 return; 
			 }
		 });  
	};
	p.pwdvalueable = function (pwd){
		if(pwd.length<6||pwd.length>20||!/^[a-zA-Z0-9]+\s*$/.test(pwd)){
			p.showMessage("#notice_password","密码不符合要求。");
			return false;
		}
		else{
			return true;
		}
	};
	p.namevalueable = function(o){
		 
		if(o.length<6||o.length>20||!/^[a-zA-Z0-9]+\s*$/.test(o)){
		 
			p.showMessage("#notice_userName","用户名不符合要求。");
			return false;
		}
		else{
			return true;
		}
	};
	//校验密码输入是否一致
	p.samePwd = function(curid,id2){
		o1 = $.trim($(curid).val());
		o2 = $.trim($(id2).val());
		if(!o2){ 
			return true;
		}
		curid = curid.substring(1);
		if(o1!=o2){
			p.showMessage("#notice_"+curid,"两次输入的密码不一致！");
			return false;
		}
		return true;		
	};
	p.vUserName = function(){
		var name = $.trim($("#username").val());
		if(!p.vRequire("#username","#notice_userName","请输入用户名！")||!p.namevalueable(name)){
			$("#check_username").hide();
			return;
		}
		 		
		p.config.username = true; 
		$("#check_username").show();
		
	};

	//校验密码
	p.vPassword = function(){
		var pwd = $.trim($("#password").val());
		if(!p.vRequire("#password","#notice_password","请输入密码！")||!p.pwdvalueable(pwd)){
			$("#check_password").hide();
			return;
		}  
		p.config.password = true; 
		$("#check_password").show();
	  
		 
	};

	//校验登录密码
	p.vConfirmpwd = function(){
		if(!p.vRequire("#confirmPassword","#notice_confirmPassword","请确认登录密码！")||!p.samePwd("#confirmPassword","#password")){
			$("#check_comfirmpwd").hide();
			return;
		} 
		
		p.config.confirmpwd = true;  
		$("#check_comfirmpwd").show();
	  
	};

	//校验注册身份证
	p.vRegistID =function(){
		
		if(!p.vRequire("#userid","#notice_userId","请输入注册的身份证号码！")){
			$("#check_userid").hide();
			p.config.userid = false; 
			return;
		} 
		else{ 
			p.config.userid = true; 
			$("#check_userid").show();
		} 
	};
	
	p.regist = function(n){
		 
		var f = true;
		var id = $.trim($("#userid").val());
		var name = $.trim($("#username").val());
		 
		p.nameexists(name);
		p.idexists(id);
		p.idregist(id);
		 
		$.each(p.config,function(q,w){
			 
					if(w===false){
						f = false;
					}
				});
		
		 
				if(f===false){
					p.showMessage("#notic_submit","还存在未验证的信息，请等待验证通过后提交！");
					return ;
				}
				
		$(n).submit();	 
	};
	
	p.remember = function(){ 
			var rememberMe = $("#rememberMe");
			var loginName = $("#userinfo");
			var value = $.trim(loginName.val());
			if (loginName.attr('s') === '1') {
			    value = '';
			}  
			if(rememberMe.attr("checked")==true||rememberMe.attr("checked")=='checked'){
				 
                $.cookie('loginName', value, {
                    expires: 30,
                    path: '/'
                });
			}else { 
                $.cookie('loginName', value, {
                    expires: -1,
                    path: '/'
                });
			};
		
	};
	p.deleteContent = function(c){
		if(confirm("是否删除该记录")){
			
		$.ajax({
			type:"post",
			 url:"/PRS/Content_delContent", 
			 data:"code="+c,
			 cache:false,
			 async:false,
			 success:function(r){	　
				 var q = r.flag;  
				 if(q==="false"){
					 alert(r.msg);
					 return;
				 } 
				 else{
					 alert("删除成功！");
					 window.location.href='/PRS/bus/manage_Content_queryContent?contentType='+r.contentType; 
				 } 	 
			 }
		});
		}
		else{
			return;
		}
			
	}
	p.addContent = function(c,t){
		 
		var o = $.trim($("#title").val());  
		$.ajax({
			type:"post",
			 url:"/PRS/Content_addContent", 
			 data:"title="+o+"&content="+c,
			 cache:false,
			 async:false,
			 success:function(r){	　
				 var q = r.flag;  
				 if(q==="false"){
					 alert(r.msg);
					 return;
				 } 
				 else{
					 alert("保存成功！");
					 window.location.href='/PRS/bus/manage_Content_queryContent?contentType='+r.contentType; 
				 } 	 
			 }
		});
	};
	p.login = function(n){　
		if(!p.vRequire("#userinfo","#notice_userinfo","请输入用户名！")||!p.vRequire("#password","#notice_password","请输入密码！")){
			
			return;
		} 
		$('.errorSml').hide(); 
		var o = $.trim($("#userinfo").val()); 
		$.ajax({
			 type:"post",
			 url:"/PRS/Regist_userExists", 
			 data:"username="+o,
			 cache:false,
			 async:false,
			 success:function(r){	　
				 var q = r.flag;  
				 if(q==="false"){
					 p.config.nameexists = true;
				 } 
				 else{ 
					 p.config.nameexists = false;					 
				 } 	 
			 }
		 });  
 		if(p.config.nameexists===false){
			
			$.ajax({
				 type:"post",
				 url:"/PRS/Regist_idExists", 
				 data:"userid="+o,
				 cache:false,
				 async:false,
				 success:function(r){		 
					 var q = r.flag;
					 if(q==="false"){						  			
						 p.config.idexists = true;
					 }
					 else{
						 p.config.idexists = false;
					 } 
				 }
			 });
			
			
			
			if(p.config.idexists===false||p.config.nameexists === false){
				 
				p.showMessage("#notice_userinfo","用户名或者身份证不存在！");
				return;
			}
				
		}
		var datastr="";
		if(p.config.nameexists===true){
			datastr = "username="+$.trim($("#userinfo").val())+"&checkflag=username&password="+$.trim($("#password").val());
		}
		else{
			datastr = "userid="+$.trim($("#userinfo").val())+"&checkflag=id&password="+$.trim($("#password").val());
		}
		$.ajax({
			 type:"post",
			 url:"/PRS/Regist_userValidate", 
			 data:datastr,
			 cache:false,
			 async:false,
			 success:function(r){		 
				 var q = r.flag; 
				 if(q==="false"){ 
					 $("#check_userid").hide();
					 p.showMessage("#notice_password",r.msg);
					 return; 
				 } 
				 else if(q==="true"){
					 p.remember();
					 $.cookie('username', r.name, {
		                    expires: 1,
		                    path: '/'
		                });
					 window.location.href='/PRS/bus/manage_Member_querySalary?userid='+r.userid; 
				 }
				 else{
					 p.remember();
					 $.cookie('username', r.name, {
		                    expires: 1,
		                    path: '/'
		                });
					 window.location.href='/PRS/bus/manage_Content_queryContent?contentType=001'; 
				 }
					 
			 }
		});		
		
	};
	p.logout = function(){
		$.cookie("username",null,{ path: '/' });
		window.location.href="/PRS/sys/manage_LoginPage";
	}
	p.senfe = function (o,a,b,c){
		 var t=document.getElementById(o).getElementsByTagName("tr");
		 for(var i=1;i<t.length;i++){
		  t[i].style.backgroundColor=(t[i].sectionRowIndex%2==0)?a:b;
		   
		  t[i].onmouseover=function(){
		   if(this.x!="1")this.style.backgroundColor=c;
		  };
		  t[i].onmouseout=function(){
		   if(this.x!="1")this.style.backgroundColor=(this.sectionRowIndex%2==0)?a:b;
		  };
		 }
		};
	
})(window);

