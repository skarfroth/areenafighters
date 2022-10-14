using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour
{
    public TMP_Text characterText;
    public CharacterNames characterNames;
    public Character character;
    string firstName, lastName, title;

    void Start()
    {
        characterNames = characterNames.GetComponent<CharacterNames>();
        int raceRoll = Random.Range(0, 3);
        if (raceRoll == 0)
        {
            CreateHumanName();
        }
        else if (raceRoll == 1)
        {
            CreateSkeletonName();
        }
        else { CreateZombieName(); }

        CreateCharacter();
    }

    void CreateHumanName()
    {
        firstName = characterNames.humanFirstName[Random.Range(0, characterNames.humanFirstName.Length)];
        lastName = characterNames.humanLastName[Random.Range(0, characterNames.humanLastName.Length)];
        title = characterNames.humanTitle[Random.Range(0, characterNames.humanTitle.Length)];
    }

    void CreateSkeletonName()
    {
        firstName = characterNames.skeletonFirstName[Random.Range(0, characterNames.skeletonFirstName.Length)];
        lastName = characterNames.skeletonLastName[Random.Range(0, characterNames.skeletonLastName.Length)];
        title = characterNames.skeletonTitle[Random.Range(0, characterNames.skeletonTitle.Length)];
    }

    void CreateZombieName()
    {
        firstName = characterNames.zombieFirstName[Random.Range(0, characterNames.zombieFirstName.Length)];
        lastName = characterNames.zombieLastName[Random.Range(0, characterNames.zombieLastName.Length)];
        title = characterNames.zombieTitle[Random.Range(0, characterNames.zombieTitle.Length)];
    }

    void CreateCharacter()
    {
        characterText.text = "You are <color=#9F0000>" + firstName + " " + lastName + " " + title + "</color> and you have come to the arena to prove your worth. You must now start an epic journey to become a <color=#9F0000>legendary warrior!</color>";
        character.fullName = string.Join(" ", firstName, lastName, title);
    }

    public void Reload()
    {
        SceneManager.LoadScene("CharacterCreation");
        Destroy(character.gameObject);
    }

    public void StartPressed()
    {
        SceneManager.LoadScene("Game");
    }
}
