
using UnityEngine;

public class MazeGameManager : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    [SerializeField] Hole hole;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hole.Entered)
        {
            GameOver.SetActive(true);
        }
    }
}
