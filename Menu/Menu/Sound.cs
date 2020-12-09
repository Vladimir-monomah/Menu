using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Menu
{
    static class Sound
    {
        static SoundPlayer zvuki_dlya_igry = new SoundPlayer(Properties.Resources.Zvuki_dlya_igry___4_iPlayer_fm_);
        static SoundPlayer Sound8425 = new SoundPlayer(Properties.Resources.Sound8425_Wav_Library_Net_);
        static SoundPlayer zvuk_volshebstva = new SoundPlayer(Properties.Resources.Zvuk_volshebstva___Zvuk_volshebstva_iPlayer_fm_);
        static SoundPlayer _0dbd6cf6363a9a7056c350b7f8e6da8a = new SoundPlayer(Properties.Resources._0dbd6cf6363a9a7056c350b7f8e6da8a);
        static bool soind_enabled = true;

        public static void sound_on()
        {
            soind_enabled = true;

        }
        public static void sound_off()
        {
            soind_enabled = false;

        }

        public static void play_zvuki_dlya_igry()
        {
            if(soind_enabled)
            zvuki_dlya_igry.Play();
        }
        public static void play_Sound8425()
        {
            if (soind_enabled)
                Sound8425.Play();
        }
        public static void play_zvuk_volshebstva()
        {
            if (soind_enabled)
                zvuk_volshebstva.Play();
        }
        public static void play__0dbd6cf6363a9a7056c350b7f8e6da8a()
        {
            if (soind_enabled)
                _0dbd6cf6363a9a7056c350b7f8e6da8a.Play();
        }
    }
}
