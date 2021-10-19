using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Cinemachine;

public class PhotonSystem : MonoBehaviourPunCallbacks
{

    public GameObject UI_Canvas_StarterAssetsInputs_Joysticks;
    public GameObject PlayerFollowCamera;

    public GameObject Player;

    private void Start()
    {

    }

    public void PopPlayer() 
    {
        // PhotonServerSettingsの設定内容を使ってマスターサーバーへ接続する
        PhotonNetwork.ConnectUsingSettings();
    }

    // マスターサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnConnectedToMaster()
    {
        // "Room"という名前のルームに参加する（ルームが存在しなければ作成して参加する）
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    // ゲームサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnJoinedRoom()
    {
        // ランダムな座標に自身のアバター（ネットワークオブジェクト）を生成する
        var position = new Vector3(Random.Range(0f, 3f), Random.Range(0f, 3f));
        Player = PhotonNetwork.Instantiate("PlayerArmature", position, Quaternion.identity);

        PlayerFollowCamera.GetComponent<CinemachineVirtualCamera>().Follow = Player.transform.Find("PlayerCameraRoot");

        UI_Canvas_StarterAssetsInputs_Joysticks.gameObject.SetActive(true);

    }

}
