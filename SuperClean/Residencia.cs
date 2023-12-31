﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperClean
{
    public class Home
    {
        public string  Name { get; private set; }
        public List<Piso> Pisos { get; private set; }
        public Home(string name, List<Piso> pisos)
        {
            Name = name;
            Pisos = pisos;
        }
    }
    public class Residencia
    {
        private string name;
        private DateTime lastUpdated;
        private List<Piso> pisos;

        public Residencia(string name) 
        {
            this.name = name;
            lastUpdated = DateTime.Now;
            pisos = new List<Piso>() ;
        }

        // Metodo para obter a residencia associada a um utilizador
        public Home GetResidencia() 
        {
            return Home(name, pisos);
        }

        private Home Home(string name, List<Piso> pisos)
        {
            throw new NotImplementedException();
        }


        // metedo para adicionar um novo piso a residência
        public void AdicionarPiso(string nomePiso) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePiso);
            if (piso != null) { throw new ArgumentException("piso já existente na residência"); }

            pisos.Add(new Piso(nomePiso));
            lastUpdated = DateTime.Now;
        }

        // método para editar o nome de um piso existente
        public void EditarNomePiso(string nomePisoAntigo, string nomePisoNovo) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePisoAntigo);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na residência"); }

            piso.setName(nomePisoNovo);
            lastUpdated = DateTime.Now;
        }

        // método para apagar um piso na residência 
        public void ApagarPiso(string nomePiso) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            pisos.Remove(piso);
            lastUpdated = DateTime.Now;
        }

        // Método Para adicionar uma nova divisão ao piso 
        public void AdicionarDivisao(string nomePiso, string nomeDivisao, int cleanTime, int cleanInterval) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.AdicionarDivisao(nomeDivisao, cleanTime, cleanInterval);
            lastUpdated = DateTime.Now;
        }

        // método para editar uma divisão existente no piso
        public void EditarDivisao(string nomePiso, string nomeDivisaoAntigo, string nomeDivisaoNovo, int cleanTime, int cleanIntervalo) 
        {
            Piso piso = pisos.Find(p => p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.editarDivisao(nomeDivisaoAntigo, nomeDivisaoNovo, cleanTime, cleanIntervalo);
            lastUpdated = DateTime.Now;
        }

        // metodo para apagar uma divisao num piso
        public void ApagarDivisao(string nomePiso, string nomeDivisao) 
        {
            Piso piso = pisos.Find(p=> p.getName() == nomePiso);
            if (piso == null) { throw new ArgumentException("piso não encontrado na Residência"); }
            piso.ApagarDivisao(nomeDivisao);
            lastUpdated= DateTime.Now;
        }

        // Método para marcar a limpeza de uma divisao num piso da residência
        public void MarcarLimpeza(string nomePiso, string nomeDivisao) 
        {
            Piso piso = pisos.Find(p=> p.getName() ==nomePiso);
            if(piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.MarcarLimpeza(nomeDivisao);
            lastUpdated= DateTime.Now;
        }

        //Método para Remover a marcação de Limpeza de uma divisão num piso da Residencia
        public void RemoverLimpeza(string nomePiso, string nomeDivisao)
        {
            Piso piso = pisos.Find(p=> p.getName() == nomePiso); 
            if(piso == null) { throw new ArgumentException("Piso não encontrado na Residência"); }
            piso.RemoverLimpeza(nomeDivisao); 
            lastUpdated= DateTime.Now;
        }

        // Método para visualizar a arvore divisões da residência
        public string VisualizarArvoreDivisoes()
        {
            if (pisos.Count == 0)
            {
                return "Não existe Pisos na Residência";
            }

            string arvore = $"Residência de {name}:\n";
            foreach(Piso piso in pisos)
            {
                arvore += piso.VisualizarArvoreDivisoes(1); //começar com o nivel 1 de identação
            }

            return arvore;
        }

        public void setName(string name) 
        { 
            this.name = name;
        }

        public string getName() { return this.name; }

        public void setLastUpdated(DateTime lastUpdate) 
        {
            this.lastUpdated = lastUpdate; 
        }
        
        public void setPisos(List<Piso> pisos) 
        { 
            this.pisos = pisos;
        }
        public List<Piso> getPisos() {  return pisos; }
    }
}
