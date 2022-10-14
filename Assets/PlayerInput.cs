using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public SceneChanger sceneChangerScript;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sceneChangerScript.CambiarDeEscenaSecuencialmente();
        }
    }
}
