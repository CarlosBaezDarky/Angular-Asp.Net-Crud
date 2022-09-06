using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace angularWebApi.Model
{
    public class paymentDetails
    {
        [Key]
        public int paymentDetail_Id { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string CardOwerName { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string CardNumber { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string SecurityCode { get; set; }


    }
}
