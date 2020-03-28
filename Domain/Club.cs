using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Club
    {
        private readonly IMember _member;
        public Club(IMember member)
        {
            this._member = member;
        }
        public double ShippingCalculate(int memberID)
        {
            double ShippingValueMember = 0;
            Member member = _member.GetMember(memberID);
            ShippingValueMember = 10 + member.Limit * 0.8;
            return ShippingValueMember;
        }
    }
}
