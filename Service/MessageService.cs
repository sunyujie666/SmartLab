using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLab.dao;
using SmartLab.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SmartLab.Service
{
    public class MessageService
    {
        public String doorOpen(String need)
        {
            model model = new model();
            if (Entry_powerMapper.doorOpen(need))
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "门锁已打开";
                model.Values = "";
            }
            String Jsonobj = JsonConvert.SerializeObject(model);
            return Jsonobj;
        }
    }
}