﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.model.Entidades
{
    internal class Aparelho
    {
        private Int64 id_Aparelho {  get; set; }
        private string modelo {  get; set; }

        private Fabricante fabricante;
        private double peso;
        private double largura;
        private double altura;
        private double espessura;
        private double quantidade;
        private decimal preco;
        private decimal desconto;

        public Int64 Id_Aparelho
        {
            get
            {
                return id_Aparelho;
            }
            set
            {
                id_Aparelho = value;
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public Fabricante Fabricante {
            get 
            { 
                return fabricante; 
            } 
            set 
            {
                fabricante = value;
            } 
        }
        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if (value < 0)
                    peso = value;
                else
                {
                    throw new Exception("o valor do peso deve ser maior que zero!");
                }
            }
        }

        public double Largura
        { get{ return largura; } set { largura = value; } }
        public double Altura
        { get { return Altura; } set { Altura = value; } }
        public double Espessura
        {  get { return espessura; } set { espessura = value; } }
        public double Quantidade
        { get { return quantidade; } set { quantidade = value; } }
        public decimal Preco
        { get { return preco; }set { preco = value; } }
        public decimal Desconto
        { get { return desconto; } set { desconto = value; } }
        public override string ToString()
        {
            return Fabricante.Nome + " " + Modelo + " " + Preco.ToString("Bauru, dd /de MMMM de YYYY") + "("+ Quantidade + "em estoque)";
        }


    }
}
