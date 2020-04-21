using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace VisitMyCities.DataModel
{
    public class Parameters
    {
        public string dataset { get; set; }
        public string timezone { get; set; }
        public int rows { get; set; }
        public string format { get; set; }
        public List<string> facet { get; set; }
    }

    public class Fields
    {
        public string commune { get; set; }
        public string stat { get; set; }
        public string insee { get; set; }
        public string scle { get; set; }
        public string dmaj { get; set; }
        public string @ref { get; set; }
        public string prot { get; set; }
        public string adrs { get; set; }
        public List<double> coordonnees_ban { get; set; }
        public string ppro { get; set; }
        public string hist { get; set; }
        public string wadrs { get; set; }
        public string @base { get; set; }
        public string ploc { get; set; }
        public string dpro { get; set; }
        public string code_departement { get; set; }
        public string tico { get; set; }
        public string pop_date { get; set; }
        public string reg { get; set; }
        public string wcom { get; set; }
        public string dpt_lettre { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Record
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Fields fields { get; set; }
        public Geometry geometry { get; set; }
        public DateTime record_timestamp { get; set; }
    }

    public class Facet
    {
        public int count { get; set; }
        public string path { get; set; }
        public string state { get; set; }
        public string name { get; set; }
    }

    public class FacetGroup
    {
        public List<Facet> facets { get; set; }
        public string name { get; set; }
    }

    public class RootObject
    {
        public int nhits { get; set; }
        public Parameters parameters { get; set; }
        public Record[] records { get; set; }
        public List<FacetGroup> facet_groups { get; set; }
    }

    public static class GouvApi
    {
        public static async void DeserializeJson()
        {
            //string json = GetUrlToString("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=xxxxxxxxxxxxxxxxxxxxx&steamids=xxxxxxxxxxxxxxx");
            //Console.WriteLine(json);
            //EncapsulatedResponse info = JsonConvert.DeserializeObject<EncapsulatedResponse>(json);

            //using (StreamWriter file = File.CreateText(@"c:\test.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, info);
            //}

            Uri uri = new Uri("https://data.culture.gouv.fr/api/records/1.0/search/?dataset=liste-des-immeubles-proteges-au-titre-des-monuments-historiques&facet=reg&facet=dpt_lettre&facet=commune&refine.commune=Strasbourg");


            using (HttpClient client = new HttpClient())
            {
                RootObject monuments = new RootObject();
                
                var response = await client.GetAsync(uri);
                var content = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<RootObject>(content);
                
            }
            
        }
    }
}