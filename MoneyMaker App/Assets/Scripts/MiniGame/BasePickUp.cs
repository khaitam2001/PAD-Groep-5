using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MiniGame
{
    class BasePickUp : MonoBehaviour
    {

        protected virtual void OnPickUp()
        {

        }

        void OnTriggerEnter2D(Collider2D col)
        {
            //checks collision with the player
            if (col.gameObject.CompareTag("Player"))
            {
                OnPickUp();
                Destroy(gameObject);
            }
        }
    }
}
