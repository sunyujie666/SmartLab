using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLab.dao;
using SmartLab.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace SmartLab.Service
{
    class EntranceService
    {
        public String getEntryList()
        {
            model model = new model();
            List<entry_power> need = Entry_powerMapper.getEntryList();

            if (need == null)
            {
                model.Result = "failed";
                model.Code = 201;
                model.Message = "获取失败";
                model.Values = "";
                String Jsonobj = JsonConvert.SerializeObject(model);
                return Jsonobj;
            }

            model.Result = "success";
            model.Code = 200;
            model.Message = "获取成功";
            model.Values = "value:[{";

            foreach (var order in need)
            {
                String Jsonobj = JsonConvert.SerializeObject(order);
                model.Values = model.Values + "," + Jsonobj;
            }
            model.Values = model.Values + "}]";

            String Jsonobj1 = JsonConvert.SerializeObject(model);
            //MessageBox.Show(Jsonobj1);
            return Jsonobj1;
        }
        public string setEntryUser(String name, String phone, String user_face, String figer_print, String adminid)
        {
            model model = new model();
            if (!Entry_powerMapper.setEntryUser(name, phone, user_face, figer_print, adminid))
            {
                model.Result = "failed";
                model.Code = 201;
                model.Message = "设置失败";
                model.Values = "value:[{";

                String Jsonobj = JsonConvert.SerializeObject(model);
                MessageBox.Show(Jsonobj);
                return Jsonobj;
            }
            else
            {

                model.Result = "success";
                model.Code = 200;
                model.Message = "设置成功";
                model.Values = "";

                String Jsonobj1 = JsonConvert.SerializeObject(model);
                MessageBox.Show(Jsonobj1);
                return Jsonobj1;
            }
            
        }

        public string deleteEntryUser(int epid)
        {
            model model = new model();
            if (!Entry_powerMapper.deleteEntryUser(epid))
            {
                model.Result = "failed";
                model.Code = 201;
                model.Message = "删除失败";
                model.Values = "";

                String Jsonobj = JsonConvert.SerializeObject(model);
                //MessageBox.Show(Jsonobj);
                return Jsonobj;
            }
            else
            {

                model.Result = "success";
                model.Code = 200;
                model.Message = "删除成功";
                model.Values = "";

                String Jsonobj1 = JsonConvert.SerializeObject(model);
                //MessageBox.Show(Jsonobj1);
                return Jsonobj1;
            }

        }

        public string adminPsdUpdate(string adminid,String psd)
        {
            model model = new model();
            if (!Entry_powerMapper.adminPsdUpdate(adminid,psd))
            {
                model.Result = "failed";
                model.Code = 201;
                model.Message = "修改失败";
                model.Values = "";

                String Jsonobj = JsonConvert.SerializeObject(model);
                //MessageBox.Show(Jsonobj);
                return Jsonobj;
            }
            else
            {

                model.Result = "success";
                model.Code = 200;
                model.Message = "修改成功";
                model.Values = "";

                String Jsonobj1 = JsonConvert.SerializeObject(model);
                //MessageBox.Show(Jsonobj1);
                return Jsonobj1;
            }
        }

    }
}
