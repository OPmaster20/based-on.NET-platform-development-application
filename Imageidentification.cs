using Project6App;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace com.baidu.ai
{
    public class Identification
    {
        

        public static string Call_model(string filepath)
        {
            try
            {
                var imageBytes = File.ReadAllBytes(filepath);
                MLModel.ModelInput sampleData = new MLModel.ModelInput()
                {
                    ImageSource = imageBytes,
                };

                //Load model and predict output
                var re = MLModel.Predict(sampleData);
                return re.PredictedLabel.ToString();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
           
        }
        

        public static string advancedGeneral(string name)
        {
            string token = "24.c76c121b6b658c1fae472f55df3591ec.2592000.1717523502.282335-67249547";
            string host = "https://aip.baidubce.com/rest/2.0/image-classify/v2/advanced_general?access_token=" + token;
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;

            string base64 = name;

            String str = "image=" + HttpUtility.UrlEncode(base64);
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            Console.WriteLine("通用物体和场景识别:");
            return result;
        }
    }
}