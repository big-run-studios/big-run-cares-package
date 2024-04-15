using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Blackjack
{
    public class BlackjackGameManager : MonoBehaviour
    {
        [SerializeField]
        TMPro.TextMeshProUGUI lastUserActionText;

        // Start is called before the first frame update
        void Start()
        {
            lastUserActionText.text = "<no action>";
        }

        // Update is called once per frame
        void Update()
        {

        }

        // // //

        public void UserDraw()
        {
            lastUserActionText.text = "Hit";
        }

        public void UserStand()
        {
            lastUserActionText.text = "Stand";
        }
    }
}
