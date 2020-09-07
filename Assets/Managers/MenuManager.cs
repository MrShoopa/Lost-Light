using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartButton, CreditsButton, ExitButton, BackCreditsButton, CreditsText, HelpBackButton, HelpButton, HelpText;
    public void startClicked()
    {
        SceneManager.LoadScene("Level1");
    }
    public void creditsClicked()
    {
        BackCreditsButton.SetActive(true);
        CreditsText.SetActive(true);
        StartButton.SetActive(false);
        CreditsButton.SetActive(false);
        ExitButton.SetActive(false);
        HelpButton.SetActive(false);
    }
    public void creditsBackClicked()
    {
        BackCreditsButton.SetActive(false);
        CreditsText.SetActive(false);
        StartButton.SetActive(true);
        CreditsButton.SetActive(true);
        ExitButton.SetActive(true);
        HelpButton.SetActive(true);
    }
    public void helpClicked()
    {
        HelpText.SetActive(true);
        HelpBackButton.SetActive(true);
        StartButton.SetActive(false);
        CreditsButton.SetActive(false);
        ExitButton.SetActive(false);
        HelpButton.SetActive(false);
    }
    public void helpBackClicked()
    {
        HelpText.SetActive(false);
        HelpBackButton.SetActive(false);
        StartButton.SetActive(true);
        CreditsButton.SetActive(true);
        ExitButton.SetActive(true);
        HelpButton.SetActive(true);
    }
    public void quitClicked()
    {
        Application.Quit();
    }
}
