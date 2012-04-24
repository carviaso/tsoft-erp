using System;

namespace TS.Sys.Domain
{
    public class SysConst
    {
        #region 执行标示
        /// <summary>
        /// 执行成功
        /// </summary>
        public static int exeSucess = 1;

        /// <summary>
        /// 执行失败
        /// </summary>
        public static int exeFaild = 0;

        public static String modifySucess = "更新成功";

        public static String modifyFaild = "更新失败";

        public static String deleteSucess = "删除成功";

        public static String deleteFaild = "删除失败";

        public static String insertSucess = "插入成功";

        public static String insertFaild = "插入失败";

        public static String forbidSuccess = "禁用成功";

        public static String forbidFaild = "禁用失败";

        public static String valueSucess = "启用成功";

        public static String valueFaild = "启用失败";

        public static String auditSucess = "审核成功";

        public static String auditFaild = "审核失败";

        public static String unauditSucess = "反审核成功";

        public static String unauditFaild = "反审核失败";
        #endregion

        #region 提示框内容
        /// <summary>
        /// 天时提示
        /// </summary>
        public static String msgBoxTitle = "天时提示";
        /// <summary>
        /// 页面数据发生变动，是否保存？
        /// </summary>
        public static String msgDataChange = "页面数据发生变动，是否保存？";
        /// <summary>
        /// 是否确认删除该单据？
        /// </summary>
        public static String msgDeleteConfirm = "是否删除";
        /// <summary>
        /// 单据号重复，添加失败
        /// </summary>
        public static String msgAddFaildForCodeExists = "单据号重复，添加失败！"; 
        /// <summary>
        /// 删除失败
        /// </summary>
        public static String msgDeleteFaild = "删除失败！";
        /// <summary>
        /// 删除成功
        /// </summary>
        public static String msgDeleteSuccess = "删除成功！";

        /// <summary>
        /// 审核成功
        /// </summary>
        public static String msgAuditSuccess = "审核成功！";
        /// <summary>
        /// 反审核成功
        /// </summary>
        public static String msgUnAuditSuccess = "反审核成功！";
        /// <summary>
        /// <summary>
        /// 保存成功
        /// </summary>
        public static String msgSaveSuccess = "保存成功！";
        /// <summary>
        /// 保存失败
        /// </summary>
        public static String msgSaveFailed = "保存失败！";
        /// <summary>
        /// 是否禁用该单据
        /// </summary>
        public static String msgForbiddenConfirm = "是否禁用";
        /// <summary>
        /// 禁用成功
        /// </summary>
        public static String msgForbiddenSuccess = "禁用成功！";

        /// <summary>
        /// 是否启用该单据
        /// </summary>
        public static String msgValueableConfirm = "是否启用";
        /// <summary>
        /// 启用成功
        /// </summary>
        public static String msgValueableSuccess = "启用成功！";

        /// <summary>
        /// 已是最后一条记录
        /// </summary>
        public static String msgLastPage = "已是最后一条记录！";
        /// <summary>
        /// 已是第一条记录
        /// </summary>
        public static String msgFirstPage = "已是第一条记录！";
        /// <summary>
        /// 该单据已经发生并发修改，不能进行操作，请刷新！
        /// </summary>
        public static String msgTimeStamp = "该单据已经发生并发修改，不能进行操作，请刷新！";
        /// <summary>
        /// 该单据已审核不能再次审核！
        /// </summary>
        public static String msgAudit = "审核失败，该单据已审核！";
        /// <summary>
        /// 该单据已审核不能再次审核！
        /// </summary>
        public static String msgUnAudit = "反审核失败，该单据还未审核！";
        #endregion
        
        #region 财务
        /// <summary>
        /// 请选择支出类型
        /// </summary>
        public static String msgFaCostTypeIsNull = "请选择支出类型！";

        public static String msgFaPayAmtIsNull = "请输入付款金额！";
        #endregion
    }
}
