namespace Image_App.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class tb1_Image
    {
        public int Id { get; set; }

       
        public string Title { get; set; }

        [DisplayName("Upload Image")]
        public string Image { get; set; }

        [NotMapped]
        public System.Web.HttpPostedFileBase ImageFile { get; set; }
    }
}
