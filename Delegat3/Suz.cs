using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat3
{
    class Suz
    {
        public GetSecretIngredient MySecretIngredient
        {
            get
            {
                return new GetSecretIngredient(SuzanesSecretIngrediens);
            }
        }
        private string SuzanesSecretIngrediens(int amount)
        {
            return amount.ToString() + " dekagramy goździków";
        }

    }
}
