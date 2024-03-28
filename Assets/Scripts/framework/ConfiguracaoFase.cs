using UnityEngine;
namespace Ludus.SDK.Framework
{

    public class ConfiguracaoFase : Configuracao
    {


        public override void CarregarConfiguracao(GameObject novoPainelGeral)
        {
            //se é a primeira vez que chama a cena
            if (inicial)
            {
                acertosFase = 0;
            }
            base.CarregarConfiguracao(novoPainelGeral);


        }

        protected override void CarregarPaineis()
        {
            string prefabsombra;
            if (this.conteudoauxiliar)
            {
                prefabsombra = sombraauxiliar;
            }
            else
            {
                prefabsombra = "sombra";
            }

            for (int i = 0; i < niveis[nivelAtual].quantidadeElementos; i++)
            {
                AdicionarPrefab("objeto", painelObjeto);
                AdicionarPrefab(prefabsombra, painelSombra);
            }

        }

        public override void CarregarCena()
        {
            acertosFase = 0;


            base.CarregarCena();

        }

        public override void AtualizarAcerto()
        {
            acertosFase++;
            if (acertosFase == niveis[nivelAtual].quantidadeElementos)
            {
                base.AtualizarAcerto();
            }
        }


    }

}



