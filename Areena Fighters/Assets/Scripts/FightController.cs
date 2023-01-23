using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FightController : MonoBehaviour
{
    public Button fightButton, attackButton, restartButton;
    public TMP_Text playerWin, enemyWin, playerHP, enemyHP;
    public GameObject playerObj, enemyObj;

    private void Update()
    {
        if (playerObj.GetComponent<Health>().currentHealth <= 0)
        {
            EnemyWin();
        }
        if (enemyObj.GetComponent<Health>().currentHealth <= 0 && playerObj.GetComponent<Health>().currentHealth > 0)
        {
            PlayerWin();
        }
        if (enemyObj.GetComponent<Health>().currentHealth <= 0 && playerObj.GetComponent<Health>().currentHealth <= 0)
        {
            EnemyWin();
        }
    }
    public void FightPressed()
    {
        fightButton.gameObject.SetActive(false);
        playerObj.SetActive(true);
        enemyObj.SetActive(true);
        attackButton.gameObject.SetActive(true);
        playerHP.gameObject.SetActive(true);
        enemyHP.gameObject.SetActive(true);
    }

    public void AttackPressed()
    {
        playerObj.GetComponent<Health>().TakeDamage(Random.Range(1, 5));
        enemyObj.GetComponent<Health>().TakeDamage(Random.Range(1, 5));
    }

    public void PlayerWin()
    {
        playerWin.gameObject.SetActive(true);
        attackButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
    }

    public void EnemyWin()
    {
        enemyWin.gameObject.SetActive(true);
        attackButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartPressed()
    {
        Destroy(GameObject.FindGameObjectWithTag("Character"));
        SceneManager.LoadScene(0);
    }
}
