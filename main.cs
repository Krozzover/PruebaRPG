using System;
using System.Collections.Generic;
namespace PruebaRPG
{
	

	class Habilidad
	{
		public Dictionary<string,float> tirada;
		public Dictionary<string,float> defensa;
		public Habilidad() {
			tirada = new Dictionary<string,float>();
			defensa = new Dictionary<string,float>();
		}
		
		public float valortotal (Dictionary<string,float> d, Personaje p)
		{
			float total = 0f;
			if (p == null) return 0f;
			foreach (KeyValuePair<string,float> entrada in d)
			{
				total += (entrada.Value * p.getAtributo(entrada.Key));
			}
			return total;
		}
		
		public bool chequea(Personaje origen, Personaje destino) 
		{
			return true;
		}
	}
	
	class Personaje
	{
		Dictionary<string,float> atributos;
		string nombre;
		public Personaje(string s, float f, float d, float a)
		{
			atributos = new Dictionary<string,float>();
			nombre = s;
			atributos["Fuerza"] = f;
			atributos["Destreza"] = d;
			atributos["Agilidad"] = a;
		}
		public float getAtributo(string n) {
			if (atributos.ContainsKey(n))
				return atributos[n];
			else
				return 0f;
		}
		
	}
	
    class Principal
    {
        static void Main() 
        {
            Personaje pj = new Personaje("Juan",15f,8f,12f);
			Habilidad sk = new Habilidad();
			sk.tirada["Fuerza"]=1.0f;
			sk.tirada["Destreza"]=1.5f;
			Console.WriteLine(sk.valortotal(sk.tirada,pj));

        }
		
    }
}
