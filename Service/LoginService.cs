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
    public  class LoginService
    {
        public String Login(String adminname, String adminpasswd)
        {
            model model = new model();
            if (adminpasswd.Equals(AdminMapper.GetpasswordByUsername(adminname)))
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "登录成功";
                model.Values = "";

             }
            else
            {
                model.Result = "false";
                model.Code = 201;
                model.Message = "登录失败";
                model.Values = "";

            }
            String Jsonobj = JsonConvert.SerializeObject(model);
            return Jsonobj;
        }
    }
}
