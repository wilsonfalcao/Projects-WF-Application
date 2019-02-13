using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_senha
{
    public class Efeito_Sonoro
    {
        public Efeito_Sonoro(bool tipo)
        {
            if (tipo = true)
            {
                String caminhoAudio = @"C:\Programa\sinal002.wav";
                System.Media.SoundPlayer s = new System.Media.SoundPlayer(caminhoAudio);
                s.PlaySync();
                s.Stop();
            }
            else
            {
                String caminhoAudio = @"C:\Programa\sinal001.wav";
                System.Media.SoundPlayer s = new System.Media.SoundPlayer(caminhoAudio);
                s.PlaySync();
                s.Stop();
            }
        }
    }
}
