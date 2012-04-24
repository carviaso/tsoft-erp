<%@ page language="java" import="java.util.*" pageEncoding="utf-8"%>
<%@ include file="Header.inc" %>
</head>
<script language="javascript"> 
$(document).ready(
function(){
//senfe("表格名称","奇数行背景","偶数行背景","鼠标经过背景");
	senfe("salaryInfo","#f8fbfc","#e5f1f4","#ecfbd4");
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
                           				<li class="info"><a href="allowForm.action?operInfo.id=${memInfo.cId}&operInfo.username=${operInfo.username}">津贴信息</a>
                           				<a>工资信息</a></li>
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
                     		 			<li class="title">工资记录</li>
                           			</div>
                           			<div style="padding:5px;vertical-align:middle;height:25;width:700;border-color:#D2DBFB;border-width:1px;border-style:solid;">
                           				<table id="salaryInfo" width="1000" cellpadding="0" cellspacing="2"  width=100% bordercolorlight=#D2DBFB bordercolordark=#efefef   style="border: solid 1px #D2DBFB;">
    										<tr align="center" valign="middle" height="30px" bgcolor=#E3ECFD style="padding:5px;vertical-align:middle;height:25;width:700;border-color:#D2DBFB;border-width:1px;border-style:solid;">
    											<th width="200">发放时间</th>
    											<th width="100">本月个人工作天数</th>
    											<th width="80">本月部门工作天数</th>
    											<th width="80">上月个人工作天数</th>
    											<th width="80">上月部门工作天数</th>
    											<th width="80">本月平时加班时数合计</th>
    											<th width="80">本月假日加班时数合计</th>
    											<th width="80">本月节日加班时数合计</th>
    											<th width="80">本月夜班津贴时数</th>
    											<th width="80">本月欠班时数合计</th>
    											<th width="80">本月旷职时数合计</th>
    											<th width="80">本月请假时数合计</th>
    											<th width="80">基本工资</th>
    											<th width="80">加班费合计</th>
    											<th width="80">夜班津贴合计</th>
    											<th width="80">缺勤扣款合计</th>
    											<th width="80">应领合计</th>
    											<th width="80">计费天数</th>
    											<th width="80">电费</th>
    											<th width="80">水费</th>
    											<th width="80">燃气费</th>
    											<th width="80">意外险</th>　
    											<th width="80">宿舍费用</th>
    											<th width="80">费用合计</th>
    											<th width="80">预支工资</th>
    											<th width="80">推荐费</th>
    											<th width="80">扣管理费</th>
    											<th width="80">扣办证费</th>
    											<th width="80">扣大专费</th>
    											<th width="80">应发工资</th>
    											<th width="80">备注</th>
    										</tr>
   										<s:iterator value="#request.memSalary" id="rm">
    									<tr height="20px">
    										<td class="ColBody">
    											<s:property value="#rm.salaryDate"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.dayNumPersonCurrMon"/>
    										</td>
    										 
    										<td class="ColBody">
    											<s:property value="#rm.dayNumDeptCurrMon"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.dayNumPersonLastMon"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.dayNumDeptLastMon"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.overtimeSum_workday"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.overtimeSum_holiday"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.overtimeSum_festival"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.overtimeSum_allow"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.owetimeSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.awaytimeSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.offtimeSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.baseSalary"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.overtimeFeeSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.nighttimeAllowSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.owetimeFeeSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.salarySum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.dayNum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.electriBill"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.waterBill"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.gasBill"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.accidentInsure"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.dormBill"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.billSum"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.prePay"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.recomBill"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.cutManPay"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.cutCertifyPay"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.cutEduPay"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.memberSalary"/>
    										</td>
    										<td class="ColBody">
    											<s:property value="#rm.salaryRemark"/>
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
