using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public TMP_Text UIcharacterName;
    public Character character;

    private void Start()
    {
        character = GameObject.Find("Character").GetComponent<Character>();
        UIcharacterName.text = character.fullName;
    }
}
