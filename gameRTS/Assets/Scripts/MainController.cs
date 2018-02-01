using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace globalVariables
{
    public class MainController : MonoBehaviour
    {
        private void LateUpdate()
        {
            if (Input.GetButton("Fire3"))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = false;
            }
            else
            {
                Cursor.visible = true;
            }
        }
    }
}