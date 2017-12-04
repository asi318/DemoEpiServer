using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoEpiServer
{
    public class DDSFormDataAccessLayer
    {
        public EpiSampleDatabaseEntities db { get; set; }

    public DDSFormDataAccessLayer()
    {
        db = new EpiSampleDatabaseEntities();
    }

    public int AddFormData(tblFormData formObject)
    {
        db.tblFormDatas.Add(formObject);
        db.SaveChanges();
        return formObject.Id;
    }
}
}