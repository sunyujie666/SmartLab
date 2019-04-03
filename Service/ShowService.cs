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
    public class ShowService
    {
        /*public String getLabinfo() { }*/
        public String getClassinfo()
        {
            model model = new model();
            List<orderinfo> need = OrderinFoMapper.getOrderinfo();
            if (need == null)
            {
                model.Result = "failed";
                model.Code = 201;
                model.Message = "";
                model.Values = "";
                String Jsonobj = JsonConvert.SerializeObject(model);
                return Jsonobj;
            }
            model.Result = "success";
            model.Code = 200;
            model.Message = "";
            model.Values = "timetable:[{";

            foreach(var order in need)
            {
                orderinfo oo=order;
                int[] timeid = new int[13];
                timeid = getNumbersFromSring(oo.Timeid1);
                int i=0;
                while (timeid[i] != -1)
                {
                    MessageBox.Show(timeid[i].ToString());
                    ordertime od = OrderTimeMapper.getTimebyTimeid(timeid[i]);
                    MessageBox.Show(od.ToString());
                    String Jsonobj = JsonConvert.SerializeObject(od);
                    model.Values = model.Values + "," + Jsonobj;
                    i++;
                }

            }
            model.Values = model.Values + "}]";

            model.Values =model.Values+ " , "+"orderClassInfo:[{";
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

        public String getOrderHistoryByDate(DateTime starttime, DateTime endtime)
        {
            model model = new model();
            List<orderinfo> work = OrderinFoMapper.getOrderHistoryByDate(starttime, endtime);
            if (work != null)
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "";
                String Jsonobj = JsonConvert.SerializeObject(work);
                model.Values = Jsonobj;

            }
            else
            {
                model.Result = "false";
                model.Code = 201;
                model.Message = "";
                model.Values = "";

            }
            String obj = JsonConvert.SerializeObject(model);
            return obj;
        }

        public int[] getNumbersFromSring(string s)
        {
            int[] result=new int[13];
            for (int i = 0; i < 13; i++)
                result[i] = -1;
            int len=0;
            for (int i = 0; i <= 9; i++)
            { 
                 char c = (char)(i+'0');
                 if (s.Contains(c))
                 { 
                    result[len++]=i;
                 }
            }
            if (s.IndexOf("11")!=-1)
            {
                result[len++] = 11;
            }
            if (s.IndexOf("12") != -1)
            {
                result[len++] = 12;
            }

            return result;
        }

    }

    
}
