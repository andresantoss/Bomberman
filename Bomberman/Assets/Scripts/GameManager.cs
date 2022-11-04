using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject[] players;

    [SerializeField] public GameObject Jogador3;
    [SerializeField] public GameObject HudJogador3;
    [SerializeField] public GameObject Hud_Jogador3;
    [SerializeField] public GameObject Jogador4;
    [SerializeField] public GameObject HudJogador4;
    [SerializeField] public GameObject Hud_Jogador4;
    //[SerializeField] public string labelQT_play;
    public void Start(){
        // Aqui você já deve ter a referência do elemento text que exibirá o dado.
        // Exibe o nome do usuário armazenado.
        
        Debug.Log(UserData.QT_play);
        QTD_play(UserData.QT_play);
    }
    public void QTD_play(int QT_play)
    {
        if (QT_play == 2)
        {
            Jogador3.SetActive(false);
            HudJogador3.SetActive(false);
            Hud_Jogador3.SetActive(false);
            Jogador4.SetActive(false);
            HudJogador4.SetActive(false);
            Hud_Jogador4.SetActive(false);
            
        }
        if (QT_play == 3)
        {
            Jogador4.SetActive(false);
            HudJogador4.SetActive(false);
            Hud_Jogador4.SetActive(false);
        }
    }
    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf) {
                aliveCount++;
            }
        }

        if (aliveCount <= 1) {
            Invoke(nameof(NewRound), 3f);
        }
    }

    private void NewRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}