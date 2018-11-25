using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat3
{
    class Amy
    {
        public GetSecretIngredient MySecretIngredient
        {
            get
            {
                return new GetSecretIngredient(AmySecretIngrediens);
            }
        }
        private string AmySecretIngrediens(int amount)
        {
            if(amount < 10)
            return amount.ToString() + " puszek sardynek --- potrzebujesz więcej!";
            else
            return amount.ToString() + " puszek sardynek";
        }
    }
}
