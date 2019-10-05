using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

namespace PhotonPractice{

public class PhotonStatus : MonoBehaviour {

	[SerializeField] PhotonLogin PLog;


	void OnGUI()
	{
		//Photonとの接続状況を表示する
		string status = PhotonNetwork.NetworkClientState.ToString()+"\n";

		//ルームに入室したら部屋の状況を表示する
		if(PhotonNetwork.InRoom)
		{
			//ルームの名前
			status += "RoomName :" + PhotonNetwork.CurrentRoom.Name + "\n";
			//プレイヤー数
			status += "PlayerNumber :" + PhotonNetwork.CurrentRoom.PlayerCount + "\n";
			//ニックネーム
			status += "NickName :" + PhotonNetwork.NickName + "\n";
			//プレイヤーナンバー
			status += "PlayerNo :" + PhotonNetwork.LocalPlayer.ActorNumber + "\n";
			//ルームマスターの判定
			status += "IsMasterClient :" + PhotonNetwork.IsMasterClient;
			//ゲームバージョン
			status += "GameStatus :" + PhotonNetwork.GameVersion + "\n";
			//サーバーのタイプ
			status += "ServerType :" + PhotonNetwork.Server + "\n";
			//現在ルームを探しているプレイヤーの数
			status += "CountOfPlayersOnMaster :" + PhotonNetwork.CountOfPlayersOnMaster + "\n";
			
		}

		GUI.TextField(new Rect(10,10,400,140),status);

	}
}


}
