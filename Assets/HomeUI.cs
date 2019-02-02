using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
