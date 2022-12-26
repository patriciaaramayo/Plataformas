using UnityEngine;
using UnityEngine.UI;

public class HUDGame : MonoBehaviour
{

    public static int stars = 0;
    [SerializeField] Text starsText;

    [Header("Barra de vida")]
    public Image barraVida;
    public float vidaActual;
    public float maxVida = 5f;

    void Update()
    {
        starsText.text =  stars.ToString();
        vidaActual = PlayerLife.vidaJugador;
        barraVida.fillAmount = vidaActual / maxVida; 
    }

}