using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.Sys.Domain
{
    public partial class ExceptionConst
    {

        #region 系统错误

        
        /// <summary>
        /// 您输入了无效的数字，请重新输入！
        /// </summary>
        public static string Error_Number = "您输入了无效的数字，请重新输入！";
        /// <summary>
        /// 该身份证号已经注册，请重新输入！
        /// </summary>
        public static string Error_IdExits = "该身份证号已经注册，请重新输入！";
        /// <summary>
        /// 为必填项！
        /// </summary>
        public static string Error_Require = "为必填项！";
        /// <summary>
        /// 没有找到注册模块,请检查菜单配置！
        /// </summary>
        public static string Error_Form = "没有找到注册模块,请检查菜单配置！";
        /// <summary>
        /// 对不起，您没有该操作的权限！
        /// </summary>
        public static string Error_Secu = "对不起，您没有该操作的权限！";
        #endregion
        /// <summary>
        /// 该单据已经被并发修改，请刷新！
        /// </summary>
        public static string Error_TimeStamp = "该单据已经被并发修改，请刷新！";
        /// <summary>
        /// 操作失败，该单据已经审核！
        /// </summary>
        public static string Error_Audit = "操作失败，该单据已经审核！";
        /// <summary>
        /// 操作失败，该单据未审核！
        /// </summary>
        public static string Error_UnAudit = "操作失败，该单据未审核！";
        /// <summary>
        /// 操作失败，该记录已禁用！
        /// </summary>
        public static string Error_Forbidden = "操作失败，该记录已禁用！";
        /// <summary>
        /// 操作失败，该记录已启用！
        /// </summary>
        public static string Error_Valueable = "操作失败，该记录已启用！";
        /// <summary>
        /// 没有记录可以删除！
        /// </summary>
        public static string Error_Del = "没有记录可以删除！";
        /// <summary>
        /// 没有记录可以查看！
        /// </summary>
        public static string Error_View = "没有记录可以查看！";
        /// <summary>
        /// 没有记录可以审核！
        /// </summary>
        public static string Error_NoAudit = "没有记录可以审核！";
        /// <summary>
        /// 
        /// 没有记录可以反审核！
        /// </summary>
        public static string Error_NoUnAudit = "没有记录可以反审核！";
    }
}
