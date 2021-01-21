using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TelephoneDirectory.Class
{
    [Table("tblTPD")]

    public class TelePhoneDirectory
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Firstname { get; set; }

        [Required, StringLength(255)]
        public string Lastname { get; set; }

        [Required, StringLength(255)]
        public string Telephone { get; set; }

        [Required, StringLength(255)]
        public string City { get; set; }

        [Required, StringLength(255)]
        public string Gender { get; set; }
    }
}
