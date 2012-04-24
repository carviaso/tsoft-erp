using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Dao;
using TS.PRS.MemberMan.Info;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Exceptions; 

namespace TS.PRS.MemberMan.Service
{
    public class MembersService : AbstractBaseService
    {
        private MembersDao memDao;
        public MembersService()
        {
            memDao = new MembersDao();
            base.Daos = memDao;
        }

         

        public override void Add(BaseInfo baseInfo)
        {
            MembersInfo memInfo = (MembersInfo)baseInfo;
            ValidationForId(memInfo);
            if (memInfo.cRecomMember == null||string.IsNullOrEmpty(memInfo.cRecomMember.ToString()))
                memInfo.cRecomMember = "000000";
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(memDao.GetAddMemberCommand(memInfo));
            commands.Add(memDao.AddRecommend(memInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);

        }

        /// <summary>
        /// 修改会员
        /// 1、修改会员信息
        /// 2、修改会员更新字段（如果更新字段为null则不修改）
        /// 3、修改推荐人
        /// 4、修改推荐关系更新字段（如果更新字段为null则不修改）
        /// </summary>
        /// <param name="baseInfo"></param>
        public override void Modify(BaseInfo baseInfo)
        { 
            MembersInfo memInfo = (MembersInfo)baseInfo;
            ValidationForId(memInfo);
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(memDao.GetModifyMemberCommand(memInfo));
            SqlCommand modifyStateCommand = memDao.GetModifyStateCommand(memInfo);
            if (modifyStateCommand != null)
            {
                commands.Add(modifyStateCommand);
            }
            if (memInfo.cRecomMember != null && !string.IsNullOrEmpty(memInfo.cRecomMember.ToString()))
            {
                commands.Add(memDao.ModifyRecommend(memInfo));
                SqlCommand modifyRecomStateCommand = memDao.ModifyRecommendState(memInfo);
                if (modifyRecomStateCommand != null)
                {
                    commands.Add(modifyRecomStateCommand);
                }
            }
            DbSvr.GetDbService().UpdateInTransaction(commands);
             memDao.ModifyMember(memInfo);
        }

        /// <summary>
        /// 删除会员
        /// 1、校验会员是否有推荐关系，如果有则不能删除
        /// 2、删除会员信息
        /// 3、删除会员的推荐信息
        /// </summary>
        /// <param name="baseInfo"></param>
        public override void Delete(BaseInfo baseInfo)
        {
            MembersInfo memInfo = (MembersInfo)baseInfo;
            ValidaForRecomend(memInfo);
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(memDao.GetDelMemberCommand(memInfo));
            commands.Add(memDao.GetDelRecommCommand(memInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);
      
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            MembersInfo memInfo = (MembersInfo)baseInfo;
             memDao.ForbiddenMember(memInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            MembersInfo memInfo = (MembersInfo)baseInfo;
            memDao.ValueableMember(memInfo);
        }
        
        public void ValidationForId(MembersInfo memInfo)
        {
            ArrayList result = memDao.GetResultById(memInfo);
            if (result != null && result.Count > 0)
            {
                throw new BusinessException("["+memInfo.cId+"]"+ExceptionConst.Error_IdExits);
            }
        }

        private void ValidaForRecomend(MembersInfo memInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cCode",memInfo.cCode);
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from MEM_MemberRecommend where cRecommendCode = @cCode", con);
            if (result != null && result.Count > 0)
            {
                throw new BusinessException("该会员存在推荐关系，不能被删除！");
            }
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            return memDao.GetResultList(con);
        }

        public ArrayList GetMaxCode()
        {
            return memDao.GetMaxCode();
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            return memDao.GetDataTable(con);
        }  
       
    }
}
