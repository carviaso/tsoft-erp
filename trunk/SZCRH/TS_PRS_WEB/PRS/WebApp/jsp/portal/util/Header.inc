<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<img src="${imgPath}/portal/logo.png"/>
<div id="nav">
    <ul id="pr">
      <li id="home" ><a href="/PRS/bus/portal_Portal_welcome" target="_self"><span>首页</span></a> </li>
      <li id="news" ><a href="/PRS/bus/portal_Content_queryContent?contentType=002" target="_self"><span>新闻中心</span></a></li>
      <li id="comp"><a href="/PRS/sys/portal_company" target="_self"><span>公司简介</span></a></li>      
      <li id="recom"><a href="/PRS/bus/portal_Content_queryContent?contentType=001" target="_self"><span>站内公告</span></a></li>
      <li id="busi"><a href="/PRS/sys/portal_business" target="_self"><span>业务范围</span></a></li>
      <li id="cont"><a href="/PRS/sys/portal_contact" target="_self"><span>联系我们</span></a></li>
      <li id="phone"></li>
    </ul>
    <div id="lan">
		<img src="${imgPath}/portal/lan.png"></img>
	</div>
</div>
<div id="searchBar">
	<div class="box-search">
        <a href="http://www.baidu.com/index.php?tn=sitehao123" title="百度首页"><img id="searchGroupLogo" src="${imgPath}/portal/web.png" width="97" height="32" alt="百度首页" /></a>
    </div> 
 <div class="box-search">
    	<form id="searchGroupForm" action="http://www.baidu.com/s">
                <div class="box-search">
                    <b class="shadow-x"></b><b class="shadow-y"></b>
                    <input id="searchGroupInput" name="word" maxlength="100" type="text" autocomplete="off" />
                </div>
                <span ><b class="r"></b><b class="l"></b><button class="box-search" id="searchGroupBtn"   hidefocus="true" type="submit">百度一下</button></span>
                
                <span id="searchGroupParams" style="display:none"><input type="hidden" name="tn" value="sitehao123"></span>
                <span style="display:none" id="sugMonParam"></span>
            </form>
            </div>
</div>
 
