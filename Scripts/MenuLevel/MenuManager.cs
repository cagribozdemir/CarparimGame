using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPanel.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);
    }

    public void IkinciLeveleGec()
    {
        SceneManager.LoadScene("IkinciMenuLevel");
    }

    public void AyarlariYap()
    {
        //daha sonra
    }

    public void OyundanCik()
    {
        Application.Quit();
    }
}
