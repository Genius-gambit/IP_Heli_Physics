using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IndiePixel
{
    public class IP_Helicopter_Menus : MonoBehaviour
    {
        [MenuItem("Indie Pixel/Vehicles/Setup New Helicopter")]
        public static void BuildNewHelicopter()
        {
            // Create a new Helicopter Setup
            GameObject curHeli = new GameObject("New_Helicopter", typeof(IP_Heli_Controller));


            // Create the COG object for the Helicopter
            GameObject curCOG = new GameObject("COG");
            curCOG.transform.SetParent(curHeli.transform);

            // Assign the COG to the curHeli
            IP_Heli_Controller curController = curHeli.GetComponent<IP_Heli_Controller>();
            curController.cog = curCOG.transform;

            //Create Groups
            GameObject audioGRP = new GameObject("Audio_GRP");
            GameObject graphics_GRP = new GameObject("Graphics_GRP");
            GameObject col_GRP = new GameObject("Collision_GRP");

            audioGRP.transform.SetParent(curHeli.transform);
            graphics_GRP.transform.SetParent(curHeli.transform);
            col_GRP.transform.SetParent(curHeli.transform);
            
            // Select New Helicopter
            Selection.activeGameObject = curHeli;
        }
    }
}
