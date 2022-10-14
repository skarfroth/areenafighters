using UnityEngine;

public class Character : MonoBehaviour
{
    public string fullName;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
