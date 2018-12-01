using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo3.App.Plugin
{
    static class ImagemPlugin
    {
        public static byte[] ConverterParaString(Image imagem)
        {
            MemoryStream memoria = new MemoryStream();

            imagem.Save(memoria, imagem.RawFormat);
            byte[] imageBytes = memoria.ToArray();

            return imageBytes;

        }

        public static Image ConverterParaImagem(byte[] imagemEmTexto)
        {
            Image imagem = Image.FromStream(new MemoryStream(imagemEmTexto));
            return imagem;
        }
    }
}
