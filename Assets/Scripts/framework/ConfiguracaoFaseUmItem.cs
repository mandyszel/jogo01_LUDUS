using JetBrains.Annotations;


namespace Ludus.SDK.Framework 
{ 
    public  class ConfiguracaoFaseUmItem:Configuracao
    {
    
 
   

        protected override void CarregarPaineis()
        {
            for (int i = 0; i < niveis[nivelAtual].quantidadeElementos; i++)
            {
                AdicionarPrefab("objeto", painelObjeto);
           
            }
            string prefabsombra;
            if (this.conteudoauxiliar)
            {
                prefabsombra = "sombraComAuxiliar";
            }
            else 
            {
                prefabsombra = "sombra";
            }
            AdicionarPrefab(prefabsombra, painelSombra);

        }


    }

}



