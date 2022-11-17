using UnityEngine;
using UnityEngine.SceneManagement;

class UserData
{

    public static int QT_play = 0;

}

public class MenuPrincipalManager : MonoBehaviour
{

    [SerializeField] private string nomeDoLevelDeJogo;
    //[SerializeField] private string nomeDoLevelDeJogo2;
    //[SerializeField] private string nomeDoLevelDeJogo3;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelOpcoesJogo;

    public void Jogar()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoesJogo.SetActive(true);
    }
    public void FecharJogar()
    {
        painelOpcoesJogo.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void Jogar1()
    {
        UserData.QT_play = 2;
        SceneManager.LoadScene("BombermanMapCeub2P");

    }
    public void Jogar2()
    {
        UserData.QT_play = 3;
        SceneManager.LoadScene("BombermanMapCeub3P");
    }
    public void Jogar3()
    {
        UserData.QT_play = 4;
        SceneManager.LoadScene("BombermanMapCeub");
    }
    public void Default()
    {
        SceneManager.LoadScene("Bomberman");
    }
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
