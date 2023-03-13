using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Host_transfers
{
    class Transfersfiles
    {


        public void TranferFile()
        {

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users", Method.Get);
            var response = client.Execute(request);
            // MessageBox.Show(response.Content.ToString());
            // Console.WriteLine(response.Content);
            //

            /*Category c = JsonConvert.DeserializeObject<Category>(response.Content)*/

            var UserList = JsonConvert.DeserializeObject<Users>(response.Content);

            foreach(User key in UserList.usuarios)
            {

                MessageBox.Show(key.name);

            }

      

        }


        public void TranferFileDirect()
        {
            /*
             xample for upload file with resharp
            RestClient restClient = new RestClient("http://stackoverflow.com/");
            RestRequest restRequest = new RestRequest("/images");
            restRequest.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "Bearer my-token");
            restRequest.Method = Method.Post;
            restRequest.AddHeader("Authorization", "Authorization");
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddFile("content", imageFullPath);
            var response = restClient.Execute(restRequest);
            */
        }
    }
}
