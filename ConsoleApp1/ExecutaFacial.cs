using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using NGT.Fcc.Framework.Core.Cognitivos.ReconhecimentoFacial;

namespace ConsoleApp1
{
    public static class ExecutaFacial
    {
        // <snippet_image_url>
        // Used for all examples.
        // URL for the images.
        const string IMAGE_BASE_URL = "https://csdx.blob.core.windows.net/resources/Face/Images/";
        // </snippet_image_url>

        // <snippet_creds>
        // From your Face subscription in the Azure portal, get your subscription key and endpoint.
        const string SUBSCRIPTION_KEY = "d11fb6c4b9f24768b0bfd401ed4b1b05";
        const string ENDPOINT = "https://testeapiface.cognitiveservices.azure.com/";
        // </snippet_creds>

        public static void Executa()
        {

            const string RECOGNITION_MODEL3 = RecognitionModel.Recognition03;
            IFaceClient client = Facial.Autenticacao(ENDPOINT, SUBSCRIPTION_KEY);
            var retfacial = Facial.IdentificaFaceExtraiDados(client, IMAGE_BASE_URL + "detection1.jpg", RECOGNITION_MODEL3).Result;

            bool ret = Facial.ComparaFotos(client, IMAGE_BASE_URL + "detection1.jpg", IMAGE_BASE_URL + "detection2.jpg", RECOGNITION_MODEL3).Result;

        }
    }
}
