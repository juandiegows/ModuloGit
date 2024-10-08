﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    /// <summary>
    /// Este clases sirve de plantilla para devolver la respuesta del servidor
    /// </summary>
   public class Respuesta<T>
    {
        public string Mensaje {set;get;}
        public T Objeto { set;get; }
      
      

        public async static Task<Respuesta<T>> GetRespuesta<T> (HttpResponseMessage httpResponseMessage) 
        {
            string mensaje = httpResponseMessage.StatusCode.ToString();
            T objeto = default(T);
            try
            {

             objeto   = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());

            }
            catch (Exception)
            {
                objeto = default(T);
            }
            return new Respuesta<T>() { Mensaje = mensaje,Objeto = objeto };
        }
    }
}
