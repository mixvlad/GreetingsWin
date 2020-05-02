using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace Greetings
{
    public static class GreetingsLoader
    {
        public static async Task<List<GreetingsListModel>> LoadGreetingsAsync()
        {
            try
            {
                var assembly = typeof(GreetingsLoader).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream("greetings.json");

                var serializer = new DataContractJsonSerializer(typeof(List<GreetingsListModel>),
                                     new DataContractJsonSerializerSettings
                    {
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd"),
                    });
                return (List<GreetingsListModel>)serializer.ReadObject(stream);
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось загрузить главный файл поздравлений!", e);
            }
        }
    }
}

