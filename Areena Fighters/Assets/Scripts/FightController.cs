using UnityEngine;
using UnityEngine.UI;

public class FightController : MonoBehaviour
{
    public Button fightButton, attackButton;
    public GameObject playerObj, enemyObj;

    public void FightPressed()
    {
        fightButton.gameObject.SetActive(false);
        playerObj.SetActive(true);
        enemyObj.SetActive(true);
        attackButton.gameObject.SetActive(true);
    }

    public void AttackPressed()
    {
        playerObj.GetComponent<Health>().TakeDamage(Random.Range(1, 5));
        enemyObj.GetComponent<Health>().TakeDamage(Random.Range(1, 5));
    }
}
