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
    class EquipmentService
    {
        public String getEquipmentInfo()
        {
            model model = new model();
            List<equipment> need = EquipmentMapper.getAllEquipment();
            model.Result = "success";
            model.Code = 200;
            model.Message = "登录成功";
            foreach (var order in need)
            {
                String Jsonobj = JsonConvert.SerializeObject(order);
                model.Values = model.Values + "," + Jsonobj;
            }
            String Jsonobj1 = JsonConvert.SerializeObject(model);
            return Jsonobj1;
        }
        public String setEquipment(equipment equipment)
        {
            model model = new model();
            if (EquipmentMapper.IntoEquipment(equipment))
            {
                
                model.Result = "success";
                model.Code = 200;
                model.Message = "插入成功";
                model.Values = "";
             }
            else
            {
                model.Result = "fail";
                model.Code = 201;
                model.Message = "插入失败";
                model.Values = "";
            }
            String Jsonobj1 = JsonConvert.SerializeObject(model);
            return Jsonobj1;
        }
        public String updateEquipment(equipment equipment)
        {
            model model = new model();
            if (EquipmentMapper.UpdateEquipment(equipment))
            {

                model.Result = "success";
                model.Code = 200;
                model.Message = "更新成功";
                model.Values = "";
            }
            else
            {
                model.Result = "fail";
                model.Code = 201;
                model.Message = "更新失败";
                model.Values = "";
            }
            String Jsonobj1 = JsonConvert.SerializeObject(model);
            return Jsonobj1;
        }
    }
}
