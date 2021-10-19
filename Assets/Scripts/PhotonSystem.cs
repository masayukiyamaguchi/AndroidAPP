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
        // PhotonServerSettings�̐ݒ���e���g���ă}�X�^�[�T�[�o�[�֐ڑ�����
        PhotonNetwork.ConnectUsingSettings();
    }

    // �}�X�^�[�T�[�o�[�ւ̐ڑ��������������ɌĂ΂��R�[���o�b�N
    public override void OnConnectedToMaster()
    {
        // "Room"�Ƃ������O�̃��[���ɎQ������i���[�������݂��Ȃ���΍쐬���ĎQ������j
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    // �Q�[���T�[�o�[�ւ̐ڑ��������������ɌĂ΂��R�[���o�b�N
    public override void OnJoinedRoom()
    {
        // �����_���ȍ��W�Ɏ��g�̃A�o�^�[�i�l�b�g���[�N�I�u�W�F�N�g�j�𐶐�����
        var position = new Vector3(Random.Range(0f, 3f), Random.Range(0f, 3f));
        Player = PhotonNetwork.Instantiate("PlayerArmature", position, Quaternion.identity);

        PlayerFollowCamera.GetComponent<CinemachineVirtualCamera>().Follow = Player.transform.Find("PlayerCameraRoot");

        UI_Canvas_StarterAssetsInputs_Joysticks.gameObject.SetActive(true);

    }

}
