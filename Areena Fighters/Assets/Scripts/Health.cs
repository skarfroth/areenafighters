using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public FightController fightController;
    public int maxHealth;
    public int currentHealth;
    SpriteRenderer spriteRenderer;
    Material originalMat;
    public Material flashMat;
    public TMP_Text hpText;

    private void Start()
    {
        currentHealth = maxHealth;
        fightController = GameObject.Find("GameController").GetComponent<FightController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalMat = spriteRenderer.material;
    }

    private void Update()
    {
        hpText.text = currentHealth.ToString();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        spriteRenderer.material = flashMat;
        Invoke(nameof(SetDefaultMat), 0.125f);
    }

    private void SetDefaultMat()
    {
        spriteRenderer.material = originalMat;
    }
}
