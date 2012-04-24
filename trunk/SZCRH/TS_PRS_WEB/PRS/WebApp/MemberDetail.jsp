<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="Header.inc" %>
</head>
<script language="javascript"> 
$(document).ready(
function(){
//senfe("表格名称","奇数行背景","偶数行背景","鼠标经过背景");
	senfe("allowInfo","#f8fbfc","#e5f1f4","#ecfbd4");
}
);
function senfe(o,a,b,c){
 var t=document.getElementById(o).getElementsByTagName("tr");
 for(var i=1;i<t.length;i++){
  t[i].style.backgroundColor=(t[i].sectionRowIndex%2==0)?a:b;
   
  t[i].onmouseover=function(){
   if(this.x!="1")this.style.backgroundColor=c;
  }
  t[i].onmouseout=function(){
   if(this.x!="1")this.style.backgroundColor=(this.sectionRowIndex%2==0)?a:b;
  }
 }
}
 </script>

<body style="background-color:#FFF;margin:0"> 
	<div id="Container">
    	<div id="Header">
	<table height="50" width="100%">
    	<tr height="20">
        	<td >
        		
            </td>
        </tr>
        <tr height="30" align="right">
        	<td>
        	</td>
        	<td>        	
        		<div style="padding:25px;height:100%;background-image:url(img/title.png);background-repeat: no-repeat;">  
        		</div>
        	</td>
        	<td style="vertical-align:bottom">
        		<a href="loginForm.action"><font color="#FFFFFF">注销登录</font></a>
        	</td>
        </tr>
    </table>
</div>
        <div id="PageBody" >
        	<table width="100%" height="500" cellpadding = 0  cellspacing =  0  border="0">
        		<tr style="background-color:#E3ECFD; height:30;width:100%;">
        			<td colspan="2">
        			</td>
        		</tr>
             	<tr >
                	<td width="200" align="center" style="vertical-align:text-top">
                    	<table height="100%" width="100%">
                    		<tr height="100%">
                    			<td style="vertical-align:text-top">
                    				<div class="menubar"> 
                     		 			<li class="title">登录信息</li>
                           			</div>
                           			<div  style="width:100%;border-color:#D2DBFB; border-width:1px; border-style:solid;">
                           				<li class="info">用户名：<s:property value="#request.operInfo.username"/></li>
                           				<li class="info">姓名：${memInfo.cName}</li>
                           				<li class="info">身份证：${memInfo.cId}</li>
                           				<li class="info">津贴信息
                           				<a href="salaryForm.action?operInfo.id=${memInfo.cId}&operInfo.username=${operInfo.username}">工资信息</a></li>
                           			</div>                           			
                    			</td>
                    		</tr> 
						</table>                    		
                    </td>
                    <td style="vertical-align:text-top">
                    	<table height="100%" width="100%">
                    		<tr height="100%">
                    			<td style="vertical-align:text-top">
                    				<div class="menubar" > 
                     		 			<li class="title">津贴记录</li>
                           			</div>
                           			<div style="padding:5px;vertical-align:middle;height:25;width:700;border-color:#D2DBFB;border-width:1px;border-style:solid;">
                           				<table id="allowInfo" width="700" cellpadding="0" cellspacing="2"  width=100% bordercolorlight=#D2DBFB bordercolordark=#efefef   style="border: solid 1px #D2DBFB;">
    										<tr align="center" valign="middle" height="30px" bgcolor=#E3ECFD style="padding:5px;vertical-align:middle;height:25;width:700;border-color:#D2DBFB;border-width:1px;border-style:solid;">
    											<th width="80">发放时间</th>
    											<th width="80">津贴金额</th>
    											<th width="80">推荐人数</th>
    											<th width="80">团队人数</th>
    										</tr>
   										<s:iterator value="#request.memAllow" id="rm">
    									<tr height="20px">
    										<td class="ColBody">
    											<s:property value="#rm.allowDate"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.allowAmt"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.recNum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.teamNum"/>
    										</td>
    									</tr> 
    									</s:iterator>
    									</table>
                           			</div>                           			
                    			</td>
                    		</tr> 
						</table>                    	 
                    </td>
                </tr>                
             </table>
        </div>
        <div id="Foot"> 
    <table width="100%">
  	<tr style="background-image:url('img/line-hy.png'); " height="20">
  		<td>
    	</td> 
  	</tr>
    <tr>
      <td align="left">&copy;2011 TSoft</td>
      <td>&nbsp;</td>
      </tr>
  </table> 
</div>
    </div>
</body>
   
</html>
