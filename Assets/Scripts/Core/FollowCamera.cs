using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        // LateUpdate prevents camera jittering
        // in this instance, because with just update
        // it tries to wrestle itself to position simultaneously
        // as the animator updates (update === once per frame)
        // --> see unity docs for order of exec! 
        void LateUpdate()
        {
            transform.position = target.position;
        }
    }

}