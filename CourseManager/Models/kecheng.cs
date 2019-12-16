namespace CourseManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kecheng")]
    public partial class kecheng
    {
        public int Id { get; set; }

        public string CourdeName { get; set; }
    }
}
