﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baze_OOP
{
    internal class Animal
    {
        // Incapsulare: field-urile raman private
        string specia;
        double nivelDeEnergie;
        // Daca cream proprietati, acestea au in spate field privat si getter si setter
        public int Varsta { get; protected set; }
        public string Culoare { get; set; }
        // Daca vrem sa modificam ce se intampla la get sau set putem putem face asta, dar trebuie sa cream si fieldul pt proprietate
        public double NivelDeEnergie
        {
            get
            {
                return nivelDeEnergie;
            }
            protected set
            {
                nivelDeEnergie = value;
            }
        }

        public Animal(string specia, string culoare)
        {
            this.specia = specia;
            this.Varsta = 0;
            this.Culoare = culoare;
            this.nivelDeEnergie = 0.7;
        }
        // Incapsulare: getters and setters
        public string GetSpecia()
        {
            return specia;
        }
        public void SetSpecia(string newSpecia)
        {
            specia = newSpecia;
        }
        // Polimorfism: cuc cheie virtual
        public virtual void Hranire(double sursaDeEnergie)
        {
            Console.WriteLine($"{specia} a gasit mancare in valoare de {sursaDeEnergie.ToString("0.00")}");
            nivelDeEnergie += sursaDeEnergie / 2;
        }
        // Polimorfism
        public virtual void Imbatranire(int nrZile)
        {
            if (nrZile < 0)
                return;
            Varsta += nrZile;
            nivelDeEnergie -= 0.1 * nrZile;
        }
    }
}
