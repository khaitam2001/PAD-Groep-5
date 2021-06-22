using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MiniGame
{
    class CoinPickUp : BasePickUp
    {
        [SerializeField] private int scoreToAdd;

        protected override void OnPickUp()
        {
            //adds score
            FindObjectOfType<MiniGameHUDController>().AddScore(scoreToAdd);
            SoundManagerScript.PlaySound("coinPickedUp");
            base.OnPickUp();
        }
    }
}
