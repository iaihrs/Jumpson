using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using HarmonyLib;
using System.Reflection;

namespace Jumpson
{
    public class JumpsonClass : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Type jump = typeof(PlayerMovement);
                FieldInfo jumpForce = jump.GetField("jumpForce", BindingFlags.NonPublic | BindingFlags.Instance);
                jumpForce.SetValue(PlayerMovement.Instance, 1500);
            }
        }
    }
}
