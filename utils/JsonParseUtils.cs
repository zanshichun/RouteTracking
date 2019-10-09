﻿using HelloWorld.model;
using Newtonsoft.Json;

namespace HelloWorld.utils
{
    class JsonParseUtils
    {

        public string JsonParse(string jsonRes)
        {
            // Console.WriteLine(jsonRes);
            IpInfoModel ipinfo = JsonConvert.DeserializeObject<IpInfoModel>(jsonRes);
            //Console.WriteLine(ipifo.code);

            string ipinfoRes = string.Format(" Area:{0}  Local:{1}", ipinfo.data.cuntry, ipinfo.data.local);
            return ipinfoRes;
        }

    }
}
