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
			GameObject avatar = PhotonNetwork.Instantiate("Haruko",new Vector3(0,0.01f,0),Quaternion.identity);
			avatar.transform.parent = transform;

		}

		else
		{
			GameObject avatar = PhotonNetwork.Instantiate("Haruko",new Vector3(3.33f,0.5f,0),Quaternion.identity);
			avatar.transform.parent = transform;

		}
		
		
		
	}

	
}

}
