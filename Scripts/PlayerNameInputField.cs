using UnityEngine;
using UnityEngine.UI;


using Photon.Pun;
using Photon.Realtime;


using System.Collections;


namespace Imagication
{
    /// <summary>
    /// Player name input field. Let the user input his name, will appear above the player in the game.
    /// </summary>
    [RequireComponent(typeof(InputField))]
    public class PlayerNameInputField : MonoBehaviour
    {
        #region Private Constants

        // Store the PlayerPref Key to avoid typos
        const string playerNamePrefKey = "PlayerName";
        public static bool locked = true;

        #endregion

        #region MonoBehaviour CallBacks

        /// <summary>
        /// MonoBehaviour method called on GameObject by Unity during initialization phase.
        /// </summary>
        void Start()
        {
            string defaultName = string.Empty;
            InputField _inputField = this.GetComponent<InputField>();
            if (_inputField != null)
            {
                if (PlayerPrefs.HasKey(playerNamePrefKey))
                {
                    // Set the input field value to the player name if it is saved, otherwise keep the default value
                    defaultName = PlayerPrefs.GetString(playerNamePrefKey);
                    _inputField.text = defaultName;
                }
            }
            PhotonNetwork.NickName = defaultName;
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Sets the name of the player, and save it in the PlayerPrefs for future sessions.
        /// </summary>
        /// <param name="value">The name of the Player</param>
        public void SetPlayerName(string value)
        {
            // #Important
            if (string.IsNullOrEmpty(value))
            {
                Debug.LogError("Player Name is null or empty");
                locked = true;
                return;
            }
            
            // Valid name
            locked = false;
            PhotonNetwork.NickName = value;
            PlayerPrefs.SetString(playerNamePrefKey, value);
        }
        #endregion
    }
}