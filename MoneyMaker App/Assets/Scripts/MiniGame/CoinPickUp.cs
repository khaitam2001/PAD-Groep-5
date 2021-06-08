using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MiniGame
{
    class CoinPickUp : BasePickUp
    {
        protected override void OnPickUp()
        {

            FindObjectOfType<MiniGameHUDController>().AddScore(1);

            base.OnPickUp();
        }
    }
}
