using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontStopAudio : MonoBehaviour
{
    public static DontStopAudio BGInstance;


    void Awake()
    {
        if(BGInstance != null && BGInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        BGInstance = this;
        DontDestroyOnLoad(this);



        //DontDestroyOnLoad(transform.gameObject);
    }

}



