using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositoriofilme<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void Atualiza(int id, Filme objetof)
		{
			listaFilme[id] = objetof;
		}

		public void Exclui(int id)
		{
			listaFilme[id].Excluir();
		}

		public void Insere(Filme objetof)
		{
			listaFilme.Add(objetof);
		}

		public List<Filme> Lista()
		{
			return listaFilme;
		}

		public int ProximoId()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorId(int id)
		{
			return listaFilme[id];
		}
	}
}