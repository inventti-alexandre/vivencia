﻿using System;
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
        public static string ConverterParaString(Image imagem)
        {
            MemoryStream memoria = new MemoryStream();

            imagem.Save(memoria, imagem.RawFormat);
            byte[] imageBytes = memoria.ToArray();

            string imagemEmTexto = Convert.ToBase64String(imageBytes);
            return imagemEmTexto;

        }

        public static Image ConverterParaImagem(string imagemEmTexto)
        {
            byte[] bytes = Convert.FromBase64String(imagemEmTexto);

            Image imagem = Image.FromStream(new MemoryStream(bytes));
            return imagem;
        }
        //public static string ConverterParaString(Image imagem)
        //{
        //    MemoryStream memoria = new MemoryStream();

        //    imagem.Save(memoria, imagem.RawFormat);
        //    byte[] imageBytes = memoria.ToArray();

        //    string imgage = Convert.ToBase64CharArray(imageBytes);

        //    return imgage;
        //}

        //public static Image ConverterParaImagem(byte[] imagemEmTexto)
        //{
        //    Image imagem = Image.FromStream(new MemoryStream(imagemEmTexto));
        //    return imagem;
        //}
    }
}
