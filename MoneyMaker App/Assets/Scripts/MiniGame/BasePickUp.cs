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

            if (col.gameObject.name == "Player")
            {
                OnPickUp();
                Destroy(gameObject);
            }
        }
    }
}
