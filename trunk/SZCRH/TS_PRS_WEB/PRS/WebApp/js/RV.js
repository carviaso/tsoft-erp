(function(){var h=window.RV=function(){if(typeof h=="undefined"){return window
}else{return h
}};
h.config={};
h.userAddConfig={};
h.modifyPasswordConfig={};
h.buyConfig={};
h.comUpdateConfig={};
h.tryFaxConfig={};
h.buyFaxConfig={};
h.init=function(){h.config={userName:false,password:false,confimPassword:false,userRealName:false,userEmail:false,userTelephone:false,userMobilephone:false,comName:false,comProvince:false,comCity:false,comAddress:false,invitationCode:false};
h.userAddConfig={userBackEmail:false,telephone:false,cellphone:false,fax:false,zipCode:false};
h.comUpdateConfig={comName:false,comProvince:false,comCity:false,comAddress:false,zipCode:false,telephone:false,fax:false};
h.modifyPasswordConfig={oldPassword:false,newPassword:false,confirmPassword:false};
h.buyConfig={userRealName:false,userEmail:false,comAddress:false,comZip:false,userMobilephone:false};
h.tryFaxConfig={userRealName:false,userTelephone:false};
h.buyFaxConfig={telExtensionsNum:false,telAreaCode:false,faxTarget:false,prestoreAmount:false,faxBuyTime:false};
var n=$("#provinceSelect");
n.bind("blur",function(){n.trigger("change")
});
n.bind("keyup",function(){n.trigger("change")
});
n.bind("change",function(){h.comProvinceV()
});
var m=$("#citySelect");
m.bind("blur",function(){m.trigger("change")
});
m.bind("keyup",function(){m.trigger("change")
});
m.bind("change",function(){h.comCityV()
})
};
h.userNameV=function(){var p=$("#userName");
var o=$.trim(p.val());
var n=$.trim($("#userId").val());
if(!o){h.config.userName=false;
h.showMessage("notice_userName","请输入用户名。","errorSml");
return
}if(o.length<6||o.length>20||!/^[a-zA-Z0-9\-]+\s*$/.test(o)){h.config.userName=false;
h.showMessage("notice_userName","用户名不符合要求。","errorSml");
return
}var m={userName:o,userId:n};
jQuery.ajax({type:"post",url:"/register/checkUserName/"+window.localeDesc,data:m,cache:false,complete:function(r){var q=r.responseText;
if(q==="true"){h.config.userName=true;
return
}else{if(q==="false"){h.config.userName=false;
h.showMessage("notice_userName","用户名已存在。","errorSml");
return
}}}})
};
h.userNameV_2=function(){var n=$("#userName");
var m=$.trim(n.val());
if(!m){h.config.userName=false;
h.showMessage("notice_userName","请输入用户名。","errorSml");
return
}if(m.length<6||m.length>20||!/^[a-zA-Z0-9\-]+\s*$/.test(m)){h.config.userName=false;
h.showMessage("notice_userName","用户名不符合要求。","errorSml");
return
}h.config.userName=true
};
h.userRealNameO=function(){var n=$("#wpUser\\.userRealName");
var m=$.trim(n.val());
if(!m){h.buyConfig.userRealName=false;
h.tryFaxConfig.userRealNmae=false;
h.showMessage("notice_wpUser\\.userRealName","请输入联系人。","errorSml");
return
}h.buyConfig.userRealName=true;
h.tryFaxConfig.userRealName=true
};
h.userTelephoneO=function(){var n=$("#wpUser\\.userTelephone");
var m=$.trim(n.val());
if(!m){h.buyConfig.userTelephone=false;
h.showMessage("notice_wpUser\\.userTelephone","请输入电话。","errorSml");
return
}h.buyConfig.userTelephone=true
};
h.userEmailO=function(){var n=$("#wpUser\\.userEmail");
var m=$.trim(n.val());
if(!m){h.buyConfig.userEmail=false;
h.showMessage("notice_wpUser\\.userEmail","请输入电子邮箱。","errorSml");
return
}if(!h.email(m)){h.buyConfig.userEmail=false;
h.showMessage("notice_wpUser\\.userEmail","请输入有效的电子邮箱。","errorSml");
return
}h.buyConfig.userEmail=true
};
h.comAddressO=function(){var n=$("#wpCompany\\.comAddress");
var m=$.trim(n.val());
if(!m){h.buyConfig.comAddress=false;
h.showMessage("notice_wpCompany\\.comAddress","请输入地址。","errorSml");
return
}h.buyConfig.comAddress=true
};
h.comZipO=function(){var n=$("#wpCompany\\.comZip");
var m=$.trim(n.val());
if(!m){h.buyConfig.comZip=false;
h.showMessage("notice_wpCompany\\.comZip","请输入邮编。","errorSml");
return
}if(!l.test(m)){h.buyConfig.comZip=false;
h.showMessage("notice_wpCompany\\.comZip","您填写的邮编有误。","errorSml");
return
}h.buyConfig.comZip=true
};
h.userMobilephoneO=function(){var n=$("#wpUser\\.userMobilephone");
var m=$.trim(n.val());
if(!m){h.buyConfig.userMobilephone=false;
h.showMessage("notice_wpUser\\.userMobilephone","请填写手机号。","errorSml");
return
}if(m&&!d.test(m)){h.buyConfig.userMobilephone=false;
h.showMessage("notice_wpUser\\.userMobilephone","您填写的手机号码有误。","errorSml");
return
}h.buyConfig.userMobilephone=true
};
h.invoiceComO=function(){var n=$("#wpOrder\\.invoiceCom");
var m=$.trim(n.val());
if(!m){h.showMessage("notice_wpOrder\\.invoiceCom","请输入开票单位。","errorSml");
return
}};
h.passwordV=function(){var n=$("#password");
var m=$.trim(n.val());
if(!m){h.config.password=false;
h.showMessage("notice_password","请输入密码。","errorSml");
return
}if(m.length<6||m.length>20||!/^[a-zA-Z0-9_\-]+\s*$/.test(m)){h.config.password=false;
h.showMessage("notice_password","密码不符合要求。","errorSml");
return
}if(m===$.trim($("#userName").val())){h.config.password=false;
h.showMessage("notice_password","密码不可与用户名相同。","errorSml");
return
}if(!h.dup(m)){h.config.password=false;
h.showMessage("notice_password","密码过于简单。","errorSml");
return
}h.config.password=true
};
h.newPasswordV=function(){var n=$("#password");
var m=$.trim(n.val());
if(!m){h.modifyPasswordConfig.newPassword=false;
h.showMessage("notice_password","请输入密码。","errorSml");
return
}h.modifyPasswordConfig.newPassword=true
};
h.confimPasswordV=function(){var n=$("#confimPassword");
var m=$.trim(n.val());
if(!m){h.config.confimPassword=false;
h.modifyPasswordConfig.confimPassword=false;
h.showMessage("notice_confimPassword","请输入确认密码。","errorSml");
return
}if(m!==$.trim($("#password").val())){h.config.confimPassword=false;
h.modifyPasswordConfig.confimPassword=false;
h.showMessage("notice_confimPassword","两次输入不一致,请重新输入。","errorSml");
return
}h.config.confimPassword=true;
h.modifyPasswordConfig.confimPassword=true
};
h.oldPasswordV=function(){var o=$("#oldPassword");
var n=$.trim(o.val());
if(!n){h.modifyPasswordConfig.oldPassword=false;
h.showMessage("notice_oldPassword","请输入密码。","errorSml");
return
}var m={oldPassword:n};
jQuery.ajax({type:"post",url:"/company/checkOldPassword/"+window.localeDesc,data:m,cache:false,complete:function(q){var p=q.responseText;
if(p==="true"){h.modifyPasswordConfig.oldPassword=true;
return
}else{if(p==="false"){h.modifyPasswordConfig.oldPassword=false;
h.showMessage("notice_oldPassword","原密码不正确","errorSml");
return
}else{h.modifyPasswordConfig.oldPassword=false;
h.showMessage("notice_oldPassword","服务器正忙。","errorSml");
return
}}}})
};
h.oldPasswordV2=function(){var n=$("#oldPassword");
var m=$.trim(n.val());
if(!m){h.modifyPasswordConfig.oldPassword=false;
h.showMessage("notice_oldPassword","请输入密码。","errorSml");
return
}};
h.userRealNameV=function(){var n=$("#userRealName");
var m=$.trim(n.val());
if(!m){h.config.userRealName=false;
h.showMessage("notice_userRealName","请输入真实姓名。","errorSml");
return
}h.config.userRealName=true
};
h.userEmailV=function(){var p=$("#userEmail");
var o=$.trim(p.val());
var n=$.trim($("#userId").val());
if(!o){h.config.userEmail=false;
h.showMessage("notice_userEmail","请输入邮箱。","errorSml");
return
}if(!h.email(o)){h.config.userEmail=false;
h.showMessage("notice_userEmail","请输入有效的邮件地址。","errorSml");
return
}var m={userEmail:o,userId:n};
jQuery.ajax({type:"post",url:"/register/checkUserEmail/"+window.localeDesc,data:m,cache:false,complete:function(r){var q=r.responseText;
if(q==="true"){h.config.userEmail=true;
return
}else{if(q==="false"){h.config.userEmail=false;
h.showMessage("notice_userEmail","此邮件地址已存在。","errorSml");
return
}}}})
};
h.userEmailV_2=function(){var n=$("#userEmail");
var m=$.trim(n.val());
if(!m){h.config.userEmail=false;
h.showMessage("notice_userEmail","请输入邮箱。","errorSml");
return
}if(!h.email(m)){h.config.userEmail=false;
h.showMessage("notice_userEmail","请输入有效的邮件地址。","errorSml");
return
}h.config.userEmail=true
};
h.userBackEmailV=function(){var n=$("#userBackEmail");
var m=$.trim(n.val());
if(m){if(!h.email(m)){h.userAddConfig.userBackEmail=false;
h.showMessage("notice_userBackEmail","请输入有效的邮件地址。","errorSml");
return
}}h.userAddConfig.userBackEmail=true
};
var d=/^[0-9]{11}\s*$/;
var g=/^[0-9]{1,4}\s*$/;
var f=/^[0-9]{1,5}\s*$/;
var e=/^[0-9]{1,10}\s*$/;
var c=/^[0-9]{1,10}\s*$/;
var b=/^[0-9]([0-9]|-){1,48}[0-9]\s*$/;
var a=/^[0-9]([0-9]|-){1,18}[0-9]\s*$/;
var l=/[^\u4E00-\u9FA5]+\s*$/;
var j=/^[0-9]{1,50}\s*$/;
var i=/^[1-9]\d*$/;
var k=/^(([3-9]\d{2,})|([1-9]\d{3,}))(\.\d{1,2})?$/;
h.tel1V=function(){h.telephoneV();
if($("#notice_userTelephone").is(":visible")===true){return
}if(!$.trim($("#userMobilephone").val())&&!$.trim($("#userTelephone").val())){h.config.userMobilephone=false;
h.showMessage("notice_userMT","固定电话和手机必填一项。","errorSml");
return
}};
h.tel2V=function(){h.telephoneV();
if($("#notice_userTelephone").is(":visible")===true){return
}if(!$.trim($("#userMobilephone").val())&&!$.trim($("#userTelephone").val())){h.config.userMobilephone=false;
h.showMessage("notice_userMT","固定电话和手机必填一项。","errorSml");
return
}};
h.tel3V=function(){h.telephoneV();
if($("#notice_userTelephone").is(":visible")===true){return
}if(!$.trim($("#userMobilephone").val())&&!$.trim($("#userTelephone").val())){h.config.userMobilephone=false;
h.showMessage("notice_userMT","固定电话和手机必填一项。","errorSml");
return
}h.config.userMobilephone=true
};
h.tel4V=function(){h.telephoneV();
if($("#notice_userTelephone").is(":visible")===true){return
}if(!$.trim($("#userMobilephone").val())&&!$.trim($("#userTelephone").val())){h.config.userMobilephone=false;
h.showMessage("notice_userMT","固定电话和手机必填一项。","errorSml");
return
}h.config.userMobilephone=true
};
h.telephoneV=function(){if($("#tel1").attr("s")==="1"&&$("#tel2").attr("s")==="1"&&$("#tel3").attr("s")==="1"&&$("#tel4").attr("s")==="1"){$("#userTelephone").val("");
h.config.userTelephone=true;
return
}else{if(!g.test($.trim($("#tel1").val()))){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{if($("#tel2").attr("s")==="1"){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{if(!f.test($.trim($("#tel2").val()))){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{if($("#tel3").attr("s")==="1"){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{if(!e.test($.trim($("#tel3").val()))){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{if($("#tel4").attr("s")==="1"){var m=$.trim($("#tel1").val())+"-"+$.trim($("#tel2").val())+"-"+$.trim($("#tel3").val());
$("#userTelephone").val(m);
h.config.userTelephone=true;
return
}else{if(!c.test($.trim($("#tel4").val()))){$("#userTelephone").val("");
h.config.userTelephone=false;
h.showMessage("notice_userTelephone","输入的固定电话格式不正确。","errorSml");
return
}else{var m=$.trim($("#tel1").val())+"-"+$.trim($("#tel2").val())+"-"+$.trim($("#tel3").val())+"-"+$.trim($("#tel4").val());
$("#userTelephone").val(m);
h.config.userTelephone=true
}}}}}}}}};
h.userMobilephoneV=function(){var n=$("#userMobilephone");
var m=$.trim(n.val());
if(m&&!d.test(m)){h.config.userMobilephone=false;
h.showMessage("notice_userMobilephone","输入的手机号码格式不正确。","errorSml");
return
}if(!$.trim($("#userMobilephone").val())&&!$.trim($("#userTelephone").val())){h.config.userMobilephone=false;
h.showMessage("notice_userMT","固定电话和手机必填一项。","errorSml");
return
}h.config.userMobilephone=true
};
h.comNameV=function(){var n=$("#comName");
var m=$.trim(n.val());
if(!m){h.config.comName=false;
h.comUpdateConfig.comName=false;
h.showMessage("notice_comName","请输入公司名称。","errorSml");
return
}h.config.comName=true;
h.comUpdateConfig.comName=true
};
h.comAddressV=function(){var n=$("#comAddress");
var m=$.trim(n.val());
if(!m){h.config.comAddress=false;
h.comUpdateConfig.comAddress=false;
h.showMessage("notice_comAddress","请填写公司地址。","errorSml");
return
}h.config.comAddress=true;
h.comUpdateConfig.comAddress=true
};
h.invitationCodeV=function(){var n=$("#invitationCode");
var m=$.trim(n.val());
if(m&&!/^[0-9a-z]{16}\s*$/.test(m)){h.config.invitationCode=false;
h.showMessage("notice_invitationCode","请输入正确的邀请码。","errorSml");
return
}h.config.invitationCode=true
};
h.comProvinceV=function(){var n=$("#provinceSelect");
var m=$.trim(n.val());
if(!m){h.config.comProvince=false;
h.config.comCity=false;
h.comUpdateConfig.comProvince=false;
h.comUpdateConfig.comCity=false;
h.showMessage("notice_comProvince","请选择所在地信息。","errorSml");
return
}h.hideMessage("notice_comProvince");
h.config.comProvince=true;
h.config.comCity=true;
h.comUpdateConfig.comProvince=true;
h.comUpdateConfig.comCity=true
};
h.comCityV=function(){var n=$("#citySelect");
var m=$.trim(n.val());
if(!m){h.config.comCity=false;
h.comUpdateConfig.comCity=false;
h.showMessage("notice_comProvince","请选择所在地信息。","errorSml");
return
}h.config.comCity=true;
h.comUpdateConfig.comCity=true
};
h.addTelV=function(){var n=$("#telephone");
var m=$.trim(n.val());
if(m&&!b.test(m)){h.userAddConfig.telephone=false;
h.comUpdateConfig.telephone=false;
h.tryFaxConfig.telephone=false;
h.showMessage("notice_addTel","输入的固定电话格式不正确。","errorSml");
h.showMessage("notice_telephone","输入的固定电话格式不正确。","errorSml");
h.showMessage("notice_wpUser\\.userTelephone","输入的固定电话格式不正确。","errorSml");
return
}h.userAddConfig.telephone=true;
h.comUpdateConfig.telephone=true;
h.tryFaxConfig.telephone=true
};
h.addCellV=function(){var n=$("#cellphone");
var m=$.trim(n.val());
if(m&&!d.test(m)){h.userAddConfig.cellphone=false;
h.showMessage("notice_cellphone","输入的手机号码格式不正确。","errorSml");
return
}h.userAddConfig.cellphone=true
};
h.addFaxV=function(){var n=$("#fax");
var m=$.trim(n.val());
if(m&&!a.test(m)){h.userAddConfig.fax=false;
h.comUpdateConfig.fax=false;
h.showMessage("notice_addFax","输入的传真格式不正确。","errorSml");
h.showMessage("notice_fax","输入的传真格式不正确。","errorSml");
return
}h.userAddConfig.fax=true;
h.comUpdateConfig.fax=true
};
h.addfaxTypeV=function(){var n=$("#faxType");
var m=$.trim(n.val());
if(!m){h.buyFaxConfig.faxType=false;
h.showMessage("notice_faxType","请选择传真类型。","errorSml");
return
}};
h.addTelExtensionsNumV=function(){var n=$("#telExtensionsNum");
var m=$.trim(n.val());
if($("#extension").is(":hidden")){h.buyFaxConfig.telExtensionsNum=true;
return
}else{if(!m){h.buyFaxConfig.telExtensionsNum=false;
h.showMessage("notice_telExtensionsNum","请输入分机数。","errorSml");
return
}else{if(!i.test(m)){h.buyFaxConfig.telExtensionsNum=false;
h.showMessage("notice_telExtensionsNum","分机必须为大于1的数字。","errorSml");
return
}}h.buyFaxConfig.telExtensionsNum=true
}};
h.addTelAreaCodeV=function(){var n=$("#telAreaCodeSelect");
var m=$.trim(n.val());
if(!m){h.buyFaxConfig.telAreaCode=false;
h.showMessage("notice_telAreaCode","请选择所在地区区号。","errorSml");
return
}h.buyFaxConfig.telAreaCode=true
};
h.addFaxTargetV=function(){var n=$("#faxTargetSelect");
var m=$.trim(n.val());
if(!m){h.buyFaxConfig.faxTarget=false;
h.showMessage("notice_faxTarget","请选择发送传真权限。","errorSml");
return
}h.buyFaxConfig.faxTarget=true
};
h.addFaxBuyTimeV=function(){var n=$("#faxBuyTimeSelect");
var m=$.trim(n.val());
if(!m){h.buyFaxConfig.faxBuyTime=false;
h.showMessage("notice_faxBuyTime","请选择购买期限。","errorSml");
return
}h.buyFaxConfig.faxBuyTime=true
};
h.addPrestoreAmountV=function(){var n=$("#prestoreAmount");
var m=$.trim(n.val());
if(!m){h.buyFaxConfig.prestoreAmount=false;
h.showMessage("notice_prestoreAmount","充值需不少于300元。","errorSml");
return
}else{if(!k.test(m)){h.buyFaxConfig.prestoreAmount=false;
h.showMessage("notice_prestoreAmount","充值需不少于300元。","errorSml");
return
}}h.buyFaxConfig.prestoreAmount=true
};
h.addZipCodeV=function(){var n=$("#zipCode");
var m=$.trim(n.val());
if(m&&!l.test(m)){h.userAddConfig.zipCode=false;
h.comUpdateConfig.zipCode=false;
h.showMessage("notice_zipCode","输入的邮编格式不正确。","errorSml");
return
}h.userAddConfig.zipCode=true;
h.comUpdateConfig.zipCode=true
};
h.addZipCodeV=function(){var n=$("#zipCode");
var m=$.trim(n.val());
if(m&&!l.test(m)){h.userAddConfig.zipCode=false;
h.comUpdateConfig.zipCode=false;
h.showMessage("notice_zipCode","输入的邮编格式不正确。","errorSml");
return
}h.userAddConfig.zipCode=true;
h.comUpdateConfig.zipCode=true
};
h.dup=function(x){var w=true;
var m=/^\d+$/;
var n=/^[a-zA-Z]+$/;
if(m.test(x)){var q=x.split(""),t=1,u=1;
for(var p=1;
p<q.length;
p++){if(q[p]-q[p-1]==1){t++
}if(q[p]-q[p-1]==0){u++
}}if(t==q.length||u==q.length){return false
}}if(n.test(x)){var v=x.split(""),s=1,r=1;
for(var o=1;
o<v.length;
o++){if(v[o].charCodeAt(0)-v[o-1].charCodeAt(0)==1){s++
}if(v[o].charCodeAt(0)-v[o-1].charCodeAt(0)==0){r++
}}if(s==v.length||r==v.length){return false
}}return w
};
h.email=function(m){return/^([a-zA-Z0-9_-])*([\.a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]+)+)\s*$/i.test(m)
};
h.showMessage=function(p,n,m){var o=$("#"+p);
o.html(n).attr("class",m).show()
};
h.hideMessage=function(n){var m=$("#"+n);
if(typeof m=="undefined"){return
}m.html("").hide()
};
h.focus=function(o){var n=$("#"+o);
var m=$.trim(n.val());
if(n.attr("s")==="1"){n.attr("s","2").css({color:""});
if(o!=="tel1"){n.val("")
}}};
h.blur=function(o){var n=$("#"+o);
var m=$.trim(n.val());
if(m==="86"){if(o==="tel1"){n.attr("s","1").css({color:"#999"})
}}else{if(!m){n.attr("s","1").css({color:"#999"});
if(o==="tel2"){n.val("区号")
}else{if(o==="tel3"){n.val("座机号")
}else{if(o==="tel4"){n.val("分机号")
}else{if(o==="tel1"){n.val("86")
}}}}}}};
h.saveOrder=function(){var p=$("#agreeBox").attr("checked");
if(!p){return
}$("#agreeBox").val("1");
h.userRealNameO();
h.userEmailO();
h.comAddressO();
h.comZipO();
h.userMobilephoneO();
h.invoiceComO();
var o=true;
$.each(h.buyConfig,function(r,q){if(q===false){o=false
}});
if(o===false){return
}var n=$("#wpOrder\\.isPostInvoice").attr("checked");
if(n){$("#wpOrder\\.isPostInvoice").val("1")
}else{$("#wpOrder\\.isPostInvoice").val("0")
}var m=$("#wpOrder\\.invoiceCom").val();
if(n&&$.trim(m)==""){$("#notice_wpOrder\\.invoiceCom").text(SMT.message("buy_right_com","请输入开票单位。"));
$("#notice_wpOrder\\.invoiceCom").show()
}else{$("#editForm").submit()
}};
h.tryuseFaxStep1Save=function(){var o=$("#editForm");
var n=$("#agreeBox").attr("checked");
if(!n){return
}if("0"==$("#vefiryFlag").val()){h.showMessage("notice_cellphone","请验证手机号码。","errorSml");
return
}$("#mobile").val($("#userMobilephone").text());
$("#agreeBox").val("1");
h.userRealNameO();
var m=true;
$.each(h.tryFaxConfig,function(q,p){if(p===false){m=false
}});
if("1"!==$("#vefiryFlag").val()){m=false
}if(m===true){o.submit()
}};
h.saveBuyFaxStep1=function(){h.tryuseFaxStep1Save()
};
h.saveBuyFaxStep2=function(){var n=$("#editForm");
h.addTelExtensionsNumV();
h.addTelAreaCodeV();
h.addFaxTargetV();
h.addPrestoreAmountV();
h.addFaxBuyTimeV();
$("#mobile").val($.trim($("#userMobilephone").html()));
var m=true;
$.each(h.buyFaxConfig,function(p,o){if(o===false){m=false
}});
if(m===true){n.submit()
}};
h.submit=function(){var p=$("#editForm");
h.userNameV_2();
h.passwordV();
h.confimPasswordV();
h.userRealNameV();
h.userEmailV_2();
h.telephoneV();
h.userMobilephoneV();
h.comNameV();
h.comProvinceV();
h.comCityV();
h.comAddressV();
h.invitationCodeV();
var m=true;
$.each(h.config,function(t,s){if(s===false){m=false
}});
$(".errorSml").each(function(){if($(this).is(":visible")){m=false
}});
if(m===true){var r=$("#tel1");
var q=$("#tel2");
var o=$("#tel3");
var n=$("#tel4");
if(r.attr("s")==="1"){$("#tel1").val("")
}if(q.attr("s")==="1"){$("#tel2").val("")
}if(o.attr("s")==="1"){$("#tel3").val("")
}if(n.attr("s")==="1"){$("#tel4").val("")
}p.submit()
}};
h.userAddSubmit=function(m){var o=$("#editForm");
h.userNameV_2();
h.passwordV();
h.confimPasswordV();
h.userRealNameV();
h.userEmailV_2();
h.userBackEmailV();
h.addTelV();
h.addCellV();
h.addFaxV();
h.addZipCodeV();
var n=true;
$.each(h.userAddConfig,function(q,p){if(p===false){n=false
}});
if(!h.config.userName||!h.config.password||!h.config.confimPassword||!h.config.userRealName||!h.config.userEmail){n=false
}$("#notice_pic").hide();
$(".errorSml").each(function(){if($(this).is(":visible")){n=false
}});
$("#isDeletePic").val($("#img_preview_isDeletePic").val());
$("#addAndCreate").val(m);
if(n===true){o.submit()
}};
h.userUpdateSubmit=function(m){var o=$("#editForm");
h.userRealNameV();
h.userEmailV_2();
h.userBackEmailV();
h.addTelV();
h.addCellV();
h.addFaxV();
h.addZipCodeV();
var n=true;
$.each(h.userAddConfig,function(q,p){if(p===false){n=false
}});
if(!h.config.userRealName||!h.config.userEmail){n=false
}$("#notice_pic").hide();
$(".errorSml").each(function(){if($(this).is(":visible")){n=false
}});
$("#isDeletePic").val($("#img_preview_isDeletePic").val());
$("#addAndCreate").val(m);
$("#userName").val($("#userName").val());
if(n===true){o.submit()
}};
h.comUpdateSubmit=function(){var n=$("#editForm");
h.comNameV();
h.comProvinceV();
h.comCityV();
h.comAddressV();
h.addZipCodeV();
h.addTelV();
h.addFaxV();
var m=true;
$.each(h.comUpdateConfig,function(p,o){if(o===false){m=false
}});
$("#notice_pic").hide();
$("#notice_comDesc").hide();
$(".errorSml").each(function(){if($(this).is(":visible")){m=false
}});
SMT.copyCkeditorHTML("comDesc");
$("#isDeletePic").val($("#img_preview_isDeletePic").val());
if(m===true){n.submit()
}};
h.modifyPasswordSubmit=function(){var n=$("#editForm");
h.oldPasswordV2();
h.newPasswordV();
h.confimPasswordV();
h.modifyPasswordConfig.oldPassword=true;
var m=true;
$.each(h.modifyPasswordConfig,function(p,o){if(o===false){m=false
}});
$(".errorSml").each(function(){if($(this).is(":visible")){m=false
}});
if(m===true){n.submit()
}}
})();
var provinceChange=function(){var c=$("#provinceSelect").val();
var b="/register/getCityListByProvince/"+window.localeDesc;
var a={comProvince:c};
jQuery.post(b,a,function(d){var g=new Function("return "+d);
g=g();
var i=document.getElementById("citySelect");
i.length=0;
for(var f in g){var e=document.createElement("OPTION");
e.value=f;
var h=document.createTextNode(g[f]);
e.appendChild(h);
i.appendChild(e)
}})
};