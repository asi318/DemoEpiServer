using DemoEpiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoEpiServer.Business
{
    public class DDSFormDBManager
    {
        public DDSFormDataAccessLayer dbAccess { get; set; }
        public DDSFormDBManager()
        {
            dbAccess = new DDSFormDataAccessLayer();
        }

        internal int SaveData(DDSFormModel dDSFormModel)
        {
            tblFormData tblFormDataObject = new tblFormData()
            {
                Email = dDSFormModel.Email,
                Name = dDSFormModel.Name
            };
            return dbAccess.AddFormData(tblFormDataObject);
        }
    }
}