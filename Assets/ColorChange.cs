using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;


public class ColorChange : MonoBehaviourPunCallbacks {

	//色表示用時間
	float time;

	//カウントアップ
	float CountUp;

	//テキストを表示
	[SerializeField] Text CountUpText;

	void Update () {

		time += Time.deltaTime;
		CountUp += Time.deltaTime;
		

		//マスタークライアントだった場合実行。
		if(PhotonNetwork.IsMasterClient)
		{
			var properties = new ExitGames.Client.Photon.Hashtable();　//変数propertiesをインスタンス化
			properties.Add("TimeCount",CountUp);
			if(time >= 1f)
			{
				
				properties.Add("CubeColor",new Vector3(Random.value,Random.value,Random.value));　//名前(string),情報を入れる
				PhotonNetwork.CurrentRoom.SetCustomProperties(properties); //Photonのプロパティーに格納
				time = 0;
			}
		}
	}

	//ルームプロパティの情報を取得・出力する。
	public override void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable changedProperties)
	{
		//ルームプロパティから床の色を取得
		object value = null; 
		
		if(changedProperties.TryGetValue("CubeColor",out value))　//格納したときにつけた名前,(out 変数)で格納する。
		{
			Vector3 color = (Vector3)value; //Vector3型に変換
			this.GetComponent<Renderer>().material.color = new Color(color.x,color.y,color.z);
		}

		//経過時間を共有
		object TimeCountUp　= null;
		if(changedProperties.TryGetValue("TimeCount",out TimeCountUp))
		{
			float cup = (float)TimeCountUp;　//float型に変換
			CountUpText.text = cup.ToString("F2");
		}
		

	}
}
