using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


namespace PhotonPractice{
public class HarukoPhoton : MonoBehaviourPunCallbacks {

	public override void OnJoinedRoom()
	{

		//ルームログイン後に呼ぶ
		CreateAvatar();

	}

	void CreateAvatar()
	{
		Debug.Log("アバター生成");

		

		if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
		{
			GameObject avatar = PhotonNetwork.Instantiate("OVRCameraRig3",new Vector3(0,1.5f,0),Quaternion.identity);
			avatar.transform.parent = transform;

			GameObject camera = transform.Find("Camera").gameObject;
			//GameObject cameracenter = transform.Find("TrackingSpace").gameObject;
			camera.transform.position = new Vector3(0,1.5f,0);
			//camera.transform.parent = cameracenter.transform;
			camera.transform.parent = avatar.transform;
		}

		else
		{
			GameObject avatar = PhotonNetwork.Instantiate("OVRCameraRig3",new Vector3(3,1.5f,0),Quaternion.identity);
			avatar.transform.parent = transform;

			GameObject camera = transform.Find("Camera").gameObject;
			//GameObject cameracenter = transform.Find("TrackingSpace").gameObject;
			camera.transform.position = new Vector3(3,1.5f,0);
			//camera.transform.parent = cameracenter.transform;
			camera.transform.parent = avatar.transform;
		}


		
			
			

		
		
		
	}

	
}

}
