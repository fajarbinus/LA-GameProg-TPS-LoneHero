using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior GameManager;
    void Start()
    {
        //3.4 ini untuk mendapatkan GameBehavior dari nama game object Game Manager
        GameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item Collected");
            //3.4 - condition ini untuk collect item ketika tabrakan
            if (GameManager != null) GameManager.Items += 1;
        }
    }
}
