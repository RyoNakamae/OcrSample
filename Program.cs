using System;
using System.Configuration;
using Patagames.Ocr;
using Patagames.Ocr.Enums;

namespace OcrSample
{
    class Program
    {

        /// <summary>
        /// 指定された画像ファイルから文字列を読み出して出力してみるサンプル
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ファイルパス
            var filePath = ConfigurationManager.AppSettings["FilePath"];

            try
            {
                using (var api = OcrApi.Create())
                {
                    //言語選択：とりあえず日本語
                    api.Init(Languages.Japanese);

                    //読み出す
                    var text = api.GetTextFromImage(filePath);

                    //コンソールに出力
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
