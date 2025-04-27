using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SharpMonoInjectorSimpleExample
{
    public class Loader : MonoBehaviour
    {
        private void OnGUI()
        {
            var style = new GUISkin();
            style.label.fontStyle = FontStyle.BoldAndItalic;
            GUI.contentColor = new Color(120, 40, 84);
            GUI.Label(new UnityEngine.Rect(10, 10, 200, 40), "It's Just Example!!! Nothing Much!!!");
        }
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Insert))
            {
                Example.Unload();
            }
            if (Input.GetKeyUp(KeyCode.Delete))
            {
                Environment.Exit(43);
            }
        }
    }
}
