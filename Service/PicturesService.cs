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
    public class PicturesService
    {
        public String updatePicture(String pictureUrl, String type)
        {
            model model = new model();
            if (PictureMapper.updatePicture(pictureUrl, type))
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "上传成功";
                model.Values = "";

            }
            else
            {
                model.Result = "false";
                model.Code = 201;
                model.Message = "上传失败";
                model.Values = "";

            }
            String Jsonobj = JsonConvert.SerializeObject(model);
            MessageBox.Show(Jsonobj);
            return Jsonobj;
        }


        public String setPictureType(int pid, String type)
        {
            model model = new model();
            if (PictureMapper.setPictureType(pid,type))
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "修改成功";
                model.Values = "";

            }
            else
            {
                model.Result = "false";
                model.Code = 201;
                model.Message = "修改失败";
                model.Values = "";

            }
            String Jsonobj = JsonConvert.SerializeObject(model);
            return Jsonobj;
        }


        public String deletePicture(int pid)
        {
            model model = new model();
            if (PictureMapper.deletePicture(pid))
            {
                model.Result = "success";
                model.Code = 200;
                model.Message = "修改成功";
                model.Values = "";

            }
            else
            {
                model.Result = "false";
                model.Code = 201;
                model.Message = "修改失败";
                model.Values = "";

            }
            String Jsonobj = JsonConvert.SerializeObject(model);
            return Jsonobj;
        }

        public String getAllPicture()
        {
            model model = new model();
            List<picture> work = PictureMapper.getallPicture();
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
            String obj= JsonConvert.SerializeObject(model);
            return obj;
        }



       

    }
}
