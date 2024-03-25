﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace e_Biblioteka.ModulAutentifikacija.Models
{
    [Table("LogKretanjePoSistemu")]
    public class LogKretanjePoSistemu
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(korisnik))]
        public int korisnikID { get; set; }
        public KorisnickiNalog korisnik { get; set; }
        public string queryPath { get; set; }
        public string postData { get; set; }
        public DateTime vrijeme { get; set; }
        public string IPadresa { get; set; }
        public string  exceptionMessage { get; set; }
        public bool isException { get; set; }
    }
}
