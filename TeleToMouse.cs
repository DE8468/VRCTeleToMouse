using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace TeleToMouse
{
    public class TeleToMouse : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.forward), out RaycastHit raycastHit))
                {
                    VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = raycastHit.point;
                }
            }
        }
    }
}
