using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{

    public void CambiarEscena(int numeroEscena)
    {
        SceneManager.LoadScene(numeroEscena);
    }
}
