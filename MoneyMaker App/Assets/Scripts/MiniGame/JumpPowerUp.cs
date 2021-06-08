using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MiniGame
{
    class JumpPowerUp : BasePickUp
    {
        protected override void OnPickUp()
        {

            FindObjectOfType<PlayerController>().JumpUpgrade();

            base.OnPickUp();
        }
    }
}
