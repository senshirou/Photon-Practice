using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class OculusPhoton : MonoBehaviourPunCallbacks
{
   [SerializeField] OVRCameraRig cameraRig;
   [SerializeField] OVRManager oVR;

   [SerializeField] OVRHeadsetEmulator oVRHeadset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( photonView.IsMine == false ){

			return;
		}

        cameraRig.enabled = true;
        oVR.enabled = true;
        oVRHeadset.enabled = true;

        
        
    }
}
