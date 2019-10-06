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

		Photon.Realtime.Player player = PhotonNetwork.LocalPlayer;
		if(player.ActorNumber == 1)
		{
			GameObject avatar = PhotonNetwork.Instantiate("OVRCameraRig2",new Vector3(0,1.5f,0),Quaternion.identity);
			avatar.transform.parent = transform;

		}

		else
		{
			GameObject avatar = PhotonNetwork.Instantiate("OVRCameraRig2",new Vector3(3.33f,1.5f,0),Quaternion.identity);
			avatar.transform.parent = transform;

		}
		
		
		
	}

	
}

}
