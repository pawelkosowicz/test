﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kino.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Tytuł { get; set; }
        public int Rok { get; set; }
        public string Reżyser { get; set; }
        public string Opis { get; set; }
        public string Zdjecie { get; set; }
        public string Wiek { get; set; }
        public string Czas { get; set; }
        public string Zdjeciedrugie { get; set; }
        public string Produkcja { get; set; }
        public string Obsada { get; set; }
        public string Gatunek { get; set; }

        // public int SeansId { get; set; }
        // public virtual Seans Seans { get; set; }
    }
}