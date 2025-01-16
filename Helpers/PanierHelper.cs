using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

public static class PanierHelper
{
    public static void AjouterAuPanier(this ISession session, string key, object value)
    {
        session.SetString(key, JsonConvert.SerializeObject(value));
    }

    public static T ObtenirDuPanier<T>(this ISession session, string key)
    {
        var data = session.GetString(key);
        return data == null ? default : JsonConvert.DeserializeObject<T>(data);
    }
}
