using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Chamador_New.Model
{
    public class Music_Class
    {
        public static byte valid = 0;
        private static int cont = 1;


        public Music_Class(byte tipo)
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            switch (tipo)
            {
                case (1): myPlayer.SoundLocation = @"C:\Programa\sinal1.wav";
                    break;
                case (2): myPlayer.SoundLocation = @"C:\Programa\sinal4.wav";
                    break;
            }
            myPlayer.Play();
        }

        /* public Music_Class(string nome,string senha, string terminal)
         {
             string path = @"C:\Users\User\Desktop\Tela Principal\audio"+cont+".mp3", fileName = null,senha_int=null;
             if (!System.IO.Directory.Exists(path))
             {
                 System.IO.File.Delete( @"C:\Users\User\Desktop\Tela Principal\audio"+(cont-1)+".mp3");
             }
             string myStringWebResource = null;
             switch (senha.Substring(1,1))
             {
                 case ("1"): senha_int = senha.Substring(0, 1) + " " + senha.Substring(1, 3); break;
                 case ("0"): senha_int = senha.Substring(0, 2) + " " + senha.Substring(2, 2); break;
             }
             if (nome == "NÃO CADASTRADO...")
             {
                 fileName = senha_int+ ", dirija-se ao terminal, " + terminal;
             }
             else
             {
                 fileName = nome + ", senha, " +senha_int + ", dirija-se ao terminal, " + terminal;
             }
             string remoteUri = "https://translate.google.com/translate_tts?tl=pt&q=" + fileName;
             WebClient myWebClient = new WebClient();
             myStringWebResource = remoteUri;
             myWebClient.DownloadFile(myStringWebResource, @"C:\Users\User\Desktop\Tela Principal\audio"+cont+".mp3");
             WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
             wplayer.URL = @"C:\Users\User\Desktop\Tela Principal\audio"+cont+".mp3";
             wplayer.controls.play();
             valid = 1;
             cont++;
         }*/
    }
}
