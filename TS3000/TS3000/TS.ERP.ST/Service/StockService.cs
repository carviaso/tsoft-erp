using TS.ERP.ST.Dao;

namespace TS.ERP.ST.Service
{
    public class StockService 
    {
        private StockDao maDao;

        private static string SQL_LIST = "";

        public StockService()
        {
            maDao = new StockDao();
           
        }




        internal static System.Data.DataTable GetDataByCondition(Sys.Platform.Business.Util.Condition condition)
        {
            throw new System.NotImplementedException();
        }
    }
}
