using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.ERP.Business
{
    public class MoneyCaculateService
    {
        /// <summary>
        /// 商品金额计算
        /// 公式：商品金额=商品单价*数量*折扣
        /// </summary>
        /// <param name="unitePrice">商品单价</param>
        /// <param name="discount">折扣</param>
        /// <param name="num">数量</param>
        /// <returns></returns>
        public Decimal MateriaMoneySumCaculate(decimal unitePrice, decimal discount, int num)
        {
            return unitePrice * (discount/100) * num;
        }
    }
}
