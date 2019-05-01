namespace PlayoVR {
    using UnityEngine;

    public class SpeakerIconManager : MonoBehaviour {
        [Tooltip("The sprite that will be shown when the associated player is not talking")]
        public Sprite NotTalking;
        [Tooltip("The sprite that will be shown when the associated player is talking")]
        public Sprite Talking;
        [Tooltip("The time in seconds to switch back from Talking to Not Talking")]
        public int SwitchBackDelay = 2;
        [Tooltip("The time in seconds to remove the icon completely. Set to -1 to always keep showing the icon")]
        public int InactiveDelay = 3;
        [Tooltip("The voice to listen to")]

        private SpriteRenderer spriteRenderer;
        private float lastTimeTalking;

        void Awake() {
       
        }

        void Update() {
         
        }
    }
}
