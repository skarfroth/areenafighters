using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BeginPressed()
    {
        SceneManager.LoadScene("CharacterCreation");
    }
}
