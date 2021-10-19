using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {
        [Header("Output")]
        public StarterAssetsInputs starterAssetsInputs;
        private GameObject Player;

        private void Start()
        {
            Player = GameObject.Find("PhotonSystem").GetComponent<PhotonSystem>().Player;
            starterAssetsInputs = Player.gameObject.GetComponent<StarterAssetsInputs>();
        }

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterAssetsInputs.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            starterAssetsInputs.LookInput(virtualLookDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            starterAssetsInputs.JumpInput(virtualJumpState);
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
            starterAssetsInputs.SprintInput(virtualSprintState);
        }

        public void VirtualTestInput(bool virtualTestState)
        {
            starterAssetsInputs.TestInput(virtualTestState);
        }

    }

}
