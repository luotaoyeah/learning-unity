using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3(0, 1, 0);
            enemy.transform.Rotate(0, Random.Range(0, 360), 0);
        }
    }
}
