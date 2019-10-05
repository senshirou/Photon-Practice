using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace PhotonPractice{
public class HarukoMove : MonoBehaviourPunCallbacks {

	//垂直・水平方向を取得
	float moveX;
	float moveZ;

	//移動スピードを設定
	float speed = 2f;

	//プレイヤーポジションの設定
	Vector3 Player_Pos;

	// Use this for initialization
	void Start () {

		//transform.positionのコンポーネントを取得。
		Player_Pos = GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {

		//所有者でないならfalse。生成者が操作可能。
		if( photonView.IsMine == false ){

			return;
		}

		//水平・垂直方向のステータスを指定
		moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		//プレイヤーの座標。
		transform.position += new Vector3(moveX,0,moveZ);

		//現在位置とプレイヤーポジション（わずかに変化する）。
		Vector3 diff = transform.position - Player_Pos;

		//ベクトルの長さが0.01fの場合、diffと同じ方向に回転する。
		if(diff.magnitude > 0.01f)
		{
			transform.rotation = Quaternion.LookRotation(diff);
		}

		//プレイヤーポジションを現在位置と同じにする。
		Player_Pos = transform.position;
	}

	
}

}
