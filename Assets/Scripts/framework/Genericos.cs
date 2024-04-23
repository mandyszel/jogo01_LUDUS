using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ludus.SDK.Framework
{
    public class Genericos : MonoBehaviour
    {

        public void CarregarCena(string Menu)
        {
            SceneManager.LoadScene(Menu);
        }


        public void CarregarCenaFase(string Menu)
        {
            Controle.configuracao = null;
            this.CarregarCena(Menu);
        }
    }


}

